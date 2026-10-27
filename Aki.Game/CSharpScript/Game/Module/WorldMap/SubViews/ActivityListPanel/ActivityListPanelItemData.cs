using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.ActivityListPanel
{
	// Token: 0x02004847 RID: 18503
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityListPanelItemData : IActivityListPanelItemData
	{
		// Token: 0x1700790B RID: 30987
		// (get) Token: 0x060306A0 RID: 198304 RVA: 0x00B3CDBB File Offset: 0x00B3AFBB
		// (set) Token: 0x060306A1 RID: 198305 RVA: 0x00B3CDC3 File Offset: 0x00B3AFC3
		public IActivityListItemData Data { get; set; }

		// Token: 0x1700790C RID: 30988
		// (get) Token: 0x060306A2 RID: 198306 RVA: 0x00B3CDCC File Offset: 0x00B3AFCC
		// (set) Token: 0x060306A3 RID: 198307 RVA: 0x00B3CDD4 File Offset: 0x00B3AFD4
		public Action OnClickCb { get; set; }
	}
}
