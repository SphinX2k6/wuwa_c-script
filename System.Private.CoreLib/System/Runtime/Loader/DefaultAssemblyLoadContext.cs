using System;

namespace System.Runtime.Loader
{
	// Token: 0x0200053A RID: 1338
	internal sealed class DefaultAssemblyLoadContext : AssemblyLoadContext
	{
		// Token: 0x06004964 RID: 18788 RVA: 0x000F31B3 File Offset: 0x000F13B3
		internal DefaultAssemblyLoadContext() : base(true, false, "Default")
		{
		}

		// Token: 0x040011AE RID: 4526
		internal static readonly AssemblyLoadContext s_loadContext = new DefaultAssemblyLoadContext();
	}
}
