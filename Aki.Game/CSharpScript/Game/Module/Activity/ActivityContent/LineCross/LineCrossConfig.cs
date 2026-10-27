using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x0200655D RID: 25949
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class LineCrossConfig : ConfigBase
	{
		// Token: 0x06041072 RID: 266354 RVA: 0x00FC2CCB File Offset: 0x00FC0ECB
		public LineCrossEntrance? GetLineCrossEntranceById(int id)
		{
			return ConfigLineCrossEntranceById.GetConfig(id, true);
		}

		// Token: 0x06041073 RID: 266355 RVA: 0x00FC2CD4 File Offset: 0x00FC0ED4
		public LineCrossGroup? GetLineCrossGroupByGroupId(int groupId)
		{
			return ConfigLineCrossGroupByGroupId.GetConfig(groupId, true);
		}

		// Token: 0x06041074 RID: 266356 RVA: 0x00FC2CDD File Offset: 0x00FC0EDD
		public LineCrossChallenge? GetLineCrossChallengeById(int id)
		{
			return ConfigLineCrossChallengeById.GetConfig(id, true);
		}

		// Token: 0x06041075 RID: 266357 RVA: 0x00FC2CE6 File Offset: 0x00FC0EE6
		public LineCrossActivity? GetLineCrossActivityById(int id)
		{
			return ConfigLineCrossActivityByActivityId.GetConfig(id, true);
		}

		// Token: 0x17009542 RID: 38210
		// (get) Token: 0x06041076 RID: 266358 RVA: 0x00FC2CEF File Offset: 0x00FC0EEF
		public static LineCrossConfig Instance
		{
			get
			{
				return LineCrossConfig._Instance;
			}
		}

		// Token: 0x06041077 RID: 266359 RVA: 0x00FC2CF6 File Offset: 0x00FC0EF6
		public static LineCrossConfig GetOrCreateInstance()
		{
			if (LineCrossConfig._Instance == null)
			{
				LineCrossConfig.CreateInstance();
			}
			return LineCrossConfig._Instance;
		}

		// Token: 0x06041078 RID: 266360 RVA: 0x00FC2D0A File Offset: 0x00FC0F0A
		public static bool CreateInstance()
		{
			if (LineCrossConfig._Instance != null)
			{
				return true;
			}
			LineCrossConfig._Instance = new LineCrossConfig();
			return true;
		}

		// Token: 0x06041079 RID: 266361 RVA: 0x00FC2D20 File Offset: 0x00FC0F20
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604107A RID: 266362 RVA: 0x00FC2D22 File Offset: 0x00FC0F22
		public static void ResetStaticDefaultValue()
		{
			LineCrossConfig._Instance = null;
		}

		// Token: 0x0604107B RID: 266363 RVA: 0x00FC2D2A File Offset: 0x00FC0F2A
		static LineCrossConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LineCrossConfig.CreateStaticDefaultValue), new Action(LineCrossConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04021E63 RID: 138851
		[Nullable(2)]
		private static LineCrossConfig _Instance;
	}
}
