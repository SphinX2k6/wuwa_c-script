using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Season
{
	// Token: 0x02004C7D RID: 19581
	[NullableContext(1)]
	[Nullable(0)]
	public static class SeasonDefine
	{
		// Token: 0x060329B6 RID: 207286 RVA: 0x00BCCE58 File Offset: 0x00BCB058
		public static double GetSeasonTimelineValue(ESeason season)
		{
			switch (season)
			{
			case ESeason.Spring:
				return 0.25;
			case ESeason.Summer:
				return 0.5;
			case ESeason.Autumn:
				return 0.75;
			case ESeason.Winter:
				return 0.0;
			default:
				return 0.0;
			}
		}

		// Token: 0x060329B7 RID: 207287 RVA: 0x00BCCEAE File Offset: 0x00BCB0AE
		public static ESeason GetNextSeasonInLoop(ESeason season)
		{
			switch (season)
			{
			case ESeason.Spring:
				return ESeason.Summer;
			case ESeason.Summer:
				return ESeason.Autumn;
			case ESeason.Autumn:
				return ESeason.Winter;
			case ESeason.Winter:
				return ESeason.Spring;
			default:
				return ESeason.Spring;
			}
		}

		// Token: 0x060329B8 RID: 207288 RVA: 0x00BCCED4 File Offset: 0x00BCB0D4
		public static string FormatSeason(ESeason season)
		{
			switch (season)
			{
			case ESeason.Spring:
				return "春";
			case ESeason.Summer:
				return "夏";
			case ESeason.Autumn:
				return "秋";
			case ESeason.Winter:
				return "冬";
			default:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
				defaultInterpolatedStringHandler.AppendLiteral("未知(");
				defaultInterpolatedStringHandler.AppendFormatted<ESeason>(season);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			}
		}

		// Token: 0x060329B9 RID: 207289 RVA: 0x00BCCF41 File Offset: 0x00BCB141
		public static string GetSeasonAudioName(ESeason season)
		{
			switch (season)
			{
			case ESeason.Spring:
				return "spring";
			case ESeason.Summer:
				return "summer";
			case ESeason.Autumn:
				return "autumn";
			case ESeason.Winter:
				return "winter";
			default:
				return "winter";
			}
		}

		// Token: 0x060329BA RID: 207290 RVA: 0x00BCCF78 File Offset: 0x00BCB178
		public static string FormatLoopPhase(ESeasonLoopPhase phase)
		{
			if (phase == ESeasonLoopPhase.Hold)
			{
				return "Hold";
			}
			if (phase != ESeasonLoopPhase.Transition)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
				defaultInterpolatedStringHandler.AppendLiteral("未知(");
				defaultInterpolatedStringHandler.AppendFormatted<ESeasonLoopPhase>(phase);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			return "Transition";
		}

		// Token: 0x060329BB RID: 207291 RVA: 0x00BCCFCC File Offset: 0x00BCB1CC
		public static string FormatDriverPhase(ESeasonDriverPhase phase)
		{
			switch (phase)
			{
			case ESeasonDriverPhase.Idle:
				return "Idle";
			case ESeasonDriverPhase.Looping:
				return "Looping";
			case ESeasonDriverPhase.Switching:
				return "Switching";
			default:
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(4, 1);
				defaultInterpolatedStringHandler.AppendLiteral("未知(");
				defaultInterpolatedStringHandler.AppendFormatted<ESeasonDriverPhase>(phase);
				defaultInterpolatedStringHandler.AppendLiteral(")");
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			}
		}

		// Token: 0x0401AECD RID: 110285
		public const string SeasonMpcPath = "/Game/Aki/Render/Shaders/Scene/Interaction/MPC_SceneInteraction.MPC_SceneInteraction";

		// Token: 0x0401AECE RID: 110286
		public const string SeasonTimelineParamName = "SeasonTransitionTimeLine";

		// Token: 0x0401AECF RID: 110287
		public const string SeasonAudioStateGroup = "game_scene_season";

		// Token: 0x0401AED0 RID: 110288
		public const string SeasonAudioRtpc = "season_mpc_value";
	}
}
