using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Skin.Skip;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002A42 RID: 10818
[NullableContext(1)]
[Nullable(0)]
public class CalabashSkinTabView : UiTabViewBase
{
	// Token: 0x0601687D RID: 92285 RVA: 0x005B6440 File Offset: 0x005B4640
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

	// Token: 0x0601687E RID: 92286 RVA: 0x005B6614 File Offset: 0x005B4814
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

	// Token: 0x0601687F RID: 92287 RVA: 0x005B670B File Offset: 0x005B490B
	protected override void OnBeforeShow()
	{
		this.RootViewModel.SetModelState(EModelStateInSkinView.ShowCalabash, false);
		this.UpdateSelectedGrid();
		this.TryPushCamera();
	}

	// Token: 0x06016880 RID: 92288 RVA: 0x005B6728 File Offset: 0x005B4928
	protected override UniTask OnBeforeShowAsyncImplement()
	{
		CalabashSkinTabView.<OnBeforeShowAsyncImplement>d__12 <OnBeforeShowAsyncImplement>d__;
		<OnBeforeShowAsyncImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeShowAsyncImplement>d__.<>4__this = this;
		<OnBeforeShowAsyncImplement>d__.<>1__state = -1;
		<OnBeforeShowAsyncImplement>d__.<>t__builder.Start<CalabashSkinTabView.<OnBeforeShowAsyncImplement>d__12>(ref <OnBeforeShowAsyncImplement>d__);
		return <OnBeforeShowAsyncImplement>d__.<>t__builder.Task;
	}

	// Token: 0x06016881 RID: 92289 RVA: 0x005B676B File Offset: 0x005B496B
	protected override void AddEventListener()
	{
		EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
	}

