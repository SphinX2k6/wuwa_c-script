using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions.Config
{
	// Token: 0x02006DA3 RID: 28067
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MusicBeatTypeConfig : ConfigBase
	{
		// Token: 0x06044807 RID: 280583 RVA: 0x010E4BC2 File Offset: 0x010E2DC2
		public MusicBeatType? GetMusicBeatTypeConfig(string beatType)
		{
			return ConfigMusicBeatTypeByBeatType.GetConfig(beatType, true);
		}

		// Token: 0x170099B3 RID: 39347
		// (get) Token: 0x06044808 RID: 280584 RVA: 0x010E4BCB File Offset: 0x010E2DCB
		public static MusicBeatTypeConfig Instance
		{
			get
			{
				return MusicBeatTypeConfig._Instance;
			}
		}

		// Token: 0x06044809 RID: 280585 RVA: 0x010E4BD2 File Offset: 0x010E2DD2
		public static MusicBeatTypeConfig GetOrCreateInstance()
		{
			if (MusicBeatTypeConfig._Instance == null)
			{
				MusicBeatTypeConfig.CreateInstance();
			}
			return MusicBeatTypeConfig._Instance;
		}

		// Token: 0x0604480A RID: 280586 RVA: 0x010E4BE6 File Offset: 0x010E2DE6
		public static bool CreateInstance()
		{
			if (MusicBeatTypeConfig._Instance != null)
			{
				return true;
			}
			MusicBeatTypeConfig._Instance = new MusicBeatTypeConfig();
			return true;
		}

		// Token: 0x0604480B RID: 280587 RVA: 0x010E4BFC File Offset: 0x010E2DFC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604480C RID: 280588 RVA: 0x010E4BFE File Offset: 0x010E2DFE
		public static void ResetStaticDefaultValue()
		{
			MusicBeatTypeConfig._Instance = null;
		}

		// Token: 0x0604480D RID: 280589 RVA: 0x010E4C06 File Offset: 0x010E2E06
		static MusicBeatTypeConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MusicBeatTypeConfig.CreateStaticDefaultValue), new Action(MusicBeatTypeConfig.ResetStaticDefaultValue));
		}

		// Token: 0x040239EC RID: 145900
		[Nullable(2)]
		private static MusicBeatTypeConfig _Instance;
	}
}
