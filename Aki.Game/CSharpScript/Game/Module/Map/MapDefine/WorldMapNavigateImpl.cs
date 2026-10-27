using System;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x0200556B RID: 21867
	public class WorldMapNavigateImpl : IWorldMapNavigate
	{
		// Token: 0x1700860D RID: 34317
		// (get) Token: 0x06037C10 RID: 228368 RVA: 0x00D38EF7 File Offset: 0x00D370F7
		// (set) Token: 0x06037C11 RID: 228369 RVA: 0x00D38EFF File Offset: 0x00D370FF
		public int AreaId { get; set; }

		// Token: 0x1700860E RID: 34318
		// (get) Token: 0x06037C12 RID: 228370 RVA: 0x00D38F08 File Offset: 0x00D37108
		// (set) Token: 0x06037C13 RID: 228371 RVA: 0x00D38F10 File Offset: 0x00D37110
		public int? StateId { get; set; }

		// Token: 0x1700860F RID: 34319
		// (get) Token: 0x06037C14 RID: 228372 RVA: 0x00D38F19 File Offset: 0x00D37119
		// (set) Token: 0x06037C15 RID: 228373 RVA: 0x00D38F21 File Offset: 0x00D37121
		public int CountryId { get; set; }

		// Token: 0x17008610 RID: 34320
		// (get) Token: 0x06037C16 RID: 228374 RVA: 0x00D38F2A File Offset: 0x00D3712A
		// (set) Token: 0x06037C17 RID: 228375 RVA: 0x00D38F32 File Offset: 0x00D37132
		public int MarkId { get; set; }

		// Token: 0x17008611 RID: 34321
		// (get) Token: 0x06037C18 RID: 228376 RVA: 0x00D38F3B File Offset: 0x00D3713B
		// (set) Token: 0x06037C19 RID: 228377 RVA: 0x00D38F43 File Offset: 0x00D37143
		public EMarkType MarkType { get; set; }

		// Token: 0x17008612 RID: 34322
		// (get) Token: 0x06037C1A RID: 228378 RVA: 0x00D38F4C File Offset: 0x00D3714C
		// (set) Token: 0x06037C1B RID: 228379 RVA: 0x00D38F54 File Offset: 0x00D37154
		public int SortIndex { get; set; }

		// Token: 0x17008613 RID: 34323
		// (get) Token: 0x06037C1C RID: 228380 RVA: 0x00D38F5D File Offset: 0x00D3715D
		// (set) Token: 0x06037C1D RID: 228381 RVA: 0x00D38F65 File Offset: 0x00D37165
		public int MapConfigId { get; set; }
	}
}
