using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.CyberPunk
{
	// Token: 0x020068AC RID: 26796
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class CyberPunkConfig : ConfigBase
	{
		// Token: 0x06042DE8 RID: 273896 RVA: 0x01047D70 File Offset: 0x01045F70
		public EdgeRunnerUnlock? GetEdgeRunnerUnlockConfigById(int id)
		{
			return ConfigEdgeRunnerUnlockById.GetConfig(id, true);
		}

		// Token: 0x06042DE9 RID: 273897 RVA: 0x01047D79 File Offset: 0x01045F79
		public IReadOnlyList<EdgeRunnerUnlock> GetAllEdgeRunnerUnlockConfigList()
		{
			return ConfigEdgeRunnerUnlockAll.GetConfigList(true) ?? new EdgeRunnerUnlock[0];
		}

		// Token: 0x06042DEA RID: 273898 RVA: 0x01047D8B File Offset: 0x01045F8B
		public EdgeRunner? GetEdgeRunnerConfigById(int id)
		{
			return ConfigEdgeRunnerById.GetConfig(id, true);
		}

		// Token: 0x06042DEB RID: 273899 RVA: 0x01047D94 File Offset: 0x01045F94
		public EdgeRunnerTrial? GetEdgeRunnerTrialConfigById(int id)
		{
			return ConfigEdgeRunnerTrialById.GetConfig(id, true);
		}

		// Token: 0x06042DEC RID: 273900 RVA: 0x01047D9D File Offset: 0x01045F9D
		public IReadOnlyList<EdgeRunnerTrial> GetEdgeRunnerTrialConfigListByActivityId(int activityId)
		{
			return ConfigEdgeRunnerTrialByActivityId.GetConfigList(activityId, true) ?? new EdgeRunnerTrial[0];
		}

		// Token: 0x06042DED RID: 273901 RVA: 0x01047DB0 File Offset: 0x01045FB0
		public EdgeRunnerScoreReward? GetEdgeRunnerScoreRewardConfigById(int id)
		{
			return ConfigEdgeRunnerScoreRewardById.GetConfig(id, true);
		}

		// Token: 0x06042DEE RID: 273902 RVA: 0x01047DB9 File Offset: 0x01045FB9
		public EdgeRunnerReward? GetEdgeRunnerRewardConfigById(int id)
		{
			return ConfigEdgeRunnerRewardById.GetConfig(id, true);
		}

		// Token: 0x06042DEF RID: 273903 RVA: 0x01047DC2 File Offset: 0x01045FC2
		public IReadOnlyList<EdgeRunnerReward> GetAllEdgeRunnerRewardConfigList()
		{
			return ConfigEdgeRunnerRewardAll.GetConfigList(true) ?? new EdgeRunnerReward[0];
		}

		// Token: 0x06042DF0 RID: 273904 RVA: 0x01047DD4 File Offset: 0x01045FD4
		public EdgeRunnerLordGym? GetEdgeRunnerLordGymConfigById(int id)
		{
			return ConfigEdgeRunnerLordGymById.GetConfig(id, true);
		}

		// Token: 0x06042DF1 RID: 273905 RVA: 0x01047DDD File Offset: 0x01045FDD
		public IReadOnlyList<EdgeRunnerLordGym> GetEdgeRunnerLordGymConfigListByActivityId(int activityId)
		{
			return ConfigEdgeRunnerLordGymByActivityId.GetConfigList(activityId, true) ?? new EdgeRunnerLordGym[0];
		}

		// Token: 0x06042DF2 RID: 273906 RVA: 0x01047DF0 File Offset: 0x01045FF0
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

		// Token: 0x06042DF3 RID: 273907 RVA: 0x01047E48 File Offset: 0x01046048
		[NullableContext(2)]
		public IReadOnlyList<EdgeRunnerLordGym> GetStageConfigList(int activityId)
		{
			return ConfigEdgeRunnerLordGymByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x06042DF4 RID: 273908 RVA: 0x01047E54 File Offset: 0x01046054
		public int GetFirstRewardPreview(int stageId)
		{
			if (this.GetStageConfig(stageId) == null)
			{
				return 0;
			}
			EdgeRunnerLordGym? edgeRunnerLordGym;
			return edgeRunnerLordGym.GetValueOrDefault().RewardId;
		}

		// Token: 0x06042DF5 RID: 273909 RVA: 0x01047E83 File Offset: 0x01046083
		[NullableContext(2)]
		public IReadOnlyList<EdgeRunnerTrial> GetTrialRoleListByTrialActivityId(int activityId)
		{
			return ConfigEdgeRunnerTrialByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x06042DF6 RID: 273910 RVA: 0x01047E8C File Offset: 0x0104608C
		[NullableContext(2)]
		public IReadOnlyList<EdgeRunnerTrial> GetTrialRoleListByCyberPunkActivityId(int activityId)
		{
			return ConfigEdgeRunnerTrialByCyberPunkActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x170097C6 RID: 38854
		// (get) Token: 0x06042DF7 RID: 273911 RVA: 0x01047E95 File Offset: 0x01046095
		public static CyberPunkConfig Instance
		{
			get
			{
				return CyberPunkConfig._Instance;
			}
		}

		// Token: 0x06042DF8 RID: 273912 RVA: 0x01047E9C File Offset: 0x0104609C
		public static CyberPunkConfig GetOrCreateInstance()
		{
			if (CyberPunkConfig._Instance == null)
			{
				CyberPunkConfig.CreateInstance();
			}
			return CyberPunkConfig._Instance;
		}

		// Token: 0x06042DF9 RID: 273913 RVA: 0x01047EB0 File Offset: 0x010460B0
		public static bool CreateInstance()
		{
			if (CyberPunkConfig._Instance != null)
			{
				return true;
			}
			CyberPunkConfig._Instance = new CyberPunkConfig();
			return true;
		}

		// Token: 0x06042DFA RID: 273914 RVA: 0x01047EC6 File Offset: 0x010460C6
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06042DFB RID: 273915 RVA: 0x01047EC8 File Offset: 0x010460C8
		public static void ResetStaticDefaultValue()
		{
			CyberPunkConfig._Instance = null;
		}

		// Token: 0x06042DFC RID: 273916 RVA: 0x01047ED0 File Offset: 0x010460D0
		static CyberPunkConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CyberPunkConfig.CreateStaticDefaultValue), new Action(CyberPunkConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04022CB6 RID: 142518
		[Nullable(2)]
		private static CyberPunkConfig _Instance;
	}
}
