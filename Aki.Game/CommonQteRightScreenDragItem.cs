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

// Token: 0x02002617 RID: 9751
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteRightScreenDragItem : CommonQteItemBase<CommonQteDragContext>
{
	// Token: 0x06013EAD RID: 81581 RVA: 0x005015E0 File Offset: 0x004FF7E0
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

	// Token: 0x06013EAE RID: 81582 RVA: 0x00501654 File Offset: 0x004FF854
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteRightScreenDragItem.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteRightScreenDragItem.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013EAF RID: 81583 RVA: 0x00501698 File Offset: 0x004FF898
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

	// Token: 0x06013EB0 RID: 81584 RVA: 0x0050175E File Offset: 0x004FF95E
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteDragContext;
	}

	// Token: 0x06013EB1 RID: 81585 RVA: 0x00501769 File Offset: 0x004FF969
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

	// Token: 0x06013EB2 RID: 81586 RVA: 0x0050179C File Offset: 0x004FF99C
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

	// Token: 0x06013EB3 RID: 81587 RVA: 0x005017F8 File Offset: 0x004FF9F8
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

	// Token: 0x06013EB4 RID: 81588 RVA: 0x00501878 File Offset: 0x004FFA78
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

	// Token: 0x06013EB5 RID: 81589 RVA: 0x005018D0 File Offset: 0x004FFAD0
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

	// Token: 0x06013EB6 RID: 81590 RVA: 0x00501942 File Offset: 0x004FFB42
	protected override bool IsUseBaseAction()
	{
		return false;
	}

	// Token: 0x06013EB7 RID: 81591 RVA: 0x00501948 File Offset: 0x004FFB48
	protected override void OnBindAction()
	{
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiTurn", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiLookUp", new TInputHandle<float>(this.OnInputLookup));
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x06013EB8 RID: 81592 RVA: 0x005019A8 File Offset: 0x004FFBA8
	protected override void OnUnbindAction()
	{
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiTurn", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiLookUp", new TInputHandle<float>(this.OnInputLookup));
		EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x06013EB9 RID: 81593 RVA: 0x00501A08 File Offset: 0x004FFC08
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

	// Token: 0x06013EBA RID: 81594 RVA: 0x00501A60 File Offset: 0x004FFC60
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

	// Token: 0x06013EBB RID: 81595 RVA: 0x00501AB4 File Offset: 0x004FFCB4
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

	// Token: 0x06013EBC RID: 81596 RVA: 0x00501B0C File Offset: 0x004FFD0C
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

	// Token: 0x06013EBD RID: 81597 RVA: 0x00501B64 File Offset: 0x004FFD64
	[NullableContext(2)]
	private void OnPointerDownCallBack(ULGUIPointerEventData eventData)
	{
		this.DerivedProgress = this.CacheProgress;
	}

	// Token: 0x06013EBE RID: 81598 RVA: 0x00501B72 File Offset: 0x004FFD72
	[NullableContext(2)]
	private void OnPointerUpCallBack(ULGUIPointerEventData eventData)
	{
		this.DerivedProgress = 0f;
	}

	// Token: 0x06013EBF RID: 81599 RVA: 0x00501B80 File Offset: 0x004FFD80
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

	// Token: 0x06013EC0 RID: 81600 RVA: 0x00501BD8 File Offset: 0x004FFDD8
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

	// Token: 0x06013EC1 RID: 81601 RVA: 0x00501C40 File Offset: 0x004FFE40
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

	// Token: 0x06013EC2 RID: 81602 RVA: 0x00501C8D File Offset: 0x004FFE8D
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

	// Token: 0x06013EC3 RID: 81603 RVA: 0x00501CC4 File Offset: 0x004FFEC4
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

	// Token: 0x04009618 RID: 38424
	private const string CURVE_PATH = "/Game/Aki/UI/UIResources/UiFight/Curve/PlotQTE/PlotQteDragRT1.PlotQteDragRT1";

	// Token: 0x04009619 RID: 38425
	[Nullable(2)]
	private InputMultiKeyItem KeyItem;

	// Token: 0x0400961A RID: 38426
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400961B RID: 38427
	[Nullable(2)]
	private UCurveFloat MoveCurve;

	// Token: 0x0400961C RID: 38428
	private bool HasInputTurn;

	// Token: 0x0400961D RID: 38429
	private bool HasInputLookup;

	// Token: 0x0400961E RID: 38430
	private bool IsDragging;

	// Token: 0x0400961F RID: 38431
	private bool DragValid;

	// Token: 0x04009620 RID: 38432
	private float CurrentProgress;

	// Token: 0x04009621 RID: 38433
	private float DerivedProgress;

	// Token: 0x04009622 RID: 38434
	private float CacheProgress;

	// Token: 0x04009623 RID: 38435
	private float LerpSpeed;

	// Token: 0x04009624 RID: 38436
	private float Bounds;

	// Token: 0x04009625 RID: 38437
	private float Length;

	// Token: 0x04009626 RID: 38438
	private readonly Vector2D StartDrag = Vector2D.Create();

	// Token: 0x04009627 RID: 38439
	private readonly Vector2D CurDrag = Vector2D.Create();

	// Token: 0x04009628 RID: 38440
	private readonly Vector2D GamepadOffset = Vector2D.Create();

	// Token: 0x04009629 RID: 38441
	private bool CheckByRealTimeInput;

	// Token: 0x02008C5C RID: 35932
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D8FF RID: 186623
		Prefab,
		// Token: 0x0402D900 RID: 186624
		Drag,
		// Token: 0x0402D901 RID: 186625
		HotKey
	}
}
