using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D0F RID: 15631
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectRolePanel : RoleDevelopProjectBasePanel
	{
		// Token: 0x06028019 RID: 163865 RVA: 0x00B32AE0 File Offset: 0x00B30CE0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickCallJumpButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602801A RID: 163866 RVA: 0x00B32CB2 File Offset: 0x00B30EB2
		protected override void OnStart()
		{
			this.InitRoleItemGrid();
			this.InitButtonItem();
			this.InitLayout();
		}

		// Token: 0x0602801B RID: 163867 RVA: 0x00B32CC8 File Offset: 0x00B30EC8
		private void InitRoleItemGrid()
		{
			this.RoleItemGrid = new SmallItemGrid();
			this.RoleItemGrid.Initialize(base.GetItem(0).GetOwner());
			this.RoleItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanRoleItemGridExecuteChange));
			this.RoleItemGrid.SetExtendToggleEnable(false, false);
			this.RoleItemGrid.SetToggleInteractive(false);
		}

		// Token: 0x0602801C RID: 163868 RVA: 0x00B32D28 File Offset: 0x00B30F28
		private void InitButtonItem()
		{
			this.NormalButtonItem = new ButtonItem(base.GetItem(4));
			this.NormalButtonItem.SetLocalTextNew("RoleProject_Button01", Array.Empty<object>());
			this.NormalButtonItem.SetFunction(new Action<int>(this.OnClickJumpButton));
			this.HighLightButtonItem = new ButtonItem(base.GetItem(5));
			this.HighLightButtonItem.SetLocalTextNew("RoleProject_Button01", Array.Empty<object>());
			this.HighLightButtonItem.SetFunction(new Action<int>(this.OnClickJumpButton));
		}

		// Token: 0x0602801D RID: 163869 RVA: 0x00B32DB1 File Offset: 0x00B30FB1
		private void InitLayout()
		{
			this.ItemLayout = new GenericLayout<RoleDevelopProjectMaterialItem, RoleDevelopProjectMaterialItemData>(base.GetVerticalLayout(8), new Func<RoleDevelopProjectMaterialItem>(this.CreateItem), null, false, true);
		}

		// Token: 0x0602801E RID: 163870 RVA: 0x00B32DD4 File Offset: 0x00B30FD4
		public override void OnCommonItemCountAnyChange(int configId)
		{
			this.RefreshButtonItem();
			this.ItemLayout.RefreshWithoutDataSync();
		}

		// Token: 0x0602801F RID: 163871 RVA: 0x00B32DE7 File Offset: 0x00B30FE7
		protected override void OnRefreshView(bool forceRefresh)
		{
			if (RoleDevelopUtil.IsProspectRole(this.Data.GetId()))
			{
				this.RefreshProspectProjectView();
				return;
			}
			this.RefreshProjectView();
		}

		// Token: 0x06028020 RID: 163872 RVA: 0x00B32E08 File Offset: 0x00B31008
		private void RefreshProspectProjectView()
		{
			int id = this.Data.GetId();
			RoleDevelopRoleBaseData developRoleData = this.Data.GetDevelopRoleData();
			RoleDevelopProjectBaseData projectData = this.Data.GetProjectData();
			ForecastCharacterSmallItemGrid parameters = new ForecastCharacterSmallItemGrid
			{
				Data = this.Data,
				RoleId = new int?(id)
			};
			this.RoleItemGrid.Apply<ForecastCharacterSmallItemGrid>(parameters);
			base.GetText(1).SetText(developRoleData.GetName(), true);
			base.GetItem(3).SetUIActive(false);
			base.GetText(2).SetUIActive(true);
			List<int> hotRoleGachaIds = RoleDevelopUtil.GetHotRoleGachaIds(id, true);
			base.GetButton(6).RootUIComp.Get().SetUIActive(hotRoleGachaIds.Count > 0);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "RoleProject_TargetLevel", new <>z__ReadOnlySingleElementList<object>(projectData.GetRoleTargetLevel()));
			List<RoleDevelopProjectMaterialItemData> roleDevelopProjectViewItems = projectData.GetRoleDevelopProjectViewItems();
			this.ItemLayout.RefreshByData(roleDevelopProjectViewItems, null, false);
		}

		// Token: 0x06028021 RID: 163873 RVA: 0x00B32EFC File Offset: 0x00B310FC
		private void RefreshProjectView()
		{
			int id = this.Data.GetId();
			RoleDevelopProjectBaseData projectData = this.Data.GetProjectData();
			int roleTargetLevel = projectData.GetRoleTargetLevel();
			bool flag = RoleModel.Instance.IsRoleOwned(id);
			UUIText text = base.GetText(2);
			UUIText text2 = base.GetText(10);
			UUIItem item = base.GetItem(4);
			UUIItem item2 = base.GetItem(5);
			UUIItem item3 = base.GetItem(7);
			base.GetText(1).SetText(this.Data.GetDevelopRoleData().GetName(), true);
			base.GetItem(3).SetUIActive(true);
			List<int> hotRoleGachaIds = RoleDevelopUtil.GetHotRoleGachaIds(id, true);
			base.GetButton(6).RootUIComp.Get().SetUIActive(hotRoleGachaIds.Count > 0);
			List<RoleDevelopProjectMaterialItemData> roleDevelopProjectViewItems = projectData.GetRoleDevelopProjectViewItems();
			foreach (RoleDevelopProjectMaterialItemData roleDevelopProjectMaterialItemData in roleDevelopProjectViewItems)
			{
				ERoleDevelopLogSubPage value;
				if (this.RoleDevelopMaterialTypeToLogSubPageMap.TryGetValue(roleDevelopProjectMaterialItemData.GroupItem.Type, out value))
				{
					roleDevelopProjectMaterialItemData.LogSubPage = new ERoleDevelopLogSubPage?(value);
					roleDevelopProjectMaterialItemData.LogRoleId = new int?(id);
					roleDevelopProjectMaterialItemData.LogMainPage = new ERoleDevelopCategoryType?(ERoleDevelopCategoryType.Role);
				}
			}
			this.ItemLayout.RefreshByData(roleDevelopProjectViewItems, null, false);
			if (!flag)
			{
				text.SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(text, "RoleProject_TargetLevel", new <>z__ReadOnlySingleElementList<object>(roleTargetLevel));
				item.SetUIActive(false);
				item2.SetUIActive(false);
				LguiUtil.Instance.SetLocalTextNew(text2, "RoleProject_Tips07", Array.Empty<object>());
				bool flag2 = RoleDevelopUtil.IsCurrentVersionProspectRoleInProspect(id);
				item3.SetUIActive(!flag2);
				if (flag2)
				{
					ForecastCharacterSmallItemGrid parameters = new ForecastCharacterSmallItemGrid
					{
						Data = this.Data,
						RoleId = new int?(id)
					};
					this.RoleItemGrid.Apply<ForecastCharacterSmallItemGrid>(parameters);
					return;
				}
				RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(id);
				CharacterSmallItemGrid parameters2 = new CharacterSmallItemGrid
				{
					ItemConfigId = new int?(id),
					Data = this.Data,
					ElementId = new int?(roleConfig.Value.ElementId),
					SkinId = new int?(roleConfig.Value.SkinId)
				};
				this.RoleItemGrid.Apply<CharacterSmallItemGrid>(parameters2);
				return;
			}
			else
			{
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(id, true);
				RoleLevelData levelData = roleDataById.GetLevelData();
				int level = levelData.GetLevel();
				CharacterSmallItemGrid parameters3 = new CharacterSmallItemGrid
				{
					ItemConfigId = new int?(roleDataById.GetDataId()),
					SkinId = new int?(roleDataById.GetRoleSkinId()),
					BottomTextId = "Text_LevelShow_Text",
					BottomTextParameter = new object[]
					{
						level
					},
					Data = this.Data,
					ElementId = new int?(roleDataById.GetElementInfo().Value.Id)
				};
				this.RoleItemGrid.Apply<CharacterSmallItemGrid>(parameters3);
				bool flag3 = level >= roleTargetLevel;
				bool roleIsMaxLevel = levelData.GetRoleIsMaxLevel();
				if (flag3 && roleIsMaxLevel)
				{
					text.SetUIActive(false);
					item.SetUIActive(false);
					item2.SetUIActive(false);
					item3.SetUIActive(true);
					LguiUtil.Instance.SetLocalTextNew(text2, "RoleProject_Tips06", Array.Empty<object>());
					return;
				}
				text.SetUIActive(true);
				item3.SetUIActive(false);
				if (flag3)
				{
					LguiUtil.Instance.SetLocalTextNew(text, "RoleProject_Tips04", Array.Empty<object>());
				}
				else
				{
					LguiUtil.Instance.SetLocalTextNew(text, "RoleProject_TargetLevel", new <>z__ReadOnlySingleElementList<object>(roleTargetLevel));
				}
				this.RefreshButtonItem();
				return;
			}
		}

		// Token: 0x06028022 RID: 163874 RVA: 0x00B332A0 File Offset: 0x00B314A0
		private void RefreshButtonItem()
		{
			int id = this.Data.GetId();
			RoleDevelopRoleBaseData developRoleData = this.Data.GetDevelopRoleData();
			RoleDevelopProjectBaseData projectData = this.Data.GetProjectData();
			if (developRoleData.IsRoleNeedBreakUp() && RoleModel.Instance.GetRoleBreachState(id) == ERoleBreachState.NoEnoughCondition)
			{
				this.SetButtonState(false, "RoleProject_Button02");
				return;
			}
			bool isHighLight = RoleDevelopUtil.CheckIsAllNeedItemsEnoughOrCanBeFilled(projectData.GetRoleDevelopNeedItems());
			this.SetButtonState(isHighLight, "RoleProject_Button01");
		}

		// Token: 0x06028023 RID: 163875 RVA: 0x00B3330A File Offset: 0x00B3150A
		private void SetButtonState(bool isHighLight, string textKey)
		{
			this.NormalButtonItem.SetUiActive(!isHighLight);
			this.HighLightButtonItem.SetUiActive(isHighLight);
			(isHighLight ? this.HighLightButtonItem : this.NormalButtonItem).SetLocalTextNew(textKey, Array.Empty<object>());
		}

		// Token: 0x06028024 RID: 163876 RVA: 0x00B33344 File Offset: 0x00B31544
		private void OnClickCallJumpButton()
		{
			List<int> hotRoleGachaIds = RoleDevelopUtil.GetHotRoleGachaIds(this.Data.GetId(), true);
			UiManager.Instance.OpenView(EUiViewName.GachaMainView, hotRoleGachaIds[0], null);
		}

		// Token: 0x06028025 RID: 163877 RVA: 0x00B33380 File Offset: 0x00B31580
		private void OnClickJumpButton(int value)
		{
			int id = this.Data.GetId();
			if (!RoleModel.Instance.IsRoleOwned(id))
			{
				return;
			}
			bool flag = this.Data.GetDevelopRoleData().IsRoleNeedBreakUp();
			RoleViewViewModel roleViewViewModel = new RoleViewViewModel(id, !UiSceneManager.Instance.HasRoleSystemRoleActor(), ERoleViewSource.Normal);
			roleViewViewModel.FadeInCurveId = ERoleFadeCurveDefine.RoleFadeInCurve;
			roleViewViewModel.FadeOutCurveId = ERoleFadeCurveDefine.RoleFadeOutCurve;
			roleViewViewModel.NeedShowOnViewPlayingStartSequence = true;
			roleViewViewModel.NeedHideOnViewPlayingCloseSequence = true;
			roleViewViewModel.RoleStatePlayContextOnShow = null;
			roleViewViewModel.RoleStatePlayContextOnHide = null;
			if (flag)
			{
				RoleController.Instance.OpenRoleViewByViewModel(EUiViewName.RoleBreachView, roleViewViewModel);
			}
			else
			{
				RoleController.Instance.OpenRoleViewByViewModel(EUiViewName.RoleLevelUpView, roleViewViewModel);
			}
			RoleController.Instance.LogRoleDevelopClick(id, ERoleDevelopCategoryType.Role, ERoleDevelopLogSubPage.RoleDevelopJump, new ERoleDevelopLogItemState?(ERoleDevelopLogItemState.Normal));
		}

		// Token: 0x06028026 RID: 163878 RVA: 0x00B33435 File Offset: 0x00B31635
		private bool CanRoleItemGridExecuteChange(object parameters, bool _, EToggleState state)
		{
			return false;
		}

		// Token: 0x06028027 RID: 163879 RVA: 0x00B33438 File Offset: 0x00B31638
		private RoleDevelopProjectMaterialItem CreateItem()
		{
			return new RoleDevelopProjectMaterialItem();
		}

		// Token: 0x04015C7F RID: 89215
		private readonly Dictionary<EItemMaterialType, ERoleDevelopLogSubPage> RoleDevelopMaterialTypeToLogSubPageMap = new Dictionary<EItemMaterialType, ERoleDevelopLogSubPage>
		{
			{
				EItemMaterialType.RoleExp,
				ERoleDevelopLogSubPage.RoleDevelopExpMaterial
			},
			{
				EItemMaterialType.RoleBreak,
				ERoleDevelopLogSubPage.RoleDevelopBreakMaterial
			},
			{
				EItemMaterialType.WeaponSkill,
				ERoleDevelopLogSubPage.RoleDevelopWeaponAndSkillMaterial
			},
			{
				EItemMaterialType.Map,
				ERoleDevelopLogSubPage.RoleDevelopMapMaterial
			},
			{
				EItemMaterialType.Drop,
				ERoleDevelopLogSubPage.RoleDevelopWeaponAndSkillMaterial
			}
		};

		// Token: 0x04015C80 RID: 89216
		private SmallItemGrid RoleItemGrid;

		// Token: 0x04015C81 RID: 89217
		private ButtonItem NormalButtonItem;

		// Token: 0x04015C82 RID: 89218
		private ButtonItem HighLightButtonItem;

		// Token: 0x04015C83 RID: 89219
		private GenericLayout<RoleDevelopProjectMaterialItem, RoleDevelopProjectMaterialItemData> ItemLayout;

		// Token: 0x020098E2 RID: 39138
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402FADC RID: 195292
			SmallRoleItem,
			// Token: 0x0402FADD RID: 195293
			TxtRoleName,
			// Token: 0x0402FADE RID: 195294
			TxtGoalLevel,
			// Token: 0x0402FADF RID: 195295
			PanelItemRight,
			// Token: 0x0402FAE0 RID: 195296
			NormalButtonItem,
			// Token: 0x0402FAE1 RID: 195297
			HighLightButtonItem,
			// Token: 0x0402FAE2 RID: 195298
			BtnCallJump,
			// Token: 0x0402FAE3 RID: 195299
			PanelItemNotObtained,
			// Token: 0x0402FAE4 RID: 195300
			PanelItemDetailLayout,
			// Token: 0x0402FAE5 RID: 195301
			PanelItemList,
			// Token: 0x0402FAE6 RID: 195302
			TxtNotObtained
		}
	}
}
