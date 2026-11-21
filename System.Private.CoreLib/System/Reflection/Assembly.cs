using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Assemblies;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System.Reflection
{
	// Token: 0x020006EB RID: 1771
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class Assembly : ICustomAttributeProvider, ISerializable
	{
		// Token: 0x06007518 RID: 29976 RVA: 0x001166DC File Offset: 0x001148DC
		[Obsolete("Assembly.LoadWithPartialName has been deprecated. Use Assembly.Load() instead.")]
		[return: Nullable(2)]
		public static Assembly LoadWithPartialName(string partialName)
		{
			ArgumentNullException.ThrowIfNull(partialName, "partialName");
			if (partialName.Length == 0 || partialName[0] == '\0')
			{
				throw new ArgumentException(SR.Format_StringZeroLength, "partialName");
			}
			Assembly result;
			try
			{
				StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
				result = Assembly.InternalLoad(partialName, ref stackCrawlMark, IntPtr.Zero);
			}
			catch (FileNotFoundException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06007519 RID: 29977 RVA: 0x00116740 File Offset: 0x00114940
		public static Assembly GetExecutingAssembly()
		{
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return Assembly.GetExecutingAssembly(ref stackCrawlMark);
		}

		// Token: 0x0600751A RID: 29978
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern RuntimeAssembly GetExecutingAssembly(ref StackCrawlMark stackMark);

		// Token: 0x0600751B RID: 29979
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern Assembly GetCallingAssembly();

		// Token: 0x0600751C RID: 29980
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Assembly GetEntryAssemblyNative();

		// Token: 0x0600751D RID: 29981 RVA: 0x00116756 File Offset: 0x00114956
		private static Assembly GetEntryAssemblyInternal()
		{
			return Assembly.GetEntryAssemblyNative();
		}

		// Token: 0x0600751E RID: 29982 RVA: 0x00116760 File Offset: 0x00114960
		public static Assembly Load(string assemblyString)
		{
			ArgumentNullException.ThrowIfNull(assemblyString, "assemblyString");
			AssemblyName assemblyRef = new AssemblyName(assemblyString);
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return Assembly.Load(assemblyRef, ref stackCrawlMark, AssemblyLoadContext.CurrentContextualReflectionContext);
		}

		// Token: 0x0600751F RID: 29983 RVA: 0x0011678C File Offset: 0x0011498C
		public static Assembly Load(AssemblyName assemblyRef)
		{
			ArgumentNullException.ThrowIfNull(assemblyRef, "assemblyRef");
			StackCrawlMark stackCrawlMark = StackCrawlMark.LookForMyCaller;
			return Assembly.Load(assemblyRef, ref stackCrawlMark, AssemblyLoadContext.CurrentContextualReflectionContext);
		}

		// Token: 0x06007520 RID: 29984 RVA: 0x001167B3 File Offset: 0x001149B3
		internal static Assembly Load(AssemblyName assemblyRef, ref StackCrawlMark stackMark, AssemblyLoadContext assemblyLoadContext)
		{
			Assembly assembly = Assembly.InternalLoad(assemblyRef.FullName, ref stackMark, (assemblyLoadContext != null) ? assemblyLoadContext.NativeALC : IntPtr.Zero);
			if (assembly == null)
			{
				throw new FileNotFoundException(null, assemblyRef.Name);
			}
			return assembly;
		}

		// Token: 0x06007521 RID: 29985 RVA: 0x001167E7 File Offset: 0x001149E7
		internal static uint GetAssemblyCount()
		{
			return (uint)EventPipeInternal.GetRuntimeCounterValue(EventPipeInternal.RuntimeCounters.ASSEMBLY_COUNT);
		}

		// Token: 0x06007522 RID: 29986
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern Assembly InternalLoad(string assemblyName, ref StackCrawlMark stackMark, IntPtr ptrLoadContextBinder);

		// Token: 0x06007523 RID: 29987
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern Type InternalGetType(Module module, string name, bool throwOnError, bool ignoreCase);

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x06007525 RID: 29989 RVA: 0x001167F0 File Offset: 0x001149F0
		public virtual IEnumerable<TypeInfo> DefinedTypes
		{
			[RequiresUnreferencedCode("Types might be removed")]
			get
			{
				Type[] types = this.GetTypes();
				TypeInfo[] array = new TypeInfo[types.Length];
				for (int i = 0; i < types.Length; i++)
				{
					TypeInfo[] array2 = array;
					int num = i;
					TypeInfo typeInfo = types[i].GetTypeInfo();
					if (typeInfo == null)
					{
						throw new NotSupportedException(SR.Format(SR.NotSupported_NoTypeInfo, types[i].FullName));
					}
					array2[num] = typeInfo;
				}
				return array;
			}
		}

		// Token: 0x06007526 RID: 29990 RVA: 0x00116844 File Offset: 0x00114A44
		[RequiresUnreferencedCode("Types might be removed")]
		public virtual Type[] GetTypes()
		{
			Module[] modules = this.GetModules(false);
			if (modules.Length == 1)
			{
				return modules[0].GetTypes();
			}
			int num = 0;
			Type[][] array = new Type[modules.Length][];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = modules[i].GetTypes();
				num += array[i].Length;
			}
			int num2 = 0;
			Type[] array2 = new Type[num];
			for (int j = 0; j < array.Length; j++)
			{
				int num3 = array[j].Length;
				Array.Copy(array[j], 0, array2, num2, num3);
				num2 += num3;
			}
			return array2;
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x06007527 RID: 29991 RVA: 0x001168D5 File Offset: 0x00114AD5
		public virtual IEnumerable<Type> ExportedTypes
		{
			[RequiresUnreferencedCode("Types might be removed")]
			get
			{
				return this.GetExportedTypes();
			}
		}

		// Token: 0x06007528 RID: 29992 RVA: 0x0001A4BD File Offset: 0x000186BD
		[RequiresUnreferencedCode("Types might be removed")]
		public virtual Type[] GetExportedTypes()
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007529 RID: 29993 RVA: 0x0001A4BD File Offset: 0x000186BD
		[RequiresUnreferencedCode("Types might be removed")]
		public virtual Type[] GetForwardedTypes()
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x0600752A RID: 29994 RVA: 0x0001A4BD File Offset: 0x000186BD
		[Nullable(2)]
		[Obsolete("Assembly.CodeBase and Assembly.EscapedCodeBase are only included for .NET Framework compatibility. Use Assembly.Location.", DiagnosticId = "SYSLIB0012", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[RequiresAssemblyFiles("This member throws an exception for assemblies embedded in a single-file app")]
		public virtual string CodeBase
		{
			[NullableContext(2)]
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x0600752B RID: 29995 RVA: 0x0001A4BD File Offset: 0x000186BD
		[Nullable(2)]
		public virtual MethodInfo EntryPoint
		{
			[NullableContext(2)]
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x0600752C RID: 29996 RVA: 0x0001A4BD File Offset: 0x000186BD
		[Nullable(2)]
		public virtual string FullName
		{
			[NullableContext(2)]
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x0600752D RID: 29997 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual string ImageRuntimeVersion
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x0600752E RID: 29998 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual bool IsDynamic
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x0600752F RID: 29999 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual string Location
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x06007530 RID: 30000 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual bool ReflectionOnly
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000E70 RID: 3696
		// (get) Token: 0x06007531 RID: 30001 RVA: 0x000070DD File Offset: 0x000052DD
		public virtual bool IsCollectible
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06007532 RID: 30002 RVA: 0x0001A4BD File Offset: 0x000186BD
		[return: Nullable(2)]
		public virtual ManifestResourceInfo GetManifestResourceInfo(string resourceName)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007533 RID: 30003 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual string[] GetManifestResourceNames()
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007534 RID: 30004 RVA: 0x0001A4BD File Offset: 0x000186BD
		[return: Nullable(2)]
		public virtual Stream GetManifestResourceStream(string name)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007535 RID: 30005 RVA: 0x0001A4BD File Offset: 0x000186BD
		[return: Nullable(2)]
		public virtual Stream GetManifestResourceStream(Type type, string name)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x17000E71 RID: 3697
		// (get) Token: 0x06007536 RID: 30006 RVA: 0x000070DD File Offset: 0x000052DD
		public bool IsFullyTrusted
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06007537 RID: 30007 RVA: 0x001168DD File Offset: 0x00114ADD
		public virtual AssemblyName GetName()
		{
			return this.GetName(false);
		}

		// Token: 0x06007538 RID: 30008 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual AssemblyName GetName(bool copiedName)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007539 RID: 30009 RVA: 0x001168E6 File Offset: 0x00114AE6
		[RequiresUnreferencedCode("Types might be removed by trimming. If the type name is a string literal, consider using Type.GetType instead.")]
		[return: Nullable(2)]
		public virtual Type GetType(string name)
		{
			return this.GetType(name, false, false);
		}

		// Token: 0x0600753A RID: 30010 RVA: 0x001168F1 File Offset: 0x00114AF1
		[RequiresUnreferencedCode("Types might be removed by trimming. If the type name is a string literal, consider using Type.GetType instead.")]
		[return: Nullable(2)]
		public virtual Type GetType(string name, bool throwOnError)
		{
			return this.GetType(name, throwOnError, false);
		}

		// Token: 0x0600753B RID: 30011 RVA: 0x0001A4BD File Offset: 0x000186BD
		[RequiresUnreferencedCode("Types might be removed by trimming. If the type name is a string literal, consider using Type.GetType instead.")]
		[return: Nullable(2)]
		public virtual Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x0600753C RID: 30012 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual bool IsDefined(Type attributeType, bool inherit)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x17000E72 RID: 3698
		// (get) Token: 0x0600753D RID: 30013 RVA: 0x001168FC File Offset: 0x00114AFC
		public virtual IEnumerable<CustomAttributeData> CustomAttributes
		{
			get
			{
				return this.GetCustomAttributesData();
			}
		}

		// Token: 0x0600753E RID: 30014 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual IList<CustomAttributeData> GetCustomAttributesData()
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x0600753F RID: 30015 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual object[] GetCustomAttributes(bool inherit)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007540 RID: 30016 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x17000E73 RID: 3699
		// (get) Token: 0x06007541 RID: 30017 RVA: 0x00116904 File Offset: 0x00114B04
		[Obsolete("Assembly.CodeBase and Assembly.EscapedCodeBase are only included for .NET Framework compatibility. Use Assembly.Location.", DiagnosticId = "SYSLIB0012", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[RequiresAssemblyFiles("This member throws an exception for assemblies embedded in a single-file app")]
		public virtual string EscapedCodeBase
		{
			get
			{
				return AssemblyName.EscapeCodeBase(this.CodeBase);
			}
		}

		// Token: 0x06007542 RID: 30018 RVA: 0x00116911 File Offset: 0x00114B11
		[RequiresUnreferencedCode("Assembly.CreateInstance is not supported with trimming. Use Type.GetType instead.")]
		[return: Nullable(2)]
		public object CreateInstance(string typeName)
		{
			return this.CreateInstance(typeName, false, BindingFlags.Instance | BindingFlags.Public, null, null, null, null);
		}

		// Token: 0x06007543 RID: 30019 RVA: 0x00116921 File Offset: 0x00114B21
		[RequiresUnreferencedCode("Assembly.CreateInstance is not supported with trimming. Use Type.GetType instead.")]
		[return: Nullable(2)]
		public object CreateInstance(string typeName, bool ignoreCase)
		{
			return this.CreateInstance(typeName, ignoreCase, BindingFlags.Instance | BindingFlags.Public, null, null, null, null);
		}

		// Token: 0x06007544 RID: 30020 RVA: 0x00116934 File Offset: 0x00114B34
		[NullableContext(2)]
		[RequiresUnreferencedCode("Assembly.CreateInstance is not supported with trimming. Use Type.GetType instead.")]
		public virtual object CreateInstance([Nullable(1)] string typeName, bool ignoreCase, BindingFlags bindingAttr, Binder binder, [Nullable(new byte[]
		{
			2,
			1
		})] object[] args, CultureInfo culture, [Nullable(new byte[]
		{
			2,
			1
		})] object[] activationAttributes)
		{
			Type type = this.GetType(typeName, false, ignoreCase);
			if (type == null)
			{
				return null;
			}
			return Activator.CreateInstance(type, bindingAttr, binder, args, culture, activationAttributes);
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06007545 RID: 30021 RVA: 0x0001A4BD File Offset: 0x000186BD
		// (remove) Token: 0x06007546 RID: 30022 RVA: 0x0001A4BD File Offset: 0x000186BD
		[Nullable(2)]
		public virtual event ModuleResolveEventHandler ModuleResolve
		{
			[NullableContext(2)]
			add
			{
				throw NotImplemented.ByDesign;
			}
			[NullableContext(2)]
			remove
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000E74 RID: 3700
		// (get) Token: 0x06007547 RID: 30023 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual Module ManifestModule
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x06007548 RID: 30024 RVA: 0x0001A4BD File Offset: 0x000186BD
		[return: Nullable(2)]
		public virtual Module GetModule(string name)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007549 RID: 30025 RVA: 0x00116965 File Offset: 0x00114B65
		public Module[] GetModules()
		{
			return this.GetModules(false);
		}

		// Token: 0x0600754A RID: 30026 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual Module[] GetModules(bool getResourceModules)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x17000E75 RID: 3701
		// (get) Token: 0x0600754B RID: 30027 RVA: 0x0011696E File Offset: 0x00114B6E
		public virtual IEnumerable<Module> Modules
		{
			get
			{
				return this.GetLoadedModules(true);
			}
		}

		// Token: 0x0600754C RID: 30028 RVA: 0x00116977 File Offset: 0x00114B77
		public Module[] GetLoadedModules()
		{
			return this.GetLoadedModules(false);
		}

		// Token: 0x0600754D RID: 30029 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual Module[] GetLoadedModules(bool getResourceModules)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x0600754E RID: 30030 RVA: 0x0001A4BD File Offset: 0x000186BD
		[RequiresUnreferencedCode("Assembly references might be removed")]
		public virtual AssemblyName[] GetReferencedAssemblies()
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x0600754F RID: 30031 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual Assembly GetSatelliteAssembly(CultureInfo culture)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007550 RID: 30032 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual Assembly GetSatelliteAssembly(CultureInfo culture, [Nullable(2)] Version version)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007551 RID: 30033 RVA: 0x0001A4BD File Offset: 0x000186BD
		[RequiresAssemblyFiles("This member throws an exception for assemblies embedded in a single-file app")]
		[return: Nullable(2)]
		public virtual FileStream GetFile(string name)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007552 RID: 30034 RVA: 0x00116980 File Offset: 0x00114B80
		[RequiresAssemblyFiles("This member throws an exception for assemblies embedded in a single-file app")]
		public virtual FileStream[] GetFiles()
		{
			return this.GetFiles(false);
		}

		// Token: 0x06007553 RID: 30035 RVA: 0x0001A4BD File Offset: 0x000186BD
		[RequiresAssemblyFiles("This member throws an exception for assemblies embedded in a single-file app")]
		public virtual FileStream[] GetFiles(bool getResourceModules)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007554 RID: 30036 RVA: 0x0001A4BD File Offset: 0x000186BD
		[Obsolete("This API supports obsolete formatter-based serialization. It should not be called or extended by application code.", DiagnosticId = "SYSLIB0051", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007555 RID: 30037 RVA: 0x00116989 File Offset: 0x00114B89
		public override string ToString()
		{
			return this.FullName ?? base.ToString();
		}

		// Token: 0x17000E76 RID: 3702
		// (get) Token: 0x06007556 RID: 30038 RVA: 0x0001A4BD File Offset: 0x000186BD
		[Obsolete("The Global Assembly Cache is not supported.", DiagnosticId = "SYSLIB0005", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public virtual bool GlobalAssemblyCache
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x17000E77 RID: 3703
		// (get) Token: 0x06007557 RID: 30039 RVA: 0x0001A4BD File Offset: 0x000186BD
		public virtual long HostContext
		{
			get
			{
				throw NotImplemented.ByDesign;
			}
		}

		// Token: 0x06007558 RID: 30040 RVA: 0x00092631 File Offset: 0x00090831
		[NullableContext(2)]
		public override bool Equals(object o)
		{
			return base.Equals(o);
		}

		// Token: 0x06007559 RID: 30041 RVA: 0x0009264E File Offset: 0x0009084E
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600755A RID: 30042 RVA: 0x0011699B File Offset: 0x00114B9B
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool operator ==(Assembly left, Assembly right)
		{
			if (right == null)
			{
				return left == null;
			}
			return left == right || (left != null && left.Equals(right));
		}

		// Token: 0x0600755B RID: 30043 RVA: 0x001169B7 File Offset: 0x00114BB7
		[NullableContext(2)]
		public static bool operator !=(Assembly left, Assembly right)
		{
			return !(left == right);
		}

		// Token: 0x0600755C RID: 30044 RVA: 0x001169C3 File Offset: 0x00114BC3
		[NullableContext(2)]
		[return: Nullable(1)]
		public static string CreateQualifiedName(string assemblyName, string typeName)
		{
			return typeName + ", " + assemblyName;
		}

		// Token: 0x0600755D RID: 30045 RVA: 0x001169D1 File Offset: 0x00114BD1
		[return: Nullable(2)]
		public static Assembly GetAssembly(Type type)
		{
			if (type == null)
			{
				ThrowHelper.ThrowArgumentNullException(ExceptionArgument.type);
			}
			Module module = type.Module;
			if (module == null)
			{
				return null;
			}
			return module.Assembly;
		}

		// Token: 0x0600755E RID: 30046 RVA: 0x001169EE File Offset: 0x00114BEE
		[NullableContext(2)]
		public static void SetEntryAssembly(Assembly assembly)
		{
			if (assembly == null)
			{
				Assembly.s_overriddenEntryAssembly = string.Empty;
				return;
			}
			if (!(assembly is RuntimeAssembly))
			{
				throw new ArgumentException(SR.Argument_MustBeRuntimeAssembly);
			}
			Assembly.s_overriddenEntryAssembly = assembly;
		}

		// Token: 0x0600755F RID: 30047 RVA: 0x00116A17 File Offset: 0x00114C17
		[NullableContext(2)]
		public static Assembly GetEntryAssembly()
		{
			if (Assembly.s_overriddenEntryAssembly != null)
			{
				return Assembly.s_overriddenEntryAssembly as Assembly;
			}
			return Assembly.GetEntryAssemblyInternal();
		}

		// Token: 0x06007560 RID: 30048 RVA: 0x00116A30 File Offset: 0x00114C30
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		public static Assembly Load(byte[] rawAssembly)
		{
			return Assembly.Load(rawAssembly, null);
		}

		// Token: 0x06007561 RID: 30049 RVA: 0x00116A3C File Offset: 0x00114C3C
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		public static Assembly Load(byte[] rawAssembly, [Nullable(2)] byte[] rawSymbolStore)
		{
			ArgumentNullException.ThrowIfNull(rawAssembly, "rawAssembly");
			if (rawAssembly.Length == 0)
			{
				throw new BadImageFormatException(SR.BadImageFormat_BadILFormat);
			}
			SerializationInfo.ThrowIfDeserializationInProgress("AllowAssembliesFromByteArrays", ref Assembly.s_cachedSerializationSwitch);
			return new IndividualAssemblyLoadContext("Assembly.Load(byte[], ...)").InternalLoad(rawAssembly, rawSymbolStore);
		}

		// Token: 0x06007562 RID: 30050 RVA: 0x00116A90 File Offset: 0x00114C90
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		public static Assembly LoadFile(string path)
		{
			ArgumentNullException.ThrowIfNull(path, "path");
			if (PathInternal.IsPartiallyQualified(path))
			{
				throw new ArgumentException(SR.Format(SR.Argument_AbsolutePathRequired, path), "path");
			}
			string fullPath = Path.GetFullPath(path);
			Dictionary<string, Assembly> obj = Assembly.s_loadfile;
			Assembly assembly;
			lock (obj)
			{
				if (Assembly.s_loadfile.TryGetValue(fullPath, out assembly))
				{
					return assembly;
				}
				if (!File.Exists(fullPath))
				{
					throw new FileNotFoundException(SR.Format(SR.FileNotFound_LoadFile, fullPath), fullPath);
				}
				assembly = new IndividualAssemblyLoadContext("Assembly.LoadFile(" + fullPath + ")").LoadFromAssemblyPath(fullPath);
				Assembly.s_loadfile.Add(fullPath, assembly);
			}
			return assembly;
		}

		// Token: 0x06007563 RID: 30051 RVA: 0x00116B58 File Offset: 0x00114D58
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		[UnconditionalSuppressMessage("SingleFile", "IL3000:Avoid accessing Assembly file path when publishing as a single file", Justification = "The assembly is loaded by specifying a path outside of the single-file bundle, the location of the path will not be empty if the path exist, otherwise it will be handled as null")]
		private static Assembly LoadFromResolveHandler(object sender, ResolveEventArgs args)
		{
			Assembly requestingAssembly = args.RequestingAssembly;
			if (requestingAssembly == null)
			{
				return null;
			}
			if (AssemblyLoadContext.Default != AssemblyLoadContext.GetLoadContext(requestingAssembly))
			{
				return null;
			}
			string text = requestingAssembly.Location;
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			text = Path.GetFullPath(text);
			List<string> obj = Assembly.s_loadFromAssemblyList;
			lock (obj)
			{
				if (!Assembly.s_loadFromAssemblyList.Contains(text))
				{
					return null;
				}
			}
			AssemblyName assemblyName = new AssemblyName(args.Name);
			string text2 = Path.Combine(Path.GetDirectoryName(text), assemblyName.Name + ".dll");
			Assembly result;
			try
			{
				if (!File.Exists(text2))
				{
					result = null;
				}
				else
				{
					result = Assembly.LoadFrom(text2);
				}
			}
			catch (FileNotFoundException)
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06007564 RID: 30052 RVA: 0x00116C34 File Offset: 0x00114E34
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		public static Assembly LoadFrom(string assemblyFile)
		{
			ArgumentNullException.ThrowIfNull(assemblyFile, "assemblyFile");
			string fullPath = Path.GetFullPath(assemblyFile);
			List<string> obj;
			if (!Assembly.s_loadFromHandlerSet)
			{
				obj = Assembly.s_loadFromAssemblyList;
				lock (obj)
				{
					if (!Assembly.s_loadFromHandlerSet)
					{
						ResolveEventHandler value;
						if ((value = Assembly.<>O.<0>__LoadFromResolveHandler) == null)
						{
							value = (Assembly.<>O.<0>__LoadFromResolveHandler = new ResolveEventHandler(Assembly.LoadFromResolveHandler));
						}
						AssemblyLoadContext.AssemblyResolve += value;
						Assembly.s_loadFromHandlerSet = true;
					}
				}
			}
			obj = Assembly.s_loadFromAssemblyList;
			lock (obj)
			{
				if (!Assembly.s_loadFromAssemblyList.Contains(fullPath))
				{
					Assembly.s_loadFromAssemblyList.Add(fullPath);
				}
			}
			return AssemblyLoadContext.Default.LoadFromAssemblyPath(fullPath);
		}

		// Token: 0x06007565 RID: 30053 RVA: 0x00116D00 File Offset: 0x00114F00
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		[Obsolete("LoadFrom with a custom AssemblyHashAlgorithm is obsolete. Use overloads without an AssemblyHashAlgorithm.", DiagnosticId = "SYSLIB0056", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public static Assembly LoadFrom(string assemblyFile, [Nullable(2)] byte[] hashValue, AssemblyHashAlgorithm hashAlgorithm)
		{
			throw new NotSupportedException(SR.NotSupported_AssemblyLoadFromHash);
		}

		// Token: 0x06007566 RID: 30054 RVA: 0x00116D0C File Offset: 0x00114F0C
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		public static Assembly UnsafeLoadFrom(string assemblyFile)
		{
			return Assembly.LoadFrom(assemblyFile);
		}

		// Token: 0x06007567 RID: 30055 RVA: 0x00116D14 File Offset: 0x00114F14
		[RequiresUnreferencedCode("Types and members the loaded module depends on might be removed")]
		public Module LoadModule(string moduleName, [Nullable(2)] byte[] rawModule)
		{
			return this.LoadModule(moduleName, rawModule, null);
		}

		// Token: 0x06007568 RID: 30056 RVA: 0x0001A4BD File Offset: 0x000186BD
		[RequiresUnreferencedCode("Types and members the loaded module depends on might be removed")]
		public virtual Module LoadModule(string moduleName, [Nullable(2)] byte[] rawModule, [Nullable(2)] byte[] rawSymbolStore)
		{
			throw NotImplemented.ByDesign;
		}

		// Token: 0x06007569 RID: 30057 RVA: 0x0001AECB File Offset: 0x000190CB
		[Obsolete("ReflectionOnly loading is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0018", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		public static Assembly ReflectionOnlyLoad(byte[] rawAssembly)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ReflectionOnly);
		}

		// Token: 0x0600756A RID: 30058 RVA: 0x0001AECB File Offset: 0x000190CB
		[Obsolete("ReflectionOnly loading is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0018", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		public static Assembly ReflectionOnlyLoad(string assemblyString)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ReflectionOnly);
		}

		// Token: 0x0600756B RID: 30059 RVA: 0x0001AECB File Offset: 0x000190CB
		[Obsolete("ReflectionOnly loading is not supported and throws PlatformNotSupportedException.", DiagnosticId = "SYSLIB0018", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[RequiresUnreferencedCode("Types and members the loaded assembly depends on might be removed")]
		public static Assembly ReflectionOnlyLoadFrom(string assemblyFile)
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ReflectionOnly);
		}

		// Token: 0x17000E78 RID: 3704
		// (get) Token: 0x0600756C RID: 30060 RVA: 0x00007B65 File Offset: 0x00005D65
		public virtual SecurityRuleSet SecurityRuleSet
		{
			get
			{
				return SecurityRuleSet.None;
			}
		}

		// Token: 0x04001517 RID: 5399
		private static readonly Dictionary<string, Assembly> s_loadfile = new Dictionary<string, Assembly>();

		// Token: 0x04001518 RID: 5400
		private static readonly List<string> s_loadFromAssemblyList = new List<string>();

		// Token: 0x04001519 RID: 5401
		private static bool s_loadFromHandlerSet;

		// Token: 0x0400151A RID: 5402
		private static int s_cachedSerializationSwitch;

		// Token: 0x0400151B RID: 5403
		private static object s_overriddenEntryAssembly;

		// Token: 0x020006EC RID: 1772
		[CompilerGenerated]
		private static class <>O
		{
			// Token: 0x0400151C RID: 5404
			public static ResolveEventHandler <0>__LoadFromResolveHandler;
		}
	}
}
