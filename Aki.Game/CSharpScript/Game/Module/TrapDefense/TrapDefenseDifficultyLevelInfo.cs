using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A64 RID: 19044
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseDifficultyLevelInfo : ITrapDefenseDifficultyLevelInfo
	{
		// Token: 0x17007A9A RID: 31386
		// (get) Token: 0x0603162A RID: 202282 RVA: 0x00B725ED File Offset: 0x00B707ED
		// (set) Token: 0x0603162B RID: 202283 RVA: 0x00B725F5 File Offset: 0x00B707F5
		public ETrapDefenseDifficultyLevel DifficultyLevel { get; set; }

		// Token: 0x17007A9B RID: 31387
		// (get) Token: 0x0603162C RID: 202284 RVA: 0x00B725FE File Offset: 0x00B707FE
		// (set) Token: 0x0603162D RID: 202285 RVA: 0x00B72606 File Offset: 0x00B70806
		public string NameKey { get; set; } = "";

		// Token: 0x17007A9C RID: 31388
		// (get) Token: 0x0603162E RID: 202286 RVA: 0x00B7260F File Offset: 0x00B7080F
		// (set) Token: 0x0603162F RID: 202287 RVA: 0x00B72617 File Offset: 0x00B70817
		public string NameBgKey { get; set; } = "";

		// Token: 0x17007A9D RID: 31389
		// (get) Token: 0x06031630 RID: 202288 RVA: 0x00B72620 File Offset: 0x00B70820
		// (set) Token: 0x06031631 RID: 202289 RVA: 0x00B72628 File Offset: 0x00B70828
		public string BgKey { get; set; } = "";

		// Token: 0x17007A9E RID: 31390
		// (get) Token: 0x06031632 RID: 202290 RVA: 0x00B72631 File Offset: 0x00B70831
		// (set) Token: 0x06031633 RID: 202291 RVA: 0x00B72639 File Offset: 0x00B70839
		public string BgLightKey { get; set; } = "";

		// Token: 0x17007A9F RID: 31391
		// (get) Token: 0x06031634 RID: 202292 RVA: 0x00B72642 File Offset: 0x00B70842
		// (set) Token: 0x06031635 RID: 202293 RVA: 0x00B7264A File Offset: 0x00B7084A
		public string BgTitleKey { get; set; } = "";

		// Token: 0x17007AA0 RID: 31392
		// (get) Token: 0x06031636 RID: 202294 RVA: 0x00B72653 File Offset: 0x00B70853
		// (set) Token: 0x06031637 RID: 202295 RVA: 0x00B7265B File Offset: 0x00B7085B
		public string BgFlowerColor { get; set; } = "";

		// Token: 0x17007AA1 RID: 31393
		// (get) Token: 0x06031638 RID: 202296 RVA: 0x00B72664 File Offset: 0x00B70864
		// (set) Token: 0x06031639 RID: 202297 RVA: 0x00B7266C File Offset: 0x00B7086C
		public string ArtTextShadowColor { get; set; } = "";
	}
}
