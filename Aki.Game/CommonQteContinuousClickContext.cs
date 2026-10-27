using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;

// Token: 0x02002604 RID: 9732
[NullableContext(2)]
[Nullable(0)]
public class CommonQteContinuousClickContext : CommonQteContextBase
{
	// Token: 0x06013D10 RID: 81168 RVA: 0x004F7F92 File Offset: 0x004F6192
	public CommonQteContinuousClickContext()
	{
		this.Type = new ECommonQteContextType?(ECommonQteContextType.SingleButtonContinuousClick);
	}

	// Token: 0x06013D11 RID: 81169 RVA: 0x004F7FB4 File Offset: 0x004F61B4
	[NullableContext(1)]
	protected override void OnSetConfig(SCommonQte config)
	{
		SCommonQte_ContinuousClick continuousClickConfig = config.BaseConfig.ContinuousClickConfig;
		this.CurrentEnergyPercent = continuousClickConfig.InitialEnergyPercent;
		this.TargetEnergyPercentCurrent = this.CurrentEnergyPercent;
		this.TargetEnergyPercent = continuousClickConfig.TargetEnergyPercent;
		this.DeltaEnergyPercentPerMs = continuousClickConfig.DeltaEnergyPercentPerSecond * (float)TimeUtil.Instance.Millisecond;
		this.EnergyInterpSpeedPerMs = continuousClickConfig.InterpSpeedForEnergyPercent * (float)TimeUtil.Instance.Millisecond;
		this.DeltaEnergyPercentPerResponse = continuousClickConfig.DeltaEnergyPercentPerClick;
		this.MaxComboInterval = ((continuousClickConfig.MaxComboInterval < 0f) ? continuousClickConfig.MaxComboInterval : Math.Max(0f, continuousClickConfig.MaxComboInterval * (float)TimeUtil.Instance.InverseMillisecond));
		this.ProgressOnBegin = continuousClickConfig.ProgressOnBegin;
		this.IsComboTiming = false;
		this.CurrentComboInterval = 0f;
	}

	// Token: 0x06013D12 RID: 81170 RVA: 0x004F8084 File Offset: 0x004F6284
	protected override void OnResponse()
	{
		if (this.Config == null)
		{
			return;
		}
		if (!base.IsPending() && !base.IsPendingSuccess())
		{
			return;
		}
		if (base.IsPending())
		{
			if (this.IsComboTiming)
			{
				this.CurrentComboInterval = 0f;
			}
			this.TargetEnergyPercentCurrent += this.DeltaEnergyPercentPerResponse;
			CommonQteController.Instance.PlayExtraEffect(this.HandleId);
			CommonQteController.Instance.PlayQteAudio(this.Config.AudioConfig.AudioEventResponse, this.UiActor);
			AudioSystem.Instance.SetRtpcValue("perform_qte_progress_default", this.GetProgress(), new SetRtpcValueArgs?(new SetRtpcValueArgs
			{
				Actor = this.UiActor
			}));
		}
		this.CheckQteConditionAndDoSuccess();
	}

	// Token: 0x06013D13 RID: 81171 RVA: 0x004F814B File Offset: 0x004F634B
	protected override void OnQtePendingSuccess()
	{
		CommonQteController.Instance.WaitQteEnd(this.HandleId);
	}

	// Token: 0x06013D14 RID: 81172 RVA: 0x004F8160 File Offset: 0x004F6360
	public override bool CheckQteConditionMatch()
	{
		bool flag = this.DeltaEnergyPercentPerResponse > 0f && this.CurrentEnergyPercent >= this.TargetEnergyPercent;
		bool flag2 = this.DeltaEnergyPercentPerResponse < 0f && this.CurrentEnergyPercent <= this.TargetEnergyPercent;
		return flag || flag2;
	}

