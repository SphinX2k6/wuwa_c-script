using System;

namespace System.Runtime.Loader
{
	// Token: 0x0200053B RID: 1339
	internal sealed class IndividualAssemblyLoadContext : AssemblyLoadContext
	{
		// Token: 0x06004966 RID: 18790 RVA: 0x000F31CE File Offset: 0x000F13CE
		internal IndividualAssemblyLoadContext(string name) : base(false, false, name)
		{
		}
	}
}
