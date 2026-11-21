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
	// Token: 0x02005135 RID: 20789
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	internal class RoleItem : GridProxyAbstract<RoleItemData>
	{
		// Token: 0x06033FB9 RID: 212921 RVA: 0x00E8B690 File Offset: 0x00E89890
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
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
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.ToggleCallBackInternal));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06033FBA RID: 212922 RVA: 0x00E8B7DC File Offset: 0x00E899DC
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

		// Token: 0x06033FBB RID: 212923 RVA: 0x00E8B846 File Offset: 0x00E89A46
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.RefreshCommonActivityRedDot, new Action<int>(this.OnStateChange));
		}

		// Token: 0x06033FBC RID: 212924 RVA: 0x00E8B864 File Offset: 0x00E89A64
		private void OnStateChange(int id)
		{
			RoleItemData data = this.Data;
			int? num = (data != null) ? new int?(data.ActivityId) : null;
			if (!(id == num.GetValueOrDefault() & num != null))
			{
				return;
			}
			this.RefreshRedDot(this.Data);
			this.RefreshFinishItem(this.Data.RoleSkinTrialData.GetRewardStateById(this.Data.RoleId) == ChallengeState.Finish);
		}

		// Token: 0x06033FBD RID: 212925 RVA: 0x00E8B8D6 File Offset: 0x00E89AD6
		private bool CanToggleExecuteChangeInternal()
		{
			return this.CanToggleExecuteChange == null || this.CanToggleExecuteChange(this.RoleId);
		}

		// Token: 0x06033FBE RID: 212926 RVA: 0x00E8B8F3 File Offset: 0x00E89AF3
		private void ToggleCallBackInternal(EToggleState _)
		{
			if (this.ToggleCallBack != null)
			{
				this.ToggleCallBack(this.Data);
			}
		}

		// Token: 0x06033FBF RID: 212927 RVA: 0x00E8B910 File Offset: 0x00E89B10
		public override void Refresh(RoleItemData data, bool isSelected, int gridIndex)
		{
			this.RoleId = data.RoleId;
			this.Data = data;
			this.RefreshRoleIcon(this.RoleId);
			this.RefreshQualitySprite(this.RoleId);
			this.RefreshRedDot(data);
			this.RefreshToggleState(data.SelectState);
			this.RefreshFinishItem(data.FinishState);
		}

		// Token: 0x06033FC0 RID: 212928 RVA: 0x00E8B967 File Offset: 0x00E89B67
		private void RefreshToggleState(bool selectState)
		{
			base.GetExtendToggle(0).SetToggleState(selectState ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06033FC1 RID: 212929 RVA: 0x00E8B980 File Offset: 0x00E89B80
		private void RefreshFinishItem(bool finishState)
		{
			base.GetItem(6).SetUIActive(finishState);
		}

		// Token: 0x06033FC2 RID: 212930 RVA: 0x00E8B990 File Offset: 0x00E89B90
		private void RefreshRoleIcon(int roleId)
		{
			RoleSkinTrialInfo value = RoleSkinTrialConfig.Instance.GetRoleSkinTrialInfoById(roleId).Value;
			if (!string.IsNullOrEmpty(value.RoleIcon))
			{
				base.SetTextureShowUntilLoaded(value.RoleIcon, base.GetTexture(3), null);
				base.SetTextureShowUntilLoaded(value.RoleIcon, base.GetTexture(5), null);
			}
		}

		// Token: 0x06033FC3 RID: 212931 RVA: 0x00E8B9EC File Offset: 0x00E89BEC
		private void RefreshQualitySprite(int roleId)
		{
			RoleSkinTrialInfo? roleSkinTrialInfoById = RoleSkinTrialConfig.Instance.GetRoleSkinTrialInfoById(roleId);
			int qualityId = RoleModel.Instance.GetRoleDataById(roleSkinTrialInfoById.Value.TrialRoleId, true).GetRoleConfig().QualityId;
			UUIItem sprite = base.GetSprite(1);
			QualityInfo? qualityConfig = ItemConfig.Instance.GetQualityConfig(qualityId);
			sprite.SetColor(FColor.FromHex(((qualityConfig != null) ? qualityConfig.GetValueOrDefault().RoleTrialQualityColor : null) ?? ""));
		}

		// Token: 0x06033FC4 RID: 212932 RVA: 0x00E8BA70 File Offset: 0x00E89C70
		public void RefreshRedDot(RoleItemData data)
		{
			int activityId = data.ActivityId;
			RoleSkinTrialData roleSkinTrialData = ActivityModel.Instance.GetActivityById(activityId) as RoleSkinTrialData;
			int selectIdByIndex = roleSkinTrialData.GetSelectIdByIndex(data.Index);
			ChallengeState rewardStateById = roleSkinTrialData.GetRewardStateById(selectIdByIndex);
			base.GetItem(4).SetUIActive(rewardStateById == ChallengeState.WaitTakeReward);
		}

		// Token: 0x0401B815 RID: 112661
		protected int RoleId;

		// Token: 0x0401B816 RID: 112662
		private RoleItemData Data;

		// Token: 0x0401B817 RID: 112663
		protected UUIExtendToggle Toggle;

		// Token: 0x0401B818 RID: 112664
		public Func<int, bool> CanToggleExecuteChange;

		// Token: 0x0401B819 RID: 112665
		public Action<RoleItemData> ToggleCallBack;

		// Token: 0x0200ADEF RID: 44527
		[NullableContext(0)]
		private class ERoleComponents
		{
			// Token: 0x04035C1C RID: 220188
			public const int Toggle = 0;

			// Token: 0x04035C1D RID: 220189
			public const int SpriteNormal = 1;

			// Token: 0x04035C1E RID: 220190
			public const int SpriteHold = 2;

			// Token: 0x04035C1F RID: 220191
			public const int RoleIcon = 3;

			// Token: 0x04035C20 RID: 220192
			public const int RedDot = 4;

			// Token: 0x04035C21 RID: 220193
			public const int RoleIconMask = 5;

			// Token: 0x04035C22 RID: 220194
			public const int FinishItem = 6;
		}
	}
}
