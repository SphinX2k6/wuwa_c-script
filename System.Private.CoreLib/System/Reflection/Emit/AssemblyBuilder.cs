using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;

namespace System.Reflection.Emit
{
	// Token: 0x020007A1 RID: 1953
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class AssemblyBuilder : Assembly
	{
		// Token: 0x06007C7E RID: 31870 RVA: 0x00126394 File Offset: 0x00124594
		[RequiresDynamicCode("Defining a dynamic assembly requires dynamic code.")]
		public static AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access)
		{
			ArgumentNullException.ThrowIfNull(name, "name");
			return new RuntimeAssemblyBuilder(name, access);
		}

		// Token: 0x06007C7F RID: 31871 RVA: 0x001263A8 File Offset: 0x001245A8
		[RequiresDynamicCode("Defining a dynamic assembly requires dynamic code.")]
		public static AssemblyBuilder DefineDynamicAssembly(AssemblyName name, AssemblyBuilderAccess access, [Nullable(new byte[]
		{
			2,
			1
		})] IEnumerable<CustomAttributeBuilder> assemblyAttributes)
		{
			AssemblyBuilder assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(name, access);
			if (assemblyAttributes != null)
			{
				foreach (CustomAttributeBuilder customAttribute in assemblyAttributes)
				{
					assemblyBuilder.SetCustomAttribute(customAttribute);
				}
			}
			return assemblyBuilder;
		}

