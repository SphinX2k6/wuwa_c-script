using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;

// Token: 0x02001AF3 RID: 6899
[NullableContext(2)]
[Nullable(0)]
public class CommonQteLongPressContext : CommonQteContextBase
{
	// Token: 0x0601125E RID: 70238 RVA: 0x00509504 File Offset: 0x00507704
	public CommonQteLongPressContext()
	{
		this.Type = new ECommonQteContextType?(ECommonQteContextType.SingleButtonLongPress);
	}

	// Token: 0x0601125F RID: 70239 RVA: 0x00509518 File Offset: 0x00507718
	[NullableContext(1)]
	protected override void OnSetConfig(SCommonQte config)
	{
		SCommonQte_LongPress longPressConfig = config.BaseConfig.LongPressConfig;
		this.InitProgress = longPressConfig.InitProgress;
		this.MaxProgress = longPressConfig.MaxProgress;
		this.TargetProgress = longPressConfig.TargetProgress;
		this.IncreaseSpeed = longPressConfig.IncreaseSpeed * (float)TimeUtil.Instance.Millisecond;
		this.DecreaseSpeed = longPressConfig.DecreaseSpeed * (float)TimeUtil.Instance.Millisecond;
		this.CheckInResponseEnd = longPressConfig.IsCheckOnRelease;
		this.CurrentProgress = this.InitProgress;
	}

