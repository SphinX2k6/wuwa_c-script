using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MoonSignIn
{
	// Token: 0x020053DB RID: 21467
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MoonSignInConfig : ConfigBase
	{
		// Token: 0x060355DB RID: 218587 RVA: 0x00EE7CC2 File Offset: 0x00EE5EC2
		[NullableContext(2)]
		public IReadOnlyList<PhaseOfMoon> GetPhaseOfMoonList()
		{
			return ConfigPhaseOfMoonAll.GetConfigList(true);
		}

		// Token: 0x060355DC RID: 218588 RVA: 0x00EE7CCA File Offset: 0x00EE5ECA
		public MoonPhaseReward? GetMoonSignReward(int activityId)
		{
			return ConfigMoonPhaseRewardByActivityId.GetConfig(activityId, true);
		}

		// Token: 0x060355DD RID: 218589 RVA: 0x00EE7CD3 File Offset: 0x00EE5ED3
		public PhaseOfMoon? GetPhaseOfMoonById(int moonId)
		{
			return ConfigPhaseOfMoonById.GetConfig(moonId, true);
		}

		// Token: 0x060355DE RID: 218590 RVA: 0x00EE7CDC File Offset: 0x00EE5EDC
		public MoonLabel? GetMoonLabelById(int moonId)
		{
			return ConfigMoonLabelById.GetConfig(moonId, true);
		}

		// Token: 0x170067E9 RID: 26601
		// (get) Token: 0x060355DF RID: 218591 RVA: 0x00EE7CE5 File Offset: 0x00EE5EE5
		public static MoonSignInConfig Instance
		{
			get
			{
				return MoonSignInConfig._Instance;
			}
		}

		// Token: 0x060355E0 RID: 218592 RVA: 0x00EE7CEC File Offset: 0x00EE5EEC
		public static MoonSignInConfig GetOrCreateInstance()
		{
			if (MoonSignInConfig._Instance == null)
			{
				MoonSignInConfig.CreateInstance();
			}
			return MoonSignInConfig._Instance;
		}

		// Token: 0x060355E1 RID: 218593 RVA: 0x00EE7D00 File Offset: 0x00EE5F00
		public static bool CreateInstance()
		{
			if (MoonSignInConfig._Instance != null)
			{
				return true;
			}
			MoonSignInConfig._Instance = new MoonSignInConfig();
			return true;
		}

		// Token: 0x060355E2 RID: 218594 RVA: 0x00EE7D16 File Offset: 0x00EE5F16
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060355E3 RID: 218595 RVA: 0x00EE7D18 File Offset: 0x00EE5F18
		public static void ResetStaticDefaultValue()
		{
			MoonSignInConfig._Instance = null;
		}

		// Token: 0x060355E4 RID: 218596 RVA: 0x00EE7D20 File Offset: 0x00EE5F20
		static MoonSignInConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MoonSignInConfig.CreateStaticDefaultValue), new Action(MoonSignInConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401C26E RID: 115310
		[Nullable(2)]
		private static MoonSignInConfig _Instance;
	}
}
