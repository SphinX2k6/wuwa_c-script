using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoleSkinTrial
{
	// Token: 0x020061B7 RID: 25015
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class RoleItem : GridProxyAbstract<RoleItemData>
	{
		// Token: 0x0603F2F9 RID: 258809 RVA: 0x00F447A4 File Offset: 0x00F429A4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleCallBackInternal));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603F2FA RID: 258810 RVA: 0x00F448D0 File Offset: 0x00F42AD0
		protected override void OnStart()
		{
			this.Toggle = base.GetExtendToggle(0);
			if (this.Toggle != null)
			{
				this.Toggle.CanExecuteChange.Unbind();
				this.Toggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChangeInternal));
			}
			EventSystem.Instance.Add<int>(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnStateChange));
		}

		// Token: 0x0603F2FB RID: 258811 RVA: 0x00F4493A File Offset: 0x00F42B3A
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnStateChange));
		}

		// Token: 0x0603F2FC RID: 258812 RVA: 0x00F44958 File Offset: 0x00F42B58
		private void OnStateChange(int id)
		{
			RoleItemData data = this.Data;
			int? num = (data != null) ? new int?(data.ActivityId) : null;
			if (!(id == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			this.RefreshRedDot(this.Data);
		}

		// Token: 0x0603F2FD RID: 258813 RVA: 0x00F449A6 File Offset: 0x00F42BA6
		private bool CanToggleExecuteChangeInternal()
		{
			return this.CanToggleExecuteChange == null || this.CanToggleExecuteChange(this.RoleId);
		}

		// Token: 0x0603F2FE RID: 258814 RVA: 0x00F449C3 File Offset: 0x00F42BC3
		private void ToggleCallBackInternal(EToggleState _)
		{
			if (this.ToggleCallBack != null)
			{
				this.ToggleCallBack(this.Data);
			}
		}

		// Token: 0x0603F2FF RID: 258815 RVA: 0x00F449DE File Offset: 0x00F42BDE
		public override void Refresh(RoleItemData data, bool isSelected, int gridIndex)
		{
			this.RoleId = data.RoleId;
			this.Data = data;
			this.RefreshRoleIcon(this.RoleId);
			this.RefreshQualitySprite(this.RoleId);
			this.RefreshRedDot(data);
			this.RefreshToggleState(data.SelectState);
		}

		// Token: 0x0603F300 RID: 258816 RVA: 0x00F44A1E File Offset: 0x00F42C1E
		private void RefreshToggleState(bool selectState)
		{
			base.GetExtendToggle(0).SetToggleState(selectState ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603F301 RID: 258817 RVA: 0x00F44A38 File Offset: 0x00F42C38
		private void RefreshRoleIcon(int roleId)
		{
			RoleSkinTrialInfo value = RoleSkinTrialConfig.Instance.GetRoleSkinTrialInfoById(roleId).Value;
			if (!string.IsNullOrEmpty(value.RoleIcon))
			{
				base.SetTextureShowUntilLoaded(value.RoleIcon, base.GetTexture(3), null);
				base.SetTextureShowUntilLoaded(value.RoleIcon, base.GetTexture(5), null);
			}
		}

		// Token: 0x0603F302 RID: 258818 RVA: 0x00F44A94 File Offset: 0x00F42C94
		private void RefreshQualitySprite(int roleId)
		{
			RoleSkinTrialInfo? roleSkinTrialInfoById = RoleSkinTrialConfig.Instance.GetRoleSkinTrialInfoById(roleId);
			int qualityId = RoleModel.Instance.GetRoleDataById(roleSkinTrialInfoById.Value.TrialRoleId, true).GetRoleConfig().QualityId;
			UUIItem sprite = base.GetSprite(1);
			QualityInfo? qualityConfig = ItemConfig.Instance.GetQualityConfig(qualityId);
			sprite.SetColor(FColor.FromHex(((qualityConfig != null) ? qualityConfig.GetValueOrDefault().RoleTrialQualityColor : null) ?? ""));
		}

		// Token: 0x0603F303 RID: 258819 RVA: 0x00F44B18 File Offset: 0x00F42D18
		public void RefreshRedDot(RoleItemData data)
		{
			int activityId = data.ActivityId;
			RoleSkinTrialData roleSkinTrialData = ActivityModel.Instance.GetActivityById(activityId) as RoleSkinTrialData;
			int selectIdByIndex = roleSkinTrialData.GetSelectIdByIndex(data.Index);
			ChallengeState rewardStateById = roleSkinTrialData.GetRewardStateById(selectIdByIndex);
			base.GetItem(4).SetUIActive(rewardStateById == ChallengeState.WaitTakeReward);
		}

		// Token: 0x04020EE6 RID: 134886
		protected int RoleId;

		// Token: 0x04020EE7 RID: 134887
		private RoleItemData Data;

		// Token: 0x04020EE8 RID: 134888
		protected UUIExtendToggle Toggle;

		// Token: 0x04020EE9 RID: 134889
		public Func<int, bool> CanToggleExecuteChange;

		// Token: 0x04020EEA RID: 134890
		public Action<RoleItemData> ToggleCallBack;

		// Token: 0x0200C408 RID: 50184
		[NullableContext(0)]
		private class ERoleComponents
		{
			// Token: 0x0403B2BB RID: 242363
			public const int Toggle = 0;

			// Token: 0x0403B2BC RID: 242364
			public const int SpriteNormal = 1;

			// Token: 0x0403B2BD RID: 242365
			public const int SpriteHold = 2;

			// Token: 0x0403B2BE RID: 242366
			public const int RoleIcon = 3;

			// Token: 0x0403B2BF RID: 242367
			public const int RedDot = 4;

			// Token: 0x0403B2C0 RID: 242368
			public const int RoleIconMask = 5;
		}
	}
}
