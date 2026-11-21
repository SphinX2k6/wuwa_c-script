using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C18 RID: 23576
	[NullableContext(1)]
	[Nullable(0)]
	public static class PianoGameplayDefine
	{
		// Token: 0x0401E9B2 RID: 125362
		public const string PIANO_GAMEPLAY_SETTING_DA_PATH = "/Game/Aki/Data/Gameplay/PianoGameplay/DA_PianoGameplaySetting.DA_PianoGameplaySetting";

		// Token: 0x0401E9B3 RID: 125363
		public const int PIANO_GAMEPLAY_QTE_COUNT = 3;

		// Token: 0x0401E9B4 RID: 125364
		public const float PIANO_GAMEPLAY_LERP_SPEED = 0.0005f;

		// Token: 0x0401E9B5 RID: 125365
		public const float PIANO_GAMEPLAY_REFERENCE_ASPECT_RATIO = 1.7777778f;

		// Token: 0x0401E9B6 RID: 125366
		public const string PIANO_GAMEPLAY_RTPC_VALUE = "level_3_8_piano_volume";

		// Token: 0x0401E9B7 RID: 125367
		public const string PIANO_GAMEPLAY_QTE_SUCCESS_EVENT_NAME = "play_sfx_gp_pianist_qte";

		// Token: 0x0401E9B8 RID: 125368
		public const string PIANO_GAMEPLAY_SPLITE_SCREEN_EVENT_NAME = "play_sfx_gp_pianist_scenewhoosh";
	}
}
