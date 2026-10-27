using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.MapMarkToggle
{
	// Token: 0x02004808 RID: 18440
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMarkProgressItemData : IMapMarkProgressItemData
	{
		// Token: 0x170078DB RID: 30939
		// (get) Token: 0x0603048B RID: 197771 RVA: 0x00B32E7F File Offset: 0x00B3107F
		// (set) Token: 0x0603048C RID: 197772 RVA: 0x00B32E87 File Offset: 0x00B31087
		public string NameId { get; set; } = "";

		// Token: 0x170078DC RID: 30940
		// (get) Token: 0x0603048D RID: 197773 RVA: 0x00B32E90 File Offset: 0x00B31090
		// (set) Token: 0x0603048E RID: 197774 RVA: 0x00B32E98 File Offset: 0x00B31098
		public float Progress { get; set; }

		// Token: 0x170078DD RID: 30941
		// (get) Token: 0x0603048F RID: 197775 RVA: 0x00B32EA1 File Offset: 0x00B310A1
		// (set) Token: 0x06030490 RID: 197776 RVA: 0x00B32EA9 File Offset: 0x00B310A9
		public float ProgressMax { get; set; }

		// Token: 0x170078DE RID: 30942
		// (get) Token: 0x06030491 RID: 197777 RVA: 0x00B32EB2 File Offset: 0x00B310B2
		// (set) Token: 0x06030492 RID: 197778 RVA: 0x00B32EBA File Offset: 0x00B310BA
		public float ProgressMin { get; set; }

		// Token: 0x170078DF RID: 30943
		// (get) Token: 0x06030493 RID: 197779 RVA: 0x00B32EC3 File Offset: 0x00B310C3
		// (set) Token: 0x06030494 RID: 197780 RVA: 0x00B32ECB File Offset: 0x00B310CB
		[Nullable(2)]
		public Action<float> SetProgressCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
