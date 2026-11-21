using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039EE RID: 14830
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseTab<[Nullable(2)] T> : ITrapDefenseTab<T>
	{
		// Token: 0x17004DFB RID: 19963
		// (get) Token: 0x06026322 RID: 156450 RVA: 0x00AB628C File Offset: 0x00AB448C
		// (set) Token: 0x06026323 RID: 156451 RVA: 0x00AB6294 File Offset: 0x00AB4494
		public T TabType { get; set; }

		// Token: 0x17004DFC RID: 19964
		// (get) Token: 0x06026324 RID: 156452 RVA: 0x00AB629D File Offset: 0x00AB449D
		// (set) Token: 0x06026325 RID: 156453 RVA: 0x00AB62A5 File Offset: 0x00AB44A5
		public string TabNameKey { get; set; } = "";
	}
}
