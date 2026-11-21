using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200053C RID: 1340
[NullableContext(1)]
[Nullable(0)]
public static class RhythmGameModelDefine
{
	// Token: 0x04003372 RID: 13170
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

	// Token: 0x04003373 RID: 13171
	public const string RHYTHM_GAME_TUNNEL_LINE_HIT_EFFECT = "/Game/Aki/Effect/DataAsset/Niagara/Scene/3_2/3_2YinYou/DA_FX_Yinyou_Rectangle_Sparks_02.DA_FX_Yinyou_Rectangle_Sparks_02";

	// Token: 0x04003374 RID: 13172
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

	// Token: 0x04003375 RID: 13173
	[StaticVariableRuleIgnore]
	private static IReadOnlyList<string> EffectGroupA = new <>z__ReadOnlyArray<string>(new string[]
	{
		RhythmGameModelDefine.RhythmGameHitEffectPath["IconBurstSparks02"],
		RhythmGameModelDefine.RhythmGameHitEffectPath["IconCylind"]
	});

	// Token: 0x04003376 RID: 13174
	[StaticVariableRuleIgnore]
	private static IReadOnlyList<string> EffectGroupB = new <>z__ReadOnlyArray<string>(new string[]
	{
		RhythmGameModelDefine.RhythmGameHitEffectPath["IconBurstSparks01"],
		RhythmGameModelDefine.RhythmGameHitEffectPath["IconCylindB"]
	});

	// Token: 0x04003377 RID: 13175
	[StaticVariableRuleIgnore]
	private static IReadOnlyList<string> EffectGroupC = new <>z__ReadOnlyArray<string>(new string[]
	{
		RhythmGameModelDefine.RhythmGameHitEffectPath["IconBurstSparks03"],
		RhythmGameModelDefine.RhythmGameHitEffectPath["IconCylindW"]
	});

	// Token: 0x04003378 RID: 13176
	[StaticVariableRuleIgnore]
	private static IReadOnlyList<string> EffectGroupLine = new <>z__ReadOnlySingleElementList<string>(RhythmGameModelDefine.RhythmGameHitEffectPath["RectangleSparks"]);

	// Token: 0x04003379 RID: 13177
	[StaticVariableRuleIgnore]
	private static IReadOnlyList<string> EffectGroupHit = new <>z__ReadOnlySingleElementList<string>(RhythmGameModelDefine.RhythmGameHitEffectPath["ChuanYue"]);

	// Token: 0x0400337A RID: 13178
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

	// Token: 0x0400337B RID: 13179
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

	// Token: 0x0400337C RID: 13180
	[StaticVariableRuleIgnore]
	public static IReadOnlyList<string> RhythmGameLockIconEffect = new <>z__ReadOnlyArray<string>(new string[]
	{
		"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Suoding_01.DA_Fx_Group_Yinyou_Suoding_01",
		"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Suoding_02.DA_Fx_Group_Yinyou_Suoding_02",
		"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Suoding_03.DA_Fx_Group_Yinyou_Suoding_03"
	});

	// Token: 0x0400337D RID: 13181
	[StaticVariableRuleIgnore]
	public static IReadOnlyList<string> RhythmGameHighSpeedEffect = new <>z__ReadOnlySingleElementList<string>("/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_LineScreen.DA_Fx_Group_Yinyou_LineScreen");

	// Token: 0x0400337E RID: 13182
	[StaticVariableRuleIgnore]
	public static IReadOnlyList<string> RhythmGameFeverEffect = new <>z__ReadOnlyArray<string>(new string[]
	{
		"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Yinyou_Screen.DA_Fx_Group_Yinyou_Screen",
		"/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_SpeedLine.DA_Fx_Group_SpeedLine"
	});

	// Token: 0x0400337F RID: 13183
	public const string RHYTHM_GAME_START_EFFECT = "/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Start.DA_Fx_Group_Start";

	// Token: 0x04003380 RID: 13184
	public const string RHYTHM_GAME_SPARKS_LINE_EFFECT = "/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_SparkLine.DA_Fx_Group_SparkLine";

	// Token: 0x04003381 RID: 13185
	public const string RHYTHM_GAME_FIREWORKS_EFFECT = "/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_Sparks.DA_Fx_Group_Sparks";

	// Token: 0x04003382 RID: 13186
	public const string RHYTHM_GAME_START_TRAIL_EFFECT = "/Game/Aki/Effect/EffectGroup/Scenes/3_2/3_2YinYou/DA_Fx_Group_StartTrail.DA_Fx_Group_StartTrail";

	// Token: 0x04003383 RID: 13187
	public const string RHYTHM_GAME_HIT_EVENT_NAME = "play_ui_rhythmship_gamenote_normal";

	// Token: 0x04003384 RID: 13188
	public const string RHYTHM_GAME_LINE_EVENT_NAME = "play_ui_rhythmship_gamenote_line";

	// Token: 0x04003385 RID: 13189
	public const string RHYTHM_GAME_LINE_HOLD_EVENT_NAME = "play_ui_rhythmship_gamenote_line_loop";

	// Token: 0x04003386 RID: 13190
	public const string RHYTHM_GAME_LINE_HIT_EVENT_NAME = "play_ui_rhythmship_gamenote_air";

	// Token: 0x04003387 RID: 13191
	public const string RHYTHM_GAME_FLICK_EVENT_NAME = "play_ui_rhythmship_gamenote_spin";

	// Token: 0x04003388 RID: 13192
	public const string RHYTHM_GAME_FEVER_LOOP_EVENT_NAME = "play_ui_rhythmship_gamefever_start_loop";

	// Token: 0x04003389 RID: 13193
	public const string RHYTHM_GAME_FEVER_END_EVENT_NAME = "play_ui_rhythmship_gamefever_end";

	// Token: 0x0400338A RID: 13194
	public const string RHYTHM_GAME_SPEED_UP_EVENT_NAME = "play_ui_rhythmship_gamespeedlevel_up";

	// Token: 0x0400338B RID: 13195
	public const string RHYTHM_GAME_SPEED_DOWN_EVENT_NAME = "play_ui_rhythmship_gamespeedlevel_down";

	// Token: 0x0400338C RID: 13196
	public const string RHYTHM_GAME_FIREWORKS_EVENT_NAME = "play_ui_rhythmship_gamefirework";

	// Token: 0x0400338D RID: 13197
	public const string RHYTHM_GAME_END_TIP_SSS_EVENT_NAME = "play_ui_rhythmship_success_sss";

	// Token: 0x0400338E RID: 13198
	public const string RHYTHM_GAME_END_TIP_NORMAL_EVENT_NAME = "play_ui_rhythmship_success_normal";

	// Token: 0x0400338F RID: 13199
	public const string RHYTHM_GAME_START_EVENT_NAME = "play_ui_rhythmship_gameship_start";
}
