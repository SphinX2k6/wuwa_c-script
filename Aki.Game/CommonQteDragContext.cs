using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;

// Token: 0x02002606 RID: 9734
[NullableContext(2)]
[Nullable(0)]
public class CommonQteDragContext : CommonQteContextBase
{
	// Token: 0x06013D5B RID: 81243 RVA: 0x004F996C File Offset: 0x004F7B6C
	public CommonQteDragContext()
	{
		this.Type = new ECommonQteContextType?(ECommonQteContextType.SingleButtonDrag);
	}

	// Token: 0x06013D5C RID: 81244 RVA: 0x004F9990 File Offset: 0x004F7B90
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

	// Token: 0x06013D5D RID: 81245 RVA: 0x004F9ACF File Offset: 0x004F7CCF
	private bool IsSlideLengthViewType(ECommonQteViewType_Drag viewType)
	{
		return viewType == ECommonQteViewType_Drag.全屏上拉界面 || viewType == ECommonQteViewType_Drag.全屏下拉界面 || viewType == ECommonQteViewType_Drag.穗穗右滑界面 || viewType == ECommonQteViewType_Drag.穗穗下滑界面 || viewType == ECommonQteViewType_Drag.沙盘滑动界面;
	}

	// Token: 0x06013D5E RID: 81246 RVA: 0x004F9AE8 File Offset: 0x004F7CE8
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

	// Token: 0x06013D5F RID: 81247 RVA: 0x004F9B6F File Offset: 0x004F7D6F
	[PreserveBaseOverrides]
	protected new virtual SCommonQte_Drag OnGetUiConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.DragConfig;
	}

	// Token: 0x06013D60 RID: 81248 RVA: 0x004F9B91 File Offset: 0x004F7D91
	protected override SCommonQteButton GetUiButtonConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.DragConfig.UIConfig;
	}

	// Token: 0x06013D61 RID: 81249 RVA: 0x004F9BB8 File Offset: 0x004F7DB8
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

	// Token: 0x06013D62 RID: 81250 RVA: 0x004F9C3C File Offset: 0x004F7E3C
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

	// Token: 0x06013D63 RID: 81251 RVA: 0x004F9CC0 File Offset: 0x004F7EC0
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

	// Token: 0x06013D64 RID: 81252 RVA: 0x004F9F18 File Offset: 0x004F8118
	public override bool CheckQteConditionMatch()
	{
		return this.PreResult.GetValueOrDefault() || this.CheckDragComplete(this.Length, this.Angle);
	}

	// Token: 0x06013D65 RID: 81253 RVA: 0x004F9F3B File Offset: 0x004F813B
	public void SetPreResult(bool isSuccess)
	{
		this.PreResult = new bool?(isSuccess);
	}

	// Token: 0x06013D66 RID: 81254 RVA: 0x004F9F49 File Offset: 0x004F8149
	protected override void OnQteSuccess()
	{
		this.StopQteAudio();
	}

	// Token: 0x06013D67 RID: 81255 RVA: 0x004F9F51 File Offset: 0x004F8151
	protected override void OnQteFail()
	{
		this.StopQteAudio();
	}

	// Token: 0x06013D68 RID: 81256 RVA: 0x004F9F59 File Offset: 0x004F8159
	public void StopMoveAudioAndSyncProgress()
	{
		this.StopQteAudio();
		this.CacheProgress = this.GetProgress();
	}

	// Token: 0x06013D69 RID: 81257 RVA: 0x004F9F70 File Offset: 0x004F8170
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

	// Token: 0x06013D6A RID: 81258 RVA: 0x004F9FE8 File Offset: 0x004F81E8
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

	// Token: 0x06013D6B RID: 81259 RVA: 0x004FA1C4 File Offset: 0x004F83C4
	private static float GetAngleDifference(float angleA, float angleB)
	{
		float num = angleA - angleB;
		return Math.Abs((float)Math.Atan2(Math.Sin((double)num), Math.Cos((double)num)));
	}

	// Token: 0x06013D6C RID: 81260 RVA: 0x004FA1F0 File Offset: 0x004F83F0
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

	// Token: 0x06013D6D RID: 81261 RVA: 0x004FA270 File Offset: 0x004F8470
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

	// Token: 0x06013D6E RID: 81262 RVA: 0x004FA2D8 File Offset: 0x004F84D8
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

	// Token: 0x06013D6F RID: 81263 RVA: 0x004FA37C File Offset: 0x004F857C
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

	// Token: 0x06013D70 RID: 81264 RVA: 0x004FA42A File Offset: 0x004F862A
	public void SetDraggingInfo(float length, float angle)
	{
		this.Length = length;
		this.Angle = angle;
		this.CheckQteConditionAndDoSuccess();
	}

	// Token: 0x06013D71 RID: 81265 RVA: 0x004FA441 File Offset: 0x004F8641
	public override bool IsAttachToActor()
	{
		SCommonQte config = this.Config;
		return config != null && config.BaseConfig.DragConfig.IsAttachToActor;
	}

	// Token: 0x06013D72 RID: 81266 RVA: 0x004FA460 File Offset: 0x004F8660
	public override SCommonQte_Attach? GetAttachConfig()
	{
		SCommonQte config = this.Config;
		if (config == null)
		{
			return null;
		}
		return new SCommonQte_Attach?(config.BaseConfig.DragConfig.AttachConfig);
	}

	// Token: 0x0400956D RID: 38253
	private float Length;

	// Token: 0x0400956E RID: 38254
	private float Angle;

	// Token: 0x0400956F RID: 38255
	private float Direction;

	// Token: 0x04009570 RID: 38256
	private float ToleranceAngle;

	// Token: 0x04009571 RID: 38257
	private float CacheProgress;

	// Token: 0x04009572 RID: 38258
	public bool? PreResult;

	// Token: 0x04009573 RID: 38259
	public bool IsCheckByRealInput;

	// Token: 0x04009574 RID: 38260
	public double LerpSpeedInProgress = -1.0;

	// Token: 0x04009575 RID: 38261
	private const float DEGREE_90_RAD = 1.5707964f;

	// Token: 0x04009576 RID: 38262
	private const float DEGREE_270_RAD = -1.5707964f;

	// Token: 0x04009577 RID: 38263
	private const float SUISUI_LEFT_PROGRESS = 0f;

	// Token: 0x04009578 RID: 38264
	private const float SUISUI_CENTER_PROGRESS = 0.5f;

	// Token: 0x04009579 RID: 38265
	private const float SUISUI_RIGHT_PROGRESS = 1f;

	// Token: 0x0400957A RID: 38266
	public int ProgressAudioHandle;

	// Token: 0x0400957B RID: 38267
	public int RegressAudioHandle;
}
