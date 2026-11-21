using System;
using System.Diagnostics;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;

namespace System.Threading
{
	// Token: 0x020003F0 RID: 1008
	public sealed class Lock
	{
		// Token: 0x06004042 RID: 16450 RVA: 0x000D695E File Offset: 0x000D4B5E
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Enter()
		{
			this.TryEnter_Inlined(-1);
		}

		// Token: 0x06004043 RID: 16451 RVA: 0x000D6968 File Offset: 0x000D4B68
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Lock.ThreadId EnterAndGetCurrentThreadId()
		{
			return this.TryEnter_Inlined(-1);
		}

		// Token: 0x06004044 RID: 16452 RVA: 0x000D6971 File Offset: 0x000D4B71
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Lock.Scope EnterScope()
		{
			return new Lock.Scope(this, this.EnterAndGetCurrentThreadId());
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x000D6980 File Offset: 0x000D4B80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool TryEnter()
		{
			return this.TryEnter_Inlined(0).IsInitialized;
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x000D699C File Offset: 0x000D4B9C
		public bool TryEnter(int millisecondsTimeout)
		{
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(millisecondsTimeout, -1, "millisecondsTimeout");
			return this.TryEnter_Outlined(millisecondsTimeout);
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x000D69B1 File Offset: 0x000D4BB1
		public bool TryEnter(TimeSpan timeout)
		{
			return this.TryEnter_Outlined(WaitHandle.ToTimeoutMilliseconds(timeout));
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x000D69C0 File Offset: 0x000D4BC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool TryEnter_Outlined(int timeoutMs)
		{
			return this.TryEnter_Inlined(timeoutMs).IsInitialized;
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x000D69DC File Offset: 0x000D4BDC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private Lock.ThreadId TryEnter_Inlined(int timeoutMs)
		{
			Lock.ThreadId current_NoInitialize = Lock.ThreadId.Current_NoInitialize;
			if (current_NoInitialize.IsInitialized && Lock.State.TryLock(this))
			{
				this._owningThreadId = current_NoInitialize.Id;
				return current_NoInitialize;
			}
			return this.TryEnterSlow(timeoutMs, current_NoInitialize);
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x000D6A18 File Offset: 0x000D4C18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Exit()
		{
			Lock.ThreadId threadId = new Lock.ThreadId(this._owningThreadId);
			if (!threadId.IsInitialized || threadId.Id != Lock.ThreadId.Current_NoInitialize.Id)
			{
				ThrowHelper.ThrowSynchronizationLockException_LockExit();
			}
			this.ExitImpl();
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x000D6A5C File Offset: 0x000D4C5C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Exit(Lock.ThreadId currentThreadId)
		{
			if (this._owningThreadId != currentThreadId.Id)
			{
				ThrowHelper.ThrowSynchronizationLockException_LockExit();
			}
			this.ExitImpl();
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x000D6A78 File Offset: 0x000D4C78
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void ExitImpl()
		{
			if (this._recursionCount == 0U)
			{
				this._owningThreadId = 0U;
				Lock.State state = Lock.State.Unlock(this);
				if (state.HasAnyWaiters)
				{
					this.SignalWaiterIfNecessary(state);
					return;
				}
			}
			else
			{
				this._recursionCount -= 1U;
			}
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x000D6ABA File Offset: 0x000D4CBA
		private static bool IsAdaptiveSpinEnabled(short minSpinCountForAdaptiveSpin)
		{
			return minSpinCountForAdaptiveSpin <= 0;
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x000D6AC4 File Offset: 0x000D4CC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Lock.ThreadId TryEnterSlow(int timeoutMs, Lock.ThreadId currentThreadId)
		{
			if (!currentThreadId.IsInitialized)
			{
				currentThreadId.InitializeForCurrentThread();
				if (Lock.State.TryLock(this))
				{
					goto IL_135;
				}
			}
			else if (this._owningThreadId == currentThreadId.Id)
			{
				uint num = this._recursionCount + 1U;
				if (num != 0U)
				{
					this._recursionCount = num;
					return currentThreadId;
				}
				throw new LockRecursionException(SR.Lock_Enter_LockRecursionException);
			}
			if (timeoutMs == 0)
			{
				return new Lock.ThreadId(0U);
			}
			Debugger.NotifyOfCrossThreadDependency();
			short num2 = Lock.s_maxSpinCount;
			if (num2 != 0)
			{
				short num3 = Lock.s_minSpinCountForAdaptiveSpin;
				short num4 = this._spinCount;
				if (num4 < 0)
				{
					this._spinCount = num4 + 1;
				}
				else
				{
					bool flag;
					Lock.TryLockResult tryLockResult = Lock.State.TryLockBeforeSpinLoop(this, num4, out flag);
					if (tryLockResult == Lock.TryLockResult.Spin)
					{
						if (flag)
						{
							num4 = num2;
						}
						short num5 = 0;
						do
						{
							LowLevelSpinWaiter.Wait((int)num5, 10, false);
							if ((num5 += 1) >= num4)
							{
								goto IL_EC;
							}
							tryLockResult = Lock.State.TryLockInsideSpinLoop(this);
						}
						while (tryLockResult == Lock.TryLockResult.Spin);
						if (tryLockResult == Lock.TryLockResult.Locked)
						{
							if (!flag || !Lock.IsAdaptiveSpinEnabled(num3))
							{
								goto IL_135;
							}
							num4 = this._spinCount;
							if (num4 < num2)
							{
								this._spinCount = num4 + 1;
								goto IL_135;
							}
							goto IL_135;
						}
						IL_EC:
						tryLockResult = Lock.State.TryLockAfterSpinLoop(this);
						if (flag && Lock.IsAdaptiveSpinEnabled(num3))
						{
							if (tryLockResult == Lock.TryLockResult.Locked)
							{
								num4 = this._spinCount;
								if (num4 < num2)
								{
									this._spinCount = num4 + 1;
								}
							}
							else
							{
								num4 = this._spinCount;
								this._spinCount = ((num4 > 0) ? (num4 - 1) : num3);
							}
						}
					}
					if (tryLockResult != Lock.TryLockResult.Wait)
					{
						goto IL_135;
					}
				}
			}
			bool flag2 = NativeRuntimeEventSource.Log.IsEnabled(EventLevel.Informational, (EventKeywords)16384L);
			AutoResetEvent autoResetEvent = this._waitEvent ?? this.CreateWaitEvent(flag2);
			if (!Lock.State.TryLockBeforeWait(this))
			{
				try
				{
					Interlocked.Increment(ref Lock.s_contentionCount);
					long num6 = 0L;
					if (flag2)
					{
						NativeRuntimeEventSource.Log.ContentionStart(this);
						num6 = Stopwatch.GetTimestamp();
					}
					using (new ThreadBlockingInfo.Scope(this, timeoutMs))
					{
						bool flag3 = false;
						int num7 = (timeoutMs < 0) ? 0 : Environment.TickCount;
						int num8 = timeoutMs;
						while (autoResetEvent.WaitOneNoCheck(num8, new Lock.State(this).UseTrivialWaits, null, NativeRuntimeEventSource.WaitHandleWaitSourceMap.Unknown))
						{
							for (short num9 = 0; num9 < num2; num9 += 1)
							{
								if (Lock.State.TryLockInsideWaiterSpinLoop(this))
								{
									flag3 = true;
									break;
								}
								LowLevelSpinWaiter.Wait((int)num9, 10, false);
							}
							if (flag3)
							{
								break;
							}
							if (Lock.State.TryLockAfterWaiterSpinLoop(this))
							{
								flag3 = true;
								break;
							}
							if (num8 >= 0)
							{
								uint num10 = (uint)(Environment.TickCount - num7);
								if (num10 >= (uint)timeoutMs)
								{
									break;
								}
								num8 = timeoutMs - (int)num10;
							}
						}
						if (flag3)
						{
							this._owningThreadId = currentThreadId.Id;
							if (flag2)
							{
								double durationNs = (double)(Stopwatch.GetTimestamp() - num6) * 1000000000.0 / (double)Stopwatch.Frequency;
								NativeRuntimeEventSource.Log.ContentionStop(durationNs);
							}
							return currentThreadId;
						}
					}
				}
				catch
				{
					Lock.State.UnregisterWaiter(this);
					throw;
				}
				Lock.State.UnregisterWaiter(this);
				return new Lock.ThreadId(0U);
			}
			IL_135:
			this._owningThreadId = currentThreadId.Id;
			return currentThreadId;
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x000D6D94 File Offset: 0x000D4F94
		private void ResetWaiterStartTime()
		{
			this._waiterStartTimeMs = 0;
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x000D6DA0 File Offset: 0x000D4FA0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void RecordWaiterStartTime()
		{
			ushort num = (ushort)Environment.TickCount;
			if (num == 0)
			{
				num -= 1;
			}
			this._waiterStartTimeMs = num;
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06004051 RID: 16465 RVA: 0x000D6DC4 File Offset: 0x000D4FC4
		private bool ShouldStopPreemptingWaiters
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				ushort waiterStartTimeMs = this._waiterStartTimeMs;
				return waiterStartTimeMs != 0 && (ushort)(Environment.TickCount - (int)waiterStartTimeMs) >= 100;
			}
		}

		// Token: 0x06004052 RID: 16466 RVA: 0x000D6DEC File Offset: 0x000D4FEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private AutoResetEvent CreateWaitEvent(bool areContentionEventsEnabled)
		{
			AutoResetEvent autoResetEvent = new AutoResetEvent(false);
			AutoResetEvent autoResetEvent2 = Interlocked.CompareExchange<AutoResetEvent>(ref this._waitEvent, autoResetEvent, null);
			if (autoResetEvent2 == null)
			{
				if (areContentionEventsEnabled && NativeRuntimeEventSource.Log.IsEnabled())
				{
					NativeRuntimeEventSource.Log.ContentionLockCreated(this);
				}
				return autoResetEvent;
			}
			autoResetEvent.Dispose();
			return autoResetEvent2;
		}

		// Token: 0x06004053 RID: 16467 RVA: 0x000D6E34 File Offset: 0x000D5034
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SignalWaiterIfNecessary(Lock.State state)
		{
			if (Lock.State.TrySetIsWaiterSignaledToWake(this, state))
			{
				this._waitEvent.Set();
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06004054 RID: 16468 RVA: 0x000D6E4C File Offset: 0x000D504C
		public bool IsHeldByCurrentThread
		{
			get
			{
				Lock.ThreadId threadId = new Lock.ThreadId(this._owningThreadId);
				return threadId.IsInitialized && threadId.Id == Lock.ThreadId.Current_NoInitialize.Id;
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x06004055 RID: 16469 RVA: 0x000D6E87 File Offset: 0x000D5087
		internal static long ContentionCount
		{
			get
			{
				return Lock.s_contentionCount;
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x06004056 RID: 16470 RVA: 0x000D6E8E File Offset: 0x000D508E
		internal IntPtr LockIdForEvents
		{
			get
			{
				return this._waitEvent.SafeWaitHandle.DangerousGetHandle();
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x06004057 RID: 16471 RVA: 0x000D6EA0 File Offset: 0x000D50A0
		internal ulong OwningThreadId
		{
			get
			{
				return (ulong)this._owningThreadId;
			}
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x000D6EA9 File Offset: 0x000D50A9
		private static short DetermineMaxSpinCount()
		{
			if (Lock.IsSingleProcessor)
			{
				return 0;
			}
			return AppContextConfigHelper.GetInt16Config("System.Threading.Lock.SpinCount", "DOTNET_Lock_SpinCount", 22, false);
		}

		// Token: 0x06004059 RID: 16473 RVA: 0x000D6EC8 File Offset: 0x000D50C8
		private static short DetermineMinSpinCountForAdaptiveSpin()
		{
			short num = AppContextConfigHelper.GetInt16Config("System.Threading.Lock.AdaptiveSpinPeriod", "DOTNET_Lock_AdaptiveSpinPeriod", 100, true);
			if (num < -1)
			{
				num = 100;
			}
			return -num;
		}

		// Token: 0x0600405A RID: 16474 RVA: 0x000D6EF2 File Offset: 0x000D50F2
		public Lock()
		{
			this._spinCount = Lock.s_maxSpinCount;
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x0600405B RID: 16475 RVA: 0x000D6F05 File Offset: 0x000D5105
		private static bool IsSingleProcessor
		{
			get
			{
				return Environment.IsSingleProcessor;
			}
		}

		// Token: 0x04000D70 RID: 3440
		private static long s_contentionCount;

		// Token: 0x04000D71 RID: 3441
		private uint _owningThreadId;

		// Token: 0x04000D72 RID: 3442
		private uint _state;

		// Token: 0x04000D73 RID: 3443
		private uint _recursionCount;

		// Token: 0x04000D74 RID: 3444
		private short _spinCount;

		// Token: 0x04000D75 RID: 3445
		private ushort _waiterStartTimeMs;

		// Token: 0x04000D76 RID: 3446
		private AutoResetEvent _waitEvent;

		// Token: 0x04000D77 RID: 3447
		private static readonly short s_maxSpinCount = Lock.DetermineMaxSpinCount();

		// Token: 0x04000D78 RID: 3448
		private static readonly short s_minSpinCountForAdaptiveSpin = Lock.DetermineMinSpinCountForAdaptiveSpin();

		// Token: 0x020003F1 RID: 1009
		[CompilerFeatureRequired("RefStructs")]
		public ref struct Scope
		{
			// Token: 0x0600405D RID: 16477 RVA: 0x000D6F22 File Offset: 0x000D5122
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal Scope(Lock lockObj, Lock.ThreadId currentThreadId)
			{
				this._lockObj = lockObj;
				this._currentThreadId = currentThreadId;
			}

			// Token: 0x0600405E RID: 16478 RVA: 0x000D6F34 File Offset: 0x000D5134
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Dispose()
			{
				Lock lockObj = this._lockObj;
				if (lockObj != null)
				{
					this._lockObj = null;
					lockObj.Exit(this._currentThreadId);
				}
			}

			// Token: 0x04000D79 RID: 3449
			private Lock _lockObj;

			// Token: 0x04000D7A RID: 3450
			private Lock.ThreadId _currentThreadId;
		}

		// Token: 0x020003F2 RID: 1010
		private struct State : IEquatable<Lock.State>
		{
			// Token: 0x0600405F RID: 16479 RVA: 0x000D6F5E File Offset: 0x000D515E
			public State(Lock lockObj)
			{
				this = new Lock.State(lockObj._state);
			}

			// Token: 0x06004060 RID: 16480 RVA: 0x000D6F6C File Offset: 0x000D516C
			private State(uint state)
			{
				this._state = state;
			}

			// Token: 0x06004061 RID: 16481 RVA: 0x0003046E File Offset: 0x0002E66E
			private static uint Neg(uint state)
			{
				return -state;
			}

			// Token: 0x17000BAF RID: 2991
			// (get) Token: 0x06004062 RID: 16482 RVA: 0x000D6F75 File Offset: 0x000D5175
			public bool IsLocked
			{
				get
				{
					return (this._state & 1U) > 0U;
				}
			}

			// Token: 0x06004063 RID: 16483 RVA: 0x000D6F82 File Offset: 0x000D5182
			private void SetIsLocked()
			{
				this._state += 1U;
			}

			// Token: 0x17000BB0 RID: 2992
			// (get) Token: 0x06004064 RID: 16484 RVA: 0x000D6F92 File Offset: 0x000D5192
			private bool ShouldNotPreemptWaiters
			{
				get
				{
					return (this._state & 2U) > 0U;
				}
			}

			// Token: 0x06004065 RID: 16485 RVA: 0x000D6F9F File Offset: 0x000D519F
			private void SetShouldNotPreemptWaiters()
			{
				this._state += 2U;
			}

			// Token: 0x06004066 RID: 16486 RVA: 0x000D6FAF File Offset: 0x000D51AF
			private void ClearShouldNotPreemptWaiters()
			{
				this._state -= 2U;
			}

			// Token: 0x17000BB1 RID: 2993
			// (get) Token: 0x06004067 RID: 16487 RVA: 0x000D6FBF File Offset: 0x000D51BF
			private bool ShouldNonWaiterAttemptToAcquireLock
			{
				get
				{
					return (this._state & 3U) == 0U;
				}
			}

			// Token: 0x17000BB2 RID: 2994
			// (get) Token: 0x06004068 RID: 16488 RVA: 0x000D6FCC File Offset: 0x000D51CC
			private bool HasAnySpinners
			{
				get
				{
					return (this._state & 28U) > 0U;
				}
			}

			// Token: 0x06004069 RID: 16489 RVA: 0x000D6FDC File Offset: 0x000D51DC
			private bool TryIncrementSpinnerCount()
			{
				uint state = this._state + 4U;
				if (new Lock.State(state).HasAnySpinners)
				{
					this._state = state;
					return true;
				}
				return false;
			}

			// Token: 0x0600406A RID: 16490 RVA: 0x000D700C File Offset: 0x000D520C
			private void DecrementSpinnerCount()
			{
				this._state -= 4U;
			}

			// Token: 0x0600406B RID: 16491 RVA: 0x000D701C File Offset: 0x000D521C
			private void SetIsWaiterSignaledToWake()
			{
				this._state += 32U;
			}

			// Token: 0x0600406C RID: 16492 RVA: 0x000D702D File Offset: 0x000D522D
			private void ClearIsWaiterSignaledToWake()
			{
				this._state -= 32U;
			}

			// Token: 0x17000BB3 RID: 2995
			// (get) Token: 0x0600406D RID: 16493 RVA: 0x000D703E File Offset: 0x000D523E
			public bool UseTrivialWaits
			{
				get
				{
					return (this._state & 64U) > 0U;
				}
			}

			// Token: 0x17000BB4 RID: 2996
			// (get) Token: 0x0600406E RID: 16494 RVA: 0x000D704C File Offset: 0x000D524C
			public bool HasAnyWaiters
			{
				get
				{
					return this._state >= 128U;
				}
			}

			// Token: 0x0600406F RID: 16495 RVA: 0x000D7060 File Offset: 0x000D5260
			private bool TryIncrementWaiterCount()
			{
				uint state = this._state + 128U;
				if (new Lock.State(state).HasAnyWaiters)
				{
					this._state = state;
					return true;
				}
				return false;
			}

			// Token: 0x06004070 RID: 16496 RVA: 0x000D7094 File Offset: 0x000D5294
			private void DecrementWaiterCount()
			{
				this._state -= 128U;
			}

			// Token: 0x17000BB5 RID: 2997
			// (get) Token: 0x06004071 RID: 16497 RVA: 0x000D70A8 File Offset: 0x000D52A8
			public bool NeedToSignalWaiter
			{
				get
				{
					return (this._state & 60U) == 0U;
				}
			}

			// Token: 0x06004072 RID: 16498 RVA: 0x000D70B6 File Offset: 0x000D52B6
			public static bool operator ==(Lock.State state1, Lock.State state2)
			{
				return state1._state == state2._state;
			}

			// Token: 0x06004073 RID: 16499 RVA: 0x000D70C6 File Offset: 0x000D52C6
			bool IEquatable<Lock.State>.Equals(Lock.State other)
			{
				return this == other;
			}

			// Token: 0x06004074 RID: 16500 RVA: 0x000D70D4 File Offset: 0x000D52D4
			public override bool Equals(object obj)
			{
				if (obj is Lock.State)
				{
					Lock.State state = (Lock.State)obj;
					return this == state;
				}
				return false;
			}

			// Token: 0x06004075 RID: 16501 RVA: 0x000D70FE File Offset: 0x000D52FE
			public override int GetHashCode()
			{
				return (int)this._state;
			}

			// Token: 0x06004076 RID: 16502 RVA: 0x000D7106 File Offset: 0x000D5306
			private static Lock.State CompareExchange(Lock lockObj, Lock.State toState, Lock.State fromState)
			{
				return new Lock.State(Interlocked.CompareExchange(ref lockObj._state, toState._state, fromState._state));
			}

			// Token: 0x06004077 RID: 16503 RVA: 0x000D7124 File Offset: 0x000D5324
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool TryLock(Lock lockObj)
			{
				Lock.State state = new Lock.State(lockObj);
				if (!state.ShouldNonWaiterAttemptToAcquireLock)
				{
					return false;
				}
				Lock.State toState = state;
				toState.SetIsLocked();
				return Lock.State.CompareExchange(lockObj, toState, state) == state;
			}

			// Token: 0x06004078 RID: 16504 RVA: 0x000D715B File Offset: 0x000D535B
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Lock.State Unlock(Lock lockObj)
			{
				return new Lock.State(Interlocked.Decrement(ref lockObj._state));
			}

			// Token: 0x06004079 RID: 16505 RVA: 0x000D7170 File Offset: 0x000D5370
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Lock.TryLockResult TryLockBeforeSpinLoop(Lock lockObj, short spinCount, out bool isFirstSpinner)
			{
				isFirstSpinner = false;
				Lock.State state = new Lock.State(lockObj);
				Lock.TryLockResult tryLockResult;
				for (;;)
				{
					Lock.State toState = state;
					tryLockResult = Lock.TryLockResult.Spin;
					if (toState.HasAnyWaiters)
					{
						if (toState.ShouldNotPreemptWaiters)
						{
							break;
						}
						if (lockObj.ShouldStopPreemptingWaiters)
						{
							toState.SetShouldNotPreemptWaiters();
							tryLockResult = Lock.TryLockResult.Wait;
						}
					}
					if (tryLockResult == Lock.TryLockResult.Spin)
					{
						if (!toState.IsLocked)
						{
							toState.SetIsLocked();
							tryLockResult = Lock.TryLockResult.Locked;
						}
						else if ((toState.HasAnySpinners && spinCount == 0) || !toState.TryIncrementSpinnerCount())
						{
							return Lock.TryLockResult.Wait;
						}
					}
					Lock.State state2 = Lock.State.CompareExchange(lockObj, toState, state);
					if (state2 == state)
					{
						goto Block_7;
					}
					state = state2;
				}
				return Lock.TryLockResult.Wait;
				Block_7:
				if (tryLockResult == Lock.TryLockResult.Spin && !state.HasAnySpinners)
				{
					isFirstSpinner = true;
				}
				return tryLockResult;
			}

			// Token: 0x0600407A RID: 16506 RVA: 0x000D7208 File Offset: 0x000D5408
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Lock.TryLockResult TryLockInsideSpinLoop(Lock lockObj)
			{
				Lock.State state = new Lock.State(lockObj);
				while (state.ShouldNonWaiterAttemptToAcquireLock)
				{
					Lock.State toState = state;
					toState.SetIsLocked();
					toState.DecrementSpinnerCount();
					Lock.State state2 = Lock.State.CompareExchange(lockObj, toState, state);
					if (state2 == state)
					{
						return Lock.TryLockResult.Locked;
					}
					state = state2;
				}
				if (!state.ShouldNotPreemptWaiters)
				{
					return Lock.TryLockResult.Spin;
				}
				return Lock.TryLockResult.Wait;
			}

			// Token: 0x0600407B RID: 16507 RVA: 0x000D725C File Offset: 0x000D545C
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static Lock.TryLockResult TryLockAfterSpinLoop(Lock lockObj)
			{
				Lock.State state = new Lock.State(Interlocked.Add(ref lockObj._state, Lock.State.Neg(4U)));
				while (!state.IsLocked)
				{
					Lock.State toState = state;
					toState.SetIsLocked();
					Lock.State state2 = Lock.State.CompareExchange(lockObj, toState, state);
					if (state2 == state)
					{
						return Lock.TryLockResult.Locked;
					}
					state = state2;
				}
				return Lock.TryLockResult.Wait;
			}

			// Token: 0x0600407C RID: 16508 RVA: 0x000D72AC File Offset: 0x000D54AC
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool TryLockBeforeWait(Lock lockObj)
			{
				Lock.State state = new Lock.State(lockObj);
				bool flag = false;
				for (;;)
				{
					Lock.State toState = state;
					if (toState.ShouldNonWaiterAttemptToAcquireLock)
					{
						toState.SetIsLocked();
					}
					else
					{
						if (!toState.TryIncrementWaiterCount())
						{
							ThrowHelper.ThrowOutOfMemoryException_LockEnter_WaiterCountOverflow();
						}
						if (!state.HasAnyWaiters && !flag)
						{
							flag = true;
							lockObj.ResetWaiterStartTime();
						}
					}
					Lock.State state2 = Lock.State.CompareExchange(lockObj, toState, state);
					if (state2 == state)
					{
						break;
					}
					state = state2;
				}
				if (state.ShouldNonWaiterAttemptToAcquireLock)
				{
					return true;
				}
				if (!state.HasAnyWaiters || flag)
				{
					lockObj.RecordWaiterStartTime();
				}
				return false;
			}

			// Token: 0x0600407D RID: 16509 RVA: 0x000D7330 File Offset: 0x000D5530
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool TryLockInsideWaiterSpinLoop(Lock lockObj)
			{
				bool flag = false;
				Lock.State state = new Lock.State(lockObj);
				while (!state.IsLocked)
				{
					Lock.State toState = state;
					toState.SetIsLocked();
					toState.ClearIsWaiterSignaledToWake();
					toState.DecrementWaiterCount();
					if (toState.ShouldNotPreemptWaiters)
					{
						toState.ClearShouldNotPreemptWaiters();
						if (toState.HasAnyWaiters && !flag)
						{
							flag = true;
							lockObj.RecordWaiterStartTime();
						}
					}
					Lock.State state2 = Lock.State.CompareExchange(lockObj, toState, state);
					if (state2 == state)
					{
						if (toState.HasAnyWaiters && !flag)
						{
							lockObj.RecordWaiterStartTime();
						}
						return true;
					}
					state = state2;
				}
				return false;
			}

			// Token: 0x0600407E RID: 16510 RVA: 0x000D73B8 File Offset: 0x000D55B8
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool TryLockAfterWaiterSpinLoop(Lock lockObj)
			{
				Lock.State state = new Lock.State(Interlocked.Add(ref lockObj._state, Lock.State.Neg(32U)));
				bool flag = false;
				while (!state.IsLocked)
				{
					Lock.State toState = state;
					toState.SetIsLocked();
					toState.DecrementWaiterCount();
					if (toState.ShouldNotPreemptWaiters)
					{
						toState.ClearShouldNotPreemptWaiters();
						if (toState.HasAnyWaiters && !flag)
						{
							flag = true;
							lockObj.RecordWaiterStartTime();
						}
					}
					Lock.State state2 = Lock.State.CompareExchange(lockObj, toState, state);
					if (state2 == state)
					{
						if (toState.HasAnyWaiters && !flag)
						{
							lockObj.RecordWaiterStartTime();
						}
						return true;
					}
					state = state2;
				}
				return false;
			}

			// Token: 0x0600407F RID: 16511 RVA: 0x000D7448 File Offset: 0x000D5648
			[MethodImpl(MethodImplOptions.NoInlining)]
			public static void UnregisterWaiter(Lock lockObj)
			{
				Lock.State state = new Lock.State(lockObj);
				for (;;)
				{
					Lock.State toState = state;
					toState.DecrementWaiterCount();
					if (toState.ShouldNotPreemptWaiters && !toState.HasAnyWaiters)
					{
						toState.ClearShouldNotPreemptWaiters();
					}
					Lock.State state2 = Lock.State.CompareExchange(lockObj, toState, state);
					if (state2 == state)
					{
						break;
					}
					state = state2;
				}
			}

			// Token: 0x06004080 RID: 16512 RVA: 0x000D7498 File Offset: 0x000D5698
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public static bool TrySetIsWaiterSignaledToWake(Lock lockObj, Lock.State state)
			{
				while (state.NeedToSignalWaiter)
				{
					Lock.State toState = state;
					toState.SetIsWaiterSignaledToWake();
					if (!toState.ShouldNotPreemptWaiters && lockObj.ShouldStopPreemptingWaiters)
					{
						toState.SetShouldNotPreemptWaiters();
					}
					Lock.State state2 = Lock.State.CompareExchange(lockObj, toState, state);
					if (state2 == state)
					{
						return true;
					}
					if (!state2.HasAnyWaiters)
					{
						return false;
					}
					state = state2;
				}
				return false;
			}

			// Token: 0x04000D7B RID: 3451
			private uint _state;
		}

		// Token: 0x020003F3 RID: 1011
		private enum TryLockResult
		{
			// Token: 0x04000D7D RID: 3453
			Locked,
			// Token: 0x04000D7E RID: 3454
			Spin,
			// Token: 0x04000D7F RID: 3455
			Wait
		}

		// Token: 0x020003F4 RID: 1012
		internal struct ThreadId
		{
			// Token: 0x06004081 RID: 16513 RVA: 0x000D74F4 File Offset: 0x000D56F4
			public ThreadId(uint id)
			{
				this._id = id;
			}

			// Token: 0x17000BB6 RID: 2998
			// (get) Token: 0x06004082 RID: 16514 RVA: 0x000D74FD File Offset: 0x000D56FD
			public uint Id
			{
				get
				{
					return this._id;
				}
			}

			// Token: 0x17000BB7 RID: 2999
			// (get) Token: 0x06004083 RID: 16515 RVA: 0x000D7505 File Offset: 0x000D5705
			public bool IsInitialized
			{
				get
				{
					return this._id > 0U;
				}
			}

			// Token: 0x17000BB8 RID: 3000
			// (get) Token: 0x06004084 RID: 16516 RVA: 0x000D7510 File Offset: 0x000D5710
			public static Lock.ThreadId Current_NoInitialize
			{
				get
				{
					return new Lock.ThreadId(Lock.ThreadId.t_threadId);
				}
			}

			// Token: 0x06004085 RID: 16517 RVA: 0x000D751C File Offset: 0x000D571C
			public void InitializeForCurrentThread()
			{
				uint num = (uint)Interop.Kernel32.GetCurrentThreadId();
				if (num == 0U)
				{
					num -= 1U;
				}
				Lock.ThreadId.t_threadId = (this._id = num);
			}

			// Token: 0x04000D80 RID: 3456
			[ThreadStatic]
			private static uint t_threadId;

			// Token: 0x04000D81 RID: 3457
			private uint _id;
		}
	}
}
