using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001F8F RID: 8079
public class ReputationDetailsView : UiViewBase
{
	// Token: 0x0600FAB2 RID: 64178 RVA: 0x003CBF70 File Offset: 0x003CA170
	[NullableContext(1)]
	public ReputationDetailsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600FAB3 RID: 64179 RVA: 0x003CBF7C File Offset: 0x003CA17C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIInteractionGroup));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
		num2 = 4;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.CloseClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.TipsClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.ReceiveClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.RewardClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600FAB4 RID: 64180 RVA: 0x003CC1B7 File Offset: 0x003CA3B7
	private void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600FAB5 RID: 64181 RVA: 0x003CC1C0 File Offset: 0x003CA3C0
	private void TipsClick()
	{
		if (this.Config == null)
		{
			return;
		}
		IntPair[] param = this.Config.Value.ReputationItem();
		UiManager.Instance.OpenView(EUiViewName.ReputationTips, param, null);
	}

	// Token: 0x0600FAB6 RID: 64182 RVA: 0x003CC200 File Offset: 0x003CA400
	private void ReceiveClick()
	{
		InfluenceReputationController.Instance.RequestInfluenceReward(this.Data.InfluenceId);
	}

	// Token: 0x0600FAB7 RID: 64183 RVA: 0x003CC217 File Offset: 0x003CA417
	private void RewardClick()
	{
		UiManager.Instance.OpenView(EUiViewName.ReputationRewardsView, this.Data.InfluenceId, null);
	}

	// Token: 0x0600FAB8 RID: 64184 RVA: 0x003CC239 File Offset: 0x003CA439
	protected override void OnBeforeCreate()
	{
		this.Data = (IReputationDetailsData)this.OpenParam;
	}

	// Token: 0x0600FAB9 RID: 64185 RVA: 0x003CC24C File Offset: 0x003CA44C
	protected override void OnStart()
	{
		this.RewardItem = new InfluenceRewardItem(base.GetItem(10));
	}

	// Token: 0x0600FABA RID: 64186 RVA: 0x003CC261 File Offset: 0x003CA461
	protected override void OnAfterShow()
	{
		this.Config = InfluenceConfig.Instance.GetInfluenceConfig(this.Data.InfluenceId);
		this.InitView();
		this.RefreshView();
	}

	// Token: 0x0600FABB RID: 64187 RVA: 0x003CC28A File Offset: 0x003CA48A
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.ReceiveReputationReward, new Action(this.RefreshEvent));
	}

	// Token: 0x0600FABC RID: 64188 RVA: 0x003CC2A8 File Offset: 0x003CA4A8
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ReceiveReputationReward, new Action(this.RefreshEvent));
	}

	// Token: 0x0600FABD RID: 64189 RVA: 0x003CC2C6 File Offset: 0x003CA4C6
	private void RefreshEvent()
	{
		this.RefreshView();
	}

	// Token: 0x0600FABE RID: 64190 RVA: 0x003CC2CE File Offset: 0x003CA4CE
	protected override void OnBeforeDestroy()
	{
		this.RewardItem.Destroy(null);
		this.RewardItem = null;
	}

	// Token: 0x0600FABF RID: 64191 RVA: 0x003CC2E4 File Offset: 0x003CA4E4
	protected void RefreshView()
	{
		ValueTuple<bool, IntPair>? canReceiveReward = InfluenceReputationModel.Instance.GetCanReceiveReward(this.Data.InfluenceId);
		if (canReceiveReward == null)
		{
			return;
		}
		ValueTuple<bool, IntPair> value = canReceiveReward.Value;
		ValueTuple<int, int> reputationProgress = InfluenceReputationModel.Instance.GetReputationProgress(this.Data.InfluenceId);
		this.RefreshProgress(reputationProgress.Item1, reputationProgress.Item2);
		this.RefreshRewardItem(value.Item2, value.Item1);
		base.GetButton(2).RootUIComp.Get().SetUIActive(!value.Item1);
		if (value.Item1)
		{
			return;
		}
		base.GetInteractionGroup(3).SetInteractable(reputationProgress.Item1 >= value.Item2.Item1);
	}

	// Token: 0x0600FAC0 RID: 64192 RVA: 0x003CC3A4 File Offset: 0x003CA5A4
	protected void RefreshProgress(int current, int max)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(9), "ReputationNormalValue", new <>z__ReadOnlyArray<object>(new object[]
		{
			current,
			max
		}));
		base.GetSprite(6).SetFillAmount((float)current / (float)max);
	}

	// Token: 0x0600FAC1 RID: 64193 RVA: 0x003CC3F8 File Offset: 0x003CA5F8
	protected void InitView()
	{
		if (this.Config == null)
		{
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), this.Config.Value.Title, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), this.Config.Value.ExtraDesc, Array.Empty<object>());
		base.SetTextureByPath(this.Config.Value.Logo, base.GetTexture(5), null, null);
	}

	// Token: 0x0600FAC2 RID: 64194 RVA: 0x003CC48F File Offset: 0x003CA68F
	private void RefreshRewardItem(IntPair reward, bool isReceived)
	{
		this.RewardItem.UpdateItem(reward, isReceived);
		if (isReceived)
		{
			this.RewardItem.SetAllReceivedTitle();
		}
	}

	// Token: 0x040074B8 RID: 29880
	[Nullable(2)]
	private IReputationDetailsData Data;

	// Token: 0x040074B9 RID: 29881
	[Nullable(2)]
	private InfluenceRewardItem RewardItem;

	// Token: 0x040074BA RID: 29882
	private Influence? Config;

	// Token: 0x02008579 RID: 34169
	private enum EReputationDetailsView
	{
		// Token: 0x0402B758 RID: 178008
		CloseButton,
		// Token: 0x0402B759 RID: 178009
		TipsButton,
		// Token: 0x0402B75A RID: 178010
		ReceiveButton,
		// Token: 0x0402B75B RID: 178011
		ReceiveInteractionGroup,
		// Token: 0x0402B75C RID: 178012
		RewardButton,
		// Token: 0x0402B75D RID: 178013
		InfluenceTexture,
		// Token: 0x0402B75E RID: 178014
		ReputationProgress,
		// Token: 0x0402B75F RID: 178015
		InfluenceText,
		// Token: 0x0402B760 RID: 178016
		AreaText,
		// Token: 0x0402B761 RID: 178017
		ProgressValue,
		// Token: 0x0402B762 RID: 178018
		RewardItem
	}
}
