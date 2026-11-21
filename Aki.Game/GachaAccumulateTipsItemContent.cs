using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200111E RID: 4382
[NullableContext(1)]
[Nullable(0)]
public class GachaAccumulateTipsItemContent : GachaAccumulateTipsContentBase
{
	// Token: 0x0600AF1E RID: 44830 RVA: 0x00339838 File Offset: 0x00337A38
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnButtonGoClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600AF1F RID: 44831 RVA: 0x003399C6 File Offset: 0x00337BC6
	protected override void OnStart()
	{
		this.UiSequencePlayer = new UiSequencePlayer(this.RootItem);
	}

	// Token: 0x0600AF20 RID: 44832 RVA: 0x003399D9 File Offset: 0x00337BD9
	private void OnButtonGoClick()
	{
		UiManager.Instance.OpenView(EUiViewName.GachaAccumulateBonusView, this.AccumulateId, null);
	}

	// Token: 0x0600AF21 RID: 44833 RVA: 0x003399F8 File Offset: 0x00337BF8
	public override void RefreshView(int accumulateId, bool needAnimate = true)
	{
		this.AccumulateId = accumulateId;
		GachaAccumulateData accumulateData = GachaAccumulateModel.Instance.GetAccumulateData(accumulateId);
		if (accumulateData == null)
		{
			return;
		}
		this.RefreshRewardTexture(accumulateData);
		this.RefreshRewardNum(accumulateData);
		this.RefreshAllFinishItem(accumulateData);
		this.RefreshRewardUnTakeItem(accumulateData);
		this.RefreshProgressText(accumulateData);
		this.RefreshProgressTipsText(accumulateData);
		this.RefreshNumItem(accumulateData);
		if (needAnimate)
		{
			this.PlayStartSequence();
		}
	}

	// Token: 0x0600AF22 RID: 44834 RVA: 0x00339A56 File Offset: 0x00337C56
	private void PlayStartSequence()
	{
		UiSequencePlayer uiSequencePlayer = this.UiSequencePlayer;
		if (uiSequencePlayer == null)
		{
			return;
		}
		uiSequencePlayer.PlaySequencePurely("Start", false, false);
	}

	// Token: 0x0600AF23 RID: 44835 RVA: 0x00339A70 File Offset: 0x00337C70
	private void RefreshRewardTexture(GachaAccumulateData accumulateData)
	{
		RewardItemData tipsShowReward = accumulateData.GetTipsShowReward();
		if (tipsShowReward == null)
		{
			return;
		}
		UUITexture texture = base.GetTexture(1);
		base.SetTextureByPath(tipsShowReward.GetConfig().Icon, texture, null, null);
		UUIItem uuiitem = texture;
		bool ifTakeAllRewardIncludingCyclic = accumulateData.GetIfTakeAllRewardIncludingCyclic();
		FColor? fcolor = new FColor?(texture.changeColor);
		uuiitem.SetChangeColor(ifTakeAllRewardIncludingCyclic, fcolor);
	}

	// Token: 0x0600AF24 RID: 44836 RVA: 0x00339AC8 File Offset: 0x00337CC8
	private void RefreshRewardNum(GachaAccumulateData accumulateData)
	{
		RewardItemData tipsShowReward = accumulateData.GetTipsShowReward();
		if (tipsShowReward == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "GachaAccumulateTipsText", new <>z__ReadOnlySingleElementList<object>(tipsShowReward.Count.ToString()));
	}

	// Token: 0x0600AF25 RID: 44837 RVA: 0x00339B06 File Offset: 0x00337D06
	private void RefreshAllFinishItem(GachaAccumulateData accumulateData)
	{
		base.GetItem(6).SetUIActive(accumulateData.GetIfTakeAllRewardIncludingCyclic());
	}

	// Token: 0x0600AF26 RID: 44838 RVA: 0x00339B1A File Offset: 0x00337D1A
	private void RefreshNumItem(GachaAccumulateData accumulateData)
	{
		base.GetItem(5).SetUIActive(!accumulateData.GetIfAllRewardAchieved());
	}

	// Token: 0x0600AF27 RID: 44839 RVA: 0x00339B34 File Offset: 0x00337D34
	private void RefreshRewardUnTakeItem(GachaAccumulateData accumulateData)
	{
		int unTakeRewardNum = accumulateData.GetUnTakeRewardNum();
		base.GetItem(7).SetUIActive(unTakeRewardNum > 0);
		if (unTakeRewardNum > 0)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "GachaAccumulateTipsUnTakeNumText", new <>z__ReadOnlySingleElementList<object>(unTakeRewardNum.ToString()));
		}
	}

	// Token: 0x0600AF28 RID: 44840 RVA: 0x00339B80 File Offset: 0x00337D80
	private void RefreshProgressText(GachaAccumulateData accumulateData)
	{
		ValueTuple<int, int> progress = accumulateData.GetProgress();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "GachaAccumulateTipsProgressText", new <>z__ReadOnlyArray<object>(new object[]
		{
			progress.Item1.ToString(),
			progress.Item2.ToString()
		}));
	}

	// Token: 0x0600AF29 RID: 44841 RVA: 0x00339BD4 File Offset: 0x00337DD4
	private void RefreshProgressTipsText(GachaAccumulateData accumulateData)
	{
		int nextRewardNeedGachaNum = accumulateData.GetNextRewardNeedGachaNum();
		UUIText text = base.GetText(4);
		if (nextRewardNeedGachaNum > 0)
		{
			LguiUtil.Instance.SetLocalTextNew(text, "GachaAccumulateTipsProgressTipsText", new <>z__ReadOnlySingleElementList<object>(nextRewardNeedGachaNum.ToString()));
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text, "GachaAccumulateTipsProgressFinishText", new <>z__ReadOnlySingleElementList<object>(nextRewardNeedGachaNum.ToString()));
	}

	// Token: 0x04006513 RID: 25875
	[Nullable(2)]
	private UiSequencePlayer UiSequencePlayer;

	// Token: 0x04006514 RID: 25876
	private int AccumulateId;

	// Token: 0x020073A6 RID: 29606
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04025A7B RID: 154235
		ButtonGo,
		// Token: 0x04025A7C RID: 154236
		Texture,
		// Token: 0x04025A7D RID: 154237
		NumText,
		// Token: 0x04025A7E RID: 154238
		ProgressText,
		// Token: 0x04025A7F RID: 154239
		TipsText,
		// Token: 0x04025A80 RID: 154240
		NumItem,
		// Token: 0x04025A81 RID: 154241
		AllFinishItem,
		// Token: 0x04025A82 RID: 154242
		RewardUnTakeTipsItem,
		// Token: 0x04025A83 RID: 154243
		RewardUnTakeNumText
	}
}
