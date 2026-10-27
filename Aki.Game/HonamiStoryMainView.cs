using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Functional;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001ED8 RID: 7896
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryMainView : UiViewBase, IUiCameraBehavior
{
	// Token: 0x0600F2CD RID: 62157 RVA: 0x003A8281 File Offset: 0x003A6481
	public HonamiStoryMainView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F2CE RID: 62158 RVA: 0x003A82AC File Offset: 0x003A64AC
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

	// Token: 0x0600F2CF RID: 62159 RVA: 0x003A85B4 File Offset: 0x003A67B4
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryMainView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryMainView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F2D0 RID: 62160 RVA: 0x003A85F8 File Offset: 0x003A67F8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnUiBlendInTimeCameraFinished, new Action<UiCameraHandleData>(this.OnCameraFinish));
		EventSystem.Instance.Add(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Add<bool>(EEventName.OnHonamiStorySetVisible, new Action<bool>(this.OnHonamiStorySetVisible));
	}

	// Token: 0x0600F2D1 RID: 62161 RVA: 0x003A865C File Offset: 0x003A685C
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnUiBlendInTimeCameraFinished, new Action<UiCameraHandleData>(this.OnCameraFinish));
		EventSystem.Instance.Remove(EEventName.OnActivitySequenceEmitEvent, new Action<string>(this.OnActivitySequenceEmitEvent));
		EventSystem.Instance.Remove(EEventName.OnHonamiStorySetVisible, new Action<bool>(this.OnHonamiStorySetVisible));
	}

	// Token: 0x0600F2D2 RID: 62162 RVA: 0x003A86C0 File Offset: 0x003A68C0
	protected override void OnBeforeShow()
	{
		UiCameraAnimationManager.Instance.DisablePlayerActor();
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

	// Token: 0x0600F2D3 RID: 62163 RVA: 0x003A8781 File Offset: 0x003A6981
	protected override void OnStart()
	{
		UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
		if (uiViewSequence == null)
		{
			return;
		}
		uiViewSequence.AddSequenceFinishEvent("ShowView", new Action<string>(this.OnShowUiSequenceFinish), false);
	}

	// Token: 0x0600F2D4 RID: 62164 RVA: 0x003A87A5 File Offset: 0x003A69A5
	protected override void OnBeforeHide()
	{
		if (this.TimerHandle != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
			this.TimerHandle = null;
		}
		this.ResetHasClickedAnyButton();
	}

	// Token: 0x0600F2D5 RID: 62165 RVA: 0x003A87D0 File Offset: 0x003A69D0
	protected override void OnBeforeDestroy()
	{
		foreach (HonamiStoryMainButtonItem honamiStoryMainButtonItem in this.ButtonItems.Values)
		{
			honamiStoryMainButtonItem.Clear();
		}
		this.ButtonItems.Clear();
		this.ButtonConfigs = new List<IHonamiStoryMainButtonConfig>();
	}

	// Token: 0x0600F2D6 RID: 62166 RVA: 0x003A883C File Offset: 0x003A6A3C
	protected override void OnAfterDestroy()
	{
		UiCameraAnimationManager.Instance.EnablePlayerActor();
	}

	// Token: 0x0600F2D7 RID: 62167 RVA: 0x003A8848 File Offset: 0x003A6A48
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

	// Token: 0x0600F2D8 RID: 62168 RVA: 0x003A88B4 File Offset: 0x003A6AB4
	private void OnHonamiStorySetVisible(bool _)
	{
		this.RefreshAllUiState(true);
	}

	// Token: 0x0600F2D9 RID: 62169 RVA: 0x003A88BD File Offset: 0x003A6ABD
	private void OnCameraFinish(UiCameraHandleData handleData)
	{
		if (handleData.ViewName == EUiViewName.HonamiStoryMainView)
		{
			this.RefreshTalkButton(false);
		}
	}

	// Token: 0x0600F2DA RID: 62170 RVA: 0x003A88DD File Offset: 0x003A6ADD
	private void OnShowUiSequenceFinish(string _)
	{
		this.RefreshSpecialButtonsStates();
	}

	// Token: 0x0600F2DB RID: 62171 RVA: 0x003A88E8 File Offset: 0x003A6AE8
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

	// Token: 0x0600F2DC RID: 62172 RVA: 0x003A898C File Offset: 0x003A6B8C
	private void RefreshNormalButtonStates()
	{
		foreach (HonamiStoryMainButtonItem honamiStoryMainButtonItem in this.ButtonItems.Values)
		{
			honamiStoryMainButtonItem.SetButtonState();
			honamiStoryMainButtonItem.SetText();
			honamiStoryMainButtonItem.SetRedDot();
		}
	}

	// Token: 0x0600F2DD RID: 62173 RVA: 0x003A89F0 File Offset: 0x003A6BF0
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

	// Token: 0x0600F2DE RID: 62174 RVA: 0x003A8A70 File Offset: 0x003A6C70
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

	// Token: 0x0600F2DF RID: 62175 RVA: 0x003A8B3C File Offset: 0x003A6D3C
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

	// Token: 0x0600F2E0 RID: 62176 RVA: 0x003A8B6B File Offset: 0x003A6D6B
	public void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
	{
		if (this.UiCameraName.Length > 0)
		{
			UiCameraAnimationController.Instance.PushCameraHandle((EUiViewName)this.UiCameraName, new int?(viewId), isBlend);
		}
	}

	// Token: 0x0600F2E1 RID: 62177 RVA: 0x003A8B97 File Offset: 0x003A6D97
	[NullableContext(2)]
	public void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
	{
		if (this.UiCameraName.Length > 0)
		{
			UiCameraAnimationController.Instance.PopCameraHandle((EUiViewName)this.UiCameraName, stackTopInfo, closeViewId, popOrDelete);
		}
	}

	// Token: 0x0600F2E2 RID: 62178 RVA: 0x003A8BC0 File Offset: 0x003A6DC0
	private bool CheckCanButtonClick()
	{
		return !this.HasClickedAnyButton;
	}

	// Token: 0x0600F2E3 RID: 62179 RVA: 0x003A8BCD File Offset: 0x003A6DCD
	private void SetHasClickedAnyButton()
	{
		this.HasClickedAnyButton = true;
	}

	// Token: 0x0600F2E4 RID: 62180 RVA: 0x003A8BD6 File Offset: 0x003A6DD6
	private void ResetHasClickedAnyButton()
	{
		this.HasClickedAnyButton = false;
	}

	// Token: 0x0600F2E5 RID: 62181 RVA: 0x003A8BDF File Offset: 0x003A6DDF
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

	// Token: 0x0600F2E6 RID: 62182 RVA: 0x003A8BFC File Offset: 0x003A6DFC
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

	// Token: 0x0600F2E7 RID: 62183 RVA: 0x003A8C48 File Offset: 0x003A6E48
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

	// Token: 0x0600F2E8 RID: 62184 RVA: 0x003A8D44 File Offset: 0x003A6F44
	private bool CheckIsShowPanel()
	{
		return !HonamiStoryUtil.CheckInMainQuest();
	}

	// Token: 0x0600F2E9 RID: 62185 RVA: 0x003A8D4E File Offset: 0x003A6F4E
	private void OnBtnTalk()
	{
		ScrollingTipsController.Instance.ShowTipsByText("剧情对话");
	}

	// Token: 0x0600F2EA RID: 62186 RVA: 0x003A8D5F File Offset: 0x003A6F5F
	private void OnHideToggle(EToggleState toggleState)
	{
		this.IsHideAllUi = !this.IsHideAllUi;
		this.RefreshAllUiState(!this.IsHideAllUi);
	}

	// Token: 0x0600F2EB RID: 62187 RVA: 0x003A8D7F File Offset: 0x003A6F7F
	private void OnBtnTechnology()
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryTechnologyView, null, null);
	}

	// Token: 0x0600F2EC RID: 62188 RVA: 0x003A8D92 File Offset: 0x003A6F92
	private void OnBtnPrepare()
	{
		FunctionController.Instance.OpenFunctionRelateView(EFunctionType.HonamiStoryBackpack);
	}

	// Token: 0x0600F2ED RID: 62189 RVA: 0x003A8DA3 File Offset: 0x003A6FA3
	private void OnBtnShop()
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryShopView, null, null);
	}

	// Token: 0x0600F2EE RID: 62190 RVA: 0x003A8DB6 File Offset: 0x003A6FB6
	private void OnBtnMascotCollect()
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryMascotCollectBookView, null, null);
	}

	// Token: 0x0600F2EF RID: 62191 RVA: 0x003A8DC9 File Offset: 0x003A6FC9
	private void OnBtnItemCollect()
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryItemCollectView, null, null);
	}

	// Token: 0x0600F2F0 RID: 62192 RVA: 0x003A8DDC File Offset: 0x003A6FDC
	private void OnBtnScoreReward()
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryPermanentTaskView, null, null);
	}

	// Token: 0x0600F2F1 RID: 62193 RVA: 0x003A8DEF File Offset: 0x003A6FEF
	private void OnBtnLimitTask()
	{
		UiManager.Instance.OpenView(EUiViewName.HonamiStoryLimitTaskView, null, null);
	}

	// Token: 0x0600F2F2 RID: 62194 RVA: 0x003A8E04 File Offset: 0x003A7004
	private bool OnBtnLimitTaskCheckShow()
	{
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		return activityData != null && activityData.CheckIfInLimitTime();
	}

	// Token: 0x0600F2F3 RID: 62195 RVA: 0x003A8E28 File Offset: 0x003A7028
	private UniTask OnBtnEnter()
	{
		HonamiStoryMainView.<OnBtnEnter>d__50 <OnBtnEnter>d__;
		<OnBtnEnter>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBtnEnter>d__.<>1__state = -1;
		<OnBtnEnter>d__.<>t__builder.Start<HonamiStoryMainView.<OnBtnEnter>d__50>(ref <OnBtnEnter>d__);
		return <OnBtnEnter>d__.<>t__builder.Task;
	}

	// Token: 0x0600F2F4 RID: 62196 RVA: 0x003A8E63 File Offset: 0x003A7063
	private void OnBtnClose()
	{
		base.CloseMe(null);
		UiManager.Instance.OpenView(EUiViewName.HonamiStorySmallLoadingView, null, null);
	}

	// Token: 0x0600F2F5 RID: 62197 RVA: 0x003A8E80 File Offset: 0x003A7080
	private bool OnBtnMascotCollectRedDot()
	{
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		return activityData != null && (activityData.CanMascotCollectGetReward() || activityData.CanAreaCollectGetReward());
	}

	// Token: 0x0600F2F6 RID: 62198 RVA: 0x003A8EB0 File Offset: 0x003A70B0
	private bool OnBtnScoreRewardRedDot()
	{
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		return activityData != null && activityData.IsPermanentTaskHasRedDot();
	}

	// Token: 0x0600F2F7 RID: 62199 RVA: 0x003A8ED4 File Offset: 0x003A70D4
	private bool OnBtnLimitTaskRedDot()
	{
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		return activityData != null && activityData.IsLimitTaskHasRedDot();
	}

	// Token: 0x0600F2F8 RID: 62200 RVA: 0x003A8EF8 File Offset: 0x003A70F8
	private bool OnBtnCollectRedDot()
	{
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(true);
		return activityData != null && activityData.IsItemCollectionHasRedDot();
	}

	// Token: 0x0600F2F9 RID: 62201 RVA: 0x003A8F1C File Offset: 0x003A711C
	private bool OnBtnPrepareRedDot()
	{
		return HonamiStoryModel.Instance.CheckIsNewInInventory();
	}

	// Token: 0x0600F2FA RID: 62202 RVA: 0x003A8F28 File Offset: 0x003A7128
	private bool OnBtnShopRedDot()
	{
		return HonamiStoryModel.Instance.IsShopHasRedDot();
	}

	// Token: 0x0600F2FB RID: 62203 RVA: 0x003A8F34 File Offset: 0x003A7134
	private bool OnBtnTechRedDot()
	{
		return HonamiStoryModel.Instance.IsTechHasRedDot();
	}

	// Token: 0x0600F2FC RID: 62204 RVA: 0x003A8F40 File Offset: 0x003A7140
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

	// Token: 0x0600F2FD RID: 62205 RVA: 0x003A8F88 File Offset: 0x003A7188
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

	// Token: 0x0600F2FE RID: 62206 RVA: 0x003A8FF0 File Offset: 0x003A71F0
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

	// Token: 0x0600F2FF RID: 62207 RVA: 0x003A908C File Offset: 0x003A728C
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

	// Token: 0x0600F300 RID: 62208 RVA: 0x003A90BC File Offset: 0x003A72BC
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

	// Token: 0x0600F301 RID: 62209 RVA: 0x003A9330 File Offset: 0x003A7530
	private UniTask CreateButtons()
	{
		HonamiStoryMainView.<CreateButtons>d__64 <CreateButtons>d__;
		<CreateButtons>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateButtons>d__.<>4__this = this;
		<CreateButtons>d__.<>1__state = -1;
		<CreateButtons>d__.<>t__builder.Start<HonamiStoryMainView.<CreateButtons>d__64>(ref <CreateButtons>d__);
		return <CreateButtons>d__.<>t__builder.Task;
	}

	// Token: 0x0600F302 RID: 62210 RVA: 0x003A9374 File Offset: 0x003A7574
	private bool CheckButtonShow(EHonamiStoryMainButtonFunctionType buttonType)
	{
		bool flag = HonamiStoryUtil.CheckInMainQuest();
		return !flag || (flag && HonamiStoryMainView.showWhenMainTask.Contains(buttonType));
	}

	// Token: 0x04007081 RID: 28801
	[StaticVariableRuleIgnore]
	private static readonly List<EHonamiStoryMainButtonFunctionType> showWhenMainTask = new List<EHonamiStoryMainButtonFunctionType>
	{
		EHonamiStoryMainButtonFunctionType.Technology,
		EHonamiStoryMainButtonFunctionType.Prepare
	};

	// Token: 0x04007082 RID: 28802
	private PopupCaptionItem PopupCaption;

	// Token: 0x04007083 RID: 28803
	private HonamiStoryQuestPanel QuestPanel;

	// Token: 0x04007084 RID: 28804
	private HonamiStoryProfitPanel ProfitPanel;

	// Token: 0x04007085 RID: 28805
	private HonamiStoryMainButtonGoItem ButtonGoItem;

	// Token: 0x04007086 RID: 28806
	private readonly Dictionary<EHonamiStoryMainButtonFunctionType, HonamiStoryMainButtonItem> ButtonItems = new Dictionary<EHonamiStoryMainButtonFunctionType, HonamiStoryMainButtonItem>();

	// Token: 0x04007087 RID: 28807
	private List<IHonamiStoryMainButtonConfig> ButtonConfigs = new List<IHonamiStoryMainButtonConfig>();

	// Token: 0x04007088 RID: 28808
	[Nullable(2)]
	private TimerHandle TimerHandle;

	// Token: 0x04007089 RID: 28809
	private string UiCameraName = string.Empty;

	// Token: 0x0400708A RID: 28810
	private int TalkEntityId;

	// Token: 0x0400708B RID: 28811
	private bool HasClickedAnyButton;

	// Token: 0x0400708C RID: 28812
	private bool IsHideAllUi;
}
