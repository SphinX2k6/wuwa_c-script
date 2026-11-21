using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F81 RID: 3969
public class MapAreaShowCountryItem : CommonTabItem
{
	// Token: 0x06009F2B RID: 40747 RVA: 0x002EFE4C File Offset: 0x002EE04C
	[NullableContext(1)]
	protected override void OnRefresh(CommonTabItemData data, bool isSelected, int gridIndex)
	{
		CommonTabData data2 = data.Data;
		base.UpdateTabIcon(((data2 != null) ? data2.GetIcon() : null) ?? "");
		CommonTabData data3 = data.Data;
		this.UpdateRedDot((data3 != null) ? data3.GetTitleData() : null);
	}

	// Token: 0x06009F2C RID: 40748 RVA: 0x002EFE88 File Offset: 0x002EE088
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
