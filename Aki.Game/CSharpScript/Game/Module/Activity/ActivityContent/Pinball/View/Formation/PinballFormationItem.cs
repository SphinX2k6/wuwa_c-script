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
	// Token: 0x020052DE RID: 21214
	public class PinballFormationItem : UiPanelBase
	{
		// Token: 0x06034CD8 RID: 216280 RVA: 0x00EC2C08 File Offset: 0x00EC0E08
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

		// Token: 0x06034CD9 RID: 216281 RVA: 0x00EC2E44 File Offset: 0x00EC1044
		protected override UniTask OnBeforeStartAsync()
		{
			PinballFormationItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballFormationItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034CDA RID: 216282 RVA: 0x00EC2E87 File Offset: 0x00EC1087
		public void RefreshItem(int roleId)
		{
			this.RoleId = roleId;
			base.GetItem(11).SetUIActive(this.RoleId <= 0);
			this.RefreshRoleSpine();
			this.RefreshRoleInfo();
			this.RefreshWeaponItem();
		}

		// Token: 0x06034CDB RID: 216283 RVA: 0x00EC2EBC File Offset: 0x00EC10BC
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

		// Token: 0x06034CDC RID: 216284 RVA: 0x00EC2F84 File Offset: 0x00EC1184
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

		// Token: 0x06034CDD RID: 216285 RVA: 0x00EC31A0 File Offset: 0x00EC13A0
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

		// Token: 0x06034CDE RID: 216286 RVA: 0x00EC32BE File Offset: 0x00EC14BE
		private void OnClickRoleBtn()
		{
			Action<int> onClickRoleBtnCallBack = this.OnClickRoleBtnCallBack;
			if (onClickRoleBtnCallBack == null)
			{
				return;
			}
			onClickRoleBtnCallBack(this.RoleId);
		}

		// Token: 0x06034CDF RID: 216287 RVA: 0x00EC32D8 File Offset: 0x00EC14D8
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

		// Token: 0x0401BF07 RID: 114439
		private int RoleId;

		// Token: 0x0401BF08 RID: 114440
		private bool IsTrail;

		// Token: 0x0401BF09 RID: 114441
		[Nullable(2)]
		private PinballRoleBdIconItem PinballRoleBdIconItem;

		// Token: 0x0401BF0A RID: 114442
		[Nullable(2)]
		public Action<int> OnClickRoleBtnCallBack;

		// Token: 0x0200AF66 RID: 44902
		private enum EComponent
		{
			// Token: 0x0403631C RID: 221980
			RoleBtn,
			// Token: 0x0403631D RID: 221981
			RoleItem,
			// Token: 0x0403631E RID: 221982
			ShadowSpine,
			// Token: 0x0403631F RID: 221983
			RoleSpine,
			// Token: 0x04036320 RID: 221984
			TrailRoleItem,
			// Token: 0x04036321 RID: 221985
			RoleInfoItem,
			// Token: 0x04036322 RID: 221986
			RoleNameText,
			// Token: 0x04036323 RID: 221987
			BdIconItem,
			// Token: 0x04036324 RID: 221988
			RoleLevelText,
			// Token: 0x04036325 RID: 221989
			WeaponBtn,
			// Token: 0x04036326 RID: 221990
			WeaponTexture,
			// Token: 0x04036327 RID: 221991
			EmptyItem,
			// Token: 0x04036328 RID: 221992
			ClassTexture
		}
	}
}
