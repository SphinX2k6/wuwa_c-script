using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001131 RID: 4401
[NullableContext(1)]
[Nullable(0)]
public class GachaAccumulateTipsItemContentStage : GachaAccumulateTipsContentBase
{
	// Token: 0x0600AF85 RID: 44933 RVA: 0x0033BD48 File Offset: 0x00339F48
	protected unsafe override void OnRegisterComponent()
	{
		int num = 8;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickEntry));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600AF86 RID: 44934 RVA: 0x0033BEB4 File Offset: 0x0033A0B4
	protected override void OnStart()
	{
		this.UiSequencePlayer = new UiSequencePlayer(this.RootItem);
	}

	// Token: 0x0600AF87 RID: 44935 RVA: 0x0033BEC7 File Offset: 0x0033A0C7
	private void OnClickEntry()
	{
		UiManager.Instance.OpenView(EUiViewName.GachaAccumulateBonusView, this.AccumulateId, null);
	}

	// Token: 0x0600AF88 RID: 44936 RVA: 0x0033BEE4 File Offset: 0x0033A0E4
	public override void RefreshView(int accumulateId, bool needAnimate = true)
	{
		this.AccumulateId = accumulateId;
		GachaAccumulateData accumulateData = GachaAccumulateModel.Instance.GetAccumulateData(accumulateId);
		if (accumulateData == null)
		{
			return;
		}
		bool ifAllRewardAchieved = accumulateData.GetIfAllRewardAchieved();
		bool ifTakeAllRewardIncludingCyclic = accumulateData.GetIfTakeAllRewardIncludingCyclic();
		base.GetItem(3).SetUIActive(ifTakeAllRewardIncludingCyclic);
		this.RefreshNextRewardIconAndCount(accumulateData, ifAllRewardAchieved, ifTakeAllRewardIncludingCyclic);
		this.RefreshDescText(accumulateData, ifAllRewardAchieved);
		this.RefreshUnTakeTips(accumulateData);
		if (needAnimate)
		{
			UiSequencePlayer uiSequencePlayer = this.UiSequencePlayer;
			if (uiSequencePlayer == null)
			{
				return;
			}
			uiSequencePlayer.PlaySequencePurely("Start", false, false);
		}
	}

	// Token: 0x0600AF89 RID: 44937 RVA: 0x0033BF58 File Offset: 0x0033A158
	private void RefreshNextRewardIconAndCount(GachaAccumulateData accumulateData, bool allDone, bool allClaimed)
	{
		RewardItemData tipsShowReward = accumulateData.GetTipsShowReward();
		if (tipsShowReward == null)
		{
			base.GetItem(4).SetUIActive(false);
			return;
		}
		UUITexture texture = base.GetTexture(2);
		base.SetTextureByPath(tipsShowReward.GetConfig().Icon, texture, null, null);
		UUIItem uuiitem = texture;
		FColor? fcolor = new FColor?(texture.changeColor);
		uuiitem.SetChangeColor(allClaimed, fcolor);
		base.GetItem(4).SetUIActive(!allDone);
		if (!allDone)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "GachaAccumulateTipsText", new <>z__ReadOnlySingleElementList<object>(tipsShowReward.Count.ToString()));
		}
	}

	// Token: 0x0600AF8A RID: 44938 RVA: 0x0033BFF0 File Offset: 0x0033A1F0
	private void RefreshDescText(GachaAccumulateData accumulateData, bool allDone)
	{
		base.GetText(1).SetUIActive(true);
		int nextRewardNeedGachaNum = accumulateData.GetNextRewardNeedGachaNum();
		string textStringId = (nextRewardNeedGachaNum > 0) ? "GachaAccumulateTipsProgressTipsText" : "GachaAccumulateTipsProgressFinishText";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, new <>z__ReadOnlySingleElementList<object>(nextRewardNeedGachaNum.ToString()));
	}

	// Token: 0x0600AF8B RID: 44939 RVA: 0x0033C040 File Offset: 0x0033A240
	private void RefreshUnTakeTips(GachaAccumulateData accumulateData)
	{
		int unTakeRewardNum = accumulateData.GetUnTakeRewardNum();
		base.GetItem(6).SetUIActive(unTakeRewardNum > 0);
		if (unTakeRewardNum > 0)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "GachaAccumulateTipsUnTakeNumText", new <>z__ReadOnlySingleElementList<object>(unTakeRewardNum.ToString()));
		}
	}

	// Token: 0x04006571 RID: 25969
	[Nullable(2)]
	private UiSequencePlayer UiSequencePlayer;

	// Token: 0x04006572 RID: 25970
	private int AccumulateId;

	// Token: 0x020073B2 RID: 29618
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04025AB5 RID: 154293
		ButtonClick,
		// Token: 0x04025AB6 RID: 154294
		TextDescription,
		// Token: 0x04025AB7 RID: 154295
		TextureIcon,
		// Token: 0x04025AB8 RID: 154296
		PanelCheck,
		// Token: 0x04025AB9 RID: 154297
		PanelCount,
		// Token: 0x04025ABA RID: 154298
		TextCount,
		// Token: 0x04025ABB RID: 154299
		PanelTips,
		// Token: 0x04025ABC RID: 154300
		TextTips
	}
}
