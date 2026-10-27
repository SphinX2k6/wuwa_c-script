using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.ItemReward;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001C72 RID: 7282
[NullableContext(1)]
[Nullable(0)]
public class GachaAccumulateTipsItemContentStage : GachaAccumulateTipsContentBase
{
	// Token: 0x0600DB6F RID: 56175 RVA: 0x003308FC File Offset: 0x0032EAFC
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

	// Token: 0x0600DB70 RID: 56176 RVA: 0x00330A68 File Offset: 0x0032EC68
	protected override void OnStart()
	{
		this.UiSequencePlayer = new UiSequencePlayer(this.RootItem);
	}

	// Token: 0x0600DB71 RID: 56177 RVA: 0x00330A7B File Offset: 0x0032EC7B
	private void OnClickEntry()
	{
		UiManager.Instance.OpenView(EUiViewName.GachaAccumulateBonusView, this.AccumulateId, null);
	}

	// Token: 0x0600DB72 RID: 56178 RVA: 0x00330A98 File Offset: 0x0032EC98
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

	// Token: 0x0600DB73 RID: 56179 RVA: 0x00330B0C File Offset: 0x0032ED0C
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

	// Token: 0x0600DB74 RID: 56180 RVA: 0x00330BA4 File Offset: 0x0032EDA4
	private void RefreshDescText(GachaAccumulateData accumulateData, bool allDone)
	{
		base.GetText(1).SetUIActive(true);
		int nextRewardNeedGachaNum = accumulateData.GetNextRewardNeedGachaNum();
		string textStringId = (nextRewardNeedGachaNum > 0) ? "GachaAccumulateTipsProgressTipsText" : "GachaAccumulateTipsProgressFinishText";
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textStringId, new <>z__ReadOnlySingleElementList<object>(nextRewardNeedGachaNum.ToString()));
	}

	// Token: 0x0600DB75 RID: 56181 RVA: 0x00330BF4 File Offset: 0x0032EDF4
	private void RefreshUnTakeTips(GachaAccumulateData accumulateData)
	{
		int unTakeRewardNum = accumulateData.GetUnTakeRewardNum();
		base.GetItem(6).SetUIActive(unTakeRewardNum > 0);
		if (unTakeRewardNum > 0)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), "GachaAccumulateTipsUnTakeNumText", new <>z__ReadOnlySingleElementList<object>(unTakeRewardNum.ToString()));
		}
	}

	// Token: 0x0400649F RID: 25759
	[Nullable(2)]
	private UiSequencePlayer UiSequencePlayer;

	// Token: 0x040064A0 RID: 25760
	private int AccumulateId;

	// Token: 0x02008229 RID: 33321
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402A78F RID: 173967
		ButtonClick,
		// Token: 0x0402A790 RID: 173968
		TextDescription,
		// Token: 0x0402A791 RID: 173969
		TextureIcon,
		// Token: 0x0402A792 RID: 173970
		PanelCheck,
		// Token: 0x0402A793 RID: 173971
		PanelCount,
		// Token: 0x0402A794 RID: 173972
		TextCount,
		// Token: 0x0402A795 RID: 173973
		PanelTips,
		// Token: 0x0402A796 RID: 173974
		TextTips
	}
}
