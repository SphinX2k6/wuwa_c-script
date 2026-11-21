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
	// Token: 0x0200545F RID: 21599
	public class MatchThreeScorePopView : UiPanelBase
	{
		// Token: 0x06035A12 RID: 219666 RVA: 0x00EFB408 File Offset: 0x00EF9608
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

		// Token: 0x06035A13 RID: 219667 RVA: 0x00EFB492 File Offset: 0x00EF9692
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.ScoreTween = new LguiIntTween();
			this.ScoreTween.BindUpdateTween(new Action<int>(this.SetScoreText));
		}

		// Token: 0x06035A14 RID: 219668 RVA: 0x00EFB4C8 File Offset: 0x00EF96C8
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

		// Token: 0x06035A15 RID: 219669 RVA: 0x00EFB544 File Offset: 0x00EF9744
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

		// Token: 0x06035A16 RID: 219670 RVA: 0x00EFB5B4 File Offset: 0x00EF97B4
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

		// Token: 0x06035A17 RID: 219671 RVA: 0x00EFB628 File Offset: 0x00EF9828
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

		// Token: 0x06035A18 RID: 219672 RVA: 0x00EFB673 File Offset: 0x00EF9873
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

		// Token: 0x06035A19 RID: 219673 RVA: 0x00EFB6A4 File Offset: 0x00EF98A4
		protected override UniTask OnShowAsyncImplementImplement()
		{
			MatchThreeScorePopView.<OnShowAsyncImplementImplement>d__13 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<MatchThreeScorePopView.<OnShowAsyncImplementImplement>d__13>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x06035A1A RID: 219674 RVA: 0x00EFB6E8 File Offset: 0x00EF98E8
		protected override UniTask OnBeforeHideAsync()
		{
			MatchThreeScorePopView.<OnBeforeHideAsync>d__14 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<MatchThreeScorePopView.<OnBeforeHideAsync>d__14>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035A1B RID: 219675 RVA: 0x00EFB72B File Offset: 0x00EF992B
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

		// Token: 0x0401C594 RID: 116116
		private const float ScoreTweenDuration = 0.3f;

		// Token: 0x0401C595 RID: 116117
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401C596 RID: 116118
		[Nullable(2)]
		private LguiIntTween ScoreTween;

		// Token: 0x0401C597 RID: 116119
		private int DisplayedScore;

		// Token: 0x0401C598 RID: 116120
		private int CurrentGradeLevel;

		// Token: 0x0200B103 RID: 45315
		private enum EComponent
		{
			// Token: 0x04036BD8 RID: 224216
			TextOutline,
			// Token: 0x04036BD9 RID: 224217
			TextTop,
			// Token: 0x04036BDA RID: 224218
			TextBottom
		}
	}
}
