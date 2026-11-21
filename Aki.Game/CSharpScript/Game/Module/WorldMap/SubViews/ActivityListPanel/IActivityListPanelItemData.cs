using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.ActivityListPanel
{
	// Token: 0x02003777 RID: 14199
	[NullableContext(1)]
	public interface IActivityListPanelItemData
	{
		// Token: 0x17004BC6 RID: 19398
		// (get) Token: 0x06024E6C RID: 151148
		// (set) Token: 0x06024E6D RID: 151149
		IActivityListItemData Data { get; set; }

		// Token: 0x17004BC7 RID: 19399
		// (get) Token: 0x06024E6E RID: 151150
		// (set) Token: 0x06024E6F RID: 151151
		Action OnClickCb { get; set; }
	}
}
