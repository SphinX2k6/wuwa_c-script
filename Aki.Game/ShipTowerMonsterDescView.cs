using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029B7 RID: 10679
[NullableContext(2)]
[Nullable(0)]
public class ShipTowerMonsterDescView : UiViewBase
{
	// Token: 0x06016247 RID: 90695 RVA: 0x005999B3 File Offset: 0x00597BB3
	[NullableContext(1)]
	public ShipTowerMonsterDescView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06016248 RID: 90696 RVA: 0x005999BC File Offset: 0x00597BBC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06016249 RID: 90697 RVA: 0x00599A2C File Offset: 0x00597C2C
	private void InitDataParam()
	{
	}

	// Token: 0x0601624A RID: 90698 RVA: 0x00599A30 File Offset: 0x00597C30
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerMonsterDescView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerMonsterDescView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601624B RID: 90699 RVA: 0x00599A74 File Offset: 0x00597C74
	private void TeamTabFinish()
	{
		if (this.TabComponent == null)
		{
			return;
		}
		Dictionary<int, ShipTowerTeamTabItem> tabItemMap = this.TabComponent.GetTabItemMap();
		ShipTowerMonsterDescViewParams shipTowerMonsterDescViewParams = this.OpenParam as ShipTowerMonsterDescViewParams;
		List<ShipTowerTeamData> list;
		if (shipTowerMonsterDescViewParams == null)
		{
			list = null;
		}
		else
		{
			ShipTowerStageData stageData = shipTowerMonsterDescViewParams.StageData;
			list = ((stageData != null) ? stageData.TeamDataList : null);
		}
		List<ShipTowerTeamData> list2 = list ?? new List<ShipTowerTeamData>();
		foreach (KeyValuePair<int, ShipTowerTeamTabItem> keyValuePair in tabItemMap)
		{
			int key = keyValuePair.Key;
			ShipTowerTeamTabItem value = keyValuePair.Value;
			if (key < list2.Count)
			{
				value.UpdateName(list2[key].AreaName);
			}
		}
		int num = -1;
		int? num2 = (shipTowerMonsterDescViewParams != null) ? shipTowerMonsterDescViewParams.InstId : null;
		for (int i = 0; i < list2.Count; i++)
		{
			int instId = list2[i].InstId;
			int? num3 = num2;
			if (instId == num3.GetValueOrDefault() & num3 != null)
			{
				num = i;
				break;
			}
		}
		int index = (num >= 0) ? num : 0;
		this.TabComponent.SelectToggleByIndex(index, true, true);
	}

	// Token: 0x0601624C RID: 90700 RVA: 0x00599B9C File Offset: 0x00597D9C
	protected override void OnBeforeShow()
	{
		this.TeamTabFinish();
	}

	// Token: 0x0601624D RID: 90701 RVA: 0x00599BA4 File Offset: 0x00597DA4
	[NullableContext(1)]
	private ShipTowerTeamTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new ShipTowerTeamTabItem();
	}

	// Token: 0x0601624E RID: 90702 RVA: 0x00599BAC File Offset: 0x00597DAC
	private void ToggleTwoTabCallBack(int index)
	{
		this.CurSelectTabIndex = index;
		ShipTowerMonsterDescViewParams shipTowerMonsterDescViewParams = this.OpenParam as ShipTowerMonsterDescViewParams;
		List<ShipTowerTeamData> list;
		if (shipTowerMonsterDescViewParams == null)
		{
			list = null;
		}
		else
		{
			ShipTowerStageData stageData = shipTowerMonsterDescViewParams.StageData;
			list = ((stageData != null) ? stageData.TeamDataList : null);
		}
		List<ShipTowerTeamData> list2 = list;
		ShipTowerTeamData shipTowerTeamData = null;
		if (list2 != null && this.CurSelectTabIndex >= 0 && this.CurSelectTabIndex < list2.Count)
		{
			shipTowerTeamData = list2[this.CurSelectTabIndex];
		}
		if (shipTowerTeamData != null)
		{
			this.UpdateTeamInfo(shipTowerTeamData);
		}
	}

	// Token: 0x0601624F RID: 90703 RVA: 0x00599C18 File Offset: 0x00597E18
	[NullableContext(1)]
	private void UpdateTeamInfo(ShipTowerTeamData data)
	{
		ShipTowerMonsterWordItem infoAttrPanel = this.InfoAttrPanel;
		if (infoAttrPanel != null)
		{
			infoAttrPanel.UpdateData(data.GetInfoAttr());
		}
		ShipTowerMonsterWordItemData infoWord = data.GetInfoWord();
		if (infoWord != null)
		{
			ShipTowerMonsterWordItem infoWordPanel = this.InfoWordPanel;
			if (infoWordPanel != null)
			{
				infoWordPanel.UpdateData(infoWord);
			}
		}
		ShipTowerMonsterWordItem infoWordPanel2 = this.InfoWordPanel;
		if (infoWordPanel2 != null)
		{
			infoWordPanel2.SetActive(infoWord != null);
		}
		ShipTowerMonsterListItem monsterListPanel = this.MonsterListPanel;
		if (monsterListPanel == null)
		{
			return;
		}
		monsterListPanel.UpdateData(data.GetMonsterListItemData());
	}

	// Token: 0x0400A4F4 RID: 42228
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<ShipTowerTeamTabItem> TabComponent;

	// Token: 0x0400A4F5 RID: 42229
	private int CurSelectTabIndex;

	// Token: 0x0400A4F6 RID: 42230
	private ShipTowerMonsterWordItem InfoAttrPanel;

	// Token: 0x0400A4F7 RID: 42231
	private ShipTowerMonsterWordItem InfoWordPanel;

	// Token: 0x0400A4F8 RID: 42232
	private ShipTowerMonsterListItem MonsterListPanel;

	// Token: 0x0400A4F9 RID: 42233
	private UUIItem ItemAttr;

	// Token: 0x0400A4FA RID: 42234
	private UUIItem ItemMonster;

	// Token: 0x02008FCA RID: 36810
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E923 RID: 190755
		public const int ItemRoot = 0;

		// Token: 0x0402E924 RID: 190756
		public const int ItemAttr = 1;

		// Token: 0x0402E925 RID: 190757
		public const int ItemMonster = 2;

		// Token: 0x0402E926 RID: 190758
		public const int ItemTabComponent = 3;
	}
}
