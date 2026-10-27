using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.StaticScene.Preprocessor;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.RefCompController
{
	// Token: 0x020071B1 RID: 29105
	[NullableContext(2)]
	[Nullable(0)]
	public class ManualSequencePlayer
	{
		// Token: 0x06047389 RID: 291721 RVA: 0x01219FF8 File Offset: 0x012181F8
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

		// Token: 0x0604738A RID: 291722 RVA: 0x0121A0DC File Offset: 0x012182DC
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

		// Token: 0x0604738B RID: 291723 RVA: 0x0121A124 File Offset: 0x01218324
		[NullableContext(1)]
		public float? GetMarkTimeInSeconds(string mark)
		{
			if (this.Sequence == null)
			{
				return null;
			}
			return SequenceDriveHelper.GetMarkTimeInSeconds(this.Sequence, mark);
		}

		// Token: 0x0604738C RID: 291724 RVA: 0x0121A150 File Offset: 0x01218350
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

		// Token: 0x0604738D RID: 291725 RVA: 0x0121A1B7 File Offset: 0x012183B7
		public float GetStartSeconds()
		{
			return this.CachedStartSeconds;
		}

		// Token: 0x0604738E RID: 291726 RVA: 0x0121A1BF File Offset: 0x012183BF
		public float GetEndSeconds()
		{
			return this.CachedEndSeconds;
		}

		// Token: 0x0604738F RID: 291727 RVA: 0x0121A1C7 File Offset: 0x012183C7
		public UMovieSceneSequencePlayer GetPlayer()
		{
			ALevelSequenceActor sequenceActor = this.SequenceActor;
			if (sequenceActor == null)
			{
				return null;
			}
			return sequenceActor.SequencePlayer;
		}

		// Token: 0x06047390 RID: 291728 RVA: 0x0121A1DA File Offset: 0x012183DA
		public ALevelSequenceActor GetSequenceActor()
		{
			return this.SequenceActor;
		}

		// Token: 0x06047391 RID: 291729 RVA: 0x0121A1E2 File Offset: 0x012183E2
		public bool HasActor()
		{
			return this.SequenceActor != null;
		}

		// Token: 0x06047392 RID: 291730 RVA: 0x0121A1F0 File Offset: 0x012183F0
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

		// Token: 0x06047393 RID: 291731 RVA: 0x0121A254 File Offset: 0x01218454
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

		// Token: 0x06047394 RID: 291732 RVA: 0x0121A318 File Offset: 0x01218518
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

		// Token: 0x06047395 RID: 291733 RVA: 0x0121A3F4 File Offset: 0x012185F4
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

		// Token: 0x0402573D RID: 153405
		private float CachedEndSeconds;

		// Token: 0x0402573E RID: 153406
		private float CachedStartSeconds;

		// Token: 0x0402573F RID: 153407
		private ULevelSequence Sequence;

		// Token: 0x04025740 RID: 153408
		private ALevelSequenceActor SequenceActor;
	}
}
