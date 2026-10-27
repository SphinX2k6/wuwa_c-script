using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029A8 RID: 10664
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerDescLeftPanel : UiPanelBase
{
	// Token: 0x060161B1 RID: 90545 RVA: 0x00596DC0 File Offset: 0x00594FC0
	public UniTask Init(UUIItem item, ShipTowerStageData data)
	{
		ShipTowerDescLeftPanel.<Init>d__4 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.data = data;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<ShipTowerDescLeftPanel.<Init>d__4>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x060161B2 RID: 90546 RVA: 0x00596E14 File Offset: 0x00595014
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(7, typeof(UUIMultiTemplateLayout)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(9, new Action(this.OnBtnRewardDetailClick))
		};
	}

	// Token: 0x060161B3 RID: 90547 RVA: 0x00596F44 File Offset: 0x00595144
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerDescLeftPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerDescLeftPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060161B4 RID: 90548 RVA: 0x00596F87 File Offset: 0x00595187
	private CommonItemSmallItemGrid CreateRewardItemGrid()
	{
		return new CommonItemSmallItemGrid
		{
			ShowReceivedCallBack = ((TItem _) => this.StageData.IsPassed())
		};
	}

	// Token: 0x060161B5 RID: 90549 RVA: 0x00596FA0 File Offset: 0x005951A0
	protected override void OnBeforeShow()
	{
		this.UpdateData(this.StageData);
	}

	// Token: 0x060161B6 RID: 90550 RVA: 0x00596FAE File Offset: 0x005951AE
	public void UpdateViewAndShow(ShipTowerStageData data)
	{
		this.StageData = data;
		if (base.GetActive())
		{
			this.UpdateData(this.StageData);
			return;
		}
		this.SetActive(true);
	}

	// Token: 0x060161B7 RID: 90551 RVA: 0x00596FD4 File Offset: 0x005951D4
	private void UpdateData(ShipTowerStageData data)
	{
		this.StageData = data;
		this.UpdateIndex();
		base.GetText(3).ShowTextNew(this.StageData.TitleKey);
		string textStringId = "GhostShipPoint_Text";
		UUIText text = base.GetText(4);
		LguiUtil.Instance.SetLocalTextNew(text, textStringId, new <>z__ReadOnlySingleElementList<object>(this.StageData.CurrentScore.ToString()));
		base.GetText(5).ShowTextNew(this.StageData.DescKey);
		this.UpdateName();
		GenericLayout<ShipTowerScoreInfoItem, ShipTowerScoreInfoData> scoreInfoLayout = this.ScoreInfoLayout;
		if (scoreInfoLayout != null)
		{
			scoreInfoLayout.RefreshByData(this.StageData.GetTargetScoreInfoList(), null, false);
		}
		List<TItem> passUnlockBuffList = this.StageData.GetPassUnlockBuffList();
		UUIItem item = base.GetItem(10);
		if (item != null)
		{
			item.SetUIActive(passUnlockBuffList.Count > 0);
		}
		if (passUnlockBuffList.Count > 0)
		{
			GenericLayout<CommonItemSmallItemGrid, TItem> rewardLayout = this.RewardLayout;
			if (rewardLayout == null)
			{
				return;
			}
			rewardLayout.RefreshByData(passUnlockBuffList, null, false);
		}
	}

	// Token: 0x060161B8 RID: 90552 RVA: 0x005970B4 File Offset: 0x005952B4
	private void UpdateIndex()
	{
		bool isEndLess = this.StageData.IsEndLess;
		base.GetTexture(2).SetUIActive(isEndLess);
		base.GetTexture(0).SetUIActive(!isEndLess);
		if (!isEndLess)
		{
			base.GetText(1).SetText(this.StageData.OrderIndex.ToString(), true);
		}
	}

	// Token: 0x060161B9 RID: 90553 RVA: 0x0059710A File Offset: 0x0059530A
	private void UpdateName()
	{
	}

	// Token: 0x060161BA RID: 90554 RVA: 0x0059710C File Offset: 0x0059530C
	private void OnBtnRewardDetailClick()
	{
		ShipTowerStageData stageData = this.StageData;
		if (stageData == null)
		{
			return;
		}
		stageData.OpenViewPassBuffShow();
	}

	// Token: 0x0400A4C4 RID: 42180
	[Nullable(2)]
	private ShipTowerStageData StageData;

	// Token: 0x0400A4C5 RID: 42181
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerScoreInfoItem, ShipTowerScoreInfoData> ScoreInfoLayout;

	// Token: 0x0400A4C6 RID: 42182
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x02008FB6 RID: 36790
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E8AE RID: 190638
		public const int TextureIndexBg = 0;

		// Token: 0x0402E8AF RID: 190639
		public const int TxtIndex = 1;

		// Token: 0x0402E8B0 RID: 190640
		public const int TextureEndlessNode = 2;

		// Token: 0x0402E8B1 RID: 190641
		public const int TxtStageName = 3;

		// Token: 0x0402E8B2 RID: 190642
		public const int TxtScore = 4;

		// Token: 0x0402E8B3 RID: 190643
		public const int TxtDesc = 5;

		// Token: 0x0402E8B4 RID: 190644
		public const int VLayoutScoreTarget = 6;

		// Token: 0x0402E8B5 RID: 190645
		public const int MLayoutReward = 7;

		// Token: 0x0402E8B6 RID: 190646
		public const int ItemReward = 8;

		// Token: 0x0402E8B7 RID: 190647
		public const int BtnRewardDetail = 9;

		// Token: 0x0402E8B8 RID: 190648
		public const int RewardTipRoot = 10;
	}
}
