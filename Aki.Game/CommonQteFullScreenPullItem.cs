using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002613 RID: 9747
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteFullScreenPullItem : CommonQteItemBase<CommonQteDragContext>
{
	// Token: 0x06013E48 RID: 81480 RVA: 0x004FF444 File Offset: 0x004FD644
	protected unsafe override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIDraggableComponent));
		this.ComponentRegisterInfos = list;
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
		}
	}

	// Token: 0x06013E49 RID: 81481 RVA: 0x004FF4DC File Offset: 0x004FD6DC
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteFullScreenPullItem.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteFullScreenPullItem.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013E4A RID: 81482 RVA: 0x004FF520 File Offset: 0x004FD720
	protected override void OnStart()
	{
		base.OnStart();
		base.SetUiActive(false);
		UUIItem item = base.GetItem(0);
		this.LevelSequencePlayer = new LevelSequencePlayer(item);
		base.SetAttachRootItem(item);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
		UUIDraggableComponent draggable = base.GetDraggable(1);
		draggable.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDragCallBack));
		draggable.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDragCallBack));
		draggable.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEndDragCallBack));
		draggable.OnPointerDownCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDownCallBack));
		draggable.OnPointerUpCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerUpCallBack));
	}

	// Token: 0x06013E4B RID: 81483 RVA: 0x004FF5E6 File Offset: 0x004FD7E6
	private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		if (!Info.Instance.IsInGamepad())
		{
			this.InputVector.Reset();
			this.HasInputLookup = false;
			this.HasInputTurn = false;
		}
		this.DerivedLength = 0f;
	}

	// Token: 0x06013E4C RID: 81484 RVA: 0x004FF618 File Offset: 0x004FD818
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteDragContext;
	}

	// Token: 0x06013E4D RID: 81485 RVA: 0x004FF623 File Offset: 0x004FD823
	[NullableContext(1)]
	protected override void OnRefreshActionUi(string action)
	{
		InputMultiKeyItem keyItem = this.KeyItem;
		if (keyItem != null)
		{
			keyItem.RefreshByActionOrAxis(new InputActionOrAxisKeyItem
			{
				ActionOrAxisName = action
			}, false);
		}
		InputMultiKeyItem keyItem2 = this.KeyItem;
		if (keyItem2 == null)
		{
			return;
		}
		keyItem2.Show(null);
	}

	// Token: 0x06013E4E RID: 81486 RVA: 0x004FF654 File Offset: 0x004FD854
	protected override void TryApplyQteUiConfig(object uiConfig)
	{
		SCommonQte_Drag scommonQte_Drag = uiConfig as SCommonQte_Drag;
		if (scommonQte_Drag != null)
		{
			this.DragLength = scommonQte_Drag.SlideLength;
			this.DragAxis = CommonQteFullScreenPullItem.EDragAxis.Y;
			this.DragDirection = 1;
			if (scommonQte_Drag.ViewType == ECommonQteViewType_Drag.全屏下拉界面 || scommonQte_Drag.ViewType == ECommonQteViewType_Drag.穗穗下滑界面)
			{
				this.DragDirection = -1;
			}
			else if (scommonQte_Drag.ViewType == ECommonQteViewType_Drag.全屏上拉界面)
			{
				this.DragDirection = 1;
			}
			else if (scommonQte_Drag.ViewType == ECommonQteViewType_Drag.穗穗右滑界面)
			{
				this.DragAxis = CommonQteFullScreenPullItem.EDragAxis.X;
				this.DragDirection = 1;
			}
			this.LerpSpeed = scommonQte_Drag.LerpSpeed / 1000f;
			this.CheckByRealTimeInput = scommonQte_Drag.CheckByRealTimeInput;
		}
	}

	// Token: 0x06013E4F RID: 81487 RVA: 0x004FF718 File Offset: 0x004FD918
	[NullableContext(1)]
	private void OnSequenceEndEvent(string sequenceName)
	{
		if (sequenceName == "Start")
		{
			if (this.IsQteEnd)
			{
				return;
			}
			this.IsQteStart = true;
			this.IsQteInteractive = true;
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Loop", false, null, false);
			}
			if (!this.IsMobile)
			{
				InputMultiKeyItem keyItem = this.KeyItem;
				if (keyItem == null)
				{
					return;
				}
				keyItem.Show(null);
				return;
			}
		}
		else if (sequenceName == "Close")
		{
			base.Destroy(null);
		}
	}

	// Token: 0x06013E50 RID: 81488 RVA: 0x004FF798 File Offset: 0x004FD998
	protected override void OnPlayQteStart()
	{
		base.SetUiActive(true);
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}
		if (this.IsQteInteractive && !this.IsMobile)
		{
			InputMultiKeyItem keyItem = this.KeyItem;
			if (keyItem == null)
			{
				return;
			}
			keyItem.Show(null);
		}
	}

	// Token: 0x06013E51 RID: 81489 RVA: 0x004FF7F0 File Offset: 0x004FD9F0
	protected override void RefreshUiOffset()
	{
		if (this.CommonQteContext != null)
		{
			SCommonQte_Drag scommonQte_Drag = this.CommonQteContext.GetUiConfig() as SCommonQte_Drag;
			if (scommonQte_Drag != null)
			{
				SCommonQteButton uiconfig = scommonQte_Drag.UIConfig;
				this.RootItem.SetAnchorAlign(uiconfig.AnchorHAlign, uiconfig.AnchorVAlign);
				this.RootItem.SetAnchorOffset(uiconfig.AnchorOffset);
				if (this.IsAttaching)
				{
					this.Reattach(this.CommonQteContext);
				}
			}
		}
	}

	// Token: 0x06013E52 RID: 81490 RVA: 0x004FF862 File Offset: 0x004FDA62
	protected override bool IsUseBaseAction()
	{
		return false;
	}

	// Token: 0x06013E53 RID: 81491 RVA: 0x004FF868 File Offset: 0x004FDA68
	protected override void OnBindAction()
	{
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiScroll2", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiScroll1", new TInputHandle<float>(this.OnInputLookup));
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x06013E54 RID: 81492 RVA: 0x004FF8C8 File Offset: 0x004FDAC8
	protected override void OnUnbindAction()
	{
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiScroll2", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiScroll1", new TInputHandle<float>(this.OnInputLookup));
		EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x06013E55 RID: 81493 RVA: 0x004FF928 File Offset: 0x004FDB28
	protected override void OnHandleQteEnd()
	{
		InputMultiKeyItem keyItem = this.KeyItem;
		if (keyItem != null)
		{
			keyItem.Hide(null);
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.StopCurrentSequence(false, false);
		}
		LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
		if (levelSequencePlayer2 == null)
		{
			return;
		}
		levelSequencePlayer2.PlayLevelSequenceByName("Close", false, null, false);
	}

	// Token: 0x06013E56 RID: 81494 RVA: 0x004FF97C File Offset: 0x004FDB7C
	[NullableContext(1)]
	private void OnInputTurn(string name, float value, InputIdentification inputIdentification)
	{
		if (!base.IsValidInput() || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.InputVector.X = (double)value;
		this.HasInputTurn = (value != 0f);
		this.SetIsDragging(this.HasInputTurn || this.HasInputLookup);
	}

	// Token: 0x06013E57 RID: 81495 RVA: 0x004FF9D4 File Offset: 0x004FDBD4
	[NullableContext(1)]
	private void OnInputLookup(string name, float value, InputIdentification inputIdentification)
	{
		if (!base.IsValidInput() || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.InputVector.Y = (double)(-(double)value);
		this.HasInputLookup = (value != 0f);
		this.SetIsDragging(this.HasInputTurn || this.HasInputLookup);
	}

	// Token: 0x06013E58 RID: 81496 RVA: 0x004FFA2C File Offset: 0x004FDC2C
	private void OnPointerDownCallBack(ULGUIPointerEventData eventData)
	{
		this.DerivedLength = this.CacheLength;
	}

	// Token: 0x06013E59 RID: 81497 RVA: 0x004FFA3A File Offset: 0x004FDC3A
	private void OnPointerUpCallBack(ULGUIPointerEventData eventData)
	{
		this.DerivedLength = 0f;
	}

	// Token: 0x06013E5A RID: 81498 RVA: 0x004FFA47 File Offset: 0x004FDC47
	private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!base.IsValidInput() || !this.HasBindAction)
		{
			return;
		}
		this.StartDragPosition = new FVector?(eventData.GetLocalPointInPlane());
		this.SetIsDragging(true);
	}

	// Token: 0x06013E5B RID: 81499 RVA: 0x004FFA74 File Offset: 0x004FDC74
	private void OnPointerDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!base.IsValidInput() || !this.HasBindAction)
		{
			return;
		}
		if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
		{
			this.StartDragPosition = null;
			return;
		}
		if (this.StartDragPosition == null)
		{
			return;
		}
		FVector localPointInPlane = eventData.GetLocalPointInPlane();
		this.InputVector.Y = (double)(localPointInPlane.Y - this.StartDragPosition.Value.Y);
		this.InputVector.X = (double)(localPointInPlane.X - this.StartDragPosition.Value.X);
	}

	// Token: 0x06013E5C RID: 81500 RVA: 0x004FFB07 File Offset: 0x004FDD07
	private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!base.IsValidInput() || !this.HasBindAction)
		{
			return;
		}
		this.DerivedLength = 0f;
		this.StartDragPosition = null;
		this.InputVector.Reset();
		this.SetIsDragging(false);
	}

	// Token: 0x06013E5D RID: 81501 RVA: 0x004FFB43 File Offset: 0x004FDD43
	private void SetIsDragging(bool isDragging)
	{
		if (isDragging == this.IsDragging)
		{
			return;
		}
		this.IsDragging = isDragging;
		if (isDragging)
		{
			CommonQteDragContext commonQteContext = this.CommonQteContext;
			if (commonQteContext == null)
			{
				return;
			}
			commonQteContext.Response();
			return;
		}
		else
		{
			CommonQteDragContext commonQteContext2 = this.CommonQteContext;
			if (commonQteContext2 == null)
			{
				return;
			}
			commonQteContext2.ResponseEnd();
			return;
		}
	}

	// Token: 0x06013E5E RID: 81502 RVA: 0x004FFB7C File Offset: 0x004FDD7C
	protected override void OnTickQteItem(float delta)
	{
		float angle = (float)this.InputVector.HeadingAngle();
		float dragInput = this.GetDragInput();
		float num;
		if (Info.Instance.IsInGamepad())
		{
			if (this.LerpSpeed < 0f)
			{
				num = dragInput * 1.43f * (float)this.DragDirection * this.DragLength;
				this.CacheLength = num;
			}
			else
			{
				float num2 = dragInput * (float)this.DragDirection;
				if ((double)num2 <= 1E-08)
				{
					this.CacheLength = MathUtils.Instance.InterpConstantTo(this.CacheLength, 0f, delta, this.LerpSpeed);
				}
				else
				{
					this.CacheLength = MathUtils.Instance.InterpConstantTo(this.CacheLength, this.DragLength, delta, this.LerpSpeed * num2);
				}
				num = this.CacheLength;
			}
		}
		else
		{
			num = dragInput * (float)this.DragDirection + this.DerivedLength;
			if (this.LerpSpeed > 0f)
			{
				this.CacheLength = MathUtils.Instance.InterpConstantTo(this.CacheLength, num, delta, this.LerpSpeed);
			}
			else
			{
				this.CacheLength = num;
			}
		}
		this.CacheLength = MathUtils.Instance.Clamp(this.CacheLength, 0f, this.DragLength);
		this.CommonQteContext.SetDraggingInfo(this.CacheLength, angle);
		if (this.CheckByRealTimeInput && this.CommonQteContext.CheckDragComplete(num, angle))
		{
			this.CommonQteContext.SetPreResult(true);
		}
	}

	// Token: 0x06013E5F RID: 81503 RVA: 0x004FFCE0 File Offset: 0x004FDEE0
	private float GetDragInput()
	{
		return (float)((this.DragAxis == CommonQteFullScreenPullItem.EDragAxis.X) ? this.InputVector.X : this.InputVector.Y);
	}

	// Token: 0x040095E2 RID: 38370
	private const float GAMEPAD_ENHANCE_RATE = 1.43f;

	// Token: 0x040095E3 RID: 38371
	private InputMultiKeyItem KeyItem;

	// Token: 0x040095E4 RID: 38372
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040095E5 RID: 38373
	private float DragLength;

	// Token: 0x040095E6 RID: 38374
	private float CacheLength;

	// Token: 0x040095E7 RID: 38375
	private float DerivedLength;

	// Token: 0x040095E8 RID: 38376
	private float LerpSpeed;

	// Token: 0x040095E9 RID: 38377
	private int DragDirection;

	// Token: 0x040095EA RID: 38378
	private CommonQteFullScreenPullItem.EDragAxis DragAxis = CommonQteFullScreenPullItem.EDragAxis.Y;

	// Token: 0x040095EB RID: 38379
	private FVector? StartDragPosition;

	// Token: 0x040095EC RID: 38380
	[Nullable(1)]
	private readonly Vector InputVector = Vector.Create();

	// Token: 0x040095ED RID: 38381
	private bool HasInputTurn;

	// Token: 0x040095EE RID: 38382
	private bool HasInputLookup;

	// Token: 0x040095EF RID: 38383
	private bool IsDragging;

	// Token: 0x040095F0 RID: 38384
	private bool CheckByRealTimeInput;

	// Token: 0x02008C57 RID: 35927
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D8E8 RID: 186600
		Prefab,
		// Token: 0x0402D8E9 RID: 186601
		Drag,
		// Token: 0x0402D8EA RID: 186602
		HotKey
	}

	// Token: 0x02008C58 RID: 35928
	[NullableContext(0)]
	private enum EDragAxis
	{
		// Token: 0x0402D8EC RID: 186604
		X,
		// Token: 0x0402D8ED RID: 186605
		Y
	}
}
