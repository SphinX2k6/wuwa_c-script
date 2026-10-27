using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A46 RID: 19014
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseTab<[Nullable(2)] T> : ITrapDefenseTab<T>
	{
		// Token: 0x17007A4E RID: 31310
		// (get) Token: 0x06031592 RID: 202130 RVA: 0x00B72308 File Offset: 0x00B70508
		// (set) Token: 0x06031593 RID: 202131 RVA: 0x00B72310 File Offset: 0x00B70510
		public T TabType { get; set; }

		// Token: 0x17007A4F RID: 31311
		// (get) Token: 0x06031594 RID: 202132 RVA: 0x00B72319 File Offset: 0x00B70519
		// (set) Token: 0x06031595 RID: 202133 RVA: 0x00B72321 File Offset: 0x00B70521
		public string TabNameKey { get; set; } = "";
	}
}
