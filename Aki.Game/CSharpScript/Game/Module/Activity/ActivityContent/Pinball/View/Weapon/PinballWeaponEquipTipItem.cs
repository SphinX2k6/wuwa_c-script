using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon
{
	// Token: 0x020062DF RID: 25311
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponEquipTipItem : UiPanelBase
	{
		// Token: 0x0603FAF6 RID: 260854 RVA: 0x00F68860 File Offset: 0x00F66A60
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603FAF7 RID: 260855 RVA: 0x00F68990 File Offset: 0x00F66B90
		protected override UniTask OnBeforeStartAsync()
		{
			PinballWeaponEquipTipItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballWeaponEquipTipItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FAF8 RID: 260856 RVA: 0x00F689D3 File Offset: 0x00F66BD3
		public void SetLockToggleShowState(bool bShow)
		{
			PinballWeaponTipsTopView weaponTopItem = this.WeaponTopItem;
			if (weaponTopItem == null)
			{
				return;
			}
			weaponTopItem.SetLockToggleShowState(bShow);
		}

		// Token: 0x0603FAF9 RID: 260857 RVA: 0x00F689E6 File Offset: 0x00F66BE6
		public void Refresh(IPinballWeaponEquipTipItemData data)
		{
			this.Data = data;
			this.RefreshUi();
		}

		// Token: 0x0603FAFA RID: 260858 RVA: 0x00F689F8 File Offset: 0x00F66BF8
		public void RefreshUi()
		{
			if (this.Data == null)
			{
				return;
			}
			PinballWeaponData weaponData = this.Data.WeaponData;
			PinballWeaponTipsTopView weaponTopItem = this.WeaponTopItem;
			if (weaponTopItem != null)
			{
				weaponTopItem.Refresh(weaponData);
			}
			PinballWeaponAttrView weaponAttrItem = this.WeaponAttrItem;
			if (weaponAttrItem != null)
			{
				weaponAttrItem.Refresh(weaponData);
			}
			this.RefreshRoleItem();
			this.RefreshStateItem();
		}

		// Token: 0x0603FAFB RID: 260859 RVA: 0x00F68A4A File Offset: 0x00F66C4A
		public void RefreshLockToggleShowState()
		{
			PinballWeaponTipsTopView weaponTopItem = this.WeaponTopItem;
			if (weaponTopItem == null)
			{
				return;
			}
			weaponTopItem.RefreshLockToggleShowState();
		}

		// Token: 0x0603FAFC RID: 260860 RVA: 0x00F68A5C File Offset: 0x00F66C5C
		public void RefreshRoleItem()
		{
			if (this.Data == null)
			{
				base.GetItem(4).SetUIActive(false);
				return;
			}
			int roleId = this.Data.WeaponData.RoleId;
			if (roleId <= 0)
			{
				base.GetItem(4).SetUIActive(false);
				return;
			}
			PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(roleId);
			if (pinballRoleConfigById == null)
			{
				base.GetItem(4).SetUIActive(false);
				return;
			}
			base.GetItem(4).SetUIActive(true);
			base.TrySetTextureByPath(pinballRoleConfigById.Value.SmallIcon, base.GetTexture(5), null, null);
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew(PinballModel.Instance.GetRoleNameByPinballRoleConfig(pinballRoleConfigById.Value), null);
			LguiUtil.Instance.TrySetLocalTextNew(base.GetText(6), "Pinball_Weapon_ArmedInfo2", new <>z__ReadOnlySingleElementList<object>(localTextNew));
		}

		// Token: 0x0603FAFD RID: 260861 RVA: 0x00F68B30 File Offset: 0x00F66D30
		public void RefreshStateItem()
		{
			if (this.Data == null)
			{
				return;
			}
			EPinballWeaponEquipState state = this.Data.State;
			ButtonItem equipButtonItem = this.EquipButtonItem;
			if (equipButtonItem != null)
			{
				equipButtonItem.SetUiActive(this.Data.ShowButton);
			}
			if (this.Data.ShowButton)
			{
				string textId;
				switch (state)
				{
				case EPinballWeaponEquipState.CanEquip:
					textId = "Pinball_Weapon_SelectInfo05";
					break;
				case EPinballWeaponEquipState.IsEquipped:
					textId = "Pinball_Weapon_ArmedInfo1";
					break;
				case EPinballWeaponEquipState.CanNotEquip:
					textId = "Pinball_Weapon_SelectInfo06";
					break;
				default:
					textId = "";
					break;
				}
				ButtonItem equipButtonItem2 = this.EquipButtonItem;
				if (equipButtonItem2 != null)
				{
					equipButtonItem2.SetLocalTextNew(textId, Array.Empty<object>());
				}
				ButtonItem equipButtonItem3 = this.EquipButtonItem;
				if (equipButtonItem3 == null)
				{
					return;
				}
				equipButtonItem3.SetEnableClick(state == EPinballWeaponEquipState.CanEquip);
			}
		}

		// Token: 0x0603FAFE RID: 260862 RVA: 0x00F68BDE File Offset: 0x00F66DDE
		private void OnClickEquipButton()
		{
			if (this.Data == null)
			{
				return;
			}
			Action confirmDelegate = this.Data.ConfirmDelegate;
			if (confirmDelegate == null)
			{
				return;
			}
			confirmDelegate();
		}

		// Token: 0x0402144B RID: 136267
		private IPinballWeaponEquipTipItemData Data;

		// Token: 0x0402144C RID: 136268
		private PinballWeaponTipsTopView WeaponTopItem;

		// Token: 0x0402144D RID: 136269
		private PinballWeaponAttrView WeaponAttrItem;

		// Token: 0x0402144E RID: 136270
		private ButtonItem EquipButtonItem;

		// Token: 0x0200C4CD RID: 50381
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B62C RID: 243244
			WeaponTopItem,
			// Token: 0x0403B62D RID: 243245
			WeaponAttrRootItem,
			// Token: 0x0403B62E RID: 243246
			CurEquipItem,
			// Token: 0x0403B62F RID: 243247
			EquipButtonItem,
			// Token: 0x0403B630 RID: 243248
			RoleItem,
			// Token: 0x0403B631 RID: 243249
			RoleTexture,
			// Token: 0x0403B632 RID: 243250
			RoleNameText,
			// Token: 0x0403B633 RID: 243251
			DebugIdText
		}
	}
}
