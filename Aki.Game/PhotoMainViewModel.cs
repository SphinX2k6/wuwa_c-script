using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using Cysharp.Threading.Tasks;

// Token: 0x02001A6A RID: 6762
[NullableContext(2)]
[Nullable(0)]
public class PhotoMainViewModel
{
	// Token: 0x1700193F RID: 6463
	// (get) Token: 0x06010B97 RID: 68503 RVA: 0x004E529F File Offset: 0x004E349F
	public PhotoCameraType CurrentMode
	{
		get
		{
			return this.CurrentModeInternal;
		}
	}

	// Token: 0x06010B98 RID: 68504 RVA: 0x004E52A7 File Offset: 0x004E34A7
	public UniTask PlaySwitchModeAnimAsync(PhotoCameraType target)
	{
		Func<PhotoCameraType, UniTask> onRequestPlaySwitchModeAnim = this.OnRequestPlaySwitchModeAnim;
		if (onRequestPlaySwitchModeAnim == null)
		{
			return UniTask.CompletedTask;
		}
		return onRequestPlaySwitchModeAnim(target);
	}

	// Token: 0x06010B99 RID: 68505 RVA: 0x004E52BF File Offset: 0x004E34BF
	public UniTask WaitSwitchModeAnimEndAsync(PhotoCameraType target)
	{
		Func<PhotoCameraType, UniTask> onRequestWaitSwitchModeAnimEnd = this.OnRequestWaitSwitchModeAnimEnd;
		if (onRequestWaitSwitchModeAnimEnd == null)
		{
			return UniTask.CompletedTask;
		}
		return onRequestWaitSwitchModeAnimEnd(target);
	}

	// Token: 0x06010B9A RID: 68506 RVA: 0x004E52D7 File Offset: 0x004E34D7
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

	// Token: 0x17001940 RID: 6464
	// (get) Token: 0x06010B9B RID: 68507 RVA: 0x004E52FB File Offset: 0x004E34FB
	public bool IsSwitchingMode
	{
		get
		{
			return this.IsSwitchingModeInternal;
		}
	}

	// Token: 0x06010B9C RID: 68508 RVA: 0x004E5303 File Offset: 0x004E3503
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

	// Token: 0x17001941 RID: 6465
	// (get) Token: 0x06010B9D RID: 68509 RVA: 0x004E5327 File Offset: 0x004E3527
	public int CurrentTabId
	{
		get
		{
			return this.CurrentTabIdInternal;
		}
	}

	// Token: 0x06010B9E RID: 68510 RVA: 0x004E532F File Offset: 0x004E352F
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

	// Token: 0x17001942 RID: 6466
	// (get) Token: 0x06010B9F RID: 68511 RVA: 0x004E5353 File Offset: 0x004E3553
	public int LastTabId
	{
		get
		{
			return this.LastTabIdInternal;
		}
	}

	// Token: 0x06010BA0 RID: 68512 RVA: 0x004E535B File Offset: 0x004E355B
	public void SetLastTabId(int tabId)
	{
		this.LastTabIdInternal = tabId;
	}

	// Token: 0x17001943 RID: 6467
	// (get) Token: 0x06010BA1 RID: 68513 RVA: 0x004E5364 File Offset: 0x004E3564
	public int CurrentStickerId
	{
		get
		{
			return this.CurrentStickerIdInternal;
		}
	}

	// Token: 0x06010BA2 RID: 68514 RVA: 0x004E536C File Offset: 0x004E356C
	public void SetStickerId(int stickerId)
	{
		this.CurrentStickerIdInternal = stickerId;
	}

	// Token: 0x17001944 RID: 6468
	// (get) Token: 0x06010BA3 RID: 68515 RVA: 0x004E5375 File Offset: 0x004E3575
	public int CurrentFrameId
	{
		get
		{
			return this.CurrentFrameIdInternal;
		}
	}

