using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A55 RID: 6741
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssRankView : UiViewBase
{
	// Token: 0x0600C659 RID: 50777 RVA: 0x002D1A30 File Offset: 0x002CFC30
	public DangoAbyssRankView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C65A RID: 50778 RVA: 0x002D1A3C File Offset: 0x002CFC3C
	protected unsafe override void OnRegisterComponent()
	{
		int num = 11;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 5;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnSingleRankTabToggleClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnOnlineRankTabToggleClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnButtonLeftClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnButtonRightClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnCloseBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C65B RID: 50779 RVA: 0x002D1C9A File Offset: 0x002CFE9A
	public override bool GetLoopAudioEventSwitch()
	{
		return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
	}

	// Token: 0x0600C65C RID: 50780 RVA: 0x002D1CAC File Offset: 0x002CFEAC
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssRankView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssRankView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C65D RID: 50781 RVA: 0x002D1CF0 File Offset: 0x002CFEF0
	private bool CanToggleExecuteChange()
	{
		if (DateTimeOffset.UtcNow.ToUnixTimeMilliseconds() - this.LastChangeToggleTime < 1000L)
		{
			return false;
		}
		this.LastChangeToggleTime = DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
		this.ChangeToggleByRequest();
		return false;
	}

	// Token: 0x0600C65E RID: 50782 RVA: 0x002D1D38 File Offset: 0x002CFF38
	private UniTask ChangeToggleByRequest()
	{
		DangoAbyssRankView.<ChangeToggleByRequest>d__17 <ChangeToggleByRequest>d__;
		<ChangeToggleByRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ChangeToggleByRequest>d__.<>4__this = this;
		<ChangeToggleByRequest>d__.<>1__state = -1;
		<ChangeToggleByRequest>d__.<>t__builder.Start<DangoAbyssRankView.<ChangeToggleByRequest>d__17>(ref <ChangeToggleByRequest>d__);
		return <ChangeToggleByRequest>d__.<>t__builder.Task;
	}

	// Token: 0x0600C65F RID: 50783 RVA: 0x002D1D7B File Offset: 0x002CFF7B
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x0600C660 RID: 50784 RVA: 0x002D1D84 File Offset: 0x002CFF84
	private UniTask InitOwnRankItem()
	{
		DangoAbyssRankView.<InitOwnRankItem>d__19 <InitOwnRankItem>d__;
		<InitOwnRankItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitOwnRankItem>d__.<>4__this = this;
		<InitOwnRankItem>d__.<>1__state = -1;
		<InitOwnRankItem>d__.<>t__builder.Start<DangoAbyssRankView.<InitOwnRankItem>d__19>(ref <InitOwnRankItem>d__);
		return <InitOwnRankItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C661 RID: 50785 RVA: 0x002D1DC7 File Offset: 0x002CFFC7
	private void InitRankScroll()
	{
		this.RankScroll = new LoopScrollView<DangoAbyssRankItem, DangoRankItemData>(base.GetLoopScrollViewComponent(3), base.GetItem(4).GetOwner() as AUIBaseActor, new Func<DangoAbyssRankItem>(this.InitRankItem), false);
	}

	// Token: 0x0600C662 RID: 50786 RVA: 0x002D1DF9 File Offset: 0x002CFFF9
	private DangoAbyssRankItem InitRankItem()
	{
		return new DangoAbyssRankItem(false);
	}

	// Token: 0x0600C663 RID: 50787 RVA: 0x002D1E01 File Offset: 0x002D0001
	private void OnSingleRankTabToggleClick(EToggleState toggleState)
	{
		this.CurrentMode = ERankMode.Single;
		this.RefreshToggleByCurrentMode();
		this.RefreshRankLayout(false, null);
	}

	// Token: 0x0600C664 RID: 50788 RVA: 0x002D1E19 File Offset: 0x002D0019
	private void OnOnlineRankTabToggleClick(EToggleState toggleState)
	{
		this.CurrentMode = ERankMode.Online;
		this.RefreshToggleByCurrentMode();
		this.RefreshRankLayout(this.CurrentMode == ERankMode.Online, null);
	}

	// Token: 0x0600C665 RID: 50789 RVA: 0x002D1E3C File Offset: 0x002D003C
	private void RefreshToggleByCurrentMode()
	{
		EToggleState state = (this.CurrentMode == ERankMode.Single) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(state, false, false, false);
		}
		EToggleState state2 = (this.CurrentMode == ERankMode.Online) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(1);
		if (extendToggle2 == null)
		{
			return;
		}
		extendToggle2.SetToggleState(state2, false, false, false);
	}

	// Token: 0x0600C666 RID: 50790 RVA: 0x002D1E94 File Offset: 0x002D0094
	private void OnButtonLeftClick()
	{
		this.CurrentPage = Math.Max(this.CurrentPage - 1, 0);
		this.RefreshButtonState();
		this.RefreshLevelText();
		this.RefreshRankLayout(this.CurrentMode == ERankMode.Online, delegate
		{
			UUIInturnAnimController attributeTurnAniComponentL = this.AttributeTurnAniComponentL;
			if (attributeTurnAniComponentL == null)
			{
				return;
			}
			attributeTurnAniComponentL.Play("", -1, false);
		});
		this.RefreshAnonymousToggle();
	}

	// Token: 0x0600C667 RID: 50791 RVA: 0x002D1EE4 File Offset: 0x002D00E4
	private void OnButtonRightClick()
	{
		this.CurrentPage = Math.Min(this.CurrentPage + 1, this.MaxPage);
		this.RefreshButtonState();
		this.RefreshLevelText();
		this.RefreshRankLayout(this.CurrentMode == ERankMode.Online, delegate
		{
			UUIInturnAnimController attributeTurnAniComponentR = this.AttributeTurnAniComponentR;
			if (attributeTurnAniComponentR == null)
			{
				return;
			}
			attributeTurnAniComponentR.Play("", -1, false);
		});
		this.RefreshAnonymousToggle();
	}

	// Token: 0x0600C668 RID: 50792 RVA: 0x002D1F38 File Offset: 0x002D0138
	private void RefreshButtonState()
	{
		bool uiactive = this.CurrentPage > 0;
		UUIButtonComponent button = base.GetButton(5);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(uiactive);
		}
		bool uiactive2 = this.CurrentPage < this.MaxPage;
		UUIButtonComponent button2 = base.GetButton(6);
		if (button2 == null)
		{
			return;
		}
		button2.RootUIComp.Get().SetUIActive(uiactive2);
	}

	// Token: 0x0600C669 RID: 50793 RVA: 0x002D1FA0 File Offset: 0x002D01A0
	protected override void OnBeforeShow()
	{
		this.OpenData = (this.OpenParam as DangoAbyssRankData);
		this.ChallengeRankData = DangoAbyssModel.Instance.GetChallengeRankInfo();
		this.MaxPage = this.OpenData.DangoAbyssData.Length - 1;
		int num = this.OpenData.DangoAbyssData.Length;
		for (int i = 0; i < num; i++)
		{
			AbyssInst? abyssInst;
			int? num2 = (this.OpenData.DangoAbyssData[i].GetConfig() != null) ? new int?(abyssInst.GetValueOrDefault().Id) : null;
			int openChallengeId = this.OpenData.OpenChallengeId;
			if (num2.GetValueOrDefault() == openChallengeId & num2 != null)
			{
				this.CurrentPage = i;
				break;
			}
		}
		this.InitMode();
		this.RefreshRankLayout(this.CurrentMode == ERankMode.Online, null);
		this.RefreshLevelText();
		this.RefreshButtonState();
		this.RefreshAnonymousToggle();
	}

	// Token: 0x0600C66A RID: 50794 RVA: 0x002D2090 File Offset: 0x002D0290
	private void RefreshAnonymousToggle()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(9);
		int id = this.OpenData.DangoAbyssData[this.CurrentPage].GetConfig().Value.Id;
		bool challengeAnonymousNameState = DangoAbyssModel.Instance.GetChallengeAnonymousNameState(id);
		extendToggle.SetToggleStateForce((!challengeAnonymousNameState) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600C66B RID: 50795 RVA: 0x002D20E8 File Offset: 0x002D02E8
	private void InitMode()
	{
		int id = this.OpenData.DangoAbyssData[this.CurrentPage].GetConfig().Value.Id;
		AbyssRankChallengeInfo challengeRankData = this.ChallengeRankData;
		if (challengeRankData != null)
		{
			challengeRankData.RefreshAllPassDataRank(id);
		}
		this.CurrentMode = (this.ChallengeRankData.IsOwnSingleBestScore(id) ? ERankMode.Single : ERankMode.Online);
		this.RefreshToggleByCurrentMode();
	}

	// Token: 0x0600C66C RID: 50796 RVA: 0x002D2150 File Offset: 0x002D0350
	private void RefreshLevelText()
	{
		string title = this.OpenData.DangoAbyssData[this.CurrentPage].GetConfig().Value.Title;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), title, Array.Empty<object>());
	}

	// Token: 0x0600C66D RID: 50797 RVA: 0x002D219C File Offset: 0x002D039C
	[NullableContext(2)]
	private UniTask RefreshRankLayout(bool onlineState, Action finishCall = null)
	{
		DangoAbyssRankView.<RefreshRankLayout>d__32 <RefreshRankLayout>d__;
		<RefreshRankLayout>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRankLayout>d__.<>4__this = this;
		<RefreshRankLayout>d__.onlineState = onlineState;
		<RefreshRankLayout>d__.finishCall = finishCall;
		<RefreshRankLayout>d__.<>1__state = -1;
		<RefreshRankLayout>d__.<>t__builder.Start<DangoAbyssRankView.<RefreshRankLayout>d__32>(ref <RefreshRankLayout>d__);
		return <RefreshRankLayout>d__.<>t__builder.Task;
	}

	// Token: 0x04005B69 RID: 23401
	private const int CD = 1000;

	// Token: 0x04005B6A RID: 23402
	private DangoAbyssRankData OpenData;

	// Token: 0x04005B6B RID: 23403
	[Nullable(2)]
	private AbyssRankChallengeInfo ChallengeRankData;

	// Token: 0x04005B6C RID: 23404
	private ERankMode CurrentMode;

	// Token: 0x04005B6D RID: 23405
	private int CurrentPage;

	// Token: 0x04005B6E RID: 23406
	private int MaxPage;

	// Token: 0x04005B6F RID: 23407
	private LoopScrollView<DangoAbyssRankItem, DangoRankItemData> RankScroll;

	// Token: 0x04005B70 RID: 23408
	private DangoAbyssRankItem OwnRankItem;

	// Token: 0x04005B71 RID: 23409
	private long LastChangeToggleTime;

	// Token: 0x04005B72 RID: 23410
	[Nullable(2)]
	private UUIInturnAnimController AttributeTurnAniComponentR;

	// Token: 0x04005B73 RID: 23411
	[Nullable(2)]
	private UUIInturnAnimController AttributeTurnAniComponentL;

	// Token: 0x02007F9B RID: 32667
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04029A9E RID: 170654
		public const int SingleRankTabToggle = 0;

		// Token: 0x04029A9F RID: 170655
		public const int OnlineRankTabToggle = 1;

		// Token: 0x04029AA0 RID: 170656
		public const int LevelText = 2;

		// Token: 0x04029AA1 RID: 170657
		public const int RankScroller = 3;

		// Token: 0x04029AA2 RID: 170658
		public const int RankScrollerItem = 4;

		// Token: 0x04029AA3 RID: 170659
		public const int ButtonLeft = 5;

		// Token: 0x04029AA4 RID: 170660
		public const int ButtonRight = 6;

		// Token: 0x04029AA5 RID: 170661
		public const int CloseBtn = 7;

		// Token: 0x04029AA6 RID: 170662
		public const int SelfRankItem = 8;

		// Token: 0x04029AA7 RID: 170663
		public const int AnonymousToggle = 9;

		// Token: 0x04029AA8 RID: 170664
		public const int TurnAnimationItem = 10;
	}
}
