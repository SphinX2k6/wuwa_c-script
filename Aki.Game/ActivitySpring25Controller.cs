using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Activity.ActivityContent.Spring25;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

// Token: 0x02001509 RID: 5385
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivitySpring25Controller : ActivityControllerBase
{
	// Token: 0x060099AD RID: 39341 RVA: 0x00214168 File Offset: 0x00212368
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x060099AE RID: 39342 RVA: 0x0021416A File Offset: 0x0021236A
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_SpringAGuide";
	}

	// Token: 0x060099AF RID: 39343 RVA: 0x00214171 File Offset: 0x00212371
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySpring25SubView();
	}

	// Token: 0x060099B0 RID: 39344 RVA: 0x00214178 File Offset: 0x00212378
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return Spring25Model.Instance.ActivityData;
	}

	// Token: 0x060099B1 RID: 39345 RVA: 0x00214184 File Offset: 0x00212384
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return UiManager.Instance.IsViewOpen(EUiViewName.Spring25MainView) || UiManager.Instance.IsViewOpen(EUiViewName.Spring25InfoView) || UiManager.Instance.IsViewOpen(EUiViewName.Spring25DialogueView) || UiManager.Instance.IsViewOpen(EUiViewName.Spring25EnvelopeView) || UiManager.Instance.IsViewOpen(EUiViewName.Spring25LetterListView);
	}

	// Token: 0x060099B2 RID: 39346 RVA: 0x002141E6 File Offset: 0x002123E6
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnCloseRewardView, new Action(this.HandleOnCloseRewardView));
	}

	// Token: 0x060099B3 RID: 39347 RVA: 0x00214204 File Offset: 0x00212404
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnCloseRewardView, new Action(this.HandleOnCloseRewardView));
	}

	// Token: 0x060099B4 RID: 39348 RVA: 0x00214224 File Offset: 0x00212424
	[NullableContext(0)]
	public UniTask<bool> RequestSpringSignDrawRoleRequest()
	{
		ActivitySpring25Controller.<RequestSpringSignDrawRoleRequest>d__8 <RequestSpringSignDrawRoleRequest>d__;
		<RequestSpringSignDrawRoleRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestSpringSignDrawRoleRequest>d__.<>1__state = -1;
		<RequestSpringSignDrawRoleRequest>d__.<>t__builder.Start<ActivitySpring25Controller.<RequestSpringSignDrawRoleRequest>d__8>(ref <RequestSpringSignDrawRoleRequest>d__);
		return <RequestSpringSignDrawRoleRequest>d__.<>t__builder.Task;
	}

	// Token: 0x060099B5 RID: 39349 RVA: 0x00214260 File Offset: 0x00212460
	public UniTask RequestSpringSignDrawRewardRequest(int id)
	{
		ActivitySpring25Controller.<RequestSpringSignDrawRewardRequest>d__9 <RequestSpringSignDrawRewardRequest>d__;
		<RequestSpringSignDrawRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestSpringSignDrawRewardRequest>d__.id = id;
		<RequestSpringSignDrawRewardRequest>d__.<>1__state = -1;
		<RequestSpringSignDrawRewardRequest>d__.<>t__builder.Start<ActivitySpring25Controller.<RequestSpringSignDrawRewardRequest>d__9>(ref <RequestSpringSignDrawRewardRequest>d__);
		return <RequestSpringSignDrawRewardRequest>d__.<>t__builder.Task;
	}

	// Token: 0x060099B6 RID: 39350 RVA: 0x002142A4 File Offset: 0x002124A4
	private UniTask RequestSpringSignSkinRewardRequest()
	{
		ActivitySpring25Controller.<RequestSpringSignSkinRewardRequest>d__10 <RequestSpringSignSkinRewardRequest>d__;
		<RequestSpringSignSkinRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestSpringSignSkinRewardRequest>d__.<>1__state = -1;
		<RequestSpringSignSkinRewardRequest>d__.<>t__builder.Start<ActivitySpring25Controller.<RequestSpringSignSkinRewardRequest>d__10>(ref <RequestSpringSignSkinRewardRequest>d__);
		return <RequestSpringSignSkinRewardRequest>d__.<>t__builder.Task;
	}

	// Token: 0x060099B7 RID: 39351 RVA: 0x002142E0 File Offset: 0x002124E0
	private UniTask RequestSpringSignPhotoRewardRequest()
	{
		ActivitySpring25Controller.<RequestSpringSignPhotoRewardRequest>d__11 <RequestSpringSignPhotoRewardRequest>d__;
		<RequestSpringSignPhotoRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestSpringSignPhotoRewardRequest>d__.<>1__state = -1;
		<RequestSpringSignPhotoRewardRequest>d__.<>t__builder.Start<ActivitySpring25Controller.<RequestSpringSignPhotoRewardRequest>d__11>(ref <RequestSpringSignPhotoRewardRequest>d__);
		return <RequestSpringSignPhotoRewardRequest>d__.<>t__builder.Task;
	}

	// Token: 0x060099B8 RID: 39352 RVA: 0x0021431B File Offset: 0x0021251B
	public void HandleConfirmClickInActivitySubView()
	{
		UiManager.Instance.OpenView(EUiViewName.Spring25MainView, Spring25Model.Instance.BuildMainViewData(false), null);
	}

	// Token: 0x060099B9 RID: 39353 RVA: 0x00214338 File Offset: 0x00212538
	public UniTask HandleInviteClickInMainView()
	{
		ActivitySpring25Controller.<HandleInviteClickInMainView>d__13 <HandleInviteClickInMainView>d__;
		<HandleInviteClickInMainView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HandleInviteClickInMainView>d__.<>4__this = this;
		<HandleInviteClickInMainView>d__.<>1__state = -1;
		<HandleInviteClickInMainView>d__.<>t__builder.Start<ActivitySpring25Controller.<HandleInviteClickInMainView>d__13>(ref <HandleInviteClickInMainView>d__);
		return <HandleInviteClickInMainView>d__.<>t__builder.Task;
	}

	// Token: 0x060099BA RID: 39354 RVA: 0x0021437B File Offset: 0x0021257B
	public void HandleGiftClickInMainView()
	{
		UiManager.Instance.OpenView(EUiViewName.Spring25InfoView, Spring25Model.Instance.BuildInfoViewData(), null);
	}

	// Token: 0x060099BB RID: 39355 RVA: 0x00214398 File Offset: 0x00212598
	public void HandleLetterClickInMainView()
	{
		if (Spring25Model.Instance.IsLetterListViewAvailable)
		{
			Spring25Model.Instance.InitLetterSignIdForLetterListView();
			UiManager.Instance.OpenView(EUiViewName.Spring25LetterListView, Spring25Model.Instance.BuildLetterListViewData(), null);
			return;
		}
		ScrollingTipsController.Instance.ShowTipsByTextId("SpringMessage_1", Array.Empty<object>());
	}

	// Token: 0x060099BC RID: 39356 RVA: 0x002143EA File Offset: 0x002125EA
	public void HandleResetCurrentSignId()
	{
		Spring25Model.Instance.ResetCurrentSignId();
	}

	// Token: 0x060099BD RID: 39357 RVA: 0x002143F8 File Offset: 0x002125F8
	public void HandleOpenOpeningDialogViewInMainView()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.Spring25FirstEnter, false);
		Spring25DialogueViewData param = Spring25Model.Instance.BuildStartDialogueViewData();
		UiManager.Instance.OpenView(EUiViewName.Spring25DialogueView, param, null);
	}

	// Token: 0x060099BE RID: 39358 RVA: 0x0021442A File Offset: 0x0021262A
	public void HandleLetterClickInLetterListView(int signId)
	{
		Spring25Model.Instance.TrySetCurrentLetterSignId(signId);
	}

	// Token: 0x060099BF RID: 39359 RVA: 0x00214438 File Offset: 0x00212638
	public void HandleHelpClick()
	{
		int helpId = Spring25Model.Instance.HelpId;
		HelpController.Instance.OpenHelpById(helpId);
	}

	// Token: 0x060099C0 RID: 39360 RVA: 0x0021445B File Offset: 0x0021265B
	public void HandleConfirmClickInDialogueView()
	{
		UiManager.Instance.CloseView(EUiViewName.Spring25DialogueView, null);
		if (Spring25Model.Instance.NeedOpenEnvelopeView)
		{
			UiManager.Instance.OpenView(EUiViewName.Spring25EnvelopeView, Spring25Model.Instance.BuildEnvelopeViewData(), null);
		}
	}

	// Token: 0x060099C1 RID: 39361 RVA: 0x00214494 File Offset: 0x00212694
	public unsafe void HandleOpenSkinPreview()
	{
		RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(81011102);
		if (roleSkinData == null)
		{
			return;
		}
		SkinController instance = SkinController.Instance;
		int num = 1;
		List<RoleSkinData> list = new List<RoleSkinData>(num);
		CollectionsMarshal.SetCount<RoleSkinData>(list, num);
		Span<RoleSkinData> span = CollectionsMarshal.AsSpan<RoleSkinData>(list);
		int index = 0;
		*span[index] = roleSkinData;
		instance.OpenBuyRoleSkinPreviewDetailViewByRoleSkinData(list);
	}

	// Token: 0x060099C2 RID: 39362 RVA: 0x002144E1 File Offset: 0x002126E1
	public void HandleRequestRewardSkin()
	{
		if (Spring25Model.Instance.IsSkinRewarded)
		{
			return;
		}
		this.RequestSpringSignSkinRewardRequest();
	}

	// Token: 0x060099C3 RID: 39363 RVA: 0x002144F8 File Offset: 0x002126F8
	public void HandleWhenUnlockAnimEnd()
	{
		Spring25DialogueViewData spring25DialogueViewData = Spring25Model.Instance.BuildDialogueViewData();
		if (spring25DialogueViewData != null)
		{
			UiManager.Instance.OpenView(EUiViewName.Spring25DialogueView, spring25DialogueViewData, null);
		}
	}

	// Token: 0x060099C4 RID: 39364 RVA: 0x00214524 File Offset: 0x00212724
	public UniTask HandleTryOpenShareViewAsync()
	{
		ActivitySpring25Controller.<HandleTryOpenShareViewAsync>d__24 <HandleTryOpenShareViewAsync>d__;
		<HandleTryOpenShareViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HandleTryOpenShareViewAsync>d__.<>4__this = this;
		<HandleTryOpenShareViewAsync>d__.<>1__state = -1;
		<HandleTryOpenShareViewAsync>d__.<>t__builder.Start<ActivitySpring25Controller.<HandleTryOpenShareViewAsync>d__24>(ref <HandleTryOpenShareViewAsync>d__);
		return <HandleTryOpenShareViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060099C5 RID: 39365 RVA: 0x00214567 File Offset: 0x00212767
	private void HandleOnCloseRewardView()
	{
		CustomPromise waitForRewardClosePromise = this.WaitForRewardClosePromise;
		if (waitForRewardClosePromise == null)
		{
			return;
		}
		waitForRewardClosePromise.SetResult();
	}

	// Token: 0x17000D30 RID: 3376
	// (get) Token: 0x060099C6 RID: 39366 RVA: 0x00214579 File Offset: 0x00212779
	public static ActivitySpring25Controller Instance
	{
		get
		{
			return ActivitySpring25Controller._Instance;
		}
	}

	// Token: 0x060099C7 RID: 39367 RVA: 0x00214580 File Offset: 0x00212780
	public static ActivitySpring25Controller GetOrCreateInstance()
	{
		if (ActivitySpring25Controller._Instance == null)
		{
			ActivitySpring25Controller.CreateInstance();
		}
		return ActivitySpring25Controller._Instance;
	}

	// Token: 0x060099C8 RID: 39368 RVA: 0x00214594 File Offset: 0x00212794
	public static bool CreateInstance()
	{
		if (ActivitySpring25Controller._Instance != null)
		{
			return true;
		}
		ActivitySpring25Controller._Instance = new ActivitySpring25Controller();
		return true;
	}

	// Token: 0x060099C9 RID: 39369 RVA: 0x002145AA File Offset: 0x002127AA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060099CA RID: 39370 RVA: 0x002145AC File Offset: 0x002127AC
	public static void ResetStaticDefaultValue()
	{
		ActivitySpring25Controller._Instance = null;
	}

	// Token: 0x060099CB RID: 39371 RVA: 0x002145B4 File Offset: 0x002127B4
	static ActivitySpring25Controller()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivitySpring25Controller.CreateStaticDefaultValue), new Action(ActivitySpring25Controller.ResetStaticDefaultValue));
	}

	// Token: 0x0400437A RID: 17274
	[Nullable(2)]
	private CustomPromise WaitForRewardClosePromise;

	// Token: 0x0400437B RID: 17275
	[Nullable(2)]
	private static ActivitySpring25Controller _Instance;
}
