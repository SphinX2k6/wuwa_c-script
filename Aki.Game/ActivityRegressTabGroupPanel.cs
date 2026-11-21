using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02000946 RID: 2374
[NullableContext(1)]
[Nullable(0)]
public class ActivityRegressTabGroupPanel
{
	// Token: 0x060068C4 RID: 26820 RVA: 0x0020BDD0 File Offset: 0x00209FD0
	public ActivityRegressTabGroupPanel(UUIHorizontalLayout tabLayout, UUIItem tabItem, Action<int> tabCallBack)
	{
		this.TabLayout = tabLayout;
		this.TabItem = tabItem;
		this.TabCallBack = tabCallBack;
	}

	// Token: 0x060068C5 RID: 26821 RVA: 0x0020BDED File Offset: 0x00209FED
	public void Init()
	{
		this.TabGroup = new TabComponent<ActivityRegressTabSwitchItemPanel>(this.TabLayout.GetRootComponent(), new Func<UUIItem, int?, ActivityRegressTabSwitchItemPanel>(this.TabItemProxyCreate), new Action<int>(this.ToggleCallBack), this.TabItem);
	}

	// Token: 0x060068C6 RID: 26822 RVA: 0x0020BE23 File Offset: 0x0020A023
	private ActivityRegressTabSwitchItemPanel TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new ActivityRegressTabSwitchItemPanel();
	}

	// Token: 0x060068C7 RID: 26823 RVA: 0x0020BE2A File Offset: 0x0020A02A
	private void ToggleCallBack(int gridIndex)
	{
		Action<int> tabCallBack = this.TabCallBack;
		if (tabCallBack == null)
		{
			return;
		}
		tabCallBack(gridIndex);
	}

	// Token: 0x060068C8 RID: 26824 RVA: 0x0020BE3D File Offset: 0x0020A03D
	public void RefreshByData(List<ActivityRegressTabSwitchItemCommonData> tabCommonDataList, int subTabIndex)
	{
		this.TabCommonDataList = tabCommonDataList;
		if (tabCommonDataList.Count > 0)
		{
			this.UpdateTabs(subTabIndex);
		}
	}

	// Token: 0x060068C9 RID: 26825 RVA: 0x0020BE58 File Offset: 0x0020A058
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

	// Token: 0x060068CA RID: 26826 RVA: 0x0020BE9D File Offset: 0x0020A09D
	public void Destroy()
	{
		this.TabGroup.Destroy(null);
	}

	// Token: 0x04004297 RID: 17047
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<ActivityRegressTabSwitchItemPanel> TabGroup;

	// Token: 0x04004298 RID: 17048
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<ActivityRegressTabSwitchItemCommonData> TabCommonDataList;

	// Token: 0x04004299 RID: 17049
	public UUIHorizontalLayout TabLayout;

	// Token: 0x0400429A RID: 17050
	public UUIItem TabItem;

	// Token: 0x0400429B RID: 17051
	[Nullable(2)]
	public readonly Action<int> TabCallBack;
}
