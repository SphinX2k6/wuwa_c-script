using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.NewbieMain
{
	// Token: 0x020052F9 RID: 21241
	[NullableContext(2)]
	[Nullable(0)]
	[Config(0)]
	public class NewbieMainConfig : ConfigBase
	{
		// Token: 0x06034D9F RID: 216479 RVA: 0x00EC6CBA File Offset: 0x00EC4EBA
		public IReadOnlyList<NewbieMainActTab> GetTabListByActivityId(int activityId)
		{
			return ConfigNewbieMainActTabByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x06034DA0 RID: 216480 RVA: 0x00EC6CC3 File Offset: 0x00EC4EC3
		public NewbieMainActTab? GetTabById(int tabId)
		{
			return ConfigNewbieMainActTabById.GetConfig(tabId, true);
		}

		// Token: 0x06034DA1 RID: 216481 RVA: 0x00EC6CCC File Offset: 0x00EC4ECC
		public NewbieMainActTask? GetTabTaskById(int taskId)
		{
			return ConfigNewbieMainActTaskById.GetConfig(taskId, true);
		}

		// Token: 0x06034DA2 RID: 216482 RVA: 0x00EC6CD5 File Offset: 0x00EC4ED5
		public IReadOnlyList<NewbieMainActTask> GetTabTaskListByTabId(int tabId)
		{
			return ConfigNewbieMainActTaskByTabId.GetConfigList(tabId, true);
		}

		// Token: 0x06034DA3 RID: 216483 RVA: 0x00EC6CDE File Offset: 0x00EC4EDE
		public IReadOnlyList<NewbieMainActReward> GetRewardListByActivityId(int activityId)
		{
			return ConfigNewbieMainActRewardByActivityId.GetConfigList(activityId, true);
		}

		// Token: 0x06034DA4 RID: 216484 RVA: 0x00EC6CE7 File Offset: 0x00EC4EE7
		public NewbieMainActReward? GetRewardById(int rewardId)
		{
			return ConfigNewbieMainActRewardById.GetConfig(rewardId, true);
		}

		// Token: 0x170066B1 RID: 26289
		// (get) Token: 0x06034DA5 RID: 216485 RVA: 0x00EC6CF0 File Offset: 0x00EC4EF0
		[Nullable(1)]
		public static NewbieMainConfig Instance
		{
			[NullableContext(1)]
			get
			{
				return NewbieMainConfig._Instance;
			}
		}

		// Token: 0x06034DA6 RID: 216486 RVA: 0x00EC6CF7 File Offset: 0x00EC4EF7
		[NullableContext(1)]
		public static NewbieMainConfig GetOrCreateInstance()
		{
			if (NewbieMainConfig._Instance == null)
			{
				NewbieMainConfig.CreateInstance();
			}
			return NewbieMainConfig._Instance;
		}

		// Token: 0x06034DA7 RID: 216487 RVA: 0x00EC6D0B File Offset: 0x00EC4F0B
		public static bool CreateInstance()
		{
			if (NewbieMainConfig._Instance != null)
			{
				return true;
			}
			NewbieMainConfig._Instance = new NewbieMainConfig();
			return true;
		}

		// Token: 0x06034DA8 RID: 216488 RVA: 0x00EC6D21 File Offset: 0x00EC4F21
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06034DA9 RID: 216489 RVA: 0x00EC6D23 File Offset: 0x00EC4F23
		public static void ResetStaticDefaultValue()
		{
			NewbieMainConfig._Instance = null;
		}

		// Token: 0x06034DAA RID: 216490 RVA: 0x00EC6D2B File Offset: 0x00EC4F2B
		static NewbieMainConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(NewbieMainConfig.CreateStaticDefaultValue), new Action(NewbieMainConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401BF44 RID: 114500
		private static NewbieMainConfig _Instance;
	}
}
