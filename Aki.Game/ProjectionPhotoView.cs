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

// Token: 0x020003A2 RID: 930
[NullableContext(2)]
[Nullable(0)]
public class ProjectionPhotoView : UiTickViewBase
{
	// Token: 0x1700077B RID: 1915
	// (get) Token: 0x06003369 RID: 13161 RVA: 0x001275BE File Offset: 0x001257BE
	private new ProjectionPhotoViewParams OpenParam
	{
		get
		{
			return this.OpenParam as ProjectionPhotoViewParams;
		}
	}

	// Token: 0x0600336A RID: 13162 RVA: 0x001275CC File Offset: 0x001257CC
	[NullableContext(1)]
	public ProjectionPhotoView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x0600336B RID: 13163 RVA: 0x00127628 File Offset: 0x00125828
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

	// Token: 0x0600336C RID: 13164 RVA: 0x00127734 File Offset: 0x00125934
	protected override UniTask OnBeforeStartAsync()
	{
		ProjectionPhotoView.<OnBeforeStartAsync>d__23 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ProjectionPhotoView.<OnBeforeStartAsync>d__23>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600336D RID: 13165 RVA: 0x00127778 File Offset: 0x00125978
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

	// Token: 0x0600336E RID: 13166 RVA: 0x00127865 File Offset: 0x00125A65
	[NullableContext(1)]
	private void OnSequenceClose(string sequenceName)
	{
		if (sequenceName == "Close2" || sequenceName == "Activate")
		{
			base.CloseMe(null);
		}
	}

	// Token: 0x0600336F RID: 13167 RVA: 0x00127888 File Offset: 0x00125A88
	private void OnSliderEndDrag()
	{
		this.CheckAllFinish();
	}

	// Token: 0x06003370 RID: 13168 RVA: 0x00127890 File Offset: 0x00125A90
	private void OnHorizontalSliderValueFirstChange()
	{
		UUIItem pnlDescTips = this.PnlDescTips;
		if (pnlDescTips == null)
		{
			return;
		}
		pnlDescTips.SetUIActive(false);
	}

	// Token: 0x06003371 RID: 13169 RVA: 0x001278A3 File Offset: 0x00125AA3
	private void OnProjectionPhotoItemPointDown()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetCloseBtnActive(false);
	}

	// Token: 0x06003372 RID: 13170 RVA: 0x001278B6 File Offset: 0x00125AB6
	private void OnProjectionPhotoItemPointUp()
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetCloseBtnActive(true);
	}

	// Token: 0x06003373 RID: 13171 RVA: 0x001278C9 File Offset: 0x00125AC9
	private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		PopupCaptionItem captionItem = this.CaptionItem;
		if (captionItem == null)
		{
			return;
		}
		captionItem.SetCloseBtnActive(true);
	}

	// Token: 0x06003374 RID: 13172 RVA: 0x001278DC File Offset: 0x00125ADC
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

	// Token: 0x06003375 RID: 13173 RVA: 0x00127990 File Offset: 0x00125B90
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
				}, 700f, null, null, true, 1f);
			}
		}
	}

	// Token: 0x06003376 RID: 13174 RVA: 0x00127A18 File Offset: 0x00125C18
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

	// Token: 0x06003377 RID: 13175 RVA: 0x00127A64 File Offset: 0x00125C64
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

	// Token: 0x06003378 RID: 13176 RVA: 0x00127B04 File Offset: 0x00125D04
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

	// Token: 0x04002C13 RID: 11283
	[Nullable(1)]
	private const string DragFinishEvent = "ProjectionMachine_Choice";

	// Token: 0x04002C14 RID: 11284
	private const int SHOW_TIPS_ENTITY_ID = 687700167;

	// Token: 0x04002C15 RID: 11285
	private const float PnlDescTipsAnchorXAtSliderMin = -565f;

	// Token: 0x04002C16 RID: 11286
	private const float PnlDescTipsAnchorXAtSliderMax = 1055f;

	// Token: 0x04002C17 RID: 11287
	private PopupCaptionItem CaptionItem;

	// Token: 0x04002C18 RID: 11288
	private ProjectionPhotoItem PhotoItem;

	// Token: 0x04002C19 RID: 11289
	private ProjectionPhotoItem FixedPhotoItem;

	// Token: 0x04002C1A RID: 11290
	private ProjectionPhotoDragItem PhotoDragItem;

	// Token: 0x04002C1B RID: 11291
	private ProjectionPhotoShowItem ItemShow;

	// Token: 0x04002C1C RID: 11292
	private ProjectionPhotoSlider SliderHorizontalPanel;

	// Token: 0x04002C1D RID: 11293
	private ProjectionPhotoSlider SliderVerticalPanel;

	// Token: 0x04002C1E RID: 11294
	private UUIItem PnlDescTips;

	// Token: 0x04002C1F RID: 11295
	private LevelSequencePlayer SequencePlayer;

	// Token: 0x04002C20 RID: 11296
	private float SliderTolerance = 0.1f;

	// Token: 0x04002C21 RID: 11297
	[Nullable(1)]
	private Action<bool> FinishCallback = delegate(bool _)
	{
	};

	// Token: 0x04002C22 RID: 11298
	private bool IsSliderDisabled;

	// Token: 0x04002C23 RID: 11299
	private float AutoFinishTime = 1.5f;

	// Token: 0x04002C24 RID: 11300
	private float AutoFinishTimer = -1f;

	// Token: 0x020066E2 RID: 26338
	[NullableContext(0)]
	private enum EViewComponent
	{
		// Token: 0x04021FEB RID: 139243
		ItemCaption,
		// Token: 0x04021FEC RID: 139244
		ItemShow,
		// Token: 0x04021FED RID: 139245
		SliderHorizontal,
		// Token: 0x04021FEE RID: 139246
		SliderVertical,
		// Token: 0x04021FEF RID: 139247
		BtnPhotoA,
		// Token: 0x04021FF0 RID: 139248
		BtnPhotoB,
		// Token: 0x04021FF1 RID: 139249
		PnlTouch,
		// Token: 0x04021FF2 RID: 139250
		BtnDragPhoto,
		// Token: 0x04021FF3 RID: 139251
		PnlPhoto,
		// Token: 0x04021FF4 RID: 139252
		PnlDescTips,
		// Token: 0x04021FF5 RID: 139253
		TxtDescTips
	}
}
