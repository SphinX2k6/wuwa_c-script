using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x020054DB RID: 21723
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class LineCrossConfig : ConfigBase
	{
		// Token: 0x06035D37 RID: 220471 RVA: 0x00F09CB3 File Offset: 0x00F07EB3
		public LineCrossEntrance? GetLineCrossEntranceById(int id)
		{
			return ConfigLineCrossEntranceById.GetConfig(id, true);
		}

		// Token: 0x06035D38 RID: 220472 RVA: 0x00F09CBC File Offset: 0x00F07EBC
		public LineCrossGroup? GetLineCrossGroupByGroupId(int groupId)
		{
			return ConfigLineCrossGroupByGroupId.GetConfig(groupId, true);
		}

		// Token: 0x06035D39 RID: 220473 RVA: 0x00F09CC5 File Offset: 0x00F07EC5
		public LineCrossChallenge? GetLineCrossChallengeById(int id)
		{
			return ConfigLineCrossChallengeById.GetConfig(id, true);
		}

		// Token: 0x06035D3A RID: 220474 RVA: 0x00F09CCE File Offset: 0x00F07ECE
		public LineCrossActivity? GetLineCrossActivityById(int id)
		{
			return ConfigLineCrossActivityByActivityId.GetConfig(id, true);
		}

		// Token: 0x170068A4 RID: 26788
		// (get) Token: 0x06035D3B RID: 220475 RVA: 0x00F09CD7 File Offset: 0x00F07ED7
		public static LineCrossConfig Instance
		{
			get
			{
				return LineCrossConfig._Instance;
			}
		}

		// Token: 0x06035D3C RID: 220476 RVA: 0x00F09CDE File Offset: 0x00F07EDE
		public static LineCrossConfig GetOrCreateInstance()
		{
			if (LineCrossConfig._Instance == null)
			{
				LineCrossConfig.CreateInstance();
			}
			return LineCrossConfig._Instance;
		}

		// Token: 0x06035D3D RID: 220477 RVA: 0x00F09CF2 File Offset: 0x00F07EF2
		public static bool CreateInstance()
		{
			if (LineCrossConfig._Instance != null)
			{
				return true;
			}
			LineCrossConfig._Instance = new LineCrossConfig();
			return true;
		}

		// Token: 0x06035D3E RID: 220478 RVA: 0x00F09D08 File Offset: 0x00F07F08
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06035D3F RID: 220479 RVA: 0x00F09D0A File Offset: 0x00F07F0A
		public static void ResetStaticDefaultValue()
		{
			LineCrossConfig._Instance = null;
		}

		// Token: 0x06035D40 RID: 220480 RVA: 0x00F09D12 File Offset: 0x00F07F12
		static LineCrossConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(LineCrossConfig.CreateStaticDefaultValue), new Action(LineCrossConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401C794 RID: 116628
		[Nullable(2)]
		private static LineCrossConfig _Instance;
	}
}
