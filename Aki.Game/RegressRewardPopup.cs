using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020008FF RID: 2303
public class RegressRewardPopup : UiPanelBase
{
	// Token: 0x0600664C RID: 26188 RVA: 0x002007B0 File Offset: 0x001FE9B0
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

	// Token: 0x0600664D RID: 26189 RVA: 0x00200898 File Offset: 0x001FEA98
	protected override void OnBeforeCreateImplement()
	{
		this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
	}

	// Token: 0x0600664E RID: 26190 RVA: 0x002008AB File Offset: 0x001FEAAB
	protected override void OnStart()
	{
		this.RewardPanel = new GenericLayout<RegressRewardPanelItem, RegressRewardTuple>(base.GetHorizontalLayout(0), new Func<RegressRewardPanelItem>(this.CreateRewardItem), null, false, true);
		this.SetActive(false);
	}

	// Token: 0x0600664F RID: 26191 RVA: 0x002008D8 File Offset: 0x001FEAD8
	protected override UniTask OnShowAsyncImplementImplement()
	{
		RegressRewardPopup.<OnShowAsyncImplementImplement>d__7 <OnShowAsyncImplementImplement>d__;
		<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnShowAsyncImplementImplement>d__.<>4__this = this;
		<OnShowAsyncImplementImplement>d__.<>1__state = -1;
		<OnShowAsyncImplementImplement>d__.<>t__builder.Start<RegressRewardPopup.<OnShowAsyncImplementImplement>d__7>(ref <OnShowAsyncImplementImplement>d__);
		return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06006650 RID: 26192 RVA: 0x0020091C File Offset: 0x001FEB1C
	protected override UniTask OnHideAsyncImplementImplement()
	{
		RegressRewardPopup.<OnHideAsyncImplementImplement>d__8 <OnHideAsyncImplementImplement>d__;
		<OnHideAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnHideAsyncImplementImplement>d__.<>4__this = this;
		<OnHideAsyncImplementImplement>d__.<>1__state = -1;
		<OnHideAsyncImplementImplement>d__.<>t__builder.Start<RegressRewardPopup.<OnHideAsyncImplementImplement>d__8>(ref <OnHideAsyncImplementImplement>d__);
		return <OnHideAsyncImplementImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06006651 RID: 26193 RVA: 0x0020095F File Offset: 0x001FEB5F
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

	// Token: 0x06006652 RID: 26194 RVA: 0x0020099D File Offset: 0x001FEB9D
	public void Refresh(RegressRewardPopupData data)
	{
		this.PopUpData = new RegressRewardPopupData?(data);
		if (this.PopUpData.Value.RewardLists.Length == 0)
		{
			return;
		}
		this.RefreshAsync().Forget();
	}

	// Token: 0x06006653 RID: 26195 RVA: 0x002009CC File Offset: 0x001FEBCC
	private UniTask RefreshAsync()
	{
		RegressRewardPopup.<RefreshAsync>d__11 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<RegressRewardPopup.<RefreshAsync>d__11>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006654 RID: 26196 RVA: 0x00200A0F File Offset: 0x001FEC0F
	[NullableContext(1)]
	private RegressRewardPanelItem CreateRewardItem()
	{
		return new RegressRewardPanelItem();
	}

	// Token: 0x06006655 RID: 26197 RVA: 0x00200A16 File Offset: 0x001FEC16
	private void OnMaskBtnClick()
	{
		this.SetActive(false);
	}

	// Token: 0x0400419A RID: 16794
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RegressRewardPanelItem, RegressRewardTuple> RewardPanel;

	// Token: 0x0400419B RID: 16795
	private RegressRewardPopupData? PopUpData;

	// Token: 0x0400419C RID: 16796
	[Nullable(2)]
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x02006C07 RID: 27655
	private class ERegressRewardPopup
	{
		// Token: 0x0402382C RID: 145452
		public const int PanelLayout = 0;

		// Token: 0x0402382D RID: 145453
		public const int RewardItem = 1;

		// Token: 0x0402382E RID: 145454
		public const int Panel = 2;

		// Token: 0x0402382F RID: 145455
		public const int MaskBtn = 3;
	}
}