	// Token: 0x06011260 RID: 70240 RVA: 0x005095A0 File Offset: 0x005077A0
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
			this.IsPressing = true;
			CommonQteController.Instance.PlayExtraEffect(this.HandleId);
			this.AudioHandle = CommonQteController.Instance.PlayQteAudio(this.Config.AudioConfig.AudioEventResponse, this.UiActor);
		}
		this.CheckQteConditionAndDoSuccess();
	}

	// Token: 0x06011261 RID: 70241 RVA: 0x0050961C File Offset: 0x0050781C
	protected override void OnResponseEnd()
	{
		this.IsPressing = false;
		CommonQteController.Instance.StopExtraEffect(this.HandleId);
		if (this.AudioHandle != 0)
		{
			CommonQteController.Instance.StopQteAudio(this.AudioHandle, null);
			this.AudioHandle = 0;
		}
		if (this.CheckInResponseEnd)
		{
			this.IsInResponseEnd = true;
			this.CheckQteConditionAndDoSuccess();
			this.IsInResponseEnd = false;
		}
	}

	// Token: 0x06011262 RID: 70242 RVA: 0x00509688 File Offset: 0x00507888
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
		float currentProgress = this.CurrentProgress;
		if (this.IsPressing)
		{
			this.CurrentProgress = Math.Min(this.MaxProgress, this.CurrentProgress + this.IncreaseSpeed * delta);
		}
		else
		{
			this.CurrentProgress = Math.Max(0f, this.CurrentProgress - this.DecreaseSpeed * delta);
		}
		bool flag = currentProgress != this.CurrentProgress;
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
			if (this.CurrentProgress > currentProgress)
			{
				if (this.RegressAudioHandle != 0)
				{
					CommonQteController.Instance.StopQteAudio(this.RegressAudioHandle, null);
					this.RegressAudioHandle = 0;
				}
				if (this.ProgressAudioHandle == 0 && this.Config.AudioConfig.AudioEventProgress != null)
				{
					this.ProgressAudioHandle = CommonQteController.Instance.PlayQteAudio(this.Config.AudioConfig.AudioEventProgress, this.UiActor);
					CommonQteController.Instance.SeekAudio((this.CurrentProgress - this.InitProgress) / this.IncreaseSpeed, this.Config.AudioConfig.AudioEventProgress, this.UiActor, new int?(this.ProgressAudioHandle));
					return;
				}
			}
			else if (this.CurrentProgress < currentProgress)
			{
				if (this.ProgressAudioHandle != 0)
				{
					CommonQteController.Instance.StopQteAudio(this.ProgressAudioHandle, null);
					this.ProgressAudioHandle = 0;
				}
				if (this.RegressAudioHandle == 0 && this.Config.AudioConfig.AudioEventRegress != null)
				{
					this.RegressAudioHandle = CommonQteController.Instance.PlayQteAudio(this.Config.AudioConfig.AudioEventRegress, this.UiActor);
					CommonQteController.Instance.SeekAudio((this.TargetProgress - this.CurrentProgress) / this.DecreaseSpeed, this.Config.AudioConfig.AudioEventRegress, this.UiActor, new int?(this.RegressAudioHandle));
				}
			}
		}
	}

	// Token: 0x06011263 RID: 70243 RVA: 0x0050992B File Offset: 0x00507B2B
	protected override void OnQteFail()
	{
		this.StopQteAudio();
	}

	// Token: 0x06011264 RID: 70244 RVA: 0x00509933 File Offset: 0x00507B33
	protected override void OnQteSuccess()
	{
		this.StopQteAudio();
	}

	// Token: 0x06011265 RID: 70245 RVA: 0x0050993C File Offset: 0x00507B3C
	protected void StopQteAudio()
	{
		if (this.ProgressAudioHandle != 0)
		{
			CommonQteController.Instance.StopQteAudio(this.ProgressAudioHandle, new float?(this.Config.AudioConfig.AudioEventProgressFadeOutTime));
			this.ProgressAudioHandle = 0;
		}
		if (this.RegressAudioHandle != 0)
		{
			CommonQteController.Instance.StopQteAudio(this.RegressAudioHandle, new float?(this.Config.AudioConfig.AudioEventRegressFadeOutTime));
			this.RegressAudioHandle = 0;
		}
	}

	// Token: 0x06011266 RID: 70246 RVA: 0x005099B4 File Offset: 0x00507BB4
	protected override string OnGetAction(int? index = null)
	{
		if (this.Config == null)
		{
			return null;
		}
		SCommonQteButton uiconfig = this.Config.BaseConfig.LongPressConfig.UIConfig;
		return CommonQteContextBase.GetQteActionNameByActionId((uiconfig.ActionId > 0) ? uiconfig.ActionId : ((int)uiconfig.Action), new int?(this.QteId));
	}

	// Token: 0x06011267 RID: 70247 RVA: 0x00509A13 File Offset: 0x00507C13
	[PreserveBaseOverrides]
	protected new virtual SCommonQte_LongPress OnGetUiConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.LongPressConfig;
	}

	// Token: 0x06011268 RID: 70248 RVA: 0x00509A35 File Offset: 0x00507C35
	protected override SCommonQteButton GetUiButtonConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.LongPressConfig.UIConfig;
	}

	// Token: 0x06011269 RID: 70249 RVA: 0x00509A5C File Offset: 0x00507C5C
	public override bool CheckQteConditionMatch()
	{
		if (this.CheckInResponseEnd)
		{
			return this.IsInResponseEnd && this.CheckProgressCondition();
		}
		return this.CheckProgressCondition();
	}

	// Token: 0x0601126A RID: 70250 RVA: 0x00509A7D File Offset: 0x00507C7D
	private bool CheckProgressCondition()
	{
		return this.CurrentProgress >= this.TargetProgress;
	}

	// Token: 0x0601126B RID: 70251 RVA: 0x00509A90 File Offset: 0x00507C90
	public override float GetProgress()
	{
		return this.CurrentProgress * 0.01f;
	}

	// Token: 0x0601126C RID: 70252 RVA: 0x00509A9E File Offset: 0x00507C9E
	public override bool IsAttachToActor()
	{
		SCommonQte config = this.Config;
		return config != null && config.BaseConfig.LongPressConfig.IsAttachToActor;
	}

	// Token: 0x0601126D RID: 70253 RVA: 0x00509ABC File Offset: 0x00507CBC
	public override SCommonQte_Attach? GetAttachConfig()
	{
		SCommonQte config = this.Config;
		if (config == null)
		{
			return null;
		}
		return new SCommonQte_Attach?(config.BaseConfig.LongPressConfig.AttachConfig);
	}

	// Token: 0x040096D5 RID: 38613
	public float InitProgress;

	// Token: 0x040096D6 RID: 38614
	public float MaxProgress;

	// Token: 0x040096D7 RID: 38615
	public float TargetProgress;

	// Token: 0x040096D8 RID: 38616
	public float IncreaseSpeed;

	// Token: 0x040096D9 RID: 38617
	public float DecreaseSpeed;

	// Token: 0x040096DA RID: 38618
	public float CurrentProgress;

	// Token: 0x040096DB RID: 38619
	public int ProgressAudioHandle;

	// Token: 0x040096DC RID: 38620
	public int RegressAudioHandle;

	// Token: 0x040096DD RID: 38621
	private bool IsPressing;

	// Token: 0x040096DE RID: 38622
	private bool CheckInResponseEnd;

	// Token: 0x040096DF RID: 38623
	private bool IsInResponseEnd;
}
