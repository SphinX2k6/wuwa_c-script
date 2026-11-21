using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200111A RID: 4378
[NullableContext(1)]
[Nullable(0)]
public class GachaAccumulateBonusViewContent : GachaAccumulateBonusContentBase
{
	// Token: 0x0600AF01 RID: 44801 RVA: 0x00338DEC File Offset: 0x00336FEC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBackButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600AF02 RID: 44802 RVA: 0x00338ED4 File Offset: 0x003370D4
	protected override void OnStart()
	{
		this.UiSequencePlayerInstance = new UiSequencePlayer(this.RootItem);
		this.Layout = new GenericLayout<GachaAccumulateRewardItem, GachaAccumulateRewardItemData>(base.GetHorizontalLayout(2), new Func<GachaAccumulateRewardItem>(this.OnCreateRewardItem), null, false, true);
	}

	// Token: 0x0600AF03 RID: 44803 RVA: 0x00338F08 File Offset: 0x00337108
	public override UniTask PlayStartSequence()
	{
		GachaAccumulateBonusViewContent.<PlayStartSequence>d__5 <PlayStartSequence>d__;
		<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayStartSequence>d__.<>4__this = this;
		<PlayStartSequence>d__.<>1__state = -1;
		<PlayStartSequence>d__.<>t__builder.Start<GachaAccumulateBonusViewContent.<PlayStartSequence>d__5>(ref <PlayStartSequence>d__);
		return <PlayStartSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600AF04 RID: 44804 RVA: 0x00338F4C File Offset: 0x0033714C
	public override UniTask PlayCloseSequence()
	{
		GachaAccumulateBonusViewContent.<PlayCloseSequence>d__6 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<GachaAccumulateBonusViewContent.<PlayCloseSequence>d__6>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600AF05 RID: 44805 RVA: 0x00338F8F File Offset: 0x0033718F
	private GachaAccumulateRewardItem OnCreateRewardItem()
	{
		return new GachaAccumulateRewardItem();
	}

	// Token: 0x0600AF06 RID: 44806 RVA: 0x00338F96 File Offset: 0x00337196
	private void OnBackButtonClick()
	{
		this.OnClickBackButtonCallBack();
	}

	// Token: 0x0600AF07 RID: 44807 RVA: 0x00338FA3 File Offset: 0x003371A3
	public override void SetOnClickBackButtonCallBack(Action callback)
	{
		this.OnClickBackButtonCallBack = callback;
	}

	// Token: 0x0600AF08 RID: 44808 RVA: 0x00338FAC File Offset: 0x003371AC
	public override void RefreshView(int gachaAccumulateId)
	{
		GachaAccumulateModel.Instance.GetAccumulateData(gachaAccumulateId);
		this.RefreshNumText(gachaAccumulateId);
		this.RefreshLayoutAsync(gachaAccumulateId).Forget();
	}

	// Token: 0x0600AF09 RID: 44809 RVA: 0x00338FD0 File Offset: 0x003371D0
	private UniTask RefreshLayoutAsync(int gachaAccumulateId)
	{
		GachaAccumulateBonusViewContent.<RefreshLayoutAsync>d__11 <RefreshLayoutAsync>d__;
		<RefreshLayoutAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshLayoutAsync>d__.<>4__this = this;
		<RefreshLayoutAsync>d__.gachaAccumulateId = gachaAccumulateId;
		<RefreshLayoutAsync>d__.<>1__state = -1;
		<RefreshLayoutAsync>d__.<>t__builder.Start<GachaAccumulateBonusViewContent.<RefreshLayoutAsync>d__11>(ref <RefreshLayoutAsync>d__);
		return <RefreshLayoutAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AF0A RID: 44810 RVA: 0x0033901C File Offset: 0x0033721C
	public void RefreshSlider()
	{
		int displayGridNum = this.Layout.GetDisplayGridNum();
		if (displayGridNum > 1)
		{
			float anchorOffsetX = this.Layout.GetGrid(1).GetAnchorOffsetX();
			float anchorOffsetX2 = this.Layout.GetGrid(0).GetAnchorOffsetX();
			float width = anchorOffsetX - anchorOffsetX2;
			for (int i = 1; i < displayGridNum; i++)
			{
				this.Layout.GetLayoutItemByIndex(i).RefreshSpriteWidth(width);
			}
		}
	}

	// Token: 0x0600AF0B RID: 44811 RVA: 0x00339080 File Offset: 0x00337280
	private void RefreshNumText(int gachaAccumulateId)
	{
		List<GachaAccumulateRewardData> rewardInfos = GachaAccumulateModel.Instance.GetAccumulateData(gachaAccumulateId).GroupData.RewardInfos;
		int gachaNum = rewardInfos[rewardInfos.Count - 1].GachaNum;
		GachaAccumulateData accumulateData = GachaAccumulateModel.Instance.GetAccumulateData(gachaAccumulateId);
		int num = (accumulateData != null) ? accumulateData.CurGachaNum : 0;
		if (num >= gachaNum)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "GachaAccumulateAllFinishProgressText", Array.Empty<object>());
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "GachaAccumulateProgressText", new <>z__ReadOnlyArray<object>(new object[]
		{
			num.ToString(),
			gachaNum.ToString()
		}));
	}

	// Token: 0x040064FA RID: 25850
	[Nullable(2)]
	private UiSequencePlayer UiSequencePlayerInstance;

	// Token: 0x040064FB RID: 25851
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<GachaAccumulateRewardItem, GachaAccumulateRewardItemData> Layout;

	// Token: 0x040064FC RID: 25852
	private Action OnClickBackButtonCallBack = delegate()
	{
	};
}
