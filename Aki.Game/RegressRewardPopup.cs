using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200144B RID: 5195
public class RegressRewardPopup : UiPanelBase
{
	// Token: 0x060092B7 RID: 37559 RVA: 0x001F7C74 File Offset: 0x001F5E74
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnMaskBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060092B8 RID: 37560 RVA: 0x001F7D5C File Offset: 0x001F5F5C
	protected override void OnBeforeCreateImplement()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x060092B9 RID: 37561 RVA: 0x001F7D6F File Offset: 0x001F5F6F
	protected override void OnStart()
	{
		this.RewardPanel = new GenericLayout<RegressRewardPanelItem, RegressRewardTuple>(base.GetHorizontalLayout(0), new Func<RegressRewardPanelItem>(this.CreateRewardItem), null, false, true);
		this.SetActive(false);
	}

	// Token: 0x060092BA RID: 37562 RVA: 0x001F7D9C File Offset: 0x001F5F9C
	protected override UniTask OnShowAsyncImplementImplement()
	{
		RegressRewardPopup.<OnShowAsyncImplementImplement>d__7 <OnShowAsyncImplementImplement>d__;
		<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnShowAsyncImplementImplement>d__.<>4__this = this;
		<OnShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnShowAsyncImplementImplement>d__.<>t__builder.Start<RegressRewardPopup.<OnShowAsyncImplementImplement>d__7>(ref <OnShowAsyncImplementImplement>d__);
		return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x060092BB RID: 37563 RVA: 0x001F7DE0 File Offset: 0x001F5FE0
	protected override UniTask OnHideAsyncImplementImplement()
	{
		RegressRewardPopup.<OnHideAsyncImplementImplement>d__8 <OnHideAsyncImplementImplement>d__;
		<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHideAsyncImplementImplement>d__.<>4__this = this;
		<OnHideAsyncImplementImplement>d__.<>1__state = -1;
		<OnHideAsyncImplementImplement>d__.<>t__builder.Start<RegressRewardPopup.<OnHideAsyncImplementImplement>d__8>(ref <OnHideAsyncImplementImplement>d__);
		return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x060092BC RID: 37564 RVA: 0x001F7E23 File Offset: 0x001F6023
	protected override void OnBeforeDestroy()
	{
		GenericLayout<RegressRewardPanelItem, RegressRewardTuple> rewardPanel = this.RewardPanel;
		if (rewardPanel != null)
		{
			rewardPanel.ClearChildren();
		}
		this.RewardPanel = null;
		this.PopUpData = null;
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
	}

	// Token: 0x060092BD RID: 37565 RVA: 0x001F7E61 File Offset: 0x001F6061
	public void Refresh(RegressRewardPopupData data)
	{
		this.PopUpData = new RegressRewardPopupData?(data);
		if (this.PopUpData.Value.RewardLists.Length == 0)
		{
			return;
		}
		this.RefreshAsync().Forget();
	}

	// Token: 0x060092BE RID: 37566 RVA: 0x001F7E90 File Offset: 0x001F6090
	private UniTask RefreshAsync()
	{
		RegressRewardPopup.<RefreshAsync>d__11 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<RegressRewardPopup.<RefreshAsync>d__11>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060092BF RID: 37567 RVA: 0x001F7ED3 File Offset: 0x001F60D3
	[NullableContext(1)]
	private RegressRewardPanelItem CreateRewardItem()
	{
		return new RegressRewardPanelItem();
	}

	// Token: 0x060092C0 RID: 37568 RVA: 0x001F7EDA File Offset: 0x001F60DA
	private void OnMaskBtnClick()
	{
		this.SetActive(false);
	}

	// Token: 0x04004102 RID: 16642
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RegressRewardPanelItem, RegressRewardTuple> RewardPanel;

	// Token: 0x04004103 RID: 16643
	private RegressRewardPopupData? PopUpData;

	// Token: 0x04004104 RID: 16644
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x02007A83 RID: 31363
	private class ERegressRewardPopup
	{
		// Token: 0x04028512 RID: 165138
		public const int PanelLayout = 0;

		// Token: 0x04028513 RID: 165139
		public const int RewardItem = 1;

		// Token: 0x04028514 RID: 165140
		public const int Panel = 2;

		// Token: 0x04028515 RID: 165141
		public const int MaskBtn = 3;
	}
}
