using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005F85 RID: 24453
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class TotalTopUpConfig : ConfigBase
	{
		// Token: 0x0603E0DF RID: 254175 RVA: 0x00EFB556 File Offset: 0x00EF9756
		public TotalTopUpReward? GetRewardConfigById(int rewardId)
		{
			return ConfigTotalTopUpRewardById.GetConfig(rewardId, true);
		}

		// Token: 0x0603E0E0 RID: 254176 RVA: 0x00EFB55F File Offset: 0x00EF975F
		public IReadOnlyList<TotalTopUpReward> GetAllRewardConfigs()
		{
			return ConfigTotalTopUpRewardAll.GetConfigList(true);
		}

		// Token: 0x0603E0E1 RID: 254177 RVA: 0x00EFB568 File Offset: 0x00EF9768
		public string GetTotalUpScoreIcon(int activityId)
		{
			TotalTopUpViewConfig? config = ConfigTotalTopUpViewConfigByActivityId.GetConfig(activityId, true);
			if (config == null)
			{
				return null;
			}
			return config.Value.ScoreIcon;
		}

		// Token: 0x0603E0E2 RID: 254178 RVA: 0x00EFB597 File Offset: 0x00EF9797
		public TotalTopUpRoleViewConfig? GetRoleViewConfigByRoleIdOrItemId(int roleIdOrItemId)
		{
			return ConfigTotalTopUpRoleViewConfigByItemId.GetConfig(roleIdOrItemId, true);
		}

		// Token: 0x0603E0E3 RID: 254179 RVA: 0x00EFB5A0 File Offset: 0x00EF97A0
		public TotalTopUpViewConfig? GetViewConfigByActivityId(int activityId)
		{
			return ConfigTotalTopUpViewConfigByActivityId.GetConfig(activityId, true);
		}

		// Token: 0x0603E0E4 RID: 254180 RVA: 0x00EFB5A9 File Offset: 0x00EF97A9
		public IReadOnlyList<TotalTopUpRotation> GetRotationListByActivityId(int activityId)
		{
			return ConfigTotalTopUpRotationByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x17008FE0 RID: 36832
		// (get) Token: 0x0603E0E5 RID: 254181 RVA: 0x00EFB5B2 File Offset: 0x00EF97B2
		[Nullable(1)]
		public static TotalTopUpConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return TotalTopUpConfig._Instance;
			}
		}

		// Token: 0x0603E0E6 RID: 254182 RVA: 0x00EFB5B9 File Offset: 0x00EF97B9
		[NullableContext(1)]
		public static TotalTopUpConfig GetOrCreateInstance()
		{
			if (TotalTopUpConfig._Instance == null)
			{
				TotalTopUpConfig.CreateInstance();
			}
			return TotalTopUpConfig._Instance;
		}

		// Token: 0x0603E0E7 RID: 254183 RVA: 0x00EFB5CD File Offset: 0x00EF97CD
		public static bool CreateInstance()
		{
			if (TotalTopUpConfig._Instance != null)
			{
				return true;
			}
			TotalTopUpConfig._Instance = new TotalTopUpConfig();
			return true;
		}

		// Token: 0x0603E0E8 RID: 254184 RVA: 0x00EFB5E3 File Offset: 0x00EF97E3
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E0E9 RID: 254185 RVA: 0x00EFB5E5 File Offset: 0x00EF97E5
		public static void ResetStaticDefaultValue()
		{
			TotalTopUpConfig._Instance = null;
		}

		// Token: 0x0603E0EA RID: 254186 RVA: 0x00EFB5ED File Offset: 0x00EF97ED
		static TotalTopUpConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TotalTopUpConfig.CreateStaticDefaultValue), new Action(TotalTopUpConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0402067D RID: 132733
		private static TotalTopUpConfig _Instance;
	}
}
