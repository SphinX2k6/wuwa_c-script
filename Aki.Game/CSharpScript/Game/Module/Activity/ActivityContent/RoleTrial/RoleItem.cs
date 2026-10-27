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
	// Token: 0x020061B4 RID: 25012
	[NullableContext(2)]
	[Nullable(0)]
	internal class RoleItem : GridProxyAbstract<int>
	{
		// Token: 0x0603F2D1 RID: 258769 RVA: 0x00F4383F File Offset: 0x00F41A3F
		[NullableContext(1)]
		public RoleItem(ActivityRoleTrialData activityData)
		{
			this.ActivityData = activityData;
		}

		// Token: 0x0603F2D2 RID: 258770 RVA: 0x00F43850 File Offset: 0x00F41A50
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

		// Token: 0x0603F2D3 RID: 258771 RVA: 0x00F439BC File Offset: 0x00F41BBC
		protected override void OnStart()
		{
			this.Toggle = base.GetExtendToggle(0);
			if (this.Toggle != null)
			{
				this.Toggle.CanExecuteChange.Unbind();
				this.Toggle.CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChangeInternal));
			}
		}

		// Token: 0x0603F2D4 RID: 258772 RVA: 0x00F43A0C File Offset: 0x00F41C0C
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

		// Token: 0x0603F2D5 RID: 258773 RVA: 0x00F43AD4 File Offset: 0x00F41CD4
		private void RefreshQualitySprite(int qualityId)
		{
			UUIItem sprite = base.GetSprite(1);
			QualityInfo? qualityConfig = ItemConfig.Instance.GetQualityConfig(qualityId);
			sprite.SetColor(FColor.FromHex(((qualityConfig != null) ? qualityConfig.GetValueOrDefault().RoleTrialQualityColor : null) ?? ""));
		}

		// Token: 0x0603F2D6 RID: 258774 RVA: 0x00F43B24 File Offset: 0x00F41D24
		private void RefreshRedDotAndNew()
		{
			ERoleTrialRewardState rewardStateByRoleId = this.ActivityData.GetRewardStateByRoleId(this.RoleId);
			base.GetItem(4).SetUIActive(rewardStateByRoleId == ERoleTrialRewardState.FinishedAndUnClaimed);
			base.GetItem(6).SetUIActive(rewardStateByRoleId == ERoleTrialRewardState.FinishedAndClaimed);
			bool isNewByRoleId = this.ActivityData.GetIsNewByRoleId(this.RoleId);
			base.GetItem(7).SetUIActive(isNewByRoleId && rewardStateByRoleId == ERoleTrialRewardState.InActive);
		}

		// Token: 0x0603F2D7 RID: 258775 RVA: 0x00F43B8B File Offset: 0x00F41D8B
		public void SetToggleState(bool bSelectOn, bool bFireEvent = false)
		{
			UUIExtendToggle toggle = this.Toggle;
			if (toggle == null)
			{
				return;
			}
			toggle.SetToggleState(bSelectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, bFireEvent, false, false);
		}

		// Token: 0x0603F2D8 RID: 258776 RVA: 0x00F43BA8 File Offset: 0x00F41DA8
		public bool IsToggleChecked()
		{
			UUIExtendToggle toggle = this.Toggle;
			return toggle != null && toggle.GetToggleState() == EToggleState.ETT_Checked;
		}

		// Token: 0x0603F2D9 RID: 258777 RVA: 0x00F43BBE File Offset: 0x00F41DBE
		public void MarkAsOld()
		{
			base.GetItem(7).SetUIActive(false);
		}

		// Token: 0x0603F2DA RID: 258778 RVA: 0x00F43BCD File Offset: 0x00F41DCD
		private bool CanToggleExecuteChangeInternal()
		{
			return this.CanToggleExecuteChange == null || this.CanToggleExecuteChange(this.RoleId);
		}

		// Token: 0x0603F2DB RID: 258779 RVA: 0x00F43BEA File Offset: 0x00F41DEA
		private void ToggleCallBackInternal(EToggleState _)
		{
			if (this.ToggleCallBack != null)
			{
				this.ToggleCallBack(this.RoleId, this.Toggle.GetToggleState() == EToggleState.ETT_Checked);
			}
		}

		// Token: 0x04020ED5 RID: 134869
		protected int RoleId;

		// Token: 0x04020ED6 RID: 134870
		protected UUIExtendToggle Toggle;

		// Token: 0x04020ED7 RID: 134871
		public Func<int, bool> CanToggleExecuteChange;

		// Token: 0x04020ED8 RID: 134872
		public Action<int, bool> ToggleCallBack;

		// Token: 0x04020ED9 RID: 134873
		private ActivityRoleTrialData ActivityData;

		// Token: 0x0200C404 RID: 50180
		[NullableContext(0)]
		private class ERoleComponents
		{
			// Token: 0x0403B296 RID: 242326
			public const int Toggle = 0;

			// Token: 0x0403B297 RID: 242327
			public const int SpriteNormal = 1;

			// Token: 0x0403B298 RID: 242328
			public const int SpriteHold = 2;

			// Token: 0x0403B299 RID: 242329
			public const int RoleIcon = 3;

			// Token: 0x0403B29A RID: 242330
			public const int RedDot = 4;

			// Token: 0x0403B29B RID: 242331
			public const int RoleIconMask = 5;

			// Token: 0x0403B29C RID: 242332
			public const int PanelDone = 6;

			// Token: 0x0403B29D RID: 242333
			public const int PanelNew = 7;
		}
	}
}
