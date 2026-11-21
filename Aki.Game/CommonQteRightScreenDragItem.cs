using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B02 RID: 6914
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteRightScreenDragItem : CommonQteItemBase<CommonQteDragContext>
{
	// Token: 0x0601138F RID: 70543 RVA: 0x005104A4 File Offset: 0x0050E6A4
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIDraggableComponent))
		};
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(2, typeof(UUIItem)));
		}
	}

	// Token: 0x06011390 RID: 70544 RVA: 0x00510518 File Offset: 0x0050E718
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteRightScreenDragItem.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteRightScreenDragItem.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011391 RID: 70545 RVA: 0x0051055C File Offset: 0x0050E75C
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

	// Token: 0x06011392 RID: 70546 RVA: 0x00510622 File Offset: 0x0050E822
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteDragContext;
	}

	// Token: 0x06011393 RID: 70547 RVA: 0x0051062D File Offset: 0x0050E82D
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

	// Token: 0x06011394 RID: 70548 RVA: 0x00510660 File Offset: 0x0050E860
	[NullableContext(2)]
	protected override void TryApplyQteUiConfig(object uiConfig)
	{
		SCommonQte_Drag scommonQte_Drag = uiConfig as SCommonQte_Drag;
		if (scommonQte_Drag != null)
		{
			this.Bounds = scommonQte_Drag.DragBounds;
			this.Length = scommonQte_Drag.DragLength;
			this.LerpSpeed = scommonQte_Drag.LerpSpeed / this.Length / 1000f;
			this.CheckByRealTimeInput = scommonQte_Drag.CheckByRealTimeInput;
		}
	}

	// Token: 0x06011395 RID: 70549 RVA: 0x005106BC File Offset: 0x0050E8BC
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

	// Token: 0x06011396 RID: 70550 RVA: 0x0051073C File Offset: 0x0050E93C
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

	// Token: 0x06011397 RID: 70551 RVA: 0x00510794 File Offset: 0x0050E994
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

	// Token: 0x06011398 RID: 70552 RVA: 0x00510806 File Offset: 0x0050EA06
	protected override bool IsUseBaseAction()
	{
		return false;
	}

	// Token: 0x06011399 RID: 70553 RVA: 0x0051080C File Offset: 0x0050EA0C
	protected override void OnBindAction()
	{
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiTurn", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiLookUp", new TInputHandle<float>(this.OnInputLookup));
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x0601139A RID: 70554 RVA: 0x0051086C File Offset: 0x0050EA6C
	protected override void OnUnbindAction()
	{
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiTurn", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiLookUp", new TInputHandle<float>(this.OnInputLookup));
		EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x0601139B RID: 70555 RVA: 0x005108CC File Offset: 0x0050EACC
	private void OnInputControllerChange(EInputControllerType last, EInputControllerType now)
	{
		if (!Info.Instance.IsInGamepad())
		{
			this.GamepadOffset.Reset();
			this.HasInputLookup = false;
			this.HasInputTurn = false;
		}
		else
		{
			this.DerivedProgress = 0f;
			this.DragValid = false;
			this.CurDrag.Reset();
		}
		this.SetIsDragging(false);
	}

	// Token: 0x0601139C RID: 70556 RVA: 0x00510924 File Offset: 0x0050EB24
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

	// Token: 0x0601139D RID: 70557 RVA: 0x00510978 File Offset: 0x0050EB78
	private void OnInputTurn(string name, float value, InputIdentification inputIdentification)
	{
		if (!base.IsValidInput() || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.HasInputTurn = (value != 0f);
		this.GamepadOffset.X = (double)value;
		this.SetIsDragging(this.HasInputTurn || this.HasInputLookup);
	}

	// Token: 0x0601139E RID: 70558 RVA: 0x005109D0 File Offset: 0x0050EBD0
	private void OnInputLookup(string name, float value, InputIdentification inputIdentification)
	{
		if (!base.IsValidInput() || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.HasInputLookup = (value != 0f);
		this.GamepadOffset.Y = (double)(-(double)value);
		this.SetIsDragging(this.HasInputTurn || this.HasInputLookup);
	}

	// Token: 0x0601139F RID: 70559 RVA: 0x00510A28 File Offset: 0x0050EC28
	[NullableContext(2)]
	private void OnPointerDownCallBack(ULGUIPointerEventData eventData)
	{
		this.DerivedProgress = this.CacheProgress;
	}

	// Token: 0x060113A0 RID: 70560 RVA: 0x00510A36 File Offset: 0x0050EC36
	[NullableContext(2)]
	private void OnPointerUpCallBack(ULGUIPointerEventData eventData)
	{
		this.DerivedProgress = 0f;
	}

	// Token: 0x060113A1 RID: 70561 RVA: 0x00510A44 File Offset: 0x0050EC44
	[NullableContext(2)]
	private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!base.IsValidInput() || !this.HasBindAction || eventData == null)
		{
			return;
		}
		this.SetIsDragging(true);
		FVector pointerPosition = eventData.pointerPosition;
		LguiUtil.Instance.ConvertPointerPositionToLguiCenterPosition(pointerPosition, this.StartDrag);
		this.CurDrag.DeepCopy(this.StartDrag);
		this.DragValid = true;
	}

	// Token: 0x060113A2 RID: 70562 RVA: 0x00510A9C File Offset: 0x0050EC9C
	[NullableContext(2)]
	private void OnPointerDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!base.IsValidInput() || !this.HasBindAction || !this.IsDragging || eventData == null)
		{
			return;
		}
		if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
		{
			this.SetIsDragging(false);
			this.DragValid = false;
			return;
		}
		if (!this.DragValid)
		{
			return;
		}
		FVector pointerPosition = eventData.pointerPosition;
		LguiUtil.Instance.ConvertPointerPositionToLguiCenterPosition(pointerPosition, this.CurDrag);
	}

	// Token: 0x060113A3 RID: 70563 RVA: 0x00510B04 File Offset: 0x0050ED04
	[NullableContext(2)]
	private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!base.IsValidInput() || !this.HasBindAction)
		{
			return;
		}
		this.CurDrag.Reset();
		this.StartDrag.Reset();
		this.DragValid = false;
		this.CurrentProgress = 0f;
		this.SetIsDragging(false);
	}

	// Token: 0x060113A4 RID: 70564 RVA: 0x00510B51 File Offset: 0x0050ED51
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

	// Token: 0x060113A5 RID: 70565 RVA: 0x00510B88 File Offset: 0x0050ED88
	protected override void OnTickQteItem(float delta)
	{
		if (Info.Instance.IsInGamepad())
		{
			if (MathUtils.Instance.IsNearlyZero(this.GamepadOffset.Size(), null))
			{
				this.CurrentProgress -= delta * this.LerpSpeed;
			}
			else
			{
				FVector2D fvector2D = new FVector2D();
				fvector2D.X = MathUtils.Instance.Clamp(delta * this.LerpSpeed, 0f, 1f);
				fvector2D.Y = this.MoveCurve.GetFloatValue(this.CurrentProgress + fvector2D.X);
				float num = fvector2D.Size();
				if (num == 0f)
				{
					return;
				}
				float num2 = (float)this.GamepadOffset.DotProduct(fvector2D) / num;
				this.CurrentProgress += num2 * fvector2D.X;
			}
		}
		else if (this.DragValid)
		{
			this.CurrentProgress = (float)(this.CurDrag.X - this.StartDrag.X) / this.Length + this.DerivedProgress;
			float num3 = (float)(this.CurDrag.Y - this.StartDrag.Y) / this.Length;
			if (Math.Abs(this.MoveCurve.GetFloatValue(MathUtils.Instance.Clamp(this.CurrentProgress, 0f, 1f)) - num3) * this.Length > this.Bounds)
			{
				this.CurDrag.Reset();
				this.StartDrag.Reset();
				this.DragValid = false;
				this.SetIsDragging(false);
			}
		}
		else
		{
			this.CurrentProgress = this.DerivedProgress;
		}
		this.CurrentProgress = MathUtils.Instance.Clamp(this.CurrentProgress, 0f, 1f);
		this.CacheProgress = MathUtils.Instance.InterpConstantTo(this.CacheProgress, this.CurrentProgress, delta, this.LerpSpeed);
		this.CommonQteContext.SetDraggingInfo(this.CacheProgress, 0f);
		if (this.CheckByRealTimeInput && this.CommonQteContext.CheckDragComplete(this.CurrentProgress, 0f))
		{
			this.CommonQteContext.SetPreResult(true);
		}
	}

	// Token: 0x0400976F RID: 38767
	private const string CURVE_PATH = "/Game/Aki/UI/UIResources/UiFight/Curve/PlotQTE/PlotQteDragRT1.PlotQteDragRT1";

	// Token: 0x04009770 RID: 38768
	[Nullable(2)]
	private InputMultiKeyItem KeyItem;

	// Token: 0x04009771 RID: 38769
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04009772 RID: 38770
	[Nullable(2)]
	private UCurveFloat MoveCurve;

	// Token: 0x04009773 RID: 38771
	private bool HasInputTurn;

	// Token: 0x04009774 RID: 38772
	private bool HasInputLookup;

	// Token: 0x04009775 RID: 38773
	private bool IsDragging;

	// Token: 0x04009776 RID: 38774
	private bool DragValid;

	// Token: 0x04009777 RID: 38775
	private float CurrentProgress;

	// Token: 0x04009778 RID: 38776
	private float DerivedProgress;

	// Token: 0x04009779 RID: 38777
	private float CacheProgress;

	// Token: 0x0400977A RID: 38778
	private float LerpSpeed;

	// Token: 0x0400977B RID: 38779
	private float Bounds;

	// Token: 0x0400977C RID: 38780
	private float Length;

	// Token: 0x0400977D RID: 38781
	private readonly Vector2D StartDrag = Vector2D.Create();

	// Token: 0x0400977E RID: 38782
	private readonly Vector2D CurDrag = Vector2D.Create();

	// Token: 0x0400977F RID: 38783
	private readonly Vector2D GamepadOffset = Vector2D.Create();

	// Token: 0x04009780 RID: 38784
	private bool CheckByRealTimeInput;

	// Token: 0x02007DE5 RID: 32229
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028C16 RID: 166934
		Prefab,
		// Token: 0x04028C17 RID: 166935
		Drag,
		// Token: 0x04028C18 RID: 166936
		HotKey
	}
}
