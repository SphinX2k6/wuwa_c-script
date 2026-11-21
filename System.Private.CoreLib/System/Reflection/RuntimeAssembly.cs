using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Loader;
using System.Threading;
using Mono;

namespace System.Reflection
{
	// Token: 0x02000700 RID: 1792
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeAssembly : Assembly
	{
		// Token: 0x060076B2 RID: 30386 RVA: 0x0011AE78 File Offset: 0x00119078
		internal IntPtr GetUnderlyingNativeHandle()
		{
			return this._mono_assembly;
		}

		// Token: 0x060076B3 RID: 30387
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetEntryPoint(QCallAssembly assembly, ObjectHandleOnStack res);

		// Token: 0x17000EDA RID: 3802
		// (get) Token: 0x060076B4 RID: 30388 RVA: 0x0011AE80 File Offset: 0x00119080
		public override MethodInfo EntryPoint
		{
			get
			{
				RuntimeAssembly runtimeAssembly = this;
				MethodInfo result = null;
				RuntimeAssembly.GetEntryPoint(new QCallAssembly(ref runtimeAssembly), ObjectHandleOnStack.Create<MethodInfo>(ref result));
				return result;
			}
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x060076B5 RID: 30389 RVA: 0x00007B65 File Offset: 0x00005D65
		public override bool ReflectionOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x060076B6 RID: 30390 RVA: 0x0011AEA5 File Offset: 0x001190A5
		[Obsolete("Assembly.CodeBase and Assembly.EscapedCodeBase are only included for .NET Framework compatibility. Use Assembly.Location.", DiagnosticId = "SYSLIB0012", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[RequiresAssemblyFiles("This member throws an exception for assemblies embedded in a single-file app")]
		public override string CodeBase
		{
			get
			{
				return this.GetInfo(RuntimeAssembly.AssemblyInfoKind.CodeBase);
			}
		}

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x060076B7 RID: 30391 RVA: 0x0011AEAE File Offset: 0x001190AE
		public override string FullName
		{
			get
			{
				return this.GetInfo(RuntimeAssembly.AssemblyInfoKind.FullName);
			}
		}

		// Token: 0x1400001B RID: 27
		// (add) Token: 0x060076B8 RID: 30392 RVA: 0x0011AEB7 File Offset: 0x001190B7
		// (remove) Token: 0x060076B9 RID: 30393 RVA: 0x0011AEC5 File Offset: 0x001190C5
		public override event ModuleResolveEventHandler ModuleResolve
		{
			add
			{
				this.resolve_event_holder.ModuleResolve += value;
			}
			remove
			{
				this.resolve_event_holder.ModuleResolve -= value;
			}
		}

		// Token: 0x17000EDE RID: 3806
		// (get) Token: 0x060076BA RID: 30394 RVA: 0x0011AED4 File Offset: 0x001190D4
		public override Module ManifestModule
		{
			get
			{
				RuntimeAssembly runtimeAssembly = this;
				Module result = null;
				RuntimeAssembly.GetManifestModuleInternal(new QCallAssembly(ref runtimeAssembly), ObjectHandleOnStack.Create<Module>(ref result));
				return result;
			}
		}

		// Token: 0x17000EDF RID: 3807
		// (get) Token: 0x060076BB RID: 30395 RVA: 0x00007B65 File Offset: 0x00005D65
		[Obsolete("The Global Assembly Cache is not supported.", DiagnosticId = "SYSLIB0005", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		public override bool GlobalAssemblyCache
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000EE0 RID: 3808
		// (get) Token: 0x060076BC RID: 30396 RVA: 0x000304C1 File Offset: 0x0002E6C1
		public override long HostContext
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000EE1 RID: 3809
		// (get) Token: 0x060076BD RID: 30397 RVA: 0x0011AEF9 File Offset: 0x001190F9
		public override string ImageRuntimeVersion
		{
			get
			{
				return this.GetInfo(RuntimeAssembly.AssemblyInfoKind.ImageRuntimeVersion);
			}
		}

		// Token: 0x17000EE2 RID: 3810
		// (get) Token: 0x060076BE RID: 30398 RVA: 0x0011AF02 File Offset: 0x00119102
		public override string Location
		{
			get
			{
				return this.GetInfo(RuntimeAssembly.AssemblyInfoKind.Location);
			}
		}

		// Token: 0x17000EE3 RID: 3811
		// (get) Token: 0x060076BF RID: 30399 RVA: 0x0011AF0B File Offset: 0x0011910B
		public override bool IsCollectible
		{
			get
			{
				return AssemblyLoadContext.GetLoadContext(this).IsCollectible;
			}
		}

		// Token: 0x060076C0 RID: 30400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetManifestResourceNames(QCallAssembly assembly_h, ObjectHandleOnStack res);

		// Token: 0x060076C1 RID: 30401 RVA: 0x0011AF18 File Offset: 0x00119118
		public override string[] GetManifestResourceNames()
		{
			RuntimeAssembly runtimeAssembly = this;
			string[] result = null;
			RuntimeAssembly.GetManifestResourceNames(new QCallAssembly(ref runtimeAssembly), ObjectHandleOnStack.Create<string[]>(ref result));
			return result;
		}

		// Token: 0x060076C2 RID: 30402
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetExportedTypes(QCallAssembly assembly_h, ObjectHandleOnStack res);

		// Token: 0x060076C3 RID: 30403 RVA: 0x0011AF40 File Offset: 0x00119140
		[RequiresUnreferencedCode("Types might be removed")]
		public override Type[] GetExportedTypes()
		{
			RuntimeAssembly runtimeAssembly = this;
			Type[] result = null;
			RuntimeAssembly.GetExportedTypes(new QCallAssembly(ref runtimeAssembly), ObjectHandleOnStack.Create<Type[]>(ref result));
			return result;
		}

		// Token: 0x060076C4 RID: 30404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetTopLevelForwardedTypes(QCallAssembly assembly_h, ObjectHandleOnStack res);

		// Token: 0x060076C5 RID: 30405 RVA: 0x0011AF68 File Offset: 0x00119168
		[RequiresUnreferencedCode("Types might be removed")]
		public override Type[] GetForwardedTypes()
		{
			RuntimeAssembly runtimeAssembly = this;
			Type[] array = null;
			RuntimeAssembly.GetTopLevelForwardedTypes(new QCallAssembly(ref runtimeAssembly), ObjectHandleOnStack.Create<Type[]>(ref array));
			List<Type> list = new List<Type>(array);
			List<Exception> list2 = new List<Exception>();
			Type[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				RuntimeAssembly.AddPublicNestedTypes(array2[i], list, list2);
			}
			if (list2.Count > 0)
			{
				list.AddRange(new Type[list2.Count]);
				list2.InsertRange(0, new Exception[list.Count]);
				throw new ReflectionTypeLoadException(list.ToArray(), list2.ToArray());
			}
			return list.ToArray();
		}

		// Token: 0x060076C6 RID: 30406 RVA: 0x0011B000 File Offset: 0x00119200
		[RequiresUnreferencedCode("Types might be removed")]
		private static void AddPublicNestedTypes(Type type, List<Type> types, List<Exception> exceptions)
		{
			Type[] nestedTypes;
			try
			{
				nestedTypes = type.GetNestedTypes(BindingFlags.Public);
			}
			catch (FileLoadException item)
			{
				exceptions.Add(item);
				return;
			}
			catch (FileNotFoundException item2)
			{
				exceptions.Add(item2);
				return;
			}
			catch (TypeLoadException item3)
			{
				exceptions.Add(item3);
				return;
			}
			catch (IOException item4)
			{
				exceptions.Add(item4);
				return;
			}
			catch (UnauthorizedAccessException item5)
			{
				exceptions.Add(item5);
				return;
			}
			foreach (Type type2 in nestedTypes)
			{
				types.Add(type2);
				RuntimeAssembly.AddPublicNestedTypes(type2, types, exceptions);
			}
		}

		// Token: 0x060076C7 RID: 30407 RVA: 0x0011B0BC File Offset: 0x001192BC
		public override ManifestResourceInfo GetManifestResourceInfo(string resourceName)
		{
			ArgumentException.ThrowIfNullOrEmpty(resourceName, "resourceName");
			ManifestResourceInfo manifestResourceInfo = new ManifestResourceInfo(null, null, (ResourceLocation)0);
			RuntimeAssembly runtimeAssembly = this;
			if (RuntimeAssembly.GetManifestResourceInfoInternal(new QCallAssembly(ref runtimeAssembly), resourceName, manifestResourceInfo))
			{
				return manifestResourceInfo;
			}
			return null;
		}

		// Token: 0x060076C8 RID: 30408 RVA: 0x0011B0F4 File Offset: 0x001192F4
		public unsafe override Stream GetManifestResourceStream(string name)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			Module module = null;
			RuntimeAssembly runtimeAssembly = this;
			int num;
			byte* manifestResourceInternal = RuntimeAssembly.GetManifestResourceInternal(new QCallAssembly(ref runtimeAssembly), name, out num, ObjectHandleOnStack.Create<Module>(ref module));
			if (manifestResourceInternal == null)
			{
				runtimeAssembly = AssemblyLoadContext.OnResourceResolve(runtimeAssembly, name);
				if (runtimeAssembly != null)
				{
					manifestResourceInternal = RuntimeAssembly.GetManifestResourceInternal(new QCallAssembly(ref runtimeAssembly), name, out num, ObjectHandleOnStack.Create<Module>(ref module));
				}
				if (manifestResourceInternal == null)
				{
					return null;
				}
			}
			return new RuntimeAssembly.UnmanagedMemoryStreamForModule(manifestResourceInternal, (long)num, module);
		}

		// Token: 0x060076C9 RID: 30409 RVA: 0x0011B164 File Offset: 0x00119364
		public override Stream GetManifestResourceStream(Type type, string name)
		{
			if (name == null)
			{
				ArgumentNullException.ThrowIfNull(type, "type");
			}
			string text = (type != null) ? type.Namespace : null;
			string text2;
			if (text == null || name == null)
			{
				text2 = text + name;
			}
			else
			{
				ReadOnlySpan<char> str = text;
				char delimiter = Type.Delimiter;
				text2 = str + new ReadOnlySpan<char>(ref delimiter) + name;
			}
			string name2 = text2;
			return this.GetManifestResourceStream(name2);
		}

		// Token: 0x060076CA RID: 30410 RVA: 0x0011B1C1 File Offset: 0x001193C1
		public override AssemblyName GetName(bool copiedName)
		{
			return AssemblyName.Create(this._mono_assembly, this.GetInfo(RuntimeAssembly.AssemblyInfoKind.CodeBase));
		}

		// Token: 0x060076CB RID: 30411 RVA: 0x0011B1D5 File Offset: 0x001193D5
		[RequiresUnreferencedCode("Types might be removed by trimming. If the type name is a string literal, consider using Type.GetType instead.")]
		public override Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			return base.InternalGetType(null, name, throwOnError, ignoreCase);
		}

		// Token: 0x060076CC RID: 30412 RVA: 0x00009CC2 File Offset: 0x00007EC2
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return CustomAttribute.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x060076CD RID: 30413 RVA: 0x0011B1EC File Offset: 0x001193EC
		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return RuntimeCustomAttributeData.GetCustomAttributesInternal(this);
		}

		// Token: 0x060076CE RID: 30414 RVA: 0x0011B1F4 File Offset: 0x001193F4
		public override object[] GetCustomAttributes(bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, inherit);
		}

		// Token: 0x060076CF RID: 30415 RVA: 0x0011B1FD File Offset: 0x001193FD
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x060076D0 RID: 30416 RVA: 0x0011B208 File Offset: 0x00119408
		public override Module GetModule(string name)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			foreach (Module module in this.GetModules(true))
			{
				if (module.ScopeName == name)
				{
					return module;
				}
			}
			return null;
		}

		// Token: 0x060076D1 RID: 30417 RVA: 0x0011B24C File Offset: 0x0011944C
		public override Module[] GetModules(bool getResourceModules)
		{
			RuntimeAssembly runtimeAssembly = this;
			Module[] array = null;
			RuntimeAssembly.GetModulesInternal(new QCallAssembly(ref runtimeAssembly), ObjectHandleOnStack.Create<Module[]>(ref array));
			Module[] array2 = array;
			if (!getResourceModules)
			{
				List<Module> list = new List<Module>(array2.Length);
				foreach (Module module in array2)
				{
					if (!module.IsResource())
					{
						list.Add(module);
					}
				}
				return list.ToArray();
			}
			return array2;
		}

		// Token: 0x060076D2 RID: 30418 RVA: 0x0011B2B4 File Offset: 0x001194B4
		public override Module[] GetLoadedModules(bool getResourceModules)
		{
			return this.GetModules(getResourceModules);
		}

		// Token: 0x060076D3 RID: 30419 RVA: 0x0011B2C0 File Offset: 0x001194C0
		internal unsafe static AssemblyName[] GetReferencedAssemblies(Assembly assembly)
		{
			AssemblyName[] result;
			using (SafeGPtrArrayHandle safeGPtrArrayHandle = new SafeGPtrArrayHandle(RuntimeAssembly.InternalGetReferencedAssemblies(assembly)))
			{
				int length = safeGPtrArrayHandle.Length;
				try
				{
					AssemblyName[] array = new AssemblyName[length];
					for (int i = 0; i < length; i++)
					{
						AssemblyName assemblyName = new AssemblyName();
						MonoAssemblyName* native = safeGPtrArrayHandle[i];
						assemblyName.FillName(native, null, true, false, true);
						array[i] = assemblyName;
					}
					result = array;
				}
				finally
				{
					for (int j = 0; j < length; j++)
					{
						MonoAssemblyName* name = safeGPtrArrayHandle[j];
						AssemblyName.FreeAssemblyName(ref *name, true);
					}
				}
			}
			return result;
		}

		// Token: 0x060076D4 RID: 30420 RVA: 0x0011B370 File Offset: 0x00119570
		[RequiresUnreferencedCode("Assembly references might be removed")]
		public override AssemblyName[] GetReferencedAssemblies()
		{
			return RuntimeAssembly.GetReferencedAssemblies(this);
		}

		// Token: 0x060076D5 RID: 30421 RVA: 0x0011B378 File Offset: 0x00119578
		public override Assembly GetSatelliteAssembly(CultureInfo culture)
		{
			return this.GetSatelliteAssembly(culture, null);
		}

		// Token: 0x060076D6 RID: 30422 RVA: 0x0011B382 File Offset: 0x00119582
		public override Assembly GetSatelliteAssembly(CultureInfo culture, Version version)
		{
			ArgumentNullException.ThrowIfNull(culture, "culture");
			return RuntimeAssembly.InternalGetSatelliteAssembly(this, culture, version, true);
		}

		// Token: 0x060076D7 RID: 30423 RVA: 0x0011B398 File Offset: 0x00119598
		internal static Assembly InternalGetSatelliteAssembly(Assembly assembly, CultureInfo culture, Version version, bool throwOnFileNotFound)
		{
			if (throwOnFileNotFound)
			{
				throw new FileNotFoundException(SR.Format(culture, SR.IO_FileNotFound_FileName, assembly.GetName().Name + ".resources"));
			}
			return null;
		}

		// Token: 0x060076D8 RID: 30424 RVA: 0x0011B3C4 File Offset: 0x001195C4
		[RequiresAssemblyFiles("This member throws an exception for assemblies embedded in a single-file app")]
		public override FileStream GetFile(string name)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			if (this.Location.Length == 0)
			{
				throw new FileNotFoundException(SR.IO_NoFileTableInInMemoryAssemblies);
			}
			RuntimeModule runtimeModule = (RuntimeModule)this.GetModule(name);
			if (runtimeModule != null)
			{
				return new FileStream(runtimeModule.FullyQualifiedName, FileMode.Open, FileAccess.Read);
			}
			return null;
		}

