using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x0200497B RID: 18811
	[NullableContext(1)]
	[Nullable(0)]
	public class CountDownFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0602F293 RID: 193171 RVA: 0x00D2502C File Offset: 0x00D2322C
		public CountDownFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F294 RID: 193172 RVA: 0x00D25058 File Offset: 0x00D23258
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUINiagara)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUINiagara)));
			this.WhiteColor = new FColor?(FColor.FromHex("FFFFFFFF"));
		}

		// Token: 0x0602F295 RID: 193173 RVA: 0x00D250B6 File Offset: 0x00D232B6
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0602F296 RID: 193174 RVA: 0x00D250CF File Offset: 0x00D232CF
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add<double, double>(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.UpdateCountDown));
		}

		// Token: 0x0602F297 RID: 193175 RVA: 0x00D250F3 File Offset: 0x00D232F3
		protected override void OnRemoveEventListener()
		{
			base.OnRemoveEventListener();
			EventSystem.Instance.Remove(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.UpdateCountDown));
		}

		// Token: 0x0602F298 RID: 193176 RVA: 0x00D25118 File Offset: 0x00D23318
		protected override void OnTick(float delta)
		{
			if (this.MinuteText == "" || this.SecondText == "" || this.Millisecond == "")
			{
				return;
			}
			if (this.CdRemainTime <= 10.0)
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
				base.MainText.SetColor(this.WhiteColor.Value);
				base.ExtraText.SetColor(this.WhiteColor.Value);
				base.MainText.SetUIItemScale(Vector.OneVector);
				base.ExtraText.SetUIItemScale(Vector.OneVector);
			}
			if (this.CdRemainTime == 0.0)
			{
				this.Millisecond = "00";
			}
			this.SetExtraText(new <>z__ReadOnlyArray<object>(new object[]
			{
				this.MinuteText,
				this.SecondText,
				this.Millisecond
			}));
		}

		// Token: 0x0602F299 RID: 193177 RVA: 0x00D2525C File Offset: 0x00D2345C
		private void UpdateCountDown(double cdRemainTime, double d)
		{
			this.CdRemainTime = cdRemainTime;
			if (cdRemainTime <= 0.0)
			{
				base.GetUiNiagara(2).SetUIActive(false);
				base.GetUiNiagara(3).SetUIActive(false);
				GeneralLogicTreeModel.Instance.CountDownViewClosing = true;
				base.CloseMe(delegate(bool success)
				{
					if (success)
					{
						GeneralLogicTreeModel.Instance.CountDownViewClosing = false;
					}
				});
				return;
			}
			base.GetUiNiagara(2).SetUIActive(cdRemainTime <= 10.0);
			base.GetUiNiagara(3).SetUIActive(cdRemainTime > 10.0);
			double num = Math.Floor(cdRemainTime % TimeUtil.Instance.Hour / TimeUtil.Instance.Minute);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted((num < 10.0) ? "0" : "");
			defaultInterpolatedStringHandler.AppendFormatted<double>(num);
			this.MinuteText = defaultInterpolatedStringHandler.ToStringAndClear();
			double num2 = Math.Floor(cdRemainTime % TimeUtil.Instance.Minute);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted((num2 < 10.0) ? "0" : "");
			defaultInterpolatedStringHandler.AppendFormatted<double>(num2);
			this.SecondText = defaultInterpolatedStringHandler.ToStringAndClear();
			double num3 = Math.Floor((cdRemainTime - Math.Floor(cdRemainTime)) * 100.0);
			defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(0, 2);
			defaultInterpolatedStringHandler.AppendFormatted((num3 < 10.0) ? "0" : "");
			defaultInterpolatedStringHandler.AppendFormatted<double>(num3);
			this.Millisecond = defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x0401907E RID: 102526
		private const int ONE_HUNDRED = 100;

		// Token: 0x0401907F RID: 102527
		private double CdRemainTime;

		// Token: 0x04019080 RID: 102528
		private string Millisecond = "";

		// Token: 0x04019081 RID: 102529
		private string MinuteText = "";

		// Token: 0x04019082 RID: 102530
		private string SecondText = "";

		// Token: 0x04019083 RID: 102531
		private FColor? WhiteColor;

		// Token: 0x04019084 RID: 102532
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200A623 RID: 42531
		[NullableContext(0)]
		private class ECountDownFloatTips
		{
			// Token: 0x04033627 RID: 210471
			public const int RedBar = 2;

			// Token: 0x04033628 RID: 210472
			public const int BlueBar = 3;
		}
	}
}
