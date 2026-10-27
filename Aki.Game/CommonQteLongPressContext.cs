using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;

// Token: 0x02002608 RID: 9736
[NullableContext(2)]
[Nullable(0)]
public class CommonQteLongPressContext : CommonQteContextBase
{
	// Token: 0x06013D7C RID: 81276 RVA: 0x004FA6F8 File Offset: 0x004F88F8
	public CommonQteLongPressContext()
	{
		this.Type = new ECommonQteContextType?(ECommonQteContextType.SingleButtonLongPress);
	}

	// Token: 0x06013D7D RID: 81277 RVA: 0x004FA70C File Offset: 0x004F890C
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

	// Token: 0x06013D7E RID: 81278 RVA: 0x004FA794 File Offset: 0x004F8994
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

	// Token: 0x06013D7F RID: 81279 RVA: 0x004FA810 File Offset: 0x004F8A10
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

	// Token: 0x06013D80 RID: 81280 RVA: 0x004FA87C File Offset: 0x004F8A7C
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

	// Token: 0x06013D81 RID: 81281 RVA: 0x004FAB2C File Offset: 0x004F8D2C
	protected override void OnQteFail()
	{
		this.StopQteAudio();
	}

	// Token: 0x06013D82 RID: 81282 RVA: 0x004FAB34 File Offset: 0x004F8D34
	protected override void OnQteSuccess()
	{
		this.StopQteAudio();
	}

	// Token: 0x06013D83 RID: 81283 RVA: 0x004FAB3C File Offset: 0x004F8D3C
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

	// Token: 0x06013D84 RID: 81284 RVA: 0x004FABB4 File Offset: 0x004F8DB4
	protected override string OnGetAction(int? index = null)
	{
		if (this.Config == null)
		{
			return null;
		}
		SCommonQteButton uiconfig = this.Config.BaseConfig.LongPressConfig.UIConfig;
		return CommonQteContextBase.GetQteActionNameByActionId((uiconfig.ActionId > 0) ? uiconfig.ActionId : ((int)uiconfig.Action), new int?(this.QteId));
	}

	// Token: 0x06013D85 RID: 81285 RVA: 0x004FAC13 File Offset: 0x004F8E13
	[PreserveBaseOverrides]
	protected new virtual SCommonQte_LongPress OnGetUiConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.LongPressConfig;
	}

	// Token: 0x06013D86 RID: 81286 RVA: 0x004FAC35 File Offset: 0x004F8E35
	protected override SCommonQteButton GetUiButtonConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.LongPressConfig.UIConfig;
	}

	// Token: 0x06013D87 RID: 81287 RVA: 0x004FAC5C File Offset: 0x004F8E5C
	public override bool CheckQteConditionMatch()
	{
		if (this.CheckInResponseEnd)
		{
			return this.IsInResponseEnd && this.CheckProgressCondition();
		}
		return this.CheckProgressCondition();
	}

	// Token: 0x06013D88 RID: 81288 RVA: 0x004FAC7D File Offset: 0x004F8E7D
	private bool CheckProgressCondition()
	{
		return this.CurrentProgress >= this.TargetProgress;
	}

	// Token: 0x06013D89 RID: 81289 RVA: 0x004FAC90 File Offset: 0x004F8E90
	public override float GetProgress()
	{
		return this.CurrentProgress * 0.01f;
	}

	// Token: 0x06013D8A RID: 81290 RVA: 0x004FAC9E File Offset: 0x004F8E9E
	public override bool IsAttachToActor()
	{
		SCommonQte config = this.Config;
		return config != null && config.BaseConfig.LongPressConfig.IsAttachToActor;
	}

	// Token: 0x06013D8B RID: 81291 RVA: 0x004FACBC File Offset: 0x004F8EBC
	public override SCommonQte_Attach? GetAttachConfig()
	{
		SCommonQte config = this.Config;
		if (config == null)
		{
			return null;
		}
		return new SCommonQte_Attach?(config.BaseConfig.LongPressConfig.AttachConfig);
	}

	// Token: 0x0400957E RID: 38270
	public float InitProgress;

	// Token: 0x0400957F RID: 38271
	public float MaxProgress;

	// Token: 0x04009580 RID: 38272
	public float TargetProgress;

	// Token: 0x04009581 RID: 38273
	public float IncreaseSpeed;

	// Token: 0x04009582 RID: 38274
	public float DecreaseSpeed;

	// Token: 0x04009583 RID: 38275
	public float CurrentProgress;

	// Token: 0x04009584 RID: 38276
	public int ProgressAudioHandle;

	// Token: 0x04009585 RID: 38277
	public int RegressAudioHandle;

	// Token: 0x04009586 RID: 38278
	private bool IsPressing;

	// Token: 0x04009587 RID: 38279
	private bool CheckInResponseEnd;

	// Token: 0x04009588 RID: 38280
	private bool IsInResponseEnd;
}
