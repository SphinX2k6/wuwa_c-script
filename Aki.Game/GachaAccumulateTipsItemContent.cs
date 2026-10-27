using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C5F RID: 7263
[NullableContext(1)]
[Nullable(0)]
public class GachaAccumulateTipsItemContent : GachaAccumulateTipsContentBase
{
	// Token: 0x0600DB08 RID: 56072 RVA: 0x0032E3EC File Offset: 0x0032C5EC
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

	// Token: 0x0600DB09 RID: 56073 RVA: 0x0032E57A File Offset: 0x0032C77A
	protected override void OnStart()
	{
		this.UiSequencePlayer = new UiSequencePlayer(this.RootItem);
	}

	// Token: 0x0600DB0A RID: 56074 RVA: 0x0032E58D File Offset: 0x0032C78D
	private void OnButtonGoClick()
	{
		UiManager.Instance.OpenView(EUiViewName.GachaAccumulateBonusView, this.AccumulateId, null);
	}

	// Token: 0x0600DB0B RID: 56075 RVA: 0x0032E5AC File Offset: 0x0032C7AC
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

	// Token: 0x0600DB0C RID: 56076 RVA: 0x0032E60A File Offset: 0x0032C80A
	private void PlayStartSequence()
	{
		UiSequencePlayer uiSequencePlayer = this.UiSequencePlayer;
		if (uiSequencePlayer == null)
		{
			return;
		}
		uiSequencePlayer.PlaySequencePurely("Start", false, false);
	}

	// Token: 0x0600DB0D RID: 56077 RVA: 0x0032E624 File Offset: 0x0032C824
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

	// Token: 0x0600DB0E RID: 56078 RVA: 0x0032E67C File Offset: 0x0032C87C
	private void RefreshRewardNum(GachaAccumulateData accumulateData)
	{
		RewardItemData tipsShowReward = accumulateData.GetTipsShowReward();
		if (tipsShowReward == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "GachaAccumulateTipsText", new <>z__ReadOnlySingleElementList<object>(tipsShowReward.Count.ToString()));
	}

	// Token: 0x0600DB0F RID: 56079 RVA: 0x0032E6BA File Offset: 0x0032C8BA
	private void RefreshAllFinishItem(GachaAccumulateData accumulateData)
	{
		base.GetItem(6).SetUIActive(accumulateData.GetIfTakeAllRewardIncludingCyclic());
	}

	// Token: 0x0600DB10 RID: 56080 RVA: 0x0032E6CE File Offset: 0x0032C8CE
	private void RefreshNumItem(GachaAccumulateData accumulateData)
	{
		base.GetItem(5).SetUIActive(!accumulateData.GetIfAllRewardAchieved());
	}

	// Token: 0x0600DB11 RID: 56081 RVA: 0x0032E6E8 File Offset: 0x0032C8E8
	private void RefreshRewardUnTakeItem(GachaAccumulateData accumulateData)
	{
		int unTakeRewardNum = accumulateData.GetUnTakeRewardNum();
		base.GetItem(7).SetUIActive(unTakeRewardNum > 0);
		if (unTakeRewardNum > 0)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), "GachaAccumulateTipsUnTakeNumText", new <>z__ReadOnlySingleElementList<object>(unTakeRewardNum.ToString()));
		}
	}

	// Token: 0x0600DB12 RID: 56082 RVA: 0x0032E734 File Offset: 0x0032C934
	private void RefreshProgressText(GachaAccumulateData accumulateData)
	{
		ValueTuple<int, int> progress = accumulateData.GetProgress();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "GachaAccumulateTipsProgressText", new <>z__ReadOnlyArray<object>(new object[]
		{
			progress.Item1.ToString(),
			progress.Item2.ToString()
		}));
	}

	// Token: 0x0600DB13 RID: 56083 RVA: 0x0032E788 File Offset: 0x0032C988
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

	// Token: 0x04006441 RID: 25665
	[Nullable(2)]
	private UiSequencePlayer UiSequencePlayer;

	// Token: 0x04006442 RID: 25666
	private int AccumulateId;

	// Token: 0x0200821D RID: 33309
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A755 RID: 173909
		ButtonGo,
		// Token: 0x0402A756 RID: 173910
		Texture,
		// Token: 0x0402A757 RID: 173911
		NumText,
		// Token: 0x0402A758 RID: 173912
		ProgressText,
		// Token: 0x0402A759 RID: 173913
		TipsText,
		// Token: 0x0402A75A RID: 173914
		NumItem,
		// Token: 0x0402A75B RID: 173915
		AllFinishItem,
		// Token: 0x0402A75C RID: 173916
		RewardUnTakeTipsItem,
		// Token: 0x0402A75D RID: 173917
		RewardUnTakeNumText
	}
}
