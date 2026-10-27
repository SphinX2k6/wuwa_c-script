using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using Cysharp.Threading.Tasks;

// Token: 0x0200257F RID: 9599
[NullableContext(2)]
[Nullable(0)]
public class PhotoMainViewModel
{
	// Token: 0x17001905 RID: 6405
	// (get) Token: 0x060136B6 RID: 79542 RVA: 0x004D6873 File Offset: 0x004D4A73
	public PhotoCameraType CurrentMode
	{
		get
		{
			return this.CurrentModeInternal;
		}
	}

	// Token: 0x060136B7 RID: 79543 RVA: 0x004D687B File Offset: 0x004D4A7B
	public UniTask PlaySwitchModeAnimAsync(PhotoCameraType target)
	{
		Func<PhotoCameraType, UniTask> onRequestPlaySwitchModeAnim = this.OnRequestPlaySwitchModeAnim;
		if (onRequestPlaySwitchModeAnim == null)
		{
			return UniTask.CompletedTask;
		}
		return onRequestPlaySwitchModeAnim(target);
	}

	// Token: 0x060136B8 RID: 79544 RVA: 0x004D6893 File Offset: 0x004D4A93
	public UniTask WaitSwitchModeAnimEndAsync(PhotoCameraType target)
	{
		Func<PhotoCameraType, UniTask> onRequestWaitSwitchModeAnimEnd = this.OnRequestWaitSwitchModeAnimEnd;
		if (onRequestWaitSwitchModeAnimEnd == null)
		{
			return UniTask.CompletedTask;
		}
		return onRequestWaitSwitchModeAnimEnd(target);
	}

	// Token: 0x060136B9 RID: 79545 RVA: 0x004D68AB File Offset: 0x004D4AAB
	public void SetMode(PhotoCameraType mode)
	{
		if (this.CurrentModeInternal == mode)
		{
			return;
		}
		this.CurrentModeInternal = mode;
		Action<PhotoCameraType> onModeChanged = this.OnModeChanged;
		if (onModeChanged == null)
		{
			return;
		}
		onModeChanged(mode);
	}

	// Token: 0x17001906 RID: 6406
	// (get) Token: 0x060136BA RID: 79546 RVA: 0x004D68CF File Offset: 0x004D4ACF
	public bool IsSwitchingMode
	{
		get
		{
			return this.IsSwitchingModeInternal;
		}
	}

	// Token: 0x060136BB RID: 79547 RVA: 0x004D68D7 File Offset: 0x004D4AD7
	public void SetSwitchingMode(bool switching)
	{
		if (this.IsSwitchingModeInternal == switching)
		{
			return;
		}
		this.IsSwitchingModeInternal = switching;
		Action<bool> onSwitchingModeChanged = this.OnSwitchingModeChanged;
		if (onSwitchingModeChanged == null)
		{
			return;
		}
		onSwitchingModeChanged(switching);
	}

	// Token: 0x17001907 RID: 6407
	// (get) Token: 0x060136BC RID: 79548 RVA: 0x004D68FB File Offset: 0x004D4AFB
	public int CurrentTabId
	{
		get
		{
			return this.CurrentTabIdInternal;
		}
	}

	// Token: 0x060136BD RID: 79549 RVA: 0x004D6903 File Offset: 0x004D4B03
	public void SetTabId(int tabId)
	{
		if (this.CurrentTabIdInternal == tabId)
		{
			return;
		}
		this.CurrentTabIdInternal = tabId;
		Action<int> onTabChanged = this.OnTabChanged;
		if (onTabChanged == null)
		{
			return;
		}
		onTabChanged(tabId);
	}

	// Token: 0x17001908 RID: 6408
	// (get) Token: 0x060136BE RID: 79550 RVA: 0x004D6927 File Offset: 0x004D4B27
	public int LastTabId
	{
		get
		{
			return this.LastTabIdInternal;
		}
	}

	// Token: 0x060136BF RID: 79551 RVA: 0x004D692F File Offset: 0x004D4B2F
	public void SetLastTabId(int tabId)
	{
		this.LastTabIdInternal = tabId;
	}

	// Token: 0x17001909 RID: 6409
	// (get) Token: 0x060136C0 RID: 79552 RVA: 0x004D6938 File Offset: 0x004D4B38
	public int CurrentStickerId
	{
		get
		{
			return this.CurrentStickerIdInternal;
		}
	}

	// Token: 0x060136C1 RID: 79553 RVA: 0x004D6940 File Offset: 0x004D4B40
	public void SetStickerId(int stickerId)
	{
		this.CurrentStickerIdInternal = stickerId;
	}

