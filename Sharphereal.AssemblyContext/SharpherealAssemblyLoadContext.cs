using System;
using System.Runtime.CompilerServices;
using System.Runtime.Loader;

namespace AssemblyContext
{
	// Token: 0x02000002 RID: 2
	public class SharpherealAssemblyLoadContext : AssemblyLoadContext
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[NullableContext(1)]
		public SharpherealAssemblyLoadContext(string name) : base(name, true)
		{
		}
	}
}
