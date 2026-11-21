using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PreWarm
{
	// Token: 0x02005233 RID: 21043
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityPreWarmConfig : ConfigBase
	{
		// Token: 0x06034596 RID: 214422 RVA: 0x00EA623B File Offset: 0x00EA443B
		public PreHeatTaskActivity? GetPreWarmConfig(int id)
		{
			return ConfigPreHeatTaskActivityById.GetConfig(id, true);
		}

		// Token: 0x170065D2 RID: 26066
		// (get) Token: 0x06034597 RID: 214423 RVA: 0x00EA6244 File Offset: 0x00EA4444
		public static ActivityPreWarmConfig Instance
		{
			get
			{
				return ActivityPreWarmConfig._Instance;
			}
		}

		// Token: 0x06034598 RID: 214424 RVA: 0x00EA624B File Offset: 0x00EA444B
		public static ActivityPreWarmConfig GetOrCreateInstance()
		{
			if (ActivityPreWarmConfig._Instance == null)
			{
				ActivityPreWarmConfig.CreateInstance();
			}
			return ActivityPreWarmConfig._Instance;
		}

		// Token: 0x06034599 RID: 214425 RVA: 0x00EA625F File Offset: 0x00EA445F
		public static bool CreateInstance()
		{
			if (ActivityPreWarmConfig._Instance != null)
			{
				return true;
			}
			ActivityPreWarmConfig._Instance = new ActivityPreWarmConfig();
			return true;
		}

		// Token: 0x0603459A RID: 214426 RVA: 0x00EA6275 File Offset: 0x00EA4475
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603459B RID: 214427 RVA: 0x00EA6277 File Offset: 0x00EA4477
		public static void ResetStaticDefaultValue()
		{
			ActivityPreWarmConfig._Instance = null;
		}

		// Token: 0x0603459C RID: 214428 RVA: 0x00EA627F File Offset: 0x00EA447F
		static ActivityPreWarmConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityPreWarmConfig.CreateStaticDefaultValue), new Action(ActivityPreWarmConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401BCFB RID: 113915
		[Nullable(2)]
		private static ActivityPreWarmConfig _Instance;
	}
}
