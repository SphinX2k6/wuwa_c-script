using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt.View
{
	// Token: 0x020059A2 RID: 22946
	[NullableContext(1)]
	[Nullable(0)]
	public class CountDownFloatTips : GenericPromptFloatTipsBase
	{
		// Token: 0x0603A36D RID: 238445 RVA: 0x00DD5B9C File Offset: 0x00DD3D9C
		public CountDownFloatTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603A36E RID: 238446 RVA: 0x00DD5BC8 File Offset: 0x00DD3DC8
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUINiagara)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUINiagara)));
			this.WhiteColor = new FColor?(FColor.FromHex("FFFFFFFF"));
		}

		// Token: 0x0603A36F RID: 238447 RVA: 0x00DD5C26 File Offset: 0x00DD3E26
		protected override void OnStart()
		{
			base.OnStart();
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603A370 RID: 238448 RVA: 0x00DD5C3F File Offset: 0x00DD3E3F
		protected override void OnAddEventListener()
		{
			base.OnAddEventListener();
			EventSystem.Instance.Add<double, double>(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.UpdateCountDown));
		}

		// Token: 0x0603A371 RID: 238449 RVA: 0x00DD5C63 File Offset: 0x00DD3E63
		protected override void OnRemoveEventListener()
		{
			base.OnRemoveEventListener();
			EventSystem.Instance.Remove(EEventName.OnGamePlayCdChanged, new Action<double, double>(this.UpdateCountDown));
		}

		// Token: 0x0603A372 RID: 238450 RVA: 0x00DD5C88 File Offset: 0x00DD3E88
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

		// Token: 0x0603A373 RID: 238451 RVA: 0x00DD5DCC File Offset: 0x00DD3FCC
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

		// Token: 0x0401E5E0 RID: 124384
		private const int ONE_HUNDRED = 100;

		// Token: 0x0401E5E1 RID: 124385
		private double CdRemainTime;

		// Token: 0x0401E5E2 RID: 124386
		private string Millisecond = "";

		// Token: 0x0401E5E3 RID: 124387
		private string MinuteText = "";

		// Token: 0x0401E5E4 RID: 124388
		private string SecondText = "";

		// Token: 0x0401E5E5 RID: 124389
		private FColor? WhiteColor;

		// Token: 0x0401E5E6 RID: 124390
		[Nullable(2)]
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200BC18 RID: 48152
		[NullableContext(0)]
		private class ECountDownFloatTips
		{
			// Token: 0x04038C58 RID: 232536
			public const int RedBar = 2;

			// Token: 0x04038C59 RID: 232537
			public const int BlueBar = 3;
		}
	}
}
