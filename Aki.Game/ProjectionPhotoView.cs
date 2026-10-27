using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf;
using UnrealEngine;

// Token: 0x02000EED RID: 3821
[NullableContext(2)]
[Nullable(0)]
public class ProjectionPhotoView : UiTickViewBase
{
	// Token: 0x17000759 RID: 1881
	// (get) Token: 0x06005FD3 RID: 24531 RVA: 0x0011F766 File Offset: 0x0011D966
	private new ProjectionPhotoViewParams OpenParam
	{
		get
		{
			return this.OpenParam as ProjectionPhotoViewParams;
		}
	}

	// Token: 0x06005FD4 RID: 24532 RVA: 0x0011F774 File Offset: 0x0011D974
	[NullableContext(1)]
	public ProjectionPhotoView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06005FD5 RID: 24533 RVA: 0x0011F7D0 File Offset: 0x0011D9D0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(3, typeof(UUISliderComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIText))
		};
	}

	// Token: 0x06005FD6 RID: 24534 RVA: 0x0011F8DC File Offset: 0x0011DADC
	protected override UniTask OnBeforeStartAsync()
	{
		ProjectionPhotoView.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ProjectionPhotoView.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005FD7 RID: 24535 RVA: 0x0011F920 File Offset: 0x0011DB20
	protected override void OnBeforeDestroy()
	{
		EventSystem.Instance.Remove(EEventName.OnProjectionPhotoItemPointDown, new Action(this.OnProjectionPhotoItemPointDown));
		EventSystem.Instance.Remove(EEventName.OnProjectionPhotoItemPointUp, new Action(this.OnProjectionPhotoItemPointUp));
		EventSystem.Instance.Remove(EEventName.OnProjectionPhotoItemStartDrag, new Action(this.OnProjectionPhotoItemPointDown));
		EventSystem.Instance.Remove(EEventName.OnProjectionPhotoItemEndDrag, new Action(this.OnProjectionPhotoItemPointUp));
		EventSystem.Instance.Remove(EEventName.OnProjectionPhotoFinishDrag, new Action(this.OnProjectionPhotoFinishDrag));
		EventSystem.Instance.Remove(EEventName.OnProjectionPhotoSliderEndDrag, new Action(this.OnSliderEndDrag));
		EventSystem.Instance.Remove(EEventName.OnHorizontalSliderValueFirstChange, new Action(this.OnHorizontalSliderValueFirstChange));
		EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x06005FD8 RID: 24536 RVA: 0x0011FA0D File Offset: 0x0011DC0D
	[NullableContext(1)]
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "Close2" || sequenceName == "Activate")
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x06005FD9 RID: 24537 RVA: 0x0011FA30 File Offset: 0x0011DC30
	private void OnSliderEndDrag()
	{
		this.CheckAllFinish();
	}

	// Token: 0x06005FDA RID: 24538 RVA: 0x0011FA38 File Offset: 0x0011DC38
	private void OnHorizontalSliderValueFirstChange()
	{
		UUIItem pnlDescTips = this.PnlDescTips;
		if (pnlDescTips == null)
		{
			return;
		}
		pnlDescTips.SetUIActive(false);
	}

	// Token: 0x06005FDB RID: 24539 RVA: 0x0011FA4B File Offset: 0x0011DC4B
	private void OnProjectionPhotoItemPointDown()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetCloseBtnActive(false);
	}

	// Token: 0x06005FDC RID: 24540 RVA: 0x0011FA5E File Offset: 0x0011DC5E
	private void OnProjectionPhotoItemPointUp()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetCloseBtnActive(true);
	}

	// Token: 0x06005FDD RID: 24541 RVA: 0x0011FA71 File Offset: 0x0011DC71
	private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetCloseBtnActive(true);
	}

	// Token: 0x06005FDE RID: 24542 RVA: 0x0011FA84 File Offset: 0x0011DC84
	private void SyncPnlDescTipsAnchorX()
	{
		if (this.PnlDescTips == null || this.IsSliderDisabled || this.OpenParam == null)
		{
			return;
		}
		IProjectionMachinePhotoFilter photoFilter = this.OpenParam.Config.PhotoFilter;
		float num = (photoFilter != null) ? photoFilter.DefaultParam1 : -1f;
		float num2 = (photoFilter != null) ? photoFilter.TargetParam1 : -1f;
		if (num == -1f && num2 == -1f)
		{
			return;
		}
		float num3 = Math.Clamp(num, 0f, 1f);
		float num4 = 1620f;
		float inX = -565f + num3 * num4;
		FVector2D anchorOffset = this.PnlDescTips.GetAnchorOffset();
		this.PnlDescTips.SetAnchorOffset(new FVector2D(inX, anchorOffset.Y));
	}

	// Token: 0x06005FDF RID: 24543 RVA: 0x0011FB38 File Offset: 0x0011DD38
	private void CheckAllFinish()
	{
		if (this.SliderHorizontalPanel.IsFinish() && this.SliderVerticalPanel.IsFinish())
		{
			this.FinishCallback(true);
			this.RequestHandInItem();
			if (this.IsSliderDisabled)
			{
				LevelSequencePlayer sequencePlayer = this.SequencePlayer;
				if (sequencePlayer == null)
				{
					return;
				}
				sequencePlayer.PlayLevelSequenceByName("Activate", false, null, false);
				return;
			}
			else
			{
				TimerSystem.Instance.Delay(delegate(float _)
				{
					LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
					if (sequencePlayer2 == null)
					{
						return;
					}
					sequencePlayer2.PlayLevelSequenceByName("Close2", false, null, false);
				}, 0.7f, null, null, true, 1f);
			}
		}
	}

	// Token: 0x06005FE0 RID: 24544 RVA: 0x0011FBC0 File Offset: 0x0011DDC0
	protected override void OnTick(float delta)
	{
		if (this.AutoFinishTimer > 0f)
		{
			this.AutoFinishTimer -= delta / 1000f;
			if (this.AutoFinishTimer <= 0f)
			{
				this.AutoFinishTimer = -1f;
				this.CheckAllFinish();
			}
		}
	}

	// Token: 0x06005FE1 RID: 24545 RVA: 0x0011FC0C File Offset: 0x0011DE0C
	private void OnProjectionPhotoFinishDrag()
	{
		if (this.OpenParam != null)
		{
			LevelGeneralNetworks.RequestEntitySendEvent(this.OpenParam.EntityId, "ProjectionMachine_Choice");
		}
		this.PhotoItem.SetHidden(true);
		if (!this.IsSliderDisabled)
		{
			ProjectionPhotoViewParams openParam = this.OpenParam;
			if (openParam != null && openParam.PbDataId == 687700167)
			{
				UUIItem pnlDescTips = this.PnlDescTips;
				if (pnlDescTips != null)
				{
					pnlDescTips.SetUIActive(true);
				}
			}
		}
		if (this.IsSliderDisabled)
		{
			this.AutoFinishTimer = this.AutoFinishTime;
			return;
		}
		LevelSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer == null)
		{
			return;
		}
		sequencePlayer.PlayLevelSequenceByName("Change", false, null, false);
	}

	// Token: 0x06005FE2 RID: 24546 RVA: 0x0011FCAC File Offset: 0x0011DEAC
	private void RequestHandInItem()
	{
		NewHandInItemRequest newHandInItemRequest = NewHandInItemRequest.Create();
		NewHandInItemsProjectionMachinePb newHandInItemsProjectionMachinePb = NewHandInItemsProjectionMachinePb.Create();
		EntityHandle entity = CreatureModel.Instance.GetEntity(this.OpenParam.EntityId);
		WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
		if (!worldEntity)
		{
			return;
		}
		CreatureDataComponent component = worldEntity.GetComponent<CreatureDataComponent>();
		newHandInItemsProjectionMachinePb.EntityCfgId = component.GetPbDataId();
		newHandInItemsProjectionMachinePb.ItemId = this.OpenParam.Config.ItemId;
		newHandInItemRequest.ProjectionMachine = newHandInItemsProjectionMachinePb;
		Net.Instance.Call(ERequestMessageId.NewHandInItemRequest, newHandInItemRequest, delegate(IMessage msg, Net.CallbackStatus _)
		{
			NewHandInItemResponse newHandInItemResponse = (NewHandInItemResponse)msg;
			if (newHandInItemResponse.ErrorCode != ErrorCode.Success)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.CH;
				string message = "ProjectionPhotoView RequestHandInItem failed";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ErrorCode", (newHandInItemResponse != null) ? new ErrorCode?(newHandInItemResponse.ErrorCode) : null);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}, 0);
	}

	// Token: 0x04002B7A RID: 11130
	[Nullable(1)]
	private const string DragFinishEvent = "ProjectionMachine_Choice";

	// Token: 0x04002B7B RID: 11131
	private const int SHOW_TIPS_ENTITY_ID = 687700167;

	// Token: 0x04002B7C RID: 11132
	private const float PnlDescTipsAnchorXAtSliderMin = -565f;

	// Token: 0x04002B7D RID: 11133
	private const float PnlDescTipsAnchorXAtSliderMax = 1055f;

	// Token: 0x04002B7E RID: 11134
	private PopupCaptionItem CaptionItem;

	// Token: 0x04002B7F RID: 11135
	private ProjectionPhotoItem PhotoItem;

	// Token: 0x04002B80 RID: 11136
	private ProjectionPhotoItem FixedPhotoItem;

	// Token: 0x04002B81 RID: 11137
	private ProjectionPhotoDragItem PhotoDragItem;

	// Token: 0x04002B82 RID: 11138
	private ProjectionPhotoShowItem ItemShow;

	// Token: 0x04002B83 RID: 11139
	private ProjectionPhotoSlider SliderHorizontalPanel;

	// Token: 0x04002B84 RID: 11140
	private ProjectionPhotoSlider SliderVerticalPanel;

	// Token: 0x04002B85 RID: 11141
	private UUIItem PnlDescTips;

	// Token: 0x04002B86 RID: 11142
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04002B87 RID: 11143
	private float SliderTolerance = 0.1f;

	// Token: 0x04002B88 RID: 11144
	[Nullable(1)]
	private Action<bool> FinishCallback = delegate(bool _)
	{
	};

	// Token: 0x04002B89 RID: 11145
	private bool IsSliderDisabled;

	// Token: 0x04002B8A RID: 11146
	private float AutoFinishTime = 1.5f;

	// Token: 0x04002B8B RID: 11147
	private float AutoFinishTimer = -1f;

	// Token: 0x0200754E RID: 30030
	[NullableContext(0)]
	private enum EViewComponent
	{
		// Token: 0x04026CA0 RID: 158880
		ItemCaption,
		// Token: 0x04026CA1 RID: 158881
		ItemShow,
		// Token: 0x04026CA2 RID: 158882
		SliderHorizontal,
		// Token: 0x04026CA3 RID: 158883
		SliderVertical,
		// Token: 0x04026CA4 RID: 158884
		BtnPhotoA,
		// Token: 0x04026CA5 RID: 158885
		BtnPhotoB,
		// Token: 0x04026CA6 RID: 158886
		PnlTouch,
		// Token: 0x04026CA7 RID: 158887
		BtnDragPhoto,
		// Token: 0x04026CA8 RID: 158888
		PnlPhoto,
		// Token: 0x04026CA9 RID: 158889
		PnlDescTips,
		// Token: 0x04026CAA RID: 158890
		TxtDescTips
	}
}
