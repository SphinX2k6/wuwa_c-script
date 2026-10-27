using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.UiCamera;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.Skin.Role.Item;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin.Role.View
{
	// Token: 0x02004BF4 RID: 19444
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleSkinTabView : UiTabViewBase
	{
		// Token: 0x0603246D RID: 205933 RVA: 0x00BAE0C4 File Offset: 0x00BAC2C4
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

		// Token: 0x0603246E RID: 205934 RVA: 0x00BAE388 File Offset: 0x00BAC588
		protected override UniTask OnBeforeStartAsync()
		{
			RoleSkinTabView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkinTabView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603246F RID: 205935 RVA: 0x00BAE3CB File Offset: 0x00BAC5CB
		private void OnRootViewModelUpdate(ESkinRootViewData data)
		{
			if (data == ESkinRootViewData.CurSelectTabViewName && base.IsShowOrShowing)
			{
				this.RevertRoleSkin();
			}
		}

		// Token: 0x06032470 RID: 205936 RVA: 0x00BAE3E0 File Offset: 0x00BAC5E0
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

		// Token: 0x06032471 RID: 205937 RVA: 0x00BAE430 File Offset: 0x00BAC630
		private UniTask LoadCurveResource()
		{
			RoleSkinTabView.<LoadCurveResource>d__15 <LoadCurveResource>d__;
			<LoadCurveResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<LoadCurveResource>d__.<>1__state = -1;
			<LoadCurveResource>d__.<>t__builder.Start<RoleSkinTabView.<LoadCurveResource>d__15>(ref <LoadCurveResource>d__);
			return <LoadCurveResource>d__.<>t__builder.Task;
		}

		// Token: 0x06032472 RID: 205938 RVA: 0x00BAE46B File Offset: 0x00BAC66B
		private RoleSkinItem InitSkinItem(AActor actor, int _1, int _2)
		{
			RoleSkinItem roleSkinItem = new RoleSkinItem();
			roleSkinItem.CreateThenShowByActor(actor, null);
			roleSkinItem.ButtonFunction = new Action<int>(this.OnMoveSkinItem);
			return roleSkinItem;
		}

		// Token: 0x06032473 RID: 205939 RVA: 0x00BAE48C File Offset: 0x00BAC68C
		private void InitSkinLayout()
		{
			this.RoleSkinList = RoleSkinModel.Instance.GetRoleSkinDataList(this.RootViewModel.RoleId);
			this.SkinLayout.ReloadView(this.RoleSkinList.Count, this.RoleSkinList.ToArray(), 0);
		}

		// Token: 0x06032474 RID: 205940 RVA: 0x00BAE4CC File Offset: 0x00BAC6CC
		private void SwitchSelectRoleSkin(RoleSkinData roleSkinData)
		{
			bool isWearWeaponSkin = roleSkinData.IsWearWeaponSkin();
			this.ViewModel.SetIsWearWeaponSkin(isWearWeaponSkin, false);
			this.ViewModel.SetSelectRoleSkinId(roleSkinData.GetItemId(), false);
		}

		// Token: 0x06032475 RID: 205941 RVA: 0x00BAE500 File Offset: 0x00BAC700
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
			this.CurrentSelectSkinIsOrigin = roleSkinData.IsOriginalSkin();
			base.GetButton(3).RootUIComp.Get().SetUIActive(!this.CurrentSelectSkinIsOrigin);
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

		// Token: 0x06032476 RID: 205942 RVA: 0x00BAE6DC File Offset: 0x00BAC8DC
		private void RefreshWearWeaponButton(RoleSkinData roleSkinData, bool isWearWeaponSkin)
		{
			EToggleState state = isWearWeaponSkin ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(10).SetToggleStateForce(state, false, false, false);
			UiCameraHandleData lastHandleData = UiCameraAnimationManager.Instance.GetLastHandleData();
			if (lastHandleData != null)
			{
				UiCameraAnimationManager.Instance.PushCameraHandleByHandleName(lastHandleData.HandleName, true, true, "1001", false, null, null);
			}
			this.ActiveRoleTabCameraInput();
		}

		// Token: 0x06032477 RID: 205943 RVA: 0x00BAE73C File Offset: 0x00BAC93C
		private void RefreshWearButton(RoleSkinData roleSkinData, bool isWearWeaponSkin)
		{
			UUIButtonComponent button = base.GetButton(14);
			button.RootUIComp.Get().SetUIActive(!roleSkinData.IsLocked());
			button.SetSelfInteractive(this.CanWearSkin(roleSkinData, isWearWeaponSkin));
		}

		// Token: 0x06032478 RID: 205944 RVA: 0x00BAE77C File Offset: 0x00BAC97C
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

		// Token: 0x06032479 RID: 205945 RVA: 0x00BAE7D8 File Offset: 0x00BAC9D8
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

		// Token: 0x0603247A RID: 205946 RVA: 0x00BAE830 File Offset: 0x00BACA30
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

		// Token: 0x0603247B RID: 205947 RVA: 0x00BAE8A0 File Offset: 0x00BACAA0
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

		// Token: 0x0603247C RID: 205948 RVA: 0x00BAE94E File Offset: 0x00BACB4E
		private void RefreshRoleMontage(bool showWeapon)
		{
			if (showWeapon)
			{
				RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Weapon, false, false, false);
				return;
			}
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Attribute_Perform, false, false, false);
		}

		// Token: 0x0603247D RID: 205949 RVA: 0x00BAE970 File Offset: 0x00BACB70
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

		// Token: 0x0603247E RID: 205950 RVA: 0x00BAEA38 File Offset: 0x00BACC38
		private void RefreshObtainLayout(int itemId)
		{
			List<IGetWayItemData> getWayDataList = InventoryModel.Instance.GetGetWayDataList(itemId);
			this.ObtainLayout.RefreshByData(getWayDataList, null, false);
		}

		// Token: 0x0603247F RID: 205951 RVA: 0x00BAEA5F File Offset: 0x00BACC5F
		private RoleSkinObtainItem InitObtainItem()
		{
			return new RoleSkinObtainItem();
		}

		// Token: 0x06032480 RID: 205952 RVA: 0x00BAEA66 File Offset: 0x00BACC66
		protected override void OnBeforeHide()
		{
			this.RevertWeaponSkin();
			this.RootViewModel.EndCameraInput();
		}

		// Token: 0x06032481 RID: 205953 RVA: 0x00BAEA79 File Offset: 0x00BACC79
		protected override void OnBeforeDestroy()
		{
			this.RootViewModel.UnBind(new Action<ESkinRootViewData>(this.OnRootViewModelUpdate));
			this.ViewModel.UnBind(new Action<ERoleSkinTabViewData>(this.OnViewModelUpdate));
		}

		// Token: 0x06032482 RID: 205954 RVA: 0x00BAEAA9 File Offset: 0x00BACCA9
		private void OnSkinRootViewDestroy()
		{
			this.RevertWeaponSkin();
			this.RevertRoleSkin();
			this.RootViewModel.EndCameraInput();
		}

		// Token: 0x06032483 RID: 205955 RVA: 0x00BAEAC2 File Offset: 0x00BACCC2
		private void RevertWeaponSkin()
		{
			this.RefreshRoleWeaponSkin();
		}

		// Token: 0x06032484 RID: 205956 RVA: 0x00BAEACC File Offset: 0x00BACCCC
		private void RevertRoleSkin()
		{
			RoleInstance roleInstanceById = RoleModel.Instance.GetRoleInstanceById(this.RootViewModel.RoleId);
			if (roleInstanceById == null || this.RootViewModel.TsUiSceneRoleActor == null)
			{
				return;
			}
			RoleController.Instance.RefreshUiSceneRoleActor(this.RootViewModel.TsUiSceneRoleActor, this.RootViewModel.RoleId, roleInstanceById.GetRoleSkinId(), null);
		}

		// Token: 0x06032485 RID: 205957 RVA: 0x00BAEB27 File Offset: 0x00BACD27
		protected override void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnSkinRootViewDestroy, new Action(this.OnSkinRootViewDestroy));
		}

		// Token: 0x06032486 RID: 205958 RVA: 0x00BAEB45 File Offset: 0x00BACD45
		protected override void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnSkinRootViewDestroy, new Action(this.OnSkinRootViewDestroy));
		}

		// Token: 0x06032487 RID: 205959 RVA: 0x00BAEB63 File Offset: 0x00BACD63
		private bool CanChangeSkin()
		{
			if (this.LastChangeSkinTime != 0.0 && Time.Instance.Now - this.LastChangeSkinTime <= (double)this.ChangeSkinInternal)
			{
				return false;
			}
			this.LastChangeSkinTime = Time.Instance.Now;
			return true;
		}

		// Token: 0x06032488 RID: 205960 RVA: 0x00BAEBA4 File Offset: 0x00BACDA4
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

		// Token: 0x06032489 RID: 205961 RVA: 0x00BAEC00 File Offset: 0x00BACE00
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
				base.GetButton(3).RootUIComp.Get().SetUIActive(!this.CurrentSelectSkinIsOrigin);
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

		// Token: 0x0603248A RID: 205962 RVA: 0x00BAECB4 File Offset: 0x00BACEB4
		private void OnClickSkinDetailButton()
		{
			RoleSkinData roleSkinData = this.RoleSkinList[this.CurSelectSkinIndex];
			SkinController.Instance.OpenSkinShowView(roleSkinData.GetItemId());
		}

		// Token: 0x0603248B RID: 205963 RVA: 0x00BAECE4 File Offset: 0x00BACEE4
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

		// Token: 0x0603248C RID: 205964 RVA: 0x00BAED34 File Offset: 0x00BACF34
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

		// Token: 0x0603248D RID: 205965 RVA: 0x00BAED84 File Offset: 0x00BACF84
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

		// Token: 0x0603248E RID: 205966 RVA: 0x00BAEE53 File Offset: 0x00BAD053
		private bool OnCanExecuteChange()
		{
			return this.CanChangeSkin();
		}

		// Token: 0x0603248F RID: 205967 RVA: 0x00BAEE5C File Offset: 0x00BAD05C
		private void OnClickWearWeaponTipButton()
		{
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.RoleSkinTip);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06032490 RID: 205968 RVA: 0x00BAEE80 File Offset: 0x00BAD080
		private void OnClickWearButton()
		{
			if (!SkinController.Instance.CheckCanWearSkinAndShowTip())
			{
				return;
			}
			RoleSkinData roleSkinData = this.RoleSkinList[this.CurSelectSkinIndex];
			RoleController.Instance.RoleSkinChangeRequest(this.RootViewModel.RoleId, roleSkinData.ItemId, this.ViewModel.GetIsWearWeaponSkin(), new Action<int, bool>(this.OnRoleSkinChange));
		}

		// Token: 0x06032491 RID: 205969 RVA: 0x00BAEEE0 File Offset: 0x00BAD0E0
		private void OnRoleSkinChange(int skinId, bool isWearWeaponSkin)
		{
			RoleSkinData roleSkinData = RoleSkinModel.Instance.GetRoleSkinData(skinId);
			this.RefreshWearButton(roleSkinData, isWearWeaponSkin);
			this.SkinLayout.RefreshItems();
		}

		// Token: 0x06032492 RID: 205970 RVA: 0x00BAEF0C File Offset: 0x00BAD10C
		private void ActiveRoleTabCameraInput()
		{
			IUiCameraInputComponentData roleTabCameraInputData = this.ViewModel.GetRoleTabCameraInputData(this.RootViewModel.GetDragItem(), this.RootViewModel.TsUiSceneRoleActor);
			this.RootViewModel.StartCameraInput(roleTabCameraInputData, new bool?(true), false);
		}

		// Token: 0x06032493 RID: 205971 RVA: 0x00BAEF4E File Offset: 0x00BAD14E
		private void OnClickOrnamentButton()
		{
			this.RootViewModel.SetTabViewParam(new SkinTabViewParam
			{
				SkinId = new int?(this.ViewModel.GetSelectRoleSkinId())
			});
			this.RootViewModel.SetSelectTabViewName(EUiTabViewName.RoleOrnamentTabView, false);
		}

		// Token: 0x06032494 RID: 205972 RVA: 0x00BAEF88 File Offset: 0x00BAD188
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

		// Token: 0x06032495 RID: 205973 RVA: 0x00BAF0B0 File Offset: 0x00BAD2B0
		private CommonItemSmallItemGrid CreateOrnamentItem()
		{
			return new CommonItemSmallItemGrid();
		}

		// Token: 0x0401ABE1 RID: 109537
		private NoCircleAttachView<RoleSkinData, RoleSkinItem> SkinLayout;

		// Token: 0x0401ABE2 RID: 109538
		protected GenericLayout<RoleSkinObtainItem, IGetWayItemData> ObtainLayout;

		// Token: 0x0401ABE3 RID: 109539
		private SkinRootViewModel RootViewModel;

		// Token: 0x0401ABE4 RID: 109540
		private RoleSkinViewModel ViewModel;

		// Token: 0x0401ABE5 RID: 109541
		private List<RoleSkinData> RoleSkinList;

		// Token: 0x0401ABE6 RID: 109542
		private GenericLayout<CommonItemSmallItemGrid, TItem> OrnamentLayout;

		// Token: 0x0401ABE7 RID: 109543
		private int CurSelectSkinIndex;

		// Token: 0x0401ABE8 RID: 109544
		private int ChangeSkinInternal;

		// Token: 0x0401ABE9 RID: 109545
		private double LastChangeSkinTime;

		// Token: 0x0401ABEA RID: 109546
		private bool CurrentSelectSkinIsOrigin = true;

		// Token: 0x0200ADEA RID: 44522
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04034D1C RID: 216348
			DragRoot,
			// Token: 0x04034D1D RID: 216349
			DragItem,
			// Token: 0x04034D1E RID: 216350
			HideViewToggle,
			// Token: 0x04034D1F RID: 216351
			SkinDetailButton,
			// Token: 0x04034D20 RID: 216352
			LeftArrowButton,
			// Token: 0x04034D21 RID: 216353
			RightArrowButton,
			// Token: 0x04034D22 RID: 216354
			SkinName,
			// Token: 0x04034D23 RID: 216355
			SkinSubName,
			// Token: 0x04034D24 RID: 216356
			SkinDesc,
			// Token: 0x04034D25 RID: 216357
			WearWeaponTipItem,
			// Token: 0x04034D26 RID: 216358
			WearWeaponToggle,
			// Token: 0x04034D27 RID: 216359
			WearWeaponTipButton,
			// Token: 0x04034D28 RID: 216360
			GetWayLayout,
			// Token: 0x04034D29 RID: 216361
			GetWayItem,
			// Token: 0x04034D2A RID: 216362
			WearButton,
			// Token: 0x04034D2B RID: 216363
			TopAndRightItem,
			// Token: 0x04034D2C RID: 216364
			WeaponSkinGuideNiagara,
			// Token: 0x04034D2D RID: 216365
			OrnamentRoot,
			// Token: 0x04034D2E RID: 216366
			OrnamentButton,
			// Token: 0x04034D2F RID: 216367
			OrnamentItemLayout,
			// Token: 0x04034D30 RID: 216368
			OrnamentItem
		}
	}
}