		// Token: 0x06007C81 RID: 31873 RVA: 0x001263FC File Offset: 0x001245FC
		public ModuleBuilder DefineDynamicModule(string name)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			return this.DefineDynamicModuleCore(name);
		}

		// Token: 0x06007C82 RID: 31874
		protected abstract ModuleBuilder DefineDynamicModuleCore(string name);

		// Token: 0x06007C83 RID: 31875 RVA: 0x00126410 File Offset: 0x00124610
		[return: Nullable(2)]
		public ModuleBuilder GetDynamicModule(string name)
		{
			ArgumentException.ThrowIfNullOrEmpty(name, "name");
			return this.GetDynamicModuleCore(name);
		}

		// Token: 0x06007C84 RID: 31876
		[return: Nullable(2)]
		protected abstract ModuleBuilder GetDynamicModuleCore(string name);

		// Token: 0x06007C85 RID: 31877 RVA: 0x00126424 File Offset: 0x00124624
		public void SetCustomAttribute(ConstructorInfo con, byte[] binaryAttribute)
		{
			ArgumentNullException.ThrowIfNull(con, "con");
			ArgumentNullException.ThrowIfNull(binaryAttribute, "binaryAttribute");
			this.SetCustomAttributeCore(con, binaryAttribute);
		}

		// Token: 0x06007C86 RID: 31878
		[NullableContext(0)]
		protected abstract void SetCustomAttributeCore([Nullable(1)] ConstructorInfo con, ReadOnlySpan<byte> binaryAttribute);

		// Token: 0x06007C87 RID: 31879 RVA: 0x00126449 File Offset: 0x00124649
		public void SetCustomAttribute(CustomAttributeBuilder customBuilder)
		{
			ArgumentNullException.ThrowIfNull(customBuilder, "customBuilder");
			this.SetCustomAttributeCore(customBuilder.Ctor, customBuilder.Data);
		}

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06007C88 RID: 31880 RVA: 0x0012646D File Offset: 0x0012466D
		[Nullable(2)]
		[Obsolete("Assembly.CodeBase and Assembly.EscapedCodeBase are only included for .NET Framework compatibility. Use Assembly.Location instead.", DiagnosticId = "SYSLIB0012", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[RequiresAssemblyFiles("This member throws an exception for assemblies embedded in a single-file app")]
		public override string CodeBase
		{
			[NullableContext(2)]
			get
			{
				throw new NotSupportedException(SR.NotSupported_DynamicAssembly);
			}
		}

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06007C89 RID: 31881 RVA: 0x00028E4B File Offset: 0x0002704B
		public override string Location
		{
			get
			{
				return string.Empty;
			}
		}

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06007C8A RID: 31882 RVA: 0x0001A4BA File Offset: 0x000186BA
		[Nullable(2)]
		public override MethodInfo EntryPoint
		{
			[NullableContext(2)]
			get
			{
				return null;
			}
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x06007C8B RID: 31883 RVA: 0x000070DD File Offset: 0x000052DD
		public override bool IsDynamic
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06007C8C RID: 31884 RVA: 0x0012646D File Offset: 0x0012466D
		[RequiresUnreferencedCode("Types might be removed")]
		public override Type[] GetExportedTypes()
		{
			throw new NotSupportedException(SR.NotSupported_DynamicAssembly);
		}

		// Token: 0x06007C8D RID: 31885 RVA: 0x0012646D File Offset: 0x0012466D
		[RequiresAssemblyFiles("This member throws an exception for assemblies embedded in a single-file app")]
		public override FileStream GetFile(string name)
		{
			throw new NotSupportedException(SR.NotSupported_DynamicAssembly);
		}

		// Token: 0x06007C8E RID: 31886 RVA: 0x0012646D File Offset: 0x0012466D
		[RequiresAssemblyFiles("This member throws an exception for assemblies embedded in a single-file app")]
		public override FileStream[] GetFiles(bool getResourceModules)
		{
			throw new NotSupportedException(SR.NotSupported_DynamicAssembly);
		}

		// Token: 0x06007C8F RID: 31887 RVA: 0x0012646D File Offset: 0x0012466D
		[return: Nullable(2)]
		public override ManifestResourceInfo GetManifestResourceInfo(string resourceName)
		{
			throw new NotSupportedException(SR.NotSupported_DynamicAssembly);
		}

		// Token: 0x06007C90 RID: 31888 RVA: 0x0012646D File Offset: 0x0012466D
		public override string[] GetManifestResourceNames()
		{
			throw new NotSupportedException(SR.NotSupported_DynamicAssembly);
		}

		// Token: 0x06007C91 RID: 31889 RVA: 0x0012646D File Offset: 0x0012466D
		[return: Nullable(2)]
		public override Stream GetManifestResourceStream(string name)
		{
			throw new NotSupportedException(SR.NotSupported_DynamicAssembly);
		}

		// Token: 0x06007C92 RID: 31890 RVA: 0x0012646D File Offset: 0x0012466D
		[return: Nullable(2)]
		public override Stream GetManifestResourceStream(Type type, string name)
		{
			throw new NotSupportedException(SR.NotSupported_DynamicAssembly);
		}

		// Token: 0x06007C93 RID: 31891 RVA: 0x00126479 File Offset: 0x00124679
		internal static void EnsureDynamicCodeSupported()
		{
			if (!RuntimeFeature.IsDynamicCodeSupported && !AssemblyBuilder.t_allowDynamicCode)
			{
				AssemblyBuilder.ThrowDynamicCodeNotSupported();
			}
		}

		// Token: 0x06007C94 RID: 31892 RVA: 0x0012648E File Offset: 0x0012468E
		internal static IDisposable ForceAllowDynamicCode()
		{
			return new AssemblyBuilder.ForceAllowDynamicCodeScope();
		}

		// Token: 0x06007C95 RID: 31893 RVA: 0x00126495 File Offset: 0x00124695
		private static void ThrowDynamicCodeNotSupported()
		{
			throw new PlatformNotSupportedException(SR.PlatformNotSupported_ReflectionEmit);
		}

		// Token: 0x040017AF RID: 6063
		[ThreadStatic]
		private static bool t_allowDynamicCode;

		// Token: 0x020007A2 RID: 1954
		private sealed class ForceAllowDynamicCodeScope : IDisposable
		{
			// Token: 0x06007C96 RID: 31894 RVA: 0x001264A1 File Offset: 0x001246A1
			public ForceAllowDynamicCodeScope()
			{
				this._previous = AssemblyBuilder.t_allowDynamicCode;
				AssemblyBuilder.t_allowDynamicCode = true;
			}

			// Token: 0x06007C97 RID: 31895 RVA: 0x001264BA File Offset: 0x001246BA
			public void Dispose()
			{
				AssemblyBuilder.t_allowDynamicCode = this._previous;
			}

			// Token: 0x040017B0 RID: 6064
			private readonly bool _previous;
		}
	}
}
