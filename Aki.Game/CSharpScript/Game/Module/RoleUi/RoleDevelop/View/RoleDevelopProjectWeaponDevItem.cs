using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D12 RID: 15634
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectWeaponDevItem : UiPanelBase
	{
		// Token: 0x0602803D RID: 163901 RVA: 0x00B34054 File Offset: 0x00B32254
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnClickSwitch));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnClickCall));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602803E RID: 163902 RVA: 0x00B34290 File Offset: 0x00B32490
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectWeaponDevItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectWeaponDevItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602803F RID: 163903 RVA: 0x00B342D4 File Offset: 0x00B324D4
		private void InitWeaponItemGrid()
		{
			this.WeaponItemGrid = new SmallItemGrid();
			this.WeaponItemGrid.Initialize(base.GetItem(4).GetOwner());
			this.WeaponItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickWeaponItemGrid));
			this.WeaponItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnCanExecuteWeaponItemGridChange));
		}

		// Token: 0x06028040 RID: 163904 RVA: 0x00B34334 File Offset: 0x00B32534
		private UniTask InitButtonItem()
		{
			RoleDevelopProjectWeaponDevItem.<InitButtonItem>d__11 <InitButtonItem>d__;
			<InitButtonItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonItem>d__.<>4__this = this;
			<InitButtonItem>d__.<>1__state = -1;
			<InitButtonItem>d__.<>t__builder.Start<RoleDevelopProjectWeaponDevItem.<InitButtonItem>d__11>(ref <InitButtonItem>d__);
			return <InitButtonItem>d__.<>t__builder.Task;
		}

		// Token: 0x06028041 RID: 163905 RVA: 0x00B34377 File Offset: 0x00B32577
		private void InitLayout()
		{
			this.ItemLayout = new GenericLayout<RoleDevelopProjectMaterialItem, RoleDevelopProjectMaterialItemData>(base.GetVerticalLayout(9), new Func<RoleDevelopProjectMaterialItem>(this.CreateItem), null, false, true);
		}

		// Token: 0x06028042 RID: 163906 RVA: 0x00B3439B File Offset: 0x00B3259B
		public void RefreshByData(RoleDevelopData data)
		{
			this.Data = data;
			this.RefreshWeaponView();
			this.RefreshLayout();
		}

		// Token: 0x06028043 RID: 163907 RVA: 0x00B343B0 File Offset: 0x00B325B0
		public void RefreshWeaponView()
		{
			if (this.Data == null)
			{
				return;
			}
			RoleDevelopRoleBaseData developRoleData = this.Data.GetDevelopRoleData();
			RoleDevelopProjectBaseData projectData = this.Data.GetProjectData();
			WeaponInstance weaponInstance = developRoleData.GetWeaponInstance();
			SmallItemGrid weaponItemGrid = this.WeaponItemGrid;
			int weaponLevel = developRoleData.GetWeaponLevel();
			UUIText text = base.GetText(6);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), developRoleData.GetWeaponName(), Array.Empty<object>());
			weaponItemGrid.SetToggleInteractive(weaponInstance != null);
			base.GetItem(12).SetUIActive(weaponInstance != null);
			if (weaponInstance != null)
			{
				WeaponSmallItemGrid parameters = new WeaponSmallItemGrid
				{
					ItemConfigId = new int?(weaponInstance.GetItemId()),
					Level = new int?(weaponLevel),
					ResonanceLevel = new int?(weaponInstance.GetResonanceLevel()),
					Data = this.Data
				};
				weaponItemGrid.Apply<WeaponSmallItemGrid>(parameters);
				bool uiactive = WeaponModel.Instance.IsWeaponHighQuality(weaponInstance);
				base.GetItem(0).SetUIActive(uiactive);
				List<int> hotWeaponGachaIds = RoleDevelopUtil.GetHotWeaponGachaIds(weaponInstance.GetItemId(), true);
				base.GetButton(11).RootUIComp.Get().SetUIActive(hotWeaponGachaIds.Count > 0);
				bool flag = weaponLevel >= developRoleData.GetWeaponTargetLevel();
				bool flag2 = weaponLevel >= weaponInstance.GetMaxLevel();
				string textId = (flag || flag2) ? "RoleProject_Button02" : "RoleProject_Button01";
				this.NormalButtonItem.SetLocalTextNew(textId, Array.Empty<object>());
				this.HighLightButtonItem.SetLocalTextNew(textId, Array.Empty<object>());
				if (flag || flag2)
				{
					this.NormalButtonItem.SetUiActive(true);
					this.HighLightButtonItem.SetUiActive(false);
				}
				else
				{
					List<RoleDevelopNeedItem> weaponUpgradeNeedItems = projectData.GetWeaponUpgradeNeedItems();
					List<RoleDevelopNeedItem> weaponBreachNeedItems = projectData.GetWeaponBreachNeedItems();
					bool flag3 = RoleDevelopUtil.CheckIsAllNeedItemsEnoughOrCanBeFilled(weaponUpgradeNeedItems) && RoleDevelopUtil.CheckIsAllNeedItemsEnoughOrCanBeFilled(weaponBreachNeedItems);
					this.NormalButtonItem.SetUiActive(!flag3);
					this.HighLightButtonItem.SetUiActive(flag3);
				}
				if (flag && !flag2)
				{
					LguiUtil.Instance.SetLocalTextNew(text, "RoleProject_Tips04", Array.Empty<object>());
				}
				else
				{
					LguiUtil.Instance.SetLocalTextNew(text, "RoleProject_TargetLevel", new int[]
					{
						developRoleData.GetWeaponTargetLevel()
					});
				}
				text.SetUIActive(!flag2);
				return;
			}
			int weaponType = this.Data.GetProjectData().GetWeaponType();
			weaponItemGrid.SetIconByPath(RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(weaponType).Value.WeaponTypeIcon);
			weaponItemGrid.SetBottomTextVisible(false);
			weaponItemGrid.SetWeaponResonanceLevel(null);
			weaponItemGrid.SetQuality(null);
			text.SetUIActive(false);
			bool flag4 = RoleDevelopUtil.IsAnyProspectRole(this.Data.GetId());
			base.GetItem(0).SetUIActive(!flag4);
		}

		// Token: 0x06028044 RID: 163908 RVA: 0x00B3465C File Offset: 0x00B3285C
		public void RefreshLayout()
		{
			if (this.Data == null)
			{
				return;
			}
			int id = this.Data.GetId();
			List<RoleDevelopProjectMaterialItemData> weaponDevelopProjectViewItems = this.Data.GetProjectData().GetWeaponDevelopProjectViewItems();
			foreach (RoleDevelopProjectMaterialItemData roleDevelopProjectMaterialItemData in weaponDevelopProjectViewItems)
			{
				ERoleDevelopLogSubPage value;
				if (this.WeaponDevelopMaterialTypeToLogSubPageMap.TryGetValue(roleDevelopProjectMaterialItemData.GroupItem.Type, out value))
				{
					roleDevelopProjectMaterialItemData.LogSubPage = new ERoleDevelopLogSubPage?(value);
					roleDevelopProjectMaterialItemData.LogRoleId = new int?(id);
					roleDevelopProjectMaterialItemData.LogMainPage = new ERoleDevelopCategoryType?(ERoleDevelopCategoryType.Weapon);
				}
			}
			this.ItemLayout.RefreshByData(weaponDevelopProjectViewItems, null, false);
		}

		// Token: 0x06028045 RID: 163909 RVA: 0x00B34718 File Offset: 0x00B32918
		public void OnCommonItemCountAnyChange(int configId)
		{
			this.RefreshWeaponView();
			this.ItemLayout.RefreshWithoutDataSync();
		}

		// Token: 0x06028046 RID: 163910 RVA: 0x00B3472B File Offset: 0x00B3292B
		public void SetClickSwitchCallback(Action callback)
		{
			this.OnClickSwitchCallback = callback;
		}

		// Token: 0x06028047 RID: 163911 RVA: 0x00B34734 File Offset: 0x00B32934
		private void OnClickSwitch()
		{
			Action onClickSwitchCallback = this.OnClickSwitchCallback;
			if (onClickSwitchCallback != null)
			{
				onClickSwitchCallback();
			}
			if (this.Data != null)
			{
				RoleController.Instance.LogRoleDevelopClick(this.Data.GetId(), ERoleDevelopCategoryType.Weapon, ERoleDevelopLogSubPage.WeaponDevelopViewRecommendedWeapons, null);
			}
		}

		// Token: 0x06028048 RID: 163912 RVA: 0x00B3477C File Offset: 0x00B3297C
		private void OnClickCall()
		{
			if (this.Data == null)
			{
				return;
			}
			WeaponInstance weaponInstance = this.Data.GetDevelopRoleData().GetWeaponInstance();
			if (weaponInstance == null)
			{
				return;
			}
			List<int> hotWeaponGachaIds = RoleDevelopUtil.GetHotWeaponGachaIds(weaponInstance.GetItemId(), true);
			if (hotWeaponGachaIds.Count > 0)
			{
				UiManager.Instance.OpenView(EUiViewName.GachaMainView, hotWeaponGachaIds[0], null);
			}
		}

		// Token: 0x06028049 RID: 163913 RVA: 0x00B347D9 File Offset: 0x00B329D9
		private RoleDevelopProjectMaterialItem CreateItem()
		{
			return new RoleDevelopProjectMaterialItem();
		}

		// Token: 0x0602804A RID: 163914 RVA: 0x00B347E0 File Offset: 0x00B329E0
		[NullableContext(2)]
		private bool OnCanExecuteWeaponItemGridChange(object data, bool isForceSelected, EToggleState state)
		{
			return false;
		}

		// Token: 0x0602804B RID: 163915 RVA: 0x00B347E4 File Offset: 0x00B329E4
		private void OnClickWeaponItemGrid(MediumItemGridExtendCallback callbackParameter)
		{
			if (this.Data == null)
			{
				return;
			}
			WeaponInstance weaponInstance = this.Data.GetDevelopRoleData().GetWeaponInstance();
			if (weaponInstance != null)
			{
				int valueOrDefault = weaponInstance.GetIncId().GetValueOrDefault();
				int itemId = weaponInstance.GetItemId();
				if (valueOrDefault > 0)
				{
					ItemController.Instance.OpenItemTipsByItemUid(valueOrDefault, itemId, true, null);
					return;
				}
				ItemController.Instance.OpenItemTipsByItemId(itemId, true, null, false);
			}
		}

		// Token: 0x0602804C RID: 163916 RVA: 0x00B34848 File Offset: 0x00B32A48
		private void OnClickWeaponJump(int value)
		{
			if (this.Data == null)
			{
				return;
			}
			WeaponInstance weaponInstance = this.Data.GetDevelopRoleData().GetWeaponInstance();
			if (weaponInstance == null)
			{
				return;
			}
			int skinIdByRoleId = WeaponSkinModel.Instance.GetSkinIdByRoleId(weaponInstance.GetRoleId());
			WeaponRootViewParam param = new WeaponRootViewParam
			{
				WeaponIncId = weaponInstance.GetIncId().GetValueOrDefault(),
				WeaponSkinId = skinIdByRoleId,
				IsFromRoleRootView = false
			};
			UiManager.Instance.OpenView(EUiViewName.WeaponRootView, param, null);
			RoleDevelopRoleBaseData developRoleData = this.Data.GetDevelopRoleData();
			ERoleDevelopLogSubPage subPage = (developRoleData.IsWeaponMaxLevel() && !developRoleData.IsWeaponNeedBreakUp()) ? ERoleDevelopLogSubPage.WeaponDevelopPerfectJump : ERoleDevelopLogSubPage.WeaponDevelopJump;
			RoleController.Instance.LogRoleDevelopClick(this.Data.GetId(), ERoleDevelopCategoryType.Weapon, subPage, null);
		}

		// Token: 0x04015C8B RID: 89227
		private readonly Dictionary<EItemMaterialType, ERoleDevelopLogSubPage> WeaponDevelopMaterialTypeToLogSubPageMap = new Dictionary<EItemMaterialType, ERoleDevelopLogSubPage>
		{
			{
				EItemMaterialType.WeaponExp,
				ERoleDevelopLogSubPage.WeaponDevelopExpMaterial
			},
			{
				EItemMaterialType.WeaponSkill,
				ERoleDevelopLogSubPage.WeaponDevelopWeaponAndSkillMaterial1
			},
			{
				EItemMaterialType.Drop,
				ERoleDevelopLogSubPage.WeaponDevelopWeaponAndSkillMaterial2
			}
		};

		// Token: 0x04015C8C RID: 89228
		[Nullable(2)]
		private RoleDevelopData Data;

		// Token: 0x04015C8D RID: 89229
		[Nullable(2)]
		private Action OnClickSwitchCallback;

		// Token: 0x04015C8E RID: 89230
		private SmallItemGrid WeaponItemGrid;

		// Token: 0x04015C8F RID: 89231
		private GenericLayout<RoleDevelopProjectMaterialItem, RoleDevelopProjectMaterialItemData> ItemLayout;

		// Token: 0x04015C90 RID: 89232
		private ButtonItem NormalButtonItem;

		// Token: 0x04015C91 RID: 89233
		private ButtonItem HighLightButtonItem;

		// Token: 0x020098E9 RID: 39145
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402FB0F RID: 195343
			PanelSwitch,
			// Token: 0x0402FB10 RID: 195344
			BtnSwitch,
			// Token: 0x0402FB11 RID: 195345
			PanelWeaponType,
			// Token: 0x0402FB12 RID: 195346
			IconWeaponType,
			// Token: 0x0402FB13 RID: 195347
			WeaponItem,
			// Token: 0x0402FB14 RID: 195348
			TxtWeaponName,
			// Token: 0x0402FB15 RID: 195349
			TxtGoalLevel,
			// Token: 0x0402FB16 RID: 195350
			BtnJump,
			// Token: 0x0402FB17 RID: 195351
			BtnPerfectJump,
			// Token: 0x0402FB18 RID: 195352
			PanelDetailLayout,
			// Token: 0x0402FB19 RID: 195353
			PanelDetailItem,
			// Token: 0x0402FB1A RID: 195354
			BtnCall,
			// Token: 0x0402FB1B RID: 195355
			RightItem
		}
	}
}
