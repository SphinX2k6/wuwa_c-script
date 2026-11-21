using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x020051DD RID: 20957
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityRealmBetweenConfig : ConfigBase
	{
		// Token: 0x06034371 RID: 213873 RVA: 0x00E9BE94 File Offset: 0x00E9A094
		public RealmBetweenConfig? GetActivityConfig(int activityId)
		{
			RealmBetweenConfig? config = ConfigRealmBetweenConfigByActivityId.GetConfig(activityId, true);
			if (config != null)
			{
				return new RealmBetweenConfig?(config.Value);
			}
			return null;
		}

		// Token: 0x06034372 RID: 213874 RVA: 0x00E9BEC8 File Offset: 0x00E9A0C8
		public RealmBetweenLevelExp? GetLevelExpConfig(int id)
		{
			RealmBetweenLevelExp? config = ConfigRealmBetweenLevelExpById.GetConfig(id, true);
			if (config != null)
			{
				return new RealmBetweenLevelExp?(config.Value);
			}
			return null;
		}

		// Token: 0x06034373 RID: 213875 RVA: 0x00E9BEFC File Offset: 0x00E9A0FC
		public IReadOnlyList<RealmBetweenLevelExp> GetAllLevelExpConfig(int activityId)
		{
			return ConfigRealmBetweenLevelExpByActivityId.GetConfigList(activityId, true) ?? new List<RealmBetweenLevelExp>();
		}

		// Token: 0x06034374 RID: 213876 RVA: 0x00E9BF10 File Offset: 0x00E9A110
		public RealmBetweenTask? GetRealmBetweenTaskConfig(int taskId)
		{
			RealmBetweenTask? config = ConfigRealmBetweenTaskByTaskId.GetConfig(taskId, true);
			if (config != null)
			{
				return new RealmBetweenTask?(config.Value);
			}
			return null;
		}

		// Token: 0x06034375 RID: 213877 RVA: 0x00E9BF44 File Offset: 0x00E9A144
		public IReadOnlyList<RealmBetweenTask> GetAllRealmBetweenTaskConfig(int activityId)
		{
			return ConfigRealmBetweenTaskByActivityId.GetConfigList(activityId, true) ?? new List<RealmBetweenTask>();
		}

		// Token: 0x06034376 RID: 213878 RVA: 0x00E9BF58 File Offset: 0x00E9A158
		public RealmBetweenArea? GetAreaConfig(int id)
		{
			RealmBetweenArea? config = ConfigRealmBetweenAreaById.GetConfig(id, true);
			if (config != null)
			{
				return new RealmBetweenArea?(config.Value);
			}
			return null;
		}

		// Token: 0x06034377 RID: 213879 RVA: 0x00E9BF8C File Offset: 0x00E9A18C
		public IReadOnlyList<RealmBetweenArea> GetAllAreaConfig(int activityId)
		{
			return ConfigRealmBetweenAreaByActivityId.GetConfigList(activityId, true) ?? new List<RealmBetweenArea>();
		}

		// Token: 0x06034378 RID: 213880 RVA: 0x00E9BFA0 File Offset: 0x00E9A1A0
		public RealmBetweenPhantomGain? GetPhantomConfig(int id)
		{
			RealmBetweenPhantomGain? config = ConfigRealmBetweenPhantomGainById.GetConfig(id, true);
			if (config != null)
			{
				return new RealmBetweenPhantomGain?(config.Value);
			}
			return null;
		}

		// Token: 0x06034379 RID: 213881 RVA: 0x00E9BFD4 File Offset: 0x00E9A1D4
		public IReadOnlyList<RealmBetweenPhantomGain> GetAllPhantomConfig(int activityId)
		{
			return ConfigRealmBetweenPhantomGainByActivityId.GetConfigList(activityId, true) ?? new List<RealmBetweenPhantomGain>();
		}

		// Token: 0x0603437A RID: 213882 RVA: 0x00E9BFE6 File Offset: 0x00E9A1E6
		public IReadOnlyList<RealmBetweenChallenge> GetAllMotorChallengeConfig()
		{
			return ConfigRealmBetweenChallengeAll.GetConfigList(true) ?? new List<RealmBetweenChallenge>();
		}

		// Token: 0x0603437B RID: 213883 RVA: 0x00E9BFF8 File Offset: 0x00E9A1F8
		public RealmBetweenChallenge? GetMotorChallengeConfig(int id)
		{
			RealmBetweenChallenge? config = ConfigRealmBetweenChallengeById.GetConfig(id, true);
			if (config != null)
			{
				return new RealmBetweenChallenge?(config.Value);
			}
			return null;
		}

		// Token: 0x170065BD RID: 26045
		// (get) Token: 0x0603437C RID: 213884 RVA: 0x00E9C02C File Offset: 0x00E9A22C
		public static ActivityRealmBetweenConfig Instance
		{
			get
			{
				return ActivityRealmBetweenConfig._Instance;
			}
		}

		// Token: 0x0603437D RID: 213885 RVA: 0x00E9C033 File Offset: 0x00E9A233
		public static ActivityRealmBetweenConfig GetOrCreateInstance()
		{
			if (ActivityRealmBetweenConfig._Instance == null)
			{
				ActivityRealmBetweenConfig.CreateInstance();
			}
			return ActivityRealmBetweenConfig._Instance;
		}

		// Token: 0x0603437E RID: 213886 RVA: 0x00E9C047 File Offset: 0x00E9A247
		public static bool CreateInstance()
		{
			if (ActivityRealmBetweenConfig._Instance != null)
			{
				return true;
			}
			ActivityRealmBetweenConfig._Instance = new ActivityRealmBetweenConfig();
			return true;
		}

		// Token: 0x0603437F RID: 213887 RVA: 0x00E9C05D File Offset: 0x00E9A25D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034380 RID: 213888 RVA: 0x00E9C05F File Offset: 0x00E9A25F
		public static void ResetStaticDefaultValue()
		{
			ActivityRealmBetweenConfig._Instance = null;
		}

		// Token: 0x06034381 RID: 213889 RVA: 0x00E9C067 File Offset: 0x00E9A267
		static ActivityRealmBetweenConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRealmBetweenConfig.CreateStaticDefaultValue), new Action(ActivityRealmBetweenConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401BB43 RID: 113475
		[Nullable(2)]
		private static ActivityRealmBetweenConfig _Instance;
	}
}
