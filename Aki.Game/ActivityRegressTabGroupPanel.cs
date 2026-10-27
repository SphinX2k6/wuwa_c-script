using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001492 RID: 5266
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressTabGroupPanel
{
	// Token: 0x0600952F RID: 38191 RVA: 0x00202E68 File Offset: 0x00201068
	public ActivityRegressTabGroupPanel(UUIHorizontalLayout tabLayout, UUIItem tabItem, Action<int> tabCallBack)
	{
		this.TabLayout = tabLayout;
		this.TabItem = tabItem;
		this.TabCallBack = tabCallBack;
	}

	// Token: 0x06009530 RID: 38192 RVA: 0x00202E85 File Offset: 0x00201085
	public void Init()
	{
		this.TabGroup = new TabComponent<ActivityRegressTabSwitchItemPanel>(this.TabLayout.GetRootComponent(), new Func<UUIItem, int?, ActivityRegressTabSwitchItemPanel>(this.TabItemProxyCreate), new Action<int>(this.ToggleCallBack), this.TabItem);
	}

	// Token: 0x06009531 RID: 38193 RVA: 0x00202EBB File Offset: 0x002010BB
	private ActivityRegressTabSwitchItemPanel TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new ActivityRegressTabSwitchItemPanel();
	}

	// Token: 0x06009532 RID: 38194 RVA: 0x00202EC2 File Offset: 0x002010C2
	private void ToggleCallBack(int gridIndex)
	{
		Action<int> tabCallBack = this.TabCallBack;
		if (tabCallBack == null)
		{
			return;
		}
		tabCallBack(gridIndex);
	}

	// Token: 0x06009533 RID: 38195 RVA: 0x00202ED5 File Offset: 0x002010D5
	public void RefreshByData(List<ActivityRegressTabSwitchItemCommonData> tabCommonDataList, int subTabIndex)
	{
		this.TabCommonDataList = tabCommonDataList;
		if (tabCommonDataList.Count > 0)
		{
			this.UpdateTabs(subTabIndex);
		}
	}

	// Token: 0x06009534 RID: 38196 RVA: 0x00202EF0 File Offset: 0x002010F0
	private void UpdateTabs(int subTabIndex)
	{
		int count = this.TabCommonDataList.Count;
		int tabIndex = subTabIndex;
		this.TabGroup.RefreshTabItemByLength(count, delegate
		{
			foreach (KeyValuePair<int, ActivityRegressTabSwitchItemPanel> keyValuePair in this.TabGroup.GetTabItemMap())
			{
				int key = keyValuePair.Key;
				ActivityRegressTabSwitchItemPanel value = keyValuePair.Value;
				ActivityRegressTabSwitchItemCommonData tabData = this.TabCommonDataList[key];
				value.UpdateView(tabData);
			}
			this.TabGroup.SelectToggleByIndex(tabIndex, false, true);
		});
	}

	// Token: 0x06009535 RID: 38197 RVA: 0x00202F35 File Offset: 0x00201135
	public void Destroy()
	{
		this.TabGroup.Destroy(null);
	}

	// Token: 0x040041FF RID: 16895
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<ActivityRegressTabSwitchItemPanel> TabGroup;

	// Token: 0x04004200 RID: 16896
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ActivityRegressTabSwitchItemCommonData> TabCommonDataList;

	// Token: 0x04004201 RID: 16897
	public UUIHorizontalLayout TabLayout;

	// Token: 0x04004202 RID: 16898
	public UUIItem TabItem;

	// Token: 0x04004203 RID: 16899
	[Nullable(2)]
	public readonly Action<int> TabCallBack;
}
