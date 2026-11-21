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

// Token: 0x020009C1 RID: 2497
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ActivitySpring25Controller : ActivityControllerBase
{
	// Token: 0x06006D8B RID: 28043 RVA: 0x0021DF20 File Offset: 0x0021C120
	protected override void OnOpenView(ActivityBaseData data)
	{
	}

	// Token: 0x06006D8C RID: 28044 RVA: 0x0021DF22 File Offset: 0x0021C122
	protected override string OnGetActivityResource(ActivityBaseData data)
	{
		return "UiItem_SpringAGuide";
	}

	// Token: 0x06006D8D RID: 28045 RVA: 0x0021DF29 File Offset: 0x0021C129
	protected override ActivitySubViewBase OnCreateSubPageComponent(ActivityBaseData data)
	{
		return new ActivitySpring25SubView();
	}

	// Token: 0x06006D8E RID: 28046 RVA: 0x0021DF30 File Offset: 0x0021C130
	protected override ActivityBaseData OnCreateActivityData(ActivityData data)
	{
		return Spring25Model.Instance.ActivityData;
	}

	// Token: 0x06006D8F RID: 28047 RVA: 0x0021DF3C File Offset: 0x0021C13C
	protected override bool OnGetIsOpeningActivityRelativeView()
	{
		return UiManager.Instance.IsViewOpen(EUiViewName.Spring25MainView) || UiManager.Instance.IsViewOpen(EUiViewName.Spring25InfoView) || UiManager.Instance.IsViewOpen(EUiViewName.Spring25DialogueView) || UiManager.Instance.IsViewOpen(EUiViewName.Spring25EnvelopeView) || UiManager.Instance.IsViewOpen(EUiViewName.Spring25LetterListView);
	}

	// Token: 0x06006D90 RID: 28048 RVA: 0x0021DF9E File Offset: 0x0021C19E
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnCloseRewardView, new Action(this.HandleOnCloseRewardView));
	}

	// Token: 0x06006D91 RID: 28049 RVA: 0x0021DFBC File Offset: 0x0021C1BC
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnCloseRewardView, new Action(this.HandleOnCloseRewardView));
	}

	// Token: 0x06006D92 RID: 28050 RVA: 0x0021DFDC File Offset: 0x0021C1DC
	[NullableContext(0)]
	public UniTask<bool> RequestSpringSignDrawRoleRequest()
	{
		ActivitySpring25Controller.<RequestSpringSignDrawRoleRequest>d__8 <RequestSpringSignDrawRoleRequest>d__;
		<RequestSpringSignDrawRoleRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<RequestSpringSignDrawRoleRequest>d__.<>1__state = -1;
		<RequestSpringSignDrawRoleRequest>d__.<>t__builder.Start<ActivitySpring25Controller.<RequestSpringSignDrawRoleRequest>d__8>(ref <RequestSpringSignDrawRoleRequest>d__);
		return <RequestSpringSignDrawRoleRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06006D93 RID: 28051 RVA: 0x0021E018 File Offset: 0x0021C218
	public UniTask RequestSpringSignDrawRewardRequest(int id)
	{
		ActivitySpring25Controller.<RequestSpringSignDrawRewardRequest>d__9 <RequestSpringSignDrawRewardRequest>d__;
		<RequestSpringSignDrawRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestSpringSignDrawRewardRequest>d__.id = id;
		<RequestSpringSignDrawRewardRequest>d__.<>1__state = -1;
		<RequestSpringSignDrawRewardRequest>d__.<>t__builder.Start<ActivitySpring25Controller.<RequestSpringSignDrawRewardRequest>d__9>(ref <RequestSpringSignDrawRewardRequest>d__);
		return <RequestSpringSignDrawRewardRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06006D94 RID: 28052 RVA: 0x0021E05C File Offset: 0x0021C25C
	private UniTask RequestSpringSignSkinRewardRequest()
	{
		ActivitySpring25Controller.<RequestSpringSignSkinRewardRequest>d__10 <RequestSpringSignSkinRewardRequest>d__;
		<RequestSpringSignSkinRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestSpringSignSkinRewardRequest>d__.<>1__state = -1;
		<RequestSpringSignSkinRewardRequest>d__.<>t__builder.Start<ActivitySpring25Controller.<RequestSpringSignSkinRewardRequest>d__10>(ref <RequestSpringSignSkinRewardRequest>d__);
		return <RequestSpringSignSkinRewardRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06006D95 RID: 28053 RVA: 0x0021E098 File Offset: 0x0021C298
	private UniTask RequestSpringSignPhotoRewardRequest()
	{
		ActivitySpring25Controller.<RequestSpringSignPhotoRewardRequest>d__11 <RequestSpringSignPhotoRewardRequest>d__;
		<RequestSpringSignPhotoRewardRequest>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestSpringSignPhotoRewardRequest>d__.<>1__state = -1;
		<RequestSpringSignPhotoRewardRequest>d__.<>t__builder.Start<ActivitySpring25Controller.<RequestSpringSignPhotoRewardRequest>d__11>(ref <RequestSpringSignPhotoRewardRequest>d__);
		return <RequestSpringSignPhotoRewardRequest>d__.<>t__builder.Task;
	}

	// Token: 0x06006D96 RID: 28054 RVA: 0x0021E0D3 File Offset: 0x0021C2D3
	public void HandleConfirmClickInActivitySubView()
	{
		UiManager.Instance.OpenView(EUiViewName.Spring25MainView, Spring25Model.Instance.BuildMainViewData(false), null);
	}

	// Token: 0x06006D97 RID: 28055 RVA: 0x0021E0F0 File Offset: 0x0021C2F0
	public UniTask HandleInviteClickInMainView()
	{
		ActivitySpring25Controller.<HandleInviteClickInMainView>d__13 <HandleInviteClickInMainView>d__;
		<HandleInviteClickInMainView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HandleInviteClickInMainView>d__.<>4__this = this;
		<HandleInviteClickInMainView>d__.<>1__state = -1;
		<HandleInviteClickInMainView>d__.<>t__builder.Start<ActivitySpring25Controller.<HandleInviteClickInMainView>d__13>(ref <HandleInviteClickInMainView>d__);
		return <HandleInviteClickInMainView>d__.<>t__builder.Task;
	}

	// Token: 0x06006D98 RID: 28056 RVA: 0x0021E133 File Offset: 0x0021C333
	public void HandleGiftClickInMainView()
	{
		UiManager.Instance.OpenView(EUiViewName.Spring25InfoView, Spring25Model.Instance.BuildInfoViewData(), null);
	}

	// Token: 0x06006D99 RID: 28057 RVA: 0x0021E150 File Offset: 0x0021C350
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

	// Token: 0x06006D9A RID: 28058 RVA: 0x0021E1A2 File Offset: 0x0021C3A2
	public void HandleResetCurrentSignId()
	{
		Spring25Model.Instance.ResetCurrentSignId();
	}

	// Token: 0x06006D9B RID: 28059 RVA: 0x0021E1B0 File Offset: 0x0021C3B0
	public void HandleOpenOpeningDialogViewInMainView()
	{
		LocalStorage.SetPlayer<bool>(ELocalStoragePlayerKey.Spring25FirstEnter, false);
		Spring25DialogueViewData param = Spring25Model.Instance.BuildStartDialogueViewData();
		UiManager.Instance.OpenView(EUiViewName.Spring25DialogueView, param, null);
	}

	// Token: 0x06006D9C RID: 28060 RVA: 0x0021E1E2 File Offset: 0x0021C3E2
	public void HandleLetterClickInLetterListView(int signId)
	{
		Spring25Model.Instance.TrySetCurrentLetterSignId(signId);
	}

	// Token: 0x06006D9D RID: 28061 RVA: 0x0021E1F0 File Offset: 0x0021C3F0
	public void HandleHelpClick()
	{
		int helpId = Spring25Model.Instance.HelpId;
		HelpController.Instance.OpenHelpById(helpId);
	}

	// Token: 0x06006D9E RID: 28062 RVA: 0x0021E213 File Offset: 0x0021C413
	public void HandleConfirmClickInDialogueView()
	{
		UiManager.Instance.CloseView(EUiViewName.Spring25DialogueView, null);
		if (Spring25Model.Instance.NeedOpenEnvelopeView)
		{
			UiManager.Instance.OpenView(EUiViewName.Spring25EnvelopeView, Spring25Model.Instance.BuildEnvelopeViewData(), null);
		}
	}

	// Token: 0x06006D9F RID: 28063 RVA: 0x0021E24C File Offset: 0x0021C44C
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

	// Token: 0x06006DA0 RID: 28064 RVA: 0x0021E299 File Offset: 0x0021C499
	public void HandleRequestRewardSkin()
	{
		if (Spring25Model.Instance.IsSkinRewarded)
		{
			return;
		}
		this.RequestSpringSignSkinRewardRequest();
	}

	// Token: 0x06006DA1 RID: 28065 RVA: 0x0021E2B0 File Offset: 0x0021C4B0
	public void HandleWhenUnlockAnimEnd()
	{
		Spring25DialogueViewData spring25DialogueViewData = Spring25Model.Instance.BuildDialogueViewData();
		if (spring25DialogueViewData != null)
		{
			UiManager.Instance.OpenView(EUiViewName.Spring25DialogueView, spring25DialogueViewData, null);
		}
	}

	// Token: 0x06006DA2 RID: 28066 RVA: 0x0021E2DC File Offset: 0x0021C4DC
	public UniTask HandleTryOpenShareViewAsync()
	{
		ActivitySpring25Controller.<HandleTryOpenShareViewAsync>d__24 <HandleTryOpenShareViewAsync>d__;
		<HandleTryOpenShareViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<HandleTryOpenShareViewAsync>d__.<>4__this = this;
		<HandleTryOpenShareViewAsync>d__.<>1__state = -1;
		<HandleTryOpenShareViewAsync>d__.<>t__builder.Start<ActivitySpring25Controller.<HandleTryOpenShareViewAsync>d__24>(ref <HandleTryOpenShareViewAsync>d__);
		return <HandleTryOpenShareViewAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006DA3 RID: 28067 RVA: 0x0021E31F File Offset: 0x0021C51F
	private void HandleOnCloseRewardView()
	{
		CustomPromise waitForRewardClosePromise = this.WaitForRewardClosePromise;
		if (waitForRewardClosePromise == null)
		{
			return;
		}
		waitForRewardClosePromise.SetResult();
	}

	// Token: 0x17000D51 RID: 3409
	// (get) Token: 0x06006DA4 RID: 28068 RVA: 0x0021E331 File Offset: 0x0021C531
	public static ActivitySpring25Controller Instance
	{
		get
		{
			return ActivitySpring25Controller._Instance;
		}
	}

	// Token: 0x06006DA5 RID: 28069 RVA: 0x0021E338 File Offset: 0x0021C538
	public static ActivitySpring25Controller GetOrCreateInstance()
	{
		if (ActivitySpring25Controller._Instance == null)
		{
			ActivitySpring25Controller.CreateInstance();
		}
		return ActivitySpring25Controller._Instance;
	}

	// Token: 0x06006DA6 RID: 28070 RVA: 0x0021E34C File Offset: 0x0021C54C
	public static bool CreateInstance()
	{
		if (ActivitySpring25Controller._Instance != null)
		{
			return true;
		}
		ActivitySpring25Controller._Instance = new ActivitySpring25Controller();
		return true;
	}

	// Token: 0x06006DA7 RID: 28071 RVA: 0x0021E362 File Offset: 0x0021C562
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006DA8 RID: 28072 RVA: 0x0021E364 File Offset: 0x0021C564
	public static void ResetStaticDefaultValue()
	{
		ActivitySpring25Controller._Instance = null;
	}

	// Token: 0x06006DA9 RID: 28073 RVA: 0x0021E36C File Offset: 0x0021C56C
	static ActivitySpring25Controller()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActivitySpring25Controller.CreateStaticDefaultValue), new Action(ActivitySpring25Controller.ResetStaticDefaultValue));
	}

	// Token: 0x04004420 RID: 17440
	[Nullable(2)]
	private CustomPromise WaitForRewardClosePromise;

	// Token: 0x04004421 RID: 17441
	[Nullable(2)]
	private static ActivitySpring25Controller _Instance;
}
