using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x0200645D RID: 25693
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MoonSignInConfig : ConfigBase
	{
		// Token: 0x0604091A RID: 264474 RVA: 0x00FA0D46 File Offset: 0x00F9EF46
		[NullableContext(2)]
		public IReadOnlyList<PhaseOfMoon> GetPhaseOfMoonList()
		{
			return ConfigPhaseOfMoonAll.GetConfigList(true);
		}

		// Token: 0x0604091B RID: 264475 RVA: 0x00FA0D4E File Offset: 0x00F9EF4E
		public MoonPhaseReward? GetMoonSignReward(int activityId)
		{
			return ConfigMoonPhaseRewardByActivityId.GetConfig(activityId, true);
		}

		// Token: 0x0604091C RID: 264476 RVA: 0x00FA0D57 File Offset: 0x00F9EF57
		public PhaseOfMoon? GetPhaseOfMoonById(int moonId)
		{
			return ConfigPhaseOfMoonById.GetConfig(moonId, true);
		}

		// Token: 0x0604091D RID: 264477 RVA: 0x00FA0D60 File Offset: 0x00F9EF60
		public MoonLabel? GetMoonLabelById(int moonId)
		{
			return ConfigMoonLabelById.GetConfig(moonId, true);
		}

		// Token: 0x17009487 RID: 38023
		// (get) Token: 0x0604091E RID: 264478 RVA: 0x00FA0D69 File Offset: 0x00F9EF69
		public static MoonSignInConfig Instance
		{
			get
			{
				return MoonSignInConfig._Instance;
			}
		}

		// Token: 0x0604091F RID: 264479 RVA: 0x00FA0D70 File Offset: 0x00F9EF70
		public static MoonSignInConfig GetOrCreateInstance()
		{
			if (MoonSignInConfig._Instance == null)
			{
				MoonSignInConfig.CreateInstance();
			}
			return MoonSignInConfig._Instance;
		}

		// Token: 0x06040920 RID: 264480 RVA: 0x00FA0D84 File Offset: 0x00F9EF84
		public static bool CreateInstance()
		{
			if (MoonSignInConfig._Instance != null)
			{
				return true;
			}
			MoonSignInConfig._Instance = new MoonSignInConfig();
			return true;
		}

		// Token: 0x06040921 RID: 264481 RVA: 0x00FA0D9A File Offset: 0x00F9EF9A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06040922 RID: 264482 RVA: 0x00FA0D9C File Offset: 0x00F9EF9C
		public static void ResetStaticDefaultValue()
		{
			MoonSignInConfig._Instance = null;
		}

		// Token: 0x06040923 RID: 264483 RVA: 0x00FA0DA4 File Offset: 0x00F9EFA4
		static MoonSignInConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MoonSignInConfig.CreateStaticDefaultValue), new Action(MoonSignInConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0402193F RID: 137535
		[Nullable(2)]
		private static MoonSignInConfig _Instance;
	}
}
