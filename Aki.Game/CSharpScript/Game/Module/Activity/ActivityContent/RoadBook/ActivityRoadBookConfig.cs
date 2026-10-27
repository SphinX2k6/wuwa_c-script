using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061BD RID: 25021
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityRoadBookConfig : ConfigBase
	{
		// Token: 0x0603F33A RID: 258874 RVA: 0x00F4589C File Offset: 0x00F43A9C
		public RoadBookConfig? GetActivityConfig(int activityId)
		{
			RoadBookConfig? config = ConfigRoadBookConfigByActivityId.GetConfig(activityId, true);
			if (config != null)
			{
				return new RoadBookConfig?(config.Value);
			}
			return null;
		}

		// Token: 0x0603F33B RID: 258875 RVA: 0x00F458D0 File Offset: 0x00F43AD0
		public RoadBookLevelExp? GetLevelExpConfig(int id)
		{
			RoadBookLevelExp? config = ConfigRoadBookLevelExpById.GetConfig(id, true);
			if (config != null)
			{
				return new RoadBookLevelExp?(config.Value);
			}
			return null;
		}

		// Token: 0x0603F33C RID: 258876 RVA: 0x00F45904 File Offset: 0x00F43B04
		public IReadOnlyList<RoadBookLevelExp> GetAllLevelExpConfig(int activityId)
		{
			return ConfigRoadBookLevelExpByActivityId.GetConfigList(activityId, true) ?? new List<RoadBookLevelExp>();
		}

		// Token: 0x0603F33D RID: 258877 RVA: 0x00F45918 File Offset: 0x00F43B18
		public RoadBookTask? GetRoadBookTaskConfig(int taskId)
		{
			RoadBookTask? config = ConfigRoadBookTaskByTaskId.GetConfig(taskId, true);
			if (config != null)
			{
				return new RoadBookTask?(config.Value);
			}
			return null;
		}

		// Token: 0x0603F33E RID: 258878 RVA: 0x00F4594C File Offset: 0x00F43B4C
		public IReadOnlyList<RoadBookTask> GetAllRoadBookTaskConfig(int activityId)
		{
			return ConfigRoadBookTaskByActivityId.GetConfigList(activityId, true) ?? new List<RoadBookTask>();
		}

		// Token: 0x0603F33F RID: 258879 RVA: 0x00F45960 File Offset: 0x00F43B60
		public RoadBookArea? GetAreaConfig(int id)
		{
			RoadBookArea? config = ConfigRoadBookAreaById.GetConfig(id, true);
			if (config != null)
			{
				return new RoadBookArea?(config.Value);
			}
			return null;
		}

		// Token: 0x0603F340 RID: 258880 RVA: 0x00F45994 File Offset: 0x00F43B94
		public IReadOnlyList<RoadBookArea> GetAllAreaConfig(int activityId)
		{
			return ConfigRoadBookAreaByActivityId.GetConfigList(activityId, true) ?? new List<RoadBookArea>();
		}

		// Token: 0x0603F341 RID: 258881 RVA: 0x00F459A8 File Offset: 0x00F43BA8
		public RoadBookPhantomGain? GetPhantomConfig(int id)
		{
			RoadBookPhantomGain? config = ConfigRoadBookPhantomGainById.GetConfig(id, true);
			if (config != null)
			{
				return new RoadBookPhantomGain?(config.Value);
			}
			return null;
		}

		// Token: 0x0603F342 RID: 258882 RVA: 0x00F459DC File Offset: 0x00F43BDC
		public IReadOnlyList<RoadBookPhantomGain> GetAllPhantomConfig(int activityId)
		{
			return ConfigRoadBookPhantomGainByActivityId.GetConfigList(activityId, true) ?? new List<RoadBookPhantomGain>();
		}

		// Token: 0x0603F343 RID: 258883 RVA: 0x00F459EE File Offset: 0x00F43BEE
		public IReadOnlyList<MotorcycleChallenge> GetAllMotorChallengeConfig()
		{
			return ConfigMotorcycleChallengeAll.GetConfigList(true) ?? new List<MotorcycleChallenge>();
		}

		// Token: 0x0603F344 RID: 258884 RVA: 0x00F45A00 File Offset: 0x00F43C00
		public MotorcycleChallenge? GetMotorChallengeConfig(int id)
		{
			MotorcycleChallenge? config = ConfigMotorcycleChallengeById.GetConfig(id, true);
			if (config != null)
			{
				return new MotorcycleChallenge?(config.Value);
			}
			return null;
		}

		// Token: 0x17009218 RID: 37400
		// (get) Token: 0x0603F345 RID: 258885 RVA: 0x00F45A34 File Offset: 0x00F43C34
		public static ActivityRoadBookConfig Instance
		{
			get
			{
				return ActivityRoadBookConfig._Instance;
			}
		}

		// Token: 0x0603F346 RID: 258886 RVA: 0x00F45A3B File Offset: 0x00F43C3B
		public static ActivityRoadBookConfig GetOrCreateInstance()
		{
			if (ActivityRoadBookConfig._Instance == null)
			{
				ActivityRoadBookConfig.CreateInstance();
			}
			return ActivityRoadBookConfig._Instance;
		}

		// Token: 0x0603F347 RID: 258887 RVA: 0x00F45A4F File Offset: 0x00F43C4F
		public static bool CreateInstance()
		{
			if (ActivityRoadBookConfig._Instance != null)
			{
				return true;
			}
			ActivityRoadBookConfig._Instance = new ActivityRoadBookConfig();
			return true;
		}

		// Token: 0x0603F348 RID: 258888 RVA: 0x00F45A65 File Offset: 0x00F43C65
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603F349 RID: 258889 RVA: 0x00F45A67 File Offset: 0x00F43C67
		public static void ResetStaticDefaultValue()
		{
			ActivityRoadBookConfig._Instance = null;
		}

		// Token: 0x0603F34A RID: 258890 RVA: 0x00F45A6F File Offset: 0x00F43C6F
		static ActivityRoadBookConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoadBookConfig.CreateStaticDefaultValue), new Action(ActivityRoadBookConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04020F0A RID: 134922
		[Nullable(2)]
		private static ActivityRoadBookConfig _Instance;
	}
}
