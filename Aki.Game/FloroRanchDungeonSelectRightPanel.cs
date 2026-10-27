using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B60 RID: 7008
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDungeonSelectRightPanel : UiPanelBase
{
	// Token: 0x0600CFF4 RID: 53236 RVA: 0x002F64AC File Offset: 0x002F46AC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 12;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600CFF5 RID: 53237 RVA: 0x002F6664 File Offset: 0x002F4864
	protected override void OnStart()
	{
		this.DifficultyLayout = new GenericLayout<FloroRanchDifficultyItem, FloroRanchSubDungeonData>(base.GetHorizontalLayout(1), new Func<FloroRanchDifficultyItem>(this.CreateDifficultyItem), null, false, true);
		this.RaceLayout = new GenericLayout<FloroRanchRaceItem, FloroRanchSelectRaceData>(base.GetHorizontalLayout(9), this.CreateRaceItem, null, false, true);
		ITermExplanationRegistryParam param = new TermExplanationRegistryParam
		{
			UiText = base.GetText(5),
			ViewType = ETermExplanationViewType.Side,
			AttachDirection = new ETermExplanationViewAttachDirection?(ETermExplanationViewAttachDirection.Left),
			AttachItem = base.GetRootItem(),
			Style = new ETermExplanationViewStyle?(ETermExplanationViewStyle.FloroRanch),
			ReportType = ETermExplanationReportType.FloroRanch
		};
		TermExplanationController.Instance.RegisterTextHyperlinkByParam(param);
	}

	// Token: 0x0600CFF6 RID: 53238 RVA: 0x002F6700 File Offset: 0x002F4900
	public void RefreshDungeonInfo(FloroRanchDungeonData dungeonData, FloroRanchSubDungeonData subDungeonData = null)
	{
		this.DungeonData = dungeonData;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(0), dungeonData.GetDungeonName(), Array.Empty<object>());
		UUIItem item = base.GetItem(6);
		if (item != null)
		{
			item.SetUIActive(!dungeonData.IsUnLock);
		}
		UUIItem item2 = base.GetItem(10);
		if (item2 != null)
		{
			item2.SetUIActive(dungeonData.IsUnLock);
		}
		if (dungeonData.IsUnLock)
		{
			List<FloroRanchSubDungeonData> dataList = dungeonData.GetSubDungeonData();
			this.DifficultyLayout.DeselectCurrentGridProxy();
			this.DifficultyLayout.RefreshByData(dataList, delegate
			{
				FloroRanchSubDungeonData subDungeonData2 = subDungeonData ?? dataList[0];
				this.RefreshSubDungeonInfo(subDungeonData2);
			}, false);
			return;
		}
		string conditionGroupHintText = LevelGeneralCommons.GetConditionGroupHintText(this.DungeonData.ConditionId);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), conditionGroupHintText, Array.Empty<object>());
	}

	// Token: 0x0600CFF7 RID: 53239 RVA: 0x002F67E0 File Offset: 0x002F49E0
	private void RefreshSubDungeonInfo(FloroRanchSubDungeonData subDungeonData)
	{
		this.SubDungeonData = subDungeonData;
		Action<int> onSelectDifficultyCallBack = this.OnSelectDifficultyCallBack;
		if (onSelectDifficultyCallBack != null)
		{
			onSelectDifficultyCallBack(subDungeonData.Id);
		}
		this.DifficultyLayout.SelectGridProxyByKey(subDungeonData.Id, false);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "Farm_DungeonTarget", new <>z__ReadOnlyArray<object>(new object[]
		{
			subDungeonData.GetMaxStage(),
			subDungeonData.GetStageDay()
		}));
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetText(subDungeonData.FirstReward.ToString(), true);
		}
		UUIText text2 = base.GetText(4);
		if (text2 != null)
		{
			text2.SetText(subDungeonData.AgainReward.ToString(), true);
		}
		UUIItem item = base.GetItem(11);
		if (item != null)
		{
			item.SetUIActive(subDungeonData.AgainReward != 0);
		}
		FloroRanchTag? floroRanchTagConfig = FloroRanchConfig.Instance.GetFloroRanchTagConfig(subDungeonData.TagId);
		if (floroRanchTagConfig != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), floroRanchTagConfig.Value.Name, Array.Empty<object>());
		}
		this.RefreshRaceList(this.SubDungeonData.SelectedRaceIds);
	}

	// Token: 0x0600CFF8 RID: 53240 RVA: 0x002F6910 File Offset: 0x002F4B10
	public void RefreshRaceList(IReadOnlyList<int> raceIdList)
	{
		List<FloroRanchSelectRaceData> list = new List<FloroRanchSelectRaceData>();
		foreach (int raceId in raceIdList)
		{
			list.Add(new FloroRanchSelectRaceData(raceId, this.SubDungeonData, EFloroRanchActivityDataType.Normal));
		}
		this.RaceLayout.RefreshByData(list, null, false);
	}

	// Token: 0x0600CFF9 RID: 53241 RVA: 0x002F6978 File Offset: 0x002F4B78
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(5));
	}

	// Token: 0x0600CFFA RID: 53242 RVA: 0x002F698B File Offset: 0x002F4B8B
	private FloroRanchDifficultyItem CreateDifficultyItem()
	{
		FloroRanchDifficultyItem floroRanchDifficultyItem = new FloroRanchDifficultyItem();
		floroRanchDifficultyItem.SetToggleCallBack(new Action<FloroRanchSubDungeonData>(this.RefreshSubDungeonInfo));
		return floroRanchDifficultyItem;
	}

	// Token: 0x04005F8B RID: 24459
	private FloroRanchDungeonData DungeonData;

	// Token: 0x04005F8C RID: 24460
	private FloroRanchSubDungeonData SubDungeonData;

	// Token: 0x04005F8D RID: 24461
	private GenericLayout<FloroRanchDifficultyItem, FloroRanchSubDungeonData> DifficultyLayout;

	// Token: 0x04005F8E RID: 24462
	private GenericLayout<FloroRanchRaceItem, FloroRanchSelectRaceData> RaceLayout;

	// Token: 0x04005F8F RID: 24463
	public Action<int> OnSelectDifficultyCallBack;

	// Token: 0x04005F90 RID: 24464
	private readonly Func<FloroRanchRaceItem> CreateRaceItem = () => new FloroRanchRaceItem();

	// Token: 0x020080B6 RID: 32950
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04029FAA RID: 171946
		public const int TextTitle = 0;

		// Token: 0x04029FAB RID: 171947
		public const int LayoutDifficulty = 1;

		// Token: 0x04029FAC RID: 171948
		public const int TextTarget = 2;

		// Token: 0x04029FAD RID: 171949
		public const int TextFirstReward = 3;

		// Token: 0x04029FAE RID: 171950
		public const int TextAgainReward = 4;

		// Token: 0x04029FAF RID: 171951
		public const int TextEnvironment = 5;

		// Token: 0x04029FB0 RID: 171952
		public const int ItemLockPanel = 6;

		// Token: 0x04029FB1 RID: 171953
		public const int TextLock = 7;

		// Token: 0x04029FB2 RID: 171954
		public const int ItemRacePanel = 8;

		// Token: 0x04029FB3 RID: 171955
		public const int LayoutRace = 9;

		// Token: 0x04029FB4 RID: 171956
		public const int ItemUnlockPanel = 10;

		// Token: 0x04029FB5 RID: 171957
		public const int ItemAgainRewardPanel = 11;
	}
}
