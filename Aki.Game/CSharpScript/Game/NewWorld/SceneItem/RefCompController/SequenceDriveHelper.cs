using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.RefCompController
{
	// Token: 0x020071BB RID: 29115
	public class SequenceDriveHelper
	{
		// Token: 0x060473FD RID: 291837 RVA: 0x0121E190 File Offset: 0x0121C390
		public static float GetNominalFrameSeconds()
		{
			float frameSeconds = GameSettingsDeviceRender.Instance.FrameSeconds;
			if (!float.IsFinite(frameSeconds) || frameSeconds <= 0f)
			{
				return 0.016666668f;
			}
			return frameSeconds;
		}

		// Token: 0x060473FE RID: 291838 RVA: 0x0121E1C0 File Offset: 0x0121C3C0
		public static ClampStepResult ClampStep(float advance, float accumulated, float remaining)
		{
			float nominalFrameSeconds = SequenceDriveHelper.GetNominalFrameSeconds();
			float num = nominalFrameSeconds * 0.5f;
			float num2 = nominalFrameSeconds * 3f;
			float num3 = accumulated + advance;
			if (num3 < num && num3 + 0.001f < remaining)
			{
				return new ClampStepResult(null, num3);
			}
			return new ClampStepResult(new float?((num3 > num2) ? num2 : num3), 0f);
		}

		// Token: 0x060473FF RID: 291839 RVA: 0x0121E21C File Offset: 0x0121C41C
		[NullableContext(1)]
		public static float? GetMarkTimeInSeconds(ULevelSequence levelSequence, string mark)
		{
			UMovieScene movieScene = levelSequence.GetMovieScene();
			if (movieScene == null)
			{
				return null;
			}
			FFrameRate tickResolution = movieScene.TickResolution;
			if (tickResolution.Numerator == 0)
			{
				return null;
			}
			for (int i = 0; i < movieScene.MarkedFrames.Num(); i++)
			{
				FMovieSceneMarkedFrame fmovieSceneMarkedFrame = movieScene.MarkedFrames.Get(i);
				if (fmovieSceneMarkedFrame.Label == mark)
				{
					return new float?((float)(fmovieSceneMarkedFrame.FrameNumber.Value * tickResolution.Denominator) / (float)tickResolution.Numerator);
				}
			}
			return null;
		}

		// Token: 0x04025783 RID: 153475
		public const float SEQUENCE_TIME_EPSILON = 0.001f;

		// Token: 0x04025784 RID: 153476
		public const float MIN_STEP_FRAME_RATIO = 0.5f;

		// Token: 0x04025785 RID: 153477
		public const float MAX_STEP_FRAME_RATIO = 3f;

		// Token: 0x04025786 RID: 153478
		public const int DEFAULT_NOMINAL_FRAME_RATE = 60;

		// Token: 0x04025787 RID: 153479
		public const float DEFAULT_NOMINAL_FRAME_SECONDS = 0.016666668f;
	}
}
