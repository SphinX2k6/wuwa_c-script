using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoleSkinReward
{
	// Token: 0x02005138 RID: 20792
	[NullableContext(1)]
	[Nullable(0)]
	public class ActivityRoleSkinRewardData : ActivityBaseData
	{
		// Token: 0x06033FDE RID: 212958 RVA: 0x00E8BC94 File Offset: 0x00E89E94
		protected override void PhraseEx(ActivityData data)
		{
			SkinRewardActivityData skinRewardActivityData = data.SkinRewardActivityData;
			foreach (SkinRewardActivityRewardInfo skinRewardActivityRewardInfo in ((skinRewardActivityData != null) ? skinRewardActivityData.RewardInfos : null))
			{
				this.SkinRewardData[skinRewardActivityRewardInfo.ConfigId] = skinRewardActivityRewardInfo.State;
			}
		}

		// Token: 0x06033FDF RID: 212959 RVA: 0x00E8BD00 File Offset: 0x00E89F00
		public void UpdateSkinRewardState(int configId, SkinRewardActivityRewardState state)
		{
			this.SkinRewardData[configId] = state;
		}

		// Token: 0x06033FE0 RID: 212960 RVA: 0x00E8BD10 File Offset: 0x00E89F10
		public SkinRewardActivityRewardState? GetSkinRewardState(int configId)
		{
			SkinRewardActivityRewardState value;
			if (this.SkinRewardData.TryGetValue(configId, out value))
			{
				return new SkinRewardActivityRewardState?(value);
			}
			return null;
		}

		// Token: 0x06033FE1 RID: 212961 RVA: 0x00E8BD40 File Offset: 0x00E89F40
		public bool CheckTransitionCondition(int configId)
		{
			SkinRewardActivityRewardState skinRewardActivityRewardState;
			return this.SkinRewardData.TryGetValue(configId, out skinRewardActivityRewardState) && skinRewardActivityRewardState == SkinRewardActivityRewardState.InitState;
		}

		// Token: 0x06033FE2 RID: 212962 RVA: 0x00E8BD64 File Offset: 0x00E89F64
		public bool CheckRewarded(int configId)
		{
			SkinRewardActivityRewardState skinRewardActivityRewardState;
			return this.SkinRewardData.TryGetValue(configId, out skinRewardActivityRewardState) && skinRewardActivityRewardState == SkinRewardActivityRewardState.TaskRewarded;
		}

		// Token: 0x06033FE3 RID: 212963 RVA: 0x00E8BD88 File Offset: 0x00E89F88
		protected override bool GetExDataFinishShowState()
		{
			int activityId = ActivityRoleSkinRewardController.Instance.ActivityId;
			SkinRewardActivityReward? activityConfig = ActivityRoleSkinRewardConfig.Instance.GetActivityConfig(activityId);
			SkinRewardActivityRewardState skinRewardActivityRewardState;
			return this.SkinRewardData.TryGetValue(activityConfig.Value.Id, out skinRewardActivityRewardState) && skinRewardActivityRewardState == SkinRewardActivityRewardState.TaskRewarded;
		}

		// Token: 0x06033FE4 RID: 212964 RVA: 0x00E8BDD0 File Offset: 0x00E89FD0
		public override bool GetExDataRedPointShowState()
		{
			int activityId = ActivityRoleSkinRewardController.Instance.ActivityId;
			SkinRewardActivityReward? activityConfig = ActivityRoleSkinRewardConfig.Instance.GetActivityConfig(activityId);
			SkinRewardActivityRewardState skinRewardActivityRewardState;
			return this.SkinRewardData.TryGetValue(activityConfig.Value.Id, out skinRewardActivityRewardState) && skinRewardActivityRewardState == SkinRewardActivityRewardState.TaskComplete;
		}

		// Token: 0x0401B81D RID: 112669
		private readonly Dictionary<int, SkinRewardActivityRewardState> SkinRewardData = new Dictionary<int, SkinRewardActivityRewardState>();
	}
}
