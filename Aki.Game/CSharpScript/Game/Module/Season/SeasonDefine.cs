using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Season
{
	// Token: 0x02003C2E RID: 15406
	[NullableContext(1)]
	[Nullable(0)]
	public static class SeasonDefine
	{
		// Token: 0x06027769 RID: 161641 RVA: 0x00B11ABC File Offset: 0x00B0FCBC
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

		// Token: 0x0602776A RID: 161642 RVA: 0x00B11B12 File Offset: 0x00B0FD12
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

		// Token: 0x0602776B RID: 161643 RVA: 0x00B11B38 File Offset: 0x00B0FD38
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

		// Token: 0x0602776C RID: 161644 RVA: 0x00B11BA5 File Offset: 0x00B0FDA5
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

		// Token: 0x0602776D RID: 161645 RVA: 0x00B11BDC File Offset: 0x00B0FDDC
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

		// Token: 0x0602776E RID: 161646 RVA: 0x00B11C30 File Offset: 0x00B0FE30
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

		// Token: 0x0401582A RID: 88106
		public const string SeasonMpcPath = "/Game/Aki/Render/Shaders/Scene/Interaction/MPC_SceneInteraction.MPC_SceneInteraction";

		// Token: 0x0401582B RID: 88107
		public const string SeasonTimelineParamName = "SeasonTransitionTimeLine";

		// Token: 0x0401582C RID: 88108
		public const string SeasonAudioStateGroup = "game_scene_season";

		// Token: 0x0401582D RID: 88109
		public const string SeasonAudioRtpc = "season_mpc_value";
	}
}
