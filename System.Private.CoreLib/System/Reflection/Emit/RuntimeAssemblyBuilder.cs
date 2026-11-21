using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Loader;

namespace System.Reflection.Emit
{
	// Token: 0x020007A3 RID: 1955
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class RuntimeAssemblyBuilder : AssemblyBuilder
	{
		// Token: 0x06007C98 RID: 31896
		[DynamicDependency("RuntimeResolve", typeof(RuntimeModuleBuilder))]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void basic_init(RuntimeAssemblyBuilder ab);

		// Token: 0x06007C99 RID: 31897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void UpdateNativeCustomAttributes(RuntimeAssemblyBuilder ab);

		// Token: 0x06007C9A RID: 31898 RVA: 0x001264C8 File Offset: 0x001246C8
		[DynamicDependency("access")]
		internal RuntimeAssemblyBuilder(AssemblyName n, AssemblyBuilderAccess access)
		{
			AssemblyBuilder.EnsureDynamicCodeSupported();
			this.aname = (AssemblyName)n.Clone();
			if (!Enum.IsDefined(typeof(AssemblyBuilderAccess), access))
			{
				throw new ArgumentException(SR.Format(CultureInfo.InvariantCulture, SR.Arg_EnumIllegalVal, (int)access), "access");
			}
			this.name = n.Name;
			this.access = (uint)access;
			if (n.CultureInfo != null)
			{
				this.culture = n.CultureInfo.Name;
			}
			Version version = n.Version;
			if (version != null)
			{
				this.version = version.ToString();
			}
			this.public_key_token = n.GetPublicKeyToken();
			RuntimeAssemblyBuilder.basic_init(this);
			this.manifest_module = new RuntimeModuleBuilder(this, "RefEmit_InMemoryManifestModule");
			this.modules = new RuntimeModuleBuilder[]
			{
				this.manifest_module
			};
			AssemblyLoadContext.InvokeAssemblyLoadEvent(this);
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06007C9B RID: 31899 RVA: 0x001265AE File Offset: 0x001247AE
		public override bool ReflectionOnly
		{
			get
			{
				return base.ReflectionOnly;
			}
		}

		// Token: 0x06007C9C RID: 31900 RVA: 0x001265B6 File Offset: 0x001247B6
		protected override ModuleBuilder DefineDynamicModuleCore(string name)
		{
			if (name[0] == '\0')
			{
				throw new ArgumentException(SR.Argument_InvalidName, "name");
			}
			if (this.manifest_module_used)
			{
				throw new InvalidOperationException(SR.InvalidOperation_NoMultiModuleAssembly);
			}
			this.manifest_module_used = true;
			return this.manifest_module;
		}

		// Token: 0x06007C9D RID: 31901 RVA: 0x001265F1 File Offset: 0x001247F1
		internal static AssemblyBuilder InternalDefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, AssemblyLoadContext _, IEnumerable<CustomAttributeBuilder> assemblyAttributes)
		{
			return AssemblyBuilder.DefineDynamicAssembly(name, access, assemblyAttributes);
		}

		// Token: 0x06007C9E RID: 31902 RVA: 0x001265FC File Offset: 0x001247FC
		protected override ModuleBuilder GetDynamicModuleCore(string name)
		{
			if (this.modules != null)
			{
				for (int i = 0; i < this.modules.Length; i++)
				{
					if (this.modules[i].name == name)
					{
						return this.modules[i];
					}
				}
			}
			return null;
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06007C9F RID: 31903 RVA: 0x00126643 File Offset: 0x00124843
		public override bool IsCollectible
		{
			get
			{
				return this.access == 9U;
			}
		}

		// Token: 0x06007CA0 RID: 31904 RVA: 0x00126650 File Offset: 0x00124850
		protected override void SetCustomAttributeCore(ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute)
		{
			CustomAttributeBuilder customAttributeBuilder = new CustomAttributeBuilder(con, binaryAttribute);
			if (this.cattrs != null)
			{
				CustomAttributeBuilder[] array = new CustomAttributeBuilder[this.cattrs.Length + 1];
				this.cattrs.CopyTo(array, 0);
				array[this.cattrs.Length] = customAttributeBuilder;
				this.cattrs = array;
			}
			else
			{
				this.cattrs = new CustomAttributeBuilder[1];
				this.cattrs[0] = customAttributeBuilder;
			}
			RuntimeAssemblyBuilder.UpdateNativeCustomAttributes(this);
		}

		// Token: 0x06007CA1 RID: 31905 RVA: 0x001266B9 File Offset: 0x001248B9
		internal static Type MakeGenericType(Type gtd, Type[] typeArguments)
		{
			return new TypeBuilderInstantiation(gtd, typeArguments);
		}

		// Token: 0x06007CA2 RID: 31906 RVA: 0x001266C4 File Offset: 0x001248C4
		[RequiresUnreferencedCode("Types might be removed by trimming. If the type name is a string literal, consider using Type.GetType instead.")]
		public override Type GetType(string name, bool throwOnError, bool ignoreCase)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			Type type = base.InternalGetType(null, name, throwOnError, ignoreCase);
			if (!(type is TypeBuilder))
			{
				return type;
			}
			if (throwOnError)
			{
				throw new TypeLoadException(SR.Format(SR.ClassLoad_General, name, this.name));
			}
			return null;
		}

		// Token: 0x06007CA3 RID: 31907 RVA: 0x0012670C File Offset: 0x0012490C
		public override Module GetModule(string name)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			if (this.modules == null)
			{
				return null;
			}
			foreach (RuntimeModuleBuilder module in this.modules)
			{
				if (module.ScopeName == name)
				{
					return module;
				}
			}
			return null;
		}

