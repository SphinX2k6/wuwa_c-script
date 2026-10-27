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

// Token: 0x020025D4 RID: 9684
[NullableContext(1)]
[Nullable(0)]
public class PhotographSetupView : UiViewBase
{
	// Token: 0x06013A53 RID: 80467 RVA: 0x004E99F8 File Offset: 0x004E7BF8
	public PhotographSetupView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06013A54 RID: 80468 RVA: 0x004E9A54 File Offset: 0x004E7C54
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

	// Token: 0x06013A55 RID: 80469 RVA: 0x004E9C6E File Offset: 0x004E7E6E
	private void OnClickedCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x06013A56 RID: 80470 RVA: 0x004E9C77 File Offset: 0x004E7E77
	private void OnClickedExpression(EToggleState toggleState)
	{
		this.RefreshTabState(EPhotoSettingMode.ExpressionSetup);
	}

	// Token: 0x06013A57 RID: 80471 RVA: 0x004E9C80 File Offset: 0x004E7E80
	private void OnClickedSetup(EToggleState toggleState)
	{
		this.RefreshTabState(EPhotoSettingMode.CameraSetup);
	}

	// Token: 0x06013A58 RID: 80472 RVA: 0x004E9C89 File Offset: 0x004E7E89
	private void OnClickedMotion(EToggleState toggleState)
	{
		this.RefreshTabState(EPhotoSettingMode.MotionSetup);
	}

	// Token: 0x06013A59 RID: 80473 RVA: 0x004E9C94 File Offset: 0x004E7E94
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

	// Token: 0x06013A5A RID: 80474 RVA: 0x004E9CF8 File Offset: 0x004E7EF8
	protected override UniTask OnBeforeStartAsync()
	{
		PhotographSetupView.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhotographSetupView.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013A5B RID: 80475 RVA: 0x004E9D3C File Offset: 0x004E7F3C
	protected override void OnStart()
	{
		this.AnimationController = (base.GetItem(3).GetOwner().GetComponentByClass(UUIInturnAnimController.StaticClass()) as UUIInturnAnimController);
		this.SelectTabToggle(this.PhotoSetupMode, true, true);
		this.SelectDefaultMotion();
		this.UiScrollView = base.GetScrollViewWithScrollbar(12);
		base.GetItem(16).SetUIActive(false);
	}

	// Token: 0x06013A5C RID: 80476 RVA: 0x004E9DA0 File Offset: 0x004E7FA0
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

	// Token: 0x06013A5D RID: 80477 RVA: 0x004E9DF0 File Offset: 0x004E7FF0
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

	// Token: 0x06013A5E RID: 80478 RVA: 0x004E9E30 File Offset: 0x004E8030
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

	// Token: 0x06013A5F RID: 80479 RVA: 0x004E9E6D File Offset: 0x004E806D
	protected override void OnBeforeShow()
	{
		EventSystem.Instance.Emit<bool>(EEventName.OnPhotographSetUpViewVisibleChanged, true);
	}

	// Token: 0x06013A60 RID: 80480 RVA: 0x004E9E80 File Offset: 0x004E8080
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Emit<bool>(EEventName.OnPhotographSetUpViewVisibleChanged, false);
	}

	// Token: 0x06013A61 RID: 80481 RVA: 0x004E9E93 File Offset: 0x004E8093
	public void SetPanelVisible(bool isShow)
	{
		base.GetItem(11).SetUIActive(isShow);
		base.GetItem(16).SetUIActive(!isShow);
	}

	// Token: 0x06013A62 RID: 80482 RVA: 0x004E9EB4 File Offset: 0x004E80B4
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

	// Token: 0x06013A63 RID: 80483 RVA: 0x004E9F54 File Offset: 0x004E8154
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

	// Token: 0x06013A64 RID: 80484 RVA: 0x004E9FC4 File Offset: 0x004E81C4
	private void SelectTabToggle(EPhotoSettingMode newMode, bool selectOn, bool bFireEvent = false)
	{
		EToggleState state = selectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle uuiextendToggle;
		if (this.TabItemMap.TryGetValue(newMode, out uuiextendToggle))
		{
			uuiextendToggle.SetToggleStateForce(state, bFireEvent, false, false);
		}
	}

	// Token: 0x06013A65 RID: 80485 RVA: 0x004E9FF3 File Offset: 0x004E81F3
	private void SetPhotoSetupMode(EPhotoSettingMode newMode)
	{
		this.PhotoSetupMode = newMode;
		this.SetCameraSetupVisible(newMode == EPhotoSettingMode.CameraSetup);
		this.SetExpressionVisible(newMode == EPhotoSettingMode.ExpressionSetup);
		this.SetMotionVisible(newMode == EPhotoSettingMode.MotionSetup);
		this.SetFilterVisible(newMode == EPhotoSettingMode.FilterSetup);
	}

