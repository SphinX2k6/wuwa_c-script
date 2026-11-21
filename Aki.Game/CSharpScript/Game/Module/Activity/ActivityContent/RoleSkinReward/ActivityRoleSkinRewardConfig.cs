using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoleSkinReward
{
	// Token: 0x02005136 RID: 20790
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityRoleSkinRewardConfig : ConfigBase
	{
		// Token: 0x06033FC6 RID: 212934 RVA: 0x00E8BAC0 File Offset: 0x00E89CC0
		public SkinRewardActivityReward? GetActivityConfig(int activityId)
		{
			SkinRewardActivityReward? config = ConfigSkinRewardActivityRewardByActivityId.GetConfig(activityId, true);
			if (config != null)
			{
				return new SkinRewardActivityReward?(config.Value);
			}
			return null;
		}

		// Token: 0x17006578 RID: 25976
		// (get) Token: 0x06033FC7 RID: 212935 RVA: 0x00E8BAF4 File Offset: 0x00E89CF4
		public static ActivityRoleSkinRewardConfig Instance
		{
			get
			{
				return ActivityRoleSkinRewardConfig._Instance;
			}
		}

		// Token: 0x06033FC8 RID: 212936 RVA: 0x00E8BAFB File Offset: 0x00E89CFB
		public static ActivityRoleSkinRewardConfig GetOrCreateInstance()
		{
			if (ActivityRoleSkinRewardConfig._Instance == null)
			{
				ActivityRoleSkinRewardConfig.CreateInstance();
			}
			return ActivityRoleSkinRewardConfig._Instance;
		}

		// Token: 0x06033FC9 RID: 212937 RVA: 0x00E8BB0F File Offset: 0x00E89D0F
		public static bool CreateInstance()
		{
			if (ActivityRoleSkinRewardConfig._Instance != null)
			{
				return true;
			}
			ActivityRoleSkinRewardConfig._Instance = new ActivityRoleSkinRewardConfig();
			return true;
		}

		// Token: 0x06033FCA RID: 212938 RVA: 0x00E8BB25 File Offset: 0x00E89D25
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06033FCB RID: 212939 RVA: 0x00E8BB27 File Offset: 0x00E89D27
		public static void ResetStaticDefaultValue()
		{
			ActivityRoleSkinRewardConfig._Instance = null;
		}

		// Token: 0x06033FCC RID: 212940 RVA: 0x00E8BB2F File Offset: 0x00E89D2F
		static ActivityRoleSkinRewardConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityRoleSkinRewardConfig.CreateStaticDefaultValue), new Action(ActivityRoleSkinRewardConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401B81A RID: 112666
		[Nullable(2)]
		private static ActivityRoleSkinRewardConfig _Instance;
	}
}
