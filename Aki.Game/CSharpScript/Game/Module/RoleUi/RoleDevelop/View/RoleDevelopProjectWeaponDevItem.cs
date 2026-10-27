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
	// Token: 0x02004D49 RID: 19785
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectWeaponDevItem : UiPanelBase
	{
		// Token: 0x060331DA RID: 209370 RVA: 0x00BEACF4 File Offset: 0x00BE8EF4
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

		// Token: 0x060331DB RID: 209371 RVA: 0x00BEAF30 File Offset: 0x00BE9130
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectWeaponDevItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectWeaponDevItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060331DC RID: 209372 RVA: 0x00BEAF74 File Offset: 0x00BE9174
		private void InitWeaponItemGrid()
		{
			this.WeaponItemGrid = new SmallItemGrid();
			this.WeaponItemGrid.Initialize(base.GetItem(4).GetOwner());
			this.WeaponItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickWeaponItemGrid));
			this.WeaponItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnCanExecuteWeaponItemGridChange));
		}

		// Token: 0x060331DD RID: 209373 RVA: 0x00BEAFD4 File Offset: 0x00BE91D4
		private UniTask InitButtonItem()
		{
			RoleDevelopProjectWeaponDevItem.<InitButtonItem>d__11 <InitButtonItem>d__;
			<InitButtonItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonItem>d__.<>4__this = this;
			<InitButtonItem>d__.<>1__state = -1;
			<InitButtonItem>d__.<>t__builder.Start<RoleDevelopProjectWeaponDevItem.<InitButtonItem>d__11>(ref <InitButtonItem>d__);
			return <InitButtonItem>d__.<>t__builder.Task;
		}

		// Token: 0x060331DE RID: 209374 RVA: 0x00BEB017 File Offset: 0x00BE9217
		private void InitLayout()
		{
			this.ItemLayout = new GenericLayout<RoleDevelopProjectMaterialItem, RoleDevelopProjectMaterialItemData>(base.GetVerticalLayout(9), new Func<RoleDevelopProjectMaterialItem>(this.CreateItem), null, false, true);
		}

		// Token: 0x060331DF RID: 209375 RVA: 0x00BEB03B File Offset: 0x00BE923B
		public void RefreshByData(RoleDevelopData data)
		{
			this.Data = data;
			this.RefreshWeaponView();
			this.RefreshLayout();
		}

		// Token: 0x060331E0 RID: 209376 RVA: 0x00BEB050 File Offset: 0x00BE9250
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
				PropSmallItemGrid parameters = new PropSmallItemGrid
				{
					ItemConfigId = new int?(weaponInstance.GetItemId()),
					BottomTextId = "Text_LevelShow_Text",
					BottomTextParameter = new object[]
					{
						weaponLevel
					},
					Data = this.Data
				};
				weaponItemGrid.Apply<PropSmallItemGrid>(parameters);
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
			weaponItemGrid.SetQuality(null);
			text.SetUIActive(false);
			bool flag4 = RoleDevelopUtil.IsAnyProspectRole(this.Data.GetId());
			base.GetItem(0).SetUIActive(!flag4);
		}

		// Token: 0x060331E1 RID: 209377 RVA: 0x00BEB2F8 File Offset: 0x00BE94F8
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

		// Token: 0x060331E2 RID: 209378 RVA: 0x00BEB3B4 File Offset: 0x00BE95B4
		public void OnCommonItemCountAnyChange(int configId)
		{
			this.RefreshWeaponView();
			this.ItemLayout.RefreshWithoutDataSync();
		}

		// Token: 0x060331E3 RID: 209379 RVA: 0x00BEB3C7 File Offset: 0x00BE95C7
		public void SetClickSwitchCallback(Action callback)
		{
			this.OnClickSwitchCallback = callback;
		}

		// Token: 0x060331E4 RID: 209380 RVA: 0x00BEB3D0 File Offset: 0x00BE95D0
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

		// Token: 0x060331E5 RID: 209381 RVA: 0x00BEB418 File Offset: 0x00BE9618
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

		// Token: 0x060331E6 RID: 209382 RVA: 0x00BEB475 File Offset: 0x00BE9675
		private RoleDevelopProjectMaterialItem CreateItem()
		{
			return new RoleDevelopProjectMaterialItem();
		}

		// Token: 0x060331E7 RID: 209383 RVA: 0x00BEB47C File Offset: 0x00BE967C
		[NullableContext(2)]
		private bool OnCanExecuteWeaponItemGridChange(object data, bool isForceSelected, EToggleState state)
		{
			return false;
		}

		// Token: 0x060331E8 RID: 209384 RVA: 0x00BEB480 File Offset: 0x00BE9680
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
				ItemController.Instance.OpenItemTipsByItemId(itemId, true, null);
			}
		}

		// Token: 0x060331E9 RID: 209385 RVA: 0x00BEB4E0 File Offset: 0x00BE96E0
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

		// Token: 0x0401B2B9 RID: 111289
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

		// Token: 0x0401B2BA RID: 111290
		[Nullable(2)]
		private RoleDevelopData Data;

		// Token: 0x0401B2BB RID: 111291
		[Nullable(2)]
		private Action OnClickSwitchCallback;

		// Token: 0x0401B2BC RID: 111292
		private SmallItemGrid WeaponItemGrid;

		// Token: 0x0401B2BD RID: 111293
		private GenericLayout<RoleDevelopProjectMaterialItem, RoleDevelopProjectMaterialItemData> ItemLayout;

		// Token: 0x0401B2BE RID: 111294
		private ButtonItem NormalButtonItem;

		// Token: 0x0401B2BF RID: 111295
		private ButtonItem HighLightButtonItem;

		// Token: 0x0200AEB5 RID: 44725
		[NullableContext(0)]
		public static class EComponentType
		{
			// Token: 0x040350E9 RID: 217321
			public const int PanelSwitch = 0;

			// Token: 0x040350EA RID: 217322
			public const int BtnSwitch = 1;

			// Token: 0x040350EB RID: 217323
			public const int PanelWeaponType = 2;

			// Token: 0x040350EC RID: 217324
			public const int IconWeaponType = 3;

			// Token: 0x040350ED RID: 217325
			public const int WeaponItem = 4;

			// Token: 0x040350EE RID: 217326
			public const int TxtWeaponName = 5;

			// Token: 0x040350EF RID: 217327
			public const int TxtGoalLevel = 6;

			// Token: 0x040350F0 RID: 217328
			public const int BtnJump = 7;

			// Token: 0x040350F1 RID: 217329
			public const int BtnPerfectJump = 8;

			// Token: 0x040350F2 RID: 217330
			public const int PanelDetailLayout = 9;

			// Token: 0x040350F3 RID: 217331
			public const int PanelDetailItem = 10;

			// Token: 0x040350F4 RID: 217332
			public const int BtnCall = 11;

			// Token: 0x040350F5 RID: 217333
			public const int RightItem = 12;
		}
	}
}