		// Token: 0x060076D9 RID: 30425 RVA: 0x0011B41C File Offset: 0x0011961C
		[RequiresAssemblyFiles("This member throws an exception for assemblies embedded in a single-file app")]
		public override FileStream[] GetFiles(bool getResourceModules)
		{
			if (this.Location.Length == 0)
			{
				throw new FileNotFoundException(SR.IO_NoFileTableInInMemoryAssemblies);
			}
			Module[] modules = this.GetModules(getResourceModules);
			if (modules.Length == 0)
			{
				return Array.Empty<FileStream>();
			}
			FileStream[] array = new FileStream[modules.Length];
			for (int i = 0; i < modules.Length; i++)
			{
				RuntimeModule runtimeModule = (RuntimeModule)modules[i];
				array[i] = new FileStream(runtimeModule.FullyQualifiedName, FileMode.Open, FileAccess.Read);
			}
			return array;
		}

		// Token: 0x060076DA RID: 30426 RVA: 0x0011B484 File Offset: 0x00119684
		internal static RuntimeAssembly InternalLoad(AssemblyName assemblyRef, ref StackCrawlMark stackMark, AssemblyLoadContext assemblyLoadContext)
		{
			RuntimeAssembly runtimeAssembly = (RuntimeAssembly)Assembly.InternalLoad(assemblyRef.FullName, ref stackMark, (assemblyLoadContext != null) ? assemblyLoadContext.NativeALC : IntPtr.Zero);
			if (runtimeAssembly == null)
			{
				throw new FileNotFoundException(null, assemblyRef.Name);
			}
			return runtimeAssembly;
		}

