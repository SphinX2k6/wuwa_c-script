using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.ActivityListPanel
{
	// Token: 0x02003778 RID: 14200
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityListPanelItemData : IActivityListPanelItemData
	{
		// Token: 0x17004BC8 RID: 19400
		// (get) Token: 0x06024E70 RID: 151152 RVA: 0x00A6CFA3 File Offset: 0x00A6B1A3
		// (set) Token: 0x06024E71 RID: 151153 RVA: 0x00A6CFAB File Offset: 0x00A6B1AB
		public IActivityListItemData Data { get; set; }

		// Token: 0x17004BC9 RID: 19401
		// (get) Token: 0x06024E72 RID: 151154 RVA: 0x00A6CFB4 File Offset: 0x00A6B1B4
		// (set) Token: 0x06024E73 RID: 151155 RVA: 0x00A6CFBC File Offset: 0x00A6B1BC
		public Action OnClickCb { get; set; }
	}
}
