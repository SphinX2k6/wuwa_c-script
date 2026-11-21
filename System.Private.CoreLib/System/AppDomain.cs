using System;
using System.Configuration.Assemblies;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.Loader;
using System.Runtime.Remoting;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
using System.Threading;

namespace System
{
	// Token: 0x020000C7 RID: 199
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class AppDomain : MarshalByRefObject
	{
		// Token: 0x06000963 RID: 2403 RVA: 0x0001DA88 File Offset: 0x0001BC88
		private AppDomain()
		{
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x0001DA97 File Offset: 0x0001BC97
		public static AppDomain CurrentDomain
		{
			get
			{
				if (AppDomain.s_domain == null)
				{
					Interlocked.CompareExchange<AppDomain>(ref AppDomain.s_domain, new AppDomain(), null);
				}
				return AppDomain.s_domain;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x0001DAB6 File Offset: 0x0001BCB6
		public string BaseDirectory
		{
			get
			{
				return AppContext.BaseDirectory;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x0001A4BA File Offset: 0x000186BA
		[Nullable(2)]
		public string RelativeSearchPath
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x0001DABD File Offset: 0x0001BCBD
		public AppDomainSetup SetupInformation
		{
			get
			{
				return new AppDomainSetup();
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x0001DAC4 File Offset: 0x0001BCC4
		[Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public PermissionSet PermissionSet
		{
			get
			{
				return new PermissionSet(PermissionState.Unrestricted);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000969 RID: 2409 RVA: 0x0001DACC File Offset: 0x0001BCCC
		// (remove) Token: 0x0600096A RID: 2410 RVA: 0x0001DAD4 File Offset: 0x0001BCD4
		[Nullable(2)]
		public event UnhandledExceptionEventHandler UnhandledException
		{
			[NullableContext(2)]
			add
			{
				AppContext.UnhandledException += value;
			}
			[NullableContext(2)]
			remove
			{
				AppContext.UnhandledException -= value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x0001A4BA File Offset: 0x000186BA
		[Nullable(2)]
		public string DynamicDirectory
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[NullableContext(2)]
		[Obsolete("AppDomain.SetDynamicBase has been deprecated and is not supported.")]
		public void SetDynamicBase(string path)
		{
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x0001DADC File Offset: 0x0001BCDC
		public string FriendlyName
		{
			get
			{
				Assembly entryAssembly = Assembly.GetEntryAssembly();
				if (!(entryAssembly != null))
				{
					return "DefaultDomain";
				}
				return entryAssembly.GetName().Name;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x000070DD File Offset: 0x000052DD
		public int Id
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x000070DD File Offset: 0x000052DD
		public bool IsFullyTrusted
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x000070DD File Offset: 0x000052DD
		public bool IsHomogenous
		{
			get
			{
				return true;
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000971 RID: 2417 RVA: 0x0001DB0C File Offset: 0x0001BD0C
		// (remove) Token: 0x06000972 RID: 2418 RVA: 0x0001DB44 File Offset: 0x0001BD44
		[Nullable(2)]
		[method: NullableContext(2)]
		public event EventHandler DomainUnload;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000973 RID: 2419 RVA: 0x0001DB79 File Offset: 0x0001BD79
		// (remove) Token: 0x06000974 RID: 2420 RVA: 0x0001DB81 File Offset: 0x0001BD81
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event EventHandler<FirstChanceExceptionEventArgs> FirstChanceException
		{
			add
			{
				AppContext.FirstChanceException += value;
			}
			remove
			{
				AppContext.FirstChanceException -= value;
			}
		}

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000975 RID: 2421 RVA: 0x0001DB8C File Offset: 0x0001BD8C
		// (remove) Token: 0x06000976 RID: 2422 RVA: 0x0001DBC4 File Offset: 0x0001BDC4
		[Nullable(2)]
		[method: NullableContext(2)]
		public event EventHandler ProcessExit;

		// Token: 0x06000977 RID: 2423 RVA: 0x0001DBFC File Offset: 0x0001BDFC
		internal static void OnProcessExit()
		{
			AppDomain appDomain = AppDomain.s_domain;
			if (appDomain != null)
			{
				EventHandler processExit = appDomain.ProcessExit;
				if (processExit == null)
				{
					return;
				}
				processExit(appDomain, EventArgs.Empty);
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x0001DC28 File Offset: 0x0001BE28
		public string ApplyPolicy(string assemblyName)
		{
			ArgumentException.ThrowIfNullOrEmpty(assemblyName, "assemblyName");
			if (assemblyName[0] == '\0')
			{
				throw new ArgumentException(SR.Argument_EmptyString, "assemblyName");
			}
			return assemblyName;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0001DC4F File Offset: 0x0001BE4F
		[Obsolete("Creating and unloading AppDomains is not supported and throws an exception.", DiagnosticId = "SYSLIB0024", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public static AppDomain CreateDomain(string friendlyName)
		{
			ArgumentNullException.ThrowIfNull(friendlyName, "friendlyName");
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_AppDomains);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0001DC66 File Offset: 0x0001BE66
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		public int ExecuteAssembly(string assemblyFile)
		{
			return this.ExecuteAssembly(assemblyFile, null);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0001DC70 File Offset: 0x0001BE70
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		public int ExecuteAssembly(string assemblyFile, [Nullable(2)] string[] args)
		{
			ArgumentNullException.ThrowIfNull(assemblyFile, "assemblyFile");
			return AppDomain.ExecuteAssembly(Assembly.LoadFile(Path.GetFullPath(assemblyFile)), args);
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0001DC8E File Offset: 0x0001BE8E
		[NullableContext(2)]
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		[Obsolete("Code Access Security is not supported or honored by the runtime.", DiagnosticId = "SYSLIB0003", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public int ExecuteAssembly([Nullable(1)] string assemblyFile, string[] args, byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_CAS);
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0001DC9C File Offset: 0x0001BE9C
		private static int ExecuteAssembly(Assembly assembly, string[] args)
		{
			MethodInfo entryPoint = assembly.EntryPoint;
			if (entryPoint == null)
			{
				throw new MissingMethodException(SR.Arg_EntryPointNotFoundException);
			}
			MethodInfo methodInfo = entryPoint;
			MethodBase methodBase = methodInfo;
			object obj = null;
			BindingFlags invokeAttr = BindingFlags.DoNotWrapExceptions;
			Binder binder = null;
			object parameters;
			if (methodInfo.GetParametersAsSpan().Length <= 0)
			{
				parameters = null;
			}
			else
			{
				(parameters = new object[1])[0] = args;
			}
			object obj2 = methodBase.Invoke(obj, invokeAttr, binder, parameters, null);
			if (obj2 == null)
			{
				return 0;
			}
			return (int)obj2;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0001DCF7 File Offset: 0x0001BEF7
		public int ExecuteAssemblyByName(AssemblyName assemblyName, [Nullable(2)] params string[] args)
		{
			return AppDomain.ExecuteAssembly(Assembly.Load(assemblyName), args);
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0001DD05 File Offset: 0x0001BF05
		public int ExecuteAssemblyByName(string assemblyName)
		{
			return this.ExecuteAssemblyByName(assemblyName, null);
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0001DD0F File Offset: 0x0001BF0F
		public int ExecuteAssemblyByName(string assemblyName, [Nullable(2)] params string[] args)
		{
			return AppDomain.ExecuteAssembly(Assembly.Load(assemblyName), args);
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x0001DD1D File Offset: 0x0001BF1D
		[return: Nullable(2)]
		public object GetData(string name)
		{
			return AppContext.GetData(name);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x0001DD25 File Offset: 0x0001BF25
		public void SetData(string name, [Nullable(2)] object data)
		{
			AppContext.SetData(name, data);
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x0001DD30 File Offset: 0x0001BF30
		public bool? IsCompatibilitySwitchSet(string value)
		{
			bool value2;
			if (!AppContext.TryGetSwitch(value, out value2))
			{
				return null;
			}
			return new bool?(value2);
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x000070DD File Offset: 0x000052DD
		public bool IsDefaultAppDomain()
		{
			return true;
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00007B65 File Offset: 0x00005D65
		public bool IsFinalizingForUnload()
		{
			return false;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0001DD57 File Offset: 0x0001BF57
		public override string ToString()
		{
			return SR.AppDomain_Name + this.FriendlyName + "\r\n" + SR.AppDomain_NoContextPolicies;
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0001DD73 File Offset: 0x0001BF73
		[Obsolete("Creating and unloading AppDomains is not supported and throws an exception.", DiagnosticId = "SYSLIB0024", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public static void Unload(AppDomain domain)
		{
			ArgumentNullException.ThrowIfNull(domain, "domain");
			throw new CannotUnloadAppDomainException(SR.Arg_PlatformNotSupported);
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x0001DD8A File Offset: 0x0001BF8A
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		public Assembly Load(byte[] rawAssembly)
		{
			return Assembly.Load(rawAssembly);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x0001DD92 File Offset: 0x0001BF92
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		public Assembly Load(byte[] rawAssembly, [Nullable(2)] byte[] rawSymbolStore)
		{
			return Assembly.Load(rawAssembly, rawSymbolStore);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0001DD9B File Offset: 0x0001BF9B
		public Assembly Load(AssemblyName assemblyRef)
		{
			return Assembly.Load(assemblyRef);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x0001DDA3 File Offset: 0x0001BFA3
		public Assembly Load(string assemblyString)
		{
			return Assembly.Load(assemblyString);
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x0001DDAB File Offset: 0x0001BFAB
		public Assembly[] ReflectionOnlyGetAssemblies()
		{
			return Array.Empty<Assembly>();
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x000070DD File Offset: 0x000052DD
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x0001DDB2 File Offset: 0x0001BFB2
		public static bool MonitoringIsEnabled
		{
			get
			{
				return true;
			}
			set
			{
				if (!value)
				{
					throw new ArgumentException(SR.Arg_MustBeTrue);
				}
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x0001DDC2 File Offset: 0x0001BFC2
		public long MonitoringSurvivedMemorySize
		{
			get
			{
				return AppDomain.MonitoringSurvivedProcessMemorySize;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0001DDCC File Offset: 0x0001BFCC
		public static long MonitoringSurvivedProcessMemorySize
		{
			get
			{
				GCMemoryInfo gcmemoryInfo = GC.GetGCMemoryInfo();
				return gcmemoryInfo.HeapSizeBytes - gcmemoryInfo.FragmentedBytes;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x0001DDEE File Offset: 0x0001BFEE
		public long MonitoringTotalAllocatedMemorySize
		{
			get
			{
				return GC.GetTotalAllocatedBytes(false);
			}
		}

		// Token: 0x06000992 RID: 2450 RVA: 0x0001DDF6 File Offset: 0x0001BFF6
		[Obsolete("AppDomain.GetCurrentThreadId has been deprecated because it does not provide a stable Id when managed threads are running on fibers (aka lightweight threads). To get a stable identifier for a managed thread, use the ManagedThreadId property on Thread instead.")]
		public static int GetCurrentThreadId()
		{
			return Environment.CurrentManagedThreadId;
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x00007B65 File Offset: 0x00005D65
		public bool ShadowCopyFiles
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[NullableContext(2)]
		[Obsolete("AppDomain.AppendPrivatePath has been deprecated and is not supported.")]
		public void AppendPrivatePath(string path)
		{
		}

		// Token: 0x06000995 RID: 2453 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[Obsolete("AppDomain.ClearPrivatePath has been deprecated and is not supported.")]
		public void ClearPrivatePath()
		{
		}

		// Token: 0x06000996 RID: 2454 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[Obsolete("AppDomain.ClearShadowCopyPath has been deprecated and is not supported.")]
		public void ClearShadowCopyPath()
		{
		}

		// Token: 0x06000997 RID: 2455 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[NullableContext(2)]
		[Obsolete("AppDomain.SetCachePath has been deprecated and is not supported.")]
		public void SetCachePath(string path)
		{
		}

		// Token: 0x06000998 RID: 2456 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[Obsolete("AppDomain.SetShadowCopyFiles has been deprecated and is not supported.")]
		public void SetShadowCopyFiles()
		{
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[NullableContext(2)]
		[Obsolete("AppDomain.SetShadowCopyPath has been deprecated and is not supported.")]
		public void SetShadowCopyPath(string path)
		{
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x0001DDFD File Offset: 0x0001BFFD
		public Assembly[] GetAssemblies()
		{
			return AssemblyLoadContext.GetLoadedAssemblies();
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600099B RID: 2459 RVA: 0x0001DE04 File Offset: 0x0001C004
		// (remove) Token: 0x0600099C RID: 2460 RVA: 0x0001DE0C File Offset: 0x0001C00C
		[Nullable(2)]
		public event AssemblyLoadEventHandler AssemblyLoad
		{
			[NullableContext(2)]
			add
			{
				AssemblyLoadContext.AssemblyLoad += value;
			}
			[NullableContext(2)]
			remove
			{
				AssemblyLoadContext.AssemblyLoad -= value;
			}
		}

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600099D RID: 2461 RVA: 0x0001DE14 File Offset: 0x0001C014
		// (remove) Token: 0x0600099E RID: 2462 RVA: 0x0001DE1C File Offset: 0x0001C01C
		[Nullable(2)]
		public event ResolveEventHandler AssemblyResolve
		{
			[NullableContext(2)]
			add
			{
				AssemblyLoadContext.AssemblyResolve += value;
			}
			[NullableContext(2)]
			remove
			{
				AssemblyLoadContext.AssemblyResolve -= value;
			}
		}

		// Token: 0x1400000A RID: 10
		// (add) Token: 0x0600099F RID: 2463 RVA: 0x0001DE24 File Offset: 0x0001C024
		// (remove) Token: 0x060009A0 RID: 2464 RVA: 0x0001DE5C File Offset: 0x0001C05C
		[Nullable(2)]
		[method: NullableContext(2)]
		public event ResolveEventHandler ReflectionOnlyAssemblyResolve;

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060009A1 RID: 2465 RVA: 0x0001DE91 File Offset: 0x0001C091
		// (remove) Token: 0x060009A2 RID: 2466 RVA: 0x0001DE99 File Offset: 0x0001C099
		[Nullable(2)]
		public event ResolveEventHandler TypeResolve
		{
			[NullableContext(2)]
			add
			{
				AssemblyLoadContext.TypeResolve += value;
			}
			[NullableContext(2)]
			remove
			{
				AssemblyLoadContext.TypeResolve -= value;
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060009A3 RID: 2467 RVA: 0x0001DEA1 File Offset: 0x0001C0A1
		// (remove) Token: 0x060009A4 RID: 2468 RVA: 0x0001DEA9 File Offset: 0x0001C0A9
		[Nullable(2)]
		public event ResolveEventHandler ResourceResolve
		{
			[NullableContext(2)]
			add
			{
				AssemblyLoadContext.ResourceResolve += value;
			}
			[NullableContext(2)]
			remove
			{
				AssemblyLoadContext.ResourceResolve -= value;
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0001DEB1 File Offset: 0x0001C0B1
		public void SetPrincipalPolicy(PrincipalPolicy policy)
		{
			this._principalPolicy = policy;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x0001DEBA File Offset: 0x0001C0BA
		public void SetThreadPrincipal(IPrincipal principal)
		{
			ArgumentNullException.ThrowIfNull(principal, "principal");
			if (Interlocked.CompareExchange<IPrincipal>(ref this._defaultPrincipal, principal, null) != null)
			{
				throw new SystemException(SR.AppDomain_Policy_PrincipalTwice);
			}
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0001DEE1 File Offset: 0x0001C0E1
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		[return: Nullable(2)]
		public ObjectHandle CreateInstance(string assemblyName, string typeName)
		{
			ArgumentNullException.ThrowIfNull(assemblyName, "assemblyName");
			return Activator.CreateInstance(assemblyName, typeName);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0001DEF5 File Offset: 0x0001C0F5
		[NullableContext(2)]
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		public ObjectHandle CreateInstance([Nullable(1)] string assemblyName, [Nullable(1)] string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			ArgumentNullException.ThrowIfNull(assemblyName, "assemblyName");
			return Activator.CreateInstance(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0001DF14 File Offset: 0x0001C114
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		[return: Nullable(2)]
		public ObjectHandle CreateInstance(string assemblyName, string typeName, [Nullable(2)] object[] activationAttributes)
		{
			ArgumentNullException.ThrowIfNull(assemblyName, "assemblyName");
			return Activator.CreateInstance(assemblyName, typeName, activationAttributes);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0001DF29 File Offset: 0x0001C129
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		[return: Nullable(2)]
		public object CreateInstanceAndUnwrap(string assemblyName, string typeName)
		{
			ObjectHandle objectHandle = this.CreateInstance(assemblyName, typeName);
			if (objectHandle == null)
			{
				return null;
			}
			return objectHandle.Unwrap();
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x0001DF40 File Offset: 0x0001C140
		[NullableContext(2)]
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		public object CreateInstanceAndUnwrap([Nullable(1)] string assemblyName, [Nullable(1)] string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			ObjectHandle objectHandle = this.CreateInstance(assemblyName, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);
			if (objectHandle == null)
			{
				return null;
			}
			return objectHandle.Unwrap();
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x0001DF6B File Offset: 0x0001C16B
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		[return: Nullable(2)]
		public object CreateInstanceAndUnwrap(string assemblyName, string typeName, [Nullable(2)] object[] activationAttributes)
		{
			ObjectHandle objectHandle = this.CreateInstance(assemblyName, typeName, activationAttributes);
			if (objectHandle == null)
			{
				return null;
			}
			return objectHandle.Unwrap();
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x0001DF81 File Offset: 0x0001C181
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		[return: Nullable(2)]
		public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName)
		{
			return Activator.CreateInstanceFrom(assemblyFile, typeName);
		}

		// Token: 0x060009AE RID: 2478 RVA: 0x0001DF8A File Offset: 0x0001C18A
		[NullableContext(2)]
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		public ObjectHandle CreateInstanceFrom([Nullable(1)] string assemblyFile, [Nullable(1)] string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			return Activator.CreateInstanceFrom(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);
		}

		// Token: 0x060009AF RID: 2479 RVA: 0x0001DF9E File Offset: 0x0001C19E
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		[return: Nullable(2)]
		public ObjectHandle CreateInstanceFrom(string assemblyFile, string typeName, [Nullable(2)] object[] activationAttributes)
		{
			return Activator.CreateInstanceFrom(assemblyFile, typeName, activationAttributes);
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x0001DFA8 File Offset: 0x0001C1A8
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		[return: Nullable(2)]
		public object CreateInstanceFromAndUnwrap(string assemblyFile, string typeName)
		{
			ObjectHandle objectHandle = this.CreateInstanceFrom(assemblyFile, typeName);
			if (objectHandle == null)
			{
				return null;
			}
			return objectHandle.Unwrap();
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x0001DFC0 File Offset: 0x0001C1C0
		[NullableContext(2)]
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		public object CreateInstanceFromAndUnwrap([Nullable(1)] string assemblyFile, [Nullable(1)] string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes)
		{
			ObjectHandle objectHandle = this.CreateInstanceFrom(assemblyFile, typeName, ignoreCase, bindingAttr, binder, args, culture, activationAttributes);
			if (objectHandle == null)
			{
				return null;
			}
			return objectHandle.Unwrap();
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x0001DFEB File Offset: 0x0001C1EB
		[RequiresUnreferencedCode("Type and its constructor could be removed")]
		[return: Nullable(2)]
		public object CreateInstanceFromAndUnwrap(string assemblyFile, string typeName, [Nullable(2)] object[] activationAttributes)
		{
			ObjectHandle objectHandle = this.CreateInstanceFrom(assemblyFile, typeName, activationAttributes);
			if (objectHandle == null)
			{
				return null;
			}
			return objectHandle.Unwrap();
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x0001E004 File Offset: 0x0001C204
		internal IPrincipal GetThreadPrincipal()
		{
			IPrincipal principal = this._defaultPrincipal;
			if (principal == null)
			{
				PrincipalPolicy principalPolicy = this._principalPolicy;
				if (principalPolicy != PrincipalPolicy.UnauthenticatedPrincipal)
				{
					if (principalPolicy == PrincipalPolicy.WindowsPrincipal)
					{
						if (this.s_getWindowsPrincipal == null)
						{
							MethodInfo method = Type.GetType("System.Security.Principal.WindowsPrincipal, System.Security.Principal.Windows", true).GetMethod("GetDefaultInstance", BindingFlags.Static | BindingFlags.NonPublic);
							if (method == null)
							{
								throw new PlatformNotSupportedException(SR.PlatformNotSupported_Principal);
							}
							MethodInfo methodInfo = method;
							this.s_getWindowsPrincipal = methodInfo.CreateDelegate<Func<IPrincipal>>();
						}
						principal = this.s_getWindowsPrincipal();
					}
				}
				else
				{
					if (this.s_getUnauthenticatedPrincipal == null)
					{
						MethodInfo method2 = Type.GetType("System.Security.Principal.GenericPrincipal, System.Security.Claims", true).GetMethod("GetDefaultInstance", BindingFlags.Static | BindingFlags.NonPublic);
						this.s_getUnauthenticatedPrincipal = method2.CreateDelegate<Func<IPrincipal>>();
					}
					principal = this.s_getUnauthenticatedPrincipal();
				}
			}
			return principal;
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x0001E0B4 File Offset: 0x0001C2B4
		public TimeSpan MonitoringTotalProcessorTime
		{
			get
			{
				long num;
				long num2;
				long num3;
				long ticks;
				if (!Interop.Kernel32.GetProcessTimes(Interop.Kernel32.GetCurrentProcess(), out num, out num2, out num3, out ticks))
				{
					return TimeSpan.Zero;
				}
				return new TimeSpan(ticks);
			}
		}

		// Token: 0x040002CA RID: 714
		private static AppDomain s_domain;

		// Token: 0x040002CB RID: 715
		private IPrincipal _defaultPrincipal;

		// Token: 0x040002CC RID: 716
		private PrincipalPolicy _principalPolicy = PrincipalPolicy.NoPrincipal;

		// Token: 0x040002CD RID: 717
		private Func<IPrincipal> s_getWindowsPrincipal;

		// Token: 0x040002CE RID: 718
		private Func<IPrincipal> s_getUnauthenticatedPrincipal;
	}
}