	// Token: 0x06013A66 RID: 80486 RVA: 0x004EA024 File Offset: 0x004E8224
	private UniTask InitializeExpressionSetup()
	{
		PhotographSetupView.<InitializeExpressionSetup>d__35 <InitializeExpressionSetup>d__;
		<InitializeExpressionSetup>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeExpressionSetup>d__.<>4__this = this;
		<InitializeExpressionSetup>d__.<>1__state = -1;
		<InitializeExpressionSetup>d__.<>t__builder.Start<PhotographSetupView.<InitializeExpressionSetup>d__35>(ref <InitializeExpressionSetup>d__);
		return <InitializeExpressionSetup>d__.<>t__builder.Task;
	}

	// Token: 0x06013A67 RID: 80487 RVA: 0x004EA068 File Offset: 0x004E8268
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

	// Token: 0x06013A68 RID: 80488 RVA: 0x004EA0B4 File Offset: 0x004E82B4
	private void ClearExpressionItem()
	{
		foreach (PhotographExpressionItem photographExpressionItem in this.ExpressionItemSet)
		{
			photographExpressionItem.Destroy(null);
		}
		this.ExpressionItemSet.Clear();
		this.SelectedExpressionItem = null;
	}

	// Token: 0x06013A69 RID: 80489 RVA: 0x004EA118 File Offset: 0x004E8318
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

	// Token: 0x06013A6A RID: 80490 RVA: 0x004EA180 File Offset: 0x004E8380
	private void OnSelectedExpressionItem(PhotographExpressionItem expressionItem, bool bSelectOn)
	{
		if (bSelectOn)
		{
			this.SelectOnExpressionItem(expressionItem);
			return;
		}
		this.DeselectOnExpressionItem(expressionItem);
	}

	// Token: 0x06013A6B RID: 80491 RVA: 0x004EA194 File Offset: 0x004E8394
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

	// Token: 0x06013A6C RID: 80492 RVA: 0x004EA1F4 File Offset: 0x004E83F4
	private void DeselectOnExpressionItem(PhotographExpressionItem expressionItem)
	{
		if (this.SelectedExpressionItem != expressionItem)
		{
			return;
		}
		PhotographController.Instance.ResetPhotoMontage();
		this.SelectedExpressionItem = null;
	}

	// Token: 0x06013A6D RID: 80493 RVA: 0x004EA214 File Offset: 0x004E8414
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

	// Token: 0x06013A6E RID: 80494 RVA: 0x004EA278 File Offset: 0x004E8478
	private UniTask InitializeMotionSetup()
	{
		PhotographSetupView.<InitializeMotionSetup>d__43 <InitializeMotionSetup>d__;
		<InitializeMotionSetup>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeMotionSetup>d__.<>4__this = this;
		<InitializeMotionSetup>d__.<>1__state = -1;
		<InitializeMotionSetup>d__.<>t__builder.Start<PhotographSetupView.<InitializeMotionSetup>d__43>(ref <InitializeMotionSetup>d__);
		return <InitializeMotionSetup>d__.<>t__builder.Task;
	}

	// Token: 0x06013A6F RID: 80495 RVA: 0x004EA2BC File Offset: 0x004E84BC
	private UniTask CreateDefaultMotionItem()
	{
		PhotographSetupView.<CreateDefaultMotionItem>d__44 <CreateDefaultMotionItem>d__;
		<CreateDefaultMotionItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateDefaultMotionItem>d__.<>4__this = this;
		<CreateDefaultMotionItem>d__.<>1__state = -1;
		<CreateDefaultMotionItem>d__.<>t__builder.Start<PhotographSetupView.<CreateDefaultMotionItem>d__44>(ref <CreateDefaultMotionItem>d__);
		return <CreateDefaultMotionItem>d__.<>t__builder.Task;
	}

	// Token: 0x06013A70 RID: 80496 RVA: 0x004EA300 File Offset: 0x004E8500
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

	// Token: 0x06013A71 RID: 80497 RVA: 0x004EA34C File Offset: 0x004E854C
	private void SetMotionVisible(bool bVisible)
	{
		foreach (PhotographExpressionItem photographExpressionItem in this.MotionItemMap.Values)
		{
			photographExpressionItem.SetActive(bVisible);
		}
	}

