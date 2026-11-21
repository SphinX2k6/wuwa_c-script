using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.FunPlay
{
	// Token: 0x020054E8 RID: 21736
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ActivityFunPlayConfig : ConfigBase
	{
		// Token: 0x06035DCA RID: 220618 RVA: 0x00F0BD3D File Offset: 0x00F09F3D
		public FunPlayActivityChallenge? GetFunPlayActivityChallenge(int challengeId)
		{
			return ConfigFunPlayActivityChallengeById.GetConfig(challengeId, true);
		}

		// Token: 0x06035DCB RID: 220619 RVA: 0x00F0BD46 File Offset: 0x00F09F46
		public FunPlaySharpComment? GetFunPlaySharpComment(int commentId)
		{
			return ConfigFunPlaySharpCommentById.GetConfig(commentId, true);
		}

		// Token: 0x170068A8 RID: 26792
		// (get) Token: 0x06035DCC RID: 220620 RVA: 0x00F0BD4F File Offset: 0x00F09F4F
		public static ActivityFunPlayConfig Instance
		{
			get
			{
				return ActivityFunPlayConfig._Instance;
			}
		}

		// Token: 0x06035DCD RID: 220621 RVA: 0x00F0BD56 File Offset: 0x00F09F56
		public static ActivityFunPlayConfig GetOrCreateInstance()
		{
			if (ActivityFunPlayConfig._Instance == null)
			{
				ActivityFunPlayConfig.CreateInstance();
			}
			return ActivityFunPlayConfig._Instance;
		}

		// Token: 0x06035DCE RID: 220622 RVA: 0x00F0BD6A File Offset: 0x00F09F6A
		public static bool CreateInstance()
		{
			if (ActivityFunPlayConfig._Instance != null)
			{
				return true;
			}
			ActivityFunPlayConfig._Instance = new ActivityFunPlayConfig();
			return true;
		}

		// Token: 0x06035DCF RID: 220623 RVA: 0x00F0BD80 File Offset: 0x00F09F80
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035DD0 RID: 220624 RVA: 0x00F0BD82 File Offset: 0x00F09F82
		public static void ResetStaticDefaultValue()
		{
			ActivityFunPlayConfig._Instance = null;
		}

		// Token: 0x06035DD1 RID: 220625 RVA: 0x00F0BD8A File Offset: 0x00F09F8A
		static ActivityFunPlayConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ActivityFunPlayConfig.CreateStaticDefaultValue), new Action(ActivityFunPlayConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401C7BF RID: 116671
		[Nullable(2)]
		private static ActivityFunPlayConfig _Instance;
	}
}
