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

// Token: 0x02002D01 RID: 11521
[NullableContext(1)]
[Nullable(0)]
public class WeaponReplaceView : UiViewBase
{
	// Token: 0x06018369 RID: 99177 RVA: 0x006299DC File Offset: 0x00627BDC
	public WeaponReplaceView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601836A RID: 99178 RVA: 0x006299E8 File Offset: 0x00627BE8
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

	// Token: 0x0601836B RID: 99179 RVA: 0x00629B58 File Offset: 0x00627D58
	protected override UniTask OnBeforeStartAsync()
	{
		WeaponReplaceView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeaponReplaceView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601836C RID: 99180 RVA: 0x00629B9C File Offset: 0x00627D9C
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

	// Token: 0x0601836D RID: 99181 RVA: 0x00629C4B File Offset: 0x00627E4B
	private SelectablePropData UpdateSelectableItemData(int gridIndex)
	{
		return SelectablePropDataUtil.GetSelectablePropData(this.ItemDataList[gridIndex]);
	}

	// Token: 0x0601836E RID: 99182 RVA: 0x00629C60 File Offset: 0x00627E60
	private WeaponReplaceMediumItemGrid InitSelectableItem()
	{
		WeaponReplaceMediumItemGrid weaponReplaceMediumItemGrid = new WeaponReplaceMediumItemGrid();
		weaponReplaceMediumItemGrid.Source = this.Source;
		weaponReplaceMediumItemGrid.RoleId = this.RoleDataId;
		weaponReplaceMediumItemGrid.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.ToggleFunction));
		weaponReplaceMediumItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanExecuteChange));
		return weaponReplaceMediumItemGrid;
	}

	// Token: 0x0601836F RID: 99183 RVA: 0x00629CB0 File Offset: 0x00627EB0
	private void ToggleFunction(MediumItemGridExtendCallback parameters)
	{
		int incId = (parameters.Data as SelectablePropData).IncId;
		this.SelectedWeaponHandle(incId, false);
	}

	// Token: 0x06018370 RID: 99184 RVA: 0x00629CD8 File Offset: 0x00627ED8
	private bool CanExecuteChange(object data, bool isForceSelected, EToggleState _)
	{
		SelectablePropData selectablePropData = data as SelectablePropData;
		return this.SelectedIncId != selectablePropData.IncId;
	}

	// Token: 0x06018371 RID: 99185 RVA: 0x00629D00 File Offset: 0x00627F00
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

	// Token: 0x06018372 RID: 99186 RVA: 0x00629D7C File Offset: 0x00627F7C
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

	// Token: 0x06018373 RID: 99187 RVA: 0x00629DEC File Offset: 0x00627FEC
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

	// Token: 0x06018374 RID: 99188 RVA: 0x00629F88 File Offset: 0x00628188
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

	// Token: 0x06018375 RID: 99189 RVA: 0x00629FC4 File Offset: 0x006281C4
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

	// Token: 0x06018376 RID: 99190 RVA: 0x0062A04C File Offset: 0x0062824C
	protected override UniTask OnPlayingStartSequenceAsync()
	{
		WeaponReplaceView.<OnPlayingStartSequenceAsync>d__24 <OnPlayingStartSequenceAsync>d__;
		<OnPlayingStartSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingStartSequenceAsync>d__.<>4__this = this;
		<OnPlayingStartSequenceAsync>d__.<>1__state = -1;
		<OnPlayingStartSequenceAsync>d__.<>t__builder.Start<WeaponReplaceView.<OnPlayingStartSequenceAsync>d__24>(ref <OnPlayingStartSequenceAsync>d__);
		return <OnPlayingStartSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06018377 RID: 99191 RVA: 0x0062A090 File Offset: 0x00628290
	protected override UniTask OnPlayingCloseSequenceAsync()
	{
		WeaponReplaceView.<OnPlayingCloseSequenceAsync>d__25 <OnPlayingCloseSequenceAsync>d__;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnPlayingCloseSequenceAsync>d__.<>4__this = this;
		<OnPlayingCloseSequenceAsync>d__.<>1__state = -1;
		<OnPlayingCloseSequenceAsync>d__.<>t__builder.Start<WeaponReplaceView.<OnPlayingCloseSequenceAsync>d__25>(ref <OnPlayingCloseSequenceAsync>d__);
		return <OnPlayingCloseSequenceAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06018378 RID: 99192 RVA: 0x0062A0D3 File Offset: 0x006282D3
	protected override void OnBeforeDestroy()
	{
		this.RestoreOriginalWeapon();
		this.SelectWeaponTipsView.Destroy(null);
		this.CurrentWeaponTipsView.Destroy(null);
		this.SortComponent.Destroy(null);
	}

	// Token: 0x06018379 RID: 99193 RVA: 0x0062A0FF File Offset: 0x006282FF
	protected override void OnHandleLoadScene()
	{
		this.ViewModel.HandleLoadScene(delegate
		{
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Weapon, true, false, false);
		});
	}

	// Token: 0x0601837A RID: 99194 RVA: 0x0062A12B File Offset: 0x0062832B
	protected override void OnHandleReleaseScene()
	{
		this.ViewModel.HandleReleaseScene();
	}

	// Token: 0x0601837B RID: 99195 RVA: 0x0062A138 File Offset: 0x00628338
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

	// Token: 0x0601837C RID: 99196 RVA: 0x0062A1F8 File Offset: 0x006283F8
	protected override void OnAfterHide()
	{
		if (this.InContrast)
		{
			this.SetContrast();
		}
	}

	// Token: 0x0601837D RID: 99197 RVA: 0x0062A208 File Offset: 0x00628408
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.EquipWeapon, new Action(this.EquipWeaponEvent));
		EventSystem.Instance.Add(EEventName.OnItemLock, new Action<int, bool>(this.WeaponTipsLockEvent));
	}

	// Token: 0x0601837E RID: 99198 RVA: 0x0062A242 File Offset: 0x00628442
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.EquipWeapon, new Action(this.EquipWeaponEvent));
		EventSystem.Instance.Remove(EEventName.OnItemLock, new Action<int, bool>(this.WeaponTipsLockEvent));
	}

	// Token: 0x0601837F RID: 99199 RVA: 0x0062A27C File Offset: 0x0062847C
	private void EquipWeaponEvent()
	{
		this.UpdateCurrentTips();
		this.UpdateSelectedTips(this.SelectedIncId);
		this.RefreshPropItem();
	}

	// Token: 0x06018380 RID: 99200 RVA: 0x0062A296 File Offset: 0x00628496
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

	// Token: 0x06018381 RID: 99201 RVA: 0x0062A2D2 File Offset: 0x006284D2
	protected void RefreshPropItem()
	{
		this.LoopScrollView.RefreshAllGridProxies();
	}

	// Token: 0x06018382 RID: 99202 RVA: 0x0062A2E0 File Offset: 0x006284E0
	protected void SetWeaponTipsRootItemState(bool state)
	{
		this.UiViewSequence.StopSequenceByKey("TipStart", false, false);
		this.UiViewSequence.StopSequenceByKey("TipClose", false, false);
		string sequenceName = state ? "TipStart" : "TipClose";
		this.UiViewSequence.PlaySequence(sequenceName, false, null);
	}

	// Token: 0x06018383 RID: 99203 RVA: 0x0062A338 File Offset: 0x00628538
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

	// Token: 0x06018384 RID: 99204 RVA: 0x0062A404 File Offset: 0x00628604
	protected void UpdateSelectedTips(int incId)
	{
		WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(incId);
		this.SelectWeaponTipsView.UpdateComponent(weaponDataByIncId);
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.RoleDataId, true);
		this.SelectWeaponTipsView.UpdateEquip(roleDataById.GetRoleId());
	}

	// Token: 0x06018385 RID: 99205 RVA: 0x0062A44C File Offset: 0x0062864C
	protected void UpdateCurrentTips()
	{
		WeaponInstance weaponData = WeaponModel.Instance.GetWeaponDataByRoleDataId(this.RoleDataId, true) as WeaponInstance;
		this.CurrentWeaponTipsView.UpdateComponent(weaponData);
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(this.RoleDataId, true);
		this.CurrentWeaponTipsView.UpdateEquip(roleDataById.GetRoleId());
	}

	// Token: 0x06018386 RID: 99206 RVA: 0x0062A4A0 File Offset: 0x006286A0
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

	// Token: 0x06018387 RID: 99207 RVA: 0x0062A4DC File Offset: 0x006286DC
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

	// Token: 0x06018388 RID: 99208 RVA: 0x0062A5F8 File Offset: 0x006287F8
	private void BackClick()
	{
		base.CloseMe(null);
	}

	// Token: 0x06018389 RID: 99209 RVA: 0x0062A601 File Offset: 0x00628801
	private void ContrastClick()
	{
		this.SetContrast();
	}

	// Token: 0x0400B3FF RID: 46079
	protected int SelectedIncId;

	// Token: 0x0400B400 RID: 46080
	protected int RoleDataId;

	// Token: 0x0400B401 RID: 46081
	protected ERoleViewSource Source;

	// Token: 0x0400B402 RID: 46082
	[Nullable(2)]
	private WeaponDetailTipsComponent SelectWeaponTipsView;

	// Token: 0x0400B403 RID: 46083
	[Nullable(2)]
	private WeaponDetailTipsComponent CurrentWeaponTipsView;

	// Token: 0x0400B404 RID: 46084
	private bool InContrast;

	// Token: 0x0400B405 RID: 46085
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected SortEntrance<WeaponItemData> SortComponent;

	// Token: 0x0400B406 RID: 46086
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	protected LoopScrollView<WeaponReplaceMediumItemGrid, SelectablePropData> LoopScrollView;

	// Token: 0x0400B407 RID: 46087
	[Nullable(new byte[]
	{
		2,
		1
	})]
	protected List<WeaponItemData> ItemDataList;

	// Token: 0x0400B408 RID: 46088
	[Nullable(2)]
	private RoleViewViewModel ViewModel;

	// Token: 0x0200929A RID: 37530
	[NullableContext(0)]
	private enum EWeaponReplaceViewDefine
	{
		// Token: 0x0402F65F RID: 194143
		Scrollbar,
		// Token: 0x0402F660 RID: 194144
		BackButton,
		// Token: 0x0402F661 RID: 194145
		WeaponTipsItem,
		// Token: 0x0402F662 RID: 194146
		CurrentTipsItem,
		// Token: 0x0402F663 RID: 194147
		ContrastButton,
		// Token: 0x0402F664 RID: 194148
		SortItem,
		// Token: 0x0402F665 RID: 194149
		SelectableItem
	}
}
