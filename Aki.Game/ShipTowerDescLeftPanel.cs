using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F23 RID: 7971
[NullableContext(1)]
[Nullable(0)]
public class ShipTowerDescLeftPanel : UiPanelBase
{
	// Token: 0x06013BB7 RID: 80823 RVA: 0x005C1D80 File Offset: 0x005BFF80
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

	// Token: 0x06013BB8 RID: 80824 RVA: 0x005C1DD4 File Offset: 0x005BFFD4
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

	// Token: 0x06013BB9 RID: 80825 RVA: 0x005C1F04 File Offset: 0x005C0104
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerDescLeftPanel.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerDescLeftPanel.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013BBA RID: 80826 RVA: 0x005C1F47 File Offset: 0x005C0147
	private CommonItemSmallItemGrid CreateRewardItemGrid()
	{
		return new CommonItemSmallItemGrid
		{
			ShowReceivedCallBack = ((TItem _) => this.StageData.IsPassed())
		};
	}

	// Token: 0x06013BBB RID: 80827 RVA: 0x005C1F60 File Offset: 0x005C0160
	protected override void OnBeforeShow()
	{
		this.UpdateData(this.StageData);
	}

	// Token: 0x06013BBC RID: 80828 RVA: 0x005C1F6E File Offset: 0x005C016E
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

	// Token: 0x06013BBD RID: 80829 RVA: 0x005C1F94 File Offset: 0x005C0194
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

	// Token: 0x06013BBE RID: 80830 RVA: 0x005C2074 File Offset: 0x005C0274
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

	// Token: 0x06013BBF RID: 80831 RVA: 0x005C20CA File Offset: 0x005C02CA
	private void UpdateName()
	{
	}

	// Token: 0x06013BC0 RID: 80832 RVA: 0x005C20CC File Offset: 0x005C02CC
	private void OnBtnRewardDetailClick()
	{
		ShipTowerStageData stageData = this.StageData;
		if (stageData == null)
		{
			return;
		}
		stageData.OpenViewPassBuffShow();
	}

	// Token: 0x0400A8AE RID: 43182
	[Nullable(2)]
	private ShipTowerStageData StageData;

	// Token: 0x0400A8AF RID: 43183
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<ShipTowerScoreInfoItem, ShipTowerScoreInfoData> ScoreInfoLayout;

	// Token: 0x0400A8B0 RID: 43184
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<CommonItemSmallItemGrid, TItem> RewardLayout;

	// Token: 0x020081FF RID: 33279
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029FAD RID: 171949
		public const int TextureIndexBg = 0;

		// Token: 0x04029FAE RID: 171950
		public const int TxtIndex = 1;

		// Token: 0x04029FAF RID: 171951
		public const int TextureEndlessNode = 2;

		// Token: 0x04029FB0 RID: 171952
		public const int TxtStageName = 3;

		// Token: 0x04029FB1 RID: 171953
		public const int TxtScore = 4;

		// Token: 0x04029FB2 RID: 171954
		public const int TxtDesc = 5;

		// Token: 0x04029FB3 RID: 171955
		public const int VLayoutScoreTarget = 6;

		// Token: 0x04029FB4 RID: 171956
		public const int MLayoutReward = 7;

		// Token: 0x04029FB5 RID: 171957
		public const int ItemReward = 8;

		// Token: 0x04029FB6 RID: 171958
		public const int BtnRewardDetail = 9;

		// Token: 0x04029FB7 RID: 171959
		public const int RewardTipRoot = 10;
	}
}
