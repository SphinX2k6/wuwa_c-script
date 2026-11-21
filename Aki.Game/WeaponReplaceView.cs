using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.FilterSort.Sort.SortEntrance;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200225B RID: 8795
[NullableContext(1)]
[Nullable(0)]
public class WeaponReplaceView : UiViewBase
{
	// Token: 0x06015C0A RID: 89098 RVA: 0x0064F9B0 File Offset: 0x0064DBB0
	public WeaponReplaceView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015C0B RID: 89099 RVA: 0x0064F9BC File Offset: 0x0064DBBC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.BackClick));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.ContrastClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06015C0C RID: 89100 RVA: 0x0064FB2C File Offset: 0x0064DD2C
	protected override UniTask OnBeforeStartAsync()
	{
		WeaponReplaceView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeaponReplaceView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015C0D RID: 89101 RVA: 0x0064FB70 File Offset: 0x0064DD70
	protected override void OnStart()
	{
		AUIBaseActor gridActor = base.GetItem(6).GetOwner() as AUIBaseActor;
		this.LoopScrollView = new LoopScrollView<WeaponReplaceMediumItemGrid, SelectablePropData>(base.GetLoopScrollViewComponent(0), gridActor, new Func<WeaponReplaceMediumItemGrid>(this.InitSelectableItem), false);
		this.SelectWeaponTipsView.SetReplaceFunction(new TWeaponDetailsTipsFunctionWithNumber(this.ReplaceWeapon));
		this.SelectWeaponTipsView.SetCultureFunction(new TWeaponDetailsTipsFunctionWithNumber(this.OpenWeaponRootView));
		this.SelectWeaponTipsView.SetCanShowEquip(true);
		this.CurrentWeaponTipsView.SetCanShowEquip(true);
		this.CurrentWeaponTipsView.SetCanShowLock(false);
		this.SortComponent = new SortEntrance<WeaponItemData>(base.GetItem(5), new TUpdateDataListFunction<WeaponItemData>(this.UpdateList));
	}

	// Token: 0x06015C0E RID: 89102 RVA: 0x0064FC1F File Offset: 0x0064DE1F
	private SelectablePropData UpdateSelectableItemData(int gridIndex)
	{
		return SelectablePropDataUtil.GetSelectablePropData(this.ItemDataList[gridIndex]);
	}

	// Token: 0x06015C0F RID: 89103 RVA: 0x0064FC34 File Offset: 0x0064DE34
	private WeaponReplaceMediumItemGrid InitSelectableItem()
	{
		WeaponReplaceMediumItemGrid weaponReplaceMediumItemGrid = new WeaponReplaceMediumItemGrid();
		weaponReplaceMediumItemGrid.Source = this.Source;
		weaponReplaceMediumItemGrid.RoleId = this.RoleDataId;
		weaponReplaceMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		weaponReplaceMediumItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChange));
		return weaponReplaceMediumItemGrid;
	}

	// Token: 0x06015C10 RID: 89104 RVA: 0x0064FC84 File Offset: 0x0064DE84
	private void ToggleFunction(MediumItemGridExtendCallback parameters)
	{
		int incId = (parameters.Data as SelectablePropData).IncId;
		this.SelectedWeaponHandle(incId, false);
	}

	// Token: 0x06015C11 RID: 89105 RVA: 0x0064FCAC File Offset: 0x0064DEAC
	private bool CanExecuteChange(object data, bool isForceSelected, EToggleState _)
	{
		SelectablePropData selectablePropData = data as SelectablePropData;
		return this.SelectedIncId != selectablePropData.IncId;
	}

	// Token: 0x06015C12 RID: 89106 RVA: 0x0064FCD4 File Offset: 0x0064DED4
	protected void UpdateList(List<WeaponItemData> list, bool _1, EFilterSortType _2)
	{
		this.LoopScrollView.DeselectCurrentGridProxy(true);
		this.LoopScrollView.ReloadProxyData(new Func<int, SelectablePropData>(this.UpdateSelectableItemData), list.Count, false, false);
		if (list.Count <= 0)
		{
			return;
		}
		if (base.IsShow)
		{
			return;
		}
		this.LoopScrollView.ScrollToGridIndex(0, true);
		this.LoopScrollView.SelectGridProxy(0, true);
		WeaponItemData weaponItemData = list[0];
		this.SelectedWeaponHandle(weaponItemData.GetUniqueId(), false);
	}

	// Token: 0x06015C13 RID: 89107 RVA: 0x0064FD50 File Offset: 0x0064DF50
	private void OpenWeaponRootView(int incId)
	{
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(incId);
		int skinIdByRoleId = WeaponSkinModel.Instance.GetSkinIdByRoleId(weaponDataByIncId.GetRoleId());
		WeaponRootViewParam param = new WeaponRootViewParam
		{
			WeaponIncId = incId,
			WeaponSkinId = skinIdByRoleId,
			IsFromRoleRootView = true
		};
		WeaponController.Instance.RoleFadeIn(UiSceneManager.Instance.GetRoleSystemRoleActor(), "RoleFadeInCurve");
		UiManager.Instance.OpenView(EUiViewName.WeaponRootView, param, null);
	}

	// Token: 0x06015C14 RID: 89108 RVA: 0x0064FDC0 File Offset: 0x0064DFC0
	private void ReplaceWeapon(int incId)
	{
		WeaponDataBase weaponDataByRoleDataId = WeaponModel.Instance.GetWeaponDataByRoleDataId(this.RoleDataId, true);
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(incId);
		int roleId = weaponDataByRoleDataId.GetRoleId();
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		BaseTagComponent baseTagComponent;
		if (getCurrentEntity == null)
		{
			baseTagComponent = null;
		}
		else
		{
			WorldEntity entity = getCurrentEntity.Entity;
			baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
		}
		BaseTagComponent baseTagComponent2 = baseTagComponent;
		SceneTeamItem getCurrentTeamItem = SceneTeamModel.Instance.GetCurrentTeamItem;
		int? num = (getCurrentTeamItem != null) ? new int?(getCurrentTeamItem.GetConfigId) : null;
		int roleId2 = roleId;
		if ((num.GetValueOrDefault() == roleId2 & num != null) && baseTagComponent2 != null && baseTagComponent2.Valid && baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["功能.系统状态标识.tag禁止数值武器切换"]))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("TagCantSwitchWeapon", Array.Empty<object>());
			return;
		}
		if (weaponDataByIncId.HasRole())
		{
			string weaponName = WeaponConfig.Instance.GetWeaponName(weaponDataByIncId.GetWeaponConfig().Value.WeaponName);
			string name = RoleModel.Instance.GetRoleDataById(weaponDataByIncId.GetRoleId(), true).GetName(null);
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.WeaponEquipmentTip);
			Action value = delegate()
			{
				WeaponController.Instance.SendPbEquipTakeOnRequest(roleId, EquipPos.Weapon, incId);
			};
			confirmBoxDataNew.SetTextArgs(new string[]
			{
				weaponName,
				name
			});
			confirmBoxDataNew.FunctionMap.Add(2, value);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
			return;
		}
		WeaponController.Instance.SendPbEquipTakeOnRequest(roleId, EquipPos.Weapon, incId);
	}

	// Token: 0x06015C15 RID: 89109 RVA: 0x0064FF5C File Offset: 0x0064E15C
	protected void SetContrast()
	{
		this.InContrast = !this.InContrast;
		if (this.CurrentWeaponTipsView != null)
		{
			bool inContrast = this.InContrast;
			this.SetWeaponTipsRootItemState(inContrast);
			if (inContrast)
			{
				this.UpdateCurrentTips();
			}
		}
	}

	// Token: 0x06015C16 RID: 89110 RVA: 0x0064FF98 File Offset: 0x0064E198
	protected override void OnBeforeShow()
	{
		WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.WeaponReplaceView);
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(this.SelectedIncId);
		if (weaponDataByIncId == null)
		{
			return;
		}
		WeaponConf? weaponConfig = weaponDataByIncId.GetWeaponConfig();
		this.ItemDataList = WeaponModel.Instance.GetWeaponListFromReplace(weaponConfig.Value.WeaponType);
		this.SortComponent.UpdateData(EFilterSortGroupId.UseWayWeaponResonanceAndReplace, this.ItemDataList, Array.Empty<object>());
		this.SelectedIncId = 0;
		this.SelectedWeaponHandle(weaponDataByIncId.GetIncId().Value, true);
	}

	// Token: 0x06015C17 RID: 89111 RVA: 0x00650020 File Offset: 0x0064E220
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		WeaponReplaceView.<OnPlayingStartSequenceAsync>d__24 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<WeaponReplaceView.<OnPlayingStartSequenceAsync>d__24>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015C18 RID: 89112 RVA: 0x00650064 File Offset: 0x0064E264
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		WeaponReplaceView.<OnPlayingCloseSequenceAsync>d__25 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<WeaponReplaceView.<OnPlayingCloseSequenceAsync>d__25>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06015C19 RID: 89113 RVA: 0x006500A7 File Offset: 0x0064E2A7
	protected override void OnBeforeDestroy()
	{
		this.RestoreOriginalWeapon();
		this.SelectWeaponTipsView.Destroy(null);
		this.CurrentWeaponTipsView.Destroy(null);
		this.SortComponent.Destroy(null);
	}

	// Token: 0x06015C1A RID: 89114 RVA: 0x006500D3 File Offset: 0x0064E2D3
	protected override void OnHandleLoadScene()
	{
		this.ViewModel.HandleLoadScene(delegate
		{
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Weapon, true, false, false);
		});
	}

	// Token: 0x06015C1B RID: 89115 RVA: 0x006500FF File Offset: 0x0064E2FF
	protected override void OnHandleReleaseScene()
	{
		this.ViewModel.HandleReleaseScene();
	}

	// Token: 0x06015C1C RID: 89116 RVA: 0x0065010C File Offset: 0x0064E30C
	private void RestoreOriginalWeapon()
	{
		try
		{
			int roleId = RoleModel.Instance.GetRoleDataById(this.RoleDataId, true).GetRoleId();
			WeaponDataBase weaponDataByRoleDataId = WeaponModel.Instance.GetWeaponDataByRoleDataId(roleId, true);
			int skinIdByRoleId = WeaponSkinModel.Instance.GetSkinIdByRoleId(roleId);
			RoleViewViewModel viewModel = this.ViewModel;
			UiModelBase uiModelBase;
			if (viewModel == null)
			{
				uiModelBase = null;
			}
			else
			{
				TsUiSceneRoleActor tsUiSceneRoleActor = viewModel.TsUiSceneRoleActor;
				uiModelBase = ((tsUiSceneRoleActor != null) ? tsUiSceneRoleActor.Model : null);
			}
			UiModelBase uiModelBase2 = uiModelBase;
			if (uiModelBase2 != null)
			{
				UiRoleWeaponComponent uiRoleWeaponComponent = uiModelBase2.CheckGetComponent<UiRoleWeaponComponent>();
				if (uiRoleWeaponComponent != null)
				{
					uiRoleWeaponComponent.SetWeaponByWeaponData(weaponDataByRoleDataId, skinIdByRoleId);
				}
			}
		}
		catch (Exception ex)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.WMQ;
			string message = "还原角色武器失败";
			Exception error = ex;
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
			instance.ErrorWithStack(module, author, message, error, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
	}

	// Token: 0x06015C1D RID: 89117 RVA: 0x006501CC File Offset: 0x0064E3CC
	protected override void OnAfterHide()
	{
		if (this.InContrast)
		{
			this.SetContrast();
		}
	}

	// Token: 0x06015C1E RID: 89118 RVA: 0x006501DC File Offset: 0x0064E3DC
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.EquipWeapon, new Action(this.EquipWeaponEvent));
		EventSystem.Instance.Add(EEventName.OnItemLock, new Action<int, bool>(this.WeaponTipsLockEvent));
	}

	// Token: 0x06015C1F RID: 89119 RVA: 0x00650216 File Offset: 0x0064E416
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.EquipWeapon, new Action(this.EquipWeaponEvent));
		EventSystem.Instance.Remove(EEventName.OnItemLock, new Action<int, bool>(this.WeaponTipsLockEvent));
	}

	// Token: 0x06015C20 RID: 89120 RVA: 0x00650250 File Offset: 0x0064E450
	private void EquipWeaponEvent()
	{
		this.UpdateCurrentTips();
		this.UpdateSelectedTips(this.SelectedIncId);
		this.RefreshPropItem();
	}

	// Token: 0x06015C21 RID: 89121 RVA: 0x0065026A File Offset: 0x0064E46A
	private void WeaponTipsLockEvent(int incId, bool isLock)
	{
		if (this.CurrentWeaponTipsView.GetWeaponIncId() == incId)
		{
			this.CurrentWeaponTipsView.UpdateWeaponLock(isLock);
		}
		if (this.SelectWeaponTipsView.GetWeaponIncId() == incId)
		{
			this.SelectWeaponTipsView.UpdateWeaponLock(isLock);
		}
		this.RefreshPropItem();
	}

	// Token: 0x06015C22 RID: 89122 RVA: 0x006502A6 File Offset: 0x0064E4A6
	protected void RefreshPropItem()
	{
		this.LoopScrollView.RefreshAllGridProxies();
	}

	// Token: 0x06015C23 RID: 89123 RVA: 0x006502B4 File Offset: 0x0064E4B4
	protected void SetWeaponTipsRootItemState(bool state)
	{
		this.UiViewSequence.StopSequenceByKey("TipStart", false, false);
		this.UiViewSequence.StopSequenceByKey("TipClose", false, false);
		string sequenceName = state ? "TipStart" : "TipClose";
		this.UiViewSequence.PlaySequence(sequenceName, false, null);
	}

	// Token: 0x06015C24 RID: 89124 RVA: 0x0065030C File Offset: 0x0064E50C
	protected void SelectedWeaponHandle(int incId, bool bFireEvent = false)
	{
		if (this.SelectedIncId == incId)
		{
			return;
		}
		if (InventoryModel.Instance.GetWeaponItemData(incId) == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.BB;
			string message = "选中武器失败，背包不存在该武器";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("incId", incId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.UpdateSelectedTips(incId);
		int weaponItemIndex = this.GetWeaponItemIndex(incId);
		if (weaponItemIndex < 0)
		{
			return;
		}
		this.LoopScrollView.SelectGridProxy(weaponItemIndex, bFireEvent);
		this.SelectedIncId = incId;
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(incId);
		int weaponSkinId = -1;
		if (weaponDataByIncId.GetRoleId() == this.RoleDataId)
		{
			weaponSkinId = WeaponSkinModel.Instance.GetSkinIdByRoleId(this.RoleDataId);
		}
		UiModelBase model = this.ViewModel.TsUiSceneRoleActor.Model;
		if (model == null)
		{
			return;
		}
		UiRoleWeaponComponent uiRoleWeaponComponent = model.CheckGetComponent<UiRoleWeaponComponent>();
		if (uiRoleWeaponComponent == null)
		{
			return;
		}
		uiRoleWeaponComponent.SetWeaponByWeaponData(weaponDataByIncId, weaponSkinId);
	}

	// Token: 0x06015C25 RID: 89125 RVA: 0x006503D8 File Offset: 0x0064E5D8
	protected void UpdateSelectedTips(int incId)
	{
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(incId);
		this.SelectWeaponTipsView.UpdateComponent(weaponDataByIncId);
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.RoleDataId, true);
		this.SelectWeaponTipsView.UpdateEquip(roleDataById.GetRoleId());
	}

	// Token: 0x06015C26 RID: 89126 RVA: 0x00650420 File Offset: 0x0064E620
	protected void UpdateCurrentTips()
	{
		WeaponInstance weaponData = WeaponModel.Instance.GetWeaponDataByRoleDataId(this.RoleDataId, true) as WeaponInstance;
		this.CurrentWeaponTipsView.UpdateComponent(weaponData);
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.RoleDataId, true);
		this.CurrentWeaponTipsView.UpdateEquip(roleDataById.GetRoleId());
	}

	// Token: 0x06015C27 RID: 89127 RVA: 0x00650474 File Offset: 0x0064E674
	protected int GetWeaponItemIndex(int incId)
	{
		for (int i = 0; i < this.ItemDataList.Count; i++)
		{
			if (this.ItemDataList[i].GetUniqueId() == incId)
			{
				return i;
			}
		}
		return -1;
	}

	// Token: 0x06015C28 RID: 89128 RVA: 0x006504B0 File Offset: 0x0064E6B0
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		int num;
		if (configParams.Length != 1 || !int.TryParse(configParams[0], out num))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Guide;
			ELogAuthor author = ELogAuthor.TL;
			string message = "武器替换界面聚焦引导ExtraParam参数配置错误";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configParams", configParams);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		int? num2 = null;
		for (int i = 0; i < this.ItemDataList.Count; i++)
		{
			SelectablePropData selectablePropData = SelectablePropDataUtil.GetSelectablePropData(this.ItemDataList[i]);
			if (selectablePropData.ItemId == num)
			{
				num2 = new int?(i);
				if (selectablePropData.RoleId != this.RoleDataId)
				{
					break;
				}
			}
		}
		if (this.LoopScrollView.StartGridIndex != -1)
		{
			this.LoopScrollView.ScrollToGridIndex(num2.Value, true);
		}
		UUIItem grid = this.LoopScrollView.GetGrid(num2.Value);
		if (grid == null || num2 == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Guide;
			ELogAuthor author2 = ELogAuthor.TL;
			string message2 = "武器替换界面聚焦引导ExtraParam参数配置错误, 找不到道具";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("itemId", num);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return null;
		}
		return new UUIItem[]
		{
			grid,
			grid
		};
	}

	// Token: 0x06015C29 RID: 89129 RVA: 0x006505CC File Offset: 0x0064E7CC
	private void BackClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06015C2A RID: 89130 RVA: 0x006505D5 File Offset: 0x0064E7D5
	private void ContrastClick()
	{
		this.SetContrast();
	}

	// Token: 0x0400B774 RID: 46964
	protected int SelectedIncId;

	// Token: 0x0400B775 RID: 46965
	protected int RoleDataId;

	// Token: 0x0400B776 RID: 46966
	protected ERoleViewSource Source;

	// Token: 0x0400B777 RID: 46967
	[Nullable(2)]
	private WeaponDetailTipsComponent SelectWeaponTipsView;

	// Token: 0x0400B778 RID: 46968
	[Nullable(2)]
	private WeaponDetailTipsComponent CurrentWeaponTipsView;

	// Token: 0x0400B779 RID: 46969
	private bool InContrast;

	// Token: 0x0400B77A RID: 46970
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected SortEntrance<WeaponItemData> SortComponent;

	// Token: 0x0400B77B RID: 46971
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<WeaponReplaceMediumItemGrid, SelectablePropData> LoopScrollView;

	// Token: 0x0400B77C RID: 46972
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected List<WeaponItemData> ItemDataList;

	// Token: 0x0400B77D RID: 46973
	[Nullable(2)]
	private RoleViewViewModel ViewModel;

	// Token: 0x020084C2 RID: 33986
	[NullableContext(0)]
	private enum EWeaponReplaceViewDefine
	{
		// Token: 0x0402ACE9 RID: 175337
		Scrollbar,
		// Token: 0x0402ACEA RID: 175338
		BackButton,
		// Token: 0x0402ACEB RID: 175339
		WeaponTipsItem,
		// Token: 0x0402ACEC RID: 175340
		CurrentTipsItem,
		// Token: 0x0402ACED RID: 175341
		ContrastButton,
		// Token: 0x0402ACEE RID: 175342
		SortItem,
		// Token: 0x0402ACEF RID: 175343
		SelectableItem
	}
}
