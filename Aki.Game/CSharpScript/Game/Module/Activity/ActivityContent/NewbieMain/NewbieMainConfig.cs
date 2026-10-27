using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain
{
	// Token: 0x0200637B RID: 25467
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class NewbieMainConfig : ConfigBase
	{
		// Token: 0x060400DE RID: 262366 RVA: 0x00F7FD56 File Offset: 0x00F7DF56
		public IReadOnlyList<NewbieMainActTab> GetTabListByActivityId(int activityId)
		{
			return ConfigNewbieMainActTabByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x060400DF RID: 262367 RVA: 0x00F7FD5F File Offset: 0x00F7DF5F
		public NewbieMainActTab? GetTabById(int tabId)
		{
			return ConfigNewbieMainActTabById.GetConfig(tabId, true);
		}

		// Token: 0x060400E0 RID: 262368 RVA: 0x00F7FD68 File Offset: 0x00F7DF68
		public NewbieMainActTask? GetTabTaskById(int taskId)
		{
			return ConfigNewbieMainActTaskById.GetConfig(taskId, true);
		}

		// Token: 0x060400E1 RID: 262369 RVA: 0x00F7FD71 File Offset: 0x00F7DF71
		public IReadOnlyList<NewbieMainActTask> GetTabTaskListByTabId(int tabId)
		{
			return ConfigNewbieMainActTaskByTabId.GetConfigList(tabId, true);
		}

		// Token: 0x060400E2 RID: 262370 RVA: 0x00F7FD7A File Offset: 0x00F7DF7A
		public IReadOnlyList<NewbieMainActReward> GetRewardListByActivityId(int activityId)
		{
			return ConfigNewbieMainActRewardByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x060400E3 RID: 262371 RVA: 0x00F7FD83 File Offset: 0x00F7DF83
		public NewbieMainActReward? GetRewardById(int rewardId)
		{
			return ConfigNewbieMainActRewardById.GetConfig(rewardId, true);
		}

		// Token: 0x1700934F RID: 37711
		// (get) Token: 0x060400E4 RID: 262372 RVA: 0x00F7FD8C File Offset: 0x00F7DF8C
		[Nullable(1)]
		public static NewbieMainConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return NewbieMainConfig._Instance;
			}
		}

		// Token: 0x060400E5 RID: 262373 RVA: 0x00F7FD93 File Offset: 0x00F7DF93
		[NullableContext(1)]
		public static NewbieMainConfig GetOrCreateInstance()
		{
			if (NewbieMainConfig._Instance == null)
			{
				NewbieMainConfig.CreateInstance();
			}
			return NewbieMainConfig._Instance;
		}

		// Token: 0x060400E6 RID: 262374 RVA: 0x00F7FDA7 File Offset: 0x00F7DFA7
		public static bool CreateInstance()
		{
			if (NewbieMainConfig._Instance != null)
			{
				return true;
			}
			NewbieMainConfig._Instance = new NewbieMainConfig();
			return true;
		}

		// Token: 0x060400E7 RID: 262375 RVA: 0x00F7FDBD File Offset: 0x00F7DFBD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060400E8 RID: 262376 RVA: 0x00F7FDBF File Offset: 0x00F7DFBF
		public static void ResetStaticDefaultValue()
		{
			NewbieMainConfig._Instance = null;
		}

		// Token: 0x060400E9 RID: 262377 RVA: 0x00F7FDC7 File Offset: 0x00F7DFC7
		static NewbieMainConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(NewbieMainConfig.CreateStaticDefaultValue), new Action(NewbieMainConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04021615 RID: 136725
		private static NewbieMainConfig _Instance;
	}
}
