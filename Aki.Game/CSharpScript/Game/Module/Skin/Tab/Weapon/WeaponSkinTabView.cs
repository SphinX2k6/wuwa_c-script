using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Skin.Skip;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin.Tab.Weapon
{
	// Token: 0x02003B98 RID: 15256
	[NullableContext(1)]
	[Nullable(0)]
	public class WeaponSkinTabView : UiTabViewBase
	{
		// Token: 0x06027182 RID: 160130 RVA: 0x00AEFFB8 File Offset: 0x00AEE1B8
		protected override void OnRegisterComponent()
		{
			this.RootViewModel = (SkinRootViewModel)this.ExtraParams;
			this.ViewModel = new WeaponSkinViewModel();
			this.ViewModel.Init(this.RootViewModel.ViewData);
			this.ViewModel.Bind(new Action<EWeaponSkinTabViewData>(this.OnViewModelUpdate));
			this.InitWeaponModel(this.RootViewModel.WeaponIncId, this.ViewModel.GetSelectedSkinId());
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(4, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(6, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action<EToggleState>(this.WeaponHideUiClick)),
				new ValueTuple<int, Delegate>(4, new Action<EToggleState>(this.WeaponSwitchShowClick)),
				new ValueTuple<int, Delegate>(5, new Action(this.WeaponConfirmClick))
			};
		}

		// Token: 0x06027183 RID: 160131 RVA: 0x00AF0168 File Offset: 0x00AEE368
		private UniTask InitGrid()
		{
			WeaponSkinTabView.<InitGrid>d__9 <InitGrid>d__;
			<InitGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitGrid>d__.<>4__this = this;
			<InitGrid>d__.<>1__state = -1;
			<InitGrid>d__.<>t__builder.Start<WeaponSkinTabView.<InitGrid>d__9>(ref <InitGrid>d__);
			return <InitGrid>d__.<>t__builder.Task;
		}

		// Token: 0x06027184 RID: 160132 RVA: 0x00AF01AC File Offset: 0x00AEE3AC
		protected override UniTask OnBeforeStartAsync()
		{
			WeaponSkinTabView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WeaponSkinTabView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027185 RID: 160133 RVA: 0x00AF01F0 File Offset: 0x00AEE3F0
		protected override void OnStart()
		{
			this.ObtainLayout = new GenericLayout<SkinObtainItem, ISkinSkipData>(base.GetLayoutBase(6), new Func<SkinObtainItem>(this.InitObtainItem), base.GetItem(7).GetOwner() as AUIBaseActor, false, true);
			UUIExtendToggle extendToggle = base.GetExtendToggle(3);
			if (extendToggle != null)
			{
				extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
			}
			EToggleState state = this.ViewModel.GetIsInShowWeapon() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(4);
			if (extendToggle2 == null)
			{
				return;
			}
			extendToggle2.SetToggleState(state, false, false, false);
		}

		// Token: 0x06027186 RID: 160134 RVA: 0x00AF026D File Offset: 0x00AEE46D
		protected override void AddEventListener()
		{
			WeaponSkinViewModel viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.AddEventListener();
		}

		// Token: 0x06027187 RID: 160135 RVA: 0x00AF027F File Offset: 0x00AEE47F
		protected override void RemoveEventListener()
		{
			WeaponSkinViewModel viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.RemoveEventListener();
		}

		// Token: 0x06027188 RID: 160136 RVA: 0x00AF0294 File Offset: 0x00AEE494
		protected override void OnBeforeShow()
		{
			this.ViewModel.RefreshEquipSkinId();
			if (this.IsFirstRefresh)
			{
				this.IsFirstRefresh = false;
			}
			else
			{
				this.GridLayout.RefreshByData(this.ViewModel.GetSkinDataList(), null, false);
			}
			this.UpdateGridSelected();
			RoleController.Instance.PlayRoleMontage(EPerformanceRoleState.Weapon, false, false, false);
			this.SwitchWeaponSkinModel(this.RootViewModel.WeaponIncId, this.ViewModel.GetSelectedSkinId(), this.ViewModel.GetIsInShowWeapon());
			if (this.ViewModel.GetIsInShowWeapon())
			{
				WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.WeaponLevelUpView);
				this.RootViewModel.SetModelState(EModelStateInSkinView.ShowWeapon, false);
				return;
			}
			WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.RoleWeaponTabView);
			this.RootViewModel.SetModelState(EModelStateInSkinView.ShowRole, false);
		}

		// Token: 0x06027189 RID: 160137 RVA: 0x00AF0350 File Offset: 0x00AEE550
		protected override void OnBeforeHide()
		{
			if (this.ViewModel.GetIsInShowWeapon())
			{
				this.ViewModel.SetIsInShowWeapon(false, true);
				EToggleState state = this.ViewModel.GetIsInShowWeapon() ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
				UUIExtendToggle extendToggle = base.GetExtendToggle(4);
				if (extendToggle != null)
				{
					extendToggle.SetToggleState(state, false, false, false);
				}
				this.RecoverySceneRoleActor();
				this.HideWeaponObserver();
				WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.RoleWeaponTabView);
			}
		}

		// Token: 0x0602718A RID: 160138 RVA: 0x00AF03B8 File Offset: 0x00AEE5B8
		protected override void OnBeforeDestroy()
		{
			this.ViewModel.UnBind(new Action<EWeaponSkinTabViewData>(this.OnViewModelUpdate));
			UiLayer.Instance.SetShowMaskLayer("WeaponSkinCamera", false);
			this.ReleaseWeaponObserver();
			WeaponInstance weaponInstanceByRoleId = WeaponModel.Instance.GetWeaponInstanceByRoleId(this.RootViewModel.RoleId);
			if (weaponInstanceByRoleId != null)
			{
				this.RecoverySceneRoleActorBySkin(weaponInstanceByRoleId.GetIncId().Value, this.ViewModel.GetEquipSkinId());
			}
		}

		// Token: 0x0602718B RID: 160139 RVA: 0x00AF042C File Offset: 0x00AEE62C
		private void UpdateGridSelected()
		{
			int selectedSkinId = this.ViewModel.GetSelectedSkinId();
			int dataIndexBySkinId = this.ViewModel.GetDataIndexBySkinId(selectedSkinId);
			WeaponSkinData weaponSkinData = this.ViewModel.GetSkinDataList()[dataIndexBySkinId];
			this.RefreshBottom(weaponSkinData, this.ViewModel.GetEquipSkinId() == selectedSkinId);
			this.RefreshText(weaponSkinData.Name, weaponSkinData.Description);
			this.SelectedGrid(dataIndexBySkinId);
		}

		// Token: 0x0602718C RID: 160140 RVA: 0x00AF0492 File Offset: 0x00AEE692
		private void WeaponHideUiClick(EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.ViewModel.SetWeaponUiVisible(true, false);
				this.RootViewModel.SetRootUiVisible(true, false);
				return;
			}
			this.ViewModel.SetWeaponUiVisible(false, false);
			this.RootViewModel.SetRootUiVisible(false, false);
		}

		// Token: 0x0602718D RID: 160141 RVA: 0x00AF04CD File Offset: 0x00AEE6CD
		private void WeaponSwitchShowClick(EToggleState state)
		{
			this.ViewModel.SetIsInShowWeapon(state == EToggleState.ETT_Checked, false);
		}

		// Token: 0x0602718E RID: 160142 RVA: 0x00AF04DF File Offset: 0x00AEE6DF
		public void WeaponConfirmClick()
		{
			this.TrySendPbEquipTakeOnRequest(this.RootViewModel.RoleId, this.ViewModel.GetSelectedSkinId());
		}

		// Token: 0x0602718F RID: 160143 RVA: 0x00AF0500 File Offset: 0x00AEE700
		private void OnViewModelUpdate(EWeaponSkinTabViewData data)
		{
			switch (data)
			{
			case EWeaponSkinTabViewData.IsInShowWeapon:
			{
				bool isInShowWeapon = this.ViewModel.GetIsInShowWeapon();
				int selectedSkinId = this.ViewModel.GetSelectedSkinId();
				if (isInShowWeapon)
				{
					this.SwitchWeaponShow(this.RootViewModel.WeaponIncId, selectedSkinId);
					return;
				}
				this.SwitchRoleWeaponShow(selectedSkinId);
				return;
			}
			case EWeaponSkinTabViewData.SkinDataList:
				break;
			case EWeaponSkinTabViewData.EquipSkinId:
			{
				int dataIndexBySkinId = this.ViewModel.GetDataIndexBySkinId(this.ViewModel.PrevEquipSkinId);
				int dataIndexBySkinId2 = this.ViewModel.GetDataIndexBySkinId(this.ViewModel.GetEquipSkinId());
				this.RefreshGridSelect(dataIndexBySkinId, dataIndexBySkinId2);
				this.RefreshConfirmBox(true);
				this.ShowEquipTips();
				return;
			}
			case EWeaponSkinTabViewData.SelectedSkinId:
			{
				int selectedSkinId2 = this.ViewModel.GetSelectedSkinId();
				this.UpdateGridSelected();
				this.SwitchWeaponSkinModel(this.RootViewModel.WeaponIncId, selectedSkinId2, this.ViewModel.GetIsInShowWeapon());
				break;
			}
			case EWeaponSkinTabViewData.WeaponUiVisible:
				if (this.ViewModel.GetWeaponUiVisible())
				{
					this.ShowView();
					return;
				}
				this.HideView();
				return;
			default:
				return;
			}
		}

		// Token: 0x06027190 RID: 160144 RVA: 0x00AF05EA File Offset: 0x00AEE7EA
		private WeaponSkinGridItem InitGridItem()
		{
			WeaponSkinGridItem weaponSkinGridItem = new WeaponSkinGridItem();
			weaponSkinGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.GridItemClick));
			weaponSkinGridItem.BindOnCanExecuteChange((object state, bool toggleState, EToggleState result) => this.ViewModel.GridItemCanExecuteChange(state));
			return weaponSkinGridItem;
		}

		// Token: 0x06027191 RID: 160145 RVA: 0x00AF0618 File Offset: 0x00AEE818
		private void GridItemClick(MediumItemGridExtendCallback parameters)
		{
			int skinId = ((WeaponSkinData)parameters.Data).SkinId;
			this.ViewModel.SetSelectedSkinId(skinId, false);
		}

		// Token: 0x06027192 RID: 160146 RVA: 0x00AF0643 File Offset: 0x00AEE843
		private void HideWeaponObserver()
		{
			if (this.WeaponObserver != null)
			{
				UiSceneManager.Instance.HideObserver(this.WeaponObserver, "ShowHideWeaponEffect");
			}
			if (this.WeaponScabbardObserver != null)
			{
				UiSceneManager.Instance.HideObserver(this.WeaponScabbardObserver, "ShowHideWeaponEffect");
			}
		}

		// Token: 0x06027193 RID: 160147 RVA: 0x00AF067F File Offset: 0x00AEE87F
		private void ShowWeaponObserver(int weaponIncId, int skinId)
		{
			WeaponController.Instance.SelectedWeaponSkinChange(weaponIncId, skinId, this.WeaponObserver, this.WeaponScabbardObserver, false);
		}

		// Token: 0x06027194 RID: 160148 RVA: 0x00AF069A File Offset: 0x00AEE89A
		private SkinObtainItem InitObtainItem()
		{
			return new SkinObtainItem();
		}

		// Token: 0x06027195 RID: 160149 RVA: 0x00AF06A4 File Offset: 0x00AEE8A4
		public void ReleaseWeaponObserver()
		{
			if (this.WeaponObserver != null)
			{
				UiSceneManager.Instance.HideObserverWithCallback(this.WeaponObserver, "ShowHideWeaponEffect", delegate(SkeletalObserverHandle observer)
				{
					UiSceneManager.Instance.DestroyWeaponObserver(observer);
				});
			}
			if (this.WeaponScabbardObserver != null)
			{
				UiSceneManager.Instance.HideObserverWithCallback(this.WeaponScabbardObserver, "ShowHideWeaponEffect", delegate(SkeletalObserverHandle observer)
				{
					UiSceneManager.Instance.DestroyWeaponScabbardObserver(observer);
				});
			}
		}

		// Token: 0x06027196 RID: 160150 RVA: 0x00AF072C File Offset: 0x00AEE92C
		public void RecoverySceneRoleActor()
		{
			if (this.ViewModel.GetIsInShowWeapon())
			{
				this.RootViewModel.SetModelState(EModelStateInSkinView.ShowRole, false);
			}
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
			uiRoleWeaponComponent.Refresh();
		}

		// Token: 0x06027197 RID: 160151 RVA: 0x00AF077C File Offset: 0x00AEE97C
		public void RecoverySceneRoleActorBySkin(int weaponIncId, int skinId)
		{
			if (this.ViewModel.GetIsInShowWeapon())
			{
				this.RootViewModel.SetModelState(EModelStateInSkinView.ShowRole, false);
			}
			WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(weaponIncId);
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
			uiRoleWeaponComponent.SetWeaponByWeaponData(weaponDataByIncId, skinId);
		}

		// Token: 0x06027198 RID: 160152 RVA: 0x00AF07DA File Offset: 0x00AEE9DA
		public void SelectedGrid(int index)
		{
			this.GridLayout.DeselectCurrentGridProxy();
			this.GridLayout.SelectGridProxy(index, true);
		}

		// Token: 0x06027199 RID: 160153 RVA: 0x00AF07F4 File Offset: 0x00AEE9F4
		public void RefreshText(string name, string bgDescription)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), bgDescription, Array.Empty<object>());
		}

		// Token: 0x0602719A RID: 160154 RVA: 0x00AF0825 File Offset: 0x00AEEA25
		public void RefreshConfirmBox(bool isSame)
		{
			UUIButtonComponent button = base.GetButton(5);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(!isSame);
		}

		// Token: 0x0602719B RID: 160155 RVA: 0x00AF083C File Offset: 0x00AEEA3C
		public void RefreshGridSelect(int lastIndex, int nowIndex)
		{
			WeaponSkinGridItem layoutItemByIndex = this.GridLayout.GetLayoutItemByIndex(lastIndex);
			if (layoutItemByIndex != null)
			{
				layoutItemByIndex.RefreshVisible();
			}
			WeaponSkinGridItem layoutItemByIndex2 = this.GridLayout.GetLayoutItemByIndex(nowIndex);
			if (layoutItemByIndex2 == null)
			{
				return;
			}
			layoutItemByIndex2.RefreshVisible();
		}

		// Token: 0x0602719C RID: 160156 RVA: 0x00AF086C File Offset: 0x00AEEA6C
		public void RefreshBottom(WeaponSkinData data, bool isSame)
		{
			bool isLock = data.GetIsLock();
			UUIButtonComponent button = base.GetButton(5);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(!isLock);
			}
			this.ObtainLayout.SetActive(isLock);
			if (isLock)
			{
				WeaponSkin weaponSkinConfig = SkinConfig.Instance.GetWeaponSkinConfig(data.SkinId);
				List<ISkinSkipData> skinSkipDataList = this.RootViewModel.GetSkinSkipDataList(data.SkinId, weaponSkinConfig.ItemAccess());
				this.ObtainLayout.SetActive(skinSkipDataList.Count != 0);
				if (skinSkipDataList.Count > 0)
				{
					this.ObtainLayout.RefreshByData(skinSkipDataList, null, false);
					return;
				}
			}
			else
			{
				UUIButtonComponent button2 = base.GetButton(5);
				if (button2 == null)
				{
					return;
				}
				button2.SetSelfInteractive(!isSame);
			}
		}

		// Token: 0x0602719D RID: 160157 RVA: 0x00AF0920 File Offset: 0x00AEEB20
		public void HideView()
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x0602719E RID: 160158 RVA: 0x00AF0960 File Offset: 0x00AEEB60
		public void ShowView()
		{
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(4);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.RootUIComp.Get().SetUIActive(true);
		}

		// Token: 0x0602719F RID: 160159 RVA: 0x00AF09A0 File Offset: 0x00AEEBA0
		public void SwitchRoleWeaponShow(int skinId)
		{
			if (skinId == -1)
			{
				TsUiSceneRoleActor tsUiSceneRoleActor = this.RootViewModel.TsUiSceneRoleActor;
				if (tsUiSceneRoleActor != null)
				{
					UiModelBase model = tsUiSceneRoleActor.Model;
					if (model != null)
					{
						UiRoleWeaponComponent uiRoleWeaponComponent = model.CheckGetComponent<UiRoleWeaponComponent>();
						if (uiRoleWeaponComponent != null)
						{
							uiRoleWeaponComponent.Refresh();
						}
					}
				}
			}
			else
			{
				WeaponSkin weaponSkinConfig = SkinConfig.Instance.GetWeaponSkinConfig(skinId);
				TsUiSceneRoleActor tsUiSceneRoleActor2 = this.RootViewModel.TsUiSceneRoleActor;
				if (tsUiSceneRoleActor2 != null)
				{
					UiModelBase model2 = tsUiSceneRoleActor2.Model;
					if (model2 != null)
					{
						UiRoleWeaponComponent uiRoleWeaponComponent2 = model2.CheckGetComponent<UiRoleWeaponComponent>();
						if (uiRoleWeaponComponent2 != null)
						{
							uiRoleWeaponComponent2.ReplaceWeaponModel(weaponSkinConfig.Models(), null);
						}
					}
				}
			}
			this.RootViewModel.SetModelState(EModelStateInSkinView.ShowRole, false);
			this.HideWeaponObserver();
			UiCameraHandleData handleData = UiCameraUtil.CreateHandleDataByView(EUiTabViewName.WeaponSkinTabView);
			UiLayer.Instance.SetShowMaskLayer("WeaponSkinCamera", true);
			UiCameraModel.Instance.PushCameraHandle(handleData, true, true, "1001", true, delegate(UiCameraDefine.IFinishData _)
			{
				UiLayer.Instance.SetShowMaskLayer("WeaponSkinCamera", false);
			});
			WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.RoleWeaponTabView);
		}

		// Token: 0x060271A0 RID: 160160 RVA: 0x00AF0A8C File Offset: 0x00AEEC8C
		public void SwitchWeaponShow(int weaponIncId, int skinId)
		{
			this.RootViewModel.SetModelState(EModelStateInSkinView.ShowWeapon, false);
			UiLayer.Instance.SetShowMaskLayer("WeaponSkinCamera", true);
			UiCameraModel.Instance.PushCameraHandleByHandleName("1072", true, true, "1001", true, delegate(UiCameraDefine.IFinishData _)
			{
				UiLayer.Instance.SetShowMaskLayer("WeaponSkinCamera", false);
				WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.WeaponLevelUpView);
				this.ShowWeaponObserver(weaponIncId, skinId);
			});
		}

		// Token: 0x060271A1 RID: 160161 RVA: 0x00AF0AF8 File Offset: 0x00AEECF8
		private void InitWeaponObserver(int weaponIncId)
		{
			WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(weaponIncId);
			this.WeaponObserver = UiSceneManager.Instance.InitWeaponObserver(false);
			UiModelBase model = this.WeaponObserver.Model;
			UiWeaponDataComponent uiWeaponDataComponent = model.CheckGetComponent<UiWeaponDataComponent>();
			if (uiWeaponDataComponent != null)
			{
				uiWeaponDataComponent.SetWeaponData(weaponDataByIncId);
			}
			UiModelDataComponent uiModelDataComponent = model.CheckGetComponent<UiModelDataComponent>();
			if (uiModelDataComponent == null)
			{
				return;
			}
			uiModelDataComponent.SetLoadingIconFollowState(false);
		}

		// Token: 0x060271A2 RID: 160162 RVA: 0x00AF0B50 File Offset: 0x00AEED50
		private void InitWeaponScabbardObserver(int weaponIncId)
		{
			WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(weaponIncId);
			this.WeaponScabbardObserver = UiSceneManager.Instance.InitWeaponScabbardObserver();
			this.WeaponScabbardObserver.Model.CheckGetComponent<UiWeaponDataComponent>().SetWeaponData(weaponDataByIncId);
		}

		// Token: 0x060271A3 RID: 160163 RVA: 0x00AF0B8F File Offset: 0x00AEED8F
		public void InitWeaponModel(int weaponIncId, int skinId)
		{
			this.InitWeaponObserver(weaponIncId);
			this.InitWeaponScabbardObserver(weaponIncId);
		}

		// Token: 0x060271A4 RID: 160164 RVA: 0x00AF0BA0 File Offset: 0x00AEEDA0
		public void SwitchWeaponSkinModel(int weaponIncId, int skinId, bool isInShowWeapon)
		{
			if (isInShowWeapon)
			{
				WeaponController.Instance.SelectedWeaponSkinChange(weaponIncId, skinId, this.WeaponObserver, this.WeaponScabbardObserver, false);
				return;
			}
			if (skinId == -1)
			{
				WeaponConf value = WeaponModel.Instance.GetWeaponDataByIncId(weaponIncId).GetWeaponConfig().Value;
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
				uiRoleWeaponComponent.ReplaceWeaponModel(value.Models(), null);
				return;
			}
			else
			{
				WeaponSkin weaponSkinConfig = SkinConfig.Instance.GetWeaponSkinConfig(skinId);
				TsUiSceneRoleActor tsUiSceneRoleActor2 = this.RootViewModel.TsUiSceneRoleActor;
				if (tsUiSceneRoleActor2 == null)
				{
					return;
				}
				UiModelBase model2 = tsUiSceneRoleActor2.Model;
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
				return;
			}
		}

		// Token: 0x060271A5 RID: 160165 RVA: 0x00AF0C56 File Offset: 0x00AEEE56
		public void ShowEquipTips()
		{
			ScrollingTipsController.Instance.ShowTipsById("WeaponSkinReplaceTip", Array.Empty<object>());
		}

		// Token: 0x060271A6 RID: 160166 RVA: 0x00AF0C6C File Offset: 0x00AEEE6C
		public void TrySendPbEquipTakeOnRequest(int roleId, int skinId)
		{
			int? roleIdBySkinId = WeaponSkinModel.Instance.GetRoleIdBySkinId(skinId);
			Action action = delegate()
			{
				WeaponSkinController.Instance.SendEquipSkinRequest(roleId, skinId);
			};
			if (roleIdBySkinId != null)
			{
				ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.WeaponSkinReplace);
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew(SkinConfig.Instance.GetWeaponSkinConfig(skinId).Name, null);
				string name = RoleModel.Instance.GetRoleDataById(roleIdBySkinId.Value, true).GetName(null);
				confirmBoxDataNew.SetTextArgs(new string[]
				{
					localTextNew,
					name
				});
				confirmBoxDataNew.FunctionMap.Add(2, action);
				ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
				return;
			}
			action();
		}

		// Token: 0x04015515 RID: 87317
		private SkinRootViewModel RootViewModel;

		// Token: 0x04015516 RID: 87318
		private WeaponSkinViewModel ViewModel;

		// Token: 0x04015517 RID: 87319
		protected GenericLayout<WeaponSkinGridItem, WeaponSkinData> GridLayout;

		// Token: 0x04015518 RID: 87320
		protected GenericLayout<SkinObtainItem, ISkinSkipData> ObtainLayout;

		// Token: 0x04015519 RID: 87321
		[Nullable(2)]
		private SkeletalObserverHandle WeaponObserver;

		// Token: 0x0401551A RID: 87322
		[Nullable(2)]
		private SkeletalObserverHandle WeaponScabbardObserver;

		// Token: 0x0401551B RID: 87323
		private bool IsFirstRefresh = true;

		// Token: 0x020097F5 RID: 38901
		[NullableContext(0)]
		private enum EComponentDefine
		{
			// Token: 0x0402F663 RID: 194147
			TopAndRightItem,
			// Token: 0x0402F664 RID: 194148
			GridLayout,
			// Token: 0x0402F665 RID: 194149
			GridItem,
			// Token: 0x0402F666 RID: 194150
			HideUiToggle,
			// Token: 0x0402F667 RID: 194151
			SwitchShowToggle,
			// Token: 0x0402F668 RID: 194152
			ConfirmBtn,
			// Token: 0x0402F669 RID: 194153
			ObtainLayout,
			// Token: 0x0402F66A RID: 194154
			ObtainItem,
			// Token: 0x0402F66B RID: 194155
			WeaponName,
			// Token: 0x0402F66C RID: 194156
			WeaponDesc
		}
	}
}
