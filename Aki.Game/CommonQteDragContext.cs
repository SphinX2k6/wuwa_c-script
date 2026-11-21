using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;

// Token: 0x02001AF1 RID: 6897
[NullableContext(2)]
[Nullable(0)]
public class CommonQteDragContext : CommonQteContextBase
{
	// Token: 0x0601123D RID: 70205 RVA: 0x00508744 File Offset: 0x00506944
	public CommonQteDragContext()
	{
		this.Type = new ECommonQteContextType?(ECommonQteContextType.SingleButtonDrag);
	}

	// Token: 0x0601123E RID: 70206 RVA: 0x00508768 File Offset: 0x00506968
	[NullableContext(1)]
	protected override void OnSetConfig(SCommonQte config)
	{
		SCommonQte_Drag dragConfig = config.BaseConfig.DragConfig;
		this.IsCheckByRealInput = config.BaseConfig.DragConfig.CheckByRealTimeInput;
		this.Direction = (float)dragConfig.Direction * 0.017453292f;
		this.ToleranceAngle = dragConfig.ToleranceAngle * 0.017453292f + 1E-08f;
		float num = 0f;
		this.CacheProgress = 0f;
		if (dragConfig.ViewType == ECommonQteViewType_Drag.右半屏拖动界面)
		{
			num = dragConfig.DragLength;
		}
		else if (this.IsSlideLengthViewType(dragConfig.ViewType))
		{
			num = dragConfig.SlideLength;
		}
		else if (dragConfig.ViewType == ECommonQteViewType_Drag.穗穗左右滑界面)
		{
			this.Length = 0.5f;
			this.CacheProgress = 0.5f;
			num = (dragConfig.IsLeftSuccess ? dragConfig.LeftSlideLength : dragConfig.RightSlideLength);
		}
		if (num > 0f && dragConfig.LerpSpeed > 0f)
		{
			float num2 = (dragConfig.ViewType == ECommonQteViewType_Drag.穗穗左右滑界面) ? 0.5f : 1f;
			this.LerpSpeedInProgress = (double)(dragConfig.LerpSpeed * num2 / num / 1000f);
			return;
		}
		this.LerpSpeedInProgress = -1.0;
	}

	// Token: 0x0601123F RID: 70207 RVA: 0x005088A7 File Offset: 0x00506AA7
	private bool IsSlideLengthViewType(ECommonQteViewType_Drag viewType)
	{
		return viewType == ECommonQteViewType_Drag.全屏上拉界面 || viewType == ECommonQteViewType_Drag.全屏下拉界面 || viewType == ECommonQteViewType_Drag.穗穗右滑界面 || viewType == ECommonQteViewType_Drag.穗穗下滑界面 || viewType == ECommonQteViewType_Drag.莉莉左滑界面 || viewType == ECommonQteViewType_Drag.沙盘滑动界面;
	}

	// Token: 0x06011240 RID: 70208 RVA: 0x005088C8 File Offset: 0x00506AC8
	protected override string OnGetAction(int? index = null)
	{
		if (this.Config == null)
		{
			return null;
		}
		if (this.Config.BaseConfig.DragConfig.ViewType == ECommonQteViewType_Drag.滑动通用界面)
		{
			return "Ui右摇杆";
		}
		SCommonQteButton uiconfig = this.Config.BaseConfig.DragConfig.UIConfig;
		return CommonQteContextBase.GetQteActionNameByActionId((uiconfig.ActionId > 0) ? uiconfig.ActionId : ((int)uiconfig.Action), new int?(this.QteId));
	}

