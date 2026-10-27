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
	// Token: 0x02004D46 RID: 19782
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectRolePanel : RoleDevelopProjectBasePanel
	{
		// Token: 0x060331B6 RID: 209334 RVA: 0x00BE97BC File Offset: 0x00BE79BC
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

		// Token: 0x060331B7 RID: 209335 RVA: 0x00BE998E File Offset: 0x00BE7B8E
		protected override void OnStart()
		{
			this.InitRoleItemGrid();
			this.InitButtonItem();
			this.InitLayout();
		}

		// Token: 0x060331B8 RID: 209336 RVA: 0x00BE99A4 File Offset: 0x00BE7BA4
		private void InitRoleItemGrid()
		{
			this.RoleItemGrid = new SmallItemGrid();
			this.RoleItemGrid.Initialize(base.GetItem(0).GetOwner());
			this.RoleItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.CanRoleItemGridExecuteChange));
			this.RoleItemGrid.SetExtendToggleEnable(false, false);
			this.RoleItemGrid.SetToggleInteractive(false);
		}

		// Token: 0x060331B9 RID: 209337 RVA: 0x00BE9A04 File Offset: 0x00BE7C04
		private void InitButtonItem()
		{
			this.NormalButtonItem = new ButtonItem(base.GetItem(4));
			this.NormalButtonItem.SetLocalTextNew("RoleProject_Button01", Array.Empty<object>());
			this.NormalButtonItem.SetFunction(new Action<int>(this.OnClickJumpButton));
			this.HighLightButtonItem = new ButtonItem(base.GetItem(5));
			this.HighLightButtonItem.SetLocalTextNew("RoleProject_Button01", Array.Empty<object>());
			this.HighLightButtonItem.SetFunction(new Action<int>(this.OnClickJumpButton));
		}

		// Token: 0x060331BA RID: 209338 RVA: 0x00BE9A8D File Offset: 0x00BE7C8D
		private void InitLayout()
		{
			this.ItemLayout = new GenericLayout<RoleDevelopProjectMaterialItem, RoleDevelopProjectMaterialItemData>(base.GetVerticalLayout(8), new Func<RoleDevelopProjectMaterialItem>(this.CreateItem), null, false, true);
		}

		// Token: 0x060331BB RID: 209339 RVA: 0x00BE9AB0 File Offset: 0x00BE7CB0
		public override void OnCommonItemCountAnyChange(int configId)
		{
			this.RefreshButtonItem();
			this.ItemLayout.RefreshWithoutDataSync();
		}

		// Token: 0x060331BC RID: 209340 RVA: 0x00BE9AC3 File Offset: 0x00BE7CC3
		protected override void OnRefreshView(bool forceRefresh)
		{
			if (RoleDevelopUtil.IsProspectRole(this.Data.GetId()))
			{
				this.RefreshProspectProjectView();
				return;
			}
			this.RefreshProjectView();
		}

		// Token: 0x060331BD RID: 209341 RVA: 0x00BE9AE4 File Offset: 0x00BE7CE4
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

		// Token: 0x060331BE RID: 209342 RVA: 0x00BE9BD8 File Offset: 0x00BE7DD8
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
					ElementId = new int?(roleConfig.Value.ElementId)
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

		// Token: 0x060331BF RID: 209343 RVA: 0x00BE9F60 File Offset: 0x00BE8160
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

		// Token: 0x060331C0 RID: 209344 RVA: 0x00BE9FCA File Offset: 0x00BE81CA
		private void SetButtonState(bool isHighLight, string textKey)
		{
			this.NormalButtonItem.SetUiActive(!isHighLight);
			this.HighLightButtonItem.SetUiActive(isHighLight);
			(isHighLight ? this.HighLightButtonItem : this.NormalButtonItem).SetLocalTextNew(textKey, Array.Empty<object>());
		}

		// Token: 0x060331C1 RID: 209345 RVA: 0x00BEA004 File Offset: 0x00BE8204
		private void OnClickCallJumpButton()
		{
			List<int> hotRoleGachaIds = RoleDevelopUtil.GetHotRoleGachaIds(this.Data.GetId(), true);
			UiManager.Instance.OpenView(EUiViewName.GachaMainView, hotRoleGachaIds[0], null);
		}

		// Token: 0x060331C2 RID: 209346 RVA: 0x00BEA040 File Offset: 0x00BE8240
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

		// Token: 0x060331C3 RID: 209347 RVA: 0x00BEA0F5 File Offset: 0x00BE82F5
		private bool CanRoleItemGridExecuteChange(object parameters, bool _, EToggleState state)
		{
			return false;
		}

		// Token: 0x060331C4 RID: 209348 RVA: 0x00BEA0F8 File Offset: 0x00BE82F8
		private RoleDevelopProjectMaterialItem CreateItem()
		{
			return new RoleDevelopProjectMaterialItem();
		}

		// Token: 0x0401B2AE RID: 111278
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

		// Token: 0x0401B2AF RID: 111279
		private SmallItemGrid RoleItemGrid;

		// Token: 0x0401B2B0 RID: 111280
		private ButtonItem NormalButtonItem;

		// Token: 0x0401B2B1 RID: 111281
		private ButtonItem HighLightButtonItem;

		// Token: 0x0401B2B2 RID: 111282
		private GenericLayout<RoleDevelopProjectMaterialItem, RoleDevelopProjectMaterialItemData> ItemLayout;

		// Token: 0x0200AEAE RID: 44718
		[NullableContext(0)]
		public static class EComponentType
		{
			// Token: 0x040350B9 RID: 217273
			public const int SmallRoleItem = 0;

			// Token: 0x040350BA RID: 217274
			public const int TxtRoleName = 1;

			// Token: 0x040350BB RID: 217275
			public const int TxtGoalLevel = 2;

			// Token: 0x040350BC RID: 217276
			public const int PanelItemRight = 3;

			// Token: 0x040350BD RID: 217277
			public const int NormalButtonItem = 4;

			// Token: 0x040350BE RID: 217278
			public const int HighLightButtonItem = 5;

			// Token: 0x040350BF RID: 217279
			public const int BtnCallJump = 6;

			// Token: 0x040350C0 RID: 217280
			public const int PanelItemNotObtained = 7;

			// Token: 0x040350C1 RID: 217281
			public const int PanelItemDetailLayout = 8;

			// Token: 0x040350C2 RID: 217282
			public const int PanelItemList = 9;

			// Token: 0x040350C3 RID: 217283
			public const int TxtNotObtained = 10;
		}
	}
}