	// Token: 0x06013A72 RID: 80498 RVA: 0x004EA3A4 File Offset: 0x004E85A4
	private void ClearMotionItem()
	{
		foreach (PhotographExpressionItem photographExpressionItem in this.MotionItemMap.Values)
		{
			photographExpressionItem.Destroy(null);
		}
		this.MotionItemMap.Clear();
		this.SelectedMotionItem = null;
	}

	// Token: 0x06013A73 RID: 80499 RVA: 0x004EA40C File Offset: 0x004E860C
	private bool OnCanExecuteChangeFunc(PhotographExpressionItem motionItem)
	{
		return this.SelectedMotionItem != motionItem;
	}

	// Token: 0x06013A74 RID: 80500 RVA: 0x004EA41A File Offset: 0x004E861A
	private void OnSelectedMotionItem(PhotographExpressionItem motionItem, bool bSelectOn)
	{
		if (bSelectOn)
		{
			this.SelectOnMotionItem(motionItem);
			return;
		}
		this.DeselectOnMotionItem(motionItem);
	}

	// Token: 0x06013A75 RID: 80501 RVA: 0x004EA430 File Offset: 0x004E8630
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

	// Token: 0x06013A76 RID: 80502 RVA: 0x004EA49F File Offset: 0x004E869F
	private void DeselectOnMotionItem(PhotographExpressionItem motionItem)
	{
		if (this.SelectedMotionItem != motionItem)
		{
			return;
		}
		PhotographController.Instance.ResetPhotoMontage();
		this.SelectedMotionItem = null;
	}

	// Token: 0x06013A77 RID: 80503 RVA: 0x004EA4BC File Offset: 0x004E86BC
	private UniTask InitializeCameraSetup()
	{
		PhotographSetupView.<InitializeCameraSetup>d__52 <InitializeCameraSetup>d__;
		<InitializeCameraSetup>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeCameraSetup>d__.<>4__this = this;
		<InitializeCameraSetup>d__.<>1__state = -1;
		<InitializeCameraSetup>d__.<>t__builder.Start<PhotographSetupView.<InitializeCameraSetup>d__52>(ref <InitializeCameraSetup>d__);
		return <InitializeCameraSetup>d__.<>t__builder.Task;
	}

	// Token: 0x06013A78 RID: 80504 RVA: 0x004EA500 File Offset: 0x004E8700
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

	// Token: 0x06013A79 RID: 80505 RVA: 0x004EA55B File Offset: 0x004E875B
	private void OnSetupIndexChanged(int index)
	{
		this.RefreshAllOptionEnable();
		this.SelectDefaultMotion();
	}

	// Token: 0x06013A7A RID: 80506 RVA: 0x004EA56C File Offset: 0x004E876C
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

	// Token: 0x06013A7B RID: 80507 RVA: 0x004EA58C File Offset: 0x004E878C
	private void ClearSetupItem()
	{
		foreach (IPhotographSetupItem photographSetupItem in this.SetupItemMap.Values)
		{
			photographSetupItem.Destroy();
		}
		this.SetupItemMap.Clear();
	}

	// Token: 0x06013A7C RID: 80508 RVA: 0x004EA5EC File Offset: 0x004E87EC
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

	// Token: 0x06013A7D RID: 80509 RVA: 0x004EA64C File Offset: 0x004E884C
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

	// Token: 0x06013A7E RID: 80510 RVA: 0x004EA78C File Offset: 0x004E898C
	private UniTask InitializeFilterSetup()
	{
		PhotographSetupView.<InitializeFilterSetup>d__59 <InitializeFilterSetup>d__;
		<InitializeFilterSetup>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitializeFilterSetup>d__.<>4__this = this;
		<InitializeFilterSetup>d__.<>1__state = -1;
		<InitializeFilterSetup>d__.<>t__builder.Start<PhotographSetupView.<InitializeFilterSetup>d__59>(ref <InitializeFilterSetup>d__);
		return <InitializeFilterSetup>d__.<>t__builder.Task;
	}

	// Token: 0x06013A7F RID: 80511 RVA: 0x004EA7D0 File Offset: 0x004E89D0
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

	// Token: 0x06013A80 RID: 80512 RVA: 0x004EA81C File Offset: 0x004E8A1C
	private void ClearFilterItem()
	{
		foreach (PhotoFilterItem photoFilterItem in this.FilterItemMap.Values)
		{
			photoFilterItem.Destroy(null);
		}
		this.FilterItemMap.Clear();
		this.SelectedFilterItem = null;
	}

	// Token: 0x06013A81 RID: 80513 RVA: 0x004EA884 File Offset: 0x004E8A84
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

	// Token: 0x06013A82 RID: 80514 RVA: 0x004EA8B8 File Offset: 0x004E8AB8
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

