using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using Internal;

namespace System.Threading
{
	// Token: 0x02000487 RID: 1159
	internal sealed class LowLevelLifoSemaphore : IDisposable
	{
		// Token: 0x06004439 RID: 17465 RVA: 0x000E4804 File Offset: 0x000E2A04
		public LowLevelLifoSemaphore(int initialSignalCount, int maximumSignalCount, int spinCount, Action onWait)
		{
			this._separated = default(LowLevelLifoSemaphore.CacheLineSeparatedCounts);
			this._separated._counts.SignalCount = (uint)initialSignalCount;
			this._maximumSignalCount = maximumSignalCount;
			this._spinCount = spinCount;
			this._onWait = onWait;
			this.Create(maximumSignalCount);
		}

		// Token: 0x0600443A RID: 17466 RVA: 0x000E4854 File Offset: 0x000E2A54
		public bool Wait(int timeoutMs, bool spinWait)
		{
			int num = spinWait ? this._spinCount : 0;
			LowLevelLifoSemaphore.Counts counts = this._separated._counts;
			LowLevelLifoSemaphore.Counts newCounts;
			for (;;)
			{
				newCounts = counts;
				if (counts.SignalCount != 0U)
				{
					newCounts.DecrementSignalCount();
				}
				else if (timeoutMs != 0)
				{
					if (num > 0 && newCounts.SpinnerCount < 255)
					{
						newCounts.IncrementSpinnerCount();
					}
					else
					{
						newCounts.IncrementWaiterCount();
					}
				}
				LowLevelLifoSemaphore.Counts counts2 = this._separated._counts.InterlockedCompareExchange(newCounts, counts);
				if (counts2 == counts)
				{
					break;
				}
				counts = counts2;
			}
			if (counts.SignalCount != 0U)
			{
				return true;
			}
			if (newCounts.WaiterCount != counts.WaiterCount)
			{
				return this.WaitForSignal(timeoutMs);
			}
			if (timeoutMs == 0)
			{
				return false;
			}
			bool isSingleProcessor = Environment.IsSingleProcessor;
			int i = isSingleProcessor ? 10 : 0;
			while (i < num)
			{
				LowLevelSpinWaiter.Wait(i, 10, isSingleProcessor);
				i++;
				counts = this._separated._counts;
				while (counts.SignalCount > 0U)
				{
					LowLevelLifoSemaphore.Counts newCounts2 = counts;
					newCounts2.DecrementSignalCount();
					newCounts2.DecrementSpinnerCount();
					LowLevelLifoSemaphore.Counts counts3 = this._separated._counts.InterlockedCompareExchange(newCounts2, counts);
					if (counts3 == counts)
					{
						return true;
					}
					counts = counts3;
				}
			}
			counts = this._separated._counts;
			for (;;)
			{
				LowLevelLifoSemaphore.Counts newCounts3 = counts;
				newCounts3.DecrementSpinnerCount();
				if (counts.SignalCount != 0U)
				{
					newCounts3.DecrementSignalCount();
				}
				else
				{
					newCounts3.IncrementWaiterCount();
				}
				LowLevelLifoSemaphore.Counts counts4 = this._separated._counts.InterlockedCompareExchange(newCounts3, counts);
				if (counts4 == counts)
				{
					break;
				}
				counts = counts4;
			}
			return counts.SignalCount != 0U || this.WaitForSignal(timeoutMs);
		}

