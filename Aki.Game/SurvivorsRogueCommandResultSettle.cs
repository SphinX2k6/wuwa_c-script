using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02002AE5 RID: 10981
public class SurvivorsRogueCommandResultSettle : SurvivorsRogueCommandBase
{
	// Token: 0x06016D9F RID: 93599 RVA: 0x005CCC3D File Offset: 0x005CAE3D
	public SurvivorsRogueCommandResultSettle(ESurvivorsRogueCommandType type) : base(type)
	{
	}

	// Token: 0x06016DA0 RID: 93600 RVA: 0x005CCC48 File Offset: 0x005CAE48
	[NullableContext(1)]
	public override string ToString()
	{
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(17, 1);
		defaultInterpolatedStringHandler.AppendLiteral("[Settle] Reason: ");
		ResultView viewInfo = this.GetViewInfo();
		defaultInterpolatedStringHandler.AppendFormatted<int?>((viewInfo != null) ? new int?(viewInfo.Reason) : null);
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x06016DA1 RID: 93601 RVA: 0x005CCC98 File Offset: 0x005CAE98
	protected override void OnUpdate()
	{
	}

	// Token: 0x06016DA2 RID: 93602 RVA: 0x005CCC9A File Offset: 0x005CAE9A
	protected override void Back2Fore()
	{
	}

	// Token: 0x06016DA3 RID: 93603 RVA: 0x005CCC9C File Offset: 0x005CAE9C
	protected override void Fore2Back()
	{
	}

	// Token: 0x06016DA4 RID: 93604 RVA: 0x005CCCA0 File Offset: 0x005CAEA0
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

	// Token: 0x06016DA5 RID: 93605 RVA: 0x005CCD1A File Offset: 0x005CAF1A
	protected override void OnExecute()
	{
	}

	// Token: 0x06016DA6 RID: 93606 RVA: 0x005CCD1C File Offset: 0x005CAF1C
	protected override void OnFinish()
	{
	}

	// Token: 0x06016DA7 RID: 93607 RVA: 0x005CCD1E File Offset: 0x005CAF1E
	protected override void OnDelete()
	{
	}

	// Token: 0x06016DA8 RID: 93608 RVA: 0x005CCD20 File Offset: 0x005CAF20
	[NullableContext(2)]
	public ResultView GetViewInfo()
	{
		return this.Data.ResultView;
	}

	// Token: 0x0400A9BE RID: 43454
	private const int TIME_DEATH_DELAY = 3000;

	// Token: 0x02009107 RID: 37127
	private static class EResultSettleReason
	{
		// Token: 0x0402EFAE RID: 192430
		public const int EarlyExit = 0;

		// Token: 0x0402EFAF RID: 192431
		public const int PlayerDeath = 1;

		// Token: 0x0402EFB0 RID: 192432
		public const int SuccessPass = 2;

		// Token: 0x0402EFB1 RID: 192433
		public const int OutSettle = 3;
	}
}
