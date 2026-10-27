using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity
{
	// Token: 0x020061AC RID: 25004
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityRogueConfig : ConfigBase
	{
		// Token: 0x0603F25C RID: 258652 RVA: 0x00F41440 File Offset: 0x00F3F640
		public RogueActivity? GetActivityUniversalConfig(int activityId)
		{
			RogueActivity? config = ConfigRogueActivityById.GetConfig(activityId, true);
			if (config == null)
			{
				return null;
			}
			return config;
		}

		// Token: 0x17009209 RID: 37385
		// (get) Token: 0x0603F25D RID: 258653 RVA: 0x00F41469 File Offset: 0x00F3F669
		public static ActivityRogueConfig Instance
		{
			get
			{
				return ActivityRogueConfig._Instance;
			}
		}

		// Token: 0x0603F25E RID: 258654 RVA: 0x00F41470 File Offset: 0x00F3F670
		public static ActivityRogueConfig GetOrCreateInstance()
		{
			if (ActivityRogueConfig._Instance == null)
			{
				ActivityRogueConfig.CreateInstance();
			}
			return ActivityRogueConfig._Instance;
		}

		// Token: 0x0603F25F RID: 258655 RVA: 0x00F41484 File Offset: 0x00F3F684
		public static bool CreateInstance()
		{
			if (ActivityRogueConfig._Instance != null)
			{
				return true;
			}
			ActivityRogueConfig._Instance = new ActivityRogueConfig();
			return true;
		}

		// Token: 0x0603F260 RID: 258656 RVA: 0x00F4149A File Offset: 0x00F3F69A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603F261 RID: 258657 RVA: 0x00F4149C File Offset: 0x00F3F69C
		public static void ResetStaticDefaultValue()
		{
			ActivityRogueConfig._Instance = null;
		}

		// Token: 0x0603F262 RID: 258658 RVA: 0x00F414A4 File Offset: 0x00F3F6A4
		static ActivityRogueConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRogueConfig.CreateStaticDefaultValue), new Action(ActivityRogueConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04020EA7 RID: 134823
		[Nullable(2)]
		private static ActivityRogueConfig _Instance;
	}
}
