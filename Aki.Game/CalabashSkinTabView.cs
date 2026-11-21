using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Skin.Skip;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001FBD RID: 8125
[NullableContext(1)]
[Nullable(0)]
public class CalabashSkinTabView : UiTabViewBase
{
	// Token: 0x0601429E RID: 82590 RVA: 0x005E25A8 File Offset: 0x005E07A8
	protected unsafe override void OnRegisterComponent()
	{
		int num = 10;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUILayoutBase));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIDraggableComponent));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.OnCalabashHideUiClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnCalabashConfirmBtnClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601429F RID: 82591 RVA: 0x005E277C File Offset: 0x005E097C
	protected override void OnStart()
	{
		this.RootViewModel = (this.ExtraParams as SkinRootViewModel);
		this.ViewModel = new CalabashSkinViewProxy();
		this.ViewModel.Init(this.RootViewModel.ViewData);
		this.ViewModel.SetGetDragItemFunc(new Func<UUIDraggableComponent>(this.GetDragItem));
		this.ViewModel.Bind(new Action<ECalabashSkinViewData>(this.OnViewModelUpdate));
		this.Draggable = base.GetDraggable(9);
		this.Draggable.RootUIComp.Get().SetUIActive(false);
		this.InitGrid();
		this.InitHuluObserver();
		this.TsUiSceneRoleActor = UiSceneManager.Instance.GetRoleSystemRoleActor();
		this.ObtainLayout = new GenericLayout<SkinObtainItem, ISkinSkipData>(base.GetLayoutBase(5), new Func<SkinObtainItem>(this.InitObtainItem), base.GetItem(6).GetOwner() as AUIBaseActor, false, true);
		UUIExtendToggle extendToggle = base.GetExtendToggle(3);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x060142A0 RID: 82592 RVA: 0x005E2873 File Offset: 0x005E0A73
	protected override void OnBeforeShow()
	{
		this.RootViewModel.SetModelState(EModelStateInSkinView.ShowCalabash, false);
		this.UpdateSelectedGrid();
		this.TryPushCamera();
	}

	// Token: 0x060142A1 RID: 82593 RVA: 0x005E2890 File Offset: 0x005E0A90
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		CalabashSkinTabView.<OnBeforeShowAsyncImplement>d__12 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<CalabashSkinTabView.<OnBeforeShowAsyncImplement>d__12>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x060142A2 RID: 82594 RVA: 0x005E28D3 File Offset: 0x005E0AD3
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
	}

	// Token: 0x060142A3 RID: 82595 RVA: 0x005E28F1 File Offset: 0x005E0AF1
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
	}

	// Token: 0x060142A4 RID: 82596 RVA: 0x005E290F File Offset: 0x005E0B0F
	protected override void OnBeforeHide()
	{
		this.HideHuluObserver();
	}

	// Token: 0x060142A5 RID: 82597 RVA: 0x005E2917 File Offset: 0x005E0B17
	protected override void OnBeforeDestroy()
	{
		this.ViewModel.UnBind(new Action<ECalabashSkinViewData>(this.OnViewModelUpdate));
		this.ReleaseHuluObserver();
		this.RemoveTimeHandler();
	}

	// Token: 0x060142A6 RID: 82598 RVA: 0x005E293C File Offset: 0x005E0B3C
	private void InitGrid()
	{
		this.GridLayout = new GenericLayout<CalabashSkinGridItem, CalabashSkinData>(base.GetLayoutBase(1), new Func<CalabashSkinGridItem>(this.InitGridItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x060142A7 RID: 82599 RVA: 0x005E296F File Offset: 0x005E0B6F
	private CalabashSkinGridItem InitGridItem()
	{
		CalabashSkinGridItem calabashSkinGridItem = new CalabashSkinGridItem();
		calabashSkinGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnCalabashGridItemClick));
		calabashSkinGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.ViewModel.CalabashGridItemCanExecuteChange));
		return calabashSkinGridItem;
	}

	// Token: 0x060142A8 RID: 82600 RVA: 0x005E299F File Offset: 0x005E0B9F
	private SkinObtainItem InitObtainItem()
	{
		return new SkinObtainItem();
	}

	// Token: 0x060142A9 RID: 82601 RVA: 0x005E29A8 File Offset: 0x005E0BA8
	private void InitHuluObserver()
	{
		this.HuluObserver = UiSceneManager.Instance.InitHuluObserver();
		UiModelBase model = this.HuluObserver.Model;
		UiModelActorComponent uiModelActorComponent = model.CheckGetComponent<UiModelActorComponent>();
		if (uiModelActorComponent != null)
		{
			uiModelActorComponent.SetTransformByTag("TerminalCase");
		}
		UiModelDataComponent uiModelDataComponent = model.CheckGetComponent<UiModelDataComponent>();
		if (uiModelDataComponent == null)
		{
			return;
		}
		uiModelDataComponent.SetLoadingIconFollowState(false);
	}

	// Token: 0x060142AA RID: 82602 RVA: 0x005E29F6 File Offset: 0x005E0BF6
	private void HideHuluObserver()
	{
		if (this.HuluObserver != null)
		{
			UiSceneManager.Instance.HideObserver(this.HuluObserver, "ShowHideWeaponEffect");
		}
	}

	// Token: 0x060142AB RID: 82603 RVA: 0x005E2A15 File Offset: 0x005E0C15
	private void ShowHuluObserver(int skinId)
	{
		CalabashSkinController instance = CalabashSkinController.Instance;
		int roleId = this.RootViewModel.RoleId;
		SkeletalObserverHandle huluObserver = this.HuluObserver;
		instance.SelectedCalabashSkinChange(skinId, roleId, (huluObserver != null) ? huluObserver.Model : null, "TerminalCase");
	}

	// Token: 0x060142AC RID: 82604 RVA: 0x005E2A44 File Offset: 0x005E0C44
	public void SwitchHuluRotate(bool needStop)
	{
		SkeletalObserverHandle huluObserver = this.HuluObserver;
		UiModelRotateComponent uiModelRotateComponent;
		if (huluObserver == null)
		{
			uiModelRotateComponent = null;
		}
		else
		{
			UiModelBase model = huluObserver.Model;
			uiModelRotateComponent = ((model != null) ? model.CheckGetComponent<UiModelRotateComponent>() : null);
		}
		UiModelRotateComponent uiModelRotateComponent2 = uiModelRotateComponent;
		if (needStop)
		{
			if (uiModelRotateComponent2 != null)
			{
				uiModelRotateComponent2.StopRotate();
				return;
			}
		}
		else if (uiModelRotateComponent2 != null)
		{
			uiModelRotateComponent2.StartRotate();
		}
	}

	// Token: 0x060142AD RID: 82605 RVA: 0x005E2A86 File Offset: 0x005E0C86
	public void ReleaseHuluObserver()
	{
		if (this.HuluObserver != null)
		{
			UiSceneManager.Instance.HideObserverWithCallback(this.HuluObserver, "ShowHideWeaponEffect", delegate(SkeletalObserverHandle observer)
			{
				UiSceneManager.Instance.DestroyHuluObserver();
			});
		}
	}

	// Token: 0x060142AE RID: 82606 RVA: 0x005E2AC4 File Offset: 0x005E0CC4
	public void HideView()
	{
		this.Draggable.RootUIComp.Get().SetUIActive(true);
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.RootViewModel.SetRootUiVisible(false, false);
		this.RootViewModel.SetMoveGamepadKeyTipActive(true, false);
	}

	// Token: 0x060142AF RID: 82607 RVA: 0x005E2B18 File Offset: 0x005E0D18
	public void ShowView()
	{
		this.RootViewModel.SetMoveGamepadKeyTipActive(false, false);
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		this.RootViewModel.SetRootUiVisible(true, false);
		this.Draggable.RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x060142B0 RID: 82608 RVA: 0x005E2B6B File Offset: 0x005E0D6B
	public void SelectedGrid(int index)
	{
		this.GridLayout.DeselectCurrentGridProxy();
		this.GridLayout.SelectGridProxy(index, true);
	}

	// Token: 0x060142B1 RID: 82609 RVA: 0x005E2B85 File Offset: 0x005E0D85
	public void RefreshText(string name, string bgDescription)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), bgDescription, Array.Empty<object>());
	}

	// Token: 0x060142B2 RID: 82610 RVA: 0x005E2BB5 File Offset: 0x005E0DB5
	public void RefreshConfirmBox(bool isSame)
	{
		UUIButtonComponent button = base.GetButton(4);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(!isSame);
	}

	// Token: 0x060142B3 RID: 82611 RVA: 0x005E2BCC File Offset: 0x005E0DCC
	public void RefreshGridSelect(int lastIndex, int nowIndex)
	{
		CalabashSkinGridItem layoutItemByIndex = this.GridLayout.GetLayoutItemByIndex(lastIndex);
		if (layoutItemByIndex != null)
		{
			layoutItemByIndex.RefreshVisible();
		}
		CalabashSkinGridItem layoutItemByIndex2 = this.GridLayout.GetLayoutItemByIndex(nowIndex);
		if (layoutItemByIndex2 == null)
		{
			return;
		}
		layoutItemByIndex2.RefreshVisible();
	}

	// Token: 0x060142B4 RID: 82612 RVA: 0x005E2BFC File Offset: 0x005E0DFC
	public void RefreshBottom(CalabashSkinData data, bool isSame)
	{
		bool isLock = data.GetIsLock();
		UUIButtonComponent button = base.GetButton(4);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(!isLock);
		}
		this.ObtainLayout.SetActive(isLock);
		if (isLock)
		{
			CalabashSkin calabashSkinConfig = SkinConfig.Instance.GetCalabashSkinConfig(data.SkinId);
			List<ISkinSkipData> skinSkipDataList = this.RootViewModel.GetSkinSkipDataList(data.SkinId, calabashSkinConfig.ItemAccess());
			this.ObtainLayout.SetActive(skinSkipDataList.Count != 0);
			if (skinSkipDataList.Count > 0)
			{
				this.ObtainLayout.RefreshByData(skinSkipDataList, null, false);
				return;
			}
		}
		else
		{
			UUIButtonComponent button2 = base.GetButton(4);
			if (button2 == null)
			{
				return;
			}
			button2.SetSelfInteractive(!isSame);
		}
	}

	// Token: 0x060142B5 RID: 82613 RVA: 0x005E2CAD File Offset: 0x005E0EAD
	public void ShowEquipTips()
	{
		ScrollingTipsController.Instance.ShowTipsByTextId("TerminalSkin_Change_Success", Array.Empty<object>());
	}

	// Token: 0x060142B6 RID: 82614 RVA: 0x005E2CC3 File Offset: 0x005E0EC3
	public void SwitchHuluObserver(int skinId)
	{
		CalabashSkinController instance = CalabashSkinController.Instance;
		int roleId = this.RootViewModel.RoleId;
		SkeletalObserverHandle huluObserver = this.HuluObserver;
		instance.SelectedCalabashSkinChange(skinId, roleId, (huluObserver != null) ? huluObserver.Model : null, "TerminalCase");
	}

	// Token: 0x060142B7 RID: 82615 RVA: 0x005E2CF4 File Offset: 0x005E0EF4
	public void RefreshMainRoleHulu()
	{
		UiModelBase model = this.TsUiSceneRoleActor.Model;
		UiRoleHuluComponent uiRoleHuluComponent = (model != null) ? model.GetComponent<UiRoleHuluComponent>() : null;
		if (uiRoleHuluComponent != null)
		{
			uiRoleHuluComponent.Refresh();
		}
	}

	// Token: 0x060142B8 RID: 82616 RVA: 0x005E2D24 File Offset: 0x005E0F24
	private void OnViewModelUpdate(ECalabashSkinViewData data)
	{
		if (data == ECalabashSkinViewData.EquipSkinId)
		{
			int dataIndexBySkinId = this.ViewModel.GetDataIndexBySkinId(this.ViewModel.PrevEquipSkinId);
			int dataIndexBySkinId2 = this.ViewModel.GetDataIndexBySkinId(this.ViewModel.GetSelectedSkinId());
			this.RefreshGridSelect(dataIndexBySkinId, dataIndexBySkinId2);
			this.RefreshConfirmBox(true);
			this.ShowEquipTips();
			this.RefreshMainRoleHulu();
			return;
		}
		if (data == ECalabashSkinViewData.SelectedSkinId)
		{
			int selectedSkinId = this.ViewModel.GetSelectedSkinId();
			this.UpdateSelectedGrid();
			this.SwitchHuluObserver(selectedSkinId);
		}
	}

	// Token: 0x060142B9 RID: 82617 RVA: 0x005E2D9C File Offset: 0x005E0F9C
	private UUIDraggableComponent GetDragItem()
	{
		return base.GetDraggable(9);
	}

	// Token: 0x060142BA RID: 82618 RVA: 0x005E2DA8 File Offset: 0x005E0FA8
	private void UpdateSelectedGrid()
	{
		int selectedSkinId = this.ViewModel.GetSelectedSkinId();
		int dataIndexBySkinId = this.ViewModel.GetDataIndexBySkinId(selectedSkinId);
		CalabashSkinData skinDataByIndex = this.ViewModel.GetSkinDataByIndex(dataIndexBySkinId);
		this.RefreshBottom(skinDataByIndex, this.ViewModel.GetEquipSkinId() == selectedSkinId);
		this.RefreshText(skinDataByIndex.Name, skinDataByIndex.Description);
		this.SelectedGrid(dataIndexBySkinId);
	}

	// Token: 0x060142BB RID: 82619 RVA: 0x005E2E0C File Offset: 0x005E100C
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		if (handleData.GetViewName() == EUiTabViewName.CalabashSkinTabView && this.ViewModel.NeedLoadModel)
		{
			this.ViewModel.NeedLoadModel = false;
			this.ShowHuluObserver(this.ViewModel.GetSelectedSkinId());
		}
	}

	// Token: 0x060142BC RID: 82620 RVA: 0x005E2E5C File Offset: 0x005E105C
	private void OnCalabashHideUiClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ShowView();
			this.RootViewModel.SetRootUiVisible(true, false);
			this.SwitchHuluRotate(false);
			this.UnbindCameraInput();
			this.ResetCamera();
			return;
		}
		this.HideView();
		this.RootViewModel.SetRootUiVisible(false, false);
		this.SwitchHuluRotate(this.ViewModel.NeedStopRotate);
		this.BindCameraInput();
	}

	// Token: 0x060142BD RID: 82621 RVA: 0x005E2EBE File Offset: 0x005E10BE
	private void OnCalabashConfirmBtnClick()
	{
		this.OnCalabashConfirmClick().Forget();
	}

	// Token: 0x060142BE RID: 82622 RVA: 0x005E2ECC File Offset: 0x005E10CC
	private UniTask OnCalabashConfirmClick()
	{
		CalabashSkinTabView.<OnCalabashConfirmClick>d__41 <OnCalabashConfirmClick>d__;
		<OnCalabashConfirmClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCalabashConfirmClick>d__.<>4__this = this;
		<OnCalabashConfirmClick>d__.<>1__state = -1;
		<OnCalabashConfirmClick>d__.<>t__builder.Start<CalabashSkinTabView.<OnCalabashConfirmClick>d__41>(ref <OnCalabashConfirmClick>d__);
		return <OnCalabashConfirmClick>d__.<>t__builder.Task;
	}

	// Token: 0x060142BF RID: 82623 RVA: 0x005E2F10 File Offset: 0x005E1110
	private void OnCalabashGridItemClick(MediumItemGridExtendCallback parameters)
	{
		int skinId = (parameters.Data as CalabashSkinData).SkinId;
		this.ViewModel.SetSelectedSkinId(skinId, false);
	}

	// Token: 0x060142C0 RID: 82624 RVA: 0x005E2F3B File Offset: 0x005E113B
	private void CreateTimeHandler()
	{
		if (this.TimeHandler != null)
		{
			return;
		}
		this.TimeHandler = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
		{
			this.TimeHandler = null;
		}, (float)this.ViewModel.FailRequestCd, null, null, true, 1f);
	}

	// Token: 0x060142C1 RID: 82625 RVA: 0x005E2F76 File Offset: 0x005E1176
	private void RemoveTimeHandler()
	{
		if (this.TimeHandler != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimeHandler);
			this.TimeHandler = null;
		}
	}

	// Token: 0x060142C2 RID: 82626 RVA: 0x005E2F98 File Offset: 0x005E1198
	private void BindCameraInput()
	{
		UiCameraInputBindingData calabashSkinTabCameraInputData = this.ViewModel.GetCalabashSkinTabCameraInputData();
		this.RootViewModel.ConfigureCameraInput(calabashSkinTabCameraInputData);
		this.RootViewModel.BindCameraInput();
	}

	// Token: 0x060142C3 RID: 82627 RVA: 0x005E2FC8 File Offset: 0x005E11C8
	private void UnbindCameraInput()
	{
		this.RootViewModel.UnbindCameraInput();
	}

	// Token: 0x060142C4 RID: 82628 RVA: 0x005E2FD8 File Offset: 0x005E11D8
	public void ResetCamera()
	{
		UiCameraHandleData handleData = UiCameraUtil.CreateHandleDataByView(EUiTabViewName.CalabashSkinTabView);
		UiCameraModel.Instance.PushCameraHandle(handleData, true, true, "1001", false, null);
	}

	// Token: 0x060142C5 RID: 82629 RVA: 0x005E3008 File Offset: 0x005E1208
	public void TryPushCamera()
	{
		this.ViewModel.NeedLoadModel = true;
		UiCameraHandleData handleData = UiCameraUtil.CreateHandleDataByView(EUiTabViewName.CalabashSkinTabView);
		UiCameraModel.Instance.PushCameraHandle(handleData, true, true, "10010", false, null);
	}

	// Token: 0x0400AB50 RID: 43856
	private SkinRootViewModel RootViewModel;

	// Token: 0x0400AB51 RID: 43857
	private CalabashSkinViewProxy ViewModel;

	// Token: 0x0400AB52 RID: 43858
	protected GenericLayout<CalabashSkinGridItem, CalabashSkinData> GridLayout;

	// Token: 0x0400AB53 RID: 43859
	protected GenericLayout<SkinObtainItem, ISkinSkipData> ObtainLayout;

	// Token: 0x0400AB54 RID: 43860
	[Nullable(2)]
	protected SkeletalObserverHandle HuluObserver;

	// Token: 0x0400AB55 RID: 43861
	[Nullable(2)]
	protected TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x0400AB56 RID: 43862
	protected UUIDraggableComponent Draggable;

	// Token: 0x0400AB57 RID: 43863
	[Nullable(2)]
	protected TimerHandle TimeHandler;

	// Token: 0x020082D0 RID: 33488
	[NullableContext(0)]
	private enum EComponentDefine
	{
		// Token: 0x0402A469 RID: 173161
		TopAndRightItem,
		// Token: 0x0402A46A RID: 173162
		GridLayout,
		// Token: 0x0402A46B RID: 173163
		GridItem,
		// Token: 0x0402A46C RID: 173164
		HideUiToggle,
		// Token: 0x0402A46D RID: 173165
		ConfirmBtn,
		// Token: 0x0402A46E RID: 173166
		ObtainLayout,
		// Token: 0x0402A46F RID: 173167
		ObtainItem,
		// Token: 0x0402A470 RID: 173168
		CalabashName,
		// Token: 0x0402A471 RID: 173169
		CalabashDesc,
		// Token: 0x0402A472 RID: 173170
		Draggable
	}
}
