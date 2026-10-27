using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.RefCompController
{
	// Token: 0x020071B2 RID: 29106
	[NullableContext(1)]
	[Nullable(0)]
	public class ManualTickSequenceDriver
	{
		// Token: 0x06047397 RID: 291735 RVA: 0x0121A489 File Offset: 0x01218689
		public bool IsPlaying()
		{
			return this.IsMoving;
		}

		// Token: 0x06047398 RID: 291736 RVA: 0x0121A491 File Offset: 0x01218691
		[NullableContext(2)]
		public ALevelSequenceActor GetSequenceActor()
		{
			return this.Player.GetSequenceActor();
		}

		// Token: 0x06047399 RID: 291737 RVA: 0x0121A49E File Offset: 0x0121869E
		public float? GetMarkTimeInSeconds(string mark)
		{
			return this.Player.GetMarkTimeInSeconds(mark);
		}

		// Token: 0x0604739A RID: 291738 RVA: 0x0121A4AC File Offset: 0x012186AC
		public float GetCurrentSeconds()
		{
			return this.Player.GetCurrentSeconds();
		}

		// Token: 0x0604739B RID: 291739 RVA: 0x0121A4BC File Offset: 0x012186BC
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

		// Token: 0x0604739C RID: 291740 RVA: 0x0121A5A0 File Offset: 0x012187A0
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

		// Token: 0x0604739D RID: 291741 RVA: 0x0121A5F8 File Offset: 0x012187F8
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

		// Token: 0x0604739E RID: 291742 RVA: 0x0121A6C0 File Offset: 0x012188C0
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

		// Token: 0x0604739F RID: 291743 RVA: 0x0121A848 File Offset: 0x01218A48
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

		// Token: 0x060473A0 RID: 291744 RVA: 0x0121A8D8 File Offset: 0x01218AD8
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

		// Token: 0x060473A1 RID: 291745 RVA: 0x0121A95C File Offset: 0x01218B5C
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

		// Token: 0x060473A2 RID: 291746 RVA: 0x0121A9C0 File Offset: 0x01218BC0
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

		// Token: 0x060473A3 RID: 291747 RVA: 0x0121AAEC File Offset: 0x01218CEC
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

		// Token: 0x060473A4 RID: 291748 RVA: 0x0121AB90 File Offset: 0x01218D90
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

		// Token: 0x060473A5 RID: 291749 RVA: 0x0121ACFF File Offset: 0x01218EFF
		public void SetTimeDilation(float timeDilation)
		{
			this.CustomTimeDilation = timeDilation;
		}

		// Token: 0x060473A6 RID: 291750 RVA: 0x0121AD08 File Offset: 0x01218F08
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

		// Token: 0x060473A7 RID: 291751 RVA: 0x0121AD28 File Offset: 0x01218F28
		public void Stop()
		{
			this.OnStopped = null;
			this.IsMoving = false;
		}

		// Token: 0x060473A8 RID: 291752 RVA: 0x0121AD38 File Offset: 0x01218F38
		public void Release()
		{
			this.Stop();
			this.IsLoop = false;
			this.IsWrapping = false;
			this.RateIsNegative = false;
			this.SeqAccumulatedSeconds = 0f;
			this.Player.Release();
		}

		// Token: 0x04025741 RID: 153409
		private readonly ManualSequencePlayer Player = new ManualSequencePlayer();

		// Token: 0x04025742 RID: 153410
		private float CustomTimeDilation = 1f;

		// Token: 0x04025743 RID: 153411
		private bool IsMoving;

		// Token: 0x04025744 RID: 153412
		[Nullable(2)]
		private Action OnStopped;

		// Token: 0x04025745 RID: 153413
		private float RateAbs = 1f;

		// Token: 0x04025746 RID: 153414
		private bool RateIsNegative;

		// Token: 0x04025747 RID: 153415
		private float SeqAccumulatedSeconds;

		// Token: 0x04025748 RID: 153416
		private float SeqPlayedSeconds;

		// Token: 0x04025749 RID: 153417
		private float SeqTargetSeconds;

		// Token: 0x0402574A RID: 153418
		private bool IsLoop;

		// Token: 0x0402574B RID: 153419
		private float LoopStartSeconds;

		// Token: 0x0402574C RID: 153420
		private float LoopEndSeconds;

		// Token: 0x0402574D RID: 153421
		private bool IsWrapping;

		// Token: 0x0402574E RID: 153422
		private float WrapFinalTargetSeconds;
	}
}
