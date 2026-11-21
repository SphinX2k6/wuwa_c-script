using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F32 RID: 7986
[NullableContext(2)]
[Nullable(0)]
public class ShipTowerMonsterDescView : UiViewBase
{
	// Token: 0x06013C4D RID: 80973 RVA: 0x005C493F File Offset: 0x005C2B3F
	[NullableContext(1)]
	public ShipTowerMonsterDescView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013C4E RID: 80974 RVA: 0x005C4948 File Offset: 0x005C2B48
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

	// Token: 0x06013C4F RID: 80975 RVA: 0x005C49B8 File Offset: 0x005C2BB8
	private void InitDataParam()
	{
	}

	// Token: 0x06013C50 RID: 80976 RVA: 0x005C49BC File Offset: 0x005C2BBC
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerMonsterDescView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerMonsterDescView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013C51 RID: 80977 RVA: 0x005C4A00 File Offset: 0x005C2C00
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

	// Token: 0x06013C52 RID: 80978 RVA: 0x005C4B28 File Offset: 0x005C2D28
	protected override void OnBeforeShow()
	{
		this.TeamTabFinish();
	}

	// Token: 0x06013C53 RID: 80979 RVA: 0x005C4B30 File Offset: 0x005C2D30
	[NullableContext(1)]
	private ShipTowerTeamTabItem TabItemProxyCreate([Nullable(2)] UUIItem uiItem, int? index)
	{
		return new ShipTowerTeamTabItem();
	}

	// Token: 0x06013C54 RID: 80980 RVA: 0x005C4B38 File Offset: 0x005C2D38
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

	// Token: 0x06013C55 RID: 80981 RVA: 0x005C4BA4 File Offset: 0x005C2DA4
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

	// Token: 0x0400A8DE RID: 43230
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private TabComponent<ShipTowerTeamTabItem> TabComponent;

	// Token: 0x0400A8DF RID: 43231
	private int CurSelectTabIndex;

	// Token: 0x0400A8E0 RID: 43232
	private ShipTowerMonsterWordItem InfoAttrPanel;

	// Token: 0x0400A8E1 RID: 43233
	private ShipTowerMonsterWordItem InfoWordPanel;

	// Token: 0x0400A8E2 RID: 43234
	private ShipTowerMonsterListItem MonsterListPanel;

	// Token: 0x0400A8E3 RID: 43235
	private UUIItem ItemAttr;

	// Token: 0x0400A8E4 RID: 43236
	private UUIItem ItemMonster;

	// Token: 0x02008212 RID: 33298
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A020 RID: 172064
		public const int ItemRoot = 0;

		// Token: 0x0402A021 RID: 172065
		public const int ItemAttr = 1;

		// Token: 0x0402A022 RID: 172066
		public const int ItemMonster = 2;

		// Token: 0x0402A023 RID: 172067
		public const int ItemTabComponent = 3;
	}
}
