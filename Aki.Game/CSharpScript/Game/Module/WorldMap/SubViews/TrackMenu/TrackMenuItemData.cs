using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.Marks.MarkItem;

namespace CSharpScript.Game.Module.WorldMap.SubViews.TrackMenu
{
	// Token: 0x020047E7 RID: 18407
	[NullableContext(1)]
	[Nullable(0)]
	public class TrackMenuItemData : ITrackMenuItemData
	{
		// Token: 0x170078C6 RID: 30918
		// (get) Token: 0x06030367 RID: 197479 RVA: 0x00B2CA83 File Offset: 0x00B2AC83
		// (set) Token: 0x06030368 RID: 197480 RVA: 0x00B2CA8B File Offset: 0x00B2AC8B
		public string Icon { get; set; }

		// Token: 0x170078C7 RID: 30919
		// (get) Token: 0x06030369 RID: 197481 RVA: 0x00B2CA94 File Offset: 0x00B2AC94
		// (set) Token: 0x0603036A RID: 197482 RVA: 0x00B2CA9C File Offset: 0x00B2AC9C
		public string Title { get; set; }

		// Token: 0x170078C8 RID: 30920
		// (get) Token: 0x0603036B RID: 197483 RVA: 0x00B2CAA5 File Offset: 0x00B2ACA5
		// (set) Token: 0x0603036C RID: 197484 RVA: 0x00B2CAAD File Offset: 0x00B2ACAD
		public string StateIcon { get; set; }

		// Token: 0x170078C9 RID: 30921
		// (get) Token: 0x0603036D RID: 197485 RVA: 0x00B2CAB6 File Offset: 0x00B2ACB6
		// (set) Token: 0x0603036E RID: 197486 RVA: 0x00B2CABE File Offset: 0x00B2ACBE
		public bool IsPlayerSelf { get; set; }

		// Token: 0x170078CA RID: 30922
		// (get) Token: 0x0603036F RID: 197487 RVA: 0x00B2CAC7 File Offset: 0x00B2ACC7
		// (set) Token: 0x06030370 RID: 197488 RVA: 0x00B2CACF File Offset: 0x00B2ACCF
		public MarkItem MarkItem { get; set; }
	}
}