		// Token: 0x060076DB RID: 30427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetInfo(QCallAssembly assembly, ObjectHandleOnStack res, RuntimeAssembly.AssemblyInfoKind kind);

		// Token: 0x060076DC RID: 30428 RVA: 0x0011B4C0 File Offset: 0x001196C0
		private string GetInfo(RuntimeAssembly.AssemblyInfoKind kind)
		{
			RuntimeAssembly runtimeAssembly = this;
			string result = null;
			RuntimeAssembly.GetInfo(new QCallAssembly(ref runtimeAssembly), ObjectHandleOnStack.Create<string>(ref result), kind);
			return result;
		}

		// Token: 0x060076DD RID: 30429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool GetManifestResourceInfoInternal(QCallAssembly assembly, string name, ManifestResourceInfo info);

		// Token: 0x060076DE RID: 30430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr GetManifestResourceInternal(QCallAssembly assembly, string name, out int size, ObjectHandleOnStack module);

		// Token: 0x060076DF RID: 30431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetManifestModuleInternal(QCallAssembly assembly, ObjectHandleOnStack res);

		// Token: 0x060076E0 RID: 30432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetModulesInternal(QCallAssembly assembly, ObjectHandleOnStack res);

		// Token: 0x060076E1 RID: 30433
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr InternalGetReferencedAssemblies(Assembly assembly);