		// Token: 0x0600443B RID: 17467 RVA: 0x000E49D8 File Offset: 0x000E2BD8
		private bool WaitForSignal(int timeoutMs)
		{
			this._onWait();
			for (;;)
			{
				int num = (timeoutMs != -1) ? Environment.TickCount : 0;
				if (timeoutMs == 0 || !this.WaitCore(timeoutMs))
				{
					break;
				}
				int num2 = (timeoutMs != -1) ? Environment.TickCount : 0;
				LowLevelLifoSemaphore.Counts counts = this._separated._counts;
				for (;;)
				{
					LowLevelLifoSemaphore.Counts newCounts = counts;
					if (counts.SignalCount != 0U)
					{
						newCounts.DecrementSignalCount();
						newCounts.DecrementWaiterCount();
					}
					if (counts.CountOfWaitersSignaledToWake != 0)
					{
						newCounts.DecrementCountOfWaitersSignaledToWake();
					}
					LowLevelLifoSemaphore.Counts counts2 = this._separated._counts.InterlockedCompareExchange(newCounts, counts);
					if (counts2 == counts)
					{
						break;
					}
					counts = counts2;
					if (timeoutMs != -1)
					{
						int num3 = num2 - num;
						if (num3 >= 0 && num3 < timeoutMs)
						{
							timeoutMs -= num3;
						}
						else
						{
							timeoutMs = 0;
						}
					}
				}
				if (counts.SignalCount != 0U)
				{
					return true;
				}
			}
			this._separated._counts.InterlockedDecrementWaiterCount();
			return false;
		}

		// Token: 0x0600443C RID: 17468 RVA: 0x000E4AAC File Offset: 0x000E2CAC
		public void Release(int releaseCount)
		{
			LowLevelLifoSemaphore.Counts counts = this._separated._counts;
			int num;
			for (;;)
			{
				LowLevelLifoSemaphore.Counts newCounts = counts;
				newCounts.AddSignalCount((uint)releaseCount);
				num = (int)(Math.Min(newCounts.SignalCount, (uint)(counts.WaiterCount + (ushort)counts.SpinnerCount)) - (uint)counts.SpinnerCount - (uint)counts.CountOfWaitersSignaledToWake);
				if (num > 0)
				{
					if (num > releaseCount)
					{
						num = releaseCount;
					}
					newCounts.AddUpToMaxCountOfWaitersSignaledToWake((uint)num);
				}
				LowLevelLifoSemaphore.Counts counts2 = this._separated._counts.InterlockedCompareExchange(newCounts, counts);
				if (counts2 == counts)
				{
					break;
				}
				counts = counts2;
			}
			if (num > 0)
			{
				this.ReleaseCore(num);
			}
		}

		// Token: 0x0600443D RID: 17469 RVA: 0x000E4B38 File Offset: 0x000E2D38
		private void Create(int maximumSignalCount)
		{
			this._completionPort = Interop.Kernel32.CreateIoCompletionPort(new IntPtr(-1), IntPtr.Zero, UIntPtr.Zero, maximumSignalCount);
			if (this._completionPort == IntPtr.Zero)
			{
				int hrforLastWin32Error = Marshal.GetHRForLastWin32Error();
				throw new OutOfMemoryException
				{
					HResult = hrforLastWin32Error
				};
			}
		}

		// Token: 0x0600443E RID: 17470 RVA: 0x000E4B84 File Offset: 0x000E2D84
		~LowLevelLifoSemaphore()
		{
			if (this._completionPort != IntPtr.Zero)
			{
				this.Dispose();
			}
		}

		// Token: 0x0600443F RID: 17471 RVA: 0x000E4BC0 File Offset: 0x000E2DC0
		public bool WaitCore(int timeoutMs)
		{
			uint num;
			UIntPtr uintPtr;
			IntPtr intPtr;
			return Interop.Kernel32.GetQueuedCompletionStatus(this._completionPort, out num, out uintPtr, out intPtr, timeoutMs);
		}

		// Token: 0x06004440 RID: 17472 RVA: 0x000E4BE0 File Offset: 0x000E2DE0
		private void ReleaseCore(int count)
		{
			for (int i = 0; i < count; i++)
			{
				if (!Interop.Kernel32.PostQueuedCompletionStatus(this._completionPort, 1U, UIntPtr.Zero, IntPtr.Zero))
				{
					int lastPInvokeError = Marshal.GetLastPInvokeError();
					throw new OutOfMemoryException
					{
						HResult = lastPInvokeError
					};
				}
			}
		}

