using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x02000596 RID: 1430
[NullableContext(1)]
[Nullable(0)]
public class AdvanceNoticeViewModel
{
	// Token: 0x170009A3 RID: 2467
	// (get) Token: 0x06004421 RID: 17441 RVA: 0x00177F4F File Offset: 0x0017614F
	public int TabId
	{
		get
		{
			return this.TabList[this.TabIndex];
		}
	}

	// Token: 0x170009A4 RID: 2468
	// (get) Token: 0x06004422 RID: 17442 RVA: 0x00177F62 File Offset: 0x00176162
	public int CurrentSubTabId
	{
		get
		{
			return this.AdvanceNoticeThumbItemDataList[this.CurrentSubTabIndex].SubTabId;
		}
	}

	// Token: 0x06004423 RID: 17443 RVA: 0x00177F7C File Offset: 0x0017617C
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

	// Token: 0x06004424 RID: 17444 RVA: 0x0017808C File Offset: 0x0017628C
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

	// Token: 0x06004425 RID: 17445 RVA: 0x00178218 File Offset: 0x00176418
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

	// Token: 0x06004426 RID: 17446 RVA: 0x0017828C File Offset: 0x0017648C
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

	// Token: 0x06004427 RID: 17447 RVA: 0x001782A8 File Offset: 0x001764A8
	public void ClickTabLogEvent()
	{
		NextVersionContentLogEvent nextVersionContentLogEvent = new NextVersionContentLogEvent();
		nextVersionContentLogEvent.i_activity_id = this.ActivityId;
		nextVersionContentLogEvent.i_second_tab = this.TabId;
		nextVersionContentLogEvent.i_third_tab = this.CurrentSubTabId;
		LogReportController.Instance.LogReport(nextVersionContentLogEvent);
	}

	// Token: 0x040034CB RID: 13515
	public int DefaultSelectedTabId;

	// Token: 0x040034CC RID: 13516
	public int TabIndex;

	// Token: 0x040034CD RID: 13517
	public int CurrentSubTabIndex;

	// Token: 0x040034CE RID: 13518
	public List<int> TabList = new List<int>();

	// Token: 0x040034CF RID: 13519
	public List<int> SubTabIdList = new List<int>();

	// Token: 0x040034D0 RID: 13520
	public EUiTabViewName CurrentTabView = EUiTabViewName.AdvanceNoticeNewRoleTabView;

	// Token: 0x040034D1 RID: 13521
	public List<AdvanceNoticeThumbItemData> AdvanceNoticeThumbItemDataList = new List<AdvanceNoticeThumbItemData>();

	// Token: 0x040034D2 RID: 13522
	private readonly Dictionary<int, AdvanceNoticeThumbItemData> AdvanceNoticeThumbEnemyMap = new Dictionary<int, AdvanceNoticeThumbItemData>();

	// Token: 0x040034D3 RID: 13523
	public int ActivityId;

	// Token: 0x040034D4 RID: 13524
	[Nullable(2)]
	public Action<int> OnSwitchSubTabDelegate;
}
