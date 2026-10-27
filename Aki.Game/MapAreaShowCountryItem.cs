using System;
using System.Runtime.CompilerServices;

// Token: 0x02001AC2 RID: 6850
public class MapAreaShowCountryItem : CommonTabItem
{
	// Token: 0x0600CB1A RID: 51994 RVA: 0x002E4CC8 File Offset: 0x002E2EC8
	[NullableContext(1)]
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		CommonTabData data2 = data.Data;
		base.UpdateTabIcon(((data2 != null) ? data2.GetIcon() : null) ?? "");
		CommonTabData data3 = data.Data;
		this.UpdateRedDot((data3 != null) ? data3.GetTitleData() : null);
	}

	// Token: 0x0600CB1B RID: 51995 RVA: 0x002E4D04 File Offset: 0x002E2F04
	[NullableContext(2)]
	private void UpdateRedDot(CommonTabTitleData titleData = null)
	{
		object obj;
		if (titleData == null)
		{
			obj = null;
		}
		else
		{
			object[] args = titleData.Args;
			obj = ((args != null) ? args[0] : null);
		}
		ExploreCountryData exploreCountryData = obj as ExploreCountryData;
		bool redDotState = exploreCountryData != null && exploreCountryData.HasCanTakeStageReward();
		base.SetRedDotState(redDotState);
	}
}
