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

// Token: 0x0200260D RID: 9741
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteCompassRotateItem : CommonQteItemBase<CommonQteDragContext>
{
	// Token: 0x06013DDA RID: 81370 RVA: 0x004FCBE8 File Offset: 0x004FADE8
	protected override void OnRegisterComponent()
	{
		base.OnRegisterComponent();
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIDraggableComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(3, typeof(UUIItem)));
		}
	}

	// Token: 0x06013DDB RID: 81371 RVA: 0x004FCC70 File Offset: 0x004FAE70
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteCompassRotateItem.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteCompassRotateItem.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013DDC RID: 81372 RVA: 0x004FCCB4 File Offset: 0x004FAEB4
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
			this.RelativeAngle = 90;
			this.StartAngle = 0;
			this.DragOffset = 0;
		}
		this.SetIsDragging(false);
	}

	// Token: 0x06013DDD RID: 81373 RVA: 0x004FCD14 File Offset: 0x004FAF14
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
		this.Pointer = base.GetItem(2);
		this.PointerRotator.Pitch = 0f;
		this.PointerRotator.Roll = 0f;
		this.PointerRotator.Yaw = 0f;
		this.CurrentAngle = 90;
		this.AnchorLocation = new FVector?(base.GetItem(2).GetUIWorldPosition());
	}

	// Token: 0x06013DDE RID: 81374 RVA: 0x004FCE3B File Offset: 0x004FB03B
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteDragContext;
	}

	// Token: 0x06013DDF RID: 81375 RVA: 0x004FCE46 File Offset: 0x004FB046
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

	// Token: 0x06013DE0 RID: 81376 RVA: 0x004FCE78 File Offset: 0x004FB078
	protected override void TryApplyQteUiConfig(object uiConfig)
	{
		SCommonQte_Drag scommonQte_Drag = uiConfig as SCommonQte_Drag;
		if (scommonQte_Drag != null)
		{
			this.RotateSpeed = scommonQte_Drag.CompassSpeed / 1000f;
		}
	}

	// Token: 0x06013DE1 RID: 81377 RVA: 0x004FCEAC File Offset: 0x004FB0AC
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

	// Token: 0x06013DE2 RID: 81378 RVA: 0x004FCF2C File Offset: 0x004FB12C
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

	// Token: 0x06013DE3 RID: 81379 RVA: 0x004FCF84 File Offset: 0x004FB184
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

	// Token: 0x06013DE4 RID: 81380 RVA: 0x004FCFF6 File Offset: 0x004FB1F6
	protected override bool IsUseBaseAction()
	{
		return false;
	}

	// Token: 0x06013DE5 RID: 81381 RVA: 0x004FCFFC File Offset: 0x004FB1FC
	protected override void OnBindAction()
	{
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiScroll2", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiScroll1", new TInputHandle<float>(this.OnInputLookup));
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x06013DE6 RID: 81382 RVA: 0x004FD05C File Offset: 0x004FB25C
	protected override void OnUnbindAction()
	{
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiScroll2", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiScroll1", new TInputHandle<float>(this.OnInputLookup));
		EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x06013DE7 RID: 81383 RVA: 0x004FD0BC File Offset: 0x004FB2BC
	protected override void OnHandleQteEnd()
	{
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

	// Token: 0x06013DE8 RID: 81384 RVA: 0x004FD0FC File Offset: 0x004FB2FC
	[NullableContext(1)]
	private void OnInputTurn(string name, float value, InputIdentification inputIdentification)
	{
		if (!base.IsValidInput() || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.GamepadOffset.X = (double)value;
		this.HasInputTurn = (value != 0f);
		this.SetIsDragging(this.HasInputTurn || this.HasInputLookup);
	}

	// Token: 0x06013DE9 RID: 81385 RVA: 0x004FD154 File Offset: 0x004FB354
	[NullableContext(1)]
	private void OnInputLookup(string name, float value, InputIdentification inputIdentification)
	{
		if (!base.IsValidInput() || !Info.Instance.IsInGamepad())
		{
			return;
		}
		this.GamepadOffset.Y = (double)(-(double)value);
		this.HasInputLookup = (value != 0f);
		this.SetIsDragging(this.HasInputTurn || this.HasInputLookup);
	}

	// Token: 0x06013DEA RID: 81386 RVA: 0x004FD1AC File Offset: 0x004FB3AC
	private void OnPointerDownCallBack(ULGUIPointerEventData eventData)
	{
		this.RelativeAngle = this.CacheAngle;
	}

	// Token: 0x06013DEB RID: 81387 RVA: 0x004FD1BA File Offset: 0x004FB3BA
	private void OnPointerUpCallBack(ULGUIPointerEventData eventData)
	{
		this.RelativeAngle = 90;
	}

	// Token: 0x06013DEC RID: 81388 RVA: 0x004FD1CC File Offset: 0x004FB3CC
	private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!base.IsValidInput() || !this.HasBindAction || eventData == null)
		{
			return;
		}
		this.SetIsDragging(true);
		FVector pointerPosition = eventData.pointerPosition;
		Vector2D vector2D = Vector2D.Create();
		LguiUtil.Instance.ConvertPointerPositionToLguiCenterPosition(pointerPosition, vector2D);
		this.StartAngle = Rotator.ClampAxis((float)(Math.Atan2(vector2D.Y - (double)this.AnchorLocation.Value.Y, vector2D.X - (double)this.AnchorLocation.Value.X) * 57.295780181884766));
	}

	// Token: 0x06013DED RID: 81389 RVA: 0x004FD260 File Offset: 0x004FB460
	private void OnPointerDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!base.IsValidInput() || !this.HasBindAction || !this.IsDragging || eventData == null)
		{
			return;
		}
		if (TouchFingerManager.Instance.GetTouchFingerCount() > 1)
		{
			this.SetIsDragging(false);
			this.DragOffset = 0;
			this.StartAngle = 0;
			return;
		}
		FVector pointerPosition = eventData.pointerPosition;
		Vector2D vector2D = Vector2D.Create();
		LguiUtil.Instance.ConvertPointerPositionToLguiCenterPosition(pointerPosition, vector2D);
		float num = Rotator.ClampAxis((float)(Math.Atan2(vector2D.Y - (double)this.AnchorLocation.Value.Y, vector2D.X - (double)this.AnchorLocation.Value.X) * 57.295780181884766));
		this.DragOffset = num - this.StartAngle;
	}

	// Token: 0x06013DEE RID: 81390 RVA: 0x004FD32E File Offset: 0x004FB52E
	private void OnPointerEndDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!base.IsValidInput() || !this.HasBindAction)
		{
			return;
		}
		this.SetIsDragging(false);
		this.DragOffset = 0;
		this.StartAngle = 0;
		this.RelativeAngle = 90;
	}

	// Token: 0x06013DEF RID: 81391 RVA: 0x004FD36D File Offset: 0x004FB56D
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

	// Token: 0x06013DF0 RID: 81392 RVA: 0x004FD3A4 File Offset: 0x004FB5A4
	protected override void OnTickQteItem(float delta)
	{
		if (Info.Instance.IsInGamepad())
		{
			if (MathUtils.Instance.IsNearlyZero(this.GamepadOffset.Size(), null))
			{
				this.CurrentAngle = this.RelativeAngle;
			}
			else
			{
				this.CurrentAngle = Math.Atan2(this.GamepadOffset.Y, this.GamepadOffset.X) * 57.295780181884766;
			}
		}
		else
		{
			this.CurrentAngle = this.RelativeAngle + this.DragOffset;
		}
		this.CurrentAngle = MathUtils.Instance.ClampAngle((double)this.CurrentAngle, 0.0, 90.0);
		this.CacheAngle = MathUtils.Instance.InterpConstantTo(this.CacheAngle, this.CurrentAngle, delta, this.RotateSpeed);
		this.CommonQteContext.SetDraggingInfo(0f, (90 - this.CacheAngle) * 0.017453292f);
		this.PointerRotator.Yaw = this.CacheAngle;
		this.Pointer.SetUIRelativeRotation(this.PointerRotator);
	}

	// Token: 0x040095B1 RID: 38321
	private InputMultiKeyItem KeyItem;

	// Token: 0x040095B2 RID: 38322
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x040095B3 RID: 38323
	private bool HasInputTurn;

	// Token: 0x040095B4 RID: 38324
	private bool HasInputLookup;

	// Token: 0x040095B5 RID: 38325
	private bool IsDragging;

	// Token: 0x040095B6 RID: 38326
	private UUIItem Pointer;

	// Token: 0x040095B7 RID: 38327
	private FRotator PointerRotator = new FRotator();

	// Token: 0x040095B8 RID: 38328
	private FVector? AnchorLocation;

	// Token: 0x040095B9 RID: 38329
	private Number StartAngle = 0;

	// Token: 0x040095BA RID: 38330
	private Number DragOffset = 0;

	// Token: 0x040095BB RID: 38331
	private Number CurrentAngle = 0;

	// Token: 0x040095BC RID: 38332
	private Number CacheAngle = 90;

	// Token: 0x040095BD RID: 38333
	[Nullable(1)]
	private readonly Vector2D GamepadOffset = Vector2D.Create();

	// Token: 0x040095BE RID: 38334
	private Number RotateSpeed = 0;

	// Token: 0x040095BF RID: 38335
	private Number RelativeAngle = 90;

	// Token: 0x02008C4A RID: 35914
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402D8AB RID: 186539
		Prefab,
		// Token: 0x0402D8AC RID: 186540
		Drag,
		// Token: 0x0402D8AD RID: 186541
		Pointer,
		// Token: 0x0402D8AE RID: 186542
		HotKey
	}
}
