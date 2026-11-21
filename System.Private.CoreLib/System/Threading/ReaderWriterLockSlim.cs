using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x02000402 RID: 1026
	public class ReaderWriterLockSlim : IDisposable
	{
		// Token: 0x060040E9 RID: 16617 RVA: 0x000D846B File Offset: 0x000D666B
		private void InitializeThreadCounts()
		{
			this._upgradeLockOwnerId = -1;
			this._writeLockOwnerId = -1;
		}

		// Token: 0x060040EA RID: 16618 RVA: 0x000D847B File Offset: 0x000D667B
		public ReaderWriterLockSlim() : this(LockRecursionPolicy.NoRecursion)
		{
		}

		// Token: 0x060040EB RID: 16619 RVA: 0x000D8484 File Offset: 0x000D6684
		public ReaderWriterLockSlim(LockRecursionPolicy recursionPolicy)
		{
			if (recursionPolicy == LockRecursionPolicy.SupportsRecursion)
			{
				this._fIsReentrant = true;
			}
			this.InitializeThreadCounts();
			this._waiterStates = ReaderWriterLockSlim.WaiterStates.NoWaiters;
			this._lockID = Interlocked.Increment(ref ReaderWriterLockSlim.s_nextLockID);
		}

		// Token: 0x17000BC3 RID: 3011
		// (get) Token: 0x060040EC RID: 16620 RVA: 0x000D84B4 File Offset: 0x000D66B4
		// (set) Token: 0x060040ED RID: 16621 RVA: 0x000D84C1 File Offset: 0x000D66C1
		private bool HasNoWaiters
		{
			get
			{
				return (this._waiterStates & ReaderWriterLockSlim.WaiterStates.NoWaiters) > ReaderWriterLockSlim.WaiterStates.None;
			}
			set
			{
				if (value)
				{
					this._waiterStates |= ReaderWriterLockSlim.WaiterStates.NoWaiters;
					return;
				}
				this._waiterStates &= ~ReaderWriterLockSlim.WaiterStates.NoWaiters;
			}
		}

		// Token: 0x060040EE RID: 16622 RVA: 0x000D84E7 File Offset: 0x000D66E7
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool IsRWEntryEmpty(ReaderWriterCount rwc)
		{
			return rwc.lockID == 0L || (rwc.readercount == 0 && rwc.writercount == 0 && rwc.upgradecount == 0);
		}

		// Token: 0x060040EF RID: 16623 RVA: 0x000D850E File Offset: 0x000D670E
		private bool IsRwHashEntryChanged(ReaderWriterCount lrwc)
		{
			return lrwc.lockID != this._lockID;
		}

		// Token: 0x060040F0 RID: 16624 RVA: 0x000D8524 File Offset: 0x000D6724
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ReaderWriterCount GetThreadRWCount(bool dontAllocate)
		{
			ReaderWriterCount next = ReaderWriterLockSlim.t_rwc;
			ReaderWriterCount readerWriterCount = null;
			while (next != null)
			{
				if (next.lockID == this._lockID)
				{
					return next;
				}
				if (!dontAllocate && readerWriterCount == null && ReaderWriterLockSlim.IsRWEntryEmpty(next))
				{
					readerWriterCount = next;
				}
				next = next.next;
			}
			if (dontAllocate)
			{
				return null;
			}
			if (readerWriterCount == null)
			{
				readerWriterCount = new ReaderWriterCount();
				readerWriterCount.next = ReaderWriterLockSlim.t_rwc;
				ReaderWriterLockSlim.t_rwc = readerWriterCount;
			}
			readerWriterCount.lockID = this._lockID;
			return readerWriterCount;
		}

		// Token: 0x060040F1 RID: 16625 RVA: 0x000D8591 File Offset: 0x000D6791
		public void EnterReadLock()
		{
			this.TryEnterReadLock(-1);
		}

		// Token: 0x060040F2 RID: 16626 RVA: 0x000D859B File Offset: 0x000D679B
		public bool TryEnterReadLock(TimeSpan timeout)
		{
			return this.TryEnterReadLock(new ReaderWriterLockSlim.TimeoutTracker(timeout));
		}

		// Token: 0x060040F3 RID: 16627 RVA: 0x000D85A9 File Offset: 0x000D67A9
		public bool TryEnterReadLock(int millisecondsTimeout)
		{
			return this.TryEnterReadLock(new ReaderWriterLockSlim.TimeoutTracker(millisecondsTimeout));
		}

		// Token: 0x060040F4 RID: 16628 RVA: 0x000D85B7 File Offset: 0x000D67B7
		private bool TryEnterReadLock(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			return this.TryEnterReadLockCore(timeout);
		}

		// Token: 0x060040F5 RID: 16629 RVA: 0x000D85C0 File Offset: 0x000D67C0
		private bool TryEnterReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			ObjectDisposedException.ThrowIf(this._fDisposed, this);
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			ReaderWriterCount threadRWCount;
			if (!this._fIsReentrant)
			{
				if (currentManagedThreadId == this._writeLockOwnerId)
				{
					throw new LockRecursionException(SR.LockRecursionException_ReadAfterWriteNotAllowed);
				}
				this._spinLock.Enter(ReaderWriterLockSlim.EnterSpinLockReason.EnterAnyRead);
				threadRWCount = this.GetThreadRWCount(false);
				if (threadRWCount.readercount > 0)
				{
					this._spinLock.Exit();
					throw new LockRecursionException(SR.LockRecursionException_RecursiveReadNotAllowed);
				}
				if (currentManagedThreadId == this._upgradeLockOwnerId)
				{
					threadRWCount.readercount++;
					this._owners += 1U;
					this._spinLock.Exit();
					return true;
				}
			}
			else
			{
				this._spinLock.Enter(ReaderWriterLockSlim.EnterSpinLockReason.EnterAnyRead);
				threadRWCount = this.GetThreadRWCount(false);
				if (threadRWCount.readercount > 0)
				{
					threadRWCount.readercount++;
					this._spinLock.Exit();
					return true;
				}
				if (currentManagedThreadId == this._upgradeLockOwnerId)
				{
					threadRWCount.readercount++;
					this._owners += 1U;
					this._spinLock.Exit();
					this._fUpgradeThreadHoldingRead = true;
					return true;
				}
				if (currentManagedThreadId == this._writeLockOwnerId)
				{
					threadRWCount.readercount++;
					this._owners += 1U;
					this._spinLock.Exit();
					return true;
				}
			}
			bool flag = true;
			int num = 0;
			while (this._owners >= 268435454U)
			{
				if (timeout.IsExpired)
				{
					this._spinLock.Exit();
					return false;
				}
				if (num < 20 && this.ShouldSpinForEnterAnyRead())
				{
					this._spinLock.Exit();
					num++;
					ReaderWriterLockSlim.SpinWait(num);
					this._spinLock.Enter(ReaderWriterLockSlim.EnterSpinLockReason.EnterAnyRead);
					if (this.IsRwHashEntryChanged(threadRWCount))
					{
						threadRWCount = this.GetThreadRWCount(false);
					}
				}
				else if (this._readEvent == null)
				{
					this.LazyCreateEvent(ref this._readEvent, ReaderWriterLockSlim.EnterLockType.Read);
					if (this.IsRwHashEntryChanged(threadRWCount))
					{
						threadRWCount = this.GetThreadRWCount(false);
					}
				}
				else
				{
					flag = this.WaitOnEvent(this._readEvent, ref this._numReadWaiters, timeout, ReaderWriterLockSlim.EnterLockType.Read);
					if (!flag)
					{
						return false;
					}
					if (this.IsRwHashEntryChanged(threadRWCount))
					{
						threadRWCount = this.GetThreadRWCount(false);
					}
				}
			}
			this._owners += 1U;
			threadRWCount.readercount++;
			this._spinLock.Exit();
			return flag;
		}

		// Token: 0x060040F6 RID: 16630 RVA: 0x000D87FF File Offset: 0x000D69FF
		public void EnterWriteLock()
		{
			this.TryEnterWriteLock(-1);
		}

		// Token: 0x060040F7 RID: 16631 RVA: 0x000D8809 File Offset: 0x000D6A09
		public bool TryEnterWriteLock(TimeSpan timeout)
		{
			return this.TryEnterWriteLock(new ReaderWriterLockSlim.TimeoutTracker(timeout));
		}

		// Token: 0x060040F8 RID: 16632 RVA: 0x000D8817 File Offset: 0x000D6A17
		public bool TryEnterWriteLock(int millisecondsTimeout)
		{
			return this.TryEnterWriteLock(new ReaderWriterLockSlim.TimeoutTracker(millisecondsTimeout));
		}

		// Token: 0x060040F9 RID: 16633 RVA: 0x000D8825 File Offset: 0x000D6A25
		private bool TryEnterWriteLock(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			return this.TryEnterWriteLockCore(timeout);
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x000D8830 File Offset: 0x000D6A30
		private bool TryEnterWriteLockCore(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			ObjectDisposedException.ThrowIf(this._fDisposed, this);
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			bool flag = false;
			ReaderWriterCount threadRWCount;
			if (!this._fIsReentrant)
			{
				if (currentManagedThreadId == this._writeLockOwnerId)
				{
					throw new LockRecursionException(SR.LockRecursionException_RecursiveWriteNotAllowed);
				}
				ReaderWriterLockSlim.EnterSpinLockReason reason;
				if (currentManagedThreadId == this._upgradeLockOwnerId)
				{
					flag = true;
					reason = ReaderWriterLockSlim.EnterSpinLockReason.UpgradeToWrite;
				}
				else
				{
					reason = ReaderWriterLockSlim.EnterSpinLockReason.EnterWrite;
				}
				this._spinLock.Enter(reason);
				threadRWCount = this.GetThreadRWCount(true);
				if (threadRWCount != null && threadRWCount.readercount > 0)
				{
					this._spinLock.Exit();
					throw new LockRecursionException(SR.LockRecursionException_WriteAfterReadNotAllowed);
				}
			}
			else
			{
				ReaderWriterLockSlim.EnterSpinLockReason reason2;
				if (currentManagedThreadId == this._writeLockOwnerId)
				{
					reason2 = ReaderWriterLockSlim.EnterSpinLockReason.EnterRecursiveWrite;
				}
				else if (currentManagedThreadId == this._upgradeLockOwnerId)
				{
					reason2 = ReaderWriterLockSlim.EnterSpinLockReason.UpgradeToWrite;
				}
				else
				{
					reason2 = ReaderWriterLockSlim.EnterSpinLockReason.EnterWrite;
				}
				this._spinLock.Enter(reason2);
				threadRWCount = this.GetThreadRWCount(false);
				if (currentManagedThreadId == this._writeLockOwnerId)
				{
					threadRWCount.writercount++;
					this._spinLock.Exit();
					return true;
				}
				if (currentManagedThreadId == this._upgradeLockOwnerId)
				{
					flag = true;
				}
				else if (threadRWCount.readercount > 0)
				{
					this._spinLock.Exit();
					throw new LockRecursionException(SR.LockRecursionException_WriteAfterReadNotAllowed);
				}
			}
			int num = 0;
			while (!this.IsWriterAcquired())
			{
				if (flag)
				{
					uint numReaders = this.GetNumReaders();
					if (numReaders == 1U)
					{
						this.SetWriterAcquired();
					}
					else
					{
						if (numReaders != 2U || threadRWCount == null)
						{
							goto IL_161;
						}
						if (this.IsRwHashEntryChanged(threadRWCount))
						{
							threadRWCount = this.GetThreadRWCount(false);
						}
						if (threadRWCount.readercount <= 0)
						{
							goto IL_161;
						}
						this.SetWriterAcquired();
					}
					IL_21E:
					if (this._fIsReentrant)
					{
						if (this.IsRwHashEntryChanged(threadRWCount))
						{
							threadRWCount = this.GetThreadRWCount(false);
						}
						threadRWCount.writercount++;
					}
					this._spinLock.Exit();
					this._writeLockOwnerId = currentManagedThreadId;
					return true;
				}
				IL_161:
				if (timeout.IsExpired)
				{
					this._spinLock.Exit();
					return false;
				}
				if (num < 20 && this.ShouldSpinForEnterAnyWrite(flag))
				{
					this._spinLock.Exit();
					num++;
					ReaderWriterLockSlim.SpinWait(num);
					this._spinLock.Enter(flag ? ReaderWriterLockSlim.EnterSpinLockReason.UpgradeToWrite : ReaderWriterLockSlim.EnterSpinLockReason.EnterWrite);
				}
				else if (flag)
				{
					if (this._waitUpgradeEvent == null)
					{
						this.LazyCreateEvent(ref this._waitUpgradeEvent, ReaderWriterLockSlim.EnterLockType.UpgradeToWrite);
					}
					else if (!this.WaitOnEvent(this._waitUpgradeEvent, ref this._numWriteUpgradeWaiters, timeout, ReaderWriterLockSlim.EnterLockType.UpgradeToWrite))
					{
						return false;
					}
				}
				else if (this._writeEvent == null)
				{
					this.LazyCreateEvent(ref this._writeEvent, ReaderWriterLockSlim.EnterLockType.Write);
				}
				else if (!this.WaitOnEvent(this._writeEvent, ref this._numWriteWaiters, timeout, ReaderWriterLockSlim.EnterLockType.Write))
				{
					return false;
				}
			}
			this.SetWriterAcquired();
			goto IL_21E;
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x000D8A95 File Offset: 0x000D6C95
		public void EnterUpgradeableReadLock()
		{
			this.TryEnterUpgradeableReadLock(-1);
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x000D8A9F File Offset: 0x000D6C9F
		public bool TryEnterUpgradeableReadLock(TimeSpan timeout)
		{
			return this.TryEnterUpgradeableReadLock(new ReaderWriterLockSlim.TimeoutTracker(timeout));
		}

		// Token: 0x060040FD RID: 16637 RVA: 0x000D8AAD File Offset: 0x000D6CAD
		public bool TryEnterUpgradeableReadLock(int millisecondsTimeout)
		{
			return this.TryEnterUpgradeableReadLock(new ReaderWriterLockSlim.TimeoutTracker(millisecondsTimeout));
		}

		// Token: 0x060040FE RID: 16638 RVA: 0x000D8ABB File Offset: 0x000D6CBB
		private bool TryEnterUpgradeableReadLock(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			return this.TryEnterUpgradeableReadLockCore(timeout);
		}

		// Token: 0x060040FF RID: 16639 RVA: 0x000D8AC4 File Offset: 0x000D6CC4
		private bool TryEnterUpgradeableReadLockCore(ReaderWriterLockSlim.TimeoutTracker timeout)
		{
			ObjectDisposedException.ThrowIf(this._fDisposed, this);
			int currentManagedThreadId = Environment.CurrentManagedThreadId;
			ReaderWriterCount threadRWCount;
			if (!this._fIsReentrant)
			{
				if (currentManagedThreadId == this._upgradeLockOwnerId)
				{
					throw new LockRecursionException(SR.LockRecursionException_RecursiveUpgradeNotAllowed);
				}
				if (currentManagedThreadId == this._writeLockOwnerId)
				{
					throw new LockRecursionException(SR.LockRecursionException_UpgradeAfterWriteNotAllowed);
				}
				this._spinLock.Enter(ReaderWriterLockSlim.EnterSpinLockReason.EnterAnyRead);
				threadRWCount = this.GetThreadRWCount(true);
				if (threadRWCount != null && threadRWCount.readercount > 0)
				{
					this._spinLock.Exit();
					throw new LockRecursionException(SR.LockRecursionException_UpgradeAfterReadNotAllowed);
				}
			}
			else
			{
				this._spinLock.Enter(ReaderWriterLockSlim.EnterSpinLockReason.EnterAnyRead);
				threadRWCount = this.GetThreadRWCount(false);
				if (currentManagedThreadId == this._upgradeLockOwnerId)
				{
					threadRWCount.upgradecount++;
					this._spinLock.Exit();
					return true;
				}
				if (currentManagedThreadId == this._writeLockOwnerId)
				{
					this._owners += 1U;
					this._upgradeLockOwnerId = currentManagedThreadId;
					threadRWCount.upgradecount++;
					if (threadRWCount.readercount > 0)
					{
						this._fUpgradeThreadHoldingRead = true;
					}
					this._spinLock.Exit();
					return true;
				}
				if (threadRWCount.readercount > 0)
				{
					this._spinLock.Exit();
					throw new LockRecursionException(SR.LockRecursionException_UpgradeAfterReadNotAllowed);
				}
			}
			int num = 0;
			while (this._upgradeLockOwnerId != -1 || this._owners >= 268435454U)
			{
				if (timeout.IsExpired)
				{
					this._spinLock.Exit();
					return false;
				}
				if (num < 20 && this.ShouldSpinForEnterAnyRead())
				{
					this._spinLock.Exit();
					num++;
					ReaderWriterLockSlim.SpinWait(num);
					this._spinLock.Enter(ReaderWriterLockSlim.EnterSpinLockReason.EnterAnyRead);
				}
				else if (this._upgradeEvent == null)
				{
					this.LazyCreateEvent(ref this._upgradeEvent, ReaderWriterLockSlim.EnterLockType.UpgradeableRead);
				}
				else if (!this.WaitOnEvent(this._upgradeEvent, ref this._numUpgradeWaiters, timeout, ReaderWriterLockSlim.EnterLockType.UpgradeableRead))
				{
					return false;
				}
			}
			this._owners += 1U;
			this._upgradeLockOwnerId = currentManagedThreadId;
			if (this._fIsReentrant)
			{
				if (this.IsRwHashEntryChanged(threadRWCount))
				{
					threadRWCount = this.GetThreadRWCount(false);
				}
				threadRWCount.upgradecount++;
			}
			this._spinLock.Exit();
			return true;
		}

		// Token: 0x06004100 RID: 16640 RVA: 0x000D8CCC File Offset: 0x000D6ECC
		public void ExitReadLock()
		{
			this._spinLock.Enter(ReaderWriterLockSlim.EnterSpinLockReason.ExitAnyRead);
			ReaderWriterCount threadRWCount = this.GetThreadRWCount(true);
			if (threadRWCount == null || threadRWCount.readercount < 1)
			{
				this._spinLock.Exit();
				throw new SynchronizationLockException(SR.SynchronizationLockException_MisMatchedRead);
			}
			if (this._fIsReentrant)
			{
				if (threadRWCount.readercount > 1)
				{
					threadRWCount.readercount--;
					this._spinLock.Exit();
					return;
				}
				if (Environment.CurrentManagedThreadId == this._upgradeLockOwnerId)
				{
					this._fUpgradeThreadHoldingRead = false;
				}
			}
			this._owners -= 1U;
			threadRWCount.readercount--;
			this.ExitAndWakeUpAppropriateWaiters();
		}

		// Token: 0x06004101 RID: 16641 RVA: 0x000D8D70 File Offset: 0x000D6F70
		public void ExitWriteLock()
		{
			if (!this._fIsReentrant)
			{
				if (Environment.CurrentManagedThreadId != this._writeLockOwnerId)
				{
					throw new SynchronizationLockException(SR.SynchronizationLockException_MisMatchedWrite);
				}
				this._spinLock.Enter(ReaderWriterLockSlim.EnterSpinLockReason.ExitAnyWrite);
			}
			else
			{
				this._spinLock.Enter(ReaderWriterLockSlim.EnterSpinLockReason.ExitAnyWrite);
				ReaderWriterCount threadRWCount = this.GetThreadRWCount(false);
				if (threadRWCount == null)
				{
					this._spinLock.Exit();
					throw new SynchronizationLockException(SR.SynchronizationLockException_MisMatchedWrite);
				}
				if (threadRWCount.writercount < 1)
				{
					this._spinLock.Exit();
					throw new SynchronizationLockException(SR.SynchronizationLockException_MisMatchedWrite);
				}
				threadRWCount.writercount--;
				if (threadRWCount.writercount > 0)
				{
					this._spinLock.Exit();
					return;
				}
			}
			this.ClearWriterAcquired();
			this._writeLockOwnerId = -1;
			this.ExitAndWakeUpAppropriateWaiters();
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x000D8E2C File Offset: 0x000D702C
		public void ExitUpgradeableReadLock()
		{
			if (!this._fIsReentrant)
			{
				if (Environment.CurrentManagedThreadId != this._upgradeLockOwnerId)
				{
					throw new SynchronizationLockException(SR.SynchronizationLockException_MisMatchedUpgrade);
				}
				this._spinLock.Enter(ReaderWriterLockSlim.EnterSpinLockReason.ExitAnyRead);
			}
			else
			{
				this._spinLock.Enter(ReaderWriterLockSlim.EnterSpinLockReason.ExitAnyRead);
				ReaderWriterCount threadRWCount = this.GetThreadRWCount(true);
				if (threadRWCount == null)
				{
					this._spinLock.Exit();
					throw new SynchronizationLockException(SR.SynchronizationLockException_MisMatchedUpgrade);
				}
				if (threadRWCount.upgradecount < 1)
				{
					this._spinLock.Exit();
					throw new SynchronizationLockException(SR.SynchronizationLockException_MisMatchedUpgrade);
				}
				threadRWCount.upgradecount--;
				if (threadRWCount.upgradecount > 0)
				{
					this._spinLock.Exit();
					return;
				}
				this._fUpgradeThreadHoldingRead = false;
			}
			this._owners -= 1U;
			this._upgradeLockOwnerId = -1;
			this.ExitAndWakeUpAppropriateWaiters();
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x000D8EF8 File Offset: 0x000D70F8
		private void LazyCreateEvent([NotNull] ref EventWaitHandle waitEvent, ReaderWriterLockSlim.EnterLockType enterLockType)
		{
			this._spinLock.Exit();
			EventWaitHandle eventWaitHandle = new EventWaitHandle(false, (enterLockType == ReaderWriterLockSlim.EnterLockType.Read) ? EventResetMode.ManualReset : EventResetMode.AutoReset);
			ReaderWriterLockSlim.EnterSpinLockReason reason;
			if (enterLockType > ReaderWriterLockSlim.EnterLockType.UpgradeableRead)
			{
				if (enterLockType != ReaderWriterLockSlim.EnterLockType.Write)
				{
					reason = (ReaderWriterLockSlim.EnterSpinLockReason)11;
				}
				else
				{
					reason = (ReaderWriterLockSlim.EnterSpinLockReason)10;
				}
			}
			else
			{
				reason = ReaderWriterLockSlim.EnterSpinLockReason.Wait;
			}
			this._spinLock.Enter(reason);
			if (waitEvent == null)
			{
				waitEvent = eventWaitHandle;
				return;
			}
			eventWaitHandle.Dispose();
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x000D8F50 File Offset: 0x000D7150
		private bool WaitOnEvent(EventWaitHandle waitEvent, ref uint numWaiters, ReaderWriterLockSlim.TimeoutTracker timeout, ReaderWriterLockSlim.EnterLockType enterLockType)
		{
			ReaderWriterLockSlim.WaiterStates waiterStates = ReaderWriterLockSlim.WaiterStates.None;
			ReaderWriterLockSlim.EnterSpinLockReason reason;
			switch (enterLockType)
			{
			case ReaderWriterLockSlim.EnterLockType.Read:
				break;
			case ReaderWriterLockSlim.EnterLockType.UpgradeableRead:
				waiterStates = ReaderWriterLockSlim.WaiterStates.UpgradeableReadWaiterSignaled;
				break;
			case ReaderWriterLockSlim.EnterLockType.Write:
				waiterStates = ReaderWriterLockSlim.WaiterStates.WriteWaiterSignaled;
				reason = ReaderWriterLockSlim.EnterSpinLockReason.EnterWrite;
				goto IL_25;
			default:
				reason = ReaderWriterLockSlim.EnterSpinLockReason.UpgradeToWrite;
				goto IL_25;
			}
			reason = ReaderWriterLockSlim.EnterSpinLockReason.EnterAnyRead;
			IL_25:
			if (waiterStates != ReaderWriterLockSlim.WaiterStates.None && (this._waiterStates & waiterStates) != ReaderWriterLockSlim.WaiterStates.None)
			{
				this._waiterStates &= ~waiterStates;
			}
			waitEvent.Reset();
			numWaiters += 1U;
			this.HasNoWaiters = false;
			if (this._numWriteWaiters == 1U)
			{
				this.SetWritersWaiting();
			}
			if (this._numWriteUpgradeWaiters == 1U)
			{
				this.SetUpgraderWaiting();
			}
			bool flag = false;
			this._spinLock.Exit();
			try
			{
				flag = waitEvent.WaitOne(timeout.RemainingMilliseconds);
			}
			finally
			{
				this._spinLock.Enter(reason);
				numWaiters -= 1U;
				if (flag && waiterStates != ReaderWriterLockSlim.WaiterStates.None && (this._waiterStates & waiterStates) != ReaderWriterLockSlim.WaiterStates.None)
				{
					this._waiterStates &= ~waiterStates;
				}
				if (this._numWriteWaiters == 0U && this._numWriteUpgradeWaiters == 0U && this._numUpgradeWaiters == 0U && this._numReadWaiters == 0U)
				{
					this.HasNoWaiters = true;
				}
				if (this._numWriteWaiters == 0U)
				{
					this.ClearWritersWaiting();
				}
				if (this._numWriteUpgradeWaiters == 0U)
				{
					this.ClearUpgraderWaiting();
				}
				if (!flag)
				{
					if (enterLockType >= ReaderWriterLockSlim.EnterLockType.Write)
					{
						this.ExitAndWakeUpAppropriateReadWaiters();
					}
					else
					{
						this._spinLock.Exit();
					}
				}
			}
			return flag;
		}

		// Token: 0x06004105 RID: 16645 RVA: 0x000D9094 File Offset: 0x000D7294
		private void ExitAndWakeUpAppropriateWaiters()
		{
			if (this.HasNoWaiters)
			{
				this._spinLock.Exit();
				return;
			}
			this.ExitAndWakeUpAppropriateWaitersPreferringWriters();
		}

		// Token: 0x06004106 RID: 16646 RVA: 0x000D90B0 File Offset: 0x000D72B0
		private void ExitAndWakeUpAppropriateWaitersPreferringWriters()
		{
			uint numReaders = this.GetNumReaders();
			if (this._fIsReentrant && this._numWriteUpgradeWaiters > 0U && this._fUpgradeThreadHoldingRead && numReaders == 2U)
			{
				this._spinLock.Exit();
				this._waitUpgradeEvent.Set();
				return;
			}
			if (numReaders == 1U && this._numWriteUpgradeWaiters > 0U)
			{
				this._spinLock.Exit();
				this._waitUpgradeEvent.Set();
				return;
			}
			if (numReaders == 0U && this._numWriteWaiters > 0U)
			{
				ReaderWriterLockSlim.WaiterStates waiterStates = this._waiterStates & ReaderWriterLockSlim.WaiterStates.WriteWaiterSignaled;
				if (waiterStates == ReaderWriterLockSlim.WaiterStates.None)
				{
					this._waiterStates |= ReaderWriterLockSlim.WaiterStates.WriteWaiterSignaled;
				}
				this._spinLock.Exit();
				if (waiterStates == ReaderWriterLockSlim.WaiterStates.None)
				{
					this._writeEvent.Set();
					return;
				}
			}
			else
			{
				this.ExitAndWakeUpAppropriateReadWaiters();
			}
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x000D9164 File Offset: 0x000D7364
		private void ExitAndWakeUpAppropriateReadWaiters()
		{
			if (this._numWriteWaiters != 0U || this._numWriteUpgradeWaiters != 0U || this.HasNoWaiters)
			{
				this._spinLock.Exit();
				return;
			}
			bool flag = this._numReadWaiters > 0U;
			bool flag2 = this._numUpgradeWaiters != 0U && this._upgradeLockOwnerId == -1;
			if (flag2)
			{
				if ((this._waiterStates & ReaderWriterLockSlim.WaiterStates.UpgradeableReadWaiterSignaled) == ReaderWriterLockSlim.WaiterStates.None)
				{
					this._waiterStates |= ReaderWriterLockSlim.WaiterStates.UpgradeableReadWaiterSignaled;
				}
				else
				{
					flag2 = false;
				}
			}
			this._spinLock.Exit();
			if (flag)
			{
				this._readEvent.Set();
			}
			if (flag2)
			{
				this._upgradeEvent.Set();
			}
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x000D91FA File Offset: 0x000D73FA
		private bool IsWriterAcquired()
		{
			return (this._owners & 3221225471U) == 0U;
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x000D920B File Offset: 0x000D740B
		private void SetWriterAcquired()
		{
			this._owners |= 2147483648U;
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x000D921F File Offset: 0x000D741F
		private void ClearWriterAcquired()
		{
			this._owners &= 2147483647U;
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x000D9233 File Offset: 0x000D7433
		private void SetWritersWaiting()
		{
			this._owners |= 1073741824U;
		}

		// Token: 0x0600410C RID: 16652 RVA: 0x000D9247 File Offset: 0x000D7447
		private void ClearWritersWaiting()
		{
			this._owners &= 3221225471U;
		}

		// Token: 0x0600410D RID: 16653 RVA: 0x000D925B File Offset: 0x000D745B
		private void SetUpgraderWaiting()
		{
			this._owners |= 536870912U;
		}

		// Token: 0x0600410E RID: 16654 RVA: 0x000D926F File Offset: 0x000D746F
		private void ClearUpgraderWaiting()
		{
			this._owners &= 3758096383U;
		}

		// Token: 0x0600410F RID: 16655 RVA: 0x000D9283 File Offset: 0x000D7483
		private uint GetNumReaders()
		{
			return this._owners & 268435455U;
		}

		// Token: 0x06004110 RID: 16656 RVA: 0x000D9291 File Offset: 0x000D7491
		private bool ShouldSpinForEnterAnyRead()
		{
			return this.HasNoWaiters || (this._numWriteWaiters == 0U && this._numWriteUpgradeWaiters == 0U);
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x000D92B0 File Offset: 0x000D74B0
		private bool ShouldSpinForEnterAnyWrite(bool isUpgradeToWrite)
		{
			return isUpgradeToWrite || this._numWriteUpgradeWaiters == 0U;
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x000D92C0 File Offset: 0x000D74C0
		private static void SpinWait(int spinCount)
		{
			if (spinCount < 5 && Environment.ProcessorCount > 1)
			{
				Thread.SpinWait(20 * spinCount);
				return;
			}
			Thread.Sleep(0);
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x000D92DE File Offset: 0x000D74DE
		public void Dispose()
		{
			this.Dispose(true);
		}

		// Token: 0x06004114 RID: 16660 RVA: 0x000D92E8 File Offset: 0x000D74E8
		private void Dispose(bool disposing)
		{
			if (disposing && !this._fDisposed)
			{
				if (this.WaitingReadCount > 0 || this.WaitingUpgradeCount > 0 || this.WaitingWriteCount > 0)
				{
					throw new SynchronizationLockException(SR.SynchronizationLockException_IncorrectDispose);
				}
				if (this.IsReadLockHeld || this.IsUpgradeableReadLockHeld || this.IsWriteLockHeld)
				{
					throw new SynchronizationLockException(SR.SynchronizationLockException_IncorrectDispose);
				}
				if (this._writeEvent != null)
				{
					this._writeEvent.Dispose();
					this._writeEvent = null;
				}
				if (this._readEvent != null)
				{
					this._readEvent.Dispose();
					this._readEvent = null;
				}
				if (this._upgradeEvent != null)
				{
					this._upgradeEvent.Dispose();
					this._upgradeEvent = null;
				}
				if (this._waitUpgradeEvent != null)
				{
					this._waitUpgradeEvent.Dispose();
					this._waitUpgradeEvent = null;
				}
				this._fDisposed = true;
			}
		}

		// Token: 0x17000BC4 RID: 3012
		// (get) Token: 0x06004115 RID: 16661 RVA: 0x000D93BE File Offset: 0x000D75BE
		public bool IsReadLockHeld
		{
			get
			{
				return this.RecursiveReadCount > 0;
			}
		}

		// Token: 0x17000BC5 RID: 3013
		// (get) Token: 0x06004116 RID: 16662 RVA: 0x000D93CC File Offset: 0x000D75CC
		public bool IsUpgradeableReadLockHeld
		{
			get
			{
				return this.RecursiveUpgradeCount > 0;
			}
		}

		// Token: 0x17000BC6 RID: 3014
		// (get) Token: 0x06004117 RID: 16663 RVA: 0x000D93DA File Offset: 0x000D75DA
		public bool IsWriteLockHeld
		{
			get
			{
				return this.RecursiveWriteCount > 0;
			}
		}

		// Token: 0x17000BC7 RID: 3015
		// (get) Token: 0x06004118 RID: 16664 RVA: 0x000D93E8 File Offset: 0x000D75E8
		public LockRecursionPolicy RecursionPolicy
		{
			get
			{
				if (this._fIsReentrant)
				{
					return LockRecursionPolicy.SupportsRecursion;
				}
				return LockRecursionPolicy.NoRecursion;
			}
		}

		// Token: 0x17000BC8 RID: 3016
		// (get) Token: 0x06004119 RID: 16665 RVA: 0x000D93F8 File Offset: 0x000D75F8
		public int CurrentReadCount
		{
			get
			{
				int numReaders = (int)this.GetNumReaders();
				if (this._upgradeLockOwnerId != -1)
				{
					return numReaders - 1;
				}
				return numReaders;
			}
		}

		// Token: 0x17000BC9 RID: 3017
		// (get) Token: 0x0600411A RID: 16666 RVA: 0x000D941C File Offset: 0x000D761C
		public int RecursiveReadCount
		{
			get
			{
				int result = 0;
				ReaderWriterCount threadRWCount = this.GetThreadRWCount(true);
				if (threadRWCount != null)
				{
					result = threadRWCount.readercount;
				}
				return result;
			}
		}

		// Token: 0x17000BCA RID: 3018
		// (get) Token: 0x0600411B RID: 16667 RVA: 0x000D9440 File Offset: 0x000D7640
		public int RecursiveUpgradeCount
		{
			get
			{
				if (this._fIsReentrant)
				{
					int result = 0;
					ReaderWriterCount threadRWCount = this.GetThreadRWCount(true);
					if (threadRWCount != null)
					{
						result = threadRWCount.upgradecount;
					}
					return result;
				}
				if (Environment.CurrentManagedThreadId == this._upgradeLockOwnerId)
				{
					return 1;
				}
				return 0;
			}
		}

		// Token: 0x17000BCB RID: 3019
		// (get) Token: 0x0600411C RID: 16668 RVA: 0x000D947C File Offset: 0x000D767C
		public int RecursiveWriteCount
		{
			get
			{
				if (this._fIsReentrant)
				{
					int result = 0;
					ReaderWriterCount threadRWCount = this.GetThreadRWCount(true);
					if (threadRWCount != null)
					{
						result = threadRWCount.writercount;
					}
					return result;
				}
				if (Environment.CurrentManagedThreadId == this._writeLockOwnerId)
				{
					return 1;
				}
				return 0;
			}
		}

		// Token: 0x17000BCC RID: 3020
		// (get) Token: 0x0600411D RID: 16669 RVA: 0x000D94B7 File Offset: 0x000D76B7
		public int WaitingReadCount
		{
			get
			{
				return (int)this._numReadWaiters;
			}
		}

		// Token: 0x17000BCD RID: 3021
		// (get) Token: 0x0600411E RID: 16670 RVA: 0x000D94BF File Offset: 0x000D76BF
		public int WaitingUpgradeCount
		{
			get
			{
				return (int)this._numUpgradeWaiters;
			}
		}

		// Token: 0x17000BCE RID: 3022
		// (get) Token: 0x0600411F RID: 16671 RVA: 0x000D94C7 File Offset: 0x000D76C7
		public int WaitingWriteCount
		{
			get
			{
				return (int)this._numWriteWaiters;
			}
		}

		// Token: 0x04000DA2 RID: 3490
		private readonly bool _fIsReentrant;

		// Token: 0x04000DA3 RID: 3491
		private ReaderWriterLockSlim.SpinLock _spinLock;

		// Token: 0x04000DA4 RID: 3492
		private uint _numWriteWaiters;

		// Token: 0x04000DA5 RID: 3493
		private uint _numReadWaiters;

		// Token: 0x04000DA6 RID: 3494
		private uint _numWriteUpgradeWaiters;

		// Token: 0x04000DA7 RID: 3495
		private uint _numUpgradeWaiters;

		// Token: 0x04000DA8 RID: 3496
		private ReaderWriterLockSlim.WaiterStates _waiterStates;

		// Token: 0x04000DA9 RID: 3497
		private int _upgradeLockOwnerId;

		// Token: 0x04000DAA RID: 3498
		private int _writeLockOwnerId;

		// Token: 0x04000DAB RID: 3499
		private EventWaitHandle _writeEvent;

		// Token: 0x04000DAC RID: 3500
		private EventWaitHandle _readEvent;

		// Token: 0x04000DAD RID: 3501
		private EventWaitHandle _upgradeEvent;

		// Token: 0x04000DAE RID: 3502
		private EventWaitHandle _waitUpgradeEvent;

		// Token: 0x04000DAF RID: 3503
		private static long s_nextLockID;

		// Token: 0x04000DB0 RID: 3504
		private readonly long _lockID;

		// Token: 0x04000DB1 RID: 3505
		[ThreadStatic]
		private static ReaderWriterCount t_rwc;

		// Token: 0x04000DB2 RID: 3506
		private bool _fUpgradeThreadHoldingRead;

		// Token: 0x04000DB3 RID: 3507
		private uint _owners;

		// Token: 0x04000DB4 RID: 3508
		private bool _fDisposed;

		// Token: 0x02000403 RID: 1027
		private readonly struct TimeoutTracker
		{
			// Token: 0x06004120 RID: 16672 RVA: 0x000D94D0 File Offset: 0x000D76D0
			public TimeoutTracker(TimeSpan timeout)
			{
				this._start = 0;
				long num = (long)timeout.TotalMilliseconds;
				ArgumentOutOfRangeException.ThrowIfLessThan<long>(num, -1L, "timeout");
				ArgumentOutOfRangeException.ThrowIfGreaterThan<long>(num, 2147483647L, "timeout");
				this._total = (int)num;
				if (this._total != -1 && this._total != 0)
				{
					this._start = Environment.TickCount;
				}
			}

			// Token: 0x06004121 RID: 16673 RVA: 0x000D952F File Offset: 0x000D772F
			public TimeoutTracker(int millisecondsTimeout)
			{
				this._start = 0;
				ArgumentOutOfRangeException.ThrowIfLessThan<int>(millisecondsTimeout, -1, "millisecondsTimeout");
				this._total = millisecondsTimeout;
				if (this._total != -1 && this._total != 0)
				{
					this._start = Environment.TickCount;
				}
			}

			// Token: 0x17000BCF RID: 3023
			// (get) Token: 0x06004122 RID: 16674 RVA: 0x000D9568 File Offset: 0x000D7768
			public int RemainingMilliseconds
			{
				get
				{
					if (this._total == -1 || this._total == 0)
					{
						return this._total;
					}
					int num = Environment.TickCount - this._start;
					if (num < 0 || num >= this._total)
					{
						return 0;
					}
					return this._total - num;
				}
			}

			// Token: 0x17000BD0 RID: 3024
			// (get) Token: 0x06004123 RID: 16675 RVA: 0x000D95B1 File Offset: 0x000D77B1
			public bool IsExpired
			{
				get
				{
					return this.RemainingMilliseconds == 0;
				}
			}

			// Token: 0x04000DB5 RID: 3509
			private readonly int _total;

			// Token: 0x04000DB6 RID: 3510
			private readonly int _start;
		}

		// Token: 0x02000404 RID: 1028
		private struct SpinLock
		{
			// Token: 0x06004124 RID: 16676 RVA: 0x000D95BC File Offset: 0x000D77BC
			private static int GetEnterDeprioritizationStateChange(ReaderWriterLockSlim.EnterSpinLockReason reason)
			{
				switch (reason & ReaderWriterLockSlim.EnterSpinLockReason.OperationMask)
				{
				case ReaderWriterLockSlim.EnterSpinLockReason.EnterAnyRead:
					return 0;
				case ReaderWriterLockSlim.EnterSpinLockReason.ExitAnyRead:
					return 1;
				case ReaderWriterLockSlim.EnterSpinLockReason.EnterWrite:
					return 65536;
				default:
					return 65537;
				}
			}

			// Token: 0x17000BD1 RID: 3025
			// (get) Token: 0x06004125 RID: 16677 RVA: 0x000D95F0 File Offset: 0x000D77F0
			private ushort EnterForEnterAnyReadDeprioritizedCount
			{
				get
				{
					return (ushort)((uint)this._enterDeprioritizationState >> 16);
				}
			}

			// Token: 0x17000BD2 RID: 3026
			// (get) Token: 0x06004126 RID: 16678 RVA: 0x000D95FC File Offset: 0x000D77FC
			private ushort EnterForEnterAnyWriteDeprioritizedCount
			{
				get
				{
					return (ushort)this._enterDeprioritizationState;
				}
			}

			// Token: 0x06004127 RID: 16679 RVA: 0x000D9605 File Offset: 0x000D7805
			private bool IsEnterDeprioritized(ReaderWriterLockSlim.EnterSpinLockReason reason)
			{
				switch (reason)
				{
				case ReaderWriterLockSlim.EnterSpinLockReason.EnterAnyRead:
					return this.EnterForEnterAnyReadDeprioritizedCount > 0;
				default:
					return false;
				case ReaderWriterLockSlim.EnterSpinLockReason.EnterWrite:
					return this.EnterForEnterAnyWriteDeprioritizedCount > 0;
				case ReaderWriterLockSlim.EnterSpinLockReason.UpgradeToWrite:
					return this.EnterForEnterAnyWriteDeprioritizedCount > 1;
				}
			}

			// Token: 0x06004128 RID: 16680 RVA: 0x000D963C File Offset: 0x000D783C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private bool TryEnter()
			{
				return !Interlocked.Exchange<bool>(ref this._isLocked, true);
			}

			// Token: 0x06004129 RID: 16681 RVA: 0x000D964D File Offset: 0x000D784D
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Enter(ReaderWriterLockSlim.EnterSpinLockReason reason)
			{
				if (!this.TryEnter())
				{
					this.EnterSpin(reason);
				}
			}

			// Token: 0x0600412A RID: 16682 RVA: 0x000D9660 File Offset: 0x000D7860
			private void EnterSpin(ReaderWriterLockSlim.EnterSpinLockReason reason)
			{
				int enterDeprioritizationStateChange = ReaderWriterLockSlim.SpinLock.GetEnterDeprioritizationStateChange(reason);
				if (enterDeprioritizationStateChange != 0)
				{
					Interlocked.Add(ref this._enterDeprioritizationState, enterDeprioritizationStateChange);
				}
				uint num = 0U;
				for (;;)
				{
					if ((num < 10U || (num - 10U) % 2U != 0U) && !Environment.IsSingleProcessor)
					{
						Thread.SpinWait((int)(20U * ((num < 10U) ? (num + 1U) : 10U)));
					}
					else
					{
						Thread.Sleep(0);
					}
					if (!this.IsEnterDeprioritized(reason))
					{
						if (!this._isLocked && this.TryEnter())
						{
							break;
						}
					}
					else if (num >= 70U)
					{
						reason |= ReaderWriterLockSlim.EnterSpinLockReason.Wait;
						num = uint.MaxValue;
					}
					num += 1U;
				}
				if (enterDeprioritizationStateChange != 0)
				{
					Interlocked.Add(ref this._enterDeprioritizationState, -enterDeprioritizationStateChange);
				}
			}

			// Token: 0x0600412B RID: 16683 RVA: 0x000D96F2 File Offset: 0x000D78F2
			public void Exit()
			{
				Volatile.Write(ref this._isLocked, false);
			}

			// Token: 0x04000DB7 RID: 3511
			private bool _isLocked;

			// Token: 0x04000DB8 RID: 3512
			private int _enterDeprioritizationState;
		}

		// Token: 0x02000405 RID: 1029
		[Flags]
		private enum WaiterStates : byte
		{
			// Token: 0x04000DBA RID: 3514
			None = 0,
			// Token: 0x04000DBB RID: 3515
			NoWaiters = 1,
			// Token: 0x04000DBC RID: 3516
			WriteWaiterSignaled = 2,
			// Token: 0x04000DBD RID: 3517
			UpgradeableReadWaiterSignaled = 4
		}

		// Token: 0x02000406 RID: 1030
		private enum EnterSpinLockReason
		{
			// Token: 0x04000DBF RID: 3519
			EnterAnyRead,
			// Token: 0x04000DC0 RID: 3520
			ExitAnyRead,
			// Token: 0x04000DC1 RID: 3521
			EnterWrite,
			// Token: 0x04000DC2 RID: 3522
			UpgradeToWrite,
			// Token: 0x04000DC3 RID: 3523
			EnterRecursiveWrite,
			// Token: 0x04000DC4 RID: 3524
			ExitAnyWrite,
			// Token: 0x04000DC5 RID: 3525
			OperationMask = 7,
			// Token: 0x04000DC6 RID: 3526
			Wait
		}

		// Token: 0x02000407 RID: 1031
		private enum EnterLockType
		{
			// Token: 0x04000DC8 RID: 3528
			Read,
			// Token: 0x04000DC9 RID: 3529
			UpgradeableRead,
			// Token: 0x04000DCA RID: 3530
			Write,
			// Token: 0x04000DCB RID: 3531
			UpgradeToWrite
		}
	}
}
