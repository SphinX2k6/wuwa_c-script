using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C5B RID: 7259
[NullableContext(1)]
[Nullable(0)]
public class GachaAccumulateBonusViewContent : GachaAccumulateBonusContentBase
{
	// Token: 0x0600DAEB RID: 56043 RVA: 0x0032D9A4 File Offset: 0x0032BBA4
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

	// Token: 0x0600DAEC RID: 56044 RVA: 0x0032DA8C File Offset: 0x0032BC8C
	protected override void OnStart()
	{
		this.UiSequencePlayerInstance = new UiSequencePlayer(this.RootItem);
		this.Layout = new GenericLayout<GachaAccumulateRewardItem, GachaAccumulateRewardItemData>(base.GetHorizontalLayout(2), new Func<GachaAccumulateRewardItem>(this.OnCreateRewardItem), null, false, true);
	}

	// Token: 0x0600DAED RID: 56045 RVA: 0x0032DAC0 File Offset: 0x0032BCC0
	public override UniTask PlayStartSequence()
	{
		GachaAccumulateBonusViewContent.<PlayStartSequence>d__5 <PlayStartSequence>d__;
		<PlayStartSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayStartSequence>d__.<>4__this = this;
		<PlayStartSequence>d__.<>1__state = -1;
		<PlayStartSequence>d__.<>t__builder.Start<GachaAccumulateBonusViewContent.<PlayStartSequence>d__5>(ref <PlayStartSequence>d__);
		return <PlayStartSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600DAEE RID: 56046 RVA: 0x0032DB04 File Offset: 0x0032BD04
	public override UniTask PlayCloseSequence()
	{
		GachaAccumulateBonusViewContent.<PlayCloseSequence>d__6 <PlayCloseSequence>d__;
		<PlayCloseSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseSequence>d__.<>4__this = this;
		<PlayCloseSequence>d__.<>1__state = -1;
		<PlayCloseSequence>d__.<>t__builder.Start<GachaAccumulateBonusViewContent.<PlayCloseSequence>d__6>(ref <PlayCloseSequence>d__);
		return <PlayCloseSequence>d__.<>t__builder.Task;
	}

	// Token: 0x0600DAEF RID: 56047 RVA: 0x0032DB47 File Offset: 0x0032BD47
	private GachaAccumulateRewardItem OnCreateRewardItem()
	{
		return new GachaAccumulateRewardItem();
	}

	// Token: 0x0600DAF0 RID: 56048 RVA: 0x0032DB4E File Offset: 0x0032BD4E
	private void OnBackButtonClick()
	{
		this.OnClickBackButtonCallBack();
	}

	// Token: 0x0600DAF1 RID: 56049 RVA: 0x0032DB5B File Offset: 0x0032BD5B
	public override void SetOnClickBackButtonCallBack(Action callback)
	{
		this.OnClickBackButtonCallBack = callback;
	}

	// Token: 0x0600DAF2 RID: 56050 RVA: 0x0032DB64 File Offset: 0x0032BD64
	public override void RefreshView(int gachaAccumulateId)
	{
		GachaAccumulateModel.Instance.GetAccumulateData(gachaAccumulateId);
		this.RefreshNumText(gachaAccumulateId);
		this.RefreshLayoutAsync(gachaAccumulateId).Forget();
	}

	// Token: 0x0600DAF3 RID: 56051 RVA: 0x0032DB88 File Offset: 0x0032BD88
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

	// Token: 0x0600DAF4 RID: 56052 RVA: 0x0032DBD4 File Offset: 0x0032BDD4
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

	// Token: 0x0600DAF5 RID: 56053 RVA: 0x0032DC38 File Offset: 0x0032BE38
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

	// Token: 0x04006428 RID: 25640
	[Nullable(2)]
	private UiSequencePlayer UiSequencePlayerInstance;

	// Token: 0x04006429 RID: 25641
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<GachaAccumulateRewardItem, GachaAccumulateRewardItemData> Layout;

	// Token: 0x0400642A RID: 25642
	private Action OnClickBackButtonCallBack = delegate()
	{
	};
}
