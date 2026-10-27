using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PreWarm
{
	// Token: 0x020062B5 RID: 25269
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityPreWarmConfig : ConfigBase
	{
		// Token: 0x0603F8D5 RID: 260309 RVA: 0x00F5F2DF File Offset: 0x00F5D4DF
		public PreHeatTaskActivity? GetPreWarmConfig(int id)
		{
			return ConfigPreHeatTaskActivityById.GetConfig(id, true);
		}

		// Token: 0x17009270 RID: 37488
		// (get) Token: 0x0603F8D6 RID: 260310 RVA: 0x00F5F2E8 File Offset: 0x00F5D4E8
		public static ActivityPreWarmConfig Instance
		{
			get
			{
				return ActivityPreWarmConfig._Instance;
			}
		}

		// Token: 0x0603F8D7 RID: 260311 RVA: 0x00F5F2EF File Offset: 0x00F5D4EF
		public static ActivityPreWarmConfig GetOrCreateInstance()
		{
			if (ActivityPreWarmConfig._Instance == null)
			{
				ActivityPreWarmConfig.CreateInstance();
			}
			return ActivityPreWarmConfig._Instance;
		}

		// Token: 0x0603F8D8 RID: 260312 RVA: 0x00F5F303 File Offset: 0x00F5D503
		public static bool CreateInstance()
		{
			if (ActivityPreWarmConfig._Instance != null)
			{
				return true;
			}
			ActivityPreWarmConfig._Instance = new ActivityPreWarmConfig();
			return true;
		}

		// Token: 0x0603F8D9 RID: 260313 RVA: 0x00F5F319 File Offset: 0x00F5D519
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603F8DA RID: 260314 RVA: 0x00F5F31B File Offset: 0x00F5D51B
		public static void ResetStaticDefaultValue()
		{
			ActivityPreWarmConfig._Instance = null;
		}

		// Token: 0x0603F8DB RID: 260315 RVA: 0x00F5F323 File Offset: 0x00F5D523
		static ActivityPreWarmConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityPreWarmConfig.CreateStaticDefaultValue), new Action(ActivityPreWarmConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040213CC RID: 136140
		[Nullable(2)]
		private static ActivityPreWarmConfig _Instance;
	}
}
