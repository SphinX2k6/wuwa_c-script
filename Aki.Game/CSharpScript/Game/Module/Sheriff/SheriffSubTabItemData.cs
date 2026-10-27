using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Sheriff
{
	// Token: 0x02004C40 RID: 19520
	[NullableContext(1)]
	[Nullable(0)]
	public class SheriffSubTabItemData : ISheriffSubTabItemData
	{
		// Token: 0x17007CB6 RID: 31926
		// (get) Token: 0x060327DC RID: 206812 RVA: 0x00BC3235 File Offset: 0x00BC1435
		// (set) Token: 0x060327DD RID: 206813 RVA: 0x00BC323D File Offset: 0x00BC143D
		public ESheriffSubTabType TabType { get; set; }

		// Token: 0x17007CB7 RID: 31927
		// (get) Token: 0x060327DE RID: 206814 RVA: 0x00BC3246 File Offset: 0x00BC1446
		// (set) Token: 0x060327DF RID: 206815 RVA: 0x00BC324E File Offset: 0x00BC144E
		public string TabIcon { get; set; } = "";

		// Token: 0x17007CB8 RID: 31928
		// (get) Token: 0x060327E0 RID: 206816 RVA: 0x00BC3257 File Offset: 0x00BC1457
		// (set) Token: 0x060327E1 RID: 206817 RVA: 0x00BC325F File Offset: 0x00BC145F
		public string TabTxt { get; set; } = "";

		// Token: 0x17007CB9 RID: 31929
		// (get) Token: 0x060327E2 RID: 206818 RVA: 0x00BC3268 File Offset: 0x00BC1468
		// (set) Token: 0x060327E3 RID: 206819 RVA: 0x00BC3270 File Offset: 0x00BC1470
		public bool IsFinished { get; set; }
	}
}
