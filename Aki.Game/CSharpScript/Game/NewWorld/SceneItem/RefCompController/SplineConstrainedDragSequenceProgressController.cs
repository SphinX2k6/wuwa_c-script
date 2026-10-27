using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;
using CSharpScript.Game.LevelGamePlay.StaticScene;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.RefCompController
{
	// Token: 0x020071B6 RID: 29110
	public class SplineConstrainedDragSequenceProgressController : ISequenceProgressController
	{
		// Token: 0x060473CB RID: 291787 RVA: 0x0121C488 File Offset: 0x0121A688
		public void SetSequenceProgress(float progress)
		{
			if (this.SimpleSequenceActor == null)
			{
				return;
			}
			UMovieSceneSequencePlayer player = this.SimpleSequenceActor.GetPlayer();
			if (player == null || !player.IsValid())
			{
				return;
			}
			if (this.CachedTotalSeconds <= 0f)
			{
				return;
			}
			float num = Math.Max(0f, Math.Min(1f, progress));
			float time = this.CachedStartSeconds + num * this.CachedTotalSeconds;
			FMovieSceneSequencePlaybackParams playbackPosition = new FMovieSceneSequencePlaybackParams(new FFrameTime(), time, "", EMovieScenePositionType.Time, EUpdatePositionMethod.Jump);
			player.SetPlaybackPosition(playbackPosition);
		}

		// Token: 0x060473CC RID: 291788 RVA: 0x0121C50A File Offset: 0x0121A70A
		public void Destroy()
		{
			if (this.SimpleSequenceActor != null)
			{
				this.SimpleSequenceActor.Clear();
			}
			this.SimpleSequenceActor = null;
			if (this.HasAcquiredForbidEvalDisable)
			{
				SplineConstrainedDragModel.Instance.ReleaseForbidEvalDisable();
				this.HasAcquiredForbidEvalDisable = false;
			}
		}

		// Token: 0x060473CD RID: 291789 RVA: 0x0121C540 File Offset: 0x0121A740
		[NullableContext(1)]
		public void OnSequenceLoaded([Nullable(2)] ULevelSequence data, string path)
		{
			if (data == null || !data.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.XDW;
				string message = "[SplineConstrainedDragSequenceProgressController] Sequence 加载失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Path", path);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			if (this.SimpleSequenceActor == null)
			{
				this.SimpleSequenceActor = new SimpleLevelSequenceActor(data);
			}
			else
			{
				this.SimpleSequenceActor.SetSequenceData(data);
			}
			this.SimpleSequenceActor.UpdateSettings(new bool?(true));
			this.SimpleSequenceActor.SetOriginTransform();
			UMovieSceneSequencePlayer player = this.SimpleSequenceActor.GetPlayer();
			if (player == null || !player.IsValid())
			{
				return;
			}
			FQualifiedFrameTime startTime = player.GetStartTime();
			FQualifiedFrameTime endTime = player.GetEndTime();
			this.CachedStartSeconds = ((float)startTime.Time.FrameNumber.Value + startTime.Time.SubFrame) * (float)startTime.Rate.Denominator / (float)startTime.Rate.Numerator;
			float num = ((float)endTime.Time.FrameNumber.Value + endTime.Time.SubFrame) * (float)endTime.Rate.Denominator / (float)endTime.Rate.Numerator;
			this.CachedTotalSeconds = num - this.CachedStartSeconds;
			if (!this.HasAcquiredForbidEvalDisable)
			{
				SplineConstrainedDragModel.Instance.AcquireForbidEvalDisable();
				this.HasAcquiredForbidEvalDisable = true;
			}
			player.Play();
			player.SetPlayRate(0f);
		}

		// Token: 0x0402576E RID: 153454
		private float CachedStartSeconds;

		// Token: 0x0402576F RID: 153455
		private float CachedTotalSeconds;

		// Token: 0x04025770 RID: 153456
		private bool HasAcquiredForbidEvalDisable;

		// Token: 0x04025771 RID: 153457
		[Nullable(2)]
		private SimpleLevelSequenceActor SimpleSequenceActor;
	}
}
