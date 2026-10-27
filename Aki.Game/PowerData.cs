using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x020025F2 RID: 9714
[NullableContext(1)]
[Nullable(0)]
public class PowerData
{
	// Token: 0x06013C40 RID: 80960 RVA: 0x004F4B5C File Offset: 0x004F2D5C
	public void Phrase(int itemId, int power, double lastUpdateTime)
	{
		this.ItemId = itemId;
		this.ChangePower(power);
		int num = (this.GetPowerLimit() - power) * this.GetPowerIncreaseTimeSpan();
		this.FinishUpdateTime = lastUpdateTime + (double)num;
		this.NextRecoverTime = lastUpdateTime + (double)this.GetPowerIncreaseTimeSpan();
	}

	// Token: 0x06013C41 RID: 80961 RVA: 0x004F4BA2 File Offset: 0x004F2DA2
	public void CheckPowerUpdate()
	{
		if (this.NeedUpdateFlag && this.GetIfCanRequestNewPower())
		{
			this.OnCheckPowerUpdate();
		}
	}

	// Token: 0x06013C42 RID: 80962 RVA: 0x004F4BBC File Offset: 0x004F2DBC
	protected virtual bool GetIfCanRequestNewPower()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		return this.NextRecoverTime > 0.0 && serverTime >= this.NextRecoverTime && PowerController.Instance.GetIfCanRequestNewPower() && serverTime - this.CurrentRequestNewPowerTime > 1.0;
	}

	// Token: 0x06013C43 RID: 80963 RVA: 0x004F4C0F File Offset: 0x004F2E0F
	protected void RequestNewPowerDataAndCacheRequestTime()
	{
		PowerController.Instance.SendUpdatePowerRequest(new int[]
		{
			this.ItemId
		});
		this.CurrentRequestNewPowerTime = TimeUtil.Instance.GetServerTime();
	}

	// Token: 0x06013C44 RID: 80964 RVA: 0x004F4C3A File Offset: 0x004F2E3A
	protected void OnCheckPowerUpdate()
	{
		this.RequestNewPowerDataAndCacheRequestTime();
	}

	// Token: 0x06013C45 RID: 80965 RVA: 0x004F4C42 File Offset: 0x004F2E42
	public virtual EPowerRecoveryMode GetPowerRecoveryMode()
	{
		if (!this.NeedUpdateFlag)
		{
			return EPowerRecoveryMode.Full;
		}
		return EPowerRecoveryMode.Update;
	}

	// Token: 0x06013C46 RID: 80966 RVA: 0x004F4C4F File Offset: 0x004F2E4F
	private void ChangePower(int power)
	{
		this.CurrentPower = power;
		this.NeedUpdateFlag = !this.CheckPowerIfMax();
		EventSystem.Instance.Emit(EEventName.OnPowerChanged);
		EventSystem.Instance.Emit<int>(EEventName.OnPowerChangedWithId, this.ItemId);
	}

	// Token: 0x06013C47 RID: 80967 RVA: 0x004F4C8D File Offset: 0x004F2E8D
	public int GetCurrentPower()
	{
		return this.CurrentPower;
	}

	// Token: 0x06013C48 RID: 80968 RVA: 0x004F4C95 File Offset: 0x004F2E95
	public bool CheckPowerIfMax()
	{
		return this.CurrentPower >= this.GetPowerLimit();
	}

	// Token: 0x06013C49 RID: 80969 RVA: 0x004F4CA8 File Offset: 0x004F2EA8
	public double GetResetTime()
	{
		return this.ResetTime;
	}

	// Token: 0x06013C4A RID: 80970 RVA: 0x004F4CB0 File Offset: 0x004F2EB0
	public bool GetNeedUpdateFlag()
	{
		return this.NeedUpdateFlag;
	}

	// Token: 0x06013C4B RID: 80971 RVA: 0x004F4CB8 File Offset: 0x004F2EB8
	public virtual string GetPowerCurrencyShowTextId()
	{
		return "Text_ItemShow_Text";
	}

	// Token: 0x06013C4C RID: 80972 RVA: 0x004F4CBF File Offset: 0x004F2EBF
	public virtual bool IfNeedShowMax()
	{
		return false;
	}

	// Token: 0x06013C4D RID: 80973 RVA: 0x004F4CC2 File Offset: 0x004F2EC2
	public virtual int GetPowerLimit()
	{
		return PowerConfig.Instance.GetPowerNaturalLimit();
	}

	// Token: 0x06013C4E RID: 80974 RVA: 0x004F4CCE File Offset: 0x004F2ECE
	public virtual int GetPowerIncreaseTimeSpan()
	{
		return PowerConfig.Instance.GetPowerIncreaseSpan();
	}

	// Token: 0x06013C4F RID: 80975 RVA: 0x004F4CDC File Offset: 0x004F2EDC
	public string GetNextTimerRecoverText()
	{
		double num = this.NextRecoverTime - TimeUtil.Instance.GetServerTime();
		num = ((num < 0.0) ? 0.0 : num);
		double num2 = num / TimeUtil.Instance.Minute;
		double num3 = num % TimeUtil.Instance.Minute;
		int num4 = (int)Math.Truncate(num2);
		num3 = Math.Truncate(num3);
		return num4.ToString().PadLeft(2, '0') + ":" + ((int)num3).ToString().PadLeft(2, '0');
	}

	// Token: 0x06013C50 RID: 80976 RVA: 0x004F4D68 File Offset: 0x004F2F68
	public string GetFullRecoverText()
	{
		double num = this.FinishUpdateTime - TimeUtil.Instance.GetServerTime();
		num = ((num < 0.0) ? 0.0 : num);
		double num2 = num / TimeUtil.Instance.Hour;
		double num3 = num % TimeUtil.Instance.Hour / TimeUtil.Instance.Minute;
		double num4 = num % TimeUtil.Instance.Minute;
		num2 = Math.Truncate(num2);
		num3 = Math.Truncate(num3);
		num4 = Math.Truncate(num4);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
		defaultInterpolatedStringHandler.AppendFormatted(((int)num2).ToString().PadLeft(2, '0'));
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(((int)num3).ToString().PadLeft(2, '0'));
		defaultInterpolatedStringHandler.AppendLiteral(":");
		defaultInterpolatedStringHandler.AppendFormatted(((int)num4).ToString().PadLeft(2, '0'));
		return defaultInterpolatedStringHandler.ToStringAndClear();
	}

	// Token: 0x040094E7 RID: 38119
	protected int ItemId;

	// Token: 0x040094E8 RID: 38120
	protected int CurrentPower;

	// Token: 0x040094E9 RID: 38121
	protected double FinishUpdateTime;

	// Token: 0x040094EA RID: 38122
	protected bool NeedUpdateFlag;

	// Token: 0x040094EB RID: 38123
	protected int CurrentRecoverMode;

	// Token: 0x040094EC RID: 38124
	protected double NextRecoverTime;

	// Token: 0x040094ED RID: 38125
	protected double ResetTime;

	// Token: 0x040094EE RID: 38126
	protected double CurrentRequestNewPowerTime;

	// Token: 0x040094EF RID: 38127
	protected int LastTickCountDown = -1;
}
