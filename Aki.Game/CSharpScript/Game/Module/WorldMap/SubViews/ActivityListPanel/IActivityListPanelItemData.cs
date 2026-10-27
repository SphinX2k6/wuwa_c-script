using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap.SubViews.ActivityListPanel
{
	// Token: 0x02004846 RID: 18502
	[NullableContext(1)]
	public interface IActivityListPanelItemData
	{
		// Token: 0x17007909 RID: 30985
		// (get) Token: 0x0603069C RID: 198300
		// (set) Token: 0x0603069D RID: 198301
		IActivityListItemData Data { get; set; }

		// Token: 0x1700790A RID: 30986
		// (get) Token: 0x0603069E RID: 198302
		// (set) Token: 0x0603069F RID: 198303
		Action OnClickCb { get; set; }
	}
}
