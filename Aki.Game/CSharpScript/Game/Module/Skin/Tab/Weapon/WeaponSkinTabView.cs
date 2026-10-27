using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Role.Common.Data.Enum;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Skin.Skip;
using CSharpScript.Game.Module.UiCameraAnimation.UiCameraContext;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Skin.Tab.Weapon
{
	// Token: 0x02004BE7 RID: 19431
	[NullableContext(1)]
	[Nullable(0)]
	public class WeaponSkinTabView : UiTabViewBase
	{
		// Token: 0x060323DE RID: 205790 RVA: 0x00BABA18 File Offset: 0x00BA9C18
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

		// Token: 0x060323DF RID: 205791 RVA: 0x00BABBC8 File Offset: 0x00BA9DC8
		private UniTask InitGrid()
		{
			WeaponSkinTabView.<InitGrid>d__9 <InitGrid>d__;
			<InitGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitGrid>d__.<>4__this = this;
			<InitGrid>d__.<>1__state = -1;
			<InitGrid>d__.<>t__builder.Start<WeaponSkinTabView.<InitGrid>d__9>(ref <InitGrid>d__);
			return <InitGrid>d__.<>t__builder.Task;
		}

		// Token: 0x060323E0 RID: 205792 RVA: 0x00BABC0C File Offset: 0x00BA9E0C
		protected override UniTask OnBeforeStartAsync()
		{
			WeaponSkinTabView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WeaponSkinTabView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060323E1 RID: 205793 RVA: 0x00BABC50 File Offset: 0x00BA9E50
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

		// Token: 0x060323E2 RID: 205794 RVA: 0x00BABCCD File Offset: 0x00BA9ECD
		protected override void AddEventListener()
		{
			WeaponSkinViewModel viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.AddEventListener();
		}

		// Token: 0x060323E3 RID: 205795 RVA: 0x00BABCDF File Offset: 0x00BA9EDF
		protected override void RemoveEventListener()
		{
			WeaponSkinViewModel viewModel = this.ViewModel;
			if (viewModel == null)
			{
				return;
			}
			viewModel.RemoveEventListener();
		}

		// Token: 0x060323E4 RID: 205796 RVA: 0x00BABCF4 File Offset: 0x00BA9EF4
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

		// Token: 0x060323E5 RID: 205797 RVA: 0x00BABDB0 File Offset: 0x00BA9FB0
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

		// Token: 0x060323E6 RID: 205798 RVA: 0x00BABE18 File Offset: 0x00BAA018
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

		// Token: 0x060323E7 RID: 205799 RVA: 0x00BABE8C File Offset: 0x00BAA08C
		private void UpdateGridSelected()
		{
			int selectedSkinId = this.ViewModel.GetSelectedSkinId();
			int dataIndexBySkinId = this.ViewModel.GetDataIndexBySkinId(selectedSkinId);
			WeaponSkinData weaponSkinData = this.ViewModel.GetSkinDataList()[dataIndexBySkinId];
			this.RefreshBottom(weaponSkinData, this.ViewModel.GetEquipSkinId() == selectedSkinId);
			this.RefreshText(weaponSkinData.Name, weaponSkinData.Description);
			this.SelectedGrid(dataIndexBySkinId);
		}

		// Token: 0x060323E8 RID: 205800 RVA: 0x00BABEF2 File Offset: 0x00BAA0F2
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

		// Token: 0x060323E9 RID: 205801 RVA: 0x00BABF2D File Offset: 0x00BAA12D
		private void WeaponSwitchShowClick(EToggleState state)
		{
			this.ViewModel.SetIsInShowWeapon(state == EToggleState.ETT_Checked, false);
		}

		// Token: 0x060323EA RID: 205802 RVA: 0x00BABF3F File Offset: 0x00BAA13F
		public void WeaponConfirmClick()
		{
			this.TrySendPbEquipTakeOnRequest(this.RootViewModel.RoleId, this.ViewModel.GetSelectedSkinId());
		}

		// Token: 0x060323EB RID: 205803 RVA: 0x00BABF60 File Offset: 0x00BAA160
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

		// Token: 0x060323EC RID: 205804 RVA: 0x00BAC04A File Offset: 0x00BAA24A
		private WeaponSkinGridItem InitGridItem()
		{
			WeaponSkinGridItem weaponSkinGridItem = new WeaponSkinGridItem();
			weaponSkinGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.GridItemClick));
			weaponSkinGridItem.BindOnCanExecuteChange((object state, bool toggleState, EToggleState result) => this.ViewModel.GridItemCanExecuteChange(state));
			return weaponSkinGridItem;
		}

		// Token: 0x060323ED RID: 205805 RVA: 0x00BAC078 File Offset: 0x00BAA278
		private void GridItemClick(MediumItemGridExtendCallback parameters)
		{
			int skinId = ((WeaponSkinData)parameters.Data).SkinId;
			this.ViewModel.SetSelectedSkinId(skinId, false);
		}

		// Token: 0x060323EE RID: 205806 RVA: 0x00BAC0A3 File Offset: 0x00BAA2A3
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

		// Token: 0x060323EF RID: 205807 RVA: 0x00BAC0DF File Offset: 0x00BAA2DF
		private void ShowWeaponObserver(int weaponIncId, int skinId)
		{
			WeaponController.Instance.SelectedWeaponSkinChange(weaponIncId, skinId, this.WeaponObserver, this.WeaponScabbardObserver, false);
		}

		// Token: 0x060323F0 RID: 205808 RVA: 0x00BAC0FA File Offset: 0x00BAA2FA
		private SkinObtainItem InitObtainItem()
		{
			return new SkinObtainItem();
		}

		// Token: 0x060323F1 RID: 205809 RVA: 0x00BAC104 File Offset: 0x00BAA304
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

		// Token: 0x060323F2 RID: 205810 RVA: 0x00BAC18C File Offset: 0x00BAA38C
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

		// Token: 0x060323F3 RID: 205811 RVA: 0x00BAC1DC File Offset: 0x00BAA3DC
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

		// Token: 0x060323F4 RID: 205812 RVA: 0x00BAC23A File Offset: 0x00BAA43A
		public void SelectedGrid(int index)
		{
			this.GridLayout.DeselectCurrentGridProxy();
			this.GridLayout.SelectGridProxy(index, true);
		}

		// Token: 0x060323F5 RID: 205813 RVA: 0x00BAC254 File Offset: 0x00BAA454
		public void RefreshText(string name, string bgDescription)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(8), name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(9), bgDescription, Array.Empty<object>());
		}

		// Token: 0x060323F6 RID: 205814 RVA: 0x00BAC285 File Offset: 0x00BAA485
		public void RefreshConfirmBox(bool isSame)
		{
			UUIButtonComponent button = base.GetButton(5);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(!isSame);
		}

		// Token: 0x060323F7 RID: 205815 RVA: 0x00BAC29C File Offset: 0x00BAA49C
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

		// Token: 0x060323F8 RID: 205816 RVA: 0x00BAC2CC File Offset: 0x00BAA4CC
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

		// Token: 0x060323F9 RID: 205817 RVA: 0x00BAC380 File Offset: 0x00BAA580
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

		// Token: 0x060323FA RID: 205818 RVA: 0x00BAC3C0 File Offset: 0x00BAA5C0
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

		// Token: 0x060323FB RID: 205819 RVA: 0x00BAC400 File Offset: 0x00BAA600
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
			UiCameraHandleData newHandleData = UiCameraHandleData.NewByView(EUiTabViewName.WeaponSkinTabView, null, null);
			UiLayer.Instance.SetShowMaskLayer("WeaponSkinCamera", true);
			UiCameraAnimationManager.Instance.PushCameraHandle(newHandleData, true, true, "1001", true, delegate(UiCameraAnimationDefine.IFinishData _)
			{
				UiLayer.Instance.SetShowMaskLayer("WeaponSkinCamera", false);
			});
			WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.RoleWeaponTabView);
		}

		// Token: 0x060323FC RID: 205820 RVA: 0x00BAC504 File Offset: 0x00BAA704
		public void SwitchWeaponShow(int weaponIncId, int skinId)
		{
			this.RootViewModel.SetModelState(EModelStateInSkinView.ShowWeapon, false);
			UiLayer.Instance.SetShowMaskLayer("WeaponSkinCamera", true);
			UiCameraAnimationManager.Instance.PushCameraHandleByHandleName("1072", true, true, "1001", true, delegate(UiCameraAnimationDefine.IFinishData _)
			{
				UiLayer.Instance.SetShowMaskLayer("WeaponSkinCamera", false);
				WeaponModel.Instance.SetCurSelectViewName(EWeaponViewName.WeaponLevelUpView);
				this.ShowWeaponObserver(weaponIncId, skinId);
			}, null);
		}

		// Token: 0x060323FD RID: 205821 RVA: 0x00BAC578 File Offset: 0x00BAA778
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

		// Token: 0x060323FE RID: 205822 RVA: 0x00BAC5D0 File Offset: 0x00BAA7D0
		private void InitWeaponScabbardObserver(int weaponIncId)
		{
			WeaponInstance weaponDataByIncId = WeaponModel.Instance.GetWeaponDataByIncId(weaponIncId);
			this.WeaponScabbardObserver = UiSceneManager.Instance.InitWeaponScabbardObserver();
			this.WeaponScabbardObserver.Model.CheckGetComponent<UiWeaponDataComponent>().SetWeaponData(weaponDataByIncId);
		}

		// Token: 0x060323FF RID: 205823 RVA: 0x00BAC60F File Offset: 0x00BAA80F
		public void InitWeaponModel(int weaponIncId, int skinId)
		{
			this.InitWeaponObserver(weaponIncId);
			this.InitWeaponScabbardObserver(weaponIncId);
		}

		// Token: 0x06032400 RID: 205824 RVA: 0x00BAC620 File Offset: 0x00BAA820
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

		// Token: 0x06032401 RID: 205825 RVA: 0x00BAC6D6 File Offset: 0x00BAA8D6
		public void ShowEquipTips()
		{
			ScrollingTipsController.Instance.ShowTipsById("WeaponSkinReplaceTip", Array.Empty<object>());
		}

		// Token: 0x06032402 RID: 205826 RVA: 0x00BAC6EC File Offset: 0x00BAA8EC
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

		// Token: 0x0401ABBA RID: 109498
		private SkinRootViewModel RootViewModel;

		// Token: 0x0401ABBB RID: 109499
		private WeaponSkinViewModel ViewModel;

		// Token: 0x0401ABBC RID: 109500
		protected GenericLayout<WeaponSkinGridItem, WeaponSkinData> GridLayout;

		// Token: 0x0401ABBD RID: 109501
		protected GenericLayout<SkinObtainItem, ISkinSkipData> ObtainLayout;

		// Token: 0x0401ABBE RID: 109502
		[Nullable(2)]
		private SkeletalObserverHandle WeaponObserver;

		// Token: 0x0401ABBF RID: 109503
		[Nullable(2)]
		private SkeletalObserverHandle WeaponScabbardObserver;

		// Token: 0x0401ABC0 RID: 109504
		private bool IsFirstRefresh = true;

		// Token: 0x0200ADD6 RID: 44502
		[NullableContext(0)]
		private enum EComponentDefine
		{
			// Token: 0x04034CBC RID: 216252
			TopAndRightItem,
			// Token: 0x04034CBD RID: 216253
			GridLayout,
			// Token: 0x04034CBE RID: 216254
			GridItem,
			// Token: 0x04034CBF RID: 216255
			HideUiToggle,
			// Token: 0x04034CC0 RID: 216256
			SwitchShowToggle,
			// Token: 0x04034CC1 RID: 216257
			ConfirmBtn,
			// Token: 0x04034CC2 RID: 216258
			ObtainLayout,
			// Token: 0x04034CC3 RID: 216259
			ObtainItem,
			// Token: 0x04034CC4 RID: 216260
			WeaponName,
			// Token: 0x04034CC5 RID: 216261
			WeaponDesc
		}
	}
}
