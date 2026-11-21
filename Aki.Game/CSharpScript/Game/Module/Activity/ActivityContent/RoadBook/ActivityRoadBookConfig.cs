using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x0200513B RID: 20795
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityRoadBookConfig : ConfigBase
	{
		// Token: 0x06033FFB RID: 212987 RVA: 0x00E8C7F4 File Offset: 0x00E8A9F4
		public RoadBookConfig? GetActivityConfig(int activityId)
		{
			RoadBookConfig? config = ConfigRoadBookConfigByActivityId.GetConfig(activityId, true);
			if (config != null)
			{
				return new RoadBookConfig?(config.Value);
			}
			return null;
		}

		// Token: 0x06033FFC RID: 212988 RVA: 0x00E8C828 File Offset: 0x00E8AA28
		public RoadBookLevelExp? GetLevelExpConfig(int id)
		{
			RoadBookLevelExp? config = ConfigRoadBookLevelExpById.GetConfig(id, true);
			if (config != null)
			{
				return new RoadBookLevelExp?(config.Value);
			}
			return null;
		}

		// Token: 0x06033FFD RID: 212989 RVA: 0x00E8C85C File Offset: 0x00E8AA5C
		public IReadOnlyList<RoadBookLevelExp> GetAllLevelExpConfig(int activityId)
		{
			return ConfigRoadBookLevelExpByActivityId.GetConfigList(activityId, true) ?? new List<RoadBookLevelExp>();
		}

		// Token: 0x06033FFE RID: 212990 RVA: 0x00E8C870 File Offset: 0x00E8AA70
		public RoadBookTask? GetRoadBookTaskConfig(int taskId)
		{
			RoadBookTask? config = ConfigRoadBookTaskByTaskId.GetConfig(taskId, true);
			if (config != null)
			{
				return new RoadBookTask?(config.Value);
			}
			return null;
		}

		// Token: 0x06033FFF RID: 212991 RVA: 0x00E8C8A4 File Offset: 0x00E8AAA4
		public IReadOnlyList<RoadBookTask> GetAllRoadBookTaskConfig(int activityId)
		{
			return ConfigRoadBookTaskByActivityId.GetConfigList(activityId, true) ?? new List<RoadBookTask>();
		}

		// Token: 0x06034000 RID: 212992 RVA: 0x00E8C8B8 File Offset: 0x00E8AAB8
		public RoadBookArea? GetAreaConfig(int id)
		{
			RoadBookArea? config = ConfigRoadBookAreaById.GetConfig(id, true);
			if (config != null)
			{
				return new RoadBookArea?(config.Value);
			}
			return null;
		}

		// Token: 0x06034001 RID: 212993 RVA: 0x00E8C8EC File Offset: 0x00E8AAEC
		public IReadOnlyList<RoadBookArea> GetAllAreaConfig(int activityId)
		{
			return ConfigRoadBookAreaByActivityId.GetConfigList(activityId, true) ?? new List<RoadBookArea>();
		}

		// Token: 0x06034002 RID: 212994 RVA: 0x00E8C900 File Offset: 0x00E8AB00
		public RoadBookPhantomGain? GetPhantomConfig(int id)
		{
			RoadBookPhantomGain? config = ConfigRoadBookPhantomGainById.GetConfig(id, true);
			if (config != null)
			{
				return new RoadBookPhantomGain?(config.Value);
			}
			return null;
		}

		// Token: 0x06034003 RID: 212995 RVA: 0x00E8C934 File Offset: 0x00E8AB34
		public IReadOnlyList<RoadBookPhantomGain> GetAllPhantomConfig(int activityId)
		{
			return ConfigRoadBookPhantomGainByActivityId.GetConfigList(activityId, true) ?? new List<RoadBookPhantomGain>();
		}

		// Token: 0x06034004 RID: 212996 RVA: 0x00E8C946 File Offset: 0x00E8AB46
		public IReadOnlyList<MotorcycleChallenge> GetAllMotorChallengeConfig()
		{
			return ConfigMotorcycleChallengeAll.GetConfigList(true) ?? new List<MotorcycleChallenge>();
		}

		// Token: 0x06034005 RID: 212997 RVA: 0x00E8C958 File Offset: 0x00E8AB58
		public MotorcycleChallenge? GetMotorChallengeConfig(int id)
		{
			MotorcycleChallenge? config = ConfigMotorcycleChallengeById.GetConfig(id, true);
			if (config != null)
			{
				return new MotorcycleChallenge?(config.Value);
			}
			return null;
		}

		// Token: 0x1700657A RID: 25978
		// (get) Token: 0x06034006 RID: 212998 RVA: 0x00E8C98C File Offset: 0x00E8AB8C
		public static ActivityRoadBookConfig Instance
		{
			get
			{
				return ActivityRoadBookConfig._Instance;
			}
		}

		// Token: 0x06034007 RID: 212999 RVA: 0x00E8C993 File Offset: 0x00E8AB93
		public static ActivityRoadBookConfig GetOrCreateInstance()
		{
			if (ActivityRoadBookConfig._Instance == null)
			{
				ActivityRoadBookConfig.CreateInstance();
			}
			return ActivityRoadBookConfig._Instance;
		}

		// Token: 0x06034008 RID: 213000 RVA: 0x00E8C9A7 File Offset: 0x00E8ABA7
		public static bool CreateInstance()
		{
			if (ActivityRoadBookConfig._Instance != null)
			{
				return true;
			}
			ActivityRoadBookConfig._Instance = new ActivityRoadBookConfig();
			return true;
		}

		// Token: 0x06034009 RID: 213001 RVA: 0x00E8C9BD File Offset: 0x00E8ABBD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603400A RID: 213002 RVA: 0x00E8C9BF File Offset: 0x00E8ABBF
		public static void ResetStaticDefaultValue()
		{
			ActivityRoadBookConfig._Instance = null;
		}

		// Token: 0x0603400B RID: 213003 RVA: 0x00E8C9C7 File Offset: 0x00E8ABC7
		static ActivityRoadBookConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoadBookConfig.CreateStaticDefaultValue), new Action(ActivityRoadBookConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401B839 RID: 112697
		[Nullable(2)]
		private static ActivityRoadBookConfig _Instance;
	}
}
