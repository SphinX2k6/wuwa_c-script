using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System
{
	// Token: 0x0200019F RID: 415
	[NullableContext(1)]
	[Nullable(0)]
	public class ResolveEventArgs : EventArgs
	{
		// Token: 0x06001ABC RID: 6844 RVA: 0x000570E9 File Offset: 0x000552E9
		public ResolveEventArgs(string name)
		{
			this.Name = name;
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x000570F8 File Offset: 0x000552F8
		public ResolveEventArgs(string name, [Nullable(2)] Assembly requestingAssembly)
		{
			this.Name = name;
			this.RequestingAssembly = requestingAssembly;
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06001ABE RID: 6846 RVA: 0x0005710E File Offset: 0x0005530E
		public string Name { get; }

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06001ABF RID: 6847 RVA: 0x00057116 File Offset: 0x00055316
		[Nullable(2)]
		public Assembly RequestingAssembly { [NullableContext(2)] get; }
	}
}
