using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
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
	// Token: 0x02004D4B RID: 19787
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectWeaponRecommendItem : UiPanelBase
	{
		// Token: 0x060331F3 RID: 209395 RVA: 0x00BEB78C File Offset: 0x00BE998C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 13;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickSwitch));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickCall));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060331F4 RID: 209396 RVA: 0x00BEB9C8 File Offset: 0x00BE9BC8
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectWeaponRecommendItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectWeaponRecommendItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060331F5 RID: 209397 RVA: 0x00BEBA0C File Offset: 0x00BE9C0C
		private void InitWeaponItemGrid()
		{
			this.WeaponItemGrid = new SmallItemGrid();
			this.WeaponItemGrid.Initialize(base.GetItem(3).GetOwner());
			this.WeaponItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickWeaponItemGrid));
			this.WeaponItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnCanExecuteWeaponItemGridChange));
		}

		// Token: 0x060331F6 RID: 209398 RVA: 0x00BEBA69 File Offset: 0x00BE9C69
		private void InitLayout()
		{
			this.ItemLayout = new GenericLayout<RoleDevelopProjectWeaponRecommendListItem, RoleDevelopProjectWeaponRecommendListItemData>(base.GetVerticalLayout(9), new Func<RoleDevelopProjectWeaponRecommendListItem>(this.CreateItem), null, false, true);
		}

		// Token: 0x060331F7 RID: 209399 RVA: 0x00BEBA90 File Offset: 0x00BE9C90
		private UniTask InitButtonItem()
		{
			RoleDevelopProjectWeaponRecommendItem.<InitButtonItem>d__12 <InitButtonItem>d__;
			<InitButtonItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonItem>d__.<>4__this = this;
			<InitButtonItem>d__.<>1__state = -1;
			<InitButtonItem>d__.<>t__builder.Start<RoleDevelopProjectWeaponRecommendItem.<InitButtonItem>d__12>(ref <InitButtonItem>d__);
			return <InitButtonItem>d__.<>t__builder.Task;
		}

		// Token: 0x060331F8 RID: 209400 RVA: 0x00BEBAD3 File Offset: 0x00BE9CD3
		public void RefreshByData(RoleDevelopData data)
		{
			this.Data = data;
			this.RefreshSwitchButton();
			this.RefreshWeaponView();
			this.RefreshLayout();
		}

		// Token: 0x060331F9 RID: 209401 RVA: 0x00BEBAF0 File Offset: 0x00BE9CF0
		private void RefreshSwitchButton()
		{
			if (this.Data == null)
			{
				return;
			}
			bool uiactive = false;
			int id = this.Data.GetId();
			if (!RoleModel.Instance.IsRoleOwned(id))
			{
				if (!RoleDevelopUtil.IsAnyProspectRole(id))
				{
					uiactive = true;
				}
			}
			else
			{
				WeaponInstance weaponInstance = this.Data.GetDevelopRoleData().GetWeaponInstance();
				uiactive = (weaponInstance != null && WeaponModel.Instance.IsWeaponHighQuality(weaponInstance));
			}
			base.GetItem(11).SetUIActive(uiactive);
		}

		// Token: 0x060331FA RID: 209402 RVA: 0x00BEBB60 File Offset: 0x00BE9D60
		private void RefreshWeaponView()
		{
			if (this.Data == null)
			{
				return;
			}
			RoleDevelopRoleBaseData developRoleData = this.Data.GetDevelopRoleData();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), developRoleData.GetWeaponName(), Array.Empty<object>());
			if (!RoleModel.Instance.IsRoleOwned(this.Data.GetId()))
			{
				int weaponType = this.Data.GetProjectData().GetWeaponType();
				RoleDevWeaponItem? roleDevWeaponItemConfig = RoleDevConfig.Instance.GetRoleDevWeaponItemConfig(weaponType);
				this.WeaponItemGrid.SetIconByPath(roleDevWeaponItemConfig.Value.WeaponTypeIcon);
				this.WeaponItemGrid.SetBottomTextVisible(false);
				this.WeaponItemGrid.SetQuality(null);
				base.GetText(5).SetUIActive(false);
				base.GetItem(6).SetUIActive(false);
				base.GetButton(12).RootUIComp.Get().SetUIActive(false);
			}
			else
			{
				WeaponInstance weaponInstance = developRoleData.GetWeaponInstance();
				int itemId = weaponInstance.GetItemId();
				if (WeaponModel.Instance.IsWeaponHighQuality(weaponInstance))
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "RoleProject_Tips01", Array.Empty<object>());
				}
				else
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "RoleProject_Tips08", Array.Empty<object>());
				}
				PropSmallItemGrid parameters = new PropSmallItemGrid
				{
					ItemConfigId = new int?(itemId),
					BottomTextId = "Text_LevelShow_Text",
					BottomTextParameter = new object[]
					{
						weaponInstance.GetLevel()
					},
					Data = this.Data
				};
				this.WeaponItemGrid.Apply<PropSmallItemGrid>(parameters);
				base.GetItem(6).SetUIActive(true);
				List<int> hotWeaponGachaIds = RoleDevelopUtil.GetHotWeaponGachaIds(itemId, true);
				base.GetButton(12).RootUIComp.Get().SetUIActive(hotWeaponGachaIds.Count > 0);
			}
			this.BtnJumpItem.SetUiActive(true);
			this.BtnPerfectJumpItem.SetUiActive(false);
		}

		// Token: 0x060331FB RID: 209403 RVA: 0x00BEBD54 File Offset: 0x00BE9F54
		private void RefreshLayout()
		{
			if (this.Data == null)
			{
				this.ItemLayout.RefreshByData(new List<RoleDevelopProjectWeaponRecommendListItemData>(), null, false);
				return;
			}
			int id = this.Data.GetId();
			int[] weaponRecommendListConfig = RoleDevConfig.Instance.GetWeaponRecommendListConfig(id);
			if (weaponRecommendListConfig == null)
			{
				this.ItemLayout.RefreshByData(new List<RoleDevelopProjectWeaponRecommendListItemData>(), null, false);
				return;
			}
			List<RoleDevelopProjectWeaponRecommendListItemData> list = new List<RoleDevelopProjectWeaponRecommendListItemData>();
			for (int i = 0; i < weaponRecommendListConfig.Length; i++)
			{
				int recommendWeaponId = weaponRecommendListConfig[i];
				RoleDevelopProjectWeaponRecommendListItemData roleDevelopProjectWeaponRecommendListItemData = new RoleDevelopProjectWeaponRecommendListItemData
				{
					DevelopRoleId = id,
					RecommendWeaponId = recommendWeaponId
				};
				if (i < this.WeaponRecommendLogSubPageList.Count)
				{
					ERoleDevelopLogSubPage value = this.WeaponRecommendLogSubPageList[i];
					roleDevelopProjectWeaponRecommendListItemData.LogRoleId = new int?(id);
					roleDevelopProjectWeaponRecommendListItemData.LogMainPage = new ERoleDevelopCategoryType?(ERoleDevelopCategoryType.Weapon);
					roleDevelopProjectWeaponRecommendListItemData.LogSubPage = new ERoleDevelopLogSubPage?(value);
				}
				list.Add(roleDevelopProjectWeaponRecommendListItemData);
			}
			this.ItemLayout.RefreshByData(list, null, false);
		}

		// Token: 0x060331FC RID: 209404 RVA: 0x00BEBE33 File Offset: 0x00BEA033
		public void SetClickSwitchCallback(Action callback)
		{
			this.OnClickSwitchCallback = callback;
		}

		// Token: 0x060331FD RID: 209405 RVA: 0x00BEBE3C File Offset: 0x00BEA03C
		private void OnClickSwitch()
		{
			Action onClickSwitchCallback = this.OnClickSwitchCallback;
			if (onClickSwitchCallback == null)
			{
				return;
			}
			onClickSwitchCallback();
		}

		// Token: 0x060331FE RID: 209406 RVA: 0x00BEBE50 File Offset: 0x00BEA050
		private void OnClickCall()
		{
			if (this.Data == null || !RoleModel.Instance.IsRoleOwned(this.Data.GetId()))
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

		// Token: 0x060331FF RID: 209407 RVA: 0x00BEBEC4 File Offset: 0x00BEA0C4
		[NullableContext(2)]
		private bool OnCanExecuteWeaponItemGridChange(object data, bool isForceSelected, EToggleState state)
		{
			return false;
		}

		// Token: 0x06033200 RID: 209408 RVA: 0x00BEBEC8 File Offset: 0x00BEA0C8
		private void OnClickWeaponItemGrid(MediumItemGridExtendCallback callback)
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

		// Token: 0x06033201 RID: 209409 RVA: 0x00BEBF28 File Offset: 0x00BEA128
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
			int? incId = weaponInstance.GetIncId();
			RoleDevelopUtil.OpenWeaponReplaceView(this.Data.GetId(), incId.GetValueOrDefault());
			RoleController.Instance.LogRoleDevelopClick(this.Data.GetId(), ERoleDevelopCategoryType.Weapon, ERoleDevelopLogSubPage.WeaponDevelopReplace, null);
		}

		// Token: 0x06033202 RID: 209410 RVA: 0x00BEBF91 File Offset: 0x00BEA191
		private RoleDevelopProjectWeaponRecommendListItem CreateItem()
		{
			return new RoleDevelopProjectWeaponRecommendListItem();
		}

		// Token: 0x06033203 RID: 209411 RVA: 0x00BEBF98 File Offset: 0x00BEA198
		public unsafe RoleDevelopProjectWeaponRecommendItem()
		{
			int num = 3;
			List<ERoleDevelopLogSubPage> list = new List<ERoleDevelopLogSubPage>(num);
			CollectionsMarshal.SetCount<ERoleDevelopLogSubPage>(list, num);
			Span<ERoleDevelopLogSubPage> span = CollectionsMarshal.AsSpan<ERoleDevelopLogSubPage>(list);
			int num2 = 0;
			*span[num2] = ERoleDevelopLogSubPage.WeaponDevelopEquip1;
			num2++;
			*span[num2] = ERoleDevelopLogSubPage.WeaponDevelopEquip2;
			num2++;
			*span[num2] = ERoleDevelopLogSubPage.WeaponDevelopEquip3;
			this.WeaponRecommendLogSubPageList = list;
			base..ctor();
		}

		// Token: 0x0401B2C3 RID: 111299
		private readonly List<ERoleDevelopLogSubPage> WeaponRecommendLogSubPageList;

		// Token: 0x0401B2C4 RID: 111300
		[Nullable(2)]
		private RoleDevelopData Data;

		// Token: 0x0401B2C5 RID: 111301
		private SmallItemGrid WeaponItemGrid;

		// Token: 0x0401B2C6 RID: 111302
		private ButtonItem BtnJumpItem;

		// Token: 0x0401B2C7 RID: 111303
		private ButtonItem BtnPerfectJumpItem;

		// Token: 0x0401B2C8 RID: 111304
		private GenericLayout<RoleDevelopProjectWeaponRecommendListItem, RoleDevelopProjectWeaponRecommendListItemData> ItemLayout;

		// Token: 0x0401B2C9 RID: 111305
		[Nullable(2)]
		private Action OnClickSwitchCallback;

		// Token: 0x0200AEBA RID: 44730
		[NullableContext(0)]
		public static class EComponentType
		{
			// Token: 0x04035104 RID: 217348
			public const int BtnSwitch = 0;

			// Token: 0x04035105 RID: 217349
			public const int PanelWeaponType = 1;

			// Token: 0x04035106 RID: 217350
			public const int IconWeaponType = 2;

			// Token: 0x04035107 RID: 217351
			public const int WeaponItem = 3;

			// Token: 0x04035108 RID: 217352
			public const int TxtWeaponName = 4;

			// Token: 0x04035109 RID: 217353
			public const int TxtGoalLevel = 5;

			// Token: 0x0403510A RID: 217354
			public const int PanelRight = 6;

			// Token: 0x0403510B RID: 217355
			public const int BtnJump = 7;

			// Token: 0x0403510C RID: 217356
			public const int BtnPerfectJump = 8;

			// Token: 0x0403510D RID: 217357
			public const int PanelSubLayout = 9;

			// Token: 0x0403510E RID: 217358
			public const int PanelSubItem = 10;

			// Token: 0x0403510F RID: 217359
			public const int PanelRecommendSwitch = 11;

			// Token: 0x04035110 RID: 217360
			public const int BtnCall = 12;
		}
	}
}
