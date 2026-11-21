using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;

// Token: 0x02001AEF RID: 6895
[NullableContext(2)]
[Nullable(0)]
public class CommonQteContinuousClickContext : CommonQteContextBase
{
	// Token: 0x060111F2 RID: 70130 RVA: 0x00506D6E File Offset: 0x00504F6E
	public CommonQteContinuousClickContext()
	{
		this.Type = new ECommonQteContextType?(ECommonQteContextType.SingleButtonContinuousClick);
	}

	// Token: 0x060111F3 RID: 70131 RVA: 0x00506D90 File Offset: 0x00504F90
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

	// Token: 0x060111F4 RID: 70132 RVA: 0x00506E60 File Offset: 0x00505060
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

	// Token: 0x060111F5 RID: 70133 RVA: 0x00506F27 File Offset: 0x00505127
	protected override void OnQtePendingSuccess()
	{
		CommonQteController.Instance.WaitQteEnd(this.HandleId);
	}

	// Token: 0x060111F6 RID: 70134 RVA: 0x00506F3C File Offset: 0x0050513C
	public override bool CheckQteConditionMatch()
	{
		bool flag = this.DeltaEnergyPercentPerResponse > 0f && this.CurrentEnergyPercent >= this.TargetEnergyPercent;
		bool flag2 = this.DeltaEnergyPercentPerResponse < 0f && this.CurrentEnergyPercent <= this.TargetEnergyPercent;
		return flag || flag2;
	}

	// Token: 0x060111F7 RID: 70135 RVA: 0x00506F90 File Offset: 0x00505190
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

	// Token: 0x060111F8 RID: 70136 RVA: 0x0050711C File Offset: 0x0050531C
	protected override string OnGetAction(int? index = null)
	{
		if (this.Config == null)
		{
			return null;
		}
		SCommonQteButton uiconfig = this.Config.BaseConfig.ContinuousClickConfig.UIConfig;
		return CommonQteContextBase.GetQteActionNameByActionId((uiconfig.ActionId > 0) ? uiconfig.ActionId : ((int)uiconfig.Action), new int?(this.QteId));
	}

	// Token: 0x060111F9 RID: 70137 RVA: 0x0050717B File Offset: 0x0050537B
	[PreserveBaseOverrides]
	protected new virtual SCommonQte_ContinuousClick OnGetUiConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.ContinuousClickConfig;
	}

	// Token: 0x060111FA RID: 70138 RVA: 0x0050719D File Offset: 0x0050539D
	protected override SCommonQteButton GetUiButtonConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.ContinuousClickConfig.UIConfig;
	}

	// Token: 0x060111FB RID: 70139 RVA: 0x005071C4 File Offset: 0x005053C4
	public override bool IsAttachToActor()
	{
		SCommonQte config = this.Config;
		return config != null && config.BaseConfig.ContinuousClickConfig.IsAttachToActor;
	}

	// Token: 0x060111FC RID: 70140 RVA: 0x005071E4 File Offset: 0x005053E4
	public override SCommonQte_Attach? GetAttachConfig()
	{
		SCommonQte config = this.Config;
		if (config == null)
		{
			return null;
		}
		return new SCommonQte_Attach?(config.BaseConfig.ContinuousClickConfig.AttachConfig);
	}

	// Token: 0x060111FD RID: 70141 RVA: 0x00507219 File Offset: 0x00505419
	public override float GetProgress()
	{
		if (this.TargetEnergyPercent > 0f)
		{
			return this.CurrentEnergyPercent / this.TargetEnergyPercent;
		}
		return 0f;
	}

	// Token: 0x060111FE RID: 70142 RVA: 0x0050723B File Offset: 0x0050543B
	public void StartComboTiming()
	{
		this.IsComboTiming = true;
		this.CurrentComboInterval = 0f;
	}

	// Token: 0x040096A2 RID: 38562
	public float CurrentEnergyPercent;

	// Token: 0x040096A3 RID: 38563
	public float TargetEnergyPercent = -1f;

	// Token: 0x040096A4 RID: 38564
	public float DeltaEnergyPercentPerResponse;

	// Token: 0x040096A5 RID: 38565
	public float DeltaEnergyPercentPerMs;

	// Token: 0x040096A6 RID: 38566
	public float EnergyInterpSpeedPerMs;

	// Token: 0x040096A7 RID: 38567
	private float TargetEnergyPercentCurrent;

	// Token: 0x040096A8 RID: 38568
	public float MaxComboInterval;

	// Token: 0x040096A9 RID: 38569
	public bool ProgressOnBegin;

	// Token: 0x040096AA RID: 38570
	private bool IsComboTiming;

	// Token: 0x040096AB RID: 38571
	private float CurrentComboInterval;
}
