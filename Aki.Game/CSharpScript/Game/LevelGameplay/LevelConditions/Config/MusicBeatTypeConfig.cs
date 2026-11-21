using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions.Config
{
	// Token: 0x02005F22 RID: 24354
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class MusicBeatTypeConfig : ConfigBase
	{
		// Token: 0x0603A96B RID: 239979 RVA: 0x0108EDEA File Offset: 0x0108CFEA
		public MusicBeatType? GetMusicBeatTypeConfig(string beatType)
		{
			return ConfigMusicBeatTypeByBeatType.GetConfig(beatType, true);
		}

		// Token: 0x17006EB6 RID: 28342
		// (get) Token: 0x0603A96C RID: 239980 RVA: 0x0108EDF3 File Offset: 0x0108CFF3
		public static MusicBeatTypeConfig Instance
		{
			get
			{
				return MusicBeatTypeConfig._Instance;
			}
		}

		// Token: 0x0603A96D RID: 239981 RVA: 0x0108EDFA File Offset: 0x0108CFFA
		public static MusicBeatTypeConfig GetOrCreateInstance()
		{
			if (MusicBeatTypeConfig._Instance == null)
			{
				MusicBeatTypeConfig.CreateInstance();
			}
			return MusicBeatTypeConfig._Instance;
		}

		// Token: 0x0603A96E RID: 239982 RVA: 0x0108EE0E File Offset: 0x0108D00E
		public static bool CreateInstance()
		{
			if (MusicBeatTypeConfig._Instance != null)
			{
				return true;
			}
			MusicBeatTypeConfig._Instance = new MusicBeatTypeConfig();
			return true;
		}

		// Token: 0x0603A96F RID: 239983 RVA: 0x0108EE24 File Offset: 0x0108D024
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603A970 RID: 239984 RVA: 0x0108EE26 File Offset: 0x0108D026
		public static void ResetStaticDefaultValue()
		{
			MusicBeatTypeConfig._Instance = null;
		}

		// Token: 0x0603A971 RID: 239985 RVA: 0x0108EE2E File Offset: 0x0108D02E
		static MusicBeatTypeConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MusicBeatTypeConfig.CreateStaticDefaultValue), new Action(MusicBeatTypeConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401EC8E RID: 126094
		[Nullable(2)]
		private static MusicBeatTypeConfig _Instance;
	}
}
