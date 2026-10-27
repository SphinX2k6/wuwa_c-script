using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RealmBetween
{
	// Token: 0x0200625F RID: 25183
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityRealmBetweenConfig : ConfigBase
	{
		// Token: 0x0603F6B0 RID: 259760 RVA: 0x00F54F38 File Offset: 0x00F53138
		public RealmBetweenConfig? GetActivityConfig(int activityId)
		{
			RealmBetweenConfig? config = ConfigRealmBetweenConfigByActivityId.GetConfig(activityId, true);
			if (config != null)
			{
				return new RealmBetweenConfig?(config.Value);
			}
			return null;
		}

		// Token: 0x0603F6B1 RID: 259761 RVA: 0x00F54F6C File Offset: 0x00F5316C
		public RealmBetweenLevelExp? GetLevelExpConfig(int id)
		{
			RealmBetweenLevelExp? config = ConfigRealmBetweenLevelExpById.GetConfig(id, true);
			if (config != null)
			{
				return new RealmBetweenLevelExp?(config.Value);
			}
			return null;
		}

		// Token: 0x0603F6B2 RID: 259762 RVA: 0x00F54FA0 File Offset: 0x00F531A0
		public IReadOnlyList<RealmBetweenLevelExp> GetAllLevelExpConfig(int activityId)
		{
			return ConfigRealmBetweenLevelExpByActivityId.GetConfigList(activityId, true) ?? new List<RealmBetweenLevelExp>();
		}

		// Token: 0x0603F6B3 RID: 259763 RVA: 0x00F54FB4 File Offset: 0x00F531B4
		public RealmBetweenTask? GetRealmBetweenTaskConfig(int taskId)
		{
			RealmBetweenTask? config = ConfigRealmBetweenTaskByTaskId.GetConfig(taskId, true);
			if (config != null)
			{
				return new RealmBetweenTask?(config.Value);
			}
			return null;
		}

		// Token: 0x0603F6B4 RID: 259764 RVA: 0x00F54FE8 File Offset: 0x00F531E8
		public IReadOnlyList<RealmBetweenTask> GetAllRealmBetweenTaskConfig(int activityId)
		{
			return ConfigRealmBetweenTaskByActivityId.GetConfigList(activityId, true) ?? new List<RealmBetweenTask>();
		}

		// Token: 0x0603F6B5 RID: 259765 RVA: 0x00F54FFC File Offset: 0x00F531FC
		public RealmBetweenArea? GetAreaConfig(int id)
		{
			RealmBetweenArea? config = ConfigRealmBetweenAreaById.GetConfig(id, true);
			if (config != null)
			{
				return new RealmBetweenArea?(config.Value);
			}
			return null;
		}

		// Token: 0x0603F6B6 RID: 259766 RVA: 0x00F55030 File Offset: 0x00F53230
		public IReadOnlyList<RealmBetweenArea> GetAllAreaConfig(int activityId)
		{
			return ConfigRealmBetweenAreaByActivityId.GetConfigList(activityId, true) ?? new List<RealmBetweenArea>();
		}

		// Token: 0x0603F6B7 RID: 259767 RVA: 0x00F55044 File Offset: 0x00F53244
		public RealmBetweenPhantomGain? GetPhantomConfig(int id)
		{
			RealmBetweenPhantomGain? config = ConfigRealmBetweenPhantomGainById.GetConfig(id, true);
			if (config != null)
			{
				return new RealmBetweenPhantomGain?(config.Value);
			}
			return null;
		}

		// Token: 0x0603F6B8 RID: 259768 RVA: 0x00F55078 File Offset: 0x00F53278
		public IReadOnlyList<RealmBetweenPhantomGain> GetAllPhantomConfig(int activityId)
		{
			return ConfigRealmBetweenPhantomGainByActivityId.GetConfigList(activityId, true) ?? new List<RealmBetweenPhantomGain>();
		}

		// Token: 0x0603F6B9 RID: 259769 RVA: 0x00F5508A File Offset: 0x00F5328A
		public IReadOnlyList<RealmBetweenChallenge> GetAllMotorChallengeConfig()
		{
			return ConfigRealmBetweenChallengeAll.GetConfigList(true) ?? new List<RealmBetweenChallenge>();
		}

		// Token: 0x0603F6BA RID: 259770 RVA: 0x00F5509C File Offset: 0x00F5329C
		public RealmBetweenChallenge? GetMotorChallengeConfig(int id)
		{
			RealmBetweenChallenge? config = ConfigRealmBetweenChallengeById.GetConfig(id, true);
			if (config != null)
			{
				return new RealmBetweenChallenge?(config.Value);
			}
			return null;
		}

		// Token: 0x1700925B RID: 37467
		// (get) Token: 0x0603F6BB RID: 259771 RVA: 0x00F550D0 File Offset: 0x00F532D0
		public static ActivityRealmBetweenConfig Instance
		{
			get
			{
				return ActivityRealmBetweenConfig._Instance;
			}
		}

		// Token: 0x0603F6BC RID: 259772 RVA: 0x00F550D7 File Offset: 0x00F532D7
		public static ActivityRealmBetweenConfig GetOrCreateInstance()
		{
			if (ActivityRealmBetweenConfig._Instance == null)
			{
				ActivityRealmBetweenConfig.CreateInstance();
			}
			return ActivityRealmBetweenConfig._Instance;
		}

		// Token: 0x0603F6BD RID: 259773 RVA: 0x00F550EB File Offset: 0x00F532EB
		public static bool CreateInstance()
		{
			if (ActivityRealmBetweenConfig._Instance != null)
			{
				return true;
			}
			ActivityRealmBetweenConfig._Instance = new ActivityRealmBetweenConfig();
			return true;
		}

		// Token: 0x0603F6BE RID: 259774 RVA: 0x00F55101 File Offset: 0x00F53301
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603F6BF RID: 259775 RVA: 0x00F55103 File Offset: 0x00F53303
		public static void ResetStaticDefaultValue()
		{
			ActivityRealmBetweenConfig._Instance = null;
		}

		// Token: 0x0603F6C0 RID: 259776 RVA: 0x00F5510B File Offset: 0x00F5330B
		static ActivityRealmBetweenConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRealmBetweenConfig.CreateStaticDefaultValue), new Action(ActivityRealmBetweenConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04021214 RID: 135700
		[Nullable(2)]
		private static ActivityRealmBetweenConfig _Instance;
	}
}
