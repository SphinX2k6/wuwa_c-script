using System;
using System.Runtime.CompilerServices;

// Token: 0x02001ADE RID: 6878
public class OverPowerData : PowerData
{
	// Token: 0x06011134 RID: 69940 RVA: 0x00503BF8 File Offset: 0x00501DF8
	protected override bool GetIfCanRequestNewPower()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		PowerData powerDataById = PowerModel.Instance.GetPowerDataById(5);
		return this.NextRecoverTime > 0.0 && serverTime >= this.NextRecoverTime && PowerController.Instance.GetIfCanRequestNewPower() && serverTime - this.CurrentRequestNewPowerTime > 1.0 && FunctionModel.Instance.IsOpen(10066) && powerDataById.CheckPowerIfMax();
	}

	// Token: 0x06011135 RID: 69941 RVA: 0x00503C6E File Offset: 0x00501E6E
	public override EPowerRecoveryMode GetPowerRecoveryMode()
	{
		if (base.CheckPowerIfMax())
		{
			return EPowerRecoveryMode.Full;
		}
		if (!PowerModel.Instance.GetPowerDataById(5).CheckPowerIfMax())
		{
			return EPowerRecoveryMode.Stop;
		}
		return EPowerRecoveryMode.Update;
	}

	// Token: 0x06011136 RID: 69942 RVA: 0x00503C8F File Offset: 0x00501E8F
	[NullableContext(1)]
	public override string GetPowerCurrencyShowTextId()
	{
		return "PowerNumTips";
	}

	// Token: 0x06011137 RID: 69943 RVA: 0x00503C96 File Offset: 0x00501E96
	public override int GetPowerLimit()
	{
		return PowerConfig.Instance.GetOverPowerLimit();
	}

	// Token: 0x06011138 RID: 69944 RVA: 0x00503CA2 File Offset: 0x00501EA2
	public override int GetPowerIncreaseTimeSpan()
	{
		return PowerConfig.Instance.GetOverPowerRecoverTimeSpan();
	}

	// Token: 0x06011139 RID: 69945 RVA: 0x00503CAE File Offset: 0x00501EAE
	public override bool IfNeedShowMax()
	{
		return true;
	}
}
