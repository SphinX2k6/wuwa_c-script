using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A0C RID: 14860
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseDifficultyLevelInfo : ITrapDefenseDifficultyLevelInfo
	{
		// Token: 0x17004E47 RID: 20039
		// (get) Token: 0x060263BA RID: 156602 RVA: 0x00AB6571 File Offset: 0x00AB4771
		// (set) Token: 0x060263BB RID: 156603 RVA: 0x00AB6579 File Offset: 0x00AB4779
		public ETrapDefenseDifficultyLevel DifficultyLevel { get; set; }

		// Token: 0x17004E48 RID: 20040
		// (get) Token: 0x060263BC RID: 156604 RVA: 0x00AB6582 File Offset: 0x00AB4782
		// (set) Token: 0x060263BD RID: 156605 RVA: 0x00AB658A File Offset: 0x00AB478A
		public string NameKey { get; set; } = "";

		// Token: 0x17004E49 RID: 20041
		// (get) Token: 0x060263BE RID: 156606 RVA: 0x00AB6593 File Offset: 0x00AB4793
		// (set) Token: 0x060263BF RID: 156607 RVA: 0x00AB659B File Offset: 0x00AB479B
		public string NameBgKey { get; set; } = "";

		// Token: 0x17004E4A RID: 20042
		// (get) Token: 0x060263C0 RID: 156608 RVA: 0x00AB65A4 File Offset: 0x00AB47A4
		// (set) Token: 0x060263C1 RID: 156609 RVA: 0x00AB65AC File Offset: 0x00AB47AC
		public string BgKey { get; set; } = "";

		// Token: 0x17004E4B RID: 20043
		// (get) Token: 0x060263C2 RID: 156610 RVA: 0x00AB65B5 File Offset: 0x00AB47B5
		// (set) Token: 0x060263C3 RID: 156611 RVA: 0x00AB65BD File Offset: 0x00AB47BD
		public string BgLightKey { get; set; } = "";

		// Token: 0x17004E4C RID: 20044
		// (get) Token: 0x060263C4 RID: 156612 RVA: 0x00AB65C6 File Offset: 0x00AB47C6
		// (set) Token: 0x060263C5 RID: 156613 RVA: 0x00AB65CE File Offset: 0x00AB47CE
		public string BgTitleKey { get; set; } = "";

		// Token: 0x17004E4D RID: 20045
		// (get) Token: 0x060263C6 RID: 156614 RVA: 0x00AB65D7 File Offset: 0x00AB47D7
		// (set) Token: 0x060263C7 RID: 156615 RVA: 0x00AB65DF File Offset: 0x00AB47DF
		public string BgFlowerColor { get; set; } = "";

		// Token: 0x17004E4E RID: 20046
		// (get) Token: 0x060263C8 RID: 156616 RVA: 0x00AB65E8 File Offset: 0x00AB47E8
		// (set) Token: 0x060263C9 RID: 156617 RVA: 0x00AB65F0 File Offset: 0x00AB47F0
		public string ArtTextShadowColor { get; set; } = "";
	}
}
