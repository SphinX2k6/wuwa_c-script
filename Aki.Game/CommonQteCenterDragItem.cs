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

// Token: 0x02001AF7 RID: 6903
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteCenterDragItem : CommonQteItemBase<CommonQteDragContext>
{
	// Token: 0x060112A5 RID: 70309 RVA: 0x0050B0F0 File Offset: 0x005092F0
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

	// Token: 0x060112A6 RID: 70310 RVA: 0x0050B1A8 File Offset: 0x005093A8
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteCenterDragItem.<OnBeforeStartAsync>d__21 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteCenterDragItem.<OnBeforeStartAsync>d__21>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060112A7 RID: 70311 RVA: 0x0050B1EC File Offset: 0x005093EC
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

	// Token: 0x060112A8 RID: 70312 RVA: 0x0050B2AC File Offset: 0x005094AC
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

	// Token: 0x060112A9 RID: 70313 RVA: 0x0050B311 File Offset: 0x00509511
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteDragContext;
	}

	// Token: 0x060112AA RID: 70314 RVA: 0x0050B31C File Offset: 0x0050951C
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

	// Token: 0x060112AB RID: 70315 RVA: 0x0050B350 File Offset: 0x00509550
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

	// Token: 0x060112AC RID: 70316 RVA: 0x0050B400 File Offset: 0x00509600
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

	// Token: 0x060112AD RID: 70317 RVA: 0x0050B458 File Offset: 0x00509658
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

	// Token: 0x060112AE RID: 70318 RVA: 0x0050B4B8 File Offset: 0x005096B8
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

	// Token: 0x060112AF RID: 70319 RVA: 0x0050B50A File Offset: 0x0050970A
	protected override bool IsUseBaseAction()
	{
		return false;
	}

	// Token: 0x060112B0 RID: 70320 RVA: 0x0050B510 File Offset: 0x00509710
	protected override void OnBindAction()
	{
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiScroll2", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiScroll1", new TInputHandle<float>(this.OnInputLookup));
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x060112B1 RID: 70321 RVA: 0x0050B570 File Offset: 0x00509770
	protected override void OnUnbindAction()
	{
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiScroll2", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiScroll1", new TInputHandle<float>(this.OnInputLookup));
		EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x060112B2 RID: 70322 RVA: 0x0050B5D0 File Offset: 0x005097D0
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

	// Token: 0x060112B3 RID: 70323 RVA: 0x0050B630 File Offset: 0x00509830
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

	// Token: 0x060112B4 RID: 70324 RVA: 0x0050B688 File Offset: 0x00509888
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

	// Token: 0x060112B5 RID: 70325 RVA: 0x0050B6E0 File Offset: 0x005098E0
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

	// Token: 0x060112B6 RID: 70326 RVA: 0x0050B71C File Offset: 0x0050991C
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

	// Token: 0x060112B7 RID: 70327 RVA: 0x0050B7AB File Offset: 0x005099AB
	private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
	{
		this.ResetPointerInput();
	}

	// Token: 0x060112B8 RID: 70328 RVA: 0x0050B7B3 File Offset: 0x005099B3
	private void ResetPointerInput()
	{
		this.StartDragPosition = null;
		this.InputVector.Reset();
		this.SetIsDragging(false);
	}

	// Token: 0x060112B9 RID: 70329 RVA: 0x0050B7D4 File Offset: 0x005099D4
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

	// Token: 0x060112BA RID: 70330 RVA: 0x0050B870 File Offset: 0x00509A70
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

	// Token: 0x040096F5 RID: 38645
	private const float GAMEPAD_ENHANCE_RATE = 1.43f;

	// Token: 0x040096F6 RID: 38646
	[Nullable(1)]
	private const string DRAG_SEQUENCE = "Drag";

	// Token: 0x040096F7 RID: 38647
	[Nullable(1)]
	private const string REST_SEQUENCE = "Reset";

	// Token: 0x040096F8 RID: 38648
	private InputMultiKeyItem KeyItem;

	// Token: 0x040096F9 RID: 38649
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040096FA RID: 38650
	private UUIDraggableComponent DragButton;

	// Token: 0x040096FB RID: 38651
	private UUIItem DragCenter;

	// Token: 0x040096FC RID: 38652
	private FVector? StartDragPosition;

	// Token: 0x040096FD RID: 38653
	private UUIText TipsText;

	// Token: 0x040096FE RID: 38654
	[Nullable(1)]
	private readonly Vector InputVector = Vector.Create();

	// Token: 0x040096FF RID: 38655
	private float SlideLength;

	// Token: 0x04009700 RID: 38656
	private float CacheLength;

	// Token: 0x04009701 RID: 38657
	private float CacheAngle;

	// Token: 0x04009702 RID: 38658
	private float Direction;

	// Token: 0x04009703 RID: 38659
	private float LerpSpeed;

	// Token: 0x04009704 RID: 38660
	private bool CheckByRealTimeInput;

	// Token: 0x04009705 RID: 38661
	private bool HasInputTurn;

	// Token: 0x04009706 RID: 38662
	private bool HasInputLookup;

	// Token: 0x04009707 RID: 38663
	private bool IsDragging;

	// Token: 0x02007DD1 RID: 32209
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028BB9 RID: 166841
		DragButton,
		// Token: 0x04028BBA RID: 166842
		DragCenter,
		// Token: 0x04028BBB RID: 166843
		TipsText,
		// Token: 0x04028BBC RID: 166844
		HotKey
	}
}
