using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x020010E2 RID: 4322
[NullableContext(1)]
[Nullable(0)]
public class AdvanceNoticeViewModel
{
	// Token: 0x17000983 RID: 2435
	// (get) Token: 0x0600708B RID: 28811 RVA: 0x0016F593 File Offset: 0x0016D793
	public int TabId
	{
		get
		{
			return this.TabList[this.TabIndex];
		}
	}

	// Token: 0x17000984 RID: 2436
	// (get) Token: 0x0600708C RID: 28812 RVA: 0x0016F5A6 File Offset: 0x0016D7A6
	public int CurrentSubTabId
	{
		get
		{
			return this.AdvanceNoticeThumbItemDataList[this.CurrentSubTabIndex].SubTabId;
		}
	}

	// Token: 0x0600708D RID: 28813 RVA: 0x0016F5C0 File Offset: 0x0016D7C0
	public void UpdateTabDataOnTabChange(int tabIndex)
	{
		this.TabIndex = tabIndex;
		int id = this.TabList[tabIndex];
		AdvertisingTabInfo advertisingTabInfoById = AdvanceNoticeConfig.Instance.GetAdvertisingTabInfoById(id);
		this.SubTabIdList.Clear();
		foreach (int item in advertisingTabInfoById.SubTabIdListIter())
		{
			this.SubTabIdList.Add(item);
		}
		this.CurrentSubTabIndex = 0;
		this.AdvanceNoticeThumbItemDataList.Clear();
		this.AdvanceNoticeThumbEnemyMap.Clear();
		this.CurrentTabView = AdvanceNoticeDefine.advanceNoticeTabTypeToTabViewName[(EAdvanceNoticeTabType)advertisingTabInfoById.Type];
		foreach (int subTabId in advertisingTabInfoById.SubTabIdListIter())
		{
			AdvanceNoticeThumbItemData item2 = this.BuildAdvanceNoticeThumbItemData((EAdvanceNoticeTabType)advertisingTabInfoById.Type, subTabId);
			this.AdvanceNoticeThumbItemDataList.Add(item2);
		}
		this.SetEnemyShowLineData();
	}

	// Token: 0x0600708E RID: 28814 RVA: 0x0016F6D0 File Offset: 0x0016D8D0
	private AdvanceNoticeThumbItemData BuildAdvanceNoticeThumbItemData(EAdvanceNoticeTabType tabType, int subTabId)
	{
		AdvanceNoticeThumbItemData advanceNoticeThumbItemData = new AdvanceNoticeThumbItemData();
		switch (tabType)
		{
		case EAdvanceNoticeTabType.NewRole:
		{
			AdvertisingTabCharacter advertisingTabCharacterById = AdvanceNoticeConfig.Instance.GetAdvertisingTabCharacterById(subTabId);
			advanceNoticeThumbItemData.BgTexturePath = advertisingTabCharacterById.ThumbnailPic;
			advanceNoticeThumbItemData.NameTextId = advertisingTabCharacterById.ThumbnailText;
			break;
		}
		case EAdvanceNoticeTabType.NewJourney:
		{
			AdvertisingTabStory advertisingTabStoryById = AdvanceNoticeConfig.Instance.GetAdvertisingTabStoryById(subTabId);
			advanceNoticeThumbItemData.BgTexturePath = advertisingTabStoryById.ThumbnailPic;
			advanceNoticeThumbItemData.NameTextId = advertisingTabStoryById.ThumbnailText;
			break;
		}
		case EAdvanceNoticeTabType.NewArea:
		{
			AdvertisingTabRegion advertisingTabRegionById = AdvanceNoticeConfig.Instance.GetAdvertisingTabRegionById(subTabId);
			advanceNoticeThumbItemData.BgTexturePath = advertisingTabRegionById.ThumbnailPic;
			advanceNoticeThumbItemData.NameTextId = advertisingTabRegionById.ThumbnailText;
			break;
		}
		case EAdvanceNoticeTabType.NewSkin:
		{
			AdvertisingTabCostume advertisingTabCostumeById = AdvanceNoticeConfig.Instance.GetAdvertisingTabCostumeById(subTabId);
			advanceNoticeThumbItemData.BgTexturePath = advertisingTabCostumeById.ThumbnailPic;
			advanceNoticeThumbItemData.NameTextId = advertisingTabCostumeById.ThumbnailText;
			break;
		}
		case EAdvanceNoticeTabType.NewEnemy:
		{
			AdvertisingTabEnemy advertisingTabEnemyById = AdvanceNoticeConfig.Instance.GetAdvertisingTabEnemyById(subTabId);
			advanceNoticeThumbItemData.BgTexturePath = advertisingTabEnemyById.ThumbnailPic;
			advanceNoticeThumbItemData.NameTextId = advertisingTabEnemyById.ThumbnailText;
			this.AdvanceNoticeThumbEnemyMap[advertisingTabEnemyById.Type] = advanceNoticeThumbItemData;
			break;
		}
		case EAdvanceNoticeTabType.NewActivity:
		{
			AdvertisingTabActivity advertisingTabActivityById = AdvanceNoticeConfig.Instance.GetAdvertisingTabActivityById(subTabId);
			advanceNoticeThumbItemData.BgTexturePath = advertisingTabActivityById.ThumbnailPic;
			advanceNoticeThumbItemData.NameTextId = advertisingTabActivityById.ThumbnailText;
			break;
		}
		case EAdvanceNoticeTabType.NewSystemOptimize:
		{
			AdvertisingTabSystem advertisingTabSystemById = AdvanceNoticeConfig.Instance.GetAdvertisingTabSystemById(subTabId);
			advanceNoticeThumbItemData.BgTexturePath = advertisingTabSystemById.ThumbnailPic;
			advanceNoticeThumbItemData.NameTextId = advertisingTabSystemById.ThumbnailText;
			break;
		}
		}
		advanceNoticeThumbItemData.TabId = this.TabId;
		advanceNoticeThumbItemData.SubTabId = subTabId;
		return advanceNoticeThumbItemData;
	}

