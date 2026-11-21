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
	// Token: 0x02003D14 RID: 15636
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopProjectWeaponRecommendItem : UiPanelBase
	{
		// Token: 0x06028056 RID: 163926 RVA: 0x00B34AF4 File Offset: 0x00B32CF4
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

		// Token: 0x06028057 RID: 163927 RVA: 0x00B34D30 File Offset: 0x00B32F30
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectWeaponRecommendItem.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectWeaponRecommendItem.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06028058 RID: 163928 RVA: 0x00B34D74 File Offset: 0x00B32F74
		private void InitWeaponItemGrid()
		{
			this.WeaponItemGrid = new SmallItemGrid();
			this.WeaponItemGrid.Initialize(base.GetItem(3).GetOwner());
			this.WeaponItemGrid.BindOnExtendToggleClicked(new Action<MediumItemGridExtendCallback>(this.OnClickWeaponItemGrid));
			this.WeaponItemGrid.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnCanExecuteWeaponItemGridChange));
		}

		// Token: 0x06028059 RID: 163929 RVA: 0x00B34DD1 File Offset: 0x00B32FD1
		private void InitLayout()
		{
			this.ItemLayout = new GenericLayout<RoleDevelopProjectWeaponRecommendListItem, RoleDevelopProjectWeaponRecommendListItemData>(base.GetVerticalLayout(9), new Func<RoleDevelopProjectWeaponRecommendListItem>(this.CreateItem), null, false, true);
		}

		// Token: 0x0602805A RID: 163930 RVA: 0x00B34DF8 File Offset: 0x00B32FF8
		private UniTask InitButtonItem()
		{
			RoleDevelopProjectWeaponRecommendItem.<InitButtonItem>d__12 <InitButtonItem>d__;
			<InitButtonItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonItem>d__.<>4__this = this;
			<InitButtonItem>d__.<>1__state = -1;
			<InitButtonItem>d__.<>t__builder.Start<RoleDevelopProjectWeaponRecommendItem.<InitButtonItem>d__12>(ref <InitButtonItem>d__);
			return <InitButtonItem>d__.<>t__builder.Task;
		}

		// Token: 0x0602805B RID: 163931 RVA: 0x00B34E3B File Offset: 0x00B3303B
		public void RefreshByData(RoleDevelopData data)
		{
			this.Data = data;
			this.RefreshSwitchButton();
			this.RefreshWeaponView();
			this.RefreshLayout();
		}

		// Token: 0x0602805C RID: 163932 RVA: 0x00B34E58 File Offset: 0x00B33058
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

		// Token: 0x0602805D RID: 163933 RVA: 0x00B34EC8 File Offset: 0x00B330C8
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
				this.WeaponItemGrid.SetWeaponResonanceLevel(null);
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
				WeaponSmallItemGrid parameters = new WeaponSmallItemGrid
				{
					ItemConfigId = new int?(itemId),
					Level = new int?(weaponInstance.GetLevel()),
					ResonanceLevel = new int?(weaponInstance.GetResonanceLevel()),
					Data = this.Data
				};
				this.WeaponItemGrid.Apply<WeaponSmallItemGrid>(parameters);
				base.GetItem(6).SetUIActive(true);
				List<int> hotWeaponGachaIds = RoleDevelopUtil.GetHotWeaponGachaIds(itemId, true);
				base.GetButton(12).RootUIComp.Get().SetUIActive(hotWeaponGachaIds.Count > 0);
			}
			this.BtnJumpItem.SetUiActive(true);
			this.BtnPerfectJumpItem.SetUiActive(false);
		}

		// Token: 0x0602805E RID: 163934 RVA: 0x00B350C4 File Offset: 0x00B332C4
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

		// Token: 0x0602805F RID: 163935 RVA: 0x00B351A3 File Offset: 0x00B333A3
		public void SetClickSwitchCallback(Action callback)
		{
			this.OnClickSwitchCallback = callback;
		}

		// Token: 0x06028060 RID: 163936 RVA: 0x00B351AC File Offset: 0x00B333AC
		private void OnClickSwitch()
		{
			Action onClickSwitchCallback = this.OnClickSwitchCallback;
			if (onClickSwitchCallback == null)
			{
				return;
			}
			onClickSwitchCallback();
		}

		// Token: 0x06028061 RID: 163937 RVA: 0x00B351C0 File Offset: 0x00B333C0
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

		// Token: 0x06028062 RID: 163938 RVA: 0x00B35234 File Offset: 0x00B33434
		[NullableContext(2)]
		private bool OnCanExecuteWeaponItemGridChange(object data, bool isForceSelected, EToggleState state)
		{
			return false;
		}

		// Token: 0x06028063 RID: 163939 RVA: 0x00B35238 File Offset: 0x00B33438
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
				ItemController.Instance.OpenItemTipsByItemId(itemId, true, null, false);
			}
		}

		// Token: 0x06028064 RID: 163940 RVA: 0x00B3529C File Offset: 0x00B3349C
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

		// Token: 0x06028065 RID: 163941 RVA: 0x00B35305 File Offset: 0x00B33505
		private RoleDevelopProjectWeaponRecommendListItem CreateItem()
		{
			return new RoleDevelopProjectWeaponRecommendListItem();
		}

		// Token: 0x06028066 RID: 163942 RVA: 0x00B3530C File Offset: 0x00B3350C
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

		// Token: 0x04015C95 RID: 89237
		private readonly List<ERoleDevelopLogSubPage> WeaponRecommendLogSubPageList;

		// Token: 0x04015C96 RID: 89238
		[Nullable(2)]
		private RoleDevelopData Data;

		// Token: 0x04015C97 RID: 89239
		private SmallItemGrid WeaponItemGrid;

		// Token: 0x04015C98 RID: 89240
		private ButtonItem BtnJumpItem;

		// Token: 0x04015C99 RID: 89241
		private ButtonItem BtnPerfectJumpItem;

		// Token: 0x04015C9A RID: 89242
		private GenericLayout<RoleDevelopProjectWeaponRecommendListItem, RoleDevelopProjectWeaponRecommendListItemData> ItemLayout;

		// Token: 0x04015C9B RID: 89243
		[Nullable(2)]
		private Action OnClickSwitchCallback;

		// Token: 0x020098EE RID: 39150
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402FB2C RID: 195372
			BtnSwitch,
			// Token: 0x0402FB2D RID: 195373
			PanelWeaponType,
			// Token: 0x0402FB2E RID: 195374
			IconWeaponType,
			// Token: 0x0402FB2F RID: 195375
			WeaponItem,
			// Token: 0x0402FB30 RID: 195376
			TxtWeaponName,
			// Token: 0x0402FB31 RID: 195377
			TxtGoalLevel,
			// Token: 0x0402FB32 RID: 195378
			PanelRight,
			// Token: 0x0402FB33 RID: 195379
			BtnJump,
			// Token: 0x0402FB34 RID: 195380
			BtnPerfectJump,
			// Token: 0x0402FB35 RID: 195381
			PanelSubLayout,
			// Token: 0x0402FB36 RID: 195382
			PanelSubItem,
			// Token: 0x0402FB37 RID: 195383
			PanelRecommendSwitch,
			// Token: 0x0402FB38 RID: 195384
			BtnCall
		}
	}
}
