using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200101F RID: 4127
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchDungeonSelectRightPanel : UiPanelBase
{
	// Token: 0x0600A405 RID: 41989 RVA: 0x00301584 File Offset: 0x002FF784
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

	// Token: 0x0600A406 RID: 41990 RVA: 0x0030173C File Offset: 0x002FF93C
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

	// Token: 0x0600A407 RID: 41991 RVA: 0x003017D8 File Offset: 0x002FF9D8
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

	// Token: 0x0600A408 RID: 41992 RVA: 0x003018B8 File Offset: 0x002FFAB8
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

	// Token: 0x0600A409 RID: 41993 RVA: 0x003019E8 File Offset: 0x002FFBE8
	public void RefreshRaceList(IReadOnlyList<int> raceIdList)
	{
		List<FloroRanchSelectRaceData> list = new List<FloroRanchSelectRaceData>();
		foreach (int raceId in raceIdList)
		{
			list.Add(new FloroRanchSelectRaceData(raceId, this.SubDungeonData, EFloroRanchActivityDataType.Normal));
		}
		this.RaceLayout.RefreshByData(list, null, false);
	}

	// Token: 0x0600A40A RID: 41994 RVA: 0x00301A50 File Offset: 0x002FFC50
	protected override void OnBeforeDestroy()
	{
		TermExplanationController.Instance.UnRegisterTextHyperlink(base.GetText(5));
	}

	// Token: 0x0600A40B RID: 41995 RVA: 0x00301A63 File Offset: 0x002FFC63
	private FloroRanchDifficultyItem CreateDifficultyItem()
	{
		FloroRanchDifficultyItem floroRanchDifficultyItem = new FloroRanchDifficultyItem();
		floroRanchDifficultyItem.SetToggleCallBack(new Action<FloroRanchSubDungeonData>(this.RefreshSubDungeonInfo));
		return floroRanchDifficultyItem;
	}

	// Token: 0x0400605A RID: 24666
	private FloroRanchDungeonData DungeonData;

	// Token: 0x0400605B RID: 24667
	private FloroRanchSubDungeonData SubDungeonData;

	// Token: 0x0400605C RID: 24668
	private GenericLayout<FloroRanchDifficultyItem, FloroRanchSubDungeonData> DifficultyLayout;

	// Token: 0x0400605D RID: 24669
	private GenericLayout<FloroRanchRaceItem, FloroRanchSelectRaceData> RaceLayout;

	// Token: 0x0400605E RID: 24670
	public Action<int> OnSelectDifficultyCallBack;

	// Token: 0x0400605F RID: 24671
	private readonly Func<FloroRanchRaceItem> CreateRaceItem = () => new FloroRanchRaceItem();

	// Token: 0x02007244 RID: 29252
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040252DE RID: 152286
		public const int TextTitle = 0;

		// Token: 0x040252DF RID: 152287
		public const int LayoutDifficulty = 1;

		// Token: 0x040252E0 RID: 152288
		public const int TextTarget = 2;

		// Token: 0x040252E1 RID: 152289
		public const int TextFirstReward = 3;

		// Token: 0x040252E2 RID: 152290
		public const int TextAgainReward = 4;

		// Token: 0x040252E3 RID: 152291
		public const int TextEnvironment = 5;

		// Token: 0x040252E4 RID: 152292
		public const int ItemLockPanel = 6;

		// Token: 0x040252E5 RID: 152293
		public const int TextLock = 7;

		// Token: 0x040252E6 RID: 152294
		public const int ItemRacePanel = 8;

		// Token: 0x040252E7 RID: 152295
		public const int LayoutRace = 9;

		// Token: 0x040252E8 RID: 152296
		public const int ItemUnlockPanel = 10;

		// Token: 0x040252E9 RID: 152297
		public const int ItemAgainRewardPanel = 11;
	}
}
