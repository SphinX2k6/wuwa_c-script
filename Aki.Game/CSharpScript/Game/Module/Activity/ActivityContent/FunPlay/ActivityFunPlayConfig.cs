using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x0200656A RID: 25962
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityFunPlayConfig : ConfigBase
	{
		// Token: 0x06041105 RID: 266501 RVA: 0x00FC4D59 File Offset: 0x00FC2F59
		public FunPlayActivityChallenge? GetFunPlayActivityChallenge(int challengeId)
		{
			return ConfigFunPlayActivityChallengeById.GetConfig(challengeId, true);
		}

		// Token: 0x06041106 RID: 266502 RVA: 0x00FC4D62 File Offset: 0x00FC2F62
		public FunPlaySharpComment? GetFunPlaySharpComment(int commentId)
		{
			return ConfigFunPlaySharpCommentById.GetConfig(commentId, true);
		}

		// Token: 0x17009546 RID: 38214
		// (get) Token: 0x06041107 RID: 266503 RVA: 0x00FC4D6B File Offset: 0x00FC2F6B
		public static ActivityFunPlayConfig Instance
		{
			get
			{
				return ActivityFunPlayConfig._Instance;
			}
		}

		// Token: 0x06041108 RID: 266504 RVA: 0x00FC4D72 File Offset: 0x00FC2F72
		public static ActivityFunPlayConfig GetOrCreateInstance()
		{
			if (ActivityFunPlayConfig._Instance == null)
			{
				ActivityFunPlayConfig.CreateInstance();
			}
			return ActivityFunPlayConfig._Instance;
		}

		// Token: 0x06041109 RID: 266505 RVA: 0x00FC4D86 File Offset: 0x00FC2F86
		public static bool CreateInstance()
		{
			if (ActivityFunPlayConfig._Instance != null)
			{
				return true;
			}
			ActivityFunPlayConfig._Instance = new ActivityFunPlayConfig();
			return true;
		}

		// Token: 0x0604110A RID: 266506 RVA: 0x00FC4D9C File Offset: 0x00FC2F9C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604110B RID: 266507 RVA: 0x00FC4D9E File Offset: 0x00FC2F9E
		public static void ResetStaticDefaultValue()
		{
			ActivityFunPlayConfig._Instance = null;
		}

		// Token: 0x0604110C RID: 266508 RVA: 0x00FC4DA6 File Offset: 0x00FC2FA6
		static ActivityFunPlayConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityFunPlayConfig.CreateStaticDefaultValue), new Action(ActivityFunPlayConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04021E8E RID: 138894
		[Nullable(2)]
		private static ActivityFunPlayConfig _Instance;
	}
}
