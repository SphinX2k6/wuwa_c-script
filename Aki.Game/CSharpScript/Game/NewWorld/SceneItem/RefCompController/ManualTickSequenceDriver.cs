using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.RefCompController
{
	// Token: 0x02006267 RID: 25191
	[NullableContext(1)]
	[Nullable(0)]
	public class ManualTickSequenceDriver
	{
		// Token: 0x0603CC92 RID: 248978 RVA: 0x0117438D File Offset: 0x0117258D
		public bool IsPlaying()
		{
			return this.IsMoving;
		}

		// Token: 0x0603CC93 RID: 248979 RVA: 0x01174395 File Offset: 0x01172595
		[NullableContext(2)]
		public ALevelSequenceActor GetSequenceActor()
		{
			return this.Player.GetSequenceActor();
		}

		// Token: 0x0603CC94 RID: 248980 RVA: 0x011743A2 File Offset: 0x011725A2
		public float? GetMarkTimeInSeconds(string mark)
		{
			return this.Player.GetMarkTimeInSeconds(mark);
		}

		// Token: 0x0603CC95 RID: 248981 RVA: 0x011743B0 File Offset: 0x011725B0
		public float GetCurrentSeconds()
		{
			return this.Player.GetCurrentSeconds();
		}

		// Token: 0x0603CC96 RID: 248982 RVA: 0x011743C0 File Offset: 0x011725C0
		public void Play(ULevelSequence sequence, PlayLevelSequence config, bool jumpToEnd = false, [Nullable(2)] Action onStopped = null)
		{
			if (!this.Player.Init(sequence, config.IsEnableCenterOffset.GetValueOrDefault(), config.PreprocessOperation))
			{
				return;
			}
			this.OnStopped = onStopped;
			this.RateAbs = MathF.Abs(config.Rate.GetValueOrDefault(1f));
			this.RateIsNegative = (config.Rate.GetValueOrDefault(1f) < 0f);
			this.SeqPlayedSeconds = this.Player.GetCurrentSeconds();
			this.SeqAccumulatedSeconds = 0f;
			this.IsLoop = false;
			this.IsWrapping = false;
			TPlayMode? tplayMode;
			if (jumpToEnd && ((config.PlayMode != null) ? tplayMode.GetValueOrDefault().ToEnumString() : null) != EPlayLevelSequenceType.Loop.ToEnumString())
			{
				this.SetupInstant(config.Mark);
				return;
			}
			this.SetupByPlayMode(config);
		}

		// Token: 0x0603CC97 RID: 248983 RVA: 0x011744A4 File Offset: 0x011726A4
		[NullableContext(2)]
		private void SetupInstant(string mark)
		{
			float? num = this.ResolveMarkSeconds(mark);
			if (num == null)
			{
				this.SetStopped();
				return;
			}
			this.SeqPlayedSeconds = num.Value;
			this.SeqTargetSeconds = num.Value;
			this.Player.SetPositionBySeconds(num.Value, EUpdatePositionMethod.Jump);
			this.SetStopped();
		}

		// Token: 0x0603CC98 RID: 248984 RVA: 0x011744FC File Offset: 0x011726FC
		private void SetupByPlayMode(PlayLevelSequence config)
		{
			string mark = config.Mark;
			TPlayMode? tplayMode;
			string a = (config.PlayMode != null) ? tplayMode.GetValueOrDefault().ToEnumString() : null;
			if (a == EPlayLevelSequenceType.Instant.ToEnumString())
			{
				this.SetupInstant(mark);
				return;
			}
			if (a == EPlayLevelSequenceType.Loop.ToEnumString())
			{
				this.SetupLoop(config);
				return;
			}
			if (a == EPlayLevelSequenceType.ShortestPath.ToEnumString())
			{
				float? num = this.ResolveMarkSeconds(mark);
				if (num == null)
				{
					this.SetStopped();
					return;
				}
				this.SetupShortestPath(num.Value);
				this.IsMoving = true;
				return;
			}
			else
			{
				float? num2 = this.ResolveMarkSeconds(mark);
				if (num2 == null)
				{
					this.SetStopped();
					return;
				}
				this.SeqTargetSeconds = num2.Value;
				this.IsMoving = true;
				return;
			}
		}

		// Token: 0x0603CC99 RID: 248985 RVA: 0x011745C4 File Offset: 0x011727C4
		private unsafe void SetupLoop(PlayLevelSequence config)
		{
			this.IsLoop = true;
			ILoopRange loopRange = config.LoopRange;
			if (!string.IsNullOrEmpty((loopRange != null) ? loopRange.LeftMark : null) && !string.IsNullOrEmpty(config.LoopRange.RightMark))
			{
				float? markTimeInSeconds = this.Player.GetMarkTimeInSeconds(config.LoopRange.LeftMark);
				float? markTimeInSeconds2 = this.Player.GetMarkTimeInSeconds(config.LoopRange.RightMark);
				if (markTimeInSeconds == null || markTimeInSeconds2 == null)
				{
					global::Log instance = global::Log.Instance;
					ELogModule module = ELogModule.SceneItem;
					ELogAuthor author = ELogAuthor.CK;
					string message = "[ManualTickSequenceDriver] Loop 区间 Mark 非法, 跳过播放";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("LeftMark", config.LoopRange.LeftMark);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("RightMark", config.LoopRange.RightMark);
					instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					this.IsLoop = false;
					this.SetStopped();
					return;
				}
				this.LoopStartSeconds = MathF.Min(markTimeInSeconds.Value, markTimeInSeconds2.Value);
				this.LoopEndSeconds = MathF.Max(markTimeInSeconds.Value, markTimeInSeconds2.Value);
			}
			else
			{
				this.LoopStartSeconds = this.Player.GetStartSeconds();
				this.LoopEndSeconds = this.Player.GetEndSeconds();
			}
			this.SeqPlayedSeconds = (this.RateIsNegative ? this.LoopEndSeconds : this.LoopStartSeconds);
			this.Player.SetPositionBySeconds(this.SeqPlayedSeconds, EUpdatePositionMethod.Jump);
			this.IsMoving = true;
		}

		// Token: 0x0603CC9A RID: 248986 RVA: 0x0117474C File Offset: 0x0117294C
		private void SetupShortestPath(float targetSeconds)
		{
			float num = this.Player.GetEndSeconds() - this.Player.GetStartSeconds();
			float num2 = MathF.Abs(targetSeconds - this.SeqPlayedSeconds);
			if (num - num2 >= num2 - 0.001f || num <= 0.001f)
			{
				this.IsWrapping = false;
				this.SeqTargetSeconds = targetSeconds;
				return;
			}
			this.IsWrapping = true;
			this.WrapFinalTargetSeconds = targetSeconds;
			if (targetSeconds > this.SeqPlayedSeconds)
			{
				this.SeqTargetSeconds = this.Player.GetStartSeconds();
				return;
			}
			this.SeqTargetSeconds = this.Player.GetEndSeconds();
		}

		// Token: 0x0603CC9B RID: 248987 RVA: 0x011747DC File Offset: 0x011729DC
		[NullableContext(2)]
		private float? ResolveMarkSeconds(string mark)
		{
			if (string.IsNullOrEmpty(mark))
			{
				global::Log.Instance.Error(ELogModule.SceneItem, ELogAuthor.CK, "[ManualTickSequenceDriver] Mark 为空, 跳过播放", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
			float? markTimeInSeconds = this.Player.GetMarkTimeInSeconds(mark);
			if (markTimeInSeconds == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[ManualTickSequenceDriver] Mark 配置非法, 跳过播放";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Mark", mark);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			return markTimeInSeconds;
		}

		// Token: 0x0603CC9C RID: 248988 RVA: 0x01174860 File Offset: 0x01172A60
		public void Tick(float deltaMs)
		{
			if (!this.IsMoving || !this.Player.HasActor())
			{
				return;
			}
			float num = deltaMs * 0.001f * this.CustomTimeDilation;
			if (num <= 0f)
			{
				return;
			}
			float num2 = num * this.RateAbs;
			if (num2 <= 0f)
			{
				return;
			}
			if (this.IsLoop)
			{
				this.TickLoop(num2);
				return;
			}
			this.TickToTarget(num2);
		}

		// Token: 0x0603CC9D RID: 248989 RVA: 0x011748C4 File Offset: 0x01172AC4
		private void TickToTarget(float advance)
		{
			float num = MathF.Abs(this.SeqTargetSeconds - this.SeqPlayedSeconds);
			if (advance + 0.001f >= num)
			{
				this.SeqPlayedSeconds = this.SeqTargetSeconds;
				this.SeqAccumulatedSeconds = 0f;
				this.Player.SetPositionBySeconds(this.SeqPlayedSeconds, EUpdatePositionMethod.Play);
				this.OnReachTarget();
				return;
			}
			ClampStepResult clampStepResult = SequenceDriveHelper.ClampStep(advance, this.SeqAccumulatedSeconds, num);
			this.SeqAccumulatedSeconds = clampStepResult.NextAccumulated;
			if (clampStepResult.Step == null)
			{
				return;
			}
			float? num2 = clampStepResult.Step + 0.001f;
			float num3 = num;
			if (num2.GetValueOrDefault() >= num3 & num2 != null)
			{
				this.SeqPlayedSeconds = this.SeqTargetSeconds;
			}
			else
			{
				int num4 = (this.SeqTargetSeconds > this.SeqPlayedSeconds) ? 1 : -1;
				this.SeqPlayedSeconds += clampStepResult.Step.Value * (float)num4;
			}
			this.Player.SetPositionBySeconds(this.SeqPlayedSeconds, EUpdatePositionMethod.Play);
		}

		// Token: 0x0603CC9E RID: 248990 RVA: 0x011749F0 File Offset: 0x01172BF0
		private void OnReachTarget()
		{
			if (this.IsWrapping)
			{
				this.IsWrapping = false;
				float num = (this.SeqTargetSeconds >= this.Player.GetEndSeconds() - 0.001f) ? this.Player.GetStartSeconds() : this.Player.GetEndSeconds();
				this.SeqPlayedSeconds = num;
				this.SeqTargetSeconds = this.WrapFinalTargetSeconds;
				this.SeqAccumulatedSeconds = 0f;
				this.Player.SetPositionBySeconds(num, EUpdatePositionMethod.Jump);
				if (MathF.Abs(this.SeqPlayedSeconds - this.SeqTargetSeconds) <= 0.001f)
				{
					this.SetStopped();
				}
				return;
			}
			this.SetStopped();
		}

		// Token: 0x0603CC9F RID: 248991 RVA: 0x01174A94 File Offset: 0x01172C94
		private void TickLoop(float advance)
		{
			ClampStepResult clampStepResult = SequenceDriveHelper.ClampStep(advance, this.SeqAccumulatedSeconds, float.MaxValue);
			this.SeqAccumulatedSeconds = clampStepResult.NextAccumulated;
			if (clampStepResult.Step == null)
			{
				return;
			}
			float num = this.LoopEndSeconds - this.LoopStartSeconds;
			if (num <= 0.001f)
			{
				return;
			}
			if (this.RateIsNegative)
			{
				float num2 = this.SeqPlayedSeconds - clampStepResult.Step.Value;
				if (num2 < this.LoopStartSeconds)
				{
					this.Player.SetPositionBySeconds(this.LoopStartSeconds, EUpdatePositionMethod.Play);
					float num3 = (this.LoopStartSeconds - num2) % num;
					this.Player.SetPositionBySeconds(this.LoopEndSeconds, EUpdatePositionMethod.Jump);
					num2 = this.LoopEndSeconds - num3;
					this.SeqPlayedSeconds = num2;
					this.Player.SetPositionBySeconds(num2, EUpdatePositionMethod.Play);
					return;
				}
				this.SeqPlayedSeconds = num2;
				this.Player.SetPositionBySeconds(num2, EUpdatePositionMethod.Play);
				return;
			}
			else
			{
				float num4 = this.SeqPlayedSeconds + clampStepResult.Step.Value;
				if (num4 > this.LoopEndSeconds)
				{
					this.Player.SetPositionBySeconds(this.LoopEndSeconds, EUpdatePositionMethod.Play);
					float num5 = (num4 - this.LoopEndSeconds) % num;
					this.Player.SetPositionBySeconds(this.LoopStartSeconds, EUpdatePositionMethod.Jump);
					num4 = this.LoopStartSeconds + num5;
					this.SeqPlayedSeconds = num4;
					this.Player.SetPositionBySeconds(num4, EUpdatePositionMethod.Play);
					return;
				}
				this.SeqPlayedSeconds = num4;
				this.Player.SetPositionBySeconds(num4, EUpdatePositionMethod.Play);
				return;
			}
		}

		// Token: 0x0603CCA0 RID: 248992 RVA: 0x01174C03 File Offset: 0x01172E03
		public void SetTimeDilation(float timeDilation)
		{
			this.CustomTimeDilation = timeDilation;
		}

		// Token: 0x0603CCA1 RID: 248993 RVA: 0x01174C0C File Offset: 0x01172E0C
		private void SetStopped()
		{
			this.IsMoving = false;
			Action onStopped = this.OnStopped;
			this.OnStopped = null;
			if (onStopped == null)
			{
				return;
			}
			onStopped();
		}

		// Token: 0x0603CCA2 RID: 248994 RVA: 0x01174C2C File Offset: 0x01172E2C
		public void Stop()
		{
			this.OnStopped = null;
			this.IsMoving = false;
		}

		// Token: 0x0603CCA3 RID: 248995 RVA: 0x01174C3C File Offset: 0x01172E3C
		public void Release()
		{
			this.Stop();
			this.IsLoop = false;
			this.IsWrapping = false;
			this.RateIsNegative = false;
			this.SeqAccumulatedSeconds = 0f;
			this.Player.Release();
		}

		// Token: 0x040203B0 RID: 132016
		private readonly ManualSequencePlayer Player = new ManualSequencePlayer();

		// Token: 0x040203B1 RID: 132017
		private float CustomTimeDilation = 1f;

		// Token: 0x040203B2 RID: 132018
		private bool IsMoving;

		// Token: 0x040203B3 RID: 132019
		[Nullable(2)]
		private Action OnStopped;

		// Token: 0x040203B4 RID: 132020
		private float RateAbs = 1f;

		// Token: 0x040203B5 RID: 132021
		private bool RateIsNegative;

		// Token: 0x040203B6 RID: 132022
		private float SeqAccumulatedSeconds;

		// Token: 0x040203B7 RID: 132023
		private float SeqPlayedSeconds;

		// Token: 0x040203B8 RID: 132024
		private float SeqTargetSeconds;

		// Token: 0x040203B9 RID: 132025
		private bool IsLoop;

		// Token: 0x040203BA RID: 132026
		private float LoopStartSeconds;

		// Token: 0x040203BB RID: 132027
		private float LoopEndSeconds;

		// Token: 0x040203BC RID: 132028
		private bool IsWrapping;

		// Token: 0x040203BD RID: 132029
		private float WrapFinalTargetSeconds;
	}
}
