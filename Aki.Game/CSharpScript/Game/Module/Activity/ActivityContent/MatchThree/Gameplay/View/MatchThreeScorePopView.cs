using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.View
{
	// Token: 0x020064E1 RID: 25825
	public class MatchThreeScorePopView : UiPanelBase
	{
		// Token: 0x06040D4E RID: 265550 RVA: 0x00FB43D8 File Offset: 0x00FB25D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06040D4F RID: 265551 RVA: 0x00FB4462 File Offset: 0x00FB2662
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.ScoreTween = new LguiIntTween();
			this.ScoreTween.BindUpdateTween(new Action<int>(this.SetScoreText));
		}

		// Token: 0x06040D50 RID: 265552 RVA: 0x00FB4498 File Offset: 0x00FB2698
		public bool SetContent(int score, ScoreComment? comment, int gradeLevel, bool animate)
		{
			if (animate && this.DisplayedScore != score)
			{
				LguiIntTween scoreTween = this.ScoreTween;
				if (scoreTween != null)
				{
					scoreTween.PlayTween(this.DisplayedScore, score, 0.3f, null);
				}
			}
			else
			{
				LguiIntTween scoreTween2 = this.ScoreTween;
				if (scoreTween2 != null)
				{
					scoreTween2.KillTween();
				}
				this.SetScoreText(score);
			}
			this.DisplayedScore = score;
			this.ApplyCommentColor(comment);
			if (gradeLevel <= this.CurrentGradeLevel)
			{
				return false;
			}
			bool result = this.CurrentGradeLevel > 0;
			this.CurrentGradeLevel = gradeLevel;
			return result;
		}

		// Token: 0x06040D51 RID: 265553 RVA: 0x00FB4514 File Offset: 0x00FB2714
		private void SetScoreText(int value)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("+");
			defaultInterpolatedStringHandler.AppendFormatted<int>(value);
			string newText = defaultInterpolatedStringHandler.ToStringAndClear();
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetText(newText, true);
			}
			UUIText text2 = base.GetText(1);
			if (text2 != null)
			{
				text2.SetText(newText, true);
			}
			UUIText text3 = base.GetText(2);
			if (text3 == null)
			{
				return;
			}
			text3.SetText(newText, true);
		}

		// Token: 0x06040D52 RID: 265554 RVA: 0x00FB4584 File Offset: 0x00FB2784
		private void ApplyCommentColor(ScoreComment? comment)
		{
			if (comment == null)
			{
				return;
			}
			ScoreComment value = comment.Value;
			if (!string.IsNullOrEmpty(value.Color1))
			{
				UUIText text = base.GetText(1);
				if (text != null)
				{
					text.SetColor(FColor.FromHex(value.Color1));
				}
			}
			if (!string.IsNullOrEmpty(value.Color2))
			{
				UUIText text2 = base.GetText(2);
				if (text2 == null)
				{
					return;
				}
				text2.SetColor(FColor.FromHex(value.Color2));
			}
		}

		// Token: 0x06040D53 RID: 265555 RVA: 0x00FB45F8 File Offset: 0x00FB27F8
		public UniTask PlayGradeSequenceAsync(int gradeLevel)
		{
			MatchThreeScorePopView.<PlayGradeSequenceAsync>d__11 <PlayGradeSequenceAsync>d__;
			<PlayGradeSequenceAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayGradeSequenceAsync>d__.<>4__this = this;
			<PlayGradeSequenceAsync>d__.gradeLevel = gradeLevel;
			<PlayGradeSequenceAsync>d__.<>1__state = -1;
			<PlayGradeSequenceAsync>d__.<>t__builder.Start<MatchThreeScorePopView.<PlayGradeSequenceAsync>d__11>(ref <PlayGradeSequenceAsync>d__);
			return <PlayGradeSequenceAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D54 RID: 265556 RVA: 0x00FB4643 File Offset: 0x00FB2843
		[NullableContext(1)]
		private string GetGradeSequenceName(int gradeLevel)
		{
			switch (gradeLevel)
			{
			case 2:
				return "Start2";
			case 3:
				return "Start3";
			case 4:
				return "Start4";
			default:
				return "Start";
			}
		}

		// Token: 0x06040D55 RID: 265557 RVA: 0x00FB4674 File Offset: 0x00FB2874
		protected override UniTask OnShowAsyncImplementImplement()
		{
			MatchThreeScorePopView.<OnShowAsyncImplementImplement>d__13 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<MatchThreeScorePopView.<OnShowAsyncImplementImplement>d__13>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06040D56 RID: 265558 RVA: 0x00FB46B8 File Offset: 0x00FB28B8
		protected override UniTask OnBeforeHideAsync()
		{
			MatchThreeScorePopView.<OnBeforeHideAsync>d__14 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<MatchThreeScorePopView.<OnBeforeHideAsync>d__14>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06040D57 RID: 265559 RVA: 0x00FB46FB File Offset: 0x00FB28FB
		protected override void OnBeforeDestroy()
		{
			LguiIntTween scoreTween = this.ScoreTween;
			if (scoreTween != null)
			{
				scoreTween.Destroy();
			}
			this.ScoreTween = null;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x04021C63 RID: 138339
		private const float ScoreTweenDuration = 0.3f;

		// Token: 0x04021C64 RID: 138340
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04021C65 RID: 138341
		[Nullable(2)]
		private LguiIntTween ScoreTween;

		// Token: 0x04021C66 RID: 138342
		private int DisplayedScore;

		// Token: 0x04021C67 RID: 138343
		private int CurrentGradeLevel;

		// Token: 0x0200C71D RID: 50973
		private enum EComponent
		{
			// Token: 0x0403C27D RID: 246397
			TextOutline,
			// Token: 0x0403C27E RID: 246398
			TextTop,
			// Token: 0x0403C27F RID: 246399
			TextBottom
		}
	}
}