	// Token: 0x0600708F RID: 28815 RVA: 0x0016F85C File Offset: 0x0016DA5C
	private void SetEnemyShowLineData()
	{
		int num = 0;
		int count = this.AdvanceNoticeThumbEnemyMap.Count;
		foreach (KeyValuePair<int, AdvanceNoticeThumbItemData> keyValuePair in this.AdvanceNoticeThumbEnemyMap)
		{
			num++;
			if (num == count)
			{
				break;
			}
			keyValuePair.Value.ShowLine = true;
		}
	}

	// Token: 0x06007090 RID: 28816 RVA: 0x0016F8D0 File Offset: 0x0016DAD0
	public void OnSwitchSubTab(int subTabIndex)
	{
		this.CurrentSubTabIndex = subTabIndex;
		Action<int> onSwitchSubTabDelegate = this.OnSwitchSubTabDelegate;
		if (onSwitchSubTabDelegate == null)
		{
			return;
		}
		onSwitchSubTabDelegate(subTabIndex);
	}

	// Token: 0x06007091 RID: 28817 RVA: 0x0016F8EC File Offset: 0x0016DAEC
	public void ClickTabLogEvent()
	{
		NextVersionContentLogEvent nextVersionContentLogEvent = new NextVersionContentLogEvent();
		nextVersionContentLogEvent.i_activity_id = this.ActivityId;
		nextVersionContentLogEvent.i_second_tab = this.TabId;
		nextVersionContentLogEvent.i_third_tab = this.CurrentSubTabId;
		LogReportController.Instance.LogReport(nextVersionContentLogEvent);
	}

	// Token: 0x04003432 RID: 13362
	public int DefaultSelectedTabId;

	// Token: 0x04003433 RID: 13363
	public int TabIndex;

	// Token: 0x04003434 RID: 13364
	public int CurrentSubTabIndex;

	// Token: 0x04003435 RID: 13365
	public List<int> TabList = new List<int>();

	// Token: 0x04003436 RID: 13366
	public List<int> SubTabIdList = new List<int>();

	// Token: 0x04003437 RID: 13367
	public EUiTabViewName CurrentTabView = EUiTabViewName.AdvanceNoticeNewRoleTabView;

	// Token: 0x04003438 RID: 13368
	public List<AdvanceNoticeThumbItemData> AdvanceNoticeThumbItemDataList = new List<AdvanceNoticeThumbItemData>();

	// Token: 0x04003439 RID: 13369
	private readonly Dictionary<int, AdvanceNoticeThumbItemData> AdvanceNoticeThumbEnemyMap = new Dictionary<int, AdvanceNoticeThumbItemData>();

	// Token: 0x0400343A RID: 13370
	public int ActivityId;

	// Token: 0x0400343B RID: 13371
	[Nullable(2)]
	public Action<int> OnSwitchSubTabDelegate;
}
