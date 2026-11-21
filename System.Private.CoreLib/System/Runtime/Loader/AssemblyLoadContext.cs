using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Mono;

namespace System.Runtime.Loader
{
	// Token: 0x02000535 RID: 1333
	[NullableContext(1)]
	[Nullable(0)]
	public class AssemblyLoadContext
	{
		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x060048FC RID: 18684 RVA: 0x000F20A2 File Offset: 0x000F02A2
		internal IntPtr NativeALC
		{
			get
			{
				return this._nativeAssemblyLoadContext;
			}
		}

		// Token: 0x060048FD RID: 18685 RVA: 0x000F20AC File Offset: 0x000F02AC
		[DynamicDependency("_nativeAssemblyLoadContext")]
		private IntPtr InitializeAssemblyLoadContext(IntPtr thisHandlePtr, bool representsTPALoadContext, bool isCollectible)
		{
			if (isCollectible)
			{
				AssemblyLoadContext.KeepLoaderAllocator();
			}
			IntPtr result;
			using (SafeStringMarshal safeStringMarshal = new SafeStringMarshal(this.Name))
			{
				result = AssemblyLoadContext.InternalInitializeNativeALC(thisHandlePtr, safeStringMarshal.Value, representsTPALoadContext, isCollectible);
			}
			return result;
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[DynamicDependency(DynamicallyAccessedMemberTypes.All, typeof(LoaderAllocator))]
		private static void KeepLoaderAllocator()
		{
		}

		// Token: 0x060048FF RID: 18687
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void PrepareForAssemblyLoadContextRelease(IntPtr nativeAssemblyLoadContext, IntPtr assemblyLoadContextStrong);

		// Token: 0x06004900 RID: 18688 RVA: 0x000F2100 File Offset: 0x000F0300
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		private Assembly InternalLoadFromPath(string assemblyPath, string nativeImagePath)
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			assemblyPath = ((assemblyPath != null) ? assemblyPath.Replace('\\', Path.DirectorySeparatorChar) : null);
			return AssemblyLoadContext.InternalLoadFile(this.NativeALC, assemblyPath, ref stackCrawlMark);
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x000F2134 File Offset: 0x000F0334
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		internal unsafe Assembly InternalLoad(ReadOnlySpan<byte> arrAssembly, ReadOnlySpan<byte> arrSymbols)
		{
			fixed (byte* pinnableReference = arrAssembly.GetPinnableReference())
			{
				byte* value = pinnableReference;
				fixed (byte* pinnableReference2 = arrSymbols.GetPinnableReference())
				{
					byte* value2 = pinnableReference2;
					return AssemblyLoadContext.InternalLoadFromStream(this.NativeALC, new IntPtr((void*)value), arrAssembly.Length, new IntPtr((void*)value2), arrSymbols.Length);
				}
			}
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x000F217C File Offset: 0x000F037C
		internal static Assembly[] GetLoadedAssemblies()
		{
			return AssemblyLoadContext.InternalGetLoadedAssemblies();
		}

		// Token: 0x06004903 RID: 18691
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetLoadContextForAssembly(RuntimeAssembly rtAsm);

		// Token: 0x06004904 RID: 18692 RVA: 0x000F2184 File Offset: 0x000F0384
		[return: Nullable(2)]
		public static AssemblyLoadContext GetLoadContext(Assembly assembly)
		{
			ArgumentNullException.ThrowIfNull(assembly, "assembly");
			AssemblyLoadContext result = null;
			RuntimeAssembly runtimeAssembly = assembly as RuntimeAssembly;
			if (runtimeAssembly != null)
			{
				AssemblyLoadContext @default = AssemblyLoadContext.Default;
				result = AssemblyLoadContext.GetAssemblyLoadContext(AssemblyLoadContext.GetLoadContextForAssembly(runtimeAssembly));
			}
			return result;
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		public void SetProfileOptimizationRoot(string directoryPath)
		{
		}

		// Token: 0x06004906 RID: 18694 RVA: 0x0000FCFA File Offset: 0x0000DEFA
		[NullableContext(2)]
		public void StartProfileOptimization(string profile)
		{
		}

		// Token: 0x06004907 RID: 18695
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Assembly InternalLoadFile(IntPtr nativeAssemblyLoadContext, string assemblyFile, ref StackCrawlMark stackMark);

		// Token: 0x06004908 RID: 18696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr InternalInitializeNativeALC(IntPtr thisHandlePtr, IntPtr name, bool representsTPALoadContext, bool isCollectible);

		// Token: 0x06004909 RID: 18697
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Assembly InternalLoadFromStream(IntPtr nativeAssemblyLoadContext, IntPtr assm, int assmLength, IntPtr symbols, int symbolsLength);

		// Token: 0x0600490A RID: 18698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern Assembly[] InternalGetLoadedAssemblies();

		// Token: 0x0600490B RID: 18699 RVA: 0x000F21C1 File Offset: 0x000F03C1
		private static RuntimeAssembly MonoResolveUsingLoad(IntPtr gchALC, string assemblyName)
		{
			return AssemblyLoadContext.Resolve(gchALC, new AssemblyName(assemblyName));
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x000F21CF File Offset: 0x000F03CF
		private static RuntimeAssembly MonoResolveUsingResolvingEvent(IntPtr gchALC, string assemblyName)
		{
			return AssemblyLoadContext.GetAssemblyLoadContext(gchALC).ResolveUsingEvent(new AssemblyName(assemblyName));
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x000F21E2 File Offset: 0x000F03E2
		private static RuntimeAssembly MonoResolveUsingResolveSatelliteAssembly(IntPtr gchALC, string assemblyName)
		{
			return AssemblyLoadContext.GetAssemblyLoadContext(gchALC).ResolveSatelliteAssembly(new AssemblyName(assemblyName));
		}

		// Token: 0x0600490E RID: 18702 RVA: 0x000F21F8 File Offset: 0x000F03F8
		private static AssemblyLoadContext GetAssemblyLoadContext(IntPtr gchManagedAssemblyLoadContext)
		{
			AssemblyLoadContext result;
			if (gchManagedAssemblyLoadContext == IntPtr.Zero)
			{
				result = AssemblyLoadContext.Default;
			}
			else
			{
				result = (AssemblyLoadContext)GCHandle.FromIntPtr(gchManagedAssemblyLoadContext).Target;
			}
			return result;
		}

		// Token: 0x0600490F RID: 18703 RVA: 0x000F222C File Offset: 0x000F042C
		private static void MonoResolveUnmanagedDll(string unmanagedDllName, IntPtr gchManagedAssemblyLoadContext, ref IntPtr dll)
		{
			AssemblyLoadContext assemblyLoadContext = AssemblyLoadContext.GetAssemblyLoadContext(gchManagedAssemblyLoadContext);
			dll = assemblyLoadContext.LoadUnmanagedDll(unmanagedDllName);
		}

		// Token: 0x06004910 RID: 18704 RVA: 0x000F224C File Offset: 0x000F044C
		private static void MonoResolveUnmanagedDllUsingEvent(string unmanagedDllName, Assembly assembly, IntPtr gchManagedAssemblyLoadContext, ref IntPtr dll)
		{
			AssemblyLoadContext assemblyLoadContext = AssemblyLoadContext.GetAssemblyLoadContext(gchManagedAssemblyLoadContext);
			dll = assemblyLoadContext.GetResolvedUnmanagedDll(assembly, unmanagedDllName);
		}

		// Token: 0x06004911 RID: 18705 RVA: 0x000F226C File Offset: 0x000F046C
		private static RuntimeAssembly GetRuntimeAssembly(Assembly asm)
		{
			if (asm == null)
			{
				return null;
			}
			RuntimeAssembly runtimeAssembly = asm as RuntimeAssembly;
			if (runtimeAssembly != null)
			{
				return runtimeAssembly;
			}
			AssemblyBuilder assemblyBuilder = asm as AssemblyBuilder;
			if (assemblyBuilder == null)
			{
				return null;
			}
			return Unsafe.As<RuntimeAssembly>(assemblyBuilder);
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x06004912 RID: 18706 RVA: 0x000F22A2 File Offset: 0x000F04A2
		[MemberNotNull("s_allContexts")]
		private static Dictionary<long, WeakReference<AssemblyLoadContext>> AllContexts
		{
			[MemberNotNull("s_allContexts")]
			get
			{
				Dictionary<long, WeakReference<AssemblyLoadContext>> result;
				if ((result = AssemblyLoadContext.s_allContexts) == null)
				{
					result = (Interlocked.CompareExchange<Dictionary<long, WeakReference<AssemblyLoadContext>>>(ref AssemblyLoadContext.s_allContexts, new Dictionary<long, WeakReference<AssemblyLoadContext>>(), null) ?? AssemblyLoadContext.s_allContexts);
				}
				return result;
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06004913 RID: 18707 RVA: 0x000F22C8 File Offset: 0x000F04C8
		// (remove) Token: 0x06004914 RID: 18708 RVA: 0x000F2300 File Offset: 0x000F0500
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private event Func<Assembly, string, IntPtr> _resolvingUnmanagedDll;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06004915 RID: 18709 RVA: 0x000F2338 File Offset: 0x000F0538
		// (remove) Token: 0x06004916 RID: 18710 RVA: 0x000F2370 File Offset: 0x000F0570
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private event Func<AssemblyLoadContext, AssemblyName, Assembly> _resolving;

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06004917 RID: 18711 RVA: 0x000F23A8 File Offset: 0x000F05A8
		// (remove) Token: 0x06004918 RID: 18712 RVA: 0x000F23E0 File Offset: 0x000F05E0
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private event Action<AssemblyLoadContext> _unloading;

		// Token: 0x06004919 RID: 18713 RVA: 0x000F2415 File Offset: 0x000F0615
		protected AssemblyLoadContext() : this(false, false, null)
		{
		}

		// Token: 0x0600491A RID: 18714 RVA: 0x000F2420 File Offset: 0x000F0620
		protected AssemblyLoadContext(bool isCollectible) : this(false, isCollectible, null)
		{
		}

		// Token: 0x0600491B RID: 18715 RVA: 0x000F242B File Offset: 0x000F062B
		[NullableContext(2)]
		public AssemblyLoadContext(string name, bool isCollectible = false) : this(false, isCollectible, name)
		{
		}

		// Token: 0x0600491C RID: 18716 RVA: 0x000F2438 File Offset: 0x000F0638
		private protected AssemblyLoadContext(bool representsTPALoadContext, bool isCollectible, string name)
		{
			this._isCollectible = isCollectible;
			this._name = name;
			this._unloadLock = new object();
			if (!isCollectible)
			{
				GC.SuppressFinalize(this);
			}
			IntPtr thisHandlePtr = GCHandle.ToIntPtr(GCHandle.Alloc(this, this.IsCollectible ? GCHandleType.WeakTrackResurrection : GCHandleType.Normal));
			this._nativeAssemblyLoadContext = this.InitializeAssemblyLoadContext(thisHandlePtr, representsTPALoadContext, isCollectible);
			Dictionary<long, WeakReference<AssemblyLoadContext>> allContexts = AssemblyLoadContext.AllContexts;
			Dictionary<long, WeakReference<AssemblyLoadContext>> obj = allContexts;
			lock (obj)
			{
				long num = AssemblyLoadContext.s_nextId;
				AssemblyLoadContext.s_nextId = num + 1L;
				this._id = num;
				allContexts.Add(this._id, new WeakReference<AssemblyLoadContext>(this, true));
			}
		}

		// Token: 0x0600491D RID: 18717 RVA: 0x000F24EC File Offset: 0x000F06EC
		~AssemblyLoadContext()
		{
			if (this._unloadLock != null)
			{
				this.InitiateUnload();
			}
		}

		// Token: 0x0600491E RID: 18718 RVA: 0x000F2520 File Offset: 0x000F0720
		private void RaiseUnloadEvent()
		{
			Action<AssemblyLoadContext> action = Interlocked.Exchange<Action<AssemblyLoadContext>>(ref this._unloading, null);
			if (action == null)
			{
				return;
			}
			action(this);
		}

		// Token: 0x0600491F RID: 18719 RVA: 0x000F253C File Offset: 0x000F073C
		private void InitiateUnload()
		{
			this.RaiseUnloadEvent();
			object unloadLock = this._unloadLock;
			AssemblyLoadContext.InternalState state;
			lock (unloadLock)
			{
				state = this._state;
				if (state == AssemblyLoadContext.InternalState.Alive)
				{
					IntPtr assemblyLoadContextStrong = GCHandle.ToIntPtr(GCHandle.Alloc(this, GCHandleType.Normal));
					AssemblyLoadContext.PrepareForAssemblyLoadContextRelease(this._nativeAssemblyLoadContext, assemblyLoadContextStrong);
					this._state = AssemblyLoadContext.InternalState.Unloading;
				}
			}
			if (state == AssemblyLoadContext.InternalState.Alive)
			{
				Dictionary<long, WeakReference<AssemblyLoadContext>> allContexts = AssemblyLoadContext.AllContexts;
				Dictionary<long, WeakReference<AssemblyLoadContext>> obj = allContexts;
				lock (obj)
				{
					allContexts.Remove(this._id);
				}
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x06004920 RID: 18720 RVA: 0x000F25E8 File Offset: 0x000F07E8
		public IEnumerable<Assembly> Assemblies
		{
			get
			{
				foreach (Assembly assembly in AssemblyLoadContext.GetLoadedAssemblies())
				{
					if (AssemblyLoadContext.GetLoadContext(assembly) == this)
					{
						yield return assembly;
					}
				}
				Assembly[] array = null;
				yield break;
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06004921 RID: 18721 RVA: 0x000F25F8 File Offset: 0x000F07F8
		// (remove) Token: 0x06004922 RID: 18722 RVA: 0x000F2601 File Offset: 0x000F0801
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public event Func<Assembly, string, IntPtr> ResolvingUnmanagedDll
		{
			[DynamicDependency("MonoResolveUnmanagedDllUsingEvent")]
			add
			{
				this._resolvingUnmanagedDll += value;
			}
			remove
			{
				this._resolvingUnmanagedDll -= value;
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06004923 RID: 18723 RVA: 0x000F260A File Offset: 0x000F080A
		// (remove) Token: 0x06004924 RID: 18724 RVA: 0x000F2613 File Offset: 0x000F0813
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			2
		})]
		public event Func<AssemblyLoadContext, AssemblyName, Assembly> Resolving
		{
			[DynamicDependency("MonoResolveUsingResolvingEvent")]
			add
			{
				this._resolving += value;
			}
			remove
			{
				this._resolving -= value;
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06004925 RID: 18725 RVA: 0x000F261C File Offset: 0x000F081C
		// (remove) Token: 0x06004926 RID: 18726 RVA: 0x000F2625 File Offset: 0x000F0825
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public event Action<AssemblyLoadContext> Unloading
		{
			add
			{
				this._unloading += value;
			}
			remove
			{
				this._unloading -= value;
			}
		}

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06004927 RID: 18727 RVA: 0x000F2630 File Offset: 0x000F0830
		// (remove) Token: 0x06004928 RID: 18728 RVA: 0x000F2664 File Offset: 0x000F0864
		[Nullable(2)]
		[method: DynamicDependency("OnAssemblyLoad")]
		internal static event AssemblyLoadEventHandler AssemblyLoad;

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06004929 RID: 18729 RVA: 0x000F2698 File Offset: 0x000F0898
		// (remove) Token: 0x0600492A RID: 18730 RVA: 0x000F26CC File Offset: 0x000F08CC
		[Nullable(2)]
		[method: DynamicDependency("OnTypeResolve")]
		internal static event ResolveEventHandler TypeResolve;

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x0600492B RID: 18731 RVA: 0x000F2700 File Offset: 0x000F0900
		// (remove) Token: 0x0600492C RID: 18732 RVA: 0x000F2734 File Offset: 0x000F0934
		[Nullable(2)]
		[method: DynamicDependency("OnResourceResolve")]
		internal static event ResolveEventHandler ResourceResolve;

		// Token: 0x14000018 RID: 24
		// (add) Token: 0x0600492D RID: 18733 RVA: 0x000F2768 File Offset: 0x000F0968
		// (remove) Token: 0x0600492E RID: 18734 RVA: 0x000F279C File Offset: 0x000F099C
		[Nullable(2)]
		[method: DynamicDependency("OnAssemblyResolve")]
		internal static event ResolveEventHandler AssemblyResolve;

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x0600492F RID: 18735 RVA: 0x000F27CF File Offset: 0x000F09CF
		public static AssemblyLoadContext Default
		{
			get
			{
				return DefaultAssemblyLoadContext.s_loadContext;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x06004930 RID: 18736 RVA: 0x000F27D6 File Offset: 0x000F09D6
		public bool IsCollectible
		{
			get
			{
				return this._isCollectible;
			}
		}

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x06004931 RID: 18737 RVA: 0x000F27DE File Offset: 0x000F09DE
		[Nullable(2)]
		public string Name
		{
			[NullableContext(2)]
			get
			{
				return this._name;
			}
		}

		// Token: 0x06004932 RID: 18738 RVA: 0x000F27E8 File Offset: 0x000F09E8
		public override string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 3);
			defaultInterpolatedStringHandler.AppendLiteral("\"");
			defaultInterpolatedStringHandler.AppendFormatted(this.Name);
			defaultInterpolatedStringHandler.AppendLiteral("\" ");
			defaultInterpolatedStringHandler.AppendFormatted<Type>(base.GetType());
			defaultInterpolatedStringHandler.AppendLiteral(" #");
			defaultInterpolatedStringHandler.AppendFormatted<long>(this._id);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x17000CF3 RID: 3315
		// (get) Token: 0x06004933 RID: 18739 RVA: 0x000F2850 File Offset: 0x000F0A50
		public static IEnumerable<AssemblyLoadContext> All
		{
			get
			{
				AssemblyLoadContext @default = AssemblyLoadContext.Default;
				Dictionary<long, WeakReference<AssemblyLoadContext>> dictionary = AssemblyLoadContext.s_allContexts;
				Dictionary<long, WeakReference<AssemblyLoadContext>> obj = dictionary;
				WeakReference<AssemblyLoadContext>[] array;
				lock (obj)
				{
					array = new WeakReference<AssemblyLoadContext>[dictionary.Count];
					int num = 0;
					foreach (KeyValuePair<long, WeakReference<AssemblyLoadContext>> keyValuePair in dictionary)
					{
						array[num++] = keyValuePair.Value;
					}
				}
				WeakReference<AssemblyLoadContext>[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					AssemblyLoadContext assemblyLoadContext;
					if (array2[i].TryGetTarget(out assemblyLoadContext))
					{
						yield return assemblyLoadContext;
					}
				}
				array2 = null;
				yield break;
			}
		}

		// Token: 0x06004934 RID: 18740 RVA: 0x000F2859 File Offset: 0x000F0A59
		public static AssemblyName GetAssemblyName(string assemblyPath)
		{
			ArgumentNullException.ThrowIfNull(assemblyPath, "assemblyPath");
			return AssemblyName.GetAssemblyName(assemblyPath);
		}

		// Token: 0x06004935 RID: 18741 RVA: 0x0001A4BA File Offset: 0x000186BA
		[return: Nullable(2)]
		protected virtual Assembly Load(AssemblyName assemblyName)
		{
			return null;
		}

		// Token: 0x06004936 RID: 18742 RVA: 0x000F286C File Offset: 0x000F0A6C
		public Assembly LoadFromAssemblyName(AssemblyName assemblyName)
		{
			ArgumentNullException.ThrowIfNull(assemblyName, "assemblyName");
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return RuntimeAssembly.InternalLoad(assemblyName, ref stackCrawlMark, this);
		}

		// Token: 0x06004937 RID: 18743 RVA: 0x000F2890 File Offset: 0x000F0A90
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		public Assembly LoadFromAssemblyPath(string assemblyPath)
		{
			ArgumentNullException.ThrowIfNull(assemblyPath, "assemblyPath");
			if (PathInternal.IsPartiallyQualified(assemblyPath))
			{
				throw new ArgumentException(SR.Format(SR.Argument_AbsolutePathRequired, assemblyPath), "assemblyPath");
			}
			object unloadLock = this._unloadLock;
			Assembly result;
			lock (unloadLock)
			{
				this.VerifyIsAlive();
				result = this.InternalLoadFromPath(assemblyPath, null);
			}
			return result;
		}

		// Token: 0x06004938 RID: 18744 RVA: 0x000F2908 File Offset: 0x000F0B08
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		public Assembly LoadFromNativeImagePath(string nativeImagePath, [Nullable(2)] string assemblyPath)
		{
			ArgumentNullException.ThrowIfNull(nativeImagePath, "nativeImagePath");
			if (PathInternal.IsPartiallyQualified(nativeImagePath))
			{
				throw new ArgumentException(SR.Format(SR.Argument_AbsolutePathRequired, nativeImagePath), "nativeImagePath");
			}
			if (assemblyPath != null && PathInternal.IsPartiallyQualified(assemblyPath))
			{
				throw new ArgumentException(SR.Format(SR.Argument_AbsolutePathRequired, assemblyPath), "assemblyPath");
			}
			object unloadLock = this._unloadLock;
			Assembly result;
			lock (unloadLock)
			{
				this.VerifyIsAlive();
				result = this.InternalLoadFromPath(assemblyPath, nativeImagePath);
			}
			return result;
		}

		// Token: 0x06004939 RID: 18745 RVA: 0x000F29A8 File Offset: 0x000F0BA8
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		public Assembly LoadFromStream(Stream assembly)
		{
			return this.LoadFromStream(assembly, null);
		}

		// Token: 0x0600493A RID: 18746 RVA: 0x000F29B4 File Offset: 0x000F0BB4
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		public Assembly LoadFromStream(Stream assembly, [Nullable(2)] Stream assemblySymbols)
		{
			ArgumentNullException.ThrowIfNull(assembly, "assembly");
			ReadOnlySpan<byte> arrAssembly = AssemblyLoadContext.<LoadFromStream>g__ReadAllBytes|88_0(assembly);
			if (arrAssembly.IsEmpty)
			{
				throw new BadImageFormatException(SR.BadImageFormat_BadILFormat);
			}
			ReadOnlySpan<byte> arrSymbols = default(ReadOnlySpan<byte>);
			if (assemblySymbols != null)
			{
				arrSymbols = AssemblyLoadContext.<LoadFromStream>g__ReadAllBytes|88_0(assemblySymbols);
			}
			object unloadLock = this._unloadLock;
			Assembly result;
			lock (unloadLock)
			{
				this.VerifyIsAlive();
				result = this.InternalLoad(arrAssembly, arrSymbols);
			}
			return result;
		}

		// Token: 0x0600493B RID: 18747 RVA: 0x000F2A38 File Offset: 0x000F0C38
		protected IntPtr LoadUnmanagedDllFromPath(string unmanagedDllPath)
		{
			ArgumentException.ThrowIfNullOrEmpty(unmanagedDllPath, "unmanagedDllPath");
			if (PathInternal.IsPartiallyQualified(unmanagedDllPath))
			{
				throw new ArgumentException(SR.Format(SR.Argument_AbsolutePathRequired, unmanagedDllPath), "unmanagedDllPath");
			}
			return NativeLibrary.Load(unmanagedDllPath);
		}

		// Token: 0x0600493C RID: 18748 RVA: 0x000F2A6E File Offset: 0x000F0C6E
		protected virtual IntPtr LoadUnmanagedDll(string unmanagedDllName)
		{
			return IntPtr.Zero;
		}

		// Token: 0x0600493D RID: 18749 RVA: 0x000F2A75 File Offset: 0x000F0C75
		public void Unload()
		{
			if (!this.IsCollectible)
			{
				throw new InvalidOperationException(SR.AssemblyLoadContext_Unload_CannotUnloadIfNotCollectible);
			}
			GC.SuppressFinalize(this);
			this.InitiateUnload();
		}

		// Token: 0x0600493E RID: 18750 RVA: 0x000F2A98 File Offset: 0x000F0C98
		internal static void OnProcessExit()
		{
			Dictionary<long, WeakReference<AssemblyLoadContext>> dictionary = AssemblyLoadContext.s_allContexts;
			if (dictionary == null)
			{
				return;
			}
			Dictionary<long, WeakReference<AssemblyLoadContext>> obj = dictionary;
			lock (obj)
			{
				foreach (KeyValuePair<long, WeakReference<AssemblyLoadContext>> keyValuePair in dictionary)
				{
					AssemblyLoadContext assemblyLoadContext;
					if (keyValuePair.Value.TryGetTarget(out assemblyLoadContext))
					{
						assemblyLoadContext.RaiseUnloadEvent();
					}
				}
			}
		}

		// Token: 0x0600493F RID: 18751 RVA: 0x000F2B24 File Offset: 0x000F0D24
		private void VerifyIsAlive()
		{
			if (this._state != AssemblyLoadContext.InternalState.Alive)
			{
				throw new InvalidOperationException(SR.AssemblyLoadContext_Verify_NotUnloading);
			}
		}

		// Token: 0x17000CF4 RID: 3316
		// (get) Token: 0x06004940 RID: 18752 RVA: 0x000F2B39 File Offset: 0x000F0D39
		[Nullable(2)]
		public static AssemblyLoadContext CurrentContextualReflectionContext
		{
			[NullableContext(2)]
			get
			{
				AsyncLocal<AssemblyLoadContext> asyncLocal = AssemblyLoadContext.s_asyncLocalCurrent;
				if (asyncLocal == null)
				{
					return null;
				}
				return asyncLocal.Value;
			}
		}

		// Token: 0x06004941 RID: 18753 RVA: 0x000F2B4B File Offset: 0x000F0D4B
		private static void SetCurrentContextualReflectionContext(AssemblyLoadContext value)
		{
			if (AssemblyLoadContext.s_asyncLocalCurrent == null)
			{
				Interlocked.CompareExchange<AsyncLocal<AssemblyLoadContext>>(ref AssemblyLoadContext.s_asyncLocalCurrent, new AsyncLocal<AssemblyLoadContext>(), null);
			}
			AssemblyLoadContext.s_asyncLocalCurrent.Value = value;
		}

		// Token: 0x06004942 RID: 18754 RVA: 0x000F2B70 File Offset: 0x000F0D70
		public AssemblyLoadContext.ContextualReflectionScope EnterContextualReflection()
		{
			return new AssemblyLoadContext.ContextualReflectionScope(this);
		}

		// Token: 0x06004943 RID: 18755 RVA: 0x000F2B78 File Offset: 0x000F0D78
		[NullableContext(2)]
		public static AssemblyLoadContext.ContextualReflectionScope EnterContextualReflection(Assembly activating)
		{
			if (activating == null)
			{
				return new AssemblyLoadContext.ContextualReflectionScope(null);
			}
			AssemblyLoadContext loadContext = AssemblyLoadContext.GetLoadContext(activating);
			if (loadContext == null)
			{
				throw new ArgumentException(SR.Arg_MustBeRuntimeAssembly, "activating");
			}
			return loadContext.EnterContextualReflection();
		}

		// Token: 0x06004944 RID: 18756 RVA: 0x000F2BAC File Offset: 0x000F0DAC
		private static RuntimeAssembly Resolve(IntPtr gchManagedAssemblyLoadContext, AssemblyName assemblyName)
		{
			return ((AssemblyLoadContext)GCHandle.FromIntPtr(gchManagedAssemblyLoadContext).Target).ResolveUsingLoad(assemblyName);
		}

		// Token: 0x06004945 RID: 18757 RVA: 0x000F2BD4 File Offset: 0x000F0DD4
		[UnconditionalSuppressMessage("SingleFile", "IL3000: Avoid accessing Assembly file path when publishing as a single file", Justification = "The code handles the Assembly.Location equals null")]
		private Assembly GetFirstResolvedAssemblyFromResolvingEvent(AssemblyName assemblyName)
		{
			foreach (Func<AssemblyLoadContext, AssemblyName, Assembly> func in Delegate.EnumerateInvocationList<Func<AssemblyLoadContext, AssemblyName, Assembly>>(this._resolving))
			{
				Assembly assembly = func(this, assemblyName);
				if (assembly != null)
				{
					return assembly;
				}
			}
			return null;
		}

		// Token: 0x06004946 RID: 18758 RVA: 0x000F2C1C File Offset: 0x000F0E1C
		private static RuntimeAssembly ValidateAssemblyNameWithSimpleName(Assembly assembly, string requestedSimpleName)
		{
			ArgumentException.ThrowIfNullOrEmpty(requestedSimpleName, "AssemblyName.Name");
			RuntimeAssembly runtimeAssembly = AssemblyLoadContext.GetRuntimeAssembly(assembly);
			if (runtimeAssembly == null)
			{
				throw new InvalidOperationException(SR.InvalidOperation_ResolvedAssemblyMustBeRuntimeAssembly);
			}
			if (!requestedSimpleName.Equals(runtimeAssembly.GetSimpleName(), StringComparison.InvariantCultureIgnoreCase))
			{
				throw new InvalidOperationException(SR.InvalidOperation_ResolvedAssemblyRequestedNameMismatch);
			}
			return runtimeAssembly;
		}

		// Token: 0x06004947 RID: 18759 RVA: 0x000F2C6C File Offset: 0x000F0E6C
		private RuntimeAssembly ResolveUsingLoad(AssemblyName assemblyName)
		{
			string name = assemblyName.Name;
			Assembly assembly = this.Load(assemblyName);
			if (!(assembly != null))
			{
				return null;
			}
			return AssemblyLoadContext.ValidateAssemblyNameWithSimpleName(assembly, name);
		}

		// Token: 0x06004948 RID: 18760 RVA: 0x000F2C9C File Offset: 0x000F0E9C
		private RuntimeAssembly ResolveUsingEvent(AssemblyName assemblyName)
		{
			string name = assemblyName.Name;
			Assembly firstResolvedAssemblyFromResolvingEvent = this.GetFirstResolvedAssemblyFromResolvingEvent(assemblyName);
			if (!(firstResolvedAssemblyFromResolvingEvent != null))
			{
				return null;
			}
			return AssemblyLoadContext.ValidateAssemblyNameWithSimpleName(firstResolvedAssemblyFromResolvingEvent, name);
		}

		// Token: 0x06004949 RID: 18761 RVA: 0x000F2CCA File Offset: 0x000F0ECA
		private static void OnAssemblyLoad(RuntimeAssembly assembly)
		{
			AssemblyLoadEventHandler assemblyLoad = AssemblyLoadContext.AssemblyLoad;
			if (assemblyLoad == null)
			{
				return;
			}
			assemblyLoad(AppDomain.CurrentDomain, new AssemblyLoadEventArgs(assembly));
		}

		// Token: 0x0600494A RID: 18762 RVA: 0x000F2CE6 File Offset: 0x000F0EE6
		internal static RuntimeAssembly OnResourceResolve(RuntimeAssembly assembly, string resourceName)
		{
			return AssemblyLoadContext.InvokeResolveEvent(AssemblyLoadContext.ResourceResolve, assembly, resourceName);
		}

		// Token: 0x0600494B RID: 18763 RVA: 0x000F2CF4 File Offset: 0x000F0EF4
		internal static RuntimeAssembly OnTypeResolve(RuntimeAssembly assembly, string typeName)
		{
			return AssemblyLoadContext.InvokeResolveEvent(AssemblyLoadContext.TypeResolve, assembly, typeName);
		}

		// Token: 0x0600494C RID: 18764 RVA: 0x000F2D02 File Offset: 0x000F0F02
		private static RuntimeAssembly OnAssemblyResolve(RuntimeAssembly assembly, string assemblyFullName)
		{
			return AssemblyLoadContext.InvokeResolveEvent(AssemblyLoadContext.AssemblyResolve, assembly, assemblyFullName);
		}

		// Token: 0x0600494D RID: 18765 RVA: 0x000F2CCA File Offset: 0x000F0ECA
		internal static void InvokeAssemblyLoadEvent(Assembly assembly)
		{
			AssemblyLoadEventHandler assemblyLoad = AssemblyLoadContext.AssemblyLoad;
			if (assemblyLoad == null)
			{
				return;
			}
			assemblyLoad(AppDomain.CurrentDomain, new AssemblyLoadEventArgs(assembly));
		}

		// Token: 0x0600494E RID: 18766 RVA: 0x000F2D10 File Offset: 0x000F0F10
		[UnconditionalSuppressMessage("SingleFile", "IL3000: Avoid accessing Assembly file path when publishing as a single file", Justification = "The code handles the Assembly.Location equals null")]
		private static RuntimeAssembly InvokeResolveEvent(ResolveEventHandler eventHandler, RuntimeAssembly assembly, string name)
		{
			if (eventHandler == null)
			{
				return null;
			}
			ResolveEventArgs args = new ResolveEventArgs(name, assembly);
			foreach (ResolveEventHandler resolveEventHandler in Delegate.EnumerateInvocationList<ResolveEventHandler>(eventHandler))
			{
				RuntimeAssembly runtimeAssembly = AssemblyLoadContext.GetRuntimeAssembly(resolveEventHandler(AppDomain.CurrentDomain, args));
				if (runtimeAssembly != null)
				{
					return runtimeAssembly;
				}
			}
			return null;
		}

		// Token: 0x0600494F RID: 18767 RVA: 0x000F2D68 File Offset: 0x000F0F68
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "Satellite assemblies have no code in them and loading is not a problem")]
		[UnconditionalSuppressMessage("SingleFile", "IL3000: Avoid accessing Assembly file path when publishing as a single file", Justification = "This call is fine because native call runs before this and checks BindSatelliteResourceFromBundle")]
		private RuntimeAssembly ResolveSatelliteAssembly(AssemblyName assemblyName)
		{
			if (assemblyName.Name == null || !assemblyName.Name.EndsWith(".resources", StringComparison.Ordinal))
			{
				return null;
			}
			string assemblyName2 = assemblyName.Name.Substring(0, assemblyName.Name.Length - ".resources".Length);
			RuntimeAssembly runtimeAssembly = (RuntimeAssembly)this.LoadFromAssemblyName(new AssemblyName(assemblyName2));
			AssemblyLoadContext loadContext = AssemblyLoadContext.GetLoadContext(runtimeAssembly);
			string directoryName = Path.GetDirectoryName(runtimeAssembly.Location);
			if (directoryName == null)
			{
				return null;
			}
			string text = Path.Combine(directoryName, assemblyName.CultureName, assemblyName.Name + ".dll");
			bool flag = FileSystem.FileExists(text);
			if (flag || false)
			{
			}
			if (!flag)
			{
				return null;
			}
			return (RuntimeAssembly)loadContext.LoadFromAssemblyPath(text);
		}

		// Token: 0x06004950 RID: 18768 RVA: 0x000F2E1C File Offset: 0x000F101C
		internal IntPtr GetResolvedUnmanagedDll(Assembly assembly, string unmanagedDllName)
		{
			foreach (Func<Assembly, string, IntPtr> func in Delegate.EnumerateInvocationList<Func<Assembly, string, IntPtr>>(this._resolvingUnmanagedDll))
			{
				IntPtr intPtr = func(assembly, unmanagedDllName);
				if (intPtr != IntPtr.Zero)
				{
					return intPtr;
				}
			}
			return IntPtr.Zero;
		}

		// Token: 0x06004951 RID: 18769 RVA: 0x000F2E68 File Offset: 0x000F1068
		[CompilerGenerated]
		internal static ReadOnlySpan<byte> <LoadFromStream>g__ReadAllBytes|88_0(Stream stream)
		{
			ArraySegment<byte> segment;
			if (stream.GetType() == typeof(MemoryStream) && ((MemoryStream)stream).TryGetBuffer(out segment))
			{
				int start = (int)stream.Position;
				stream.Seek(0L, SeekOrigin.End);
				return segment.AsSpan(start);
			}
			long num = stream.Length - stream.Position;
			if (num == 0L)
			{
				return ReadOnlySpan<byte>.Empty;
			}
			if (num > 2147483591L)
			{
				throw new BadImageFormatException(SR.BadImageFormat_BadILFormat);
			}
			byte[] array = GC.AllocateUninitializedArray<byte>((int)num, false);
			stream.ReadExactly(array);
			return array;
		}

		// Token: 0x0400118D RID: 4493
		private static Dictionary<long, WeakReference<AssemblyLoadContext>> s_allContexts;

		// Token: 0x0400118E RID: 4494
		private static long s_nextId;

		// Token: 0x0400118F RID: 4495
		private readonly IntPtr _nativeAssemblyLoadContext;

		// Token: 0x04001190 RID: 4496
		private readonly object _unloadLock;

		// Token: 0x04001194 RID: 4500
		private readonly string _name;

		// Token: 0x04001195 RID: 4501
		private readonly long _id;

		// Token: 0x04001196 RID: 4502
		private AssemblyLoadContext.InternalState _state;

		// Token: 0x04001197 RID: 4503
		private readonly bool _isCollectible;

		// Token: 0x0400119C RID: 4508
		private static AsyncLocal<AssemblyLoadContext> s_asyncLocalCurrent;

		// Token: 0x02000536 RID: 1334
		private enum InternalState
		{
			// Token: 0x0400119E RID: 4510
			Alive,
			// Token: 0x0400119F RID: 4511
			Unloading
		}

		// Token: 0x02000537 RID: 1335
		[NullableContext(0)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public struct ContextualReflectionScope : IDisposable
		{
			// Token: 0x06004952 RID: 18770 RVA: 0x000F2F00 File Offset: 0x000F1100
			internal ContextualReflectionScope(AssemblyLoadContext activating)
			{
				this._predecessor = AssemblyLoadContext.CurrentContextualReflectionContext;
				AssemblyLoadContext.SetCurrentContextualReflectionContext(activating);
				this._activated = activating;
				this._initialized = true;
			}

			// Token: 0x06004953 RID: 18771 RVA: 0x000F2F21 File Offset: 0x000F1121
			public void Dispose()
			{
				if (this._initialized)
				{
					AssemblyLoadContext.SetCurrentContextualReflectionContext(this._predecessor);
				}
			}

			// Token: 0x040011A0 RID: 4512
			private readonly AssemblyLoadContext _activated;

			// Token: 0x040011A1 RID: 4513
			private readonly AssemblyLoadContext _predecessor;

			// Token: 0x040011A2 RID: 4514
			private readonly bool _initialized;
		}
	}
}
