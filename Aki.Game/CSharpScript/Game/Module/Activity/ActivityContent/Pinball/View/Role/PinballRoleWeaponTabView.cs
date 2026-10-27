using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x0200631A RID: 25370
	public class PinballRoleWeaponTabView : UiTabViewBase, IPinballRoleTabViewRoleChange, IPinballRoleTabViewRefresh
	{
		// Token: 0x0603FD44 RID: 261444 RVA: 0x00F712C8 File Offset: 0x00F6F4C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 11;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickWeaponButton));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnClickConfirmButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FD45 RID: 261445 RVA: 0x00F714C0 File Offset: 0x00F6F6C0
		protected override UniTask OnBeforeStartAsync()
		{
			PinballRoleWeaponTabView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballRoleWeaponTabView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FD46 RID: 261446 RVA: 0x00F71504 File Offset: 0x00F6F704
		protected override void OnBeforeShow()
		{
			this.ViewProxy = (IPinballRoleWeaponTabViewProxy)this.ExtraParams;
			this.RefreshView();
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x0603FD47 RID: 261447 RVA: 0x00F71548 File Offset: 0x00F6F748
		public void RefreshView()
		{
			IPinballRoleWeaponTabViewProxy viewProxy = this.ViewProxy;
			PinballRoleDataBase pinballRoleDataBase = (viewProxy != null) ? viewProxy.GetRoleData() : null;
			if (pinballRoleDataBase == null)
			{
				return;
			}
			PinballWeaponData weaponData = pinballRoleDataBase.GetWeaponData();
			bool flag = weaponData != null;
			base.GetItem(0).SetUIActive(flag);
			base.GetItem(8).SetUIActive(!flag);
			base.GetItem(9).SetUIActive(!flag);
			base.GetButton(7).RootUIComp.Get().SetUIActive(flag);
			if (flag)
			{
				PinballWeaponConfig? pinballWeaponConfigById = PinballConfig.Instance.GetPinballWeaponConfigById(weaponData.Id);
				PinballWeaponType? pinballWeaponTypeConfigById = PinballConfig.Instance.GetPinballWeaponTypeConfigById(pinballWeaponConfigById.Value.Type);
				base.SetTextureByPath(pinballWeaponTypeConfigById.Value.Icon2, base.GetTexture(1), null, null);
				base.SetTextureByPath(pinballWeaponConfigById.Value.Icon, base.GetTexture(5), null, null);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(2), pinballWeaponConfigById.Value.Name, Array.Empty<object>());
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), pinballWeaponTypeConfigById.Value.Name, Array.Empty<object>());
				PinballWeaponAttrView attrView = this.AttrView;
				if (attrView != null)
				{
					attrView.Refresh(weaponData);
				}
			}
			else
			{
				PinballLevelConfig? pinballLevelConfigByRoleId = PinballConfig.Instance.GetPinballLevelConfigByRoleId(pinballRoleDataBase.GetId());
				if (pinballLevelConfigByRoleId == null)
				{
					return;
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(10), "Pinball_Character_lockedinfo", new <>z__ReadOnlySingleElementList<object>(ConfigMultiTextLang.GetLocalTextNew(pinballLevelConfigByRoleId.Value.Name, null)));
			}
			ButtonItem confirmButtonItem = this.ConfirmButtonItem;
			if (confirmButtonItem == null)
			{
				return;
			}
			confirmButtonItem.SetRedDotVisible(PinballModel.Instance.GetWeaponRedDot(this.ViewProxy.GetActivityData().Id, this.ViewProxy.GetRoleData().GetId()));
		}

		// Token: 0x0603FD48 RID: 261448 RVA: 0x00F7172C File Offset: 0x00F6F92C
		public void RefreshByRoleChange()
		{
			this.RefreshView();
		}

		// Token: 0x0603FD49 RID: 261449 RVA: 0x00F71734 File Offset: 0x00F6F934
		private void OnClickWeaponButton()
		{
			this.OpenWeaponEquipView();
		}

		// Token: 0x0603FD4A RID: 261450 RVA: 0x00F7173C File Offset: 0x00F6F93C
		private void OnClickConfirmButton()
		{
			this.OpenWeaponEquipView();
		}

		// Token: 0x0603FD4B RID: 261451 RVA: 0x00F71744 File Offset: 0x00F6F944
		public void OpenWeaponEquipView()
		{
			IPinballRoleWeaponTabViewProxy viewProxy = this.ViewProxy;
			PinballRoleDataBase pinballRoleDataBase = (viewProxy != null) ? viewProxy.GetRoleData() : null;
			IPinballRoleWeaponTabViewProxy viewProxy2 = this.ViewProxy;
			PinballActivityData pinballActivityData = (viewProxy2 != null) ? viewProxy2.GetActivityData() : null;
			if (pinballRoleDataBase == null || pinballActivityData == null)
			{
				return;
			}
			PinballWeaponEquipViewData param = new PinballWeaponEquipViewData
			{
				ActivityData = pinballActivityData,
				RoleData = pinballRoleDataBase
			};
			UiManager.Instance.OpenView(EUiViewName.PinballWeaponEquipView, param, null);
		}

		// Token: 0x040214E5 RID: 136421
		[Nullable(2)]
		protected IPinballRoleWeaponTabViewProxy ViewProxy;

		// Token: 0x040214E6 RID: 136422
		[Nullable(2)]
		protected PinballWeaponAttrView AttrView;

		// Token: 0x040214E7 RID: 136423
		[Nullable(2)]
		protected ButtonItem ConfirmButtonItem;

		// Token: 0x0200C517 RID: 50455
		private enum EComponent
		{
			// Token: 0x0403B7A8 RID: 243624
			ActiveRootItem,
			// Token: 0x0403B7A9 RID: 243625
			TypeIconTexture,
			// Token: 0x0403B7AA RID: 243626
			WeaponNameText,
			// Token: 0x0403B7AB RID: 243627
			WeaponTypeText,
			// Token: 0x0403B7AC RID: 243628
			WeaponButton,
			// Token: 0x0403B7AD RID: 243629
			WeaponIconTexture,
			// Token: 0x0403B7AE RID: 243630
			WeaponAttrRootItem,
			// Token: 0x0403B7AF RID: 243631
			ConfirmButton,
			// Token: 0x0403B7B0 RID: 243632
			LockItem,
			// Token: 0x0403B7B1 RID: 243633
			LockConditionItem,
			// Token: 0x0403B7B2 RID: 243634
			LockText
		}
	}
}
