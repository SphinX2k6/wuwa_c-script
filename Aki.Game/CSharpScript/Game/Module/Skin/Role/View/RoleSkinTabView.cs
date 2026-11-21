using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin.Role.Item;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin.Role.View
{
	// Token: 0x02003BA5 RID: 15269
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleSkinTabView : UiTabViewBase
	{
		// Token: 0x06027211 RID: 160273 RVA: 0x00AF2644 File Offset: 0x00AF0844
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(11, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(12, typeof(UUIVerticalLayout)),
				new ValueTuple<int, Type>(13, typeof(UUIItem)),
				new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(15, typeof(UUIItem)),
				new ValueTuple<int, Type>(16, typeof(UUINiagara)),
				new ValueTuple<int, Type>(17, typeof(UUIItem)),
				new ValueTuple<int, Type>(18, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(19, typeof(UUIGridLayout)),
				new ValueTuple<int, Type>(20, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(2, new Action<EToggleState>(this.OnClickHideViewToggle)),
				new ValueTuple<int, Delegate>(3, new Action(this.OnClickSkinDetailButton)),
				new ValueTuple<int, Delegate>(4, new Action(this.OnClickLeftArrowButton)),
				new ValueTuple<int, Delegate>(5, new Action(this.OnClickRightArrowButton)),
				new ValueTuple<int, Delegate>(10, new Action<EToggleState>(this.OnClickWearWeaponToggle)),
				new ValueTuple<int, Delegate>(11, new Action(this.OnClickWearWeaponTipButton)),
				new ValueTuple<int, Delegate>(14, new Action(this.OnClickWearButton)),
				new ValueTuple<int, Delegate>(18, new Action(this.OnClickOrnamentButton))
			};
		}

		// Token: 0x06027212 RID: 160274 RVA: 0x00AF2908 File Offset: 0x00AF0B08
		protected override UniTask OnBeforeStartAsync()
		{
			RoleSkinTabView.<OnBeforeStartAsync>d__11 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkinTabView.<OnBeforeStartAsync>d__11>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027213 RID: 160275 RVA: 0x00AF294B File Offset: 0x00AF0B4B
		private void OnRootViewModelUpdate(ESkinRootViewData data)
		{
			if (data == ESkinRootViewData.CurSelectTabViewName && base.IsShowOrShowing)
			{
				this.RevertRoleSkin();
			}
		}

		// Token: 0x06027214 RID: 160276 RVA: 0x00AF2960 File Offset: 0x00AF0B60
		private void OnViewModelUpdate(ERoleSkinTabViewData data)
		{
			if (data == ERoleSkinTabViewData.SelectRoleSkinId)
			{
				RoleSkinData roleSkinData = this.RoleSkinList[this.CurSelectSkinIndex];
				this.RefreshUi(roleSkinData);
				this.RefreshSkinOrnament(roleSkinData);
				return;
			}
			if (data == ERoleSkinTabViewData.IsWearWeaponSkin)
			{
				RoleSkinData roleSkinData2 = this.RoleSkinList[this.CurSelectSkinIndex];
				this.RefreshUi(roleSkinData2);
			}
		}

		// Token: 0x06027215 RID: 160277 RVA: 0x00AF29B0 File Offset: 0x00AF0BB0
		private UniTask LoadCurveResource()
		{
			RoleSkinTabView.<LoadCurveResource>d__14 <LoadCurveResource>d__;
			<LoadCurveResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadCurveResource>d__.<>1__state = -1;
			<LoadCurveResource>d__.<>t__builder.Start<RoleSkinTabView.<LoadCurveResource>d__14>(ref <LoadCurveResource>d__);
			return <LoadCurveResource>d__.<>t__builder.Task;
		}

		// Token: 0x06027216 RID: 160278 RVA: 0x00AF29EB File Offset: 0x00AF0BEB
		private RoleSkinItem InitSkinItem(AActor actor, int _1, int _2)
		{
			RoleSkinItem roleSkinItem = new RoleSkinItem();
			roleSkinItem.CreateThenShowByActor(actor, null);
			roleSkinItem.ButtonFunction = new Action<int>(this.OnMoveSkinItem);
			return roleSkinItem;
		}

		// Token: 0x06027217 RID: 160279 RVA: 0x00AF2A0C File Offset: 0x00AF0C0C
		private void InitSkinLayout()
		{
			this.RoleSkinList = RoleSkinModel.Instance.GetRoleSkinDataList(this.RootViewModel.RoleId);
			this.SkinLayout.ReloadView(this.RoleSkinList.Count, this.RoleSkinList.ToArray(), 0);
		}

		// Token: 0x06027218 RID: 160280 RVA: 0x00AF2A4C File Offset: 0x00AF0C4C
		private void SwitchSelectRoleSkin(RoleSkinData roleSkinData)
		{
			bool isWearWeaponSkin = roleSkinData.IsWearWeaponSkin();
			this.ViewModel.SetIsWearWeaponSkin(isWearWeaponSkin, false);
			this.ViewModel.SetSelectRoleSkinId(roleSkinData.GetItemId(), false);
			bool uiactive = base.GetExtendToggle(2).GetToggleState() == EToggleState.ETT_Checked && this.CanShowSkinDetailButton(roleSkinData);
			base.GetButton(3).RootUIComp.Get().SetUIActive(uiactive);
		}

		// Token: 0x06027219 RID: 160281 RVA: 0x00AF2AB3 File Offset: 0x00AF0CB3
		private bool CanShowSkinDetailButton(RoleSkinData roleSkinData)
		{
			return SkinPreviewUtil.TryGetSpinePreviewResources(roleSkinData.GetRoleSkinConfig(), false).Item1;
		}

		// Token: 0x0602721A RID: 160282 RVA: 0x00AF2AC8 File Offset: 0x00AF0CC8
		private void RefreshUi(RoleSkinData roleSkinData)
		{
			bool isWearWeaponSkin = this.ViewModel.GetIsWearWeaponSkin();
			RoleSkin roleSkinConfig = roleSkinData.GetRoleSkinConfig();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), roleSkinConfig.TitleName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), roleSkinConfig.SubDecName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), roleSkinConfig.BgDescription, Array.Empty<object>());
			this.ObtainLayout.SetActive(roleSkinData.IsLocked() && roleSkinConfig.ItemAccess().Length != 0);
			this.RefreshWearButton(roleSkinData, isWearWeaponSkin);
			this.RefreshObtainLayout(roleSkinConfig.Id);
			base.GetButton(4).RootUIComp.Get().SetUIActive(this.CurSelectSkinIndex > 0);
			base.GetButton(5).RootUIComp.Get().SetUIActive(this.CurSelectSkinIndex < this.RoleSkinList.Count - 1);
			base.GetItem(9).SetUIActive(roleSkinConfig.SuitWeaponSkinId > 0);
			bool flag = RoleSkinModel.Instance.CheckSuitWeaponFirstWear(roleSkinConfig.SuitWeaponSkinId);
			if (flag && isWearWeaponSkin)
			{
				flag = false;
				RoleSkinModel instance = RoleSkinModel.Instance;
				if (instance != null)
				{
					instance.RecordSuitWeaponFirstWear(roleSkinConfig.SuitWeaponSkinId, false);
				}
			}
			base.GetUiNiagara(16).SetUIActive(flag);
			RoleController.Instance.RefreshUiSceneRoleActor(this.RootViewModel.TsUiSceneRoleActor, this.RootViewModel.RoleId, roleSkinData.ItemId, null);
			bool flag2 = isWearWeaponSkin && roleSkinConfig.SuitWeaponSkinId > 0;
			if (flag2)
			{
				this.RefreshWeaponSkin(roleSkinData);
			}
			this.RefreshWearWeaponButton(roleSkinData, isWearWeaponSkin);
			this.RefreshRoleMontage(flag2);
			this.RefreshRoleSkinRedDot(roleSkinData);
		}

		// Token: 0x0602721B RID: 160283 RVA: 0x00AF2C78 File Offset: 0x00AF0E78
		private void RefreshWearWeaponButton(RoleSkinData roleSkinData, bool isWearWeaponSkin)
		{
			EToggleState state = isWearWeaponSkin ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(10).SetToggleStateForce(state, false, false, false);
			UiCameraHandleData lastHandleData = UiCameraModel.Instance.GetLastHandleData();
			if (lastHandleData != null)
			{
				UiCameraModel.Instance.PushCameraHandleByHandleName(lastHandleData.GetHandleName(), true, true, "1001", false, null);
			}
			this.ActiveRoleTabCameraInput();
		}

		// Token: 0x0602721C RID: 160284 RVA: 0x00AF2CCC File Offset: 0x00AF0ECC
		private void RefreshWearButton(RoleSkinData roleSkinData, bool isWearWeaponSkin)
		{
			UUIButtonComponent button = base.GetButton(14);
			button.RootUIComp.Get().SetUIActive(!roleSkinData.IsLocked());
			button.SetSelfInteractive(this.CanWearSkin(roleSkinData, isWearWeaponSkin));
		}

		// Token: 0x0602721D RID: 160285 RVA: 0x00AF2D0C File Offset: 0x00AF0F0C
		private void RefreshRoleSkinRedDot(RoleSkinData skinData)
		{
			if (skinData.IsLocked())
			{
				return;
			}
			NewFlagModel.Instance.RemoveNewFlag(ELocalStoragePlayerKey.RoleSkinRedDot, skinData.GetItemId());
			NewFlagModel.Instance.SaveNewFlagConfig(ELocalStoragePlayerKey.RoleSkinRedDot);
			EventSystem.Instance.Emit<int>(EEventName.RoleSkinRedDotRefresh, skinData.GetRoleId());
			EventSystem.Instance.Emit(EEventName.MainViewRoleButtonRefreshByRoleSkin);
		}

		// Token: 0x0602721E RID: 160286 RVA: 0x00AF2D68 File Offset: 0x00AF0F68
		public bool CanWearSkin(RoleSkinData roleSkinData, bool isWearWeaponSkin)
		{
			if (roleSkinData.IsLocked())
			{
				return false;
			}
			if (!roleSkinData.IsWear())
			{
				return true;
			}
			int suitWeaponSkinId = roleSkinData.GetRoleSkinConfig().SuitWeaponSkinId;
			if (suitWeaponSkinId <= 0)
			{
				return false;
			}
			bool flag = WeaponSkinModel.Instance.GetSkinIdByRoleId(roleSkinData.GetRoleId()) == suitWeaponSkinId;
			return (!flag || !isWearWeaponSkin) && (flag || isWearWeaponSkin);
		}

		// Token: 0x0602721F RID: 160287 RVA: 0x00AF2DC0 File Offset: 0x00AF0FC0
		private void RefreshWeaponSkin(RoleSkinData roleSkinData)
		{
			if (roleSkinData.GetRoleSkinConfig().SuitWeaponSkinId <= 0)
			{
				this.RefreshRoleWeaponSkin();
				return;
			}
			WeaponSkin weaponSkinConfig = SkinConfig.Instance.GetWeaponSkinConfig(roleSkinData.GetRoleSkinConfig().SuitWeaponSkinId);
			TsUiSceneRoleActor tsUiSceneRoleActor = this.RootViewModel.TsUiSceneRoleActor;
			if (tsUiSceneRoleActor == null)
			{
				return;
			}
			UiModelBase model = tsUiSceneRoleActor.Model;
			if (model == null)
			{
				return;
			}
			UiRoleWeaponComponent uiRoleWeaponComponent = model.CheckGetComponent<UiRoleWeaponComponent>();
			if (uiRoleWeaponComponent == null)
			{
				return;
			}
			uiRoleWeaponComponent.ReplaceWeaponModel(weaponSkinConfig.Models(), null);
		}

		// Token: 0x06027220 RID: 160288 RVA: 0x00AF2E30 File Offset: 0x00AF1030
		private void RefreshRoleWeaponSkin()
		{
			int skinIdByRoleId = WeaponSkinModel.Instance.GetSkinIdByRoleId(this.RootViewModel.RoleId);
			TsUiSceneRoleActor tsUiSceneRoleActor = this.RootViewModel.TsUiSceneRoleActor;
			if (skinIdByRoleId == -1)
			{
				WeaponConf value = WeaponModel.Instance.GetWeaponDataByIncId(this.RootViewModel.WeaponIncId).GetWeaponConfig().Value;
				if (tsUiSceneRoleActor != null)
				{
					UiModelBase model = tsUiSceneRoleActor.Model;
					if (model == null)
					{
						return;
					}
					UiRoleWeaponComponent uiRoleWeaponComponent = model.CheckGetComponent<UiRoleWeaponComponent>();
					if (uiRoleWeaponComponent == null)
					{
						return;
					}
					uiRoleWeaponComponent.ReplaceWeaponModel(value.Models(), null);
					return;
				}
			}
			else
			{
				WeaponSkin weaponSkinConfig = SkinConfig.Instance.GetWeaponSkinConfig(skinIdByRoleId);
				if (tsUiSceneRoleActor != null)
				{
					UiModelBase model2 = tsUiSceneRoleActor.Model;
					if (model2 == null)
					{
						return;
					}
					UiRoleWeaponComponent uiRoleWeaponComponent2 = model2.CheckGetComponent<UiRoleWeaponComponent>();
					if (uiRoleWeaponComponent2 == null)
					{
						return;
					}
					uiRoleWeaponComponent2.ReplaceWeaponModel(weaponSkinConfig.Models(), null);
				}
			}
		}

		// Token: 0x06027221 RID: 160289 RVA: 0x00AF2EDE File Offset: 0x00AF10DE
		private void RefreshRoleMontage(bool showWeapon)
		{
			if (showWeapon)
			{
				RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Weapon, false, false, false);
				return;
			}
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, false, false);
		}

		// Token: 0x06027222 RID: 160290 RVA: 0x00AF2F00 File Offset: 0x00AF1100
		protected override void OnBeforeShow()
		{
			SkinTabViewParam tabViewParam = this.RootViewModel.GetTabViewParam();
			if (tabViewParam != null && tabViewParam.SkinId != null)
			{
				this.ViewModel.SetSelectRoleSkinId(tabViewParam.SkinId.Value, true);
			}
			int num = this.RoleSkinList.FindIndex((RoleSkinData data) => data.ItemId == this.ViewModel.GetSelectRoleSkinId());
			this.SkinLayout.AttachToIndex(num, true);
			this.CurSelectSkinIndex = num;
			RoleSkinData roleSkinData = this.RoleSkinList[this.CurSelectSkinIndex];
			this.SkinLayout.RefreshItems();
			this.SwitchSelectRoleSkin(roleSkinData);
			this.RootViewModel.SetModelState(EModelStateInSkinView.ShowRole, false);
			EventSystem.Instance.Emit<bool>(EEventName.OnRoleSkinSubViewShow, this.CurSelectSkinIndex == 0 && this.RoleSkinList.Count > 1);
		}

		// Token: 0x06027223 RID: 160291 RVA: 0x00AF2FC8 File Offset: 0x00AF11C8
		private void RefreshObtainLayout(int itemId)
		{
			List<IGetWayItemData> getWayDataList = InventoryModel.Instance.GetGetWayDataList(itemId);
			this.ObtainLayout.RefreshByData(getWayDataList, null, false);
		}

		// Token: 0x06027224 RID: 160292 RVA: 0x00AF2FEF File Offset: 0x00AF11EF
		private RoleSkinObtainItem InitObtainItem()
		{
			return new RoleSkinObtainItem();
		}

		// Token: 0x06027225 RID: 160293 RVA: 0x00AF2FF6 File Offset: 0x00AF11F6
		protected override void OnBeforeHide()
		{
			this.RevertWeaponSkin();
			this.RootViewModel.UnbindCameraInput();
		}

		// Token: 0x06027226 RID: 160294 RVA: 0x00AF3009 File Offset: 0x00AF1209
		protected override void OnBeforeDestroy()
		{
			this.RootViewModel.UnBind(new Action<ESkinRootViewData>(this.OnRootViewModelUpdate));
			this.ViewModel.UnBind(new Action<ERoleSkinTabViewData>(this.OnViewModelUpdate));
		}

		// Token: 0x06027227 RID: 160295 RVA: 0x00AF3039 File Offset: 0x00AF1239
		private void OnSkinRootViewDestroy()
		{
			this.RevertWeaponSkin();
			this.RevertRoleSkin();
			this.RootViewModel.UnbindCameraInput();
		}

		// Token: 0x06027228 RID: 160296 RVA: 0x00AF3052 File Offset: 0x00AF1252
		private void RevertWeaponSkin()
		{
			this.RefreshRoleWeaponSkin();
		}

		// Token: 0x06027229 RID: 160297 RVA: 0x00AF305C File Offset: 0x00AF125C
		private void RevertRoleSkin()
		{
			RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RootViewModel.RoleId);
			if (roleInstanceById == null || this.RootViewModel.TsUiSceneRoleActor == null)
			{
				return;
			}
			RoleController.Instance.RefreshUiSceneRoleActor(this.RootViewModel.TsUiSceneRoleActor, this.RootViewModel.RoleId, roleInstanceById.GetRoleSkinId(), null);
		}

		// Token: 0x0602722A RID: 160298 RVA: 0x00AF30B7 File Offset: 0x00AF12B7
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnSkinRootViewDestroy, new Action(this.OnSkinRootViewDestroy));
			EventSystem.Instance.Add<UiCameraHandleData>(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		}

		// Token: 0x0602722B RID: 160299 RVA: 0x00AF30F1 File Offset: 0x00AF12F1
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnSkinRootViewDestroy, new Action(this.OnSkinRootViewDestroy));
			EventSystem.Instance.Remove(EEventName.OnActivateUiCameraAnimationHandle, new Action<UiCameraHandleData>(this.OnActivateUiCameraAnimationHandle));
		}

		// Token: 0x0602722C RID: 160300 RVA: 0x00AF312B File Offset: 0x00AF132B
		private void OnActivateUiCameraAnimationHandle(UiCameraHandleData handleData)
		{
			if (!base.IsShowOrShowing || handleData.GetViewName() != EUiTabViewName.RoleSkinTabView)
			{
				return;
			}
			this.ActiveRoleTabCameraInput();
		}

		// Token: 0x0602722D RID: 160301 RVA: 0x00AF3153 File Offset: 0x00AF1353
		private bool CanChangeSkin()
		{
			if (this.LastChangeSkinTime != 0.0 && Time.Instance.Now - this.LastChangeSkinTime <= (double)this.ChangeSkinInternal)
			{
				return false;
			}
			this.LastChangeSkinTime = Time.Instance.Now;
			return true;
		}

		// Token: 0x0602722E RID: 160302 RVA: 0x00AF3194 File Offset: 0x00AF1394
		private void OnMoveSkinItem(int showIndex)
		{
			if (this.CurSelectSkinIndex == showIndex)
			{
				return;
			}
			this.CurSelectSkinIndex = showIndex;
			if (this.SkinLayout.GetCurrentSelectIndex() != showIndex)
			{
				this.SkinLayout.AttachToIndex(showIndex, false);
			}
			RoleSkinData roleSkinData = this.RoleSkinList[this.CurSelectSkinIndex];
			this.SwitchSelectRoleSkin(roleSkinData);
			GuideController.Instance.TryFinishRunningGuides();
		}

		// Token: 0x0602722F RID: 160303 RVA: 0x00AF31F0 File Offset: 0x00AF13F0
		private void OnClickHideViewToggle(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
				if (uiViewSequence != null)
				{
					uiViewSequence.PlaySequence("UiIn", false, null);
				}
				this.RootViewModel.SetCaptionItemActive(true);
				RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(this.ViewModel.GetSelectRoleSkinId());
				base.GetButton(3).RootUIComp.Get().SetUIActive(this.CanShowSkinDetailButton(roleSkinData));
			}
			else
			{
				UiBehaviorLevelSequence uiViewSequence2 = this.UiViewSequence;
				if (uiViewSequence2 != null)
				{
					uiViewSequence2.PlaySequence("UiOut", false, null);
				}
				this.RootViewModel.SetCaptionItemActive(false);
				base.GetButton(3).RootUIComp.Get().SetUIActive(false);
			}
			GuideController.Instance.TryFinishRunningGuides();
		}

		// Token: 0x06027230 RID: 160304 RVA: 0x00AF32B8 File Offset: 0x00AF14B8
		private void OnClickSkinDetailButton()
		{
			RoleSkinData roleSkinData = this.RoleSkinList[this.CurSelectSkinIndex];
			SkinController.Instance.OpenSkinShowView(roleSkinData.GetItemId());
		}

		// Token: 0x06027231 RID: 160305 RVA: 0x00AF32E8 File Offset: 0x00AF14E8
		private void OnClickLeftArrowButton()
		{
			if (!this.CanChangeSkin())
			{
				return;
			}
			this.CurSelectSkinIndex--;
			this.SwitchSelectRoleSkin(this.RoleSkinList[this.CurSelectSkinIndex]);
			this.SkinLayout.AttachToIndex(this.CurSelectSkinIndex, false);
		}

		// Token: 0x06027232 RID: 160306 RVA: 0x00AF3338 File Offset: 0x00AF1538
		private void OnClickRightArrowButton()
		{
			if (!this.CanChangeSkin())
			{
				return;
			}
			this.CurSelectSkinIndex++;
			this.SwitchSelectRoleSkin(this.RoleSkinList[this.CurSelectSkinIndex]);
			this.SkinLayout.AttachToIndex(this.CurSelectSkinIndex, false);
		}

		// Token: 0x06027233 RID: 160307 RVA: 0x00AF3388 File Offset: 0x00AF1588
		private void OnClickWearWeaponToggle(EToggleState state)
		{
			bool flag = state == EToggleState.ETT_Checked;
			this.ViewModel.SetIsWearWeaponSkin(flag, false);
			RoleSkinData roleSkinData = this.RoleSkinList[this.CurSelectSkinIndex];
			int suitWeaponSkinId = roleSkinData.GetRoleSkinConfig().SuitWeaponSkinId;
			if (RoleSkinModel.Instance.CheckSuitWeaponFirstWear(suitWeaponSkinId))
			{
				base.GetUiNiagara(16).SetUIActive(false);
				RoleSkinModel.Instance.RecordSuitWeaponFirstWear(suitWeaponSkinId, false);
			}
			if (flag)
			{
				WeaponSkin weaponSkinConfig = SkinConfig.Instance.GetWeaponSkinConfig(roleSkinData.GetRoleSkinConfig().SuitWeaponSkinId);
				TsUiSceneRoleActor tsUiSceneRoleActor = this.RootViewModel.TsUiSceneRoleActor;
				if (tsUiSceneRoleActor != null)
				{
					UiModelBase model = tsUiSceneRoleActor.Model;
					if (model != null)
					{
						UiRoleWeaponComponent uiRoleWeaponComponent = model.CheckGetComponent<UiRoleWeaponComponent>();
						if (uiRoleWeaponComponent != null)
						{
							uiRoleWeaponComponent.ReplaceWeaponModel(weaponSkinConfig.Models(), null);
						}
					}
				}
			}
			this.RefreshWearWeaponButton(roleSkinData, flag);
			this.RefreshWearButton(roleSkinData, flag);
			this.RefreshRoleMontage(flag);
		}

		// Token: 0x06027234 RID: 160308 RVA: 0x00AF3457 File Offset: 0x00AF1657
		private bool OnCanExecuteChange()
		{
			return this.CanChangeSkin();
		}

		// Token: 0x06027235 RID: 160309 RVA: 0x00AF3460 File Offset: 0x00AF1660
		private void OnClickWearWeaponTipButton()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleSkinTip);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06027236 RID: 160310 RVA: 0x00AF3484 File Offset: 0x00AF1684
		private void OnClickWearButton()
		{
			if (!SkinController.Instance.CheckCanWearSkinAndShowTip())
			{
				return;
			}
			RoleSkinData roleSkinData = this.RoleSkinList[this.CurSelectSkinIndex];
			RoleController.Instance.RoleSkinChangeRequest(this.RootViewModel.RoleId, roleSkinData.ItemId, this.ViewModel.GetIsWearWeaponSkin(), new Action<int, bool>(this.OnRoleSkinChange));
		}

		// Token: 0x06027237 RID: 160311 RVA: 0x00AF34E4 File Offset: 0x00AF16E4
		private void OnRoleSkinChange(int skinId, bool isWearWeaponSkin)
		{
			RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(skinId);
			this.RefreshWearButton(roleSkinData, isWearWeaponSkin);
			this.SkinLayout.RefreshItems();
		}

		// Token: 0x06027238 RID: 160312 RVA: 0x00AF3510 File Offset: 0x00AF1710
		private void ActiveRoleTabCameraInput()
		{
			UiCameraInputBindingData roleTabCameraInputData = this.ViewModel.GetRoleTabCameraInputData(this.RootViewModel.GetDragItem(), this.RootViewModel.TsUiSceneRoleActor);
			this.RootViewModel.ConfigureCameraInput(roleTabCameraInputData);
			this.RootViewModel.BindCameraInput();
		}

		// Token: 0x06027239 RID: 160313 RVA: 0x00AF3556 File Offset: 0x00AF1756
		private void OnClickOrnamentButton()
		{
			this.RootViewModel.SetTabViewParam(new SkinTabViewParam
			{
				SkinId = new int?(this.ViewModel.GetSelectRoleSkinId())
			});
			this.RootViewModel.SetSelectTabViewName(EUiTabViewName.RoleOrnamentTabView, false);
		}

		// Token: 0x0602723A RID: 160314 RVA: 0x00AF3590 File Offset: 0x00AF1790
		private void RefreshSkinOrnament(RoleSkinData roleSkinData)
		{
			List<int> skinAllOrnaments = RoleOrnamentModel.Instance.GetSkinAllOrnaments(roleSkinData.GetItemId(), new bool?(true));
			UUIItem item = base.GetItem(17);
			if (skinAllOrnaments.Count == 0)
			{
				item.SetUIActive(false);
				return;
			}
			item.SetUIActive(true);
			if (this.OrnamentLayout == null)
			{
				this.OrnamentLayout = new GenericLayout<CommonItemSmallItemGrid, TItem>(base.GetGridLayout(19), new Func<CommonItemSmallItemGrid>(this.CreateOrnamentItem), base.GetItem(20).GetOwner() as AUIBaseActor, false, true);
			}
			List<TItem> dataList = new List<TItem>();
			foreach (int itemId in skinAllOrnaments)
			{
				dataList.Add(new TItem
				{
					ItemData = new InventoryDefine.GetItemData(itemId, 0),
					Count = 0
				});
			}
			this.OrnamentLayout.RefreshByData(dataList, delegate
			{
				for (int i = 0; i < dataList.Count; i++)
				{
					CommonItemSmallItemGrid layoutItemByIndex = this.OrnamentLayout.GetLayoutItemByIndex(i);
					if (layoutItemByIndex != null)
					{
						int itemId2 = dataList[i].ItemData.ItemId;
						bool selectVisible = RoleOrnamentModel.Instance.IsSkinWearingOrnament(itemId2, roleSkinData.GetItemId(), true);
						layoutItemByIndex.SetSelectVisible(selectVisible);
						layoutItemByIndex.SetLockBlackVisible(!RoleOrnamentModel.Instance.IsOwnOrnament(itemId2));
					}
				}
			}, false);
		}

		// Token: 0x0602723B RID: 160315 RVA: 0x00AF36B8 File Offset: 0x00AF18B8
		private CommonItemSmallItemGrid CreateOrnamentItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0401553C RID: 87356
		private NoCircleAttachView<RoleSkinData, RoleSkinItem> SkinLayout;

		// Token: 0x0401553D RID: 87357
		protected GenericLayout<RoleSkinObtainItem, IGetWayItemData> ObtainLayout;

		// Token: 0x0401553E RID: 87358
		private SkinRootViewModel RootViewModel;

		// Token: 0x0401553F RID: 87359
		private RoleSkinViewModel ViewModel;

		// Token: 0x04015540 RID: 87360
		private List<RoleSkinData> RoleSkinList;

		// Token: 0x04015541 RID: 87361
		private GenericLayout<CommonItemSmallItemGrid, TItem> OrnamentLayout;

		// Token: 0x04015542 RID: 87362
		private int CurSelectSkinIndex;

		// Token: 0x04015543 RID: 87363
		private int ChangeSkinInternal;

		// Token: 0x04015544 RID: 87364
		private double LastChangeSkinTime;

		// Token: 0x02009809 RID: 38921
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0402F6C3 RID: 194243
			DragRoot,
			// Token: 0x0402F6C4 RID: 194244
			DragItem,
			// Token: 0x0402F6C5 RID: 194245
			HideViewToggle,
			// Token: 0x0402F6C6 RID: 194246
			SkinDetailButton,
			// Token: 0x0402F6C7 RID: 194247
			LeftArrowButton,
			// Token: 0x0402F6C8 RID: 194248
			RightArrowButton,
			// Token: 0x0402F6C9 RID: 194249
			SkinName,
			// Token: 0x0402F6CA RID: 194250
			SkinSubName,
			// Token: 0x0402F6CB RID: 194251
			SkinDesc,
			// Token: 0x0402F6CC RID: 194252
			WearWeaponTipItem,
			// Token: 0x0402F6CD RID: 194253
			WearWeaponToggle,
			// Token: 0x0402F6CE RID: 194254
			WearWeaponTipButton,
			// Token: 0x0402F6CF RID: 194255
			GetWayLayout,
			// Token: 0x0402F6D0 RID: 194256
			GetWayItem,
			// Token: 0x0402F6D1 RID: 194257
			WearButton,
			// Token: 0x0402F6D2 RID: 194258
			TopAndRightItem,
			// Token: 0x0402F6D3 RID: 194259
			WeaponSkinGuideNiagara,
			// Token: 0x0402F6D4 RID: 194260
			OrnamentRoot,
			// Token: 0x0402F6D5 RID: 194261
			OrnamentButton,
			// Token: 0x0402F6D6 RID: 194262
			OrnamentItemLayout,
			// Token: 0x0402F6D7 RID: 194263
			OrnamentItem
		}
	}
}
