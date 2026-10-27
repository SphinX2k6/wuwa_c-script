using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoleSkinReward
{
	// Token: 0x020061BA RID: 25018
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityRoleSkinRewardData : ActivityBaseData
	{
		// Token: 0x0603F31D RID: 258845 RVA: 0x00F44D3C File Offset: 0x00F42F3C
		protected override void PhraseEx(ActivityData data)
		{
			SkinRewardActivityData skinRewardActivityData = data.SkinRewardActivityData;
			foreach (SkinRewardActivityRewardInfo skinRewardActivityRewardInfo in ((skinRewardActivityData != null) ? skinRewardActivityData.RewardInfos : null))
			{
				this.SkinRewardData[skinRewardActivityRewardInfo.ConfigId] = skinRewardActivityRewardInfo.State;
			}
		}

		// Token: 0x0603F31E RID: 258846 RVA: 0x00F44DA8 File Offset: 0x00F42FA8
		public void UpdateSkinRewardState(int configId, SkinRewardActivityRewardState state)
		{
			this.SkinRewardData[configId] = state;
		}

		// Token: 0x0603F31F RID: 258847 RVA: 0x00F44DB8 File Offset: 0x00F42FB8
		public SkinRewardActivityRewardState? GetSkinRewardState(int configId)
		{
			SkinRewardActivityRewardState value;
			if (this.SkinRewardData.TryGetValue(configId, out value))
			{
				return new SkinRewardActivityRewardState?(value);
			}
			return null;
		}

		// Token: 0x0603F320 RID: 258848 RVA: 0x00F44DE8 File Offset: 0x00F42FE8
		public bool CheckTransitionCondition(int configId)
		{
			SkinRewardActivityRewardState skinRewardActivityRewardState;
			return this.SkinRewardData.TryGetValue(configId, out skinRewardActivityRewardState) && skinRewardActivityRewardState == SkinRewardActivityRewardState.InitState;
		}

		// Token: 0x0603F321 RID: 258849 RVA: 0x00F44E0C File Offset: 0x00F4300C
		public bool CheckRewarded(int configId)
		{
			SkinRewardActivityRewardState skinRewardActivityRewardState;
			return this.SkinRewardData.TryGetValue(configId, out skinRewardActivityRewardState) && skinRewardActivityRewardState == SkinRewardActivityRewardState.TaskRewarded;
		}

		// Token: 0x0603F322 RID: 258850 RVA: 0x00F44E30 File Offset: 0x00F43030
		protected override bool GetExDataFinishShowState()
		{
			int activityId = ActivityRoleSkinRewardController.Instance.ActivityId;
			SkinRewardActivityReward? activityConfig = ActivityRoleSkinRewardConfig.Instance.GetActivityConfig(activityId);
			SkinRewardActivityRewardState skinRewardActivityRewardState;
			return this.SkinRewardData.TryGetValue(activityConfig.Value.Id, out skinRewardActivityRewardState) && skinRewardActivityRewardState == SkinRewardActivityRewardState.TaskRewarded;
		}

		// Token: 0x0603F323 RID: 258851 RVA: 0x00F44E78 File Offset: 0x00F43078
		public override bool GetExDataRedPointShowState()
		{
			int activityId = ActivityRoleSkinRewardController.Instance.ActivityId;
			SkinRewardActivityReward? activityConfig = ActivityRoleSkinRewardConfig.Instance.GetActivityConfig(activityId);
			SkinRewardActivityRewardState skinRewardActivityRewardState;
			return this.SkinRewardData.TryGetValue(activityConfig.Value.Id, out skinRewardActivityRewardState) && skinRewardActivityRewardState == SkinRewardActivityRewardState.TaskComplete;
		}

		// Token: 0x04020EEE RID: 134894
		private readonly Dictionary<int, SkinRewardActivityRewardState> SkinRewardData = new Dictionary<int, SkinRewardActivityRewardState>();
	}
}