		// Token: 0x06007CA4 RID: 31908 RVA: 0x00126758 File Offset: 0x00124958
		public override Module[] GetModules(bool getResourceModules)
		{
			if (this.modules == null)
			{
				return Array.Empty<Module>();
			}
			return (Module[])this.modules.Clone();
		}

		// Token: 0x06007CA5 RID: 31909 RVA: 0x00126778 File Offset: 0x00124978
		public override AssemblyName GetName(bool copiedName)
		{
			return AssemblyName.Create(this._mono_assembly, null);
		}

		// Token: 0x06007CA6 RID: 31910 RVA: 0x0011B370 File Offset: 0x00119570
		[RequiresUnreferencedCode("Assembly references might be removed")]
		public override AssemblyName[] GetReferencedAssemblies()
		{
			return RuntimeAssembly.GetReferencedAssemblies(this);
		}

		// Token: 0x06007CA7 RID: 31911 RVA: 0x0011B2B4 File Offset: 0x001194B4
		public override Module[] GetLoadedModules(bool getResourceModules)
		{
			return this.GetModules(getResourceModules);
		}

		// Token: 0x06007CA8 RID: 31912 RVA: 0x0011B378 File Offset: 0x00119578
		public override Assembly GetSatelliteAssembly(CultureInfo culture)
		{
			return this.GetSatelliteAssembly(culture, null);
		}

		// Token: 0x06007CA9 RID: 31913 RVA: 0x00126786 File Offset: 0x00124986
		public override Assembly GetSatelliteAssembly(CultureInfo culture, Version version)
		{
			return RuntimeAssembly.InternalGetSatelliteAssembly(this, culture, version, true);
		}

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x06007CAA RID: 31914 RVA: 0x00126791 File Offset: 0x00124991
		public override Module ManifestModule
		{
			get
			{
				return this.manifest_module;
			}
		}

		// Token: 0x17001083 RID: 4227
		// (get) Token: 0x06007CAB RID: 31915 RVA: 0x00126799 File Offset: 0x00124999
		public override string FullName
		{
			get
			{
				return this.aname.ToString();
			}
		}

		// Token: 0x06007CAC RID: 31916 RVA: 0x001267A6 File Offset: 0x001249A6
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06007CAD RID: 31917 RVA: 0x001267AF File Offset: 0x001249AF
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06007CAE RID: 31918 RVA: 0x00009CC2 File Offset: 0x00007EC2
		public override bool IsDefined(Type attributeType, bool inherit)
		{
			return CustomAttribute.IsDefined(this, attributeType, inherit);
		}

		// Token: 0x06007CAF RID: 31919 RVA: 0x0011B1F4 File Offset: 0x001193F4
		public override object[] GetCustomAttributes(bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, inherit);
		}

		// Token: 0x06007CB0 RID: 31920 RVA: 0x0011B1FD File Offset: 0x001193FD
		public override object[] GetCustomAttributes(Type attributeType, bool inherit)
		{
			return CustomAttribute.GetCustomAttributes(this, attributeType, inherit);
		}

		// Token: 0x06007CB1 RID: 31921 RVA: 0x0011B693 File Offset: 0x00119893
		public override IList<CustomAttributeData> GetCustomAttributesData()
		{
			return CustomAttribute.GetCustomAttributesData(this, false);
		}

		// Token: 0x040017B1 RID: 6065
		internal IntPtr _mono_assembly;

		// Token: 0x040017B2 RID: 6066
		private LoaderAllocator m_keepalive;

		// Token: 0x040017B3 RID: 6067
		private UIntPtr dynamic_assembly;

		// Token: 0x040017B4 RID: 6068
		private RuntimeModuleBuilder[] modules;

		// Token: 0x040017B5 RID: 6069
		private string name;

		// Token: 0x040017B6 RID: 6070
		private CustomAttributeBuilder[] cattrs;

		// Token: 0x040017B7 RID: 6071
		private string version;

		// Token: 0x040017B8 RID: 6072
		private string culture;

		// Token: 0x040017B9 RID: 6073
		private byte[] public_key_token;

		// Token: 0x040017BA RID: 6074
		private Module[] loaded_modules;

		// Token: 0x040017BB RID: 6075
		private uint access;

		// Token: 0x040017BC RID: 6076
		private AssemblyName aname;

		// Token: 0x040017BD RID: 6077
		private RuntimeModuleBuilder manifest_module;

		// Token: 0x040017BE RID: 6078
		private bool manifest_module_used;
	}
}
