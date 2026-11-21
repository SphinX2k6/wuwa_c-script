using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02002061 RID: 8289
public class SurvivorsRogueCommandResultSettle : SurvivorsRogueCommandBase
{
	// Token: 0x060147D0 RID: 83920 RVA: 0x005F978D File Offset: 0x005F798D
	public SurvivorsRogueCommandResultSettle(ESurvivorsRogueCommandType type) : base(type)
	{
	}

	// Token: 0x060147D1 RID: 83921 RVA: 0x005F9798 File Offset: 0x005F7998
	[NullableContext(1)]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[Settle] Reason: ");
		ResultView viewInfo = this.GetViewInfo();
		defaultInterpolatedStringHandler.AppendFormatted<int?>((viewInfo != null) ? new int?(viewInfo.Reason) : null);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x060147D2 RID: 83922 RVA: 0x005F97E8 File Offset: 0x005F79E8
	protected override void OnUpdate()
	{
	}

	// Token: 0x060147D3 RID: 83923 RVA: 0x005F97EA File Offset: 0x005F79EA
	protected override void Back2Fore()
	{
	}

	// Token: 0x060147D4 RID: 83924 RVA: 0x005F97EC File Offset: 0x005F79EC
	protected override void Fore2Back()
	{
	}

	// Token: 0x060147D5 RID: 83925 RVA: 0x005F97F0 File Offset: 0x005F79F0
	protected override void OnStartExecute()
	{
		ResultView viewInfo = this.GetViewInfo();
		if (viewInfo != null && viewInfo.Reason == 1)
		{
			int valueOrDefault = ConfigCommonParamById.GetIntConfig("SurvivorsDeathDelaySettleTime").GetValueOrDefault(3000);
			UiLayer.Instance.SetShowMaskLayer("SurvivorsRogueSettleView.DelayOpen", true);
			TimerSystem.Instance.Delay(delegate(float _)
			{
				base.OpenView(EUiViewName.SurvivorsRogueSettleView, false);
				UiLayer.Instance.SetShowMaskLayer("SurvivorsRogueSettleView.DelayOpen", false);
			}, (float)valueOrDefault, null, null, true, 1f);
			return;
		}
		base.OpenView(EUiViewName.SurvivorsRogueSettleView, false);
	}

	// Token: 0x060147D6 RID: 83926 RVA: 0x005F986A File Offset: 0x005F7A6A
	protected override void OnExecute()
	{
	}

	// Token: 0x060147D7 RID: 83927 RVA: 0x005F986C File Offset: 0x005F7A6C
	protected override void OnFinish()
	{
	}

	// Token: 0x060147D8 RID: 83928 RVA: 0x005F986E File Offset: 0x005F7A6E
	protected override void OnDelete()
	{
	}

	// Token: 0x060147D9 RID: 83929 RVA: 0x005F9870 File Offset: 0x005F7A70
	[NullableContext(2)]
	public ResultView GetViewInfo()
	{
		return this.Data.ResultView;
	}

	// Token: 0x0400ADC4 RID: 44484
	private const int TIME_DEATH_DELAY = 3000;

	// Token: 0x0200834B RID: 33611
	private static class EResultSettleReason
	{
		// Token: 0x0402A6B4 RID: 173748
		public const int EarlyExit = 0;

		// Token: 0x0402A6B5 RID: 173749
		public const int PlayerDeath = 1;

		// Token: 0x0402A6B6 RID: 173750
		public const int SuccessPass = 2;

		// Token: 0x0402A6B7 RID: 173751
		public const int OutSettle = 3;
	}
}
