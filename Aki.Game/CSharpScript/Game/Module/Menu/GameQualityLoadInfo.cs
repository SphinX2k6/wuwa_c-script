using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Menu
{
	// Token: 0x020043E4 RID: 17380
	[NullableContext(1)]
	[Nullable(0)]
	public class GameQualityLoadInfo : IGameQualityLoadInfo
	{
		// Token: 0x170057F5 RID: 22517
		// (get) Token: 0x0602BE9C RID: 179868 RVA: 0x00C543C8 File Offset: 0x00C525C8
		// (set) Token: 0x0602BE9D RID: 179869 RVA: 0x00C543D0 File Offset: 0x00C525D0
		public string Desc { get; set; } = "";

		// Token: 0x170057F6 RID: 22518
		// (get) Token: 0x0602BE9E RID: 179870 RVA: 0x00C543D9 File Offset: 0x00C525D9
		// (set) Token: 0x0602BE9F RID: 179871 RVA: 0x00C543E1 File Offset: 0x00C525E1
		public int Percentage { get; set; }

		// Token: 0x170057F7 RID: 22519
		// (get) Token: 0x0602BEA0 RID: 179872 RVA: 0x00C543EA File Offset: 0x00C525EA
		// (set) Token: 0x0602BEA1 RID: 179873 RVA: 0x00C543F2 File Offset: 0x00C525F2
		public string BarColor { get; set; } = "";
	}
}
