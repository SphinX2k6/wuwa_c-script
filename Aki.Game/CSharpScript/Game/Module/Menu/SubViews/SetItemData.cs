using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu.SubViews
{
	// Token: 0x02004421 RID: 17441
	[NullableContext(1)]
	[Nullable(0)]
	public class SetItemData : ISetItemData
	{
		// Token: 0x1700580C RID: 22540
		// (get) Token: 0x0602C05A RID: 180314 RVA: 0x00C5C3D6 File Offset: 0x00C5A5D6
		// (set) Token: 0x0602C05B RID: 180315 RVA: 0x00C5C3DE File Offset: 0x00C5A5DE
		public int Index { get; set; }

		// Token: 0x1700580D RID: 22541
		// (get) Token: 0x0602C05C RID: 180316 RVA: 0x00C5C3E7 File Offset: 0x00C5A5E7
		// (set) Token: 0x0602C05D RID: 180317 RVA: 0x00C5C3EF File Offset: 0x00C5A5EF
		public int Value { get; set; }

		// Token: 0x1700580E RID: 22542
		// (get) Token: 0x0602C05E RID: 180318 RVA: 0x00C5C3F8 File Offset: 0x00C5A5F8
		// (set) Token: 0x0602C05F RID: 180319 RVA: 0x00C5C400 File Offset: 0x00C5A600
		public string Name { get; set; } = "";
	}
}
