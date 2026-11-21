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

// Token: 0x02001AF8 RID: 6904
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteCompassRotateItem : CommonQteItemBase<CommonQteDragContext>
{
	// Token: 0x060112BC RID: 70332 RVA: 0x0050BA24 File Offset: 0x00509C24
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

	// Token: 0x060112BD RID: 70333 RVA: 0x0050BAAC File Offset: 0x00509CAC
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteCompassRotateItem.<OnBeforeStartAsync>d__17 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteCompassRotateItem.<OnBeforeStartAsync>d__17>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060112BE RID: 70334 RVA: 0x0050BAF0 File Offset: 0x00509CF0
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

	// Token: 0x060112BF RID: 70335 RVA: 0x0050BB50 File Offset: 0x00509D50
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

	// Token: 0x060112C0 RID: 70336 RVA: 0x0050BC77 File Offset: 0x00509E77
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteDragContext;
	}

	// Token: 0x060112C1 RID: 70337 RVA: 0x0050BC82 File Offset: 0x00509E82
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

	// Token: 0x060112C2 RID: 70338 RVA: 0x0050BCB4 File Offset: 0x00509EB4
	protected override void TryApplyQteUiConfig(object uiConfig)
	{
		SCommonQte_Drag scommonQte_Drag = uiConfig as SCommonQte_Drag;
		if (scommonQte_Drag != null)
		{
			this.RotateSpeed = scommonQte_Drag.CompassSpeed / 1000f;
		}
	}

	// Token: 0x060112C3 RID: 70339 RVA: 0x0050BCE8 File Offset: 0x00509EE8
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

	// Token: 0x060112C4 RID: 70340 RVA: 0x0050BD68 File Offset: 0x00509F68
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

	// Token: 0x060112C5 RID: 70341 RVA: 0x0050BDC0 File Offset: 0x00509FC0
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

	// Token: 0x060112C6 RID: 70342 RVA: 0x0050BE32 File Offset: 0x0050A032
	protected override bool IsUseBaseAction()
	{
		return false;
	}

	// Token: 0x060112C7 RID: 70343 RVA: 0x0050BE38 File Offset: 0x0050A038
	protected override void OnBindAction()
	{
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiScroll2", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiScroll1", new TInputHandle<float>(this.OnInputLookup));
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x060112C8 RID: 70344 RVA: 0x0050BE98 File Offset: 0x0050A098
	protected override void OnUnbindAction()
	{
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiScroll2", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiScroll1", new TInputHandle<float>(this.OnInputLookup));
		EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x060112C9 RID: 70345 RVA: 0x0050BEF8 File Offset: 0x0050A0F8
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

	// Token: 0x060112CA RID: 70346 RVA: 0x0050BF38 File Offset: 0x0050A138
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

	// Token: 0x060112CB RID: 70347 RVA: 0x0050BF90 File Offset: 0x0050A190
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

	// Token: 0x060112CC RID: 70348 RVA: 0x0050BFE8 File Offset: 0x0050A1E8
	private void OnPointerDownCallBack(ULGUIPointerEventData eventData)
	{
		this.RelativeAngle = this.CacheAngle;
	}

	// Token: 0x060112CD RID: 70349 RVA: 0x0050BFF6 File Offset: 0x0050A1F6
	private void OnPointerUpCallBack(ULGUIPointerEventData eventData)
	{
		this.RelativeAngle = 90;
	}

	// Token: 0x060112CE RID: 70350 RVA: 0x0050C008 File Offset: 0x0050A208
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

	// Token: 0x060112CF RID: 70351 RVA: 0x0050C09C File Offset: 0x0050A29C
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

	// Token: 0x060112D0 RID: 70352 RVA: 0x0050C16A File Offset: 0x0050A36A
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

	// Token: 0x060112D1 RID: 70353 RVA: 0x0050C1A9 File Offset: 0x0050A3A9
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

	// Token: 0x060112D2 RID: 70354 RVA: 0x0050C1E0 File Offset: 0x0050A3E0
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

	// Token: 0x04009708 RID: 38664
	private InputMultiKeyItem KeyItem;

	// Token: 0x04009709 RID: 38665
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400970A RID: 38666
	private bool HasInputTurn;

	// Token: 0x0400970B RID: 38667
	private bool HasInputLookup;

	// Token: 0x0400970C RID: 38668
	private bool IsDragging;

	// Token: 0x0400970D RID: 38669
	private UUIItem Pointer;

	// Token: 0x0400970E RID: 38670
	private FRotator PointerRotator = new FRotator();

	// Token: 0x0400970F RID: 38671
	private FVector? AnchorLocation;

	// Token: 0x04009710 RID: 38672
	private Number StartAngle = 0;

	// Token: 0x04009711 RID: 38673
	private Number DragOffset = 0;

	// Token: 0x04009712 RID: 38674
	private Number CurrentAngle = 0;

	// Token: 0x04009713 RID: 38675
	private Number CacheAngle = 90;

	// Token: 0x04009714 RID: 38676
	[Nullable(1)]
	private readonly Vector2D GamepadOffset = Vector2D.Create();

	// Token: 0x04009715 RID: 38677
	private Number RotateSpeed = 0;

	// Token: 0x04009716 RID: 38678
	private Number RelativeAngle = 90;

	// Token: 0x02007DD3 RID: 32211
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028BC2 RID: 166850
		Prefab,
		// Token: 0x04028BC3 RID: 166851
		Drag,
		// Token: 0x04028BC4 RID: 166852
		Pointer,
		// Token: 0x04028BC5 RID: 166853
		HotKey
	}
}
