using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.RefCompController
{
	// Token: 0x02006270 RID: 25200
	public class SequenceDriveHelper
	{
		// Token: 0x0603CCF8 RID: 249080 RVA: 0x0117809C File Offset: 0x0117629C
		public static float GetNominalFrameSeconds()
		{
			float frameSeconds = GameSettingsDeviceRender.Instance.FrameSeconds;
			if (!float.IsFinite(frameSeconds) || frameSeconds <= 0f)
			{
				return 0.016666668f;
			}
			return frameSeconds;
		}

		// Token: 0x0603CCF9 RID: 249081 RVA: 0x011780CC File Offset: 0x011762CC
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

		// Token: 0x0603CCFA RID: 249082 RVA: 0x01178128 File Offset: 0x01176328
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

		// Token: 0x040203F2 RID: 132082
		public const float SEQUENCE_TIME_EPSILON = 0.001f;

		// Token: 0x040203F3 RID: 132083
		public const float MIN_STEP_FRAME_RATIO = 0.5f;

		// Token: 0x040203F4 RID: 132084
		public const float MAX_STEP_FRAME_RATIO = 3f;

		// Token: 0x040203F5 RID: 132085
		public const int DEFAULT_NOMINAL_FRAME_RATE = 60;

		// Token: 0x040203F6 RID: 132086
		public const float DEFAULT_NOMINAL_FRAME_SECONDS = 0.016666668f;
	}
}
