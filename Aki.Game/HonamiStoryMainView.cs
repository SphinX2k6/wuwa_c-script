using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200139A RID: 5018
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryMainView : UiViewBase, IUiViewCameraBehavior
{
	// Token: 0x0600C6EC RID: 50924 RVA: 0x003B3D81 File Offset: 0x003B1F81
	public HonamiStoryMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C6ED RID: 50925 RVA: 0x003B3DAC File Offset: 0x003B1FAC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 19;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnBtnTalk));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(14, new Action<EToggleState>(this.OnHideToggle));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C6EE RID: 50926 RVA: 0x003B40B4 File Offset: 0x003B22B4
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryMainView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryMainView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C6EF RID: 50927 RVA: 0x003B40F8 File Offset: 0x003B22F8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnUiBlendInTimeCameraFinished, new Action<UiCameraHandleData>(this.OnCameraFinish));
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Add<bool>(EEventName.OnHonamiStorySetVisible, new Action<bool>(this.OnHonamiStorySetVisible));
	}

	// Token: 0x0600C6F0 RID: 50928 RVA: 0x003B415C File Offset: 0x003B235C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnUiBlendInTimeCameraFinished, new Action<UiCameraHandleData>(this.OnCameraFinish));
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Remove(EEventName.OnHonamiStorySetVisible, new Action<bool>(this.OnHonamiStorySetVisible));
	}

	// Token: 0x0600C6F1 RID: 50929 RVA: 0x003B41C0 File Offset: 0x003B23C0
	protected override void OnBeforeShow()
	{
		UiCameraModel.Instance.DisablePlayerActor();
		if (!HonamiStoryUtil.CheckInMainQuest())
		{
			this.RefreshTimeText();
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				this.RefreshTimeText();
			}, (float)TimeUtil.Instance.InverseMillisecond, 1f, null, null, true);
		}
		bool flag = this.CheckIsShowPanel();
		if (flag)
		{
			this.QuestPanel.Refresh(false);
			this.ProfitPanel.Refresh(true);
		}
		this.QuestPanel.SetActive(flag);
		this.ProfitPanel.SetActive(flag);
		this.RefreshNormalButtonStates();
		this.ButtonGoItem.RefreshButtonState();
		this.RefreshTalkButton(false);
		this.RefreshPermanentScore();
		this.IsHideAllUi = false;
		this.RefreshAllUiState(!this.IsHideAllUi);
	}

	// Token: 0x0600C6F2 RID: 50930 RVA: 0x003B4281 File Offset: 0x003B2481
	protected override void OnStart()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.AddSequenceFinishEvent("ShowView", new Action<string>(this.OnShowUiSequenceFinish), false);
	}

	// Token: 0x0600C6F3 RID: 50931 RVA: 0x003B42A5 File Offset: 0x003B24A5
	protected override void OnBeforeHide()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
		this.ResetHasClickedAnyButton();
	}

	// Token: 0x0600C6F4 RID: 50932 RVA: 0x003B42D0 File Offset: 0x003B24D0
	protected override void OnBeforeDestroy()
	{
		foreach (HonamiStoryMainButtonItem honamiStoryMainButtonItem in this.ButtonItems.Values)
		{
			honamiStoryMainButtonItem.Clear();
		}
		this.ButtonItems.Clear();
		this.ButtonConfigs = new List<IHonamiStoryMainButtonConfig>();
	}

	// Token: 0x0600C6F5 RID: 50933 RVA: 0x003B433C File Offset: 0x003B253C
	protected override void OnAfterDestroy()
	{
		UiCameraModel.Instance.EnablePlayerActor();
	}

	// Token: 0x0600C6F6 RID: 50934 RVA: 0x003B4348 File Offset: 0x003B2548
	private void OnActivitySequenceEmitEvent(string param)
	{
		foreach (HonamiStoryMainButtonItem honamiStoryMainButtonItem in this.ButtonItems.Values)
		{
			if (honamiStoryMainButtonItem.SpecialParamName == param)
			{
				honamiStoryMainButtonItem.SetText();
				honamiStoryMainButtonItem.SetRedDot();
			}
		}
	}

	// Token: 0x0600C6F7 RID: 50935 RVA: 0x003B43B4 File Offset: 0x003B25B4
	private void OnHonamiStorySetVisible(bool _)
	{
		this.RefreshAllUiState(true);
	}

	// Token: 0x0600C6F8 RID: 50936 RVA: 0x003B43BD File Offset: 0x003B25BD
	private void OnCameraFinish(UiCameraHandleData handleData)
	{
		if (handleData.GetViewName() == EUiViewName.HonamiStoryMainView)
		{
			this.RefreshTalkButton(false);
		}
	}

	// Token: 0x0600C6F9 RID: 50937 RVA: 0x003B43DD File Offset: 0x003B25DD
	private void OnShowUiSequenceFinish(string _)
	{
		this.RefreshSpecialButtonsStates();
	}

	// Token: 0x0600C6FA RID: 50938 RVA: 0x003B43E8 File Offset: 0x003B25E8
	public void RefreshSpecialButtonsStates()
	{
		foreach (HonamiStoryMainButtonItem honamiStoryMainButtonItem in this.ButtonItems.Values)
		{
			if (honamiStoryMainButtonItem.CheckIsSpecialSet())
			{
				honamiStoryMainButtonItem.SetButtonState();
				this.UiViewSequence.PlaySequence(honamiStoryMainButtonItem.SpecialSequenceName, false, null);
			}
		}
		int lastRecordRevenue = HonamiStoryModel.Instance.LastRecordRevenue;
		int totalRevenue = HonamiStoryModel.Instance.TotalRevenue;
		if (lastRecordRevenue != totalRevenue)
		{
			this.ProfitPanel.PlayChangeSequence();
		}
	}

	// Token: 0x0600C6FB RID: 50939 RVA: 0x003B448C File Offset: 0x003B268C
	private void RefreshNormalButtonStates()
	{
		foreach (HonamiStoryMainButtonItem honamiStoryMainButtonItem in this.ButtonItems.Values)
		{
			honamiStoryMainButtonItem.SetButtonState();
			honamiStoryMainButtonItem.SetText();
			honamiStoryMainButtonItem.SetRedDot();
		}
	}

	// Token: 0x0600C6FC RID: 50940 RVA: 0x003B44F0 File Offset: 0x003B26F0
	private void RefreshTimeText()
	{
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		if (activityData == null)
		{
			return;
		}
		bool flag = activityData.CheckIfInLimitTime();
		base.GetItem(11).SetUIActive(flag && !this.IsHideAllUi);
		if (!flag && this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
			return;
		}
		HonamiStoryMainButtonItem honamiStoryMainButtonItem;
		if (this.ButtonItems.TryGetValue(EHonamiStoryMainButtonFunctionType.LimitTask, out honamiStoryMainButtonItem))
		{
			honamiStoryMainButtonItem.SetText();
			honamiStoryMainButtonItem.SetRedDot();
		}
	}

	// Token: 0x0600C6FD RID: 50941 RVA: 0x003B4570 File Offset: 0x003B2770
	private void RefreshTalkButton(bool isActive)
	{
		UUIButtonComponent button = base.GetButton(12);
		button.RootUIComp.Get().SetUIActive(false);
		if (isActive)
		{
			WorldEntity worldEntity = null;
			List<EntityHandle> list = new List<EntityHandle>();
			CreatureModel.Instance.GetEntitiesWithPbDataId(this.TalkEntityId, ref list);
			if (list.Count > 0)
			{
				worldEntity = list[0].Entity;
			}
			if (worldEntity == null)
			{
				Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.LRC, "RefreshTalkButton: entity is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			BaseActorComponent component = worldEntity.GetComponent<BaseActorComponent>();
			if (component == null)
			{
				return;
			}
			FVectorDouble actorLocation = component.ActorLocation;
			Vector2D vector2D = new Vector2D();
			if (HudUnitUtils.PositionUtil.ProjectWorldToScreen(actorLocation, vector2D))
			{
				button.RootUIComp.Get().SetAnchorOffset(vector2D.ToUeVector2D(false));
			}
		}
	}

	// Token: 0x0600C6FE RID: 50942 RVA: 0x003B463C File Offset: 0x003B283C
	private void RefreshPermanentScore()
	{
		HonamiStoryMainButtonItem honamiStoryMainButtonItem;
		if (this.ButtonItems.TryGetValue(EHonamiStoryMainButtonFunctionType.ScoreReward, out honamiStoryMainButtonItem))
		{
			honamiStoryMainButtonItem.SetButtonState();
			honamiStoryMainButtonItem.SetText();
			honamiStoryMainButtonItem.SetRedDot();
		}
	}

	// Token: 0x0600C6FF RID: 50943 RVA: 0x003B466B File Offset: 0x003B286B
	public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
	{
		if (this.UiCameraName.Length > 0)
		{
			UiCameraController.Instance.PushCameraHandleByOpenView((EUiViewName)this.UiCameraName, viewId, operationType);
		}
	}

	// Token: 0x0600C700 RID: 50944 RVA: 0x003B4692 File Offset: 0x003B2892
	public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
	{
		if (this.UiCameraName.Length > 0)
		{
			UiCameraController.Instance.PopCameraHandleByCloseView((EUiViewName)this.UiCameraName, nextViewName, closeViewId, operationType);
		}
	}

	// Token: 0x0600C701 RID: 50945 RVA: 0x003B46BB File Offset: 0x003B28BB
	private bool CheckCanButtonClick()
	{
		return !this.HasClickedAnyButton;
	}

	// Token: 0x0600C702 RID: 50946 RVA: 0x003B46C8 File Offset: 0x003B28C8
	private void SetHasClickedAnyButton()
	{
		this.HasClickedAnyButton = true;
	}

	// Token: 0x0600C703 RID: 50947 RVA: 0x003B46D1 File Offset: 0x003B28D1
	private void ResetHasClickedAnyButton()
	{
		this.HasClickedAnyButton = false;
	}

	// Token: 0x0600C704 RID: 50948 RVA: 0x003B46DA File Offset: 0x003B28DA
	private void ExecuteButtonAction(Action action)
	{
		if (!this.CheckCanButtonClick())
		{
			return;
		}
		this.SetHasClickedAnyButton();
		action();
		this.ResetHasClickedAnyButton();
	}

	// Token: 0x0600C705 RID: 50949 RVA: 0x003B46F8 File Offset: 0x003B28F8
	private UniTask ExecuteButtonActionAsync(Func<UniTask> action)
	{
		HonamiStoryMainView.<ExecuteButtonActionAsync>d__37 <ExecuteButtonActionAsync>d__;
		<ExecuteButtonActionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<ExecuteButtonActionAsync>d__.<>4__this = this;
		<ExecuteButtonActionAsync>d__.action = action;
		<ExecuteButtonActionAsync>d__.<>1__state = -1;
		<ExecuteButtonActionAsync>d__.<>t__builder.Start<HonamiStoryMainView.<ExecuteButtonActionAsync>d__37>(ref <ExecuteButtonActionAsync>d__);
		return <ExecuteButtonActionAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C706 RID: 50950 RVA: 0x003B4744 File Offset: 0x003B2944
	private void RefreshAllUiState(bool isShow)
	{
		base.GetExtendToggle(14).SetToggleState(isShow ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked, false, false, false);
		base.GetItem(15).SetUIActive(isShow);
		base.GetButton(16).RootUIComp.Get().SetUIActive(isShow);
		bool flag = HonamiStoryUtil.CheckInMainQuest();
		base.GetButton(18).RootUIComp.Get().SetUIActive(!flag && isShow);
		this.QuestPanel.SetActive(this.CheckIsShowPanel() && isShow);
		this.ProfitPanel.SetActive(this.CheckIsShowPanel() && isShow);
		foreach (HonamiStoryMainButtonItem honamiStoryMainButtonItem in this.ButtonItems.Values)
		{
			if (isShow)
			{
				honamiStoryMainButtonItem.SetButtonState();
			}
			else
			{
				honamiStoryMainButtonItem.SetUiActive(isShow);
			}
		}
		this.ButtonGoItem.SetUiActive(isShow);
	}

	// Token: 0x0600C707 RID: 50951 RVA: 0x003B4840 File Offset: 0x003B2A40
	private bool CheckIsShowPanel()
	{
		return !HonamiStoryUtil.CheckInMainQuest();
	}

	// Token: 0x0600C708 RID: 50952 RVA: 0x003B484A File Offset: 0x003B2A4A
	private void OnBtnTalk()
	{
		ScrollingTipsController.Instance.ShowTipsByText("剧情对话");
	}

	// Token: 0x0600C709 RID: 50953 RVA: 0x003B485B File Offset: 0x003B2A5B
	private void OnHideToggle(EToggleState toggleState)
	{
		this.IsHideAllUi = !this.IsHideAllUi;
		this.RefreshAllUiState(!this.IsHideAllUi);
	}

	// Token: 0x0600C70A RID: 50954 RVA: 0x003B487B File Offset: 0x003B2A7B
	private void OnBtnTechnology()
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryTechnologyView, null, null);
	}

	// Token: 0x0600C70B RID: 50955 RVA: 0x003B488E File Offset: 0x003B2A8E
	private void OnBtnPrepare()
	{
		FunctionController.Instance.OpenFunctionRelateView(EFunctionType.HonamiStoryBackpack);
	}

	// Token: 0x0600C70C RID: 50956 RVA: 0x003B489F File Offset: 0x003B2A9F
	private void OnBtnShop()
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryShopView, null, null);
	}

	// Token: 0x0600C70D RID: 50957 RVA: 0x003B48B2 File Offset: 0x003B2AB2
	private void OnBtnMascotCollect()
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryMascotCollectBookView, null, null);
	}

	// Token: 0x0600C70E RID: 50958 RVA: 0x003B48C5 File Offset: 0x003B2AC5
	private void OnBtnItemCollect()
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryItemCollectView, null, null);
	}

	// Token: 0x0600C70F RID: 50959 RVA: 0x003B48D8 File Offset: 0x003B2AD8
	private void OnBtnScoreReward()
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryPermanentTaskView, null, null);
	}

	// Token: 0x0600C710 RID: 50960 RVA: 0x003B48EB File Offset: 0x003B2AEB
	private void OnBtnLimitTask()
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryLimitTaskView, null, null);
	}

	// Token: 0x0600C711 RID: 50961 RVA: 0x003B4900 File Offset: 0x003B2B00
	private bool OnBtnLimitTaskCheckShow()
	{
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		return activityData != null && activityData.CheckIfInLimitTime();
	}

	// Token: 0x0600C712 RID: 50962 RVA: 0x003B4924 File Offset: 0x003B2B24
	private UniTask OnBtnEnter()
	{
		HonamiStoryMainView.<OnBtnEnter>d__50 <OnBtnEnter>d__;
		<OnBtnEnter>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBtnEnter>d__.<>1__state = -1;
		<OnBtnEnter>d__.<>t__builder.Start<HonamiStoryMainView.<OnBtnEnter>d__50>(ref <OnBtnEnter>d__);
		return <OnBtnEnter>d__.<>t__builder.Task;
	}

	// Token: 0x0600C713 RID: 50963 RVA: 0x003B495F File Offset: 0x003B2B5F
	private void OnBtnClose()
	{
		base.CloseMe(null);
		UiManager.Instance.OpenView(EUiViewName.HonamiStorySmallLoadingView, null, null);
	}

	// Token: 0x0600C714 RID: 50964 RVA: 0x003B497C File Offset: 0x003B2B7C
	private bool OnBtnMascotCollectRedDot()
	{
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		return activityData != null && (activityData.CanMascotCollectGetReward() || activityData.CanAreaCollectGetReward());
	}

	// Token: 0x0600C715 RID: 50965 RVA: 0x003B49AC File Offset: 0x003B2BAC
	private bool OnBtnScoreRewardRedDot()
	{
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		return activityData != null && activityData.IsPermanentTaskHasRedDot();
	}

	// Token: 0x0600C716 RID: 50966 RVA: 0x003B49D0 File Offset: 0x003B2BD0
	private bool OnBtnLimitTaskRedDot()
	{
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		return activityData != null && activityData.IsLimitTaskHasRedDot();
	}

	// Token: 0x0600C717 RID: 50967 RVA: 0x003B49F4 File Offset: 0x003B2BF4
	private bool OnBtnCollectRedDot()
	{
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		return activityData != null && activityData.IsItemCollectionHasRedDot();
	}

	// Token: 0x0600C718 RID: 50968 RVA: 0x003B4A18 File Offset: 0x003B2C18
	private bool OnBtnPrepareRedDot()
	{
		return HonamiStoryModel.Instance.CheckIsNewInInventory();
	}

	// Token: 0x0600C719 RID: 50969 RVA: 0x003B4A24 File Offset: 0x003B2C24
	private bool OnBtnShopRedDot()
	{
		return HonamiStoryModel.Instance.IsShopHasRedDot();
	}

	// Token: 0x0600C71A RID: 50970 RVA: 0x003B4A30 File Offset: 0x003B2C30
	private bool OnBtnTechRedDot()
	{
		return HonamiStoryModel.Instance.IsTechHasRedDot();
	}

	// Token: 0x0600C71B RID: 50971 RVA: 0x003B4A3C File Offset: 0x003B2C3C
	[NullableContext(2)]
	private void OnLimitTaskTextCallBack(UUIText item)
	{
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		if (activityData == null)
		{
			return;
		}
		string newText = ActivityModel.Instance.GetRemainTimeText(activityData.EndRewardTime, "{0}") ?? string.Empty;
		if (item != null)
		{
			item.SetText(newText, true);
		}
	}

	// Token: 0x0600C71C RID: 50972 RVA: 0x003B4A84 File Offset: 0x003B2C84
	[NullableContext(2)]
	private void OnScoreRewardTextCallBack(UUIText item)
	{
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		if (activityData == null)
		{
			return;
		}
		int count = activityData.GetPermanentTaskIdsByState(EActivityTaskState.FinishedAndClaimed).Count;
		int permanentTaskTotalNum = activityData.GetPermanentTaskTotalNum();
		if (item != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(count);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(permanentTaskTotalNum);
			item.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
	}

	// Token: 0x0600C71D RID: 50973 RVA: 0x003B4AEC File Offset: 0x003B2CEC
	[NullableContext(2)]
	private void OnPrepareTextCallBack(UUIText item)
	{
		HonamiStoryBackpackData backPackData = HonamiStoryModel.Instance.GetBackPackData(1, false);
		if (backPackData == null)
		{
			return;
		}
		int capacity = backPackData.GetCapacity();
		int occupy = backPackData.GetOccupy();
		if (backPackData.GetOverflowCapacity() > 0)
		{
			LguiUtil.Instance.SetLocalTextNew(item, "HonamiStory_OverflowCapacity", new <>z__ReadOnlyArray<object>(new object[]
			{
				occupy,
				capacity
			}));
			return;
		}
		if (item != null)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(occupy);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(capacity);
			item.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
	}

	// Token: 0x0600C71E RID: 50974 RVA: 0x003B4B88 File Offset: 0x003B2D88
	private void InitButtonShow()
	{
		int num = 5;
		int num2 = 11;
		for (int i = num; i <= num2; i++)
		{
			UUIItem item = base.GetItem(i);
			if (item != null)
			{
				item.SetUIActive(false);
			}
		}
	}

	// Token: 0x0600C71F RID: 50975 RVA: 0x003B4BB8 File Offset: 0x003B2DB8
	private void InitButtonConfigs()
	{
		if (this.ButtonConfigs.Count > 0)
		{
			return;
		}
		this.ButtonConfigs = new List<IHonamiStoryMainButtonConfig>
		{
			new HonamiStoryMainButtonConfig
			{
				Type = EHonamiStoryMainButtonFunctionType.Technology,
				ComponentId = EHonamiStoryMainComponent.TechnologyButton,
				FunctionId = new EFunctionType?(EFunctionType.HonamiStoryTechFuncId),
				OnClickCallback = new Action(this.OnBtnTechnology),
				ShowRedDot = new Func<bool>(this.OnBtnTechRedDot)
			},
			new HonamiStoryMainButtonConfig
			{
				Type = EHonamiStoryMainButtonFunctionType.Prepare,
				ComponentId = EHonamiStoryMainComponent.PrepareButton,
				OnClickCallback = new Action(this.OnBtnPrepare),
				SetTextCallback = new Action<UUIText>(this.OnPrepareTextCallBack),
				ShowRedDot = new Func<bool>(this.OnBtnPrepareRedDot),
				SpecialParamName = "Enter",
				SpecialSequenceName = "Acquire"
			},
			new HonamiStoryMainButtonConfig
			{
				Type = EHonamiStoryMainButtonFunctionType.Shop,
				ComponentId = EHonamiStoryMainComponent.ShopButton,
				FunctionId = new EFunctionType?(EFunctionType.HonamiStoryShopFuncId),
				OnClickCallback = new Action(this.OnBtnShop),
				ShowRedDot = new Func<bool>(this.OnBtnShopRedDot)
			},
			new HonamiStoryMainButtonConfig
			{
				Type = EHonamiStoryMainButtonFunctionType.MascotCollect,
				ComponentId = EHonamiStoryMainComponent.MascotCollectButton,
				FunctionId = new EFunctionType?(EFunctionType.HonamiStoryMascotFuncId),
				OnClickCallback = new Action(this.OnBtnMascotCollect),
				ShowRedDot = new Func<bool>(this.OnBtnMascotCollectRedDot)
			},
			new HonamiStoryMainButtonConfig
			{
				Type = EHonamiStoryMainButtonFunctionType.ItemCollect,
				ComponentId = EHonamiStoryMainComponent.ItemCollectButton,
				FunctionId = new EFunctionType?(EFunctionType.HonamiStoryItemCollectFuncId),
				OnClickCallback = new Action(this.OnBtnItemCollect),
				ShowRedDot = new Func<bool>(this.OnBtnCollectRedDot)
			},
			new HonamiStoryMainButtonConfig
			{
				Type = EHonamiStoryMainButtonFunctionType.ScoreReward,
				ComponentId = EHonamiStoryMainComponent.ScoreRewardButton,
				OnClickCallback = new Action(this.OnBtnScoreReward),
				SetTextCallback = new Action<UUIText>(this.OnScoreRewardTextCallBack),
				ShowRedDot = new Func<bool>(this.OnBtnScoreRewardRedDot)
			},
			new HonamiStoryMainButtonConfig
			{
				Type = EHonamiStoryMainButtonFunctionType.LimitTask,
				ComponentId = EHonamiStoryMainComponent.LimitTaskButton,
				OnClickCallback = new Action(this.OnBtnLimitTask),
				ShowCallback = new Func<bool>(this.OnBtnLimitTaskCheckShow),
				SetTextCallback = new Action<UUIText>(this.OnLimitTaskTextCallBack),
				ShowRedDot = new Func<bool>(this.OnBtnLimitTaskRedDot)
			}
		};
	}

	// Token: 0x0600C720 RID: 50976 RVA: 0x003B4E2C File Offset: 0x003B302C
	private UniTask CreateButtons()
	{
		HonamiStoryMainView.<CreateButtons>d__64 <CreateButtons>d__;
		<CreateButtons>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateButtons>d__.<>4__this = this;
		<CreateButtons>d__.<>1__state = -1;
		<CreateButtons>d__.<>t__builder.Start<HonamiStoryMainView.<CreateButtons>d__64>(ref <CreateButtons>d__);
		return <CreateButtons>d__.<>t__builder.Task;
	}

	// Token: 0x0600C721 RID: 50977 RVA: 0x003B4E70 File Offset: 0x003B3070
	private bool CheckButtonShow(EHonamiStoryMainButtonFunctionType buttonType)
	{
		bool flag = HonamiStoryUtil.CheckInMainQuest();
		return !flag || (flag && HonamiStoryMainView.showWhenMainTask.Contains(buttonType));
	}

	// Token: 0x04007162 RID: 29026
	[StaticVariableRuleIgnore]
	private static readonly List<EHonamiStoryMainButtonFunctionType> showWhenMainTask = new List<EHonamiStoryMainButtonFunctionType>
	{
		EHonamiStoryMainButtonFunctionType.Technology,
		EHonamiStoryMainButtonFunctionType.Prepare
	};

	// Token: 0x04007163 RID: 29027
	private PopupCaptionItem PopupCaption;

	// Token: 0x04007164 RID: 29028
	private HonamiStoryQuestPanel QuestPanel;

	// Token: 0x04007165 RID: 29029
	private HonamiStoryProfitPanel ProfitPanel;

	// Token: 0x04007166 RID: 29030
	private HonamiStoryMainButtonGoItem ButtonGoItem;

	// Token: 0x04007167 RID: 29031
	private readonly Dictionary<EHonamiStoryMainButtonFunctionType, HonamiStoryMainButtonItem> ButtonItems = new Dictionary<EHonamiStoryMainButtonFunctionType, HonamiStoryMainButtonItem>();

	// Token: 0x04007168 RID: 29032
	private List<IHonamiStoryMainButtonConfig> ButtonConfigs = new List<IHonamiStoryMainButtonConfig>();

	// Token: 0x04007169 RID: 29033
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x0400716A RID: 29034
	private string UiCameraName = string.Empty;

	// Token: 0x0400716B RID: 29035
	private int TalkEntityId;

	// Token: 0x0400716C RID: 29036
	private bool HasClickedAnyButton;

	// Token: 0x0400716D RID: 29037
	private bool IsHideAllUi;
}
