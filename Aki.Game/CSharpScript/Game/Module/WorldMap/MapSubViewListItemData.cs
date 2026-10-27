using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020047A1 RID: 18337
	[NullableContext(2)]
	[Nullable(0)]
	public class MapSubViewListItemData : IMapSubViewListItemData
	{
		// Token: 0x1700780B RID: 30731
		// (get) Token: 0x0602FF3E RID: 196414 RVA: 0x00B19DEF File Offset: 0x00B17FEF
		// (set) Token: 0x0602FF3F RID: 196415 RVA: 0x00B19DF7 File Offset: 0x00B17FF7
		[Nullable(1)]
		public string LeftTextId { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x1700780C RID: 30732
		// (get) Token: 0x0602FF40 RID: 196416 RVA: 0x00B19E00 File Offset: 0x00B18000
		// (set) Token: 0x0602FF41 RID: 196417 RVA: 0x00B19E08 File Offset: 0x00B18008
		public string LeftText { get; set; }

		// Token: 0x1700780D RID: 30733
		// (get) Token: 0x0602FF42 RID: 196418 RVA: 0x00B19E11 File Offset: 0x00B18011
		// (set) Token: 0x0602FF43 RID: 196419 RVA: 0x00B19E19 File Offset: 0x00B18019
		public string RightTextId { get; set; }

		// Token: 0x1700780E RID: 30734
		// (get) Token: 0x0602FF44 RID: 196420 RVA: 0x00B19E22 File Offset: 0x00B18022
		// (set) Token: 0x0602FF45 RID: 196421 RVA: 0x00B19E2A File Offset: 0x00B1802A
		public string RightText { get; set; }

		// Token: 0x1700780F RID: 30735
		// (get) Token: 0x0602FF46 RID: 196422 RVA: 0x00B19E33 File Offset: 0x00B18033
		// (set) Token: 0x0602FF47 RID: 196423 RVA: 0x00B19E3B File Offset: 0x00B1803B
		public bool ShowBtnHelp { get; set; }

		// Token: 0x17007810 RID: 30736
		// (get) Token: 0x0602FF48 RID: 196424 RVA: 0x00B19E44 File Offset: 0x00B18044
		// (set) Token: 0x0602FF49 RID: 196425 RVA: 0x00B19E4C File Offset: 0x00B1804C
		public Action OnBtnClickCb { get; set; }

		// Token: 0x17007811 RID: 30737
		// (get) Token: 0x0602FF4A RID: 196426 RVA: 0x00B19E55 File Offset: 0x00B18055
		// (set) Token: 0x0602FF4B RID: 196427 RVA: 0x00B19E5D File Offset: 0x00B1805D
		public bool ShowIcon { get; set; }

		// Token: 0x17007812 RID: 30738
		// (get) Token: 0x0602FF4C RID: 196428 RVA: 0x00B19E66 File Offset: 0x00B18066
		// (set) Token: 0x0602FF4D RID: 196429 RVA: 0x00B19E6E File Offset: 0x00B1806E
		public bool ShowSprite { get; set; }

		// Token: 0x17007813 RID: 30739
		// (get) Token: 0x0602FF4E RID: 196430 RVA: 0x00B19E77 File Offset: 0x00B18077
		// (set) Token: 0x0602FF4F RID: 196431 RVA: 0x00B19E7F File Offset: 0x00B1807F
		public bool ShowScaleIcon { get; set; }

		// Token: 0x17007814 RID: 30740
		// (get) Token: 0x0602FF50 RID: 196432 RVA: 0x00B19E88 File Offset: 0x00B18088
		// (set) Token: 0x0602FF51 RID: 196433 RVA: 0x00B19E90 File Offset: 0x00B18090
		public string ScaleIconPath { get; set; }
	}
}
