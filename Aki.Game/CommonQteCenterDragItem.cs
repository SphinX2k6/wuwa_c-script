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

// Token: 0x0200260C RID: 9740
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteCenterDragItem : CommonQteItemBase<CommonQteDragContext>
{
	// Token: 0x06013DC3 RID: 81347 RVA: 0x004FC2B4 File Offset: 0x004FA4B4
	protected unsafe override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIDraggableComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUIItem)));
		}
	}

	// Token: 0x06013DC4 RID: 81348 RVA: 0x004FC36C File Offset: 0x004FA56C
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteCenterDragItem.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteCenterDragItem.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013DC5 RID: 81349 RVA: 0x004FC3B0 File Offset: 0x004FA5B0
	protected override void OnStart()
	{
		base.OnStart();
		base.SetUiActive(false);
		this.DragButton = base.GetDraggable(0);
		this.DragCenter = base.GetItem(1);
		this.TipsText = base.GetText(2);
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEndEvent), false);
		this.DragButton.OnPointerBeginDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerBeginDragCallBack));
		this.DragButton.OnPointerDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerDragCallBack));
		this.DragButton.OnPointerEndDragCallBack.Bind(new Action<ULGUIPointerEventData>(this.OnPointerEndDragCallBack));
	}

	// Token: 0x06013DC6 RID: 81350 RVA: 0x004FC470 File Offset: 0x004FA670
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		UUIDraggableComponent dragButton = this.DragButton;
		if (dragButton != null)
		{
			dragButton.OnPointerBeginDragCallBack.Unbind();
		}
		UUIDraggableComponent dragButton2 = this.DragButton;
		if (dragButton2 != null)
		{
			dragButton2.OnPointerDragCallBack.Unbind();
		}
		UUIDraggableComponent dragButton3 = this.DragButton;
		if (dragButton3 != null)
		{
			dragButton3.OnPointerEndDragCallBack.Unbind();
		}
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer == null)
		{
			return;
		}
		levelSequencePlayer.Clear();
	}

	// Token: 0x06013DC7 RID: 81351 RVA: 0x004FC4D5 File Offset: 0x004FA6D5
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteDragContext;
	}

	// Token: 0x06013DC8 RID: 81352 RVA: 0x004FC4E0 File Offset: 0x004FA6E0
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

	// Token: 0x06013DC9 RID: 81353 RVA: 0x004FC514 File Offset: 0x004FA714
	protected override void TryApplyQteUiConfig(object uiConfig)
	{
		SCommonQte_Drag scommonQte_Drag = uiConfig as SCommonQte_Drag;
		if (scommonQte_Drag == null)
		{
			return;
		}
		this.SlideLength = scommonQte_Drag.SlideLength;
		this.CacheLength = 0f;
		this.CacheAngle = 0f;
		this.Direction = (float)scommonQte_Drag.Direction * 0.017453292f;
		this.LerpSpeed = scommonQte_Drag.LerpSpeed / 1000f;
		this.CheckByRealTimeInput = scommonQte_Drag.CheckByRealTimeInput;
		UUIItem dragCenter = this.DragCenter;
		if (dragCenter != null)
		{
			dragCenter.SetAnchorOffset(scommonQte_Drag.DragCenterPivot);
		}
		UUIItem dragCenter2 = this.DragCenter;
		if (dragCenter2 == null)
		{
			return;
		}
		FRotator frotator = new FRotator(0f, (float)(scommonQte_Drag.Direction - 90), 0f);
		dragCenter2.SetUIRelativeRotation(frotator);
	}

	// Token: 0x06013DCA RID: 81354 RVA: 0x004FC5C4 File Offset: 0x004FA7C4
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

	// Token: 0x06013DCB RID: 81355 RVA: 0x004FC61C File Offset: 0x004FA81C
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

	// Token: 0x06013DCC RID: 81356 RVA: 0x004FC67C File Offset: 0x004FA87C
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

	// Token: 0x06013DCD RID: 81357 RVA: 0x004FC6CE File Offset: 0x004FA8CE
	protected override bool IsUseBaseAction()
	{
		return false;
	}

	// Token: 0x06013DCE RID: 81358 RVA: 0x004FC6D4 File Offset: 0x004FA8D4
	protected override void OnBindAction()
	{
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiScroll2", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiScroll1", new TInputHandle<float>(this.OnInputLookup));
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x06013DCF RID: 81359 RVA: 0x004FC734 File Offset: 0x004FA934
	protected override void OnUnbindAction()
	{
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiScroll2", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiScroll1", new TInputHandle<float>(this.OnInputLookup));
		EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x06013DD0 RID: 81360 RVA: 0x004FC794 File Offset: 0x004FA994
	private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		UUIText tipsText = this.TipsText;
		if (tipsText != null)
		{
			tipsText.SetGameRichText(false);
		}
		UUIText tipsText2 = this.TipsText;
		if (tipsText2 != null)
		{
			tipsText2.SetGameRichText(true);
		}
		this.StartDragPosition = null;
		this.InputVector.Reset();
		this.HasInputTurn = false;
		this.HasInputLookup = false;
		this.SetIsDragging(false);
	}

	// Token: 0x06013DD1 RID: 81361 RVA: 0x004FC7F4 File Offset: 0x004FA9F4
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

	// Token: 0x06013DD2 RID: 81362 RVA: 0x004FC84C File Offset: 0x004FAA4C
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

	// Token: 0x06013DD3 RID: 81363 RVA: 0x004FC8A4 File Offset: 0x004FAAA4
	private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!base.IsValidInput() || !this.HasBindAction || eventData == null)
		{
			return;
		}
		this.StartDragPosition = new FVector?(eventData.GetLocalPointInPlane());
		this.InputVector.Reset();
		this.SetIsDragging(true);
	}

	// Token: 0x06013DD4 RID: 81364 RVA: 0x004FC8E0 File Offset: 0x004FAAE0
	private void OnPointerDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!base.IsValidInput() || !this.HasBindAction || eventData == null || this.StartDragPosition == null)
		{
			return;
		}
		if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
		{
			this.ResetPointerInput();
			return;
		}
		FVector localPointInPlane = eventData.GetLocalPointInPlane();
		this.InputVector.X = (double)(localPointInPlane.X - this.StartDragPosition.Value.X);
		this.InputVector.Y = (double)(localPointInPlane.Y - this.StartDragPosition.Value.Y);
	}

	// Token: 0x06013DD5 RID: 81365 RVA: 0x004FC96F File Offset: 0x004FAB6F
	private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
	{
		this.ResetPointerInput();
	}

	// Token: 0x06013DD6 RID: 81366 RVA: 0x004FC977 File Offset: 0x004FAB77
	private void ResetPointerInput()
	{
		this.StartDragPosition = null;
		this.InputVector.Reset();
		this.SetIsDragging(false);
	}

	// Token: 0x06013DD7 RID: 81367 RVA: 0x004FC998 File Offset: 0x004FAB98
	private void SetIsDragging(bool isDragging)
	{
		if (isDragging == this.IsDragging)
		{
			return;
		}
		this.IsDragging = isDragging;
		if (isDragging)
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.PlayLevelSequenceByName("Drag", false, null, false);
			}
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
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.StopSequenceByKey("Drag", false, false);
			}
			LevelSequencePlayer levelSequencePlayer3 = this.LevelSequencePlayer;
			if (levelSequencePlayer3 != null)
			{
				levelSequencePlayer3.PlayLevelSequenceByName("Reset", false, null, false);
			}
			CommonQteDragContext commonQteContext2 = this.CommonQteContext;
			if (commonQteContext2 == null)
			{
				return;
			}
			commonQteContext2.ResponseEnd();
			return;
		}
	}

	// Token: 0x06013DD8 RID: 81368 RVA: 0x004FCA34 File Offset: 0x004FAC34
	protected override void OnTickQteItem(float delta)
	{
		if (this.CommonQteContext == null)
		{
			return;
		}
		float num = this.IsDragging ? ((float)this.InputVector.Size2D()) : 0f;
		if ((double)num > 1E-08)
		{
			this.CacheAngle = (float)this.InputVector.HeadingAngle();
		}
		float num2 = num * (float)Math.Cos((double)(this.CacheAngle - this.Direction));
		float num4;
		if (Info.Instance.IsInGamepad() && this.LerpSpeed > 0f)
		{
			float num3 = num2;
			bool flag = (double)num3 > 1E-08;
			this.CacheLength = MathUtils.Instance.InterpConstantTo(this.CacheLength, flag ? this.SlideLength : 0f, delta, flag ? (this.LerpSpeed * num3) : this.LerpSpeed);
			num4 = this.CacheLength;
		}
		else
		{
			num4 = (Info.Instance.IsInGamepad() ? (num2 * this.SlideLength * 1.43f) : num2);
			float num5 = MathUtils.Instance.Clamp(num4, 0f, this.SlideLength);
			this.CacheLength = ((this.LerpSpeed > 0f) ? MathUtils.Instance.InterpConstantTo(this.CacheLength, num5, delta, this.LerpSpeed) : num5);
		}
		this.CacheLength = MathUtils.Instance.Clamp(this.CacheLength, 0f, this.SlideLength);
		if (this.IsDragging && this.CheckByRealTimeInput && this.CommonQteContext.CheckDragComplete(num4, this.CacheAngle))
		{
			this.CommonQteContext.SetPreResult(true);
		}
		this.CommonQteContext.SetDraggingInfo(this.CacheLength, this.CacheAngle);
	}

	// Token: 0x0400959E RID: 38302
	private const float GAMEPAD_ENHANCE_RATE = 1.43f;

	// Token: 0x0400959F RID: 38303
	[Nullable(1)]
	private const string DRAG_SEQUENCE = "Drag";

	// Token: 0x040095A0 RID: 38304
	[Nullable(1)]
	private const string REST_SEQUENCE = "Reset";

	// Token: 0x040095A1 RID: 38305
	private InputMultiKeyItem KeyItem;

	// Token: 0x040095A2 RID: 38306
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040095A3 RID: 38307
	private UUIDraggableComponent DragButton;

	// Token: 0x040095A4 RID: 38308
	private UUIItem DragCenter;

	// Token: 0x040095A5 RID: 38309
	private FVector? StartDragPosition;

	// Token: 0x040095A6 RID: 38310
	private UUIText TipsText;

	// Token: 0x040095A7 RID: 38311
	[Nullable(1)]
	private readonly Vector InputVector = Vector.Create();

	// Token: 0x040095A8 RID: 38312
	private float SlideLength;

	// Token: 0x040095A9 RID: 38313
	private float CacheLength;

	// Token: 0x040095AA RID: 38314
	private float CacheAngle;

	// Token: 0x040095AB RID: 38315
	private float Direction;

	// Token: 0x040095AC RID: 38316
	private float LerpSpeed;

	// Token: 0x040095AD RID: 38317
	private bool CheckByRealTimeInput;

	// Token: 0x040095AE RID: 38318
	private bool HasInputTurn;

	// Token: 0x040095AF RID: 38319
	private bool HasInputLookup;

	// Token: 0x040095B0 RID: 38320
	private bool IsDragging;

	// Token: 0x02008C48 RID: 35912
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D8A2 RID: 186530
		DragButton,
		// Token: 0x0402D8A3 RID: 186531
		DragCenter,
		// Token: 0x0402D8A4 RID: 186532
		TipsText,
		// Token: 0x0402D8A5 RID: 186533
		HotKey
	}
}
