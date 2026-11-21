using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoleTrial
{
	// Token: 0x02005132 RID: 20786
	[NullableContext(2)]
	[Nullable(0)]
	internal class RoleItem : GridProxyAbstract<int>
	{
		// Token: 0x06033F91 RID: 212881 RVA: 0x00E8A70B File Offset: 0x00E8890B
		[NullableContext(1)]
		public RoleItem(ActivityRoleTrialData activityData)
		{
			this.ActivityData = activityData;
		}

		// Token: 0x06033F92 RID: 212882 RVA: 0x00E8A71C File Offset: 0x00E8891C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
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
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleCallBackInternal));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033F93 RID: 212883 RVA: 0x00E8A888 File Offset: 0x00E88A88
		protected override void OnStart()
		{
			this.Toggle = base.GetExtendToggle(0);
			if (this.Toggle != null)
			{
				this.Toggle.CanExecuteChange.Unbind();
				this.Toggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChangeInternal));
			}
		}

		// Token: 0x06033F94 RID: 212884 RVA: 0x00E8A8D8 File Offset: 0x00E88AD8
		public override void Refresh(int roleId, bool isSelected, int gridIndex)
		{
			this.RoleId = roleId;
			RoleTrialInfo? roleTrialInfoConfigByRoleId = ActivityRoleTrialConfig.Instance.GetRoleTrialInfoConfigByRoleId(this.RoleId);
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleTrialInfoConfigByRoleId.Value.TrialRoleId, true);
			RoleTrialRoleConfig? roleTrialRoleConfigByRoleId = ActivityRoleTrialConfig.Instance.GetRoleTrialRoleConfigByRoleId(roleTrialInfoConfigByRoleId.Value.RoleId);
			if (!string.IsNullOrEmpty(roleTrialRoleConfigByRoleId.Value.RoleIcon))
			{
				base.SetTextureShowUntilLoaded(roleTrialRoleConfigByRoleId.Value.RoleIcon, base.GetTexture(3), null);
				base.SetTextureShowUntilLoaded(roleTrialRoleConfigByRoleId.Value.RoleIcon, base.GetTexture(5), null);
			}
			this.RefreshQualitySprite(roleDataById.GetRoleConfig().QualityId);
			this.RefreshRedDotAndNew();
		}

		// Token: 0x06033F95 RID: 212885 RVA: 0x00E8A9A0 File Offset: 0x00E88BA0
		private void RefreshQualitySprite(int qualityId)
		{
			UUIItem sprite = base.GetSprite(1);
			QualityInfo? qualityConfig = ItemConfig.Instance.GetQualityConfig(qualityId);
			sprite.SetColor(FColor.FromHex(((qualityConfig != null) ? qualityConfig.GetValueOrDefault().RoleTrialQualityColor : null) ?? ""));
		}

		// Token: 0x06033F96 RID: 212886 RVA: 0x00E8A9F0 File Offset: 0x00E88BF0
		private void RefreshRedDotAndNew()
		{
			ERoleTrialRewardState rewardStateByRoleId = this.ActivityData.GetRewardStateByRoleId(this.RoleId);
			base.GetItem(4).SetUIActive(rewardStateByRoleId == ERoleTrialRewardState.FinishedAndUnClaimed);
			base.GetItem(6).SetUIActive(rewardStateByRoleId == ERoleTrialRewardState.FinishedAndClaimed);
			bool isNewByRoleId = this.ActivityData.GetIsNewByRoleId(this.RoleId);
			base.GetItem(7).SetUIActive(isNewByRoleId && rewardStateByRoleId == ERoleTrialRewardState.InActive);
		}

		// Token: 0x06033F97 RID: 212887 RVA: 0x00E8AA57 File Offset: 0x00E88C57
		public void SetToggleState(bool bSelectOn, bool bFireEvent = false)
		{
			UUIExtendToggle toggle = this.Toggle;
			if (toggle == null)
			{
				return;
			}
			toggle.SetToggleState(bSelectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
		}

		// Token: 0x06033F98 RID: 212888 RVA: 0x00E8AA74 File Offset: 0x00E88C74
		public bool IsToggleChecked()
		{
			UUIExtendToggle toggle = this.Toggle;
			return toggle != null && toggle.GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x06033F99 RID: 212889 RVA: 0x00E8AA8A File Offset: 0x00E88C8A
		public void MarkAsOld()
		{
			base.GetItem(7).SetUIActive(false);
		}

		// Token: 0x06033F9A RID: 212890 RVA: 0x00E8AA99 File Offset: 0x00E88C99
		private bool CanToggleExecuteChangeInternal()
		{
			return this.CanToggleExecuteChange == null || this.CanToggleExecuteChange(this.RoleId);
		}

		// Token: 0x06033F9B RID: 212891 RVA: 0x00E8AAB6 File Offset: 0x00E88CB6
		private void ToggleCallBackInternal(EToggleState _)
		{
			if (this.ToggleCallBack != null)
			{
				this.ToggleCallBack(this.RoleId, this.Toggle.GetToggleState() == EToggleState.ETT_Checked);
			}
		}

		// Token: 0x0401B802 RID: 112642
		protected int RoleId;

		// Token: 0x0401B803 RID: 112643
		protected UUIExtendToggle Toggle;

		// Token: 0x0401B804 RID: 112644
		public Func<int, bool> CanToggleExecuteChange;

		// Token: 0x0401B805 RID: 112645
		public Action<int, bool> ToggleCallBack;

		// Token: 0x0401B806 RID: 112646
		private ActivityRoleTrialData ActivityData;

		// Token: 0x0200ADEB RID: 44523
		[NullableContext(0)]
		private class ERoleComponents
		{
			// Token: 0x04035BF7 RID: 220151
			public const int Toggle = 0;

			// Token: 0x04035BF8 RID: 220152
			public const int SpriteNormal = 1;

			// Token: 0x04035BF9 RID: 220153
			public const int SpriteHold = 2;

			// Token: 0x04035BFA RID: 220154
			public const int RoleIcon = 3;

			// Token: 0x04035BFB RID: 220155
			public const int RedDot = 4;

			// Token: 0x04035BFC RID: 220156
			public const int RoleIconMask = 5;

			// Token: 0x04035BFD RID: 220157
			public const int PanelDone = 6;

			// Token: 0x04035BFE RID: 220158
			public const int PanelNew = 7;
		}
	}
}
