using System;
using System.Runtime.CompilerServices;

// Token: 0x020025F3 RID: 9715
public class OverPowerData : PowerData
{
	// Token: 0x06013C52 RID: 80978 RVA: 0x004F4E6C File Offset: 0x004F306C
	protected override bool GetIfCanRequestNewPower()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		PowerData powerDataById = PowerModel.Instance.GetPowerDataById(5);
		return this.NextRecoverTime > 0.0 && serverTime >= this.NextRecoverTime && PowerController.Instance.GetIfCanRequestNewPower() && serverTime - this.CurrentRequestNewPowerTime > 1.0 && FunctionModel.Instance.IsOpen(10066) && powerDataById.CheckPowerIfMax();
	}

	// Token: 0x06013C53 RID: 80979 RVA: 0x004F4EE2 File Offset: 0x004F30E2
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

	// Token: 0x06013C54 RID: 80980 RVA: 0x004F4F03 File Offset: 0x004F3103
	[NullableContext(1)]
	public override string GetPowerCurrencyShowTextId()
	{
		return "PowerNumTips";
	}

	// Token: 0x06013C55 RID: 80981 RVA: 0x004F4F0A File Offset: 0x004F310A
	public override int GetPowerLimit()
	{
		return PowerConfig.Instance.GetOverPowerLimit();
	}

	// Token: 0x06013C56 RID: 80982 RVA: 0x004F4F16 File Offset: 0x004F3116
	public override int GetPowerIncreaseTimeSpan()
	{
		return PowerConfig.Instance.GetOverPowerRecoverTimeSpan();
	}

	// Token: 0x06013C57 RID: 80983 RVA: 0x004F4F22 File Offset: 0x004F3122
	public override bool IfNeedShowMax()
	{
		return true;
	}
}
