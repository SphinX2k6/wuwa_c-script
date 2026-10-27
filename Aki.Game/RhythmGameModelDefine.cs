using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02001088 RID: 4232
[NullableContext(1)]
[Nullable(0)]
public static class RhythmGameModelDefine
{
	// Token: 0x040032D9 RID: 13017
	[StaticVariableRuleIgnore]
	public static IReadOnlyDictionary<EKuroRhythmGameRating, string> RhythmGameHitResultTexture = new Dictionary<EKuroRhythmGameRating, string>
	{
		{
			EKuroRhythmGameRating.Perfect,
			"T_RhythmGamePerfect"
		},
		{
			EKuroRhythmGameRating.Great,
			"T_RhythmGameGreat"
		},
		{
			EKuroRhythmGameRating.Good,
			"T_RhythmGameGood"
		},
		{
			EKuroRhythmGameRating.Bad,
			"T_RhythmGameBad"
		},
		{
			EKuroRhythmGameRating.Miss,
			"T_RhythmGameMiss"
		},
		{
			EKuroRhythmGameRating.EKuroRhythmGameRating_MAX,
			""
		}
	};

	// Token: 0x040032DA RID: 13018
	public const string RHYTHM_GAME_TUNNEL_LINE_HIT_EFFECT = "/Game/Aki/Effect/DataAsset/Niagara/Scene/3_2/3_2YinYou/DA_FX_Yinyou_Rectangle_Sparks_02.DA_FX_Yinyou_Rectangle_Sparks_02";

	// Token: 0x040032DB RID: 13019
	[StaticVariableRuleIgnore]
	private static IReadOnlyDictionary<string, string> RhythmGameHitEffectPath = new Dictionary<string, string>
	{
		{
			"IconBurstSparks01",
			"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Icon_Burst_Sparks_01.DA_Fx_Group_Yinyou_Icon_Burst_Sparks_01"
		},
		{
			"IconBurstSparks02",
			"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Icon_Burst_Sparks_02.DA_Fx_Group_Yinyou_Icon_Burst_Sparks_02"
		},
		{
			"IconBurstSparks03",
			"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Icon_Burst_Sparks_03.DA_Fx_Group_Yinyou_Icon_Burst_Sparks_03"
		},
		{
			"IconCylind",
			"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Icon_Cylind.DA_Fx_Group_Yinyou_Icon_Cylind"
		},
		{
			"IconCylindB",
			"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Icon_Cylind_B.DA_Fx_Group_Yinyou_Icon_Cylind_B"
		},
		{
			"IconCylindW",
			"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Icon_Cylind_W.DA_Fx_Group_Yinyou_Icon_Cylind_W"
		},
		{
			"RectangleSparks",
			"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Rectangle_Sparks_01.DA_Fx_Group_Yinyou_Rectangle_Sparks_01"
		},
		{
			"ChuanYue",
			"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_SYinyou_ChuanYue_02.DA_Fx_Group_SYinyou_ChuanYue_02"
		},
		{
			"BurstSparksG",
			"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Burst_Sparks_G.DA_Fx_Group_Yinyou_Burst_Sparks_G"
		},
		{
			"BurstSparksB",
			"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Burst_Sparks_B.DA_Fx_Group_Yinyou_Burst_Sparks_B"
		},
		{
			"BurstSparksW",
			"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Burst_Sparks_W.DA_Fx_Group_Yinyou_Burst_Sparks_W"
		}
	};

	// Token: 0x040032DC RID: 13020
	[StaticVariableRuleIgnore]
	private static IReadOnlyList<string> EffectGroupA = new <>z__ReadOnlyArray<string>(new string[]
	{
		RhythmGameModelDefine.RhythmGameHitEffectPath["IconBurstSparks02"],
		RhythmGameModelDefine.RhythmGameHitEffectPath["IconCylind"]
	});

	// Token: 0x040032DD RID: 13021
	[StaticVariableRuleIgnore]
	private static IReadOnlyList<string> EffectGroupB = new <>z__ReadOnlyArray<string>(new string[]
	{
		RhythmGameModelDefine.RhythmGameHitEffectPath["IconBurstSparks01"],
		RhythmGameModelDefine.RhythmGameHitEffectPath["IconCylindB"]
	});

	// Token: 0x040032DE RID: 13022
	[StaticVariableRuleIgnore]
	private static IReadOnlyList<string> EffectGroupC = new <>z__ReadOnlyArray<string>(new string[]
	{
		RhythmGameModelDefine.RhythmGameHitEffectPath["IconBurstSparks03"],
		RhythmGameModelDefine.RhythmGameHitEffectPath["IconCylindW"]
	});

