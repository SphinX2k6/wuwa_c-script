using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001451 RID: 5201
public class ReputationDetailsView : UiViewBase
{
	// Token: 0x0600CED1 RID: 52945 RVA: 0x003D7AA4 File Offset: 0x003D5CA4
	[NullableContext(1)]
	public ReputationDetailsView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600CED2 RID: 52946 RVA: 0x003D7AB0 File Offset: 0x003D5CB0
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

	// Token: 0x0600CED3 RID: 52947 RVA: 0x003D7CEB File Offset: 0x003D5EEB
	private void CloseClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600CED4 RID: 52948 RVA: 0x003D7CF4 File Offset: 0x003D5EF4
	private void TipsClick()
	{
		if (this.Config == null)
		{
			return;
		}
		IntPair[] param = this.Config.Value.ReputationItem();
		UiManager.Instance.OpenView(EUiViewName.ReputationTips, param, null);
	}

	// Token: 0x0600CED5 RID: 52949 RVA: 0x003D7D34 File Offset: 0x003D5F34
	private void ReceiveClick()
	{
		InfluenceReputationController.Instance.RequestInfluenceReward(this.Data.InfluenceId);
	}

	// Token: 0x0600CED6 RID: 52950 RVA: 0x003D7D4B File Offset: 0x003D5F4B
	private void RewardClick()
	{
		UiManager.Instance.OpenView(EUiViewName.ReputationRewardsView, this.Data.InfluenceId, null);
	}

	// Token: 0x0600CED7 RID: 52951 RVA: 0x003D7D6D File Offset: 0x003D5F6D
	protected override void OnBeforeCreate()
	{
		this.Data = (IReputationDetailsData)this.OpenParam;
	}

	// Token: 0x0600CED8 RID: 52952 RVA: 0x003D7D80 File Offset: 0x003D5F80
	protected override void OnStart()
	{
		this.RewardItem = new InfluenceRewardItem(base.GetItem(10));
	}

	// Token: 0x0600CED9 RID: 52953 RVA: 0x003D7D95 File Offset: 0x003D5F95
	protected override void OnAfterShow()
	{
		this.Config = InfluenceConfig.Instance.GetInfluenceConfig(this.Data.InfluenceId);
		this.InitView();
		this.RefreshView();
	}

	// Token: 0x0600CEDA RID: 52954 RVA: 0x003D7DBE File Offset: 0x003D5FBE
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.ReceiveReputationReward, new Action(this.RefreshEvent));
	}

	// Token: 0x0600CEDB RID: 52955 RVA: 0x003D7DDC File Offset: 0x003D5FDC
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.ReceiveReputationReward, new Action(this.RefreshEvent));
	}

	// Token: 0x0600CEDC RID: 52956 RVA: 0x003D7DFA File Offset: 0x003D5FFA
	private void RefreshEvent()
	{
		this.RefreshView();
	}

	// Token: 0x0600CEDD RID: 52957 RVA: 0x003D7E02 File Offset: 0x003D6002
	protected override void OnBeforeDestroy()
	{
		this.RewardItem.Destroy(null);
		this.RewardItem = null;
	}

	// Token: 0x0600CEDE RID: 52958 RVA: 0x003D7E18 File Offset: 0x003D6018
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

	// Token: 0x0600CEDF RID: 52959 RVA: 0x003D7ED8 File Offset: 0x003D60D8
	protected void RefreshProgress(int current, int max)
	{
		LguiUtil.Instance.SetLocalText(base.GetText(9), "ReputationNormalValue", new <>z__ReadOnlyArray<object>(new object[]
		{
			current,
			max
		}));
		base.GetSprite(6).SetFillAmount((float)current / (float)max);
	}

	// Token: 0x0600CEE0 RID: 52960 RVA: 0x003D7F2C File Offset: 0x003D612C
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

	// Token: 0x0600CEE1 RID: 52961 RVA: 0x003D7FC3 File Offset: 0x003D61C3
	private void RefreshRewardItem(IntPair reward, bool isReceived)
	{
		this.RewardItem.UpdateItem(reward, isReceived);
		if (isReceived)
		{
			this.RewardItem.SetAllReceivedTitle();
		}
	}

	// Token: 0x04007599 RID: 30105
	[Nullable(2)]
	private IReputationDetailsData Data;

	// Token: 0x0400759A RID: 30106
	[Nullable(2)]
	private InfluenceRewardItem RewardItem;

	// Token: 0x0400759B RID: 30107
	private Influence? Config;

	// Token: 0x020076FE RID: 30462
	private enum EReputationDetailsView
	{
		// Token: 0x04026A7B RID: 158331
		CloseButton,
		// Token: 0x04026A7C RID: 158332
		TipsButton,
		// Token: 0x04026A7D RID: 158333
		ReceiveButton,
		// Token: 0x04026A7E RID: 158334
		ReceiveInteractionGroup,
		// Token: 0x04026A7F RID: 158335
		RewardButton,
		// Token: 0x04026A80 RID: 158336
		InfluenceTexture,
		// Token: 0x04026A81 RID: 158337
		ReputationProgress,
		// Token: 0x04026A82 RID: 158338
		InfluenceText,
		// Token: 0x04026A83 RID: 158339
		AreaText,
		// Token: 0x04026A84 RID: 158340
		ProgressValue,
		// Token: 0x04026A85 RID: 158341
		RewardItem
	}
}
