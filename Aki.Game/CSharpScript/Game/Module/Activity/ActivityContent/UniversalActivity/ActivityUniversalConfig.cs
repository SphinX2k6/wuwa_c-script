using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.UniversalActivity
{
	// Token: 0x02005F81 RID: 24449
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityUniversalConfig : ConfigBase
	{
		// Token: 0x0603E0BD RID: 254141 RVA: 0x00EFB166 File Offset: 0x00EF9366
		public UniversalActivity? GetActivityUniversalConfig(int activityId)
		{
			return ConfigUniversalActivityById.GetConfig(activityId, true);
		}

		// Token: 0x17008FDE RID: 36830
		// (get) Token: 0x0603E0BE RID: 254142 RVA: 0x00EFB16F File Offset: 0x00EF936F
		public static ActivityUniversalConfig Instance
		{
			get
			{
				return ActivityUniversalConfig._Instance;
			}
		}

		// Token: 0x0603E0BF RID: 254143 RVA: 0x00EFB176 File Offset: 0x00EF9376
		public static ActivityUniversalConfig GetOrCreateInstance()
		{
			if (ActivityUniversalConfig._Instance == null)
			{
				ActivityUniversalConfig.CreateInstance();
			}
			return ActivityUniversalConfig._Instance;
		}

		// Token: 0x0603E0C0 RID: 254144 RVA: 0x00EFB18A File Offset: 0x00EF938A
		public static bool CreateInstance()
		{
			if (ActivityUniversalConfig._Instance != null)
			{
				return true;
			}
			ActivityUniversalConfig._Instance = new ActivityUniversalConfig();
			return true;
		}

		// Token: 0x0603E0C1 RID: 254145 RVA: 0x00EFB1A0 File Offset: 0x00EF93A0
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603E0C2 RID: 254146 RVA: 0x00EFB1A2 File Offset: 0x00EF93A2
		public static void ResetStaticDefaultValue()
		{
			ActivityUniversalConfig._Instance = null;
		}

		// Token: 0x0603E0C3 RID: 254147 RVA: 0x00EFB1AA File Offset: 0x00EF93AA
		static ActivityUniversalConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityUniversalConfig.CreateStaticDefaultValue), new Action(ActivityUniversalConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04020675 RID: 132725
		[Nullable(2)]
		private static ActivityUniversalConfig _Instance;
	}
}
