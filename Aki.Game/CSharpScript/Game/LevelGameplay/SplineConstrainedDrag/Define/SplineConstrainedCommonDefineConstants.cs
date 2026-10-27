using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define
{
	// Token: 0x02006A3E RID: 27198
	[NullableContext(1)]
	[Nullable(0)]
	public class SplineConstrainedCommonDefineConstants : IStaticVariableResetter
	{
		// Token: 0x06043A93 RID: 277139 RVA: 0x0108D380 File Offset: 0x0108B580
		private static int GetMagneticCoarseSampleCountByQuality(EGameQualitySettingLevel level)
		{
			int result;
			switch (level)
			{
			case EGameQualitySettingLevel.VeryLow:
				result = 16;
				break;
			case EGameQualitySettingLevel.Low:
				result = 20;
				break;
			case EGameQualitySettingLevel.Middle:
				result = 28;
				break;
			case EGameQualitySettingLevel.High:
				result = 36;
				break;
			case EGameQualitySettingLevel.VeryHigh:
				result = 48;
				break;
			case EGameQualitySettingLevel.Highest:
				result = 64;
				break;
			default:
				<PrivateImplementationDetails>.ThrowSwitchExpressionException(level);
				break;
			}
			return result;
		}

		// Token: 0x06043A94 RID: 277140 RVA: 0x0108D3D7 File Offset: 0x0108B5D7
		static SplineConstrainedCommonDefineConstants()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SplineConstrainedCommonDefineConstants.CreateStaticDefaultValue), new Action(SplineConstrainedCommonDefineConstants.ResetStaticDefaultValue));
		}

		// Token: 0x06043A95 RID: 277141 RVA: 0x0108D3F8 File Offset: 0x0108B5F8
		public static void CreateStaticDefaultValue()
		{
			SplineConstrainedCommonDefineConstants.magneticCoarseSampleCountByQuality = new Dictionary<EGameQualitySettingLevel, int>();
			foreach (object obj in Enum.GetValues(typeof(EGameQualitySettingLevel)))
			{
				EGameQualitySettingLevel egameQualitySettingLevel = (EGameQualitySettingLevel)obj;
				SplineConstrainedCommonDefineConstants.magneticCoarseSampleCountByQuality[egameQualitySettingLevel] = SplineConstrainedCommonDefineConstants.GetMagneticCoarseSampleCountByQuality(egameQualitySettingLevel);
			}
		}

		// Token: 0x06043A96 RID: 277142 RVA: 0x0108D470 File Offset: 0x0108B670
		public static void ResetStaticDefaultValue()
		{
			SplineConstrainedCommonDefineConstants.magneticCoarseSampleCountByQuality = null;
		}

		// Token: 0x040234F4 RID: 144628
		public const string DEBUG_KEY = "SplineConstrainedDrag";

		// Token: 0x040234F5 RID: 144629
		public const int DEBUG_DRAW_SEGMENTS = 16;

		// Token: 0x040234F6 RID: 144630
		public const int DEBUG_DRAW_DURATION = 0;

		// Token: 0x040234F7 RID: 144631
		public const int DEBUG_MAGNETIC_SPHERE_RADIUS = 20;

		// Token: 0x040234F8 RID: 144632
		public const int DEBUG_TEXT_VERTICAL_OFFSET = 80;

		// Token: 0x040234F9 RID: 144633
		public const int GAMEPAD_AXIS_TO_PIXEL_PER_SECOND = 800;

		// Token: 0x040234FA RID: 144634
		public const float GAMEPAD_AXIS_DEADZONE = 0.05f;

		// Token: 0x040234FB RID: 144635
		public const float DRAGGABLE_SELECTED_MOVING_SPEED_THRESHOLD = 0.1f;

		// Token: 0x040234FC RID: 144636
		public const float DRAGGABLE_MOVING_LATCH_RELEASE_DELAY_SECONDS = 0.2f;

		// Token: 0x040234FD RID: 144637
		public const int MAGNETIC_TIMER_INTERVAL_MS = 20;

		// Token: 0x040234FE RID: 144638
		public const float MIN_ACTOR_SCREEN_PX = 1f;

		// Token: 0x040234FF RID: 144639
		public const int MAX_SCREEN_DEGENERATE_FRAMES = 5;

		// Token: 0x04023500 RID: 144640
		public const float MAX_STEP_SECONDS = 0.033333335f;

		// Token: 0x04023501 RID: 144641
		public const float CONVERGE_SPEED_THRESHOLD = 0.01f;

		// Token: 0x04023502 RID: 144642
		public const float CONVERGE_POS_THRESHOLD = 0.5f;

		// Token: 0x04023503 RID: 144643
		public const int MAGNETIC_STIFFNESS = 50;

		// Token: 0x04023504 RID: 144644
		public const int MAGNETIC_DAMPING = 10;

		// Token: 0x04023505 RID: 144645
		public const int MAGNETIC_BUFFER_CAPACITY = 128;

		// Token: 0x04023506 RID: 144646
		public static Dictionary<EGameQualitySettingLevel, int> magneticCoarseSampleCountByQuality;

		// Token: 0x04023507 RID: 144647
		public const double MAGNETIC_COARSE_SAMPLE_MIN_DISTANCE = 0.5;

		// Token: 0x04023508 RID: 144648
		public const string DRAGGABLE_STATE_PARAM_NAME_STATE1 = "EnableState1";

		// Token: 0x04023509 RID: 144649
		public const string DRAGGABLE_STATE_PARAM_NAME_STATE2 = "EnableState2";

		// Token: 0x0402350A RID: 144650
		public const string DRAGGABLE_STATE_PARAM_NAME_STATE3 = "EnableState3";

		// Token: 0x0402350B RID: 144651
		public const string DRAG_ACTOR_PLAY_GUIDE_ID_KEY = "DragActorPlayGuideGroupId";

		// Token: 0x0402350C RID: 144652
		public const int DEFAULT_DRAG_ACTOR_PLAY_GUIDE_ID = 10001;
	}
}
