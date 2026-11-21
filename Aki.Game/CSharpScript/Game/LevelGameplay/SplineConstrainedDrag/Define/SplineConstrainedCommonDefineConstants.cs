using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Define
{
	// Token: 0x02005B9B RID: 23451
	[NullableContext(1)]
	[Nullable(0)]
	public class SplineConstrainedCommonDefineConstants : IStaticVariableResetter
	{
		// Token: 0x06039AE1 RID: 236257 RVA: 0x01031B88 File Offset: 0x0102FD88
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

		// Token: 0x06039AE2 RID: 236258 RVA: 0x01031BDF File Offset: 0x0102FDDF
		static SplineConstrainedCommonDefineConstants()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SplineConstrainedCommonDefineConstants.CreateStaticDefaultValue), new Action(SplineConstrainedCommonDefineConstants.ResetStaticDefaultValue));
		}

		// Token: 0x06039AE3 RID: 236259 RVA: 0x01031C00 File Offset: 0x0102FE00
		public static void CreateStaticDefaultValue()
		{
			SplineConstrainedCommonDefineConstants.magneticCoarseSampleCountByQuality = new Dictionary<EGameQualitySettingLevel, int>();
			foreach (object obj in Enum.GetValues(typeof(EGameQualitySettingLevel)))
			{
				EGameQualitySettingLevel egameQualitySettingLevel = (EGameQualitySettingLevel)obj;
				SplineConstrainedCommonDefineConstants.magneticCoarseSampleCountByQuality[egameQualitySettingLevel] = SplineConstrainedCommonDefineConstants.GetMagneticCoarseSampleCountByQuality(egameQualitySettingLevel);
			}
		}

		// Token: 0x06039AE4 RID: 236260 RVA: 0x01031C78 File Offset: 0x0102FE78
		public static void ResetStaticDefaultValue()
		{
			SplineConstrainedCommonDefineConstants.magneticCoarseSampleCountByQuality = null;
		}

		// Token: 0x0401E6E6 RID: 124646
		public const string DEBUG_KEY = "SplineConstrainedDrag";

		// Token: 0x0401E6E7 RID: 124647
		public const int DEBUG_DRAW_SEGMENTS = 16;

		// Token: 0x0401E6E8 RID: 124648
		public const int DEBUG_DRAW_DURATION = 0;

		// Token: 0x0401E6E9 RID: 124649
		public const int DEBUG_MAGNETIC_SPHERE_RADIUS = 20;

		// Token: 0x0401E6EA RID: 124650
		public const int DEBUG_TEXT_VERTICAL_OFFSET = 80;

		// Token: 0x0401E6EB RID: 124651
		public const int GAMEPAD_AXIS_TO_PIXEL_PER_SECOND = 800;

		// Token: 0x0401E6EC RID: 124652
		public const float GAMEPAD_AXIS_DEADZONE = 0.05f;

		// Token: 0x0401E6ED RID: 124653
		public const float DRAGGABLE_SELECTED_MOVING_SPEED_THRESHOLD = 0.1f;

		// Token: 0x0401E6EE RID: 124654
		public const float DRAGGABLE_MOVING_LATCH_RELEASE_DELAY_SECONDS = 0.2f;

		// Token: 0x0401E6EF RID: 124655
		public const int MAGNETIC_TIMER_INTERVAL_MS = 20;

		// Token: 0x0401E6F0 RID: 124656
		public const float MIN_ACTOR_SCREEN_PX = 1f;

		// Token: 0x0401E6F1 RID: 124657
		public const int MAX_SCREEN_DEGENERATE_FRAMES = 5;

		// Token: 0x0401E6F2 RID: 124658
		public const float MAX_STEP_SECONDS = 0.033333335f;

		// Token: 0x0401E6F3 RID: 124659
		public const float CONVERGE_SPEED_THRESHOLD = 0.01f;

		// Token: 0x0401E6F4 RID: 124660
		public const float CONVERGE_POS_THRESHOLD = 0.5f;

		// Token: 0x0401E6F5 RID: 124661
		public const int MAGNETIC_STIFFNESS = 50;

		// Token: 0x0401E6F6 RID: 124662
		public const int MAGNETIC_DAMPING = 10;

		// Token: 0x0401E6F7 RID: 124663
		public const int MAGNETIC_BUFFER_CAPACITY = 128;

		// Token: 0x0401E6F8 RID: 124664
		public static Dictionary<EGameQualitySettingLevel, int> magneticCoarseSampleCountByQuality;

		// Token: 0x0401E6F9 RID: 124665
		public const double MAGNETIC_COARSE_SAMPLE_MIN_DISTANCE = 0.5;

		// Token: 0x0401E6FA RID: 124666
		public const string DRAGGABLE_STATE_PARAM_NAME_STATE1 = "EnableState1";

		// Token: 0x0401E6FB RID: 124667
		public const string DRAGGABLE_STATE_PARAM_NAME_STATE2 = "EnableState2";

		// Token: 0x0401E6FC RID: 124668
		public const string DRAGGABLE_STATE_PARAM_NAME_STATE3 = "EnableState3";

		// Token: 0x0401E6FD RID: 124669
		public const string DRAG_ACTOR_PLAY_GUIDE_ID_KEY = "DragActorPlayGuideGroupId";

		// Token: 0x0401E6FE RID: 124670
		public const int DEFAULT_DRAG_ACTOR_PLAY_GUIDE_ID = 10001;
	}
}