	// Token: 0x040032DF RID: 13023
	[StaticVariableRuleIgnore]
	private static IReadOnlyList<string> EffectGroupLine = new <>z__ReadOnlySingleElementList<string>(RhythmGameModelDefine.RhythmGameHitEffectPath["RectangleSparks"]);

	// Token: 0x040032E0 RID: 13024
	[StaticVariableRuleIgnore]
	private static IReadOnlyList<string> EffectGroupHit = new <>z__ReadOnlySingleElementList<string>(RhythmGameModelDefine.RhythmGameHitEffectPath["ChuanYue"]);

	// Token: 0x040032E1 RID: 13025
	[StaticVariableRuleIgnore]
	public static IReadOnlyDictionary<EKuroRhythmGameNoteType, IReadOnlyList<string>> RhythmGameHitResultEffect = new Dictionary<EKuroRhythmGameNoteType, IReadOnlyList<string>>
	{
		{
			EKuroRhythmGameNoteType.None,
			Array.Empty<string>()
		},
		{
			EKuroRhythmGameNoteType.KuroTapA,
			RhythmGameModelDefine.EffectGroupA
		},
		{
			EKuroRhythmGameNoteType.KuroTapB,
			RhythmGameModelDefine.EffectGroupB
		},
		{
			EKuroRhythmGameNoteType.KuroTapLeft,
			RhythmGameModelDefine.EffectGroupC
		},
		{
			EKuroRhythmGameNoteType.KuroTapRight,
			RhythmGameModelDefine.EffectGroupC
		},
		{
			EKuroRhythmGameNoteType.KuroFlickLeft,
			RhythmGameModelDefine.EffectGroupC
		},
		{
			EKuroRhythmGameNoteType.KuroFlickRight,
			RhythmGameModelDefine.EffectGroupC
		},
		{
			EKuroRhythmGameNoteType.Kuro3DFlickLeft,
			Array.Empty<string>()
		},
		{
			EKuroRhythmGameNoteType.Kuro3DFlickRight,
			Array.Empty<string>()
		},
		{
			EKuroRhythmGameNoteType.KuroLine,
			RhythmGameModelDefine.EffectGroupLine
		},
		{
			EKuroRhythmGameNoteType.KuroLineHold,
			RhythmGameModelDefine.EffectGroupLine
		},
		{
			EKuroRhythmGameNoteType.KuroLineHit,
			RhythmGameModelDefine.EffectGroupHit
		},
		{
			EKuroRhythmGameNoteType.KuroEvent,
			Array.Empty<string>()
		},
		{
			EKuroRhythmGameNoteType.EKuroRhythmGameNoteType_MAX,
			Array.Empty<string>()
		}
	};

	// Token: 0x040032E2 RID: 13026
	[StaticVariableRuleIgnore]
	public static IReadOnlyDictionary<EKuroRhythmGameNoteType, string> RhythmGameHitResultExternalEffect = new Dictionary<EKuroRhythmGameNoteType, string>
	{
		{
			EKuroRhythmGameNoteType.None,
			""
		},
		{
			EKuroRhythmGameNoteType.KuroTapA,
			RhythmGameModelDefine.RhythmGameHitEffectPath["BurstSparksG"]
		},
		{
			EKuroRhythmGameNoteType.KuroTapB,
			RhythmGameModelDefine.RhythmGameHitEffectPath["BurstSparksB"]
		},
		{
			EKuroRhythmGameNoteType.KuroTapLeft,
			RhythmGameModelDefine.RhythmGameHitEffectPath["BurstSparksW"]
		},
		{
			EKuroRhythmGameNoteType.KuroTapRight,
			RhythmGameModelDefine.RhythmGameHitEffectPath["BurstSparksW"]
		},
		{
			EKuroRhythmGameNoteType.KuroFlickLeft,
			RhythmGameModelDefine.RhythmGameHitEffectPath["BurstSparksW"]
		},
		{
			EKuroRhythmGameNoteType.KuroFlickRight,
			RhythmGameModelDefine.RhythmGameHitEffectPath["BurstSparksW"]
		},
		{
			EKuroRhythmGameNoteType.Kuro3DFlickLeft,
			""
		},
		{
			EKuroRhythmGameNoteType.Kuro3DFlickRight,
			""
		},
		{
			EKuroRhythmGameNoteType.KuroLine,
			""
		},
		{
			EKuroRhythmGameNoteType.KuroLineHold,
			""
		},
		{
			EKuroRhythmGameNoteType.KuroLineHit,
			""
		},
		{
			EKuroRhythmGameNoteType.KuroEvent,
			""
		},
		{
			EKuroRhythmGameNoteType.EKuroRhythmGameNoteType_MAX,
			""
		}
	};