	// Token: 0x06011241 RID: 70209 RVA: 0x0050894F File Offset: 0x00506B4F
	[PreserveBaseOverrides]
	protected new virtual SCommonQte_Drag OnGetUiConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.DragConfig;
	}

	// Token: 0x06011242 RID: 70210 RVA: 0x00508971 File Offset: 0x00506B71
	protected override SCommonQteButton GetUiButtonConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.DragConfig.UIConfig;
	}

	// Token: 0x06011243 RID: 70211 RVA: 0x00508998 File Offset: 0x00506B98
	protected override void OnResponse()
	{
		if (this.Config == null)
		{
			return;
		}
		if (base.IsPending())
		{
			CommonQteController.Instance.PlayExtraEffect(this.HandleId);
			if (this.AudioHandle != 0)
			{
				CommonQteController.Instance.StopQteAudio(this.AudioHandle, null);
				this.AudioHandle = 0;
			}
			this.AudioHandle = CommonQteController.Instance.PlayQteAudio(this.Config.AudioConfig.AudioEventResponse, this.UiActor);
		}
	}

	// Token: 0x06011244 RID: 70212 RVA: 0x00508A1C File Offset: 0x00506C1C
	protected override void OnResponseEnd()
	{
		if (this.Config == null)
		{
			return;
		}
		CommonQteController.Instance.StopExtraEffect(this.HandleId);
		if (this.AudioHandle != 0)
		{
			CommonQteController.Instance.StopQteAudio(this.AudioHandle, null);
			this.AudioHandle = 0;
		}
		if (base.IsPending())
		{
			this.AudioHandle = CommonQteController.Instance.PlayQteAudio(this.Config.AudioConfig.AudioEventResponseEnd, this.UiActor);
		}
	}

	// Token: 0x06011245 RID: 70213 RVA: 0x00508AA0 File Offset: 0x00506CA0
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
		float progress = this.GetProgress();
		if (base.IsPending())
		{
			AudioSystem.Instance.SetRtpcValue("perform_qte_progress_default", this.GetProgress(), new SetRtpcValueArgs?(new SetRtpcValueArgs
			{
				Actor = this.UiActor
			}));
			if (progress > this.CacheProgress)
			{
				if (this.RegressAudioHandle != 0)
				{
					CommonQteController.Instance.StopQteAudio(this.RegressAudioHandle, null);
					this.RegressAudioHandle = 0;
				}
				if (this.ProgressAudioHandle == 0 && this.Config.AudioConfig.AudioEventProgress != null)
				{
					this.ProgressAudioHandle = CommonQteController.Instance.PlayQteAudio(this.Config.AudioConfig.AudioEventProgress, this.UiActor);
					CommonQteController.Instance.SeekAudio(progress, this.Config.AudioConfig.AudioEventProgress, this.UiActor, new int?(this.ProgressAudioHandle));
				}
			}
			else if (progress < this.CacheProgress)
			{
				if (this.ProgressAudioHandle != 0)
				{
					CommonQteController.Instance.StopQteAudio(this.ProgressAudioHandle, null);
					this.ProgressAudioHandle = 0;
				}
				if (this.RegressAudioHandle == 0 && this.Config.AudioConfig.AudioEventRegress != null)
				{
					this.RegressAudioHandle = CommonQteController.Instance.PlayQteAudio(this.Config.AudioConfig.AudioEventRegress, this.UiActor);
					CommonQteController.Instance.SeekAudio(progress, this.Config.AudioConfig.AudioEventRegress, this.UiActor, new int?(this.RegressAudioHandle));
				}
				if (progress == 0f)
				{
					CommonQteController.Instance.PlayQteAudio(this.Config.AudioConfig.AudioEventReset, this.UiActor);
				}
			}
		}
		this.CacheProgress = progress;
		if (!this.IsPermanent && this.PassTime > this.Duration)
		{
			base.QteFail();
		}
	}

	// Token: 0x06011246 RID: 70214 RVA: 0x00508CEE File Offset: 0x00506EEE
	public override bool CheckQteConditionMatch()
	{
		return this.PreResult.GetValueOrDefault() || this.CheckDragComplete(this.Length, this.Angle);
	}

	// Token: 0x06011247 RID: 70215 RVA: 0x00508D11 File Offset: 0x00506F11
	public void SetPreResult(bool isSuccess)
	{
		this.PreResult = new bool?(isSuccess);
	}

	// Token: 0x06011248 RID: 70216 RVA: 0x00508D1F File Offset: 0x00506F1F
	protected override void OnQteSuccess()
	{
		this.StopQteAudio();
	}

	// Token: 0x06011249 RID: 70217 RVA: 0x00508D27 File Offset: 0x00506F27
	protected override void OnQteFail()
	{
		this.StopQteAudio();
	}

	// Token: 0x0601124A RID: 70218 RVA: 0x00508D2F File Offset: 0x00506F2F
	public void StopMoveAudioAndSyncProgress()
	{
		this.StopQteAudio();
		this.CacheProgress = this.GetProgress();
	}

	// Token: 0x0601124B RID: 70219 RVA: 0x00508D44 File Offset: 0x00506F44
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

	// Token: 0x0601124C RID: 70220 RVA: 0x00508DBC File Offset: 0x00506FBC
	public bool CheckDragComplete(float length, float angle)
	{
		SCommonQte config = this.Config;
		SCommonQte_Drag scommonQte_Drag = (config != null) ? config.BaseConfig.DragConfig : null;
		if (scommonQte_Drag == null)
		{
			return false;
		}
		if (scommonQte_Drag.ViewType == ECommonQteViewType_Drag.沙盘滑动界面)
		{
			if (length >= scommonQte_Drag.SlideLength)
			{
				return true;
			}
		}
		else if (scommonQte_Drag.ViewType == ECommonQteViewType_Drag.滑动通用界面)
		{
			if (length >= scommonQte_Drag.SlideLength && CommonQteDragContext.GetAngleDifference(angle, this.Direction) <= this.ToleranceAngle)
			{
				return true;
			}
		}
		else if (scommonQte_Drag.ViewType == ECommonQteViewType_Drag.全屏上拉界面)
		{
			if (length >= scommonQte_Drag.SlideLength && Math.Abs(angle - 1.5707964f) <= this.ToleranceAngle)
			{
				return true;
			}
		}
		else if (scommonQte_Drag.ViewType == ECommonQteViewType_Drag.全屏下拉界面 || scommonQte_Drag.ViewType == ECommonQteViewType_Drag.穗穗下滑界面)
		{
			if (length >= scommonQte_Drag.SlideLength && Math.Abs(angle - -1.5707964f) <= this.ToleranceAngle)
			{
				return true;
			}
		}
		else if (scommonQte_Drag.ViewType == ECommonQteViewType_Drag.穗穗右滑界面)
		{
			if (length >= scommonQte_Drag.SlideLength && Math.Abs(angle) <= this.ToleranceAngle)
			{
				return true;
			}
		}
		else if (scommonQte_Drag.ViewType == ECommonQteViewType_Drag.莉莉左滑界面)
		{
			if (length >= scommonQte_Drag.SlideLength && CommonQteDragContext.GetAngleDifference(angle, 3.1415927f) <= this.ToleranceAngle)
			{
				return true;
			}
		}
		else if (scommonQte_Drag.ViewType == ECommonQteViewType_Drag.罗盘旋转界面)
		{
			if (Math.Abs(angle - 1.5707964f) <= this.ToleranceAngle)
			{
				return true;
			}
		}
		else if (scommonQte_Drag.ViewType == ECommonQteViewType_Drag.右半屏拖动界面)
		{
			if (length >= 1f)
			{
				return true;
			}
		}
		else if (scommonQte_Drag.ViewType == ECommonQteViewType_Drag.穗穗左右滑界面)
		{
			if (scommonQte_Drag.IsLeftSuccess)
			{
				return scommonQte_Drag.LeftSlideLength > 0f && length <= 0f;
			}
			return scommonQte_Drag.RightSlideLength > 0f && length >= 1f;
		}
		return false;
	}

	// Token: 0x0601124D RID: 70221 RVA: 0x00508FD0 File Offset: 0x005071D0
	private static float GetAngleDifference(float angleA, float angleB)
	{
		float num = angleA - angleB;
		return Math.Abs((float)Math.Atan2(Math.Sin((double)num), Math.Cos((double)num)));
	}

	// Token: 0x0601124E RID: 70222 RVA: 0x00508FFC File Offset: 0x005071FC
	public bool CheckDragFail(float progress)
	{
		SCommonQte config = this.Config;
		SCommonQte_Drag scommonQte_Drag = (config != null) ? config.BaseConfig.DragConfig : null;
		if (scommonQte_Drag == null || scommonQte_Drag.ViewType != ECommonQteViewType_Drag.穗穗左右滑界面)
		{
			return false;
		}
		if (scommonQte_Drag.IsLeftSuccess)
		{
			return scommonQte_Drag.RightSlideLength > 0f && progress >= 1f;
		}
		return scommonQte_Drag.LeftSlideLength > 0f && progress <= 0f;
	}

	// Token: 0x0601124F RID: 70223 RVA: 0x0050907C File Offset: 0x0050727C
	public float GetSequenceResultProgress(bool isSuccess)
	{
		SCommonQte config = this.Config;
		SCommonQte_Drag scommonQte_Drag = (config != null) ? config.BaseConfig.DragConfig : null;
		if (!(scommonQte_Drag != null) || !(scommonQte_Drag.ViewType == ECommonQteViewType_Drag.穗穗左右滑界面))
		{
			return 1f;
		}
		if (!(isSuccess ? scommonQte_Drag.IsLeftSuccess : (!scommonQte_Drag.IsLeftSuccess)))
		{
			return 1f;
		}
		return 0f;
	}

	// Token: 0x06011250 RID: 70224 RVA: 0x005090E4 File Offset: 0x005072E4
	public double GetSequenceResultLerpSpeedInProgress(bool isSuccess)
	{
		SCommonQte config = this.Config;
		SCommonQte_Drag scommonQte_Drag = (config != null) ? config.BaseConfig.DragConfig : null;
		if (scommonQte_Drag == null || scommonQte_Drag.ViewType != ECommonQteViewType_Drag.穗穗左右滑界面)
		{
			return this.LerpSpeedInProgress;
		}
		float num = (isSuccess ? scommonQte_Drag.IsLeftSuccess : (!scommonQte_Drag.IsLeftSuccess)) ? scommonQte_Drag.LeftSlideLength : scommonQte_Drag.RightSlideLength;
		if (num > 0f && scommonQte_Drag.LerpSpeed > 0f)
		{
			return (double)(scommonQte_Drag.LerpSpeed * 0.5f / num / 1000f);
		}
		return -1.0;
	}

	// Token: 0x06011251 RID: 70225 RVA: 0x00509188 File Offset: 0x00507388
	public override float GetProgress()
	{
		SCommonQte config = this.Config;
		SCommonQte_Drag scommonQte_Drag = (config != null) ? config.BaseConfig.DragConfig : null;
		if (scommonQte_Drag == null)
		{
			return 0f;
		}
		if (this.IsSlideLengthViewType(scommonQte_Drag.ViewType))
		{
			return this.Length / scommonQte_Drag.SlideLength;
		}
		if (scommonQte_Drag.ViewType == ECommonQteViewType_Drag.罗盘旋转界面)
		{
			return this.Angle / 1.5707964f;
		}
		if (scommonQte_Drag.ViewType == ECommonQteViewType_Drag.右半屏拖动界面)
		{
			return this.Length;
		}
		if (scommonQte_Drag.ViewType == ECommonQteViewType_Drag.穗穗左右滑界面)
		{
			return this.Length;
		}
		return 0f;
	}

	// Token: 0x06011252 RID: 70226 RVA: 0x00509236 File Offset: 0x00507436
	public void SetDraggingInfo(float length, float angle)
	{
		this.Length = length;
		this.Angle = angle;
		this.CheckQteConditionAndDoSuccess();
	}

	// Token: 0x06011253 RID: 70227 RVA: 0x0050924D File Offset: 0x0050744D
	public override bool IsAttachToActor()
	{
		SCommonQte config = this.Config;
		return config != null && config.BaseConfig.DragConfig.IsAttachToActor;
	}

	// Token: 0x06011254 RID: 70228 RVA: 0x0050926C File Offset: 0x0050746C
	public override SCommonQte_Attach? GetAttachConfig()
	{
		SCommonQte config = this.Config;
		if (config == null)
		{
			return null;
		}
		return new SCommonQte_Attach?(config.BaseConfig.DragConfig.AttachConfig);
	}

	// Token: 0x040096C4 RID: 38596
	private float Length;

	// Token: 0x040096C5 RID: 38597
	private float Angle;

	// Token: 0x040096C6 RID: 38598
	private float Direction;

	// Token: 0x040096C7 RID: 38599
	private float ToleranceAngle;

	// Token: 0x040096C8 RID: 38600
	private float CacheProgress;

	// Token: 0x040096C9 RID: 38601
	public bool? PreResult;

	// Token: 0x040096CA RID: 38602
	public bool IsCheckByRealInput;

	// Token: 0x040096CB RID: 38603
	public double LerpSpeedInProgress = -1.0;

	// Token: 0x040096CC RID: 38604
	private const float DEGREE_90_RAD = 1.5707964f;

	// Token: 0x040096CD RID: 38605
	private const float DEGREE_270_RAD = -1.5707964f;

	// Token: 0x040096CE RID: 38606
	private const float SUISUI_LEFT_PROGRESS = 0f;

	// Token: 0x040096CF RID: 38607
	private const float SUISUI_CENTER_PROGRESS = 0.5f;

	// Token: 0x040096D0 RID: 38608
	private const float SUISUI_RIGHT_PROGRESS = 1f;

	// Token: 0x040096D1 RID: 38609
	public int ProgressAudioHandle;

	// Token: 0x040096D2 RID: 38610
	public int RegressAudioHandle;
}