	// Token: 0x06013A83 RID: 80515 RVA: 0x004EA994 File Offset: 0x004E8B94
	private void OnSelectedFilterItem(PhotoFilterItem filterItem, bool bSelectOn)
	{
		if (bSelectOn)
		{
			this.SelectOnFilterItem(filterItem);
		}
	}

	// Token: 0x06013A84 RID: 80516 RVA: 0x004EA9A0 File Offset: 0x004E8BA0
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

	// Token: 0x06013A85 RID: 80517 RVA: 0x004EA9D7 File Offset: 0x004E8BD7
	private void DeselectOnFilterItem()
	{
		if (this.SelectedFilterItem != null)
		{
			this.SelectedFilterItem.SetSelected(false, false);
			this.SelectedFilterItem = null;
			PhotographModel.Instance.ClearSelectedPhotographFilter();
		}
	}

	// Token: 0x0400941D RID: 37917
	private int SkinId;

	// Token: 0x0400941E RID: 37918
	private EPhotoSettingMode PhotoSetupMode = EPhotoSettingMode.CameraSetup;

	// Token: 0x0400941F RID: 37919
	private ERoleMainAnimInstanceType RoleAnimType = ERoleMainAnimInstanceType.CommonAnim;

	// Token: 0x04009420 RID: 37920
	private readonly HashSet<PhotographExpressionItem> ExpressionItemSet = new HashSet<PhotographExpressionItem>();

	// Token: 0x04009421 RID: 37921
	private readonly Dictionary<int, PhotographExpressionItem> MotionItemMap = new Dictionary<int, PhotographExpressionItem>();

	// Token: 0x04009422 RID: 37922
	private readonly Dictionary<int, PhotoFilterItem> FilterItemMap = new Dictionary<int, PhotoFilterItem>();

	// Token: 0x04009423 RID: 37923
	[Nullable(2)]
	private PhotoFilterToggleItem FilterToggleItem;

	// Token: 0x04009424 RID: 37924
	[Nullable(2)]
	private PhotographTab PhotoFilterTab;

	// Token: 0x04009425 RID: 37925
	[Nullable(2)]
	private PhotographExpressionItem SelectedExpressionItem;

	// Token: 0x04009426 RID: 37926
	[Nullable(2)]
	private PhotographExpressionItem SelectedMotionItem;

	// Token: 0x04009427 RID: 37927
	[Nullable(2)]
	private PhotoFilterItem SelectedFilterItem;

	// Token: 0x04009428 RID: 37928
	public UUIScrollViewWithScrollbarComponent UiScrollView;

	// Token: 0x04009429 RID: 37929
	private readonly Dictionary<EPhotoSetupValueType, IPhotographSetupItem> SetupItemMap = new Dictionary<EPhotoSetupValueType, IPhotographSetupItem>();

	// Token: 0x0400942A RID: 37930
	[Nullable(2)]
	private UUIInturnAnimController AnimationController;

	// Token: 0x0400942B RID: 37931
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<EPhotoSettingMode, UUIExtendToggle> TabItemMap = new Dictionary<EPhotoSettingMode, UUIExtendToggle>();

	// Token: 0x02008BE1 RID: 35809
	[NullableContext(0)]
	private enum ESetUpChildNode
	{
		// Token: 0x0402D685 RID: 185989
		TabSet,
		// Token: 0x0402D686 RID: 185990
		TabEmotion,
		// Token: 0x0402D687 RID: 185991
		TabMotion,
		// Token: 0x0402D688 RID: 185992
		LayoutContent,
		// Token: 0x0402D689 RID: 185993
		ItemExpressionSource,
		// Token: 0x0402D68A RID: 185994
		ItemOptionSetupSource,
		// Token: 0x0402D68B RID: 185995
		ItemValueSetupSource,
		// Token: 0x0402D68C RID: 185996
		ButtonBack,
		// Token: 0x0402D68D RID: 185997
		ItemExpressionDefault,
		// Token: 0x0402D68E RID: 185998
		TabFilter,
		// Token: 0x0402D68F RID: 185999
		ItemFilterSource,
		// Token: 0x0402D690 RID: 186000
		PanelAll,
		// Token: 0x0402D691 RID: 186001
		ScrollView,
		// Token: 0x0402D692 RID: 186002
		ItemDropDownSetupSource,
		// Token: 0x0402D693 RID: 186003
		ItemValueWithoutTitleSetupSource,
		// Token: 0x0402D694 RID: 186004
		RedDot,
		// Token: 0x0402D695 RID: 186005
		PanelHideOnly
	}
}
