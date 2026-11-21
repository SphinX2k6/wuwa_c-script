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
	// Token: 0x020060DF RID: 24799
	[NullableContext(1)]
	[Nullable(0)]
	public class GameCountDownItem : UiPanelBase
	{
		// Token: 0x0603B755 RID: 243541 RVA: 0x010D4450 File Offset: 0x010D2650
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

		// Token: 0x0603B756 RID: 243542 RVA: 0x010D451C File Offset: 0x010D271C
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.TitleText = base.GetText(0);
			this.TimeText = base.GetText(1);
			this.WhiteColor = new FColor?(FColor.FromHex("FFFFFFFF"));
		}

		// Token: 0x0603B757 RID: 243543 RVA: 0x010D4570 File Offset: 0x010D2770
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

		// Token: 0x0603B758 RID: 243544 RVA: 0x010D45BC File Offset: 0x010D27BC
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

		// Token: 0x0603B759 RID: 243545 RVA: 0x010D46D0 File Offset: 0x010D28D0
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

		// Token: 0x0401F594 RID: 128404
		private const int ONE_HUNDRED = 100;

		// Token: 0x0401F595 RID: 128405
		private bool EnableCountDown;

		// Token: 0x0401F596 RID: 128406
		private float RemainTime;

		// Token: 0x0401F597 RID: 128407
		private string Millisecond = "";

		// Token: 0x0401F598 RID: 128408
		private string MinuteText = "";

		// Token: 0x0401F599 RID: 128409
		private string SecondText = "";

		// Token: 0x0401F59A RID: 128410
		private FColor? WhiteColor;

		// Token: 0x0401F59B RID: 128411
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401F59C RID: 128412
		[Nullable(2)]
		private UUIText TitleText;

		// Token: 0x0401F59D RID: 128413
		[Nullable(2)]
		private UUIText TimeText;

		// Token: 0x0200B986 RID: 47494
		[NullableContext(0)]
		private class EViewComponent
		{
			// Token: 0x04039345 RID: 234309
			public const int TitleText = 0;

			// Token: 0x04039346 RID: 234310
			public const int TimeText = 1;

			// Token: 0x04039347 RID: 234311
			public const int RedBar = 2;

			// Token: 0x04039348 RID: 234312
			public const int BlueBar = 3;

			// Token: 0x04039349 RID: 234313
			public const int TextAddTime = 4;
		}
	}
}
