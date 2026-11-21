using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.StaticScene.Preprocessor;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.RefCompController
{
	// Token: 0x02006266 RID: 25190
	[NullableContext(2)]
	[Nullable(0)]
	public class ManualSequencePlayer
	{
		// Token: 0x0603CC84 RID: 248964 RVA: 0x01173EFC File Offset: 0x011720FC
		[NullableContext(1)]
		public bool Init(ULevelSequence sequence, bool enableCenterOffset, [Nullable(2)] IFloatingSubtitleLanguageDiff preprocessOperation = null)
		{
			if (this.SequenceActor != null && this.Sequence == sequence)
			{
				if (enableCenterOffset)
				{
					this.ApplyCenterOffset();
				}
				else
				{
					this.ClearCenterOffset();
				}
				this.CacheStartEndSeconds();
				return true;
			}
			this.Release();
			this.Sequence = sequence;
			this.SequenceActor = (ActorSystem.Instance.Get(ALevelSequenceActor.StaticClass(), new FTransformDouble(), null, false) as ALevelSequenceActor);
			if (this.SequenceActor == null)
			{
				global::Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CK, "[ManualSequencePlayer] 获取 LevelSequenceActor 失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			LevelSequencePreprocessHelper.Instance.Apply(sequence, preprocessOperation);
			this.SequenceActor.SetSequence(sequence);
			ULevelSequencePlayer sequencePlayer = this.SequenceActor.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Play();
				sequencePlayer.SetPlayRate(0f);
				sequencePlayer.Pause();
			}
			if (enableCenterOffset)
			{
				this.ApplyCenterOffset();
			}
			else
			{
				this.ClearCenterOffset();
			}
			this.CacheStartEndSeconds();
			return true;
		}

		// Token: 0x0603CC85 RID: 248965 RVA: 0x01173FE0 File Offset: 0x011721E0
		public void SetPositionBySeconds(float seconds, EUpdatePositionMethod method)
		{
			ALevelSequenceActor sequenceActor = this.SequenceActor;
			ULevelSequencePlayer ulevelSequencePlayer = (sequenceActor != null) ? sequenceActor.SequencePlayer : null;
			if (ulevelSequencePlayer == null)
			{
				return;
			}
			FMovieSceneSequencePlaybackParams playbackPosition = new FMovieSceneSequencePlaybackParams
			{
				Time = seconds,
				PositionType = EMovieScenePositionType.Time,
				UpdateMethod = method
			};
			ulevelSequencePlayer.SetPlaybackPosition(playbackPosition);
		}

		// Token: 0x0603CC86 RID: 248966 RVA: 0x01174028 File Offset: 0x01172228
		[NullableContext(1)]
		public float? GetMarkTimeInSeconds(string mark)
		{
			if (this.Sequence == null)
			{
				return null;
			}
			return SequenceDriveHelper.GetMarkTimeInSeconds(this.Sequence, mark);
		}

		// Token: 0x0603CC87 RID: 248967 RVA: 0x01174054 File Offset: 0x01172254
		public float GetCurrentSeconds()
		{
			ALevelSequenceActor sequenceActor = this.SequenceActor;
			ULevelSequencePlayer ulevelSequencePlayer = (sequenceActor != null) ? sequenceActor.SequencePlayer : null;
			if (ulevelSequencePlayer == null)
			{
				return 0f;
			}
			FQualifiedFrameTime currentTime = ulevelSequencePlayer.GetCurrentTime();
			return ((float)currentTime.Time.FrameNumber.Value + currentTime.Time.SubFrame) * (float)currentTime.Rate.Denominator / (float)currentTime.Rate.Numerator;
		}

		// Token: 0x0603CC88 RID: 248968 RVA: 0x011740BB File Offset: 0x011722BB
		public float GetStartSeconds()
		{
			return this.CachedStartSeconds;
		}

		// Token: 0x0603CC89 RID: 248969 RVA: 0x011740C3 File Offset: 0x011722C3
		public float GetEndSeconds()
		{
			return this.CachedEndSeconds;
		}

		// Token: 0x0603CC8A RID: 248970 RVA: 0x011740CB File Offset: 0x011722CB
		public UMovieSceneSequencePlayer GetPlayer()
		{
			ALevelSequenceActor sequenceActor = this.SequenceActor;
			if (sequenceActor == null)
			{
				return null;
			}
			return sequenceActor.SequencePlayer;
		}

		// Token: 0x0603CC8B RID: 248971 RVA: 0x011740DE File Offset: 0x011722DE
		public ALevelSequenceActor GetSequenceActor()
		{
			return this.SequenceActor;
		}

		// Token: 0x0603CC8C RID: 248972 RVA: 0x011740E6 File Offset: 0x011722E6
		public bool HasActor()
		{
			return this.SequenceActor != null;
		}

		// Token: 0x0603CC8D RID: 248973 RVA: 0x011740F4 File Offset: 0x011722F4
		public void Release()
		{
			if (this.SequenceActor != null)
			{
				ULevelSequencePlayer sequencePlayer = this.SequenceActor.SequencePlayer;
				if (sequencePlayer != null)
				{
					sequencePlayer.Stop();
				}
				ALevelSequenceActor sequenceActor = this.SequenceActor;
				TimerSystem.Instance.Next(delegate(float _)
				{
					ActorSystem.Instance.Put("ManualSequencePlayer.Release", sequenceActor, null);
				}, null, null);
				this.SequenceActor = null;
			}
			this.Sequence = null;
		}

		// Token: 0x0603CC8E RID: 248974 RVA: 0x01174158 File Offset: 0x01172358
		private void CacheStartEndSeconds()
		{
			ALevelSequenceActor sequenceActor = this.SequenceActor;
			ULevelSequencePlayer ulevelSequencePlayer = (sequenceActor != null) ? sequenceActor.SequencePlayer : null;
			if (ulevelSequencePlayer == null)
			{
				this.CachedStartSeconds = 0f;
				this.CachedEndSeconds = 0f;
				return;
			}
			FQualifiedFrameTime startTime = ulevelSequencePlayer.GetStartTime();
			FQualifiedFrameTime endTime = ulevelSequencePlayer.GetEndTime();
			this.CachedStartSeconds = ((float)startTime.Time.FrameNumber.Value + startTime.Time.SubFrame) * (float)startTime.Rate.Denominator / (float)startTime.Rate.Numerator;
			this.CachedEndSeconds = ((float)endTime.Time.FrameNumber.Value + endTime.Time.SubFrame) * (float)endTime.Rate.Denominator / (float)endTime.Rate.Numerator;
		}

		// Token: 0x0603CC8F RID: 248975 RVA: 0x0117421C File Offset: 0x0117241C
		private void ApplyCenterOffset()
		{
			if (this.SequenceActor == null)
			{
				return;
			}
			FVectorDouble fvectorDouble = new FVectorDouble();
			ULevelSequence sequence = this.SequenceActor.GetSequence();
			if (!((sequence != null) ? new bool?(sequence.D_GetCenterOffset(ref fvectorDouble)) : null).GetValueOrDefault())
			{
				fvectorDouble.Set(0.0, 0.0, 0.0);
			}
			this.SequenceActor.bOverrideInstanceData = true;
			UObject defaultInstanceData = this.SequenceActor.DefaultInstanceData;
			if (defaultInstanceData != null && defaultInstanceData.IsA(UDefaultLevelSequenceInstanceData.StaticClass()))
			{
				UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = this.SequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
				FVector fvector = fvectorDouble.ToVector();
				udefaultLevelSequenceInstanceData.TransformOrigin = new FTransform(ref fvector);
				return;
			}
			global::Log.Instance.Warn(ELogModule.SceneItem, ELogAuthor.CK, "[ManualSequencePlayer] DefaultInstanceData 缺失或类型不符, 中心偏移未写入", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0603CC90 RID: 248976 RVA: 0x011742F8 File Offset: 0x011724F8
		private void ClearCenterOffset()
		{
			if (this.SequenceActor == null)
			{
				return;
			}
			FVectorDouble fvectorDouble = new FVectorDouble();
			fvectorDouble.Set(0.0, 0.0, 0.0);
			this.SequenceActor.bOverrideInstanceData = false;
			UObject defaultInstanceData = this.SequenceActor.DefaultInstanceData;
			if (defaultInstanceData != null && defaultInstanceData.IsA(UDefaultLevelSequenceInstanceData.StaticClass()))
			{
				UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = this.SequenceActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
				FVector fvector = fvectorDouble.ToVector();
				udefaultLevelSequenceInstanceData.TransformOrigin = new FTransform(ref fvector);
			}
		}

		// Token: 0x040203AC RID: 132012
		private float CachedEndSeconds;

		// Token: 0x040203AD RID: 132013
		private float CachedStartSeconds;

		// Token: 0x040203AE RID: 132014
		private ULevelSequence Sequence;

		// Token: 0x040203AF RID: 132015
		private ALevelSequenceActor SequenceActor;
	}
}