	// Token: 0x040032E3 RID: 13027
	[StaticVariableRuleIgnore]
	public static IReadOnlyList<string> RhythmGameLockIconEffect = new <>z__ReadOnlyArray<string>(new string[]
	{
		"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Suoding_01.DA_Fx_Group_Yinyou_Suoding_01",
		"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Suoding_02.DA_Fx_Group_Yinyou_Suoding_02",
		"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Suoding_03.DA_Fx_Group_Yinyou_Suoding_03"
	});

	// Token: 0x040032E4 RID: 13028
	[StaticVariableRuleIgnore]
	public static IReadOnlyList<string> RhythmGameHighSpeedEffect = new <>z__ReadOnlySingleElementList<string>("/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_LineScreen.DA_Fx_Group_Yinyou_LineScreen");

	// Token: 0x040032E5 RID: 13029
	[StaticVariableRuleIgnore]
	public static IReadOnlyList<string> RhythmGameFeverEffect = new <>z__ReadOnlyArray<string>(new string[]
	{
		"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Screen.DA_Fx_Group_Yinyou_Screen",
		"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_SpeedLine.DA_Fx_Group_SpeedLine"
	});

	// Token: 0x040032E6 RID: 13030
	public const string RHYTHM_GAME_START_EFFECT = "/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Start.DA_Fx_Group_Start";

	// Token: 0x040032E7 RID: 13031
	public const string RHYTHM_GAME_SPARKS_LINE_EFFECT = "/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_SparkLine.DA_Fx_Group_SparkLine";

	// Token: 0x040032E8 RID: 13032
	public const string RHYTHM_GAME_FIREWORKS_EFFECT = "/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Sparks.DA_Fx_Group_Sparks";

	// Token: 0x040032E9 RID: 13033
	public const string RHYTHM_GAME_START_TRAIL_EFFECT = "/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_StartTrail.DA_Fx_Group_StartTrail";

	// Token: 0x040032EA RID: 13034
	public const string RHYTHM_GAME_HIT_EVENT_NAME = "play_ui_rhythmship_gamenote_normal";

	// Token: 0x040032EB RID: 13035
	public const string RHYTHM_GAME_LINE_EVENT_NAME = "play_ui_rhythmship_gamenote_line";

	// Token: 0x040032EC RID: 13036
	public const string RHYTHM_GAME_LINE_HOLD_EVENT_NAME = "play_ui_rhythmship_gamenote_line_loop";

	// Token: 0x040032ED RID: 13037
	public const string RHYTHM_GAME_LINE_HIT_EVENT_NAME = "play_ui_rhythmship_gamenote_air";

	// Token: 0x040032EE RID: 13038
	public const string RHYTHM_GAME_FLICK_EVENT_NAME = "play_ui_rhythmship_gamenote_spin";

	// Token: 0x040032EF RID: 13039
	public const string RHYTHM_GAME_FEVER_LOOP_EVENT_NAME = "play_ui_rhythmship_gamefever_start_loop";

	// Token: 0x040032F0 RID: 13040
	public const string RHYTHM_GAME_FEVER_END_EVENT_NAME = "play_ui_rhythmship_gamefever_end";

	// Token: 0x040032F1 RID: 13041
	public const string RHYTHM_GAME_SPEED_UP_EVENT_NAME = "play_ui_rhythmship_gamespeedlevel_up";

	// Token: 0x040032F2 RID: 13042
	public const string RHYTHM_GAME_SPEED_DOWN_EVENT_NAME = "play_ui_rhythmship_gamespeedlevel_down";

	// Token: 0x040032F3 RID: 13043
	public const string RHYTHM_GAME_FIREWORKS_EVENT_NAME = "play_ui_rhythmship_gamefirework";

	// Token: 0x040032F4 RID: 13044
	public const string RHYTHM_GAME_END_TIP_SSS_EVENT_NAME = "play_ui_rhythmship_success_sss";

	// Token: 0x040032F5 RID: 13045
	public const string RHYTHM_GAME_END_TIP_NORMAL_EVENT_NAME = "play_ui_rhythmship_success_normal";

	// Token: 0x040032F6 RID: 13046
	public const string RHYTHM_GAME_START_EVENT_NAME = "play_ui_rhythmship_gameship_start";
}
