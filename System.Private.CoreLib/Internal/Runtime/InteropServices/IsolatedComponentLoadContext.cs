using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.Loader;
using System.Runtime.Versioning;

namespace Internal.Runtime.InteropServices
{
	// Token: 0x0200006F RID: 111
	[UnsupportedOSPlatform("android")]
	[UnsupportedOSPlatform("browser")]
	[UnsupportedOSPlatform("ios")]
	[UnsupportedOSPlatform("maccatalyst")]
	[UnsupportedOSPlatform("tvos")]
	internal sealed class IsolatedComponentLoadContext : AssemblyLoadContext
	{
		// Token: 0x06000218 RID: 536 RVA: 0x000067B2 File Offset: 0x000049B2
		[RequiresUnreferencedCode("The trimmer might remove assemblies that are loaded by this class", Url = "https://aka.ms/dotnet-illink/nativehost")]
		public IsolatedComponentLoadContext(string componentAssemblyPath) : base("IsolatedComponentLoadContext(" + componentAssemblyPath + ")", false)
		{
			this._resolver = new AssemblyDependencyResolver(componentAssemblyPath);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000067D8 File Offset: 0x000049D8
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The trimmer warning is added to the constructor of this class since this method is a virtual one.")]
		protected override Assembly Load(AssemblyName assemblyName)
		{
			string text = this._resolver.ResolveAssemblyToPath(assemblyName);
			if (text != null)
			{
				return base.LoadFromAssemblyPath(text);
			}
			return null;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00006800 File Offset: 0x00004A00
		protected override IntPtr LoadUnmanagedDll(string unmanagedDllName)
		{
			string text = this._resolver.ResolveUnmanagedDllToPath(unmanagedDllName);
			if (text != null)
			{
				return base.LoadUnmanagedDllFromPath(text);
			}
			return IntPtr.Zero;
		}

		// Token: 0x040001DF RID: 479
		private readonly AssemblyDependencyResolver _resolver;
	}
}