		// Token: 0x06004441 RID: 17473 RVA: 0x000E4C24 File Offset: 0x000E2E24
		public void Dispose()
		{
			Interop.Kernel32.CloseHandle(this._completionPort);
			this._completionPort = IntPtr.Zero;
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000F90 RID: 3984
		private LowLevelLifoSemaphore.CacheLineSeparatedCounts _separated;

		// Token: 0x04000F91 RID: 3985
		private readonly int _maximumSignalCount;

		// Token: 0x04000F92 RID: 3986
		private readonly int _spinCount;

		// Token: 0x04000F93 RID: 3987
		private readonly Action _onWait;

		// Token: 0x04000F94 RID: 3988
		private IntPtr _completionPort;

		// Token: 0x02000488 RID: 1160
		private struct Counts : IEquatable<LowLevelLifoSemaphore.Counts>
		{
			// Token: 0x06004442 RID: 17474 RVA: 0x000E4C43 File Offset: 0x000E2E43
			private Counts(ulong data)
			{
				this._data = data;
			}

			// Token: 0x06004443 RID: 17475 RVA: 0x000E4C4C File Offset: 0x000E2E4C
			private uint GetUInt32Value(byte shift)
			{
				return (uint)(this._data >> (int)shift);
			}

			// Token: 0x06004444 RID: 17476 RVA: 0x000E4C5A File Offset: 0x000E2E5A
			private void SetUInt32Value(uint value, byte shift)
			{
				this._data = ((this._data & ~((ulong)-1 << (int)shift)) | (ulong)value << (int)shift);
			}

			// Token: 0x06004445 RID: 17477 RVA: 0x000E4C79 File Offset: 0x000E2E79
			private ushort GetUInt16Value(byte shift)
			{
				return (ushort)(this._data >> (int)shift);
			}

			// Token: 0x06004446 RID: 17478 RVA: 0x000E4C87 File Offset: 0x000E2E87
			private byte GetByteValue(byte shift)
			{
				return (byte)(this._data >> (int)shift);
			}

			// Token: 0x17000C2F RID: 3119
			// (get) Token: 0x06004447 RID: 17479 RVA: 0x000E4C95 File Offset: 0x000E2E95
			// (set) Token: 0x06004448 RID: 17480 RVA: 0x000E4C9E File Offset: 0x000E2E9E
			public uint SignalCount
			{
				get
				{
					return this.GetUInt32Value(0);
				}
				set
				{
					this.SetUInt32Value(value, 0);
				}
			}

			// Token: 0x06004449 RID: 17481 RVA: 0x000E4CA8 File Offset: 0x000E2EA8
			public void AddSignalCount(uint value)
			{
				this._data += (ulong)value;
			}

			// Token: 0x0600444A RID: 17482 RVA: 0x000E4CB9 File Offset: 0x000E2EB9
			public void DecrementSignalCount()
			{
				this._data -= 1UL;
			}

			// Token: 0x17000C30 RID: 3120
			// (get) Token: 0x0600444B RID: 17483 RVA: 0x000E4CCA File Offset: 0x000E2ECA
			public ushort WaiterCount
			{
				get
				{
					return this.GetUInt16Value(32);
				}
			}

			// Token: 0x0600444C RID: 17484 RVA: 0x000E4CD4 File Offset: 0x000E2ED4
			public void IncrementWaiterCount()
			{
				this._data += 4294967296UL;
			}

			// Token: 0x0600444D RID: 17485 RVA: 0x000E4CEC File Offset: 0x000E2EEC
			public void DecrementWaiterCount()
			{
				this._data -= 4294967296UL;
			}

			// Token: 0x0600444E RID: 17486 RVA: 0x000E4D04 File Offset: 0x000E2F04
			public void InterlockedDecrementWaiterCount()
			{
				new LowLevelLifoSemaphore.Counts(Interlocked.Add(ref this._data, 18446744069414584320UL));
			}

			// Token: 0x17000C31 RID: 3121
			// (get) Token: 0x0600444F RID: 17487 RVA: 0x000E4D20 File Offset: 0x000E2F20
			public byte SpinnerCount
			{
				get
				{
					return this.GetByteValue(48);
				}
			}

			// Token: 0x06004450 RID: 17488 RVA: 0x000E4D2A File Offset: 0x000E2F2A
			public void IncrementSpinnerCount()
			{
				this._data += 281474976710656UL;
			}

			// Token: 0x06004451 RID: 17489 RVA: 0x000E4D42 File Offset: 0x000E2F42
			public void DecrementSpinnerCount()
			{
				this._data -= 281474976710656UL;
			}

			// Token: 0x17000C32 RID: 3122
			// (get) Token: 0x06004452 RID: 17490 RVA: 0x000E4D5A File Offset: 0x000E2F5A
			public byte CountOfWaitersSignaledToWake
			{
				get
				{
					return this.GetByteValue(56);
				}
			}

			// Token: 0x06004453 RID: 17491 RVA: 0x000E4D64 File Offset: 0x000E2F64
			public void AddUpToMaxCountOfWaitersSignaledToWake(uint value)
			{
				uint num = (uint)(byte.MaxValue - this.CountOfWaitersSignaledToWake);
				if (value > num)
				{
					value = num;
				}
				this._data += (ulong)value << 56;
			}

			// Token: 0x06004454 RID: 17492 RVA: 0x000E4D97 File Offset: 0x000E2F97
			public void DecrementCountOfWaitersSignaledToWake()
			{
				this._data -= 72057594037927936UL;
			}

			// Token: 0x06004455 RID: 17493 RVA: 0x000E4DAF File Offset: 0x000E2FAF
			public LowLevelLifoSemaphore.Counts InterlockedCompareExchange(LowLevelLifoSemaphore.Counts newCounts, LowLevelLifoSemaphore.Counts oldCounts)
			{
				return new LowLevelLifoSemaphore.Counts(Interlocked.CompareExchange(ref this._data, newCounts._data, oldCounts._data));
			}

			// Token: 0x06004456 RID: 17494 RVA: 0x000E4DCD File Offset: 0x000E2FCD
			public static bool operator ==(LowLevelLifoSemaphore.Counts lhs, LowLevelLifoSemaphore.Counts rhs)
			{
				return lhs.Equals(rhs);
			}

			// Token: 0x06004457 RID: 17495 RVA: 0x000E4DD8 File Offset: 0x000E2FD8
			public override bool Equals([NotNullWhen(true)] object obj)
			{
				if (obj is LowLevelLifoSemaphore.Counts)
				{
					LowLevelLifoSemaphore.Counts other = (LowLevelLifoSemaphore.Counts)obj;
					return this.Equals(other);
				}
				return false;
			}

			// Token: 0x06004458 RID: 17496 RVA: 0x000E4DFD File Offset: 0x000E2FFD
			public bool Equals(LowLevelLifoSemaphore.Counts other)
			{
				return this._data == other._data;
			}

			// Token: 0x06004459 RID: 17497 RVA: 0x000E4E0D File Offset: 0x000E300D
			public override int GetHashCode()
			{
				return (int)this._data + (int)(this._data >> 32);
			}

			// Token: 0x04000F95 RID: 3989
			private ulong _data;
		}

		// Token: 0x02000489 RID: 1161
		private struct CacheLineSeparatedCounts
		{
			// Token: 0x04000F96 RID: 3990
			private readonly PaddingFor32 _pad1;

			// Token: 0x04000F97 RID: 3991
			public LowLevelLifoSemaphore.Counts _counts;

			// Token: 0x04000F98 RID: 3992
			private readonly PaddingFor32 _pad2;
		}
	}
}
