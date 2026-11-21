using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F6C RID: 20332
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class TotalTopUpConfig : ConfigBase
	{
		// Token: 0x06033079 RID: 209017 RVA: 0x00E4D226 File Offset: 0x00E4B426
		public TotalTopUpReward? GetRewardConfigById(int rewardId)
		{
			return ConfigTotalTopUpRewardById.GetConfig(rewardId, true);
		}

		// Token: 0x0603307A RID: 209018 RVA: 0x00E4D22F File Offset: 0x00E4B42F
		public IReadOnlyList<TotalTopUpReward> GetAllRewardConfigs()
		{
			return ConfigTotalTopUpRewardAll.GetConfigList(true);
		}

		// Token: 0x0603307B RID: 209019 RVA: 0x00E4D238 File Offset: 0x00E4B438
		public string GetTotalUpScoreIcon(int activityId)
		{
			TotalTopUpViewConfig? config = ConfigTotalTopUpViewConfigByActivityId.GetConfig(activityId, true);
			if (config == null)
			{
				return null;
			}
			return config.Value.ScoreIcon;
		}

		// Token: 0x0603307C RID: 209020 RVA: 0x00E4D267 File Offset: 0x00E4B467
		public TotalTopUpRoleViewConfig? GetRoleViewConfigByRoleIdOrItemId(int roleIdOrItemId)
		{
			return ConfigTotalTopUpRoleViewConfigByItemId.GetConfig(roleIdOrItemId, true);
		}

		// Token: 0x0603307D RID: 209021 RVA: 0x00E4D270 File Offset: 0x00E4B470
		public TotalTopUpViewConfig? GetViewConfigByActivityId(int activityId)
		{
			return ConfigTotalTopUpViewConfigByActivityId.GetConfig(activityId, true);
		}

		// Token: 0x0603307E RID: 209022 RVA: 0x00E4D279 File Offset: 0x00E4B479
		public IReadOnlyList<TotalTopUpRotation> GetRotationListByActivityId(int activityId)
		{
			return ConfigTotalTopUpRotationByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x170063B2 RID: 25522
		// (get) Token: 0x0603307F RID: 209023 RVA: 0x00E4D282 File Offset: 0x00E4B482
		[Nullable(1)]
		public static TotalTopUpConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return TotalTopUpConfig._Instance;
			}
		}

		// Token: 0x06033080 RID: 209024 RVA: 0x00E4D289 File Offset: 0x00E4B489
		[NullableContext(1)]
		public static TotalTopUpConfig GetOrCreateInstance()
		{
			if (TotalTopUpConfig._Instance == null)
			{
				TotalTopUpConfig.CreateInstance();
			}
			return TotalTopUpConfig._Instance;
		}

		// Token: 0x06033081 RID: 209025 RVA: 0x00E4D29D File Offset: 0x00E4B49D
		public static bool CreateInstance()
		{
			if (TotalTopUpConfig._Instance != null)
			{
				return true;
			}
			TotalTopUpConfig._Instance = new TotalTopUpConfig();
			return true;
		}

		// Token: 0x06033082 RID: 209026 RVA: 0x00E4D2B3 File Offset: 0x00E4B4B3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033083 RID: 209027 RVA: 0x00E4D2B5 File Offset: 0x00E4B4B5
		public static void ResetStaticDefaultValue()
		{
			TotalTopUpConfig._Instance = null;
		}

		// Token: 0x06033084 RID: 209028 RVA: 0x00E4D2BD File Offset: 0x00E4B4BD
		static TotalTopUpConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TotalTopUpConfig.CreateStaticDefaultValue), new Action(TotalTopUpConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401B14F RID: 110927
		private static TotalTopUpConfig _Instance;
	}
}
