using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.BigStuffedDoll.View
{
	// Token: 0x02006F5E RID: 28510
	[NullableContext(1)]
	[Nullable(0)]
	public class GameCountDownItem : UiPanelBase
	{
		// Token: 0x060455A7 RID: 284071 RVA: 0x0112A670 File Offset: 0x01128870
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060455A8 RID: 284072 RVA: 0x0112A73C File Offset: 0x0112893C
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.TitleText = base.GetText(0);
			this.TimeText = base.GetText(1);
			this.WhiteColor = new FColor?(FColor.FromHex("FFFFFFFF"));
		}

		// Token: 0x060455A9 RID: 284073 RVA: 0x0112A790 File Offset: 0x01128990
		public UniTask StartCountDown(float time)
		{
			GameCountDownItem.<StartCountDown>d__13 <StartCountDown>d__;
			<StartCountDown>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<StartCountDown>d__.<>4__this = this;
			<StartCountDown>d__.time = time;
			<StartCountDown>d__.<>1__state = -1;
			<StartCountDown>d__.<>t__builder.Start<GameCountDownItem.<StartCountDown>d__13>(ref <StartCountDown>d__);
			return <StartCountDown>d__.<>t__builder.Task;
		}

		// Token: 0x060455AA RID: 284074 RVA: 0x0112A7DC File Offset: 0x011289DC
		public void OnTick(float delta)
		{
			if (BigStuffedDollModel.Instance.GetGameStage() != EGameStage.GamePlaying || !this.EnableCountDown)
			{
				return;
			}
			this.RemainTime -= delta / 1000f;
			if (this.RemainTime <= 10f)
			{
				if (this.LevelSequencePlayer.GetCurrentSequence() != "Loop")
				{
					this.LevelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
				}
			}
			else
			{
				if (this.LevelSequencePlayer.GetCurrentSequence() == "Loop")
				{
					this.LevelSequencePlayer.StopCurrentSequence(false, false);
				}
				UUIText titleText = this.TitleText;
				if (titleText != null)
				{
					titleText.SetColor(this.WhiteColor.Value);
				}
				UUIText timeText = this.TimeText;
				if (timeText != null)
				{
					timeText.SetColor(this.WhiteColor.Value);
				}
				UUIText titleText2 = this.TitleText;
				if (titleText2 != null)
				{
					titleText2.SetUIItemScale(Vector.OneVector);
				}
				UUIText timeText2 = this.TimeText;
				if (timeText2 != null)
				{
					timeText2.SetUIItemScale(Vector.OneVector);
				}
			}
			this.UpdateCountDown(this.RemainTime);
		}

		// Token: 0x060455AB RID: 284075 RVA: 0x0112A8F0 File Offset: 0x01128AF0
		public void UpdateCountDown(float remainTime)
		{
			if (remainTime <= 0f)
			{
				base.GetUiNiagara(2).SetUIActive(false);
				base.GetUiNiagara(3).SetUIActive(false);
				UUIText timeText = this.TimeText;
				if (timeText != null)
				{
					timeText.SetText("00:00:00", true);
				}
				BigStuffedDollModel.Instance.GameResult = false;
				BigStuffedDollModel.Instance.EnterNextGameStage();
				return;
			}
			base.GetUiNiagara(2).SetUIActive(remainTime <= 10f);
			base.GetUiNiagara(3).SetUIActive(remainTime > 10f);
			int num = (int)Math.Floor((double)remainTime % TimeUtil.Instance.Hour / TimeUtil.Instance.Minute);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted((num < 10) ? "0" : "");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			this.MinuteText = defaultInterpolatedStringHandler.ToStringAndClear();
			int num2 = (int)Math.Floor((double)remainTime % TimeUtil.Instance.Minute);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted((num2 < 10) ? "0" : "");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num2);
			this.SecondText = defaultInterpolatedStringHandler.ToStringAndClear();
			int num3 = (int)Math.Floor(((double)remainTime - Math.Floor((double)remainTime)) * 100.0);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted((num3 < 10) ? "0" : "");
			defaultInterpolatedStringHandler.AppendFormatted<int>(num3);
			this.Millisecond = defaultInterpolatedStringHandler.ToStringAndClear();
			UUIText timeText2 = this.TimeText;
			if (timeText2 == null)
			{
				return;
			}
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
			defaultInterpolatedStringHandler.AppendFormatted(this.MinuteText);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(this.SecondText);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(this.Millisecond);
			timeText2.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x040242DF RID: 148191
		private const int ONE_HUNDRED = 100;

		// Token: 0x040242E0 RID: 148192
		private bool EnableCountDown;

		// Token: 0x040242E1 RID: 148193
		private float RemainTime;

		// Token: 0x040242E2 RID: 148194
		private string Millisecond = "";

		// Token: 0x040242E3 RID: 148195
		private string MinuteText = "";

		// Token: 0x040242E4 RID: 148196
		private string SecondText = "";

		// Token: 0x040242E5 RID: 148197
		private FColor? WhiteColor;

		// Token: 0x040242E6 RID: 148198
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x040242E7 RID: 148199
		[Nullable(2)]
		private UUIText TitleText;

		// Token: 0x040242E8 RID: 148200
		[Nullable(2)]
		private UUIText TimeText;

		// Token: 0x0200CD94 RID: 52628
		[NullableContext(0)]
		private class EViewComponent
		{
			// Token: 0x0403DF16 RID: 253718
			public const int TitleText = 0;

			// Token: 0x0403DF17 RID: 253719
			public const int TimeText = 1;

			// Token: 0x0403DF18 RID: 253720
			public const int RedBar = 2;

			// Token: 0x0403DF19 RID: 253721
			public const int BlueBar = 3;

			// Token: 0x0403DF1A RID: 253722
			public const int TextAddTime = 4;
		}
	}
}