	// Token: 0x06010BA4 RID: 68516 RVA: 0x004E537D File Offset: 0x004E357D
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

	// Token: 0x06010BA5 RID: 68517 RVA: 0x004E53A1 File Offset: 0x004E35A1
	public void ResetFrameId()
	{
		this.CurrentFrameIdInternal = 1;
	}

	// Token: 0x0400937C RID: 37756
	private PhotoCameraType CurrentModeInternal;

	// Token: 0x0400937D RID: 37757
	public Action<PhotoCameraType> OnModeChanged;

	// Token: 0x0400937E RID: 37758
	public Func<PhotoCameraType, UniTask> OnRequestPlaySwitchModeAnim;

	// Token: 0x0400937F RID: 37759
	public Func<PhotoCameraType, UniTask> OnRequestWaitSwitchModeAnimEnd;

	// Token: 0x04009380 RID: 37760
	private bool IsSwitchingModeInternal;

	// Token: 0x04009381 RID: 37761
	public Action<bool> OnSwitchingModeChanged;

	// Token: 0x04009382 RID: 37762
	private int CurrentTabIdInternal;

	// Token: 0x04009383 RID: 37763
	public Action<int> OnTabChanged;

	// Token: 0x04009384 RID: 37764
	private int LastTabIdInternal;

	// Token: 0x04009385 RID: 37765
	public float FovInputValue;

	// Token: 0x04009386 RID: 37766
	public float MoveForwardInputValue;

	// Token: 0x04009387 RID: 37767
	public float MoveRightInputValue;

	// Token: 0x04009388 RID: 37768
	public float MoveUpInputValue;

	// Token: 0x04009389 RID: 37769
	public Action OnRequestClose;

	// Token: 0x0400938A RID: 37770
	public Action OnRequestHideUi;

	// Token: 0x0400938B RID: 37771
	public Action<bool> OnFilterDetailModeChanged;

	// Token: 0x0400938C RID: 37772
	public Action OnDetailPanelClosed;

	// Token: 0x0400938D RID: 37773
	public Action OnDetailPanelOpened;

	// Token: 0x0400938E RID: 37774
	public Action<PhotoSticker> OnRequestCreateSticker;

	// Token: 0x0400938F RID: 37775
	public Action OnRequestRemoveSticker;

	// Token: 0x04009390 RID: 37776
	public Action OnCameraReset;

	// Token: 0x04009391 RID: 37777
	private int CurrentStickerIdInternal = 1;

	// Token: 0x04009392 RID: 37778
	public Action<bool> OnStickerSelectedChanged;

	// Token: 0x04009393 RID: 37779
	public Action OnStickerRemoved;

	// Token: 0x04009394 RID: 37780
	public const int DEFAULT_FRAME_ID = 1;

	// Token: 0x04009395 RID: 37781
	private int CurrentFrameIdInternal = 1;

	// Token: 0x04009396 RID: 37782
	public Action<int> OnFrameSelected;

	// Token: 0x04009397 RID: 37783
	public const int DEFAULT_SELECT_ID = 1;

	// Token: 0x04009398 RID: 37784
	public int CurrentWeatherId;

	// Token: 0x04009399 RID: 37785
	public int CurrentWindId = 1;

	// Token: 0x0400939A RID: 37786
	public int CurrentWindStrength;

	// Token: 0x0400939B RID: 37787
	public int CurrentAtmosphereId = 1;

	// Token: 0x0400939C RID: 37788
	public int CurrentAtmosphereStrength;

	// Token: 0x0400939D RID: 37789
	public int CurrentLightId = 1;

	// Token: 0x0400939E RID: 37790
	public int CurrentLightDirection;

	// Token: 0x0400939F RID: 37791
	public int CurrentExpressionId = 1;

	// Token: 0x040093A0 RID: 37792
	public int CurrentSelfieMotionId = 1;

	// Token: 0x040093A1 RID: 37793
	public int CurrentTemplateId = 1;
}
