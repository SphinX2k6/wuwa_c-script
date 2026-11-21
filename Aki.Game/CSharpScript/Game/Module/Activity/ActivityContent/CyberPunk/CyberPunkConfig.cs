using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020057FC RID: 22524
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class CyberPunkConfig : ConfigBase
	{
		// Token: 0x06037940 RID: 227648 RVA: 0x00F89380 File Offset: 0x00F87580
		public EdgeRunnerUnlock? GetEdgeRunnerUnlockConfigById(int id)
		{
			return ConfigEdgeRunnerUnlockById.GetConfig(id, true);
		}

		// Token: 0x06037941 RID: 227649 RVA: 0x00F89389 File Offset: 0x00F87589
		public IReadOnlyList<EdgeRunnerUnlock> GetAllEdgeRunnerUnlockConfigList()
		{
			return ConfigEdgeRunnerUnlockAll.GetConfigList(true) ?? new EdgeRunnerUnlock[0];
		}

		// Token: 0x06037942 RID: 227650 RVA: 0x00F8939B File Offset: 0x00F8759B
		public EdgeRunner? GetEdgeRunnerConfigById(int id)
		{
			return ConfigEdgeRunnerById.GetConfig(id, true);
		}

		// Token: 0x06037943 RID: 227651 RVA: 0x00F893A4 File Offset: 0x00F875A4
		public EdgeRunnerTrial? GetEdgeRunnerTrialConfigById(int id)
		{
			return ConfigEdgeRunnerTrialById.GetConfig(id, true);
		}

		// Token: 0x06037944 RID: 227652 RVA: 0x00F893AD File Offset: 0x00F875AD
		public IReadOnlyList<EdgeRunnerTrial> GetEdgeRunnerTrialConfigListByActivityId(int activityId)
		{
			return ConfigEdgeRunnerTrialByActivityId.GetConfigList(activityId, true) ?? new EdgeRunnerTrial[0];
		}

		// Token: 0x06037945 RID: 227653 RVA: 0x00F893C0 File Offset: 0x00F875C0
		public EdgeRunnerScoreReward? GetEdgeRunnerScoreRewardConfigById(int id)
		{
			return ConfigEdgeRunnerScoreRewardById.GetConfig(id, true);
		}

		// Token: 0x06037946 RID: 227654 RVA: 0x00F893C9 File Offset: 0x00F875C9
		public EdgeRunnerReward? GetEdgeRunnerRewardConfigById(int id)
		{
			return ConfigEdgeRunnerRewardById.GetConfig(id, true);
		}

		// Token: 0x06037947 RID: 227655 RVA: 0x00F893D2 File Offset: 0x00F875D2
		public IReadOnlyList<EdgeRunnerReward> GetAllEdgeRunnerRewardConfigList()
		{
			return ConfigEdgeRunnerRewardAll.GetConfigList(true) ?? new EdgeRunnerReward[0];
		}

		// Token: 0x06037948 RID: 227656 RVA: 0x00F893E4 File Offset: 0x00F875E4
		public EdgeRunnerLordGym? GetEdgeRunnerLordGymConfigById(int id)
		{
			return ConfigEdgeRunnerLordGymById.GetConfig(id, true);
		}

		// Token: 0x06037949 RID: 227657 RVA: 0x00F893ED File Offset: 0x00F875ED
		public IReadOnlyList<EdgeRunnerLordGym> GetEdgeRunnerLordGymConfigListByActivityId(int activityId)
		{
			return ConfigEdgeRunnerLordGymByActivityId.GetConfigList(activityId, true) ?? new EdgeRunnerLordGym[0];
		}

		// Token: 0x0603794A RID: 227658 RVA: 0x00F89400 File Offset: 0x00F87600
		public EdgeRunnerLordGym? GetStageConfig(int stageId)
		{
			EdgeRunnerLordGym? config = ConfigEdgeRunnerLordGymById.GetConfig(stageId, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Activity;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "[AdamSmasherConfig] 找不到关卡配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("stageId", stageId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return config;
		}

		// Token: 0x0603794B RID: 227659 RVA: 0x00F89458 File Offset: 0x00F87658
		[NullableContext(2)]
		public IReadOnlyList<EdgeRunnerLordGym> GetStageConfigList(int activityId)
		{
			return ConfigEdgeRunnerLordGymByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x0603794C RID: 227660 RVA: 0x00F89464 File Offset: 0x00F87664
		public int GetFirstRewardPreview(int stageId)
		{
			if (this.GetStageConfig(stageId) == null)
			{
				return 0;
			}
			EdgeRunnerLordGym? edgeRunnerLordGym;
			return edgeRunnerLordGym.GetValueOrDefault().RewardId;
		}

		// Token: 0x0603794D RID: 227661 RVA: 0x00F89493 File Offset: 0x00F87693
		[NullableContext(2)]
		public IReadOnlyList<EdgeRunnerTrial> GetTrialRoleListByTrialActivityId(int activityId)
		{
			return ConfigEdgeRunnerTrialByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x0603794E RID: 227662 RVA: 0x00F8949C File Offset: 0x00F8769C
		[NullableContext(2)]
		public IReadOnlyList<EdgeRunnerTrial> GetTrialRoleListByCyberPunkActivityId(int activityId)
		{
			return ConfigEdgeRunnerTrialByCyberPunkActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x17006B06 RID: 27398
		// (get) Token: 0x0603794F RID: 227663 RVA: 0x00F894A5 File Offset: 0x00F876A5
		public static CyberPunkConfig Instance
		{
			get
			{
				return CyberPunkConfig._Instance;
			}
		}

		// Token: 0x06037950 RID: 227664 RVA: 0x00F894AC File Offset: 0x00F876AC
		public static CyberPunkConfig GetOrCreateInstance()
		{
			if (CyberPunkConfig._Instance == null)
			{
				CyberPunkConfig.CreateInstance();
			}
			return CyberPunkConfig._Instance;
		}

		// Token: 0x06037951 RID: 227665 RVA: 0x00F894C0 File Offset: 0x00F876C0
		public static bool CreateInstance()
		{
			if (CyberPunkConfig._Instance != null)
			{
				return true;
			}
			CyberPunkConfig._Instance = new CyberPunkConfig();
			return true;
		}

		// Token: 0x06037952 RID: 227666 RVA: 0x00F894D6 File Offset: 0x00F876D6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06037953 RID: 227667 RVA: 0x00F894D8 File Offset: 0x00F876D8
		public static void ResetStaticDefaultValue()
		{
			CyberPunkConfig._Instance = null;
		}

		// Token: 0x06037954 RID: 227668 RVA: 0x00F894E0 File Offset: 0x00F876E0
		static CyberPunkConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CyberPunkConfig.CreateStaticDefaultValue), new Action(CyberPunkConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401D512 RID: 120082
		[Nullable(2)]
		private static CyberPunkConfig _Instance;
	}
}
