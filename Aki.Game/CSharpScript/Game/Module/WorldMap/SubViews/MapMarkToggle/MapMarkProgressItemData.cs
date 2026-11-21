using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.MapMarkToggle
{
	// Token: 0x02003739 RID: 14137
	[NullableContext(1)]
	[Nullable(0)]
	public class MapMarkProgressItemData : IMapMarkProgressItemData
	{
		// Token: 0x17004B98 RID: 19352
		// (get) Token: 0x06024C5B RID: 150619 RVA: 0x00A62DE3 File Offset: 0x00A60FE3
		// (set) Token: 0x06024C5C RID: 150620 RVA: 0x00A62DEB File Offset: 0x00A60FEB
		public string NameId { get; set; } = "";

		// Token: 0x17004B99 RID: 19353
		// (get) Token: 0x06024C5D RID: 150621 RVA: 0x00A62DF4 File Offset: 0x00A60FF4
		// (set) Token: 0x06024C5E RID: 150622 RVA: 0x00A62DFC File Offset: 0x00A60FFC
		public float Progress { get; set; }

		// Token: 0x17004B9A RID: 19354
		// (get) Token: 0x06024C5F RID: 150623 RVA: 0x00A62E05 File Offset: 0x00A61005
		// (set) Token: 0x06024C60 RID: 150624 RVA: 0x00A62E0D File Offset: 0x00A6100D
		public float ProgressMax { get; set; }

		// Token: 0x17004B9B RID: 19355
		// (get) Token: 0x06024C61 RID: 150625 RVA: 0x00A62E16 File Offset: 0x00A61016
		// (set) Token: 0x06024C62 RID: 150626 RVA: 0x00A62E1E File Offset: 0x00A6101E
		public float ProgressMin { get; set; }

		// Token: 0x17004B9C RID: 19356
		// (get) Token: 0x06024C63 RID: 150627 RVA: 0x00A62E27 File Offset: 0x00A61027
		// (set) Token: 0x06024C64 RID: 150628 RVA: 0x00A62E2F File Offset: 0x00A6102F
		[Nullable(2)]
		public Action<float> SetProgressCallback { [NullableContext(2)] get; [NullableContext(2)] set; }
	}
}
