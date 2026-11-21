using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Principal;

namespace System.Threading
{
	// Token: 0x020003C2 RID: 962
	[NullableContext(1)]
	[Nullable(0)]
	[StructLayout(LayoutKind.Sequential)]
	public sealed class Thread : CriticalFinalizerObject
	{
		// Token: 0x06003ED3 RID: 16083 RVA: 0x000D352F File Offset: 0x000D172F
		private Thread()
		{
			this.Initialize();
		}

		// Token: 0x06003ED4 RID: 16084 RVA: 0x000D3540 File Offset: 0x000D1740
		~Thread()
		{
			this.FreeInternal();
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x06003ED5 RID: 16085 RVA: 0x000D356C File Offset: 0x000D176C
		public bool IsAlive
		{
			get
			{
				return (Thread.GetState(this) & (ThreadState.Unstarted | ThreadState.Stopped | ThreadState.Aborted)) == ThreadState.Running;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x06003ED6 RID: 16086 RVA: 0x000D357D File Offset: 0x000D177D
		// (set) Token: 0x06003ED7 RID: 16087 RVA: 0x000D358A File Offset: 0x000D178A
		public bool IsBackground
		{
			get
			{
				return (this.ValidateThreadState() & ThreadState.Background) > ThreadState.Running;
			}
			set
			{
				this.ValidateThreadState();
				if (value)
				{
					Thread.SetState(this, ThreadState.Background);
					return;
				}
				Thread.ClrState(this, ThreadState.Background);
				this._mayNeedResetForThreadPool = true;
			}
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x06003ED8 RID: 16088 RVA: 0x000D35AC File Offset: 0x000D17AC
		// (set) Token: 0x06003ED9 RID: 16089 RVA: 0x000D35BB File Offset: 0x000D17BB
		public bool IsThreadPoolThread
		{
			get
			{
				this.ValidateThreadState();
				return this.threadpool_thread;
			}
			internal set
			{
				this.threadpool_thread = value;
			}
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x06003EDA RID: 16090 RVA: 0x000D35C4 File Offset: 0x000D17C4
		public int ManagedThreadId
		{
			get
			{
				return this.managed_id;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x06003EDB RID: 16091 RVA: 0x000D35CC File Offset: 0x000D17CC
		// (set) Token: 0x06003EDC RID: 16092 RVA: 0x000D35DB File Offset: 0x000D17DB
		public ThreadPriority Priority
		{
			get
			{
				this.ValidateThreadState();
				return (ThreadPriority)this.priority;
			}
			set
			{
				Thread.SetPriority(this, (int)value);
				if (value != ThreadPriority.Normal)
				{
					this._mayNeedResetForThreadPool = true;
				}
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x06003EDD RID: 16093 RVA: 0x000D35EF File Offset: 0x000D17EF
		public ThreadState ThreadState
		{
			get
			{
				return Thread.GetState(this);
			}
		}

		// Token: 0x06003EDE RID: 16094 RVA: 0x000201B4 File Offset: 0x0001E3B4
		public ApartmentState GetApartmentState()
		{
			return ApartmentState.Unknown;
		}

		// Token: 0x06003EDF RID: 16095 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public void DisableComObjectEagerCleanup()
		{
		}

		// Token: 0x06003EE0 RID: 16096 RVA: 0x000D35F7 File Offset: 0x000D17F7
		public void Interrupt()
		{
			Thread.InterruptInternal(this);
		}

		// Token: 0x06003EE1 RID: 16097 RVA: 0x000D35FF File Offset: 0x000D17FF
		public bool Join(int millisecondsTimeout)
		{
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(millisecondsTimeout, -1, "millisecondsTimeout");
			return Thread.JoinInternal(this, millisecondsTimeout);
		}

		// Token: 0x06003EE2 RID: 16098 RVA: 0x000D3614 File Offset: 0x000D1814
		private void Initialize()
		{
			Thread.InitInternal(this);
		}

		// Token: 0x06003EE3 RID: 16099 RVA: 0x000D361C File Offset: 0x000D181C
		public static void SpinWait(int iterations)
		{
			if (iterations < 0)
			{
				return;
			}
			while (iterations-- > 0)
			{
				Thread.SpinWait_nop();
			}
		}

		// Token: 0x06003EE4 RID: 16100 RVA: 0x000D3631 File Offset: 0x000D1831
		internal void StartCallback()
		{
			Thread.StartHelper startHelper = this._startHelper;
			this._startHelper = null;
			startHelper.Run();
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x000D3645 File Offset: 0x000D1845
		internal static void ThrowThreadStartException(Exception ex)
		{
			throw new ThreadStartException(ex);
		}

		// Token: 0x06003EE6 RID: 16102 RVA: 0x000D364D File Offset: 0x000D184D
		private void StartCore()
		{
			Thread.StartHelper startHelper = this._startHelper;
			Thread.StartInternal(this, (startHelper != null) ? startHelper._maxStackSize : 0);
		}

		// Token: 0x06003EE7 RID: 16103
		[DynamicDependency("StartCallback")]
		[DynamicDependency("ThrowThreadStartException")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void StartInternal(Thread runtimeThread, int stackSize);

		// Token: 0x06003EE8 RID: 16104 RVA: 0x000D3667 File Offset: 0x000D1867
		public static bool Yield()
		{
			return Thread.YieldInternal();
		}

		// Token: 0x06003EE9 RID: 16105 RVA: 0x000D366E File Offset: 0x000D186E
		private static bool SetApartmentStateUnchecked(ApartmentState state, bool throwOnError)
		{
			if (state == ApartmentState.Unknown)
			{
				return true;
			}
			if (throwOnError)
			{
				throw new PlatformNotSupportedException(SR.PlatformNotSupported_ComInterop);
			}
			return false;
		}

		// Token: 0x06003EEA RID: 16106 RVA: 0x000D3685 File Offset: 0x000D1885
		private ThreadState ValidateThreadState()
		{
			ThreadState threadState = Thread.GetState(this);
			if ((threadState & ThreadState.Stopped) != ThreadState.Running)
			{
				throw new ThreadStateException(SR.ThreadState_Dead_State);
			}
			return threadState;
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x000D369E File Offset: 0x000D189E
		internal void SetWaitSleepJoinState()
		{
			Thread.SetState(this, ThreadState.WaitSleepJoin);
		}

		// Token: 0x06003EEC RID: 16108 RVA: 0x000D36A8 File Offset: 0x000D18A8
		internal void ClearWaitSleepJoinState()
		{
			Thread.ClrState(this, ThreadState.WaitSleepJoin);
		}

		// Token: 0x06003EED RID: 16109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ulong GetCurrentOSThreadId();

		// Token: 0x06003EEE RID: 16110
		[MemberNotNull("self")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InitInternal(Thread thread);

		// Token: 0x06003EEF RID: 16111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Thread GetCurrentThread();

		// Token: 0x06003EF0 RID: 16112 RVA: 0x000D36B2 File Offset: 0x000D18B2
		[MethodImpl(MethodImplOptions.NoInlining)]
		private static Thread InitializeCurrentThread()
		{
			Thread.t_currentThread = Thread.GetCurrentThread();
			return Thread.t_currentThread;
		}

		// Token: 0x06003EF1 RID: 16113
		[MethodImpl(MethodImplOptions.InternalCall)]
		private extern void FreeInternal();

		// Token: 0x06003EF2 RID: 16114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ThreadState GetState(Thread thread);

		// Token: 0x06003EF3 RID: 16115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetState(Thread thread, ThreadState set);

		// Token: 0x06003EF4 RID: 16116
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void ClrState(Thread thread, ThreadState clr);

		// Token: 0x06003EF5 RID: 16117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern void SetName_icall(Thread thread, char* name, int nameLength);

		// Token: 0x06003EF6 RID: 16118 RVA: 0x000D36C4 File Offset: 0x000D18C4
		private unsafe static void SetName(Thread thread, string name)
		{
			char* ptr;
			if (name == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = name.GetPinnableReference())
				{
					ptr = ptr2;
				}
			}
			char* ptr3 = ptr;
			Thread.SetName_icall(thread, ptr3, (name != null) ? name.Length : 0);
			char* ptr2 = null;
		}

		// Token: 0x06003EF7 RID: 16119
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool YieldInternal();

		// Token: 0x06003EF8 RID: 16120 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[Intrinsic]
		private static void SpinWait_nop()
		{
		}

		// Token: 0x06003EF9 RID: 16121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool JoinInternal(Thread thread, int millisecondsTimeout);

		// Token: 0x06003EFA RID: 16122
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void InterruptInternal(Thread thread);

		// Token: 0x06003EFB RID: 16123
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetPriority(Thread thread, int priority);

		// Token: 0x06003EFC RID: 16124 RVA: 0x000D36F8 File Offset: 0x000D18F8
		internal int GetSmallId()
		{
			return this.small_id;
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x000D3700 File Offset: 0x000D1900
		public Thread(ThreadStart start)
		{
			ArgumentNullException.ThrowIfNull(start, "start");
			this._startHelper = new Thread.StartHelper(start);
			this.Initialize();
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x000D3725 File Offset: 0x000D1925
		public Thread(ThreadStart start, int maxStackSize)
		{
			ArgumentNullException.ThrowIfNull(start, "start");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(maxStackSize, "maxStackSize");
			this._startHelper = new Thread.StartHelper(start)
			{
				_maxStackSize = maxStackSize
			};
			this.Initialize();
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x000D3700 File Offset: 0x000D1900
		public Thread(ParameterizedThreadStart start)
		{
			ArgumentNullException.ThrowIfNull(start, "start");
			this._startHelper = new Thread.StartHelper(start);
			this.Initialize();
		}

		// Token: 0x06003F00 RID: 16128 RVA: 0x000D3725 File Offset: 0x000D1925
		public Thread(ParameterizedThreadStart start, int maxStackSize)
		{
			ArgumentNullException.ThrowIfNull(start, "start");
			ArgumentOutOfRangeException.ThrowIfNegative<int>(maxStackSize, "maxStackSize");
			this._startHelper = new Thread.StartHelper(start)
			{
				_maxStackSize = maxStackSize
			};
			this.Initialize();
		}

		// Token: 0x06003F01 RID: 16129 RVA: 0x000D375C File Offset: 0x000D195C
		internal static void ThrowIfNoThreadStart(bool internalThread = false)
		{
		}

		// Token: 0x06003F02 RID: 16130 RVA: 0x000D3760 File Offset: 0x000D1960
		[NullableContext(2)]
		[UnsupportedOSPlatform("browser")]
		public void Start(object parameter)
		{
			this.Start(parameter, true, false);
		}

		// Token: 0x06003F03 RID: 16131 RVA: 0x000D376B File Offset: 0x000D196B
		[NullableContext(2)]
		[UnsupportedOSPlatform("browser")]
		public void UnsafeStart(object parameter)
		{
			this.Start(parameter, false, false);
		}

		// Token: 0x06003F04 RID: 16132 RVA: 0x000D3778 File Offset: 0x000D1978
		private void Start(object parameter, bool captureContext, bool internalThread = false)
		{
			Thread.ThrowIfNoThreadStart(internalThread);
			Thread.StartHelper startHelper = this._startHelper;
			if (startHelper != null)
			{
				if (startHelper._start is ThreadStart)
				{
					throw new InvalidOperationException(SR.InvalidOperation_ThreadWrongThreadStart);
				}
				startHelper._startArg = parameter;
				startHelper._executionContext = (captureContext ? ExecutionContext.Capture() : null);
			}
			this.StartCore();
		}

		// Token: 0x06003F05 RID: 16133 RVA: 0x000D37CB File Offset: 0x000D19CB
		[UnsupportedOSPlatform("browser")]
		public void Start()
		{
			this.Start(true, false);
		}

		// Token: 0x06003F06 RID: 16134 RVA: 0x000D37D5 File Offset: 0x000D19D5
		[UnsupportedOSPlatform("browser")]
		public void UnsafeStart()
		{
			this.Start(false, false);
		}

		// Token: 0x06003F07 RID: 16135 RVA: 0x000D37DF File Offset: 0x000D19DF
		internal void InternalUnsafeStart()
		{
			this.Start(false, true);
		}

		// Token: 0x06003F08 RID: 16136 RVA: 0x000D37EC File Offset: 0x000D19EC
		private void Start(bool captureContext, bool internalThread = false)
		{
			Thread.ThrowIfNoThreadStart(internalThread);
			Thread.StartHelper startHelper = this._startHelper;
			if (startHelper != null)
			{
				startHelper._startArg = null;
				startHelper._executionContext = (captureContext ? ExecutionContext.Capture() : null);
			}
			this.StartCore();
		}

		// Token: 0x06003F09 RID: 16137 RVA: 0x000D3827 File Offset: 0x000D1A27
		private void RequireCurrentThread()
		{
			if (this != Thread.CurrentThread)
			{
				throw new InvalidOperationException(SR.Thread_Operation_RequiresCurrentThread);
			}
		}

		// Token: 0x06003F0A RID: 16138 RVA: 0x000D383C File Offset: 0x000D1A3C
		private void SetCultureOnUnstartedThread(CultureInfo value, bool uiCulture)
		{
			ArgumentNullException.ThrowIfNull(value, "value");
			Thread.StartHelper startHelper = this._startHelper;
			if ((this.ThreadState & ThreadState.Unstarted) == ThreadState.Running)
			{
				throw new InvalidOperationException(SR.Thread_Operation_RequiresCurrentThread);
			}
			if (uiCulture)
			{
				startHelper._uiCulture = value;
				return;
			}
			startHelper._culture = value;
		}

		// Token: 0x06003F0B RID: 16139 RVA: 0x000D3882 File Offset: 0x000D1A82
		private void ThreadNameChanged(string value)
		{
			Thread.SetName(this, value);
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x06003F0C RID: 16140 RVA: 0x000D388B File Offset: 0x000D1A8B
		// (set) Token: 0x06003F0D RID: 16141 RVA: 0x000D3898 File Offset: 0x000D1A98
		public CultureInfo CurrentCulture
		{
			get
			{
				this.RequireCurrentThread();
				return CultureInfo.CurrentCulture;
			}
			set
			{
				if (this != Thread.CurrentThread)
				{
					this.SetCultureOnUnstartedThread(value, false);
					return;
				}
				CultureInfo.CurrentCulture = value;
			}
		}

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x06003F0E RID: 16142 RVA: 0x000D38B1 File Offset: 0x000D1AB1
		// (set) Token: 0x06003F0F RID: 16143 RVA: 0x000D38BE File Offset: 0x000D1ABE
		public CultureInfo CurrentUICulture
		{
			get
			{
				this.RequireCurrentThread();
				return CultureInfo.CurrentUICulture;
			}
			set
			{
				if (this != Thread.CurrentThread)
				{
					this.SetCultureOnUnstartedThread(value, true);
					return;
				}
				CultureInfo.CurrentUICulture = value;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x06003F10 RID: 16144 RVA: 0x000D38D8 File Offset: 0x000D1AD8
		// (set) Token: 0x06003F11 RID: 16145 RVA: 0x000D390C File Offset: 0x000D1B0C
		[Nullable(2)]
		public static IPrincipal CurrentPrincipal
		{
			[NullableContext(2)]
			get
			{
				AsyncLocal<IPrincipal> asyncLocal = Thread.s_asyncLocalPrincipal;
				IPrincipal principal = (asyncLocal != null) ? asyncLocal.Value : null;
				if (principal == null)
				{
					principal = (Thread.CurrentPrincipal = AppDomain.CurrentDomain.GetThreadPrincipal());
				}
				return principal;
			}
			[NullableContext(2)]
			set
			{
				if (Thread.s_asyncLocalPrincipal == null)
				{
					if (value == null)
					{
						return;
					}
					Interlocked.CompareExchange<AsyncLocal<IPrincipal>>(ref Thread.s_asyncLocalPrincipal, new AsyncLocal<IPrincipal>(), null);
				}
				Thread.s_asyncLocalPrincipal.Value = value;
			}
		}

		// Token: 0x17000B92 RID: 2962
		// (get) Token: 0x06003F12 RID: 16146 RVA: 0x000D3935 File Offset: 0x000D1B35
		public static Thread CurrentThread
		{
			[Intrinsic]
			get
			{
				return Thread.t_currentThread ?? Thread.InitializeCurrentThread();
			}
		}

		// Token: 0x06003F13 RID: 16147 RVA: 0x000D3945 File Offset: 0x000D1B45
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Sleep(int millisecondsTimeout)
		{
			ArgumentOutOfRangeException.ThrowIfLessThan<int>(millisecondsTimeout, -1, "millisecondsTimeout");
			Thread.SleepInternal(millisecondsTimeout);
		}

		// Token: 0x17000B93 RID: 2963
		// (get) Token: 0x06003F14 RID: 16148 RVA: 0x000D3959 File Offset: 0x000D1B59
		internal static ulong CurrentOSThreadId
		{
			get
			{
				return Thread.GetCurrentOSThreadId();
			}
		}

		// Token: 0x17000B94 RID: 2964
		// (get) Token: 0x06003F15 RID: 16149 RVA: 0x000D3960 File Offset: 0x000D1B60
		[Nullable(2)]
		public ExecutionContext ExecutionContext
		{
			[NullableContext(2)]
			get
			{
				return ExecutionContext.Capture();
			}
		}

		// Token: 0x17000B95 RID: 2965
		// (get) Token: 0x06003F16 RID: 16150 RVA: 0x000D3967 File Offset: 0x000D1B67
		// (set) Token: 0x06003F17 RID: 16151 RVA: 0x000D3970 File Offset: 0x000D1B70
		[Nullable(2)]
		public string Name
		{
			[NullableContext(2)]
			get
			{
				return this._name;
			}
			[NullableContext(2)]
			set
			{
				lock (this)
				{
					if (this._name != value)
					{
						this._name = value;
						this.ThreadNameChanged(value);
						this._mayNeedResetForThreadPool = true;
					}
				}
			}
		}

		// Token: 0x06003F18 RID: 16152 RVA: 0x000D39C8 File Offset: 0x000D1BC8
		internal void SetThreadPoolWorkerThreadName()
		{
			lock (this)
			{
				this._name = ".NET TP Worker";
				this.ThreadNameChanged(".NET TP Worker");
			}
		}

		// Token: 0x06003F19 RID: 16153 RVA: 0x000D3A14 File Offset: 0x000D1C14
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void ResetThreadPoolThread()
		{
			if (this._mayNeedResetForThreadPool)
			{
				this.ResetThreadPoolThreadSlow();
			}
		}

		// Token: 0x06003F1A RID: 16154 RVA: 0x000D3A24 File Offset: 0x000D1C24
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void ResetThreadPoolThreadSlow()
		{
			this._mayNeedResetForThreadPool = false;
			if (this._name != ".NET TP Worker")
			{
				this.SetThreadPoolWorkerThreadName();
			}
			if (!this.IsBackground)
			{
				this.IsBackground = true;
			}
			if (this.Priority != ThreadPriority.Normal)
			{
				this.Priority = ThreadPriority.Normal;
			}
		}

		// Token: 0x06003F1B RID: 16155 RVA: 0x000D3A64 File Offset: 0x000D1C64
		[Obsolete("Thread.Abort is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0006", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public void Abort()
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ThreadAbort);
		}

		// Token: 0x06003F1C RID: 16156 RVA: 0x000D3A64 File Offset: 0x000D1C64
		[NullableContext(2)]
		[Obsolete("Thread.Abort is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0006", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public void Abort(object stateInfo)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ThreadAbort);
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x000D3A64 File Offset: 0x000D1C64
		[Obsolete("Thread.ResetAbort is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0006", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public static void ResetAbort()
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ThreadAbort);
		}

		// Token: 0x06003F1E RID: 16158 RVA: 0x000D3A70 File Offset: 0x000D1C70
		[Obsolete("Thread.Suspend has been deprecated. Use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.")]
		public void Suspend()
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ThreadSuspend);
		}

		// Token: 0x06003F1F RID: 16159 RVA: 0x000D3A70 File Offset: 0x000D1C70
		[Obsolete("Thread.Resume has been deprecated. Use other classes in System.Threading, such as Monitor, Mutex, Event, and Semaphore, to synchronize Threads or protect resources.")]
		public void Resume()
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ThreadSuspend);
		}

		// Token: 0x06003F20 RID: 16160 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public static void BeginCriticalRegion()
		{
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public static void EndCriticalRegion()
		{
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public static void BeginThreadAffinity()
		{
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public static void EndThreadAffinity()
		{
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x000D3A7C File Offset: 0x000D1C7C
		public static LocalDataStoreSlot AllocateDataSlot()
		{
			return Thread.LocalDataStore.AllocateSlot();
		}

		// Token: 0x06003F25 RID: 16165 RVA: 0x000D3A83 File Offset: 0x000D1C83
		public static LocalDataStoreSlot AllocateNamedDataSlot(string name)
		{
			return Thread.LocalDataStore.AllocateNamedSlot(name);
		}

		// Token: 0x06003F26 RID: 16166 RVA: 0x000D3A8B File Offset: 0x000D1C8B
		public static LocalDataStoreSlot GetNamedDataSlot(string name)
		{
			return Thread.LocalDataStore.GetNamedSlot(name);
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x000D3A93 File Offset: 0x000D1C93
		public static void FreeNamedDataSlot(string name)
		{
			Thread.LocalDataStore.FreeNamedSlot(name);
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x000D3A9B File Offset: 0x000D1C9B
		[return: Nullable(2)]
		public static object GetData(LocalDataStoreSlot slot)
		{
			return Thread.LocalDataStore.GetData(slot);
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x000D3AA3 File Offset: 0x000D1CA3
		public static void SetData(LocalDataStoreSlot slot, [Nullable(2)] object data)
		{
			Thread.LocalDataStore.SetData(slot, data);
		}

		// Token: 0x17000B96 RID: 2966
		// (get) Token: 0x06003F2A RID: 16170 RVA: 0x000D3AAC File Offset: 0x000D1CAC
		// (set) Token: 0x06003F2B RID: 16171 RVA: 0x000D3AB0 File Offset: 0x000D1CB0
		[Obsolete("The ApartmentState property has been deprecated. Use GetApartmentState, SetApartmentState or TrySetApartmentState instead.")]
		public ApartmentState ApartmentState
		{
			get
			{
				return ApartmentState.Unknown;
			}
			set
			{
				this.TrySetApartmentState(value);
			}
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x000D3ABA File Offset: 0x000D1CBA
		[SupportedOSPlatform("windows")]
		public void SetApartmentState(ApartmentState state)
		{
			this.SetApartmentState(state, true);
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x000D3AC5 File Offset: 0x000D1CC5
		public bool TrySetApartmentState(ApartmentState state)
		{
			return this.SetApartmentState(state, false);
		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x000D3ACF File Offset: 0x000D1CCF
		private bool SetApartmentState(ApartmentState state, bool throwOnError)
		{
			if (state > ApartmentState.Unknown)
			{
				throw new ArgumentOutOfRangeException("state", SR.ArgumentOutOfRange_Enum);
			}
			return Thread.SetApartmentStateUnchecked(state, throwOnError);
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x000D3AEC File Offset: 0x000D1CEC
		[Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public CompressedStack GetCompressedStack()
		{
			throw new InvalidOperationException(SR.Thread_GetSetCompressedStack_NotSupported);
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x000D3AEC File Offset: 0x000D1CEC
		[Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public void SetCompressedStack(CompressedStack stack)
		{
			throw new InvalidOperationException(SR.Thread_GetSetCompressedStack_NotSupported);
		}

		// Token: 0x06003F31 RID: 16177 RVA: 0x000D3AF8 File Offset: 0x000D1CF8
		public static AppDomain GetDomain()
		{
			return AppDomain.CurrentDomain;
		}

		// Token: 0x06003F32 RID: 16178 RVA: 0x000070DD File Offset: 0x000052DD
		public static int GetDomainID()
		{
			return 1;
		}

		// Token: 0x06003F33 RID: 16179 RVA: 0x000D3AFF File Offset: 0x000D1CFF
		public override int GetHashCode()
		{
			return this.ManagedThreadId;
		}

		// Token: 0x06003F34 RID: 16180 RVA: 0x000D3B07 File Offset: 0x000D1D07
		public void Join()
		{
			this.Join(-1);
		}

		// Token: 0x06003F35 RID: 16181 RVA: 0x000D3B11 File Offset: 0x000D1D11
		public bool Join(TimeSpan timeout)
		{
			return this.Join(WaitHandle.ToTimeoutMilliseconds(timeout));
		}

		// Token: 0x06003F36 RID: 16182 RVA: 0x000D2E40 File Offset: 0x000D1040
		public static void MemoryBarrier()
		{
			Interlocked.MemoryBarrier();
		}

		// Token: 0x06003F37 RID: 16183 RVA: 0x000D3B1F File Offset: 0x000D1D1F
		public static void Sleep(TimeSpan timeout)
		{
			Thread.Sleep(WaitHandle.ToTimeoutMilliseconds(timeout));
		}

		// Token: 0x06003F38 RID: 16184 RVA: 0x000D3B2C File Offset: 0x000D1D2C
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static byte VolatileRead(ref byte address)
		{
			return Volatile.Read(ref address);
		}

		// Token: 0x06003F39 RID: 16185 RVA: 0x000D3B34 File Offset: 0x000D1D34
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static double VolatileRead(ref double address)
		{
			return Volatile.Read(ref address);
		}

		// Token: 0x06003F3A RID: 16186 RVA: 0x000D3B3C File Offset: 0x000D1D3C
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static short VolatileRead(ref short address)
		{
			return Volatile.Read(ref address);
		}

		// Token: 0x06003F3B RID: 16187 RVA: 0x000D3B44 File Offset: 0x000D1D44
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static int VolatileRead(ref int address)
		{
			return Volatile.Read(ref address);
		}

		// Token: 0x06003F3C RID: 16188 RVA: 0x000D3B4C File Offset: 0x000D1D4C
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static long VolatileRead(ref long address)
		{
			return Volatile.Read(ref address);
		}

		// Token: 0x06003F3D RID: 16189 RVA: 0x000D3B54 File Offset: 0x000D1D54
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static IntPtr VolatileRead(ref IntPtr address)
		{
			return Volatile.Read(ref address);
		}

		// Token: 0x06003F3E RID: 16190 RVA: 0x000D3B5C File Offset: 0x000D1D5C
		[NullableContext(2)]
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[return: NotNullIfNotNull("address")]
		public static object VolatileRead([NotNullIfNotNull("address")] ref object address)
		{
			return Volatile.Read<object>(ref address);
		}

		// Token: 0x06003F3F RID: 16191 RVA: 0x000D3B64 File Offset: 0x000D1D64
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[CLSCompliant(false)]
		public static sbyte VolatileRead(ref sbyte address)
		{
			return Volatile.Read(ref address);
		}

		// Token: 0x06003F40 RID: 16192 RVA: 0x000D3B6C File Offset: 0x000D1D6C
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static float VolatileRead(ref float address)
		{
			return Volatile.Read(ref address);
		}

		// Token: 0x06003F41 RID: 16193 RVA: 0x000D3B74 File Offset: 0x000D1D74
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[CLSCompliant(false)]
		public static ushort VolatileRead(ref ushort address)
		{
			return Volatile.Read(ref address);
		}

		// Token: 0x06003F42 RID: 16194 RVA: 0x000D3B7C File Offset: 0x000D1D7C
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[CLSCompliant(false)]
		public static uint VolatileRead(ref uint address)
		{
			return Volatile.Read(ref address);
		}

		// Token: 0x06003F43 RID: 16195 RVA: 0x000D3B84 File Offset: 0x000D1D84
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[CLSCompliant(false)]
		public static ulong VolatileRead(ref ulong address)
		{
			return Volatile.Read(ref address);
		}

		// Token: 0x06003F44 RID: 16196 RVA: 0x000D3B8C File Offset: 0x000D1D8C
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[CLSCompliant(false)]
		public static UIntPtr VolatileRead(ref UIntPtr address)
		{
			return Volatile.Read(ref address);
		}

		// Token: 0x06003F45 RID: 16197 RVA: 0x000D3B94 File Offset: 0x000D1D94
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void VolatileWrite(ref byte address, byte value)
		{
			Volatile.Write(ref address, value);
		}

		// Token: 0x06003F46 RID: 16198 RVA: 0x000D3B9D File Offset: 0x000D1D9D
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void VolatileWrite(ref double address, double value)
		{
			Volatile.Write(ref address, value);
		}

		// Token: 0x06003F47 RID: 16199 RVA: 0x000D3BA6 File Offset: 0x000D1DA6
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void VolatileWrite(ref short address, short value)
		{
			Volatile.Write(ref address, value);
		}

		// Token: 0x06003F48 RID: 16200 RVA: 0x000D3BAF File Offset: 0x000D1DAF
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void VolatileWrite(ref int address, int value)
		{
			Volatile.Write(ref address, value);
		}

		// Token: 0x06003F49 RID: 16201 RVA: 0x000D3BB8 File Offset: 0x000D1DB8
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void VolatileWrite(ref long address, long value)
		{
			Volatile.Write(ref address, value);
		}

		// Token: 0x06003F4A RID: 16202 RVA: 0x000D3BC1 File Offset: 0x000D1DC1
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void VolatileWrite(ref IntPtr address, IntPtr value)
		{
			Volatile.Write(ref address, value);
		}

		// Token: 0x06003F4B RID: 16203 RVA: 0x000D3BCA File Offset: 0x000D1DCA
		[NullableContext(2)]
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void VolatileWrite([NotNullIfNotNull("value")] ref object address, object value)
		{
			Volatile.Write<object>(ref address, value);
		}

		// Token: 0x06003F4C RID: 16204 RVA: 0x000D3BD3 File Offset: 0x000D1DD3
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[CLSCompliant(false)]
		public static void VolatileWrite(ref sbyte address, sbyte value)
		{
			Volatile.Write(ref address, value);
		}

		// Token: 0x06003F4D RID: 16205 RVA: 0x000D3BDC File Offset: 0x000D1DDC
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public static void VolatileWrite(ref float address, float value)
		{
			Volatile.Write(ref address, value);
		}

		// Token: 0x06003F4E RID: 16206 RVA: 0x000D3BE5 File Offset: 0x000D1DE5
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[CLSCompliant(false)]
		public static void VolatileWrite(ref ushort address, ushort value)
		{
			Volatile.Write(ref address, value);
		}

		// Token: 0x06003F4F RID: 16207 RVA: 0x000D3BEE File Offset: 0x000D1DEE
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[CLSCompliant(false)]
		public static void VolatileWrite(ref uint address, uint value)
		{
			Volatile.Write(ref address, value);
		}

		// Token: 0x06003F50 RID: 16208 RVA: 0x000D3BF7 File Offset: 0x000D1DF7
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[CLSCompliant(false)]
		public static void VolatileWrite(ref ulong address, ulong value)
		{
			Volatile.Write(ref address, value);
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x000D3C00 File Offset: 0x000D1E00
		[Obsolete("Thread.VolatileRead and Thread.VolatileWrite are obsolete. Use Volatile.Read or Volatile.Write respectively instead.", DiagnosticId = "SYSLIB0054", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[CLSCompliant(false)]
		public static void VolatileWrite(ref UIntPtr address, UIntPtr value)
		{
			Volatile.Write(ref address, value);
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x000D3C09 File Offset: 0x000D1E09
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int GetCurrentProcessorId()
		{
			return ProcessorIdCache.GetCurrentProcessorId();
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x000D3C10 File Offset: 0x000D1E10
		internal static void UninterruptibleSleep0()
		{
			Interop.Kernel32.Sleep(0U);
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x000D3C18 File Offset: 0x000D1E18
		private static void SleepInternal(int millisecondsTimeout)
		{
			Interop.Kernel32.Sleep((uint)millisecondsTimeout);
		}

		// Token: 0x06003F55 RID: 16213 RVA: 0x000D3C20 File Offset: 0x000D1E20
		internal static int GetCurrentProcessorNumber()
		{
			Interop.Kernel32.PROCESSOR_NUMBER processor_NUMBER;
			Interop.Kernel32.GetCurrentProcessorNumberEx(out processor_NUMBER);
			return (int)processor_NUMBER.Group << 6 | (int)processor_NUMBER.Number;
		}

		// Token: 0x04000CE2 RID: 3298
		private int lock_thread_id;

		// Token: 0x04000CE3 RID: 3299
		private IntPtr handle;

		// Token: 0x04000CE4 RID: 3300
		private IntPtr native_handle;

		// Token: 0x04000CE5 RID: 3301
		private IntPtr name;

		// Token: 0x04000CE6 RID: 3302
		private int name_free;

		// Token: 0x04000CE7 RID: 3303
		private int name_length;

		// Token: 0x04000CE8 RID: 3304
		private ThreadState state;

		// Token: 0x04000CE9 RID: 3305
		private object abort_exc;

		// Token: 0x04000CEA RID: 3306
		private int abort_state_handle;

		// Token: 0x04000CEB RID: 3307
		internal long thread_id;

		// Token: 0x04000CEC RID: 3308
		private IntPtr debugger_thread;

		// Token: 0x04000CED RID: 3309
		private UIntPtr static_data;

		// Token: 0x04000CEE RID: 3310
		private IntPtr runtime_thread_info;

		// Token: 0x04000CEF RID: 3311
		private int interruption_requested;

		// Token: 0x04000CF0 RID: 3312
		private IntPtr longlived;

		// Token: 0x04000CF1 RID: 3313
		internal bool threadpool_thread;

		// Token: 0x04000CF2 RID: 3314
		internal bool external_eventloop;

		// Token: 0x04000CF3 RID: 3315
		internal byte apartment_state;

		// Token: 0x04000CF4 RID: 3316
		internal int managed_id;

		// Token: 0x04000CF5 RID: 3317
		private int small_id;

		// Token: 0x04000CF6 RID: 3318
		private IntPtr manage_callback;

		// Token: 0x04000CF7 RID: 3319
		private IntPtr flags;

		// Token: 0x04000CF8 RID: 3320
		private IntPtr thread_pinning_ref;

		// Token: 0x04000CF9 RID: 3321
		private int priority;

		// Token: 0x04000CFA RID: 3322
		private IntPtr owned_mutex;

		// Token: 0x04000CFB RID: 3323
		private IntPtr suspended_event;

		// Token: 0x04000CFC RID: 3324
		private int self_suspended;

		// Token: 0x04000CFD RID: 3325
		private IntPtr thread_state;

		// Token: 0x04000CFE RID: 3326
		private Thread self;

		// Token: 0x04000CFF RID: 3327
		private object pending_exception;

		// Token: 0x04000D00 RID: 3328
		private IntPtr last;

		// Token: 0x04000D01 RID: 3329
		private string _name;

		// Token: 0x04000D02 RID: 3330
		private Thread.StartHelper _startHelper;

		// Token: 0x04000D03 RID: 3331
		internal ExecutionContext _executionContext;

		// Token: 0x04000D04 RID: 3332
		internal SynchronizationContext _synchronizationContext;

		// Token: 0x04000D05 RID: 3333
		private bool _mayNeedResetForThreadPool;

		// Token: 0x04000D06 RID: 3334
		private static AsyncLocal<IPrincipal> s_asyncLocalPrincipal;

		// Token: 0x04000D07 RID: 3335
		[ThreadStatic]
		private static Thread t_currentThread;

		// Token: 0x020003C3 RID: 963
		private sealed class StartHelper
		{
			// Token: 0x06003F56 RID: 16214 RVA: 0x000D3C44 File Offset: 0x000D1E44
			internal StartHelper(Delegate start)
			{
				this._start = start;
			}

			// Token: 0x06003F57 RID: 16215 RVA: 0x000D3C53 File Offset: 0x000D1E53
			private static void Callback(object state)
			{
				((Thread.StartHelper)state).RunWorker();
			}

			// Token: 0x06003F58 RID: 16216 RVA: 0x000D3C60 File Offset: 0x000D1E60
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal void Run()
			{
				if (this._executionContext != null && !this._executionContext.IsDefault)
				{
					ExecutionContext.RunInternal(this._executionContext, Thread.StartHelper.s_threadStartContextCallback, this);
					return;
				}
				this.RunWorker();
			}

			// Token: 0x06003F59 RID: 16217 RVA: 0x000D3C90 File Offset: 0x000D1E90
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private void RunWorker()
			{
				this.InitializeCulture();
				Delegate start = this._start;
				this._start = null;
				ThreadStart threadStart = start as ThreadStart;
				if (threadStart != null)
				{
					threadStart();
					return;
				}
				ParameterizedThreadStart parameterizedThreadStart = (ParameterizedThreadStart)start;
				object startArg = this._startArg;
				this._startArg = null;
				parameterizedThreadStart(startArg);
			}

			// Token: 0x06003F5A RID: 16218 RVA: 0x000D3CDC File Offset: 0x000D1EDC
			private void InitializeCulture()
			{
				if (this._culture != null)
				{
					CultureInfo.CurrentCulture = this._culture;
					this._culture = null;
				}
				if (this._uiCulture != null)
				{
					CultureInfo.CurrentUICulture = this._uiCulture;
					this._uiCulture = null;
				}
			}

			// Token: 0x04000D08 RID: 3336
			internal int _maxStackSize;

			// Token: 0x04000D09 RID: 3337
			internal Delegate _start;

			// Token: 0x04000D0A RID: 3338
			internal object _startArg;

			// Token: 0x04000D0B RID: 3339
			internal CultureInfo _culture;

			// Token: 0x04000D0C RID: 3340
			internal CultureInfo _uiCulture;

			// Token: 0x04000D0D RID: 3341
			internal ExecutionContext _executionContext;

			// Token: 0x04000D0E RID: 3342
			internal static readonly ContextCallback s_threadStartContextCallback = new ContextCallback(Thread.StartHelper.Callback);
		}

		// Token: 0x020003C4 RID: 964
		private static class LocalDataStore
		{
			// Token: 0x06003F5C RID: 16220 RVA: 0x000D3D25 File Offset: 0x000D1F25
			public static LocalDataStoreSlot AllocateSlot()
			{
				return new LocalDataStoreSlot(new ThreadLocal<object>());
			}

			// Token: 0x06003F5D RID: 16221 RVA: 0x000D3D34 File Offset: 0x000D1F34
			private static Dictionary<string, LocalDataStoreSlot> EnsureNameToSlotMap()
			{
				Dictionary<string, LocalDataStoreSlot> dictionary = Thread.LocalDataStore.s_nameToSlotMap;
				if (dictionary != null)
				{
					return dictionary;
				}
				dictionary = new Dictionary<string, LocalDataStoreSlot>();
				return Interlocked.CompareExchange<Dictionary<string, LocalDataStoreSlot>>(ref Thread.LocalDataStore.s_nameToSlotMap, dictionary, null) ?? dictionary;
			}

			// Token: 0x06003F5E RID: 16222 RVA: 0x000D3D64 File Offset: 0x000D1F64
			public static LocalDataStoreSlot AllocateNamedSlot(string name)
			{
				LocalDataStoreSlot localDataStoreSlot = Thread.LocalDataStore.AllocateSlot();
				Dictionary<string, LocalDataStoreSlot> dictionary = Thread.LocalDataStore.EnsureNameToSlotMap();
				Dictionary<string, LocalDataStoreSlot> obj = dictionary;
				lock (obj)
				{
					dictionary.Add(name, localDataStoreSlot);
				}
				return localDataStoreSlot;
			}

			// Token: 0x06003F5F RID: 16223 RVA: 0x000D3DB0 File Offset: 0x000D1FB0
			public static LocalDataStoreSlot GetNamedSlot(string name)
			{
				Dictionary<string, LocalDataStoreSlot> dictionary = Thread.LocalDataStore.EnsureNameToSlotMap();
				Dictionary<string, LocalDataStoreSlot> obj = dictionary;
				LocalDataStoreSlot result;
				lock (obj)
				{
					LocalDataStoreSlot localDataStoreSlot;
					if (!dictionary.TryGetValue(name, out localDataStoreSlot))
					{
						localDataStoreSlot = Thread.LocalDataStore.AllocateSlot();
						dictionary[name] = localDataStoreSlot;
					}
					result = localDataStoreSlot;
				}
				return result;
			}

			// Token: 0x06003F60 RID: 16224 RVA: 0x000D3E0C File Offset: 0x000D200C
			public static void FreeNamedSlot(string name)
			{
				Dictionary<string, LocalDataStoreSlot> dictionary = Thread.LocalDataStore.EnsureNameToSlotMap();
				Dictionary<string, LocalDataStoreSlot> obj = dictionary;
				lock (obj)
				{
					dictionary.Remove(name);
				}
			}

			// Token: 0x06003F61 RID: 16225 RVA: 0x000D3E50 File Offset: 0x000D2050
			private static ThreadLocal<object> GetThreadLocal(LocalDataStoreSlot slot)
			{
				ArgumentNullException.ThrowIfNull(slot, "slot");
				return slot.Data;
			}

			// Token: 0x06003F62 RID: 16226 RVA: 0x000D3E63 File Offset: 0x000D2063
			public static object GetData(LocalDataStoreSlot slot)
			{
				return Thread.LocalDataStore.GetThreadLocal(slot).Value;
			}

			// Token: 0x06003F63 RID: 16227 RVA: 0x000D3E70 File Offset: 0x000D2070
			public static void SetData(LocalDataStoreSlot slot, object value)
			{
				Thread.LocalDataStore.GetThreadLocal(slot).Value = value;
			}

			// Token: 0x04000D0F RID: 3343
			private static Dictionary<string, LocalDataStoreSlot> s_nameToSlotMap;
		}
	}
}
