using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.ServerStorage;
using CSharpScript.Game.ServerStorage.Container;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001ABF RID: 6847
[NullableContext(1)]
[Nullable(0)]
public class PhotographSetupView : UiViewBase
{
	// Token: 0x06010F33 RID: 69427 RVA: 0x004F85F8 File Offset: 0x004F67F8
	public PhotographSetupView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06010F34 RID: 69428 RVA: 0x004F8654 File Offset: 0x004F6854
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(9, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickedSetup)),
			new ValueTuple<int, Delegate>(1, new Action<EToggleState>(this.OnClickedExpression)),
			new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickedMotion)),
			new ValueTuple<int, Delegate>(9, new Action<EToggleState>(this.OnClickedFilter)),
			new ValueTuple<int, Delegate>(7, new Action(this.OnClickedCloseButton))
		};
	}

	// Token: 0x06010F35 RID: 69429 RVA: 0x004F886E File Offset: 0x004F6A6E
	private void OnClickedCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x06010F36 RID: 69430 RVA: 0x004F8877 File Offset: 0x004F6A77
	private void OnClickedExpression(EToggleState toggleState)
	{
		this.RefreshTabState(EPhotoSettingMode.ExpressionSetup);
	}

	// Token: 0x06010F37 RID: 69431 RVA: 0x004F8880 File Offset: 0x004F6A80
	private void OnClickedSetup(EToggleState toggleState)
	{
		this.RefreshTabState(EPhotoSettingMode.CameraSetup);
	}

	// Token: 0x06010F38 RID: 69432 RVA: 0x004F8889 File Offset: 0x004F6A89
	private void OnClickedMotion(EToggleState toggleState)
	{
		this.RefreshTabState(EPhotoSettingMode.MotionSetup);
	}

	// Token: 0x06010F39 RID: 69433 RVA: 0x004F8894 File Offset: 0x004F6A94
	private void OnClickedFilter(EToggleState toggleState)
	{
		ServerStorageBoolean serverStorageBoolean = ServerStorageModel.Instance.Get(EClientStorageSystemIdType.FilterRedPoint) as ServerStorageBoolean;
		if (serverStorageBoolean.Get().GetValueOrDefault(true))
		{
			serverStorageBoolean.Set(new bool?(false));
			EventSystem.Instance.Emit(EEventName.RedDotFilter);
			PhotographTab photoFilterTab = this.PhotoFilterTab;
			if (photoFilterTab != null)
			{
				photoFilterTab.RefreshRedDot();
			}
		}
		this.RefreshTabState(EPhotoSettingMode.FilterSetup);
	}

	// Token: 0x06010F3A RID: 69434 RVA: 0x004F88F8 File Offset: 0x004F6AF8
	protected override UniTask OnBeforeStartAsync()
	{
		PhotographSetupView.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotographSetupView.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010F3B RID: 69435 RVA: 0x004F893C File Offset: 0x004F6B3C
	protected override void OnStart()
	{
		this.AnimationController = (base.GetItem(3).GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController);
		this.SelectTabToggle(this.PhotoSetupMode, true, true);
		this.SelectDefaultMotion();
		this.UiScrollView = base.GetScrollViewWithScrollbar(12);
		base.GetItem(16).SetUIActive(false);
	}

	// Token: 0x06010F3C RID: 69436 RVA: 0x004F89A0 File Offset: 0x004F6BA0
	protected override void OnBeforeDestroy()
	{
		this.ClearMotionItem();
		this.ClearExpressionItem();
		this.ClearSetupItem();
		this.ClearFilterItem();
		this.TabItemMap.Clear();
		this.TabItemMap = null;
		this.PhotoFilterTab.Destroy(null);
		this.FilterToggleItem.Destroy(null);
	}

	// Token: 0x06010F3D RID: 69437 RVA: 0x004F89F0 File Offset: 0x004F6BF0
	private void ScrollToSelectedItem(PhotoFilterItem item)
	{
		TTimerAction <>9__1;
		this.UiScrollView.OnLateUpdate.Bind(delegate(float deltaTime)
		{
			TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
			TTimerAction action;
			if ((action = <>9__1) == null)
			{
				action = (<>9__1 = delegate(float _)
				{
					FVector relativeLocation = this.UiScrollView.ContentUIItem.Get().RelativeLocation;
					FVector2D fvector2D = new FVector2D(ref relativeLocation);
					this.UiScrollView.StopMovement();
					this.UiScrollView.ScrollToBottom(ref fvector2D, item.GetRootItem(), false);
				});
			}
			gameplayTimeInstance.Next(action, null, null);
			UUIScrollViewWithScrollbarComponent uiScrollView = this.UiScrollView;
			if (uiScrollView != null && uiScrollView.IsValid())
			{
				this.UiScrollView.OnLateUpdate.Unbind();
			}
		});
	}

	// Token: 0x06010F3E RID: 69438 RVA: 0x004F8A30 File Offset: 0x004F6C30
	private void ScrollToSelectedItem(PhotographExpressionItem item)
	{
		TTimerAction <>9__1;
		this.UiScrollView.OnLateUpdate.Bind(delegate(float deltaTime)
		{
			TimerSystemInstance gameplayTimeInstance = TimerSystem.GameplayTimeInstance;
			TTimerAction action;
			if ((action = <>9__1) == null)
			{
				action = (<>9__1 = delegate(float _)
				{
					FVector relativeLocation = this.UiScrollView.ContentUIItem.Get().RelativeLocation;
					FVector2D fvector2D = new FVector2D(ref relativeLocation);
					this.UiScrollView.StopMovement();
					this.UiScrollView.ScrollToBottom(ref fvector2D, item.GetRootItem(), false);
				});
			}
			gameplayTimeInstance.Next(action, null, null);
			UUIScrollViewWithScrollbarComponent uiScrollView = this.UiScrollView;
			if (uiScrollView != null && uiScrollView.IsValid())
			{
				this.UiScrollView.OnLateUpdate.Unbind();
			}
		});
	}

	// Token: 0x06010F3F RID: 69439 RVA: 0x004F8A6D File Offset: 0x004F6C6D
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Emit<bool>(EEventName.OnPhotographSetUpViewVisibleChanged, true);
	}

	// Token: 0x06010F40 RID: 69440 RVA: 0x004F8A80 File Offset: 0x004F6C80
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Emit<bool>(EEventName.OnPhotographSetUpViewVisibleChanged, false);
	}

	// Token: 0x06010F41 RID: 69441 RVA: 0x004F8A93 File Offset: 0x004F6C93
	public void SetPanelVisible(bool isShow)
	{
		base.GetItem(11).SetUIActive(isShow);
		base.GetItem(16).SetUIActive(!isShow);
	}

	// Token: 0x06010F42 RID: 69442 RVA: 0x004F8AB4 File Offset: 0x004F6CB4
	private void InitTabToggle()
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		UUIExtendToggle extendToggle2 = base.GetExtendToggle(1);
		UUIExtendToggle extendToggle3 = base.GetExtendToggle(2);
		UUIExtendToggle extendToggle4 = base.GetExtendToggle(9);
		if (extendToggle2 != null)
		{
			extendToggle2.RootUIComp.Get().SetUIActive(false);
		}
		if (extendToggle3 != null)
		{
			extendToggle3.RootUIComp.Get().SetUIActive(false);
		}
		base.GetItem(10).SetUIActive(false);
		this.TabItemMap.Add(EPhotoSettingMode.CameraSetup, extendToggle);
		this.TabItemMap.Add(EPhotoSettingMode.ExpressionSetup, extendToggle2);
		this.TabItemMap.Add(EPhotoSettingMode.MotionSetup, extendToggle3);
		this.TabItemMap.Add(EPhotoSettingMode.FilterSetup, extendToggle4);
	}

	// Token: 0x06010F43 RID: 69443 RVA: 0x004F8B54 File Offset: 0x004F6D54
	private void RefreshTabState(EPhotoSettingMode newMode)
	{
		foreach (KeyValuePair<EPhotoSettingMode, UUIExtendToggle> keyValuePair in this.TabItemMap)
		{
			EPhotoSettingMode key = keyValuePair.Key;
			UUIExtendToggle value = keyValuePair.Value;
			if (key != newMode)
			{
				value.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			}
		}
		this.SetPhotoSetupMode(newMode);
	}

	// Token: 0x06010F44 RID: 69444 RVA: 0x004F8BC4 File Offset: 0x004F6DC4
	private void SelectTabToggle(EPhotoSettingMode newMode, bool selectOn, bool bFireEvent = false)
	{
		EToggleState state = selectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle uuiextendToggle;
		if (this.TabItemMap.TryGetValue(newMode, out uuiextendToggle))
		{
			uuiextendToggle.SetToggleStateForce(state, bFireEvent, false, false);
		}
	}

	// Token: 0x06010F45 RID: 69445 RVA: 0x004F8BF3 File Offset: 0x004F6DF3
	private void SetPhotoSetupMode(EPhotoSettingMode newMode)
	{
		this.PhotoSetupMode = newMode;
		this.SetCameraSetupVisible(newMode == EPhotoSettingMode.CameraSetup);
		this.SetExpressionVisible(newMode == EPhotoSettingMode.ExpressionSetup);
		this.SetMotionVisible(newMode == EPhotoSettingMode.MotionSetup);
		this.SetFilterVisible(newMode == EPhotoSettingMode.FilterSetup);
	}

	// Token: 0x06010F46 RID: 69446 RVA: 0x004F8C24 File Offset: 0x004F6E24
	private UniTask InitializeExpressionSetup()
	{
		PhotographSetupView.<InitializeExpressionSetup>d__35 <InitializeExpressionSetup>d__;
		<InitializeExpressionSetup>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeExpressionSetup>d__.<>4__this = this;
		<InitializeExpressionSetup>d__.<>1__state = -1;
		<InitializeExpressionSetup>d__.<>t__builder.Start<PhotographSetupView.<InitializeExpressionSetup>d__35>(ref <InitializeExpressionSetup>d__);
		return <InitializeExpressionSetup>d__.<>t__builder.Task;
	}

	// Token: 0x06010F47 RID: 69447 RVA: 0x004F8C68 File Offset: 0x004F6E68
	private UniTask NewExpressionItem(int montageId)
	{
		PhotographSetupView.<NewExpressionItem>d__36 <NewExpressionItem>d__;
		<NewExpressionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewExpressionItem>d__.<>4__this = this;
		<NewExpressionItem>d__.montageId = montageId;
		<NewExpressionItem>d__.<>1__state = -1;
		<NewExpressionItem>d__.<>t__builder.Start<PhotographSetupView.<NewExpressionItem>d__36>(ref <NewExpressionItem>d__);
		return <NewExpressionItem>d__.<>t__builder.Task;
	}

	// Token: 0x06010F48 RID: 69448 RVA: 0x004F8CB4 File Offset: 0x004F6EB4
	private void ClearExpressionItem()
	{
		foreach (PhotographExpressionItem photographExpressionItem in this.ExpressionItemSet)
		{
			photographExpressionItem.Destroy(null);
		}
		this.ExpressionItemSet.Clear();
		this.SelectedExpressionItem = null;
	}

	// Token: 0x06010F49 RID: 69449 RVA: 0x004F8D18 File Offset: 0x004F6F18
	private void SetExpressionVisible(bool bVisible)
	{
		foreach (PhotographExpressionItem photographExpressionItem in this.ExpressionItemSet)
		{
			photographExpressionItem.SetActive(bVisible);
		}
		UUIInturnAnimController animationController = this.AnimationController;
		if (animationController == null)
		{
			return;
		}
		animationController.Play("Start03", -1, false);
	}

	// Token: 0x06010F4A RID: 69450 RVA: 0x004F8D80 File Offset: 0x004F6F80
	private void OnSelectedExpressionItem(PhotographExpressionItem expressionItem, bool bSelectOn)
	{
		if (bSelectOn)
		{
			this.SelectOnExpressionItem(expressionItem);
			return;
		}
		this.DeselectOnExpressionItem(expressionItem);
	}

	// Token: 0x06010F4B RID: 69451 RVA: 0x004F8D94 File Offset: 0x004F6F94
	private void SelectOnExpressionItem(PhotographExpressionItem expressionItem)
	{
		if (this.SelectedExpressionItem != null)
		{
			this.SelectedExpressionItem.SetSelected(false, false);
		}
		int photoMontageId = expressionItem.GetPhotoMontageId();
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		PhotographController.Instance.PlayPhotoMontage(getCurrentEntity, photoMontageId);
		this.SelectedExpressionItem = expressionItem;
		this.SelectedExpressionItem.SetSelected(true, false);
		this.ScrollToSelectedItem(this.SelectedExpressionItem);
	}

	// Token: 0x06010F4C RID: 69452 RVA: 0x004F8DF4 File Offset: 0x004F6FF4
	private void DeselectOnExpressionItem(PhotographExpressionItem expressionItem)
	{
		if (this.SelectedExpressionItem != expressionItem)
		{
			return;
		}
		PhotographController.Instance.ResetPhotoMontage();
		this.SelectedExpressionItem = null;
	}

	// Token: 0x06010F4D RID: 69453 RVA: 0x004F8E14 File Offset: 0x004F7014
	private void SelectDefaultMotion()
	{
		int montageId = PhotographModel.Instance.MontageId;
		PhotographExpressionItem photographExpressionItem;
		if (!this.MotionItemMap.TryGetValue(montageId, out photographExpressionItem))
		{
			return;
		}
		if (this.SelectedMotionItem == photographExpressionItem)
		{
			return;
		}
		if (this.SelectedMotionItem != null)
		{
			this.SelectedMotionItem.SetSelected(false, false);
		}
		this.SelectedMotionItem = photographExpressionItem;
		PhotographExpressionItem selectedMotionItem = this.SelectedMotionItem;
		if (selectedMotionItem == null)
		{
			return;
		}
		selectedMotionItem.SetSelected(true, false);
	}

	// Token: 0x06010F4E RID: 69454 RVA: 0x004F8E78 File Offset: 0x004F7078
	private UniTask InitializeMotionSetup()
	{
		PhotographSetupView.<InitializeMotionSetup>d__43 <InitializeMotionSetup>d__;
		<InitializeMotionSetup>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeMotionSetup>d__.<>4__this = this;
		<InitializeMotionSetup>d__.<>1__state = -1;
		<InitializeMotionSetup>d__.<>t__builder.Start<PhotographSetupView.<InitializeMotionSetup>d__43>(ref <InitializeMotionSetup>d__);
		return <InitializeMotionSetup>d__.<>t__builder.Task;
	}

	// Token: 0x06010F4F RID: 69455 RVA: 0x004F8EBC File Offset: 0x004F70BC
	private UniTask CreateDefaultMotionItem()
	{
		PhotographSetupView.<CreateDefaultMotionItem>d__44 <CreateDefaultMotionItem>d__;
		<CreateDefaultMotionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDefaultMotionItem>d__.<>4__this = this;
		<CreateDefaultMotionItem>d__.<>1__state = -1;
		<CreateDefaultMotionItem>d__.<>t__builder.Start<PhotographSetupView.<CreateDefaultMotionItem>d__44>(ref <CreateDefaultMotionItem>d__);
		return <CreateDefaultMotionItem>d__.<>t__builder.Task;
	}

	// Token: 0x06010F50 RID: 69456 RVA: 0x004F8F00 File Offset: 0x004F7100
	private UniTask NewMotionItem(int montageId)
	{
		PhotographSetupView.<NewMotionItem>d__45 <NewMotionItem>d__;
		<NewMotionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewMotionItem>d__.<>4__this = this;
		<NewMotionItem>d__.montageId = montageId;
		<NewMotionItem>d__.<>1__state = -1;
		<NewMotionItem>d__.<>t__builder.Start<PhotographSetupView.<NewMotionItem>d__45>(ref <NewMotionItem>d__);
		return <NewMotionItem>d__.<>t__builder.Task;
	}

	// Token: 0x06010F51 RID: 69457 RVA: 0x004F8F4C File Offset: 0x004F714C
	private void SetMotionVisible(bool bVisible)
	{
		foreach (PhotographExpressionItem photographExpressionItem in this.MotionItemMap.Values)
		{
			photographExpressionItem.SetActive(bVisible);
		}
	}

	// Token: 0x06010F52 RID: 69458 RVA: 0x004F8FA4 File Offset: 0x004F71A4
	private void ClearMotionItem()
	{
		foreach (PhotographExpressionItem photographExpressionItem in this.MotionItemMap.Values)
		{
			photographExpressionItem.Destroy(null);
		}
		this.MotionItemMap.Clear();
		this.SelectedMotionItem = null;
	}

	// Token: 0x06010F53 RID: 69459 RVA: 0x004F900C File Offset: 0x004F720C
	private bool OnCanExecuteChangeFunc(PhotographExpressionItem motionItem)
	{
		return this.SelectedMotionItem != motionItem;
	}

	// Token: 0x06010F54 RID: 69460 RVA: 0x004F901A File Offset: 0x004F721A
	private void OnSelectedMotionItem(PhotographExpressionItem motionItem, bool bSelectOn)
	{
		if (bSelectOn)
		{
			this.SelectOnMotionItem(motionItem);
			return;
		}
		this.DeselectOnMotionItem(motionItem);
	}

	// Token: 0x06010F55 RID: 69461 RVA: 0x004F9030 File Offset: 0x004F7230
	private void SelectOnMotionItem(PhotographExpressionItem motionItem)
	{
		if (this.SelectedMotionItem != null)
		{
			this.SelectedMotionItem.SetSelected(false, false);
		}
		int photoMontageId = motionItem.GetPhotoMontageId();
		if (photoMontageId == 0)
		{
			PhotographController.Instance.ResetPhotoMontage();
		}
		else
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			PhotographController.Instance.PlayPhotoMontage(getCurrentEntity, photoMontageId);
		}
		this.SelectedMotionItem = motionItem;
		this.SelectedMotionItem.SetSelected(true, false);
		this.ScrollToSelectedItem(this.SelectedMotionItem);
	}

	// Token: 0x06010F56 RID: 69462 RVA: 0x004F909F File Offset: 0x004F729F
	private void DeselectOnMotionItem(PhotographExpressionItem motionItem)
	{
		if (this.SelectedMotionItem != motionItem)
		{
			return;
		}
		PhotographController.Instance.ResetPhotoMontage();
		this.SelectedMotionItem = null;
	}

	// Token: 0x06010F57 RID: 69463 RVA: 0x004F90BC File Offset: 0x004F72BC
	private UniTask InitializeCameraSetup()
	{
		PhotographSetupView.<InitializeCameraSetup>d__52 <InitializeCameraSetup>d__;
		<InitializeCameraSetup>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeCameraSetup>d__.<>4__this = this;
		<InitializeCameraSetup>d__.<>1__state = -1;
		<InitializeCameraSetup>d__.<>t__builder.Start<PhotographSetupView.<InitializeCameraSetup>d__52>(ref <InitializeCameraSetup>d__);
		return <InitializeCameraSetup>d__.<>t__builder.Task;
	}

	// Token: 0x06010F58 RID: 69464 RVA: 0x004F9100 File Offset: 0x004F7300
	private UniTask NewCameraSetupItem(int setupId, EPhotoSetupValueType setupValueType, EPhotoSetupOptionType optionType)
	{
		PhotographSetupView.<NewCameraSetupItem>d__53 <NewCameraSetupItem>d__;
		<NewCameraSetupItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewCameraSetupItem>d__.<>4__this = this;
		<NewCameraSetupItem>d__.setupId = setupId;
		<NewCameraSetupItem>d__.setupValueType = setupValueType;
		<NewCameraSetupItem>d__.optionType = optionType;
		<NewCameraSetupItem>d__.<>1__state = -1;
		<NewCameraSetupItem>d__.<>t__builder.Start<PhotographSetupView.<NewCameraSetupItem>d__53>(ref <NewCameraSetupItem>d__);
		return <NewCameraSetupItem>d__.<>t__builder.Task;
	}

	// Token: 0x06010F59 RID: 69465 RVA: 0x004F915B File Offset: 0x004F735B
	private void OnSetupIndexChanged(int index)
	{
		this.RefreshAllOptionEnable();
		this.SelectDefaultMotion();
	}

	// Token: 0x06010F5A RID: 69466 RVA: 0x004F916C File Offset: 0x004F736C
	[NullableContext(2)]
	private IPhotographSetupItem GetSetupItem(EPhotoSetupValueType valueType)
	{
		IPhotographSetupItem result;
		if (this.SetupItemMap.TryGetValue(valueType, out result))
		{
			return result;
		}
		return null;
	}

	// Token: 0x06010F5B RID: 69467 RVA: 0x004F918C File Offset: 0x004F738C
	private void ClearSetupItem()
	{
		foreach (IPhotographSetupItem photographSetupItem in this.SetupItemMap.Values)
		{
			photographSetupItem.Destroy();
		}
		this.SetupItemMap.Clear();
	}

	// Token: 0x06010F5C RID: 69468 RVA: 0x004F91EC File Offset: 0x004F73EC
	private void SetCameraSetupVisible(bool bVisible)
	{
		foreach (IPhotographSetupItem photographSetupItem in this.SetupItemMap.Values)
		{
			photographSetupItem.SetActive(bVisible);
		}
		if (bVisible)
		{
			this.RefreshAllOptionEnable();
		}
	}

	// Token: 0x06010F5D RID: 69469 RVA: 0x004F924C File Offset: 0x004F744C
	private void RefreshAllOptionEnable()
	{
		foreach (IPhotographSetupItem photographSetupItem in this.SetupItemMap.Values)
		{
			photographSetupItem.SetEnable(true);
		}
		IEnumerable<KeyValuePair<EPhotoSetupValueType, float>> allPhotographOption = PhotographModel.Instance.GetAllPhotographOption();
		PhotographConfig instance = PhotographConfig.Instance;
		foreach (KeyValuePair<EPhotoSetupValueType, float> keyValuePair in allPhotographOption)
		{
			EPhotoSetupValueType key = keyValuePair.Key;
			float value = keyValuePair.Value;
			PhotoSetup? photoSetupConfig = instance.GetPhotoSetupConfig(key);
			if (photoSetupConfig != null && photoSetupConfig.Value.Type == 0)
			{
				IntArray? subOptions = photoSetupConfig.Value.GetSubOptions((int)value);
				if (subOptions != null)
				{
					int arrayIntLength = subOptions.Value.ArrayIntLength;
					for (int i = 0; i < arrayIntLength; i++)
					{
						EPhotoSetupValueType valueType = (EPhotoSetupValueType)subOptions.Value.ArrayInt(i);
						IPhotographSetupItem setupItem = this.GetSetupItem(valueType);
						if (setupItem != null)
						{
							setupItem.SetEnable(false);
						}
					}
				}
			}
		}
	}

	// Token: 0x06010F5E RID: 69470 RVA: 0x004F938C File Offset: 0x004F758C
	private UniTask InitializeFilterSetup()
	{
		PhotographSetupView.<InitializeFilterSetup>d__59 <InitializeFilterSetup>d__;
		<InitializeFilterSetup>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeFilterSetup>d__.<>4__this = this;
		<InitializeFilterSetup>d__.<>1__state = -1;
		<InitializeFilterSetup>d__.<>t__builder.Start<PhotographSetupView.<InitializeFilterSetup>d__59>(ref <InitializeFilterSetup>d__);
		return <InitializeFilterSetup>d__.<>t__builder.Task;
	}

	// Token: 0x06010F5F RID: 69471 RVA: 0x004F93D0 File Offset: 0x004F75D0
	private UniTask NewFilterItem(int filterId)
	{
		PhotographSetupView.<NewFilterItem>d__60 <NewFilterItem>d__;
		<NewFilterItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<NewFilterItem>d__.<>4__this = this;
		<NewFilterItem>d__.filterId = filterId;
		<NewFilterItem>d__.<>1__state = -1;
		<NewFilterItem>d__.<>t__builder.Start<PhotographSetupView.<NewFilterItem>d__60>(ref <NewFilterItem>d__);
		return <NewFilterItem>d__.<>t__builder.Task;
	}

	// Token: 0x06010F60 RID: 69472 RVA: 0x004F941C File Offset: 0x004F761C
	private void ClearFilterItem()
	{
		foreach (PhotoFilterItem photoFilterItem in this.FilterItemMap.Values)
		{
			photoFilterItem.Destroy(null);
		}
		this.FilterItemMap.Clear();
		this.SelectedFilterItem = null;
	}

	// Token: 0x06010F61 RID: 69473 RVA: 0x004F9484 File Offset: 0x004F7684
	private void SetFilterVisible(bool bVisible)
	{
		this.FilterToggleItem.SetActive(bVisible);
		if (!bVisible)
		{
			this.SetFilterOptionVisible(false, false);
			return;
		}
		UUIInturnAnimController animationController = this.AnimationController;
		if (animationController == null)
		{
			return;
		}
		animationController.Play("Start02", -1, false);
	}

	// Token: 0x06010F62 RID: 69474 RVA: 0x004F94B8 File Offset: 0x004F76B8
	private void SetFilterOptionVisible(bool bVisible, bool isClickToggle = false)
	{
		foreach (PhotoFilterItem photoFilterItem in this.FilterItemMap.Values)
		{
			if (bVisible)
			{
				photoFilterItem.ShowFilterItem();
				int photographFilter = PhotographModel.Instance.GetPhotographFilter();
				if (photoFilterItem.GetPhotoFilterId() == photographFilter)
				{
					this.SelectedFilterItem = photoFilterItem;
				}
			}
			else
			{
				photoFilterItem.PlayDisappearSequence(isClickToggle);
			}
		}
		if (bVisible && isClickToggle)
		{
			UUIInturnAnimController animationController = this.AnimationController;
			if (animationController != null)
			{
				animationController.Play("SwitchIn", -1, false);
			}
		}
		PhotoFilterItem photoFilterItem2;
		if (bVisible && this.SelectedFilterItem == null && this.FilterItemMap.TryGetValue(1, out photoFilterItem2))
		{
			PhotographModel.Instance.SetPhotographFilter(photoFilterItem2.GetPhotoFilterId());
			this.SelectedFilterItem = photoFilterItem2;
			this.SelectedFilterItem.SetSelected(true, false);
		}
	}

	// Token: 0x06010F63 RID: 69475 RVA: 0x004F9594 File Offset: 0x004F7794
	private void OnSelectedFilterItem(PhotoFilterItem filterItem, bool bSelectOn)
	{
		if (bSelectOn)
		{
			this.SelectOnFilterItem(filterItem);
		}
	}

	// Token: 0x06010F64 RID: 69476 RVA: 0x004F95A0 File Offset: 0x004F77A0
	private void SelectOnFilterItem(PhotoFilterItem filterItem)
	{
		if (this.SelectedFilterItem != null)
		{
			this.SelectedFilterItem.SetSelected(false, false);
		}
		this.SelectedFilterItem = filterItem;
		this.SelectedFilterItem.SetSelected(true, false);
		this.ScrollToSelectedItem(this.SelectedFilterItem);
	}

	// Token: 0x06010F65 RID: 69477 RVA: 0x004F95D7 File Offset: 0x004F77D7
	private void DeselectOnFilterItem()
	{
		if (this.SelectedFilterItem != null)
		{
			this.SelectedFilterItem.SetSelected(false, false);
			this.SelectedFilterItem = null;
			PhotographModel.Instance.ClearSelectedPhotographFilter();
		}
	}

	// Token: 0x04009573 RID: 38259
	private int SkinId;

	// Token: 0x04009574 RID: 38260
	private EPhotoSettingMode PhotoSetupMode = EPhotoSettingMode.CameraSetup;

	// Token: 0x04009575 RID: 38261
	private ERoleMainAnimInstanceType RoleAnimType = ERoleMainAnimInstanceType.CommonAnim;

	// Token: 0x04009576 RID: 38262
	private readonly HashSet<PhotographExpressionItem> ExpressionItemSet = new HashSet<PhotographExpressionItem>();

	// Token: 0x04009577 RID: 38263
	private readonly Dictionary<int, PhotographExpressionItem> MotionItemMap = new Dictionary<int, PhotographExpressionItem>();

	// Token: 0x04009578 RID: 38264
	private readonly Dictionary<int, PhotoFilterItem> FilterItemMap = new Dictionary<int, PhotoFilterItem>();

	// Token: 0x04009579 RID: 38265
	[Nullable(2)]
	private PhotoFilterToggleItem FilterToggleItem;

	// Token: 0x0400957A RID: 38266
	[Nullable(2)]
	private PhotographTab PhotoFilterTab;

	// Token: 0x0400957B RID: 38267
	[Nullable(2)]
	private PhotographExpressionItem SelectedExpressionItem;

	// Token: 0x0400957C RID: 38268
	[Nullable(2)]
	private PhotographExpressionItem SelectedMotionItem;

	// Token: 0x0400957D RID: 38269
	[Nullable(2)]
	private PhotoFilterItem SelectedFilterItem;

	// Token: 0x0400957E RID: 38270
	public UUIScrollViewWithScrollbarComponent UiScrollView;

	// Token: 0x0400957F RID: 38271
	private readonly Dictionary<EPhotoSetupValueType, IPhotographSetupItem> SetupItemMap = new Dictionary<EPhotoSetupValueType, IPhotographSetupItem>();

	// Token: 0x04009580 RID: 38272
	[Nullable(2)]
	private UUIInturnAnimController AnimationController;

	// Token: 0x04009581 RID: 38273
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<EPhotoSettingMode, UUIExtendToggle> TabItemMap = new Dictionary<EPhotoSettingMode, UUIExtendToggle>();

	// Token: 0x02007D69 RID: 32105
	[NullableContext(0)]
	private enum ESetUpChildNode
	{
		// Token: 0x0402899A RID: 166298
		TabSet,
		// Token: 0x0402899B RID: 166299
		TabEmotion,
		// Token: 0x0402899C RID: 166300
		TabMotion,
		// Token: 0x0402899D RID: 166301
		LayoutContent,
		// Token: 0x0402899E RID: 166302
		ItemExpressionSource,
		// Token: 0x0402899F RID: 166303
		ItemOptionSetupSource,
		// Token: 0x040289A0 RID: 166304
		ItemValueSetupSource,
		// Token: 0x040289A1 RID: 166305
		ButtonBack,
		// Token: 0x040289A2 RID: 166306
		ItemExpressionDefault,
		// Token: 0x040289A3 RID: 166307
		TabFilter,
		// Token: 0x040289A4 RID: 166308
		ItemFilterSource,
		// Token: 0x040289A5 RID: 166309
		PanelAll,
		// Token: 0x040289A6 RID: 166310
		ScrollView,
		// Token: 0x040289A7 RID: 166311
		ItemDropDownSetupSource,
		// Token: 0x040289A8 RID: 166312
		ItemValueWithoutTitleSetupSource,
		// Token: 0x040289A9 RID: 166313
		RedDot,
		// Token: 0x040289AA RID: 166314
		PanelHideOnly
	}
}