	// Token: 0x06016882 RID: 92290 RVA: 0x005B6789 File Offset: 0x005B4989
	protected override void RemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
	}

	// Token: 0x06016883 RID: 92291 RVA: 0x005B67A7 File Offset: 0x005B49A7
	protected override void OnBeforeHide()
	{
		this.HideHuluObserver();
	}

	// Token: 0x06016884 RID: 92292 RVA: 0x005B67AF File Offset: 0x005B49AF
	protected override void OnBeforeDestroy()
	{
		this.ViewModel.UnBind(new Action<ECalabashSkinViewData>(this.OnViewModelUpdate));
		this.ReleaseHuluObserver();
		this.RemoveTimeHandler();
	}

	// Token: 0x06016885 RID: 92293 RVA: 0x005B67D4 File Offset: 0x005B49D4
	private void InitGrid()
	{
		this.GridLayout = new GenericLayout<CalabashSkinGridItem, CalabashSkinData>(base.GetLayoutBase(1), new Func<CalabashSkinGridItem>(this.InitGridItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
	}

	// Token: 0x06016886 RID: 92294 RVA: 0x005B6807 File Offset: 0x005B4A07
	private CalabashSkinGridItem InitGridItem()
	{
		CalabashSkinGridItem calabashSkinGridItem = new CalabashSkinGridItem();
		calabashSkinGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnCalabashGridItemClick));
		calabashSkinGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.ViewModel.CalabashGridItemCanExecuteChange));
		return calabashSkinGridItem;
	}

	// Token: 0x06016887 RID: 92295 RVA: 0x005B6837 File Offset: 0x005B4A37
	private SkinObtainItem InitObtainItem()
	{
		return new SkinObtainItem();
	}

	// Token: 0x06016888 RID: 92296 RVA: 0x005B6840 File Offset: 0x005B4A40
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

	// Token: 0x06016889 RID: 92297 RVA: 0x005B688E File Offset: 0x005B4A8E
	private void HideHuluObserver()
	{
		if (this.HuluObserver != null)
		{
			UiSceneManager.Instance.HideObserver(this.HuluObserver, "ShowHideWeaponEffect");
		}
	}

	// Token: 0x0601688A RID: 92298 RVA: 0x005B68AD File Offset: 0x005B4AAD
	private void ShowHuluObserver(int skinId)
	{
		CalabashSkinController instance = CalabashSkinController.Instance;
		int roleId = this.RootViewModel.RoleId;
		SkeletalObserverHandle huluObserver = this.HuluObserver;
		instance.SelectedCalabashSkinChange(skinId, roleId, (huluObserver != null) ? huluObserver.Model : null, "TerminalCase");
	}

	// Token: 0x0601688B RID: 92299 RVA: 0x005B68DC File Offset: 0x005B4ADC
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

	// Token: 0x0601688C RID: 92300 RVA: 0x005B691E File Offset: 0x005B4B1E
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

	// Token: 0x0601688D RID: 92301 RVA: 0x005B695C File Offset: 0x005B4B5C
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

	// Token: 0x0601688E RID: 92302 RVA: 0x005B69B0 File Offset: 0x005B4BB0
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

	// Token: 0x0601688F RID: 92303 RVA: 0x005B6A03 File Offset: 0x005B4C03
	public void SelectedGrid(int index)
	{
		this.GridLayout.DeselectCurrentGridProxy();
		this.GridLayout.SelectGridProxy(index, true);
	}

	// Token: 0x06016890 RID: 92304 RVA: 0x005B6A1D File Offset: 0x005B4C1D
	public void RefreshText(string name, string bgDescription)
	{
		LguiUtil.Instance.SetLocalTextNew(base.GetText(7), name, Array.Empty<object>());
		LguiUtil.Instance.SetLocalTextNew(base.GetText(8), bgDescription, Array.Empty<object>());
	}

	// Token: 0x06016891 RID: 92305 RVA: 0x005B6A4D File Offset: 0x005B4C4D
	public void RefreshConfirmBox(bool isSame)
	{
		UUIButtonComponent button = base.GetButton(4);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(!isSame);
	}

	// Token: 0x06016892 RID: 92306 RVA: 0x005B6A64 File Offset: 0x005B4C64
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

	// Token: 0x06016893 RID: 92307 RVA: 0x005B6A94 File Offset: 0x005B4C94
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

	// Token: 0x06016894 RID: 92308 RVA: 0x005B6B45 File Offset: 0x005B4D45
	public void ShowEquipTips()
	{
		ScrollingTipsController.Instance.ShowTipsByTextId("TerminalSkin_Change_Success", Array.Empty<object>());
	}

	// Token: 0x06016895 RID: 92309 RVA: 0x005B6B5B File Offset: 0x005B4D5B
	public void SwitchHuluObserver(int skinId)
	{
		CalabashSkinController instance = CalabashSkinController.Instance;
		int roleId = this.RootViewModel.RoleId;
		SkeletalObserverHandle huluObserver = this.HuluObserver;
		instance.SelectedCalabashSkinChange(skinId, roleId, (huluObserver != null) ? huluObserver.Model : null, "TerminalCase");
	}

	// Token: 0x06016896 RID: 92310 RVA: 0x005B6B8C File Offset: 0x005B4D8C
	public void RefreshMainRoleHulu()
	{
		UiModelBase model = this.TsUiSceneRoleActor.Model;
		UiRoleHuluComponent uiRoleHuluComponent = (model != null) ? model.GetComponent<UiRoleHuluComponent>() : null;
		if (uiRoleHuluComponent != null)
		{
			uiRoleHuluComponent.Refresh();
		}
	}

	// Token: 0x06016897 RID: 92311 RVA: 0x005B6BBC File Offset: 0x005B4DBC
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

	// Token: 0x06016898 RID: 92312 RVA: 0x005B6C34 File Offset: 0x005B4E34
	private UUIDraggableComponent GetDragItem()
	{
		return base.GetDraggable(9);
	}

	// Token: 0x06016899 RID: 92313 RVA: 0x005B6C40 File Offset: 0x005B4E40
	private void UpdateSelectedGrid()
	{
		int selectedSkinId = this.ViewModel.GetSelectedSkinId();
		int dataIndexBySkinId = this.ViewModel.GetDataIndexBySkinId(selectedSkinId);
		CalabashSkinData skinDataByIndex = this.ViewModel.GetSkinDataByIndex(dataIndexBySkinId);
		this.RefreshBottom(skinDataByIndex, this.ViewModel.GetEquipSkinId() == selectedSkinId);
		this.RefreshText(skinDataByIndex.Name, skinDataByIndex.Description);
		this.SelectedGrid(dataIndexBySkinId);
	}

	// Token: 0x0601689A RID: 92314 RVA: 0x005B6CA4 File Offset: 0x005B4EA4
	private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
	{
		if (handleData.ViewName == EUiTabViewName.CalabashSkinTabView && this.ViewModel.NeedLoadModel)
		{
			this.ViewModel.NeedLoadModel = false;
			this.ShowHuluObserver(this.ViewModel.GetSelectedSkinId());
		}
	}

	// Token: 0x0601689B RID: 92315 RVA: 0x005B6CF4 File Offset: 0x005B4EF4
	private void OnCalabashHideUiClick(EToggleState state)
	{
		if (state == EToggleState.ETT_Checked)
		{
			this.ShowView();
			this.RootViewModel.SetRootUiVisible(true, false);
			this.SwitchHuluRotate(false);
			this.EndCameraInput();
			this.ResetCamera();
			return;
		}
		this.HideView();
		this.RootViewModel.SetRootUiVisible(false, false);
		this.SwitchHuluRotate(this.ViewModel.NeedStopRotate);
		this.StartCameraInput();
	}

	// Token: 0x0601689C RID: 92316 RVA: 0x005B6D56 File Offset: 0x005B4F56
	private void OnCalabashConfirmBtnClick()
	{
		this.OnCalabashConfirmClick().Forget();
	}

	// Token: 0x0601689D RID: 92317 RVA: 0x005B6D64 File Offset: 0x005B4F64
	private UniTask OnCalabashConfirmClick()
	{
		CalabashSkinTabView.<OnCalabashConfirmClick>d__41 <OnCalabashConfirmClick>d__;
		<OnCalabashConfirmClick>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnCalabashConfirmClick>d__.<>4__this = this;
		<OnCalabashConfirmClick>d__.<>1__state = -1;
		<OnCalabashConfirmClick>d__.<>t__builder.Start<CalabashSkinTabView.<OnCalabashConfirmClick>d__41>(ref <OnCalabashConfirmClick>d__);
		return <OnCalabashConfirmClick>d__.<>t__builder.Task;
	}

	// Token: 0x0601689E RID: 92318 RVA: 0x005B6DA8 File Offset: 0x005B4FA8
	private void OnCalabashGridItemClick(MediumItemGridExtendCallback parameters)
	{
		int skinId = (parameters.Data as CalabashSkinData).SkinId;
		this.ViewModel.SetSelectedSkinId(skinId, false);
	}

	// Token: 0x0601689F RID: 92319 RVA: 0x005B6DD3 File Offset: 0x005B4FD3
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

	// Token: 0x060168A0 RID: 92320 RVA: 0x005B6E0E File Offset: 0x005B500E
	private void RemoveTimeHandler()
	{
		if (this.TimeHandler != null)
		{
			TimerSystem.GameplayTimeInstance.Remove(this.TimeHandler);
			this.TimeHandler = null;
		}
	}

	// Token: 0x060168A1 RID: 92321 RVA: 0x005B6E30 File Offset: 0x005B5030
	private void StartCameraInput()
	{
		IUiCameraInputComponentData calabashSkinTabCameraInputData = this.ViewModel.GetCalabashSkinTabCameraInputData();
		this.RootViewModel.StartCameraInput(calabashSkinTabCameraInputData, new bool?(true), true);
	}

	// Token: 0x060168A2 RID: 92322 RVA: 0x005B6E5C File Offset: 0x005B505C
	private void EndCameraInput()
	{
		this.RootViewModel.EndCameraInput();
	}

	// Token: 0x060168A3 RID: 92323 RVA: 0x005B6E6C File Offset: 0x005B506C
	public void ResetCamera()
	{
		UiCameraHandleData newHandleData = UiCameraHandleData.NewByView(EUiTabViewName.CalabashSkinTabView, null, null);
		UiCameraAnimationManager.Instance.PushCameraHandle(newHandleData, true, true, "1001", false, null);
	}

	// Token: 0x060168A4 RID: 92324 RVA: 0x005B6EB0 File Offset: 0x005B50B0
	public void TryPushCamera()
	{
		this.ViewModel.NeedLoadModel = true;
		UiCameraHandleData newHandleData = UiCameraHandleData.NewByView(EUiTabViewName.CalabashSkinTabView, null, null);
		UiCameraAnimationManager.Instance.PushCameraHandle(newHandleData, true, true, "10010", false, null);
	}

	// Token: 0x0400A74C RID: 42828
	private SkinRootViewModel RootViewModel;

	// Token: 0x0400A74D RID: 42829
	private CalabashSkinViewProxy ViewModel;

	// Token: 0x0400A74E RID: 42830
	protected GenericLayout<CalabashSkinGridItem, CalabashSkinData> GridLayout;

	// Token: 0x0400A74F RID: 42831
	protected GenericLayout<SkinObtainItem, ISkinSkipData> ObtainLayout;

	// Token: 0x0400A750 RID: 42832
	[Nullable(2)]
	protected SkeletalObserverHandle HuluObserver;

	// Token: 0x0400A751 RID: 42833
	[Nullable(2)]
	protected TsUiSceneRoleActor TsUiSceneRoleActor;

	// Token: 0x0400A752 RID: 42834
	protected UUIDraggableComponent Draggable;

	// Token: 0x0400A753 RID: 42835
	[Nullable(2)]
	protected TimerHandle TimeHandler;

	// Token: 0x02009089 RID: 37001
	[NullableContext(0)]
	private enum EComponentDefine
	{
		// Token: 0x0402ED6F RID: 191855
		TopAndRightItem,
		// Token: 0x0402ED70 RID: 191856
		GridLayout,
		// Token: 0x0402ED71 RID: 191857
		GridItem,
		// Token: 0x0402ED72 RID: 191858
		HideUiToggle,
		// Token: 0x0402ED73 RID: 191859
		ConfirmBtn,
		// Token: 0x0402ED74 RID: 191860
		ObtainLayout,
		// Token: 0x0402ED75 RID: 191861
		ObtainItem,
		// Token: 0x0402ED76 RID: 191862
		CalabashName,
		// Token: 0x0402ED77 RID: 191863
		CalabashDesc,
		// Token: 0x0402ED78 RID: 191864
		Draggable
	}
}
