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
	// Token: 0x02005298 RID: 21144
	public class PinballRoleWeaponTabView : UiTabViewBase, IPinballRoleTabViewRoleChange, IPinballRoleTabViewRefresh
	{
		// Token: 0x06034A05 RID: 215557 RVA: 0x00EB8224 File Offset: 0x00EB6424
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

		// Token: 0x06034A06 RID: 215558 RVA: 0x00EB841C File Offset: 0x00EB661C
		protected override UniTask OnBeforeStartAsync()
		{
			PinballRoleWeaponTabView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballRoleWeaponTabView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034A07 RID: 215559 RVA: 0x00EB8460 File Offset: 0x00EB6660
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

		// Token: 0x06034A08 RID: 215560 RVA: 0x00EB84A4 File Offset: 0x00EB66A4
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

		// Token: 0x06034A09 RID: 215561 RVA: 0x00EB8688 File Offset: 0x00EB6888
		public void RefreshByRoleChange()
		{
			this.RefreshView();
		}

		// Token: 0x06034A0A RID: 215562 RVA: 0x00EB8690 File Offset: 0x00EB6890
		private void OnClickWeaponButton()
		{
			this.OpenWeaponEquipView();
		}

		// Token: 0x06034A0B RID: 215563 RVA: 0x00EB8698 File Offset: 0x00EB6898
		private void OnClickConfirmButton()
		{
			this.OpenWeaponEquipView();
		}

		// Token: 0x06034A0C RID: 215564 RVA: 0x00EB86A0 File Offset: 0x00EB68A0
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

		// Token: 0x0401BE14 RID: 114196
		[Nullable(2)]
		protected IPinballRoleWeaponTabViewProxy ViewProxy;

		// Token: 0x0401BE15 RID: 114197
		[Nullable(2)]
		protected PinballWeaponAttrView AttrView;

		// Token: 0x0401BE16 RID: 114198
		[Nullable(2)]
		protected ButtonItem ConfirmButtonItem;

		// Token: 0x0200AEFE RID: 44798
		private enum EComponent
		{
			// Token: 0x0403610A RID: 221450
			ActiveRootItem,
			// Token: 0x0403610B RID: 221451
			TypeIconTexture,
			// Token: 0x0403610C RID: 221452
			WeaponNameText,
			// Token: 0x0403610D RID: 221453
			WeaponTypeText,
			// Token: 0x0403610E RID: 221454
			WeaponButton,
			// Token: 0x0403610F RID: 221455
			WeaponIconTexture,
			// Token: 0x04036110 RID: 221456
			WeaponAttrRootItem,
			// Token: 0x04036111 RID: 221457
			ConfirmButton,
			// Token: 0x04036112 RID: 221458
			LockItem,
			// Token: 0x04036113 RID: 221459
			LockConditionItem,
			// Token: 0x04036114 RID: 221460
			LockText
		}
	}
}
