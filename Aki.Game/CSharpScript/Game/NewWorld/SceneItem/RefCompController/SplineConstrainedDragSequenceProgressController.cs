using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag.Interface;
using CSharpScript.Game.LevelGamePlay.StaticScene;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.RefCompController
{
	// Token: 0x0200626B RID: 25195
	public class SplineConstrainedDragSequenceProgressController : ISequenceProgressController
	{
		// Token: 0x0603CCC6 RID: 249030 RVA: 0x0117638C File Offset: 0x0117458C
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
			FMovieSceneSequencePlaybackParams playbackPosition = new FMovieSceneSequencePlaybackParams
			{
				Time = time,
				PositionType = EMovieScenePositionType.Time,
				UpdateMethod = EUpdatePositionMethod.Jump
			};
			player.SetPlaybackPosition(playbackPosition);
		}

		// Token: 0x0603CCC7 RID: 249031 RVA: 0x01176416 File Offset: 0x01174616
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

		// Token: 0x0603CCC8 RID: 249032 RVA: 0x0117644C File Offset: 0x0117464C
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

		// Token: 0x040203DD RID: 132061
		private float CachedStartSeconds;

		// Token: 0x040203DE RID: 132062
		private float CachedTotalSeconds;

		// Token: 0x040203DF RID: 132063
		private bool HasAcquiredForbidEvalDisable;

		// Token: 0x040203E0 RID: 132064
		[Nullable(2)]
		private SimpleLevelSequenceActor SimpleSequenceActor;
	}
}
