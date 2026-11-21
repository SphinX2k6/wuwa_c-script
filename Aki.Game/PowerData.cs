using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02001ADD RID: 6877
[NullableContext(1)]
[Nullable(0)]
public class PowerData
{
	// Token: 0x06011122 RID: 69922 RVA: 0x005038E8 File Offset: 0x00501AE8
	public void Phrase(int itemId, int power, double lastUpdateTime)
	{
		this.ItemId = itemId;
		this.ChangePower(power);
		int num = (this.GetPowerLimit() - power) * this.GetPowerIncreaseTimeSpan();
		this.FinishUpdateTime = lastUpdateTime + (double)num;
		this.NextRecoverTime = lastUpdateTime + (double)this.GetPowerIncreaseTimeSpan();
	}

	// Token: 0x06011123 RID: 69923 RVA: 0x0050392E File Offset: 0x00501B2E
	public void CheckPowerUpdate()
	{
		if (this.NeedUpdateFlag && this.GetIfCanRequestNewPower())
		{
			this.OnCheckPowerUpdate();
		}
	}

	// Token: 0x06011124 RID: 69924 RVA: 0x00503948 File Offset: 0x00501B48
	protected virtual bool GetIfCanRequestNewPower()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		return this.NextRecoverTime > 0.0 && serverTime >= this.NextRecoverTime && PowerController.Instance.GetIfCanRequestNewPower() && serverTime - this.CurrentRequestNewPowerTime > 1.0;
	}

	// Token: 0x06011125 RID: 69925 RVA: 0x0050399B File Offset: 0x00501B9B
	protected void RequestNewPowerDataAndCacheRequestTime()
	{
		PowerController.Instance.SendUpdatePowerRequest(new int[]
		{
			this.ItemId
		});
		this.CurrentRequestNewPowerTime = TimeUtil.Instance.GetServerTime();
	}

	// Token: 0x06011126 RID: 69926 RVA: 0x005039C6 File Offset: 0x00501BC6
	protected void OnCheckPowerUpdate()
	{
		this.RequestNewPowerDataAndCacheRequestTime();
	}

	// Token: 0x06011127 RID: 69927 RVA: 0x005039CE File Offset: 0x00501BCE
	public virtual EPowerRecoveryMode GetPowerRecoveryMode()
	{
		if (!this.NeedUpdateFlag)
		{
			return EPowerRecoveryMode.Full;
		}
		return EPowerRecoveryMode.Update;
	}

	// Token: 0x06011128 RID: 69928 RVA: 0x005039DB File Offset: 0x00501BDB
	private void ChangePower(int power)
	{
		this.CurrentPower = power;
		this.NeedUpdateFlag = !this.CheckPowerIfMax();
		EventSystem.Instance.Emit(EEventName.OnPowerChanged);
		EventSystem.Instance.Emit<int>(EEventName.OnPowerChangedWithId, this.ItemId);
	}

	// Token: 0x06011129 RID: 69929 RVA: 0x00503A19 File Offset: 0x00501C19
	public int GetCurrentPower()
	{
		return this.CurrentPower;
	}

	// Token: 0x0601112A RID: 69930 RVA: 0x00503A21 File Offset: 0x00501C21
	public bool CheckPowerIfMax()
	{
		return this.CurrentPower >= this.GetPowerLimit();
	}

	// Token: 0x0601112B RID: 69931 RVA: 0x00503A34 File Offset: 0x00501C34
	public double GetResetTime()
	{
		return this.ResetTime;
	}

	// Token: 0x0601112C RID: 69932 RVA: 0x00503A3C File Offset: 0x00501C3C
	public bool GetNeedUpdateFlag()
	{
		return this.NeedUpdateFlag;
	}

	// Token: 0x0601112D RID: 69933 RVA: 0x00503A44 File Offset: 0x00501C44
	public virtual string GetPowerCurrencyShowTextId()
	{
		return "Text_ItemShow_Text";
	}

	// Token: 0x0601112E RID: 69934 RVA: 0x00503A4B File Offset: 0x00501C4B
	public virtual bool IfNeedShowMax()
	{
		return false;
	}

	// Token: 0x0601112F RID: 69935 RVA: 0x00503A4E File Offset: 0x00501C4E
	public virtual int GetPowerLimit()
	{
		return PowerConfig.Instance.GetPowerNaturalLimit();
	}

	// Token: 0x06011130 RID: 69936 RVA: 0x00503A5A File Offset: 0x00501C5A
	public virtual int GetPowerIncreaseTimeSpan()
	{
		return PowerConfig.Instance.GetPowerIncreaseSpan();
	}

	// Token: 0x06011131 RID: 69937 RVA: 0x00503A68 File Offset: 0x00501C68
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

	// Token: 0x06011132 RID: 69938 RVA: 0x00503AF4 File Offset: 0x00501CF4
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

	// Token: 0x0400963E RID: 38462
	protected int ItemId;

	// Token: 0x0400963F RID: 38463
	protected int CurrentPower;

	// Token: 0x04009640 RID: 38464
	protected double FinishUpdateTime;

	// Token: 0x04009641 RID: 38465
	protected bool NeedUpdateFlag;

	// Token: 0x04009642 RID: 38466
	protected int CurrentRecoverMode;

	// Token: 0x04009643 RID: 38467
	protected double NextRecoverTime;

	// Token: 0x04009644 RID: 38468
	protected double ResetTime;

	// Token: 0x04009645 RID: 38469
	protected double CurrentRequestNewPowerTime;

	// Token: 0x04009646 RID: 38470
	protected int LastTickCountDown = -1;
}