		// Token: 0x060076E2 RID: 30434 RVA: 0x0011B4E6 File Offset: 0x001196E6
		internal string GetSimpleName()
		{
			return this.GetName().Name;
		}

		// Token: 0x04001564 RID: 5476
		private IntPtr _mono_assembly;

		// Token: 0x04001565 RID: 5477
		private LoaderAllocator m_keepalive;

		// Token: 0x04001566 RID: 5478
		private RuntimeAssembly.ResolveEventHolder resolve_event_holder;

		// Token: 0x02000701 RID: 1793
		private enum AssemblyInfoKind
		{
			// Token: 0x04001568 RID: 5480
			Location = 1,
			// Token: 0x04001569 RID: 5481
			CodeBase,
			// Token: 0x0400156A RID: 5482
			FullName,
			// Token: 0x0400156B RID: 5483
			ImageRuntimeVersion
		}

		// Token: 0x02000702 RID: 1794
		private sealed class ResolveEventHolder
		{
			// Token: 0x1400001C RID: 28
			// (add) Token: 0x060076E4 RID: 30436 RVA: 0x0011B4FC File Offset: 0x001196FC
			// (remove) Token: 0x060076E5 RID: 30437 RVA: 0x0011B534 File Offset: 0x00119734
			public event ModuleResolveEventHandler ModuleResolve;
		}

		// Token: 0x02000703 RID: 1795
		private sealed class UnmanagedMemoryStreamForModule : UnmanagedMemoryStream
		{
			// Token: 0x060076E6 RID: 30438 RVA: 0x0011B569 File Offset: 0x00119769
			public unsafe UnmanagedMemoryStreamForModule(byte* pointer, long length, Module module) : base(pointer, length)
			{
				this.module = module;
			}

			// Token: 0x0400156D RID: 5485
			private Module module;
		}
	}
}