	// Token: 0x06013D15 RID: 81173 RVA: 0x004F81B4 File Offset: 0x004F63B4
	protected override void OnUpdateTime(float delta)
	{
		if (this.Config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CommonQte;
			ELogAuthor author = ELogAuthor.WWJ;
			string message = "Context中获取不到Config";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("QteId", this.QteId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			CommonQteController.Instance.StopCurrentQte();
			return;
		}
		this.PassTime += delta;
		if (base.IsPending() && this.IsComboTiming && this.MaxComboInterval >= 0f)
		{
			this.CurrentComboInterval += delta;
			if (this.CurrentComboInterval > this.MaxComboInterval)
			{
				base.QteFail();
				return;
			}
		}
		float currentEnergyPercent = this.CurrentEnergyPercent;
		if (base.IsPending())
		{
			this.TargetEnergyPercentCurrent = MathUtils.Instance.Clamp(this.TargetEnergyPercentCurrent + this.DeltaEnergyPercentPerMs * delta, 0f, 100f);
		}
		if (this.EnergyInterpSpeedPerMs > 0f)
		{
			this.CurrentEnergyPercent = MathUtils.Instance.InterpConstantTo(this.CurrentEnergyPercent, this.TargetEnergyPercentCurrent, delta, this.EnergyInterpSpeedPerMs);
		}
		else
		{
			this.CurrentEnergyPercent = this.TargetEnergyPercentCurrent;
		}
		bool flag = currentEnergyPercent != this.CurrentEnergyPercent;
		if (this.CheckQteConditionAndDoSuccess())
		{
			return;
		}
		if (!this.IsPermanent && this.PassTime > this.Duration)
		{
			base.QteFail();
		}
		if (base.IsPending() && flag)
		{
			AudioSystem.Instance.SetRtpcValue("perform_qte_progress_default", this.GetProgress(), new SetRtpcValueArgs?(new SetRtpcValueArgs
			{
				Actor = this.UiActor
			}));
		}
	}

	// Token: 0x06013D16 RID: 81174 RVA: 0x004F8340 File Offset: 0x004F6540
	protected override string OnGetAction(int? index = null)
	{
		if (this.Config == null)
		{
			return null;
		}
		SCommonQteButton uiconfig = this.Config.BaseConfig.ContinuousClickConfig.UIConfig;
		return CommonQteContextBase.GetQteActionNameByActionId((uiconfig.ActionId > 0) ? uiconfig.ActionId : ((int)uiconfig.Action), new int?(this.QteId));
	}

	// Token: 0x06013D17 RID: 81175 RVA: 0x004F839F File Offset: 0x004F659F
	[PreserveBaseOverrides]
	protected new virtual SCommonQte_ContinuousClick OnGetUiConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.ContinuousClickConfig;
	}

	// Token: 0x06013D18 RID: 81176 RVA: 0x004F83C1 File Offset: 0x004F65C1
	protected override SCommonQteButton GetUiButtonConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.ContinuousClickConfig.UIConfig;
	}

	// Token: 0x06013D19 RID: 81177 RVA: 0x004F83E8 File Offset: 0x004F65E8
	public override bool IsAttachToActor()
	{
		SCommonQte config = this.Config;
		return config != null && config.BaseConfig.ContinuousClickConfig.IsAttachToActor;
	}

	// Token: 0x06013D1A RID: 81178 RVA: 0x004F8408 File Offset: 0x004F6608
	public override SCommonQte_Attach? GetAttachConfig()
	{
		SCommonQte config = this.Config;
		if (config == null)
		{
			return null;
		}
		return new SCommonQte_Attach?(config.BaseConfig.ContinuousClickConfig.AttachConfig);
	}

	// Token: 0x06013D1B RID: 81179 RVA: 0x004F843D File Offset: 0x004F663D
	public override float GetProgress()
	{
		if (this.TargetEnergyPercent > 0f)
		{
			return this.CurrentEnergyPercent / this.TargetEnergyPercent;
		}
		return 0f;
	}

	// Token: 0x06013D1C RID: 81180 RVA: 0x004F845F File Offset: 0x004F665F
	public void StartComboTiming()
	{
		this.IsComboTiming = true;
		this.CurrentComboInterval = 0f;
	}

	// Token: 0x0400954B RID: 38219
	public float CurrentEnergyPercent;

	// Token: 0x0400954C RID: 38220
	public float TargetEnergyPercent = -1f;

	// Token: 0x0400954D RID: 38221
	public float DeltaEnergyPercentPerResponse;

	// Token: 0x0400954E RID: 38222
	public float DeltaEnergyPercentPerMs;

	// Token: 0x0400954F RID: 38223
	public float EnergyInterpSpeedPerMs;

	// Token: 0x04009550 RID: 38224
	private float TargetEnergyPercentCurrent;

	// Token: 0x04009551 RID: 38225
	public float MaxComboInterval;

	// Token: 0x04009552 RID: 38226
	public bool ProgressOnBegin;

	// Token: 0x04009553 RID: 38227
	private bool IsComboTiming;

	// Token: 0x04009554 RID: 38228
	private float CurrentComboInterval;
}
