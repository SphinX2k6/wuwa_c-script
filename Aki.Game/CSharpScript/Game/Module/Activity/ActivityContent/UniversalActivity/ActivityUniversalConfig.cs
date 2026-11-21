using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalActivity
{
	// Token: 0x02004F68 RID: 20328
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityUniversalConfig : ConfigBase
	{
		// Token: 0x06033057 RID: 208983 RVA: 0x00E4CE46 File Offset: 0x00E4B046
		public UniversalActivity? GetActivityUniversalConfig(int activityId)
		{
			return ConfigUniversalActivityById.GetConfig(activityId, true);
		}

		// Token: 0x170063B0 RID: 25520
		// (get) Token: 0x06033058 RID: 208984 RVA: 0x00E4CE4F File Offset: 0x00E4B04F
		public static ActivityUniversalConfig Instance
		{
			get
			{
				return ActivityUniversalConfig._Instance;
			}
		}

		// Token: 0x06033059 RID: 208985 RVA: 0x00E4CE56 File Offset: 0x00E4B056
		public static ActivityUniversalConfig GetOrCreateInstance()
		{
			if (ActivityUniversalConfig._Instance == null)
			{
				ActivityUniversalConfig.CreateInstance();
			}
			return ActivityUniversalConfig._Instance;
		}

		// Token: 0x0603305A RID: 208986 RVA: 0x00E4CE6A File Offset: 0x00E4B06A
		public static bool CreateInstance()
		{
			if (ActivityUniversalConfig._Instance != null)
			{
				return true;
			}
			ActivityUniversalConfig._Instance = new ActivityUniversalConfig();
			return true;
		}

		// Token: 0x0603305B RID: 208987 RVA: 0x00E4CE80 File Offset: 0x00E4B080
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603305C RID: 208988 RVA: 0x00E4CE82 File Offset: 0x00E4B082
		public static void ResetStaticDefaultValue()
		{
			ActivityUniversalConfig._Instance = null;
		}

		// Token: 0x0603305D RID: 208989 RVA: 0x00E4CE8A File Offset: 0x00E4B08A
		static ActivityUniversalConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityUniversalConfig.CreateStaticDefaultValue), new Action(ActivityUniversalConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401B147 RID: 110919
		[Nullable(2)]
		private static ActivityUniversalConfig _Instance;
	}
}
