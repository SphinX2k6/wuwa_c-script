using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoleSkinReward
{
	// Token: 0x020061B8 RID: 25016
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityRoleSkinRewardConfig : ConfigBase
	{
		// Token: 0x0603F305 RID: 258821 RVA: 0x00F44B68 File Offset: 0x00F42D68
		public SkinRewardActivityReward? GetActivityConfig(int activityId)
		{
			SkinRewardActivityReward? config = ConfigSkinRewardActivityRewardByActivityId.GetConfig(activityId, true);
			if (config != null)
			{
				return new SkinRewardActivityReward?(config.Value);
			}
			return null;
		}

		// Token: 0x17009216 RID: 37398
		// (get) Token: 0x0603F306 RID: 258822 RVA: 0x00F44B9C File Offset: 0x00F42D9C
		public static ActivityRoleSkinRewardConfig Instance
		{
			get
			{
				return ActivityRoleSkinRewardConfig._Instance;
			}
		}

		// Token: 0x0603F307 RID: 258823 RVA: 0x00F44BA3 File Offset: 0x00F42DA3
		public static ActivityRoleSkinRewardConfig GetOrCreateInstance()
		{
			if (ActivityRoleSkinRewardConfig._Instance == null)
			{
				ActivityRoleSkinRewardConfig.CreateInstance();
			}
			return ActivityRoleSkinRewardConfig._Instance;
		}

		// Token: 0x0603F308 RID: 258824 RVA: 0x00F44BB7 File Offset: 0x00F42DB7
		public static bool CreateInstance()
		{
			if (ActivityRoleSkinRewardConfig._Instance != null)
			{
				return true;
			}
			ActivityRoleSkinRewardConfig._Instance = new ActivityRoleSkinRewardConfig();
			return true;
		}

		// Token: 0x0603F309 RID: 258825 RVA: 0x00F44BCD File Offset: 0x00F42DCD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603F30A RID: 258826 RVA: 0x00F44BCF File Offset: 0x00F42DCF
		public static void ResetStaticDefaultValue()
		{
			ActivityRoleSkinRewardConfig._Instance = null;
		}

		// Token: 0x0603F30B RID: 258827 RVA: 0x00F44BD7 File Offset: 0x00F42DD7
		static ActivityRoleSkinRewardConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoleSkinRewardConfig.CreateStaticDefaultValue), new Action(ActivityRoleSkinRewardConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04020EEB RID: 134891
		[Nullable(2)]
		private static ActivityRoleSkinRewardConfig _Instance;
	}
}
