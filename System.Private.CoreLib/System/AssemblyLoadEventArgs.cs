using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x020000D8 RID: 216
	[NullableContext(1)]
	[Nullable(0)]
	public class AssemblyLoadEventArgs : EventArgs
	{
		// Token: 0x06000A44 RID: 2628 RVA: 0x0001F03D File Offset: 0x0001D23D
		public AssemblyLoadEventArgs(Assembly loadedAssembly)
		{
			this.LoadedAssembly = loadedAssembly;
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000A45 RID: 2629 RVA: 0x0001F04C File Offset: 0x0001D24C
		public Assembly LoadedAssembly { get; }
	}
}
