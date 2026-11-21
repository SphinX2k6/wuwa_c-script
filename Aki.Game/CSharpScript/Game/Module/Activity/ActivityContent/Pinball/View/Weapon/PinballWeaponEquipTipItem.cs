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
	// Token: 0x0200525D RID: 21085
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballWeaponEquipTipItem : UiPanelBase
	{
		// Token: 0x060347B7 RID: 214967 RVA: 0x00EAF7BC File Offset: 0x00EAD9BC
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

		// Token: 0x060347B8 RID: 214968 RVA: 0x00EAF8EC File Offset: 0x00EADAEC
		protected override UniTask OnBeforeStartAsync()
		{
			PinballWeaponEquipTipItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballWeaponEquipTipItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060347B9 RID: 214969 RVA: 0x00EAF92F File Offset: 0x00EADB2F
		public void SetLockToggleShowState(bool bShow)
		{
			PinballWeaponTipsTopView weaponTopItem = this.WeaponTopItem;
			if (weaponTopItem == null)
			{
				return;
			}
			weaponTopItem.SetLockToggleShowState(bShow);
		}

		// Token: 0x060347BA RID: 214970 RVA: 0x00EAF942 File Offset: 0x00EADB42
		public void Refresh(IPinballWeaponEquipTipItemData data)
		{
			this.Data = data;
			this.RefreshUi();
		}

		// Token: 0x060347BB RID: 214971 RVA: 0x00EAF954 File Offset: 0x00EADB54
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

		// Token: 0x060347BC RID: 214972 RVA: 0x00EAF9A6 File Offset: 0x00EADBA6
		public void RefreshLockToggleShowState()
		{
			PinballWeaponTipsTopView weaponTopItem = this.WeaponTopItem;
			if (weaponTopItem == null)
			{
				return;
			}
			weaponTopItem.RefreshLockToggleShowState();
		}

		// Token: 0x060347BD RID: 214973 RVA: 0x00EAF9B8 File Offset: 0x00EADBB8
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

		// Token: 0x060347BE RID: 214974 RVA: 0x00EAFA8C File Offset: 0x00EADC8C
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

		// Token: 0x060347BF RID: 214975 RVA: 0x00EAFB3A File Offset: 0x00EADD3A
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

		// Token: 0x0401BD7A RID: 114042
		private IPinballWeaponEquipTipItemData Data;

		// Token: 0x0401BD7B RID: 114043
		private PinballWeaponTipsTopView WeaponTopItem;

		// Token: 0x0401BD7C RID: 114044
		private PinballWeaponAttrView WeaponAttrItem;

		// Token: 0x0401BD7D RID: 114045
		private ButtonItem EquipButtonItem;

		// Token: 0x0200AEB4 RID: 44724
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04035F8E RID: 221070
			WeaponTopItem,
			// Token: 0x04035F8F RID: 221071
			WeaponAttrRootItem,
			// Token: 0x04035F90 RID: 221072
			CurEquipItem,
			// Token: 0x04035F91 RID: 221073
			EquipButtonItem,
			// Token: 0x04035F92 RID: 221074
			RoleItem,
			// Token: 0x04035F93 RID: 221075
			RoleTexture,
			// Token: 0x04035F94 RID: 221076
			RoleNameText,
			// Token: 0x04035F95 RID: 221077
			DebugIdText
		}
	}
}