	// Token: 0x1700190A RID: 6410
	// (get) Token: 0x060136C2 RID: 79554 RVA: 0x004D6949 File Offset: 0x004D4B49
	public int CurrentFrameId
	{
		get
		{
			return this.CurrentFrameIdInternal;
		}
	}

	// Token: 0x060136C3 RID: 79555 RVA: 0x004D6951 File Offset: 0x004D4B51
	public void SetFrameId(int frameId)
	{
		if (this.CurrentFrameIdInternal == frameId)
		{
			return;
		}
		this.CurrentFrameIdInternal = frameId;
		Action<int> onFrameSelected = this.OnFrameSelected;
		if (onFrameSelected == null)
		{
			return;
		}
		onFrameSelected(frameId);
	}

	// Token: 0x060136C4 RID: 79556 RVA: 0x004D6975 File Offset: 0x004D4B75
	public void ResetFrameId()
	{
		this.CurrentFrameIdInternal = 1;
	}

	// Token: 0x04009224 RID: 37412
	private PhotoCameraType CurrentModeInternal;

	// Token: 0x04009225 RID: 37413
	public Action<PhotoCameraType> OnModeChanged;

	// Token: 0x04009226 RID: 37414
	public Func<PhotoCameraType, UniTask> OnRequestPlaySwitchModeAnim;

	// Token: 0x04009227 RID: 37415
	public Func<PhotoCameraType, UniTask> OnRequestWaitSwitchModeAnimEnd;

	// Token: 0x04009228 RID: 37416
	private bool IsSwitchingModeInternal;

	// Token: 0x04009229 RID: 37417
	public Action<bool> OnSwitchingModeChanged;

	// Token: 0x0400922A RID: 37418
	private int CurrentTabIdInternal;

	// Token: 0x0400922B RID: 37419
	public Action<int> OnTabChanged;

	// Token: 0x0400922C RID: 37420
	private int LastTabIdInternal;

	// Token: 0x0400922D RID: 37421
	public float FovInputValue;

	// Token: 0x0400922E RID: 37422
	public float MoveForwardInputValue;

	// Token: 0x0400922F RID: 37423
	public float MoveRightInputValue;

	// Token: 0x04009230 RID: 37424
	public float MoveUpInputValue;

	// Token: 0x04009231 RID: 37425
	public Action OnRequestClose;

	// Token: 0x04009232 RID: 37426
	public Action OnRequestHideUi;

	// Token: 0x04009233 RID: 37427
	public Action<bool> OnFilterDetailModeChanged;

	// Token: 0x04009234 RID: 37428
	public Action OnDetailPanelClosed;

	// Token: 0x04009235 RID: 37429
	public Action OnDetailPanelOpened;

	// Token: 0x04009236 RID: 37430
	public Action<PhotoSticker> OnRequestCreateSticker;

	// Token: 0x04009237 RID: 37431
	public Action OnRequestRemoveSticker;

	// Token: 0x04009238 RID: 37432
	public Action OnCameraReset;

	// Token: 0x04009239 RID: 37433
	private int CurrentStickerIdInternal = 1;

	// Token: 0x0400923A RID: 37434
	public Action<bool> OnStickerSelectedChanged;

	// Token: 0x0400923B RID: 37435
	public Action OnStickerRemoved;

	// Token: 0x0400923C RID: 37436
	public const int DEFAULT_FRAME_ID = 1;

	// Token: 0x0400923D RID: 37437
	private int CurrentFrameIdInternal = 1;

	// Token: 0x0400923E RID: 37438
	public Action<int> OnFrameSelected;

	// Token: 0x0400923F RID: 37439
	public const int DEFAULT_SELECT_ID = 1;

	// Token: 0x04009240 RID: 37440
	public int CurrentWeatherId;

	// Token: 0x04009241 RID: 37441
	public int CurrentWindId = 1;

	// Token: 0x04009242 RID: 37442
	public int CurrentWindStrength;

	// Token: 0x04009243 RID: 37443
	public int CurrentAtmosphereId = 1;

	// Token: 0x04009244 RID: 37444
	public int CurrentAtmosphereStrength;

	// Token: 0x04009245 RID: 37445
	public int CurrentLightId = 1;

	// Token: 0x04009246 RID: 37446
	public int CurrentLightDirection;

	// Token: 0x04009247 RID: 37447
	public int CurrentExpressionId = 1;

	// Token: 0x04009248 RID: 37448
	public int CurrentSelfieMotionId = 1;

	// Token: 0x04009249 RID: 37449
	public int CurrentTemplateId = 1;
}
