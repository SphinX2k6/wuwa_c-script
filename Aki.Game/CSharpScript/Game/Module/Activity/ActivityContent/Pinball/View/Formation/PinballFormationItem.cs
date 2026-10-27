using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Weapon;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x02006360 RID: 25440
	public class PinballFormationItem : UiPanelBase
	{
		// Token: 0x06040017 RID: 262167 RVA: 0x00F7BCA8 File Offset: 0x00F79EA8
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickRoleBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickWeaponBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06040018 RID: 262168 RVA: 0x00F7BEE4 File Offset: 0x00F7A0E4
		protected override UniTask OnBeforeStartAsync()
		{
			PinballFormationItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballFormationItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040019 RID: 262169 RVA: 0x00F7BF27 File Offset: 0x00F7A127
		public void RefreshItem(int roleId)
		{
			this.RoleId = roleId;
			base.GetItem(11).SetUIActive(this.RoleId <= 0);
			this.RefreshRoleSpine();
			this.RefreshRoleInfo();
			this.RefreshWeaponItem();
		}

		// Token: 0x0604001A RID: 262170 RVA: 0x00F7BF5C File Offset: 0x00F7A15C
		private void RefreshRoleSpine()
		{
			if (this.RoleId <= 0)
			{
				base.GetItem(1).SetUIActive(false);
				return;
			}
			PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(this.RoleId);
			if (pinballRoleConfigById == null)
			{
				return;
			}
			UniTask.WhenAll(new List<UniTask>
			{
				base.SetSpineAssetByPath(pinballRoleConfigById.Value.SpineAtlasPath, pinballRoleConfigById.Value.SpineSkeletonDataPath, base.GetSpine(3)),
				base.SetSpineAssetByPath(pinballRoleConfigById.Value.SpineAtlasPath, pinballRoleConfigById.Value.SpineSkeletonDataPath, base.GetSpine(2))
			}.ToArray()).ContinueWith(delegate()
			{
				base.GetItem(1).SetUIActive(true);
				base.GetSpine(2).SetAnimation(0, "Idle_Fight", true);
				base.GetSpine(3).SetAnimation(0, "Idle_Fight", true);
			}).Forget();
		}

		// Token: 0x0604001B RID: 262171 RVA: 0x00F7C024 File Offset: 0x00F7A224
		private void RefreshRoleInfo()
		{
			if (this.RoleId <= 0)
			{
				base.GetItem(4).SetUIActive(false);
				base.GetItem(5).SetUIActive(false);
				base.GetTexture(12).SetUIActive(false);
				return;
			}
			PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(this.RoleId);
			if (pinballRoleConfigById == null)
			{
				return;
			}
			this.IsTrail = pinballRoleConfigById.Value.IsTrail;
			base.GetItem(4).SetUIActive(this.IsTrail);
			base.GetItem(5).SetUIActive(true);
			base.GetTexture(12).SetUIActive(true);
			RoleConfig instance = RoleConfig.Instance;
			RoleInfo? roleInfo = (instance != null) ? instance.GetRoleConfig(pinballRoleConfigById.Value.RoleId) : null;
			if (roleInfo == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(6), roleInfo.Value.Name, Array.Empty<object>());
			PinballRoleBdIconItem pinballRoleBdIconItem = this.PinballRoleBdIconItem;
			if (pinballRoleBdIconItem != null)
			{
				pinballRoleBdIconItem.RefreshItem(pinballRoleConfigById.Value.Bd);
			}
			if (!this.IsTrail)
			{
				base.GetText(8).SetText("Lv." + PinballModel.Instance.GetRoleLevel(this.RoleId).ToString(), true);
			}
			else
			{
				base.GetText(8).SetText("Lv." + pinballRoleConfigById.Value.InitLevelId.ToString(), true);
			}
			PinballClassConfig? pinballClassConfigById = PinballConfig.Instance.GetPinballClassConfigById(pinballRoleConfigById.Value.PinballClass(0));
			UTexture newTexture = ResourceSystem.Instance.Load<UTexture>(pinballClassConfigById.Value.HoverBigIcon, "js_undefined");
			UUITextureTransitionComponent uuitextureTransitionComponent = base.GetTexture(12).GetOwner().GetComponentByClass(UUITextureTransitionComponent.StaticClass()) as UUITextureTransitionComponent;
			uuitextureTransitionComponent.SetStateTexture(EUISelectableSelectionState.Highlighted, newTexture);
			uuitextureTransitionComponent.SetStateTexture(EUISelectableSelectionState.Pressed, newTexture);
			UTexture newTexture2 = ResourceSystem.Instance.Load<UTexture>(pinballClassConfigById.Value.BigIcon, "js_undefined");
			uuitextureTransitionComponent.SetStateTexture(EUISelectableSelectionState.Normal, newTexture2);
		}

		// Token: 0x0604001C RID: 262172 RVA: 0x00F7C240 File Offset: 0x00F7A440
		private void RefreshWeaponItem()
		{
			if (this.RoleId <= 0)
			{
				base.GetButton(9).RootUIComp.Get().SetUIActive(false);
				return;
			}
			if (this.IsTrail)
			{
				PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(this.RoleId);
				PinballWeaponConfig? pinballWeaponConfigById = PinballConfig.Instance.GetPinballWeaponConfigById(pinballRoleConfigById.Value.InitWeapon);
				base.GetButton(9).RootUIComp.Get().SetUIActive(true);
				base.SetTextureByPath(pinballWeaponConfigById.Value.Icon, base.GetTexture(10), null, null);
				return;
			}
			PinballWeaponData roleWeapon = PinballModel.Instance.GetRoleWeapon(this.RoleId);
			if (roleWeapon == null || roleWeapon.Id <= 0)
			{
				base.GetButton(9).RootUIComp.Get().SetUIActive(false);
				return;
			}
			base.GetButton(9).RootUIComp.Get().SetUIActive(true);
			base.SetTextureByPath(roleWeapon.Icon, base.GetTexture(10), null, null);
		}

		// Token: 0x0604001D RID: 262173 RVA: 0x00F7C35E File Offset: 0x00F7A55E
		private void OnClickRoleBtn()
		{
			Action<int> onClickRoleBtnCallBack = this.OnClickRoleBtnCallBack;
			if (onClickRoleBtnCallBack == null)
			{
				return;
			}
			onClickRoleBtnCallBack(this.RoleId);
		}

		// Token: 0x0604001E RID: 262174 RVA: 0x00F7C378 File Offset: 0x00F7A578
		private void OnClickWeaponBtn()
		{
			PinballActivityData activityData = PinballModel.Instance.ActivityData;
			if (activityData == null)
			{
				return;
			}
			if (this.IsTrail)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PinballFilterTrailClickTips", Array.Empty<object>());
				return;
			}
			PinballWeaponEquipViewData param = new PinballWeaponEquipViewData
			{
				ActivityData = activityData,
				RoleData = activityData.GetRoleData(this.RoleId)
			};
			UiManager.Instance.OpenView(EUiViewName.PinballWeaponEquipView, param, null);
		}

		// Token: 0x040215D8 RID: 136664
		private int RoleId;

		// Token: 0x040215D9 RID: 136665
		private bool IsTrail;

		// Token: 0x040215DA RID: 136666
		[Nullable(2)]
		private PinballRoleBdIconItem PinballRoleBdIconItem;

		// Token: 0x040215DB RID: 136667
		[Nullable(2)]
		public Action<int> OnClickRoleBtnCallBack;

		// Token: 0x0200C57F RID: 50559
		private enum EComponent
		{
			// Token: 0x0403B9BA RID: 244154
			RoleBtn,
			// Token: 0x0403B9BB RID: 244155
			RoleItem,
			// Token: 0x0403B9BC RID: 244156
			ShadowSpine,
			// Token: 0x0403B9BD RID: 244157
			RoleSpine,
			// Token: 0x0403B9BE RID: 244158
			TrailRoleItem,
			// Token: 0x0403B9BF RID: 244159
			RoleInfoItem,
			// Token: 0x0403B9C0 RID: 244160
			RoleNameText,
			// Token: 0x0403B9C1 RID: 244161
			BdIconItem,
			// Token: 0x0403B9C2 RID: 244162
			RoleLevelText,
			// Token: 0x0403B9C3 RID: 244163
			WeaponBtn,
			// Token: 0x0403B9C4 RID: 244164
			WeaponTexture,
			// Token: 0x0403B9C5 RID: 244165
			EmptyItem,
			// Token: 0x0403B9C6 RID: 244166
			ClassTexture
		}
	}
}
