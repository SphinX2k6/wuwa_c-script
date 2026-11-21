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

// Token: 0x02000F14 RID: 3860
[NullableContext(1)]
[Nullable(0)]
public class DangoAbyssRankView : UiViewBase
{
	// Token: 0x06009A69 RID: 39529 RVA: 0x002DCB44 File Offset: 0x002DAD44
	public DangoAbyssRankView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06009A6A RID: 39530 RVA: 0x002DCB50 File Offset: 0x002DAD50
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

	// Token: 0x06009A6B RID: 39531 RVA: 0x002DCDAE File Offset: 0x002DAFAE
	public override bool GetBgmSwitch()
	{
		return !DangoAbyssModel.Instance.CheckIfInSmallWorldInstance();
	}

	// Token: 0x06009A6C RID: 39532 RVA: 0x002DCDC0 File Offset: 0x002DAFC0
	protected override UniTask OnBeforeStartAsync()
	{
		DangoAbyssRankView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssRankView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009A6D RID: 39533 RVA: 0x002DCE04 File Offset: 0x002DB004
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

	// Token: 0x06009A6E RID: 39534 RVA: 0x002DCE4C File Offset: 0x002DB04C
	private UniTask ChangeToggleByRequest()
	{
		DangoAbyssRankView.<ChangeToggleByRequest>d__17 <ChangeToggleByRequest>d__;
		<ChangeToggleByRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ChangeToggleByRequest>d__.<>4__this = this;
		<ChangeToggleByRequest>d__.<>1__state = -1;
		<ChangeToggleByRequest>d__.<>t__builder.Start<DangoAbyssRankView.<ChangeToggleByRequest>d__17>(ref <ChangeToggleByRequest>d__);
		return <ChangeToggleByRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06009A6F RID: 39535 RVA: 0x002DCE8F File Offset: 0x002DB08F
	private void OnCloseBtnClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06009A70 RID: 39536 RVA: 0x002DCE98 File Offset: 0x002DB098
	private UniTask InitOwnRankItem()
	{
		DangoAbyssRankView.<InitOwnRankItem>d__19 <InitOwnRankItem>d__;
		<InitOwnRankItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitOwnRankItem>d__.<>4__this = this;
		<InitOwnRankItem>d__.<>1__state = -1;
		<InitOwnRankItem>d__.<>t__builder.Start<DangoAbyssRankView.<InitOwnRankItem>d__19>(ref <InitOwnRankItem>d__);
		return <InitOwnRankItem>d__.<>t__builder.Task;
	}

	// Token: 0x06009A71 RID: 39537 RVA: 0x002DCEDB File Offset: 0x002DB0DB
	private void InitRankScroll()
	{
		this.RankScroll = new LoopScrollView<DangoAbyssRankItem, DangoRankItemData>(base.GetLoopScrollViewComponent(3), base.GetItem(4).GetOwner() as AUIBaseActor, new Func<DangoAbyssRankItem>(this.InitRankItem), false);
	}

	// Token: 0x06009A72 RID: 39538 RVA: 0x002DCF0D File Offset: 0x002DB10D
	private DangoAbyssRankItem InitRankItem()
	{
		return new DangoAbyssRankItem(false);
	}

	// Token: 0x06009A73 RID: 39539 RVA: 0x002DCF15 File Offset: 0x002DB115
	private void OnSingleRankTabToggleClick(EToggleState toggleState)
	{
		this.CurrentMode = ERankMode.Single;
		this.RefreshToggleByCurrentMode();
		this.RefreshRankLayout(false, null);
	}

	// Token: 0x06009A74 RID: 39540 RVA: 0x002DCF2D File Offset: 0x002DB12D
	private void OnOnlineRankTabToggleClick(EToggleState toggleState)
	{
		this.CurrentMode = ERankMode.Online;
		this.RefreshToggleByCurrentMode();
		this.RefreshRankLayout(this.CurrentMode == ERankMode.Online, null);
	}

	// Token: 0x06009A75 RID: 39541 RVA: 0x002DCF50 File Offset: 0x002DB150
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

	// Token: 0x06009A76 RID: 39542 RVA: 0x002DCFA8 File Offset: 0x002DB1A8
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

	// Token: 0x06009A77 RID: 39543 RVA: 0x002DCFF8 File Offset: 0x002DB1F8
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

	// Token: 0x06009A78 RID: 39544 RVA: 0x002DD04C File Offset: 0x002DB24C
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

	// Token: 0x06009A79 RID: 39545 RVA: 0x002DD0B4 File Offset: 0x002DB2B4
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

	// Token: 0x06009A7A RID: 39546 RVA: 0x002DD1A4 File Offset: 0x002DB3A4
	private void RefreshAnonymousToggle()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(9);
		int id = this.OpenData.DangoAbyssData[this.CurrentPage].GetConfig().Value.Id;
		bool challengeAnonymousNameState = DangoAbyssModel.Instance.GetChallengeAnonymousNameState(id);
		extendToggle.SetToggleStateForce((!challengeAnonymousNameState) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06009A7B RID: 39547 RVA: 0x002DD1FC File Offset: 0x002DB3FC
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

	// Token: 0x06009A7C RID: 39548 RVA: 0x002DD264 File Offset: 0x002DB464
	private void RefreshLevelText()
	{
		string title = this.OpenData.DangoAbyssData[this.CurrentPage].GetConfig().Value.Title;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), title, Array.Empty<object>());
	}

	// Token: 0x06009A7D RID: 39549 RVA: 0x002DD2B0 File Offset: 0x002DB4B0
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

	// Token: 0x04005C38 RID: 23608
	private const int CD = 1000;

	// Token: 0x04005C39 RID: 23609
	private DangoAbyssRankData OpenData;

	// Token: 0x04005C3A RID: 23610
	[Nullable(2)]
	private AbyssRankChallengeInfo ChallengeRankData;

	// Token: 0x04005C3B RID: 23611
	private ERankMode CurrentMode;

	// Token: 0x04005C3C RID: 23612
	private int CurrentPage;

	// Token: 0x04005C3D RID: 23613
	private int MaxPage;

	// Token: 0x04005C3E RID: 23614
	private LoopScrollView<DangoAbyssRankItem, DangoRankItemData> RankScroll;

	// Token: 0x04005C3F RID: 23615
	private DangoAbyssRankItem OwnRankItem;

	// Token: 0x04005C40 RID: 23616
	private long LastChangeToggleTime;

	// Token: 0x04005C41 RID: 23617
	[Nullable(2)]
	private UUIInturnAnimController AttributeTurnAniComponentR;

	// Token: 0x04005C42 RID: 23618
	[Nullable(2)]
	private UUIInturnAnimController AttributeTurnAniComponentL;

	// Token: 0x0200712A RID: 28970
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04024DDB RID: 151003
		public const int SingleRankTabToggle = 0;

		// Token: 0x04024DDC RID: 151004
		public const int OnlineRankTabToggle = 1;

		// Token: 0x04024DDD RID: 151005
		public const int LevelText = 2;

		// Token: 0x04024DDE RID: 151006
		public const int RankScroller = 3;

		// Token: 0x04024DDF RID: 151007
		public const int RankScrollerItem = 4;

		// Token: 0x04024DE0 RID: 151008
		public const int ButtonLeft = 5;

		// Token: 0x04024DE1 RID: 151009
		public const int ButtonRight = 6;

		// Token: 0x04024DE2 RID: 151010
		public const int CloseBtn = 7;

		// Token: 0x04024DE3 RID: 151011
		public const int SelfRankItem = 8;

		// Token: 0x04024DE4 RID: 151012
		public const int AnonymousToggle = 9;

		// Token: 0x04024DE5 RID: 151013
		public const int TurnAnimationItem = 10;
	}
}
