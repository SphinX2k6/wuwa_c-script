using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity
{
	// Token: 0x0200512A RID: 20778
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityRogueConfig : ConfigBase
	{
		// Token: 0x06033F1C RID: 212764 RVA: 0x00E88308 File Offset: 0x00E86508
		public RogueActivity? GetActivityUniversalConfig(int activityId)
		{
			RogueActivity? config = ConfigRogueActivityById.GetConfig(activityId, true);
			if (config == null)
			{
				return null;
			}
			return config;
		}

		// Token: 0x1700656B RID: 25963
		// (get) Token: 0x06033F1D RID: 212765 RVA: 0x00E88331 File Offset: 0x00E86531
		public static ActivityRogueConfig Instance
		{
			get
			{
				return ActivityRogueConfig._Instance;
			}
		}

		// Token: 0x06033F1E RID: 212766 RVA: 0x00E88338 File Offset: 0x00E86538
		public static ActivityRogueConfig GetOrCreateInstance()
		{
			if (ActivityRogueConfig._Instance == null)
			{
				ActivityRogueConfig.CreateInstance();
			}
			return ActivityRogueConfig._Instance;
		}

		// Token: 0x06033F1F RID: 212767 RVA: 0x00E8834C File Offset: 0x00E8654C
		public static bool CreateInstance()
		{
			if (ActivityRogueConfig._Instance != null)
			{
				return true;
			}
			ActivityRogueConfig._Instance = new ActivityRogueConfig();
			return true;
		}

		// Token: 0x06033F20 RID: 212768 RVA: 0x00E88362 File Offset: 0x00E86562
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033F21 RID: 212769 RVA: 0x00E88364 File Offset: 0x00E86564
		public static void ResetStaticDefaultValue()
		{
			ActivityRogueConfig._Instance = null;
		}

		// Token: 0x06033F22 RID: 212770 RVA: 0x00E8836C File Offset: 0x00E8656C
		static ActivityRogueConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRogueConfig.CreateStaticDefaultValue), new Action(ActivityRogueConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401B7D4 RID: 112596
		[Nullable(2)]
		private static ActivityRogueConfig _Instance;
	}
}
