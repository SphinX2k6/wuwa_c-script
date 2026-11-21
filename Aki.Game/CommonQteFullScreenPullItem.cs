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

// Token: 0x02001AFE RID: 6910
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CommonQteFullScreenPullItem : CommonQteItemBase<CommonQteDragContext>
{
	// Token: 0x0601132A RID: 70442 RVA: 0x0050E280 File Offset: 0x0050C480
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

	// Token: 0x0601132B RID: 70443 RVA: 0x0050E318 File Offset: 0x0050C518
	protected override UniTask OnBeforeStartAsync()
	{
		CommonQteFullScreenPullItem.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<CommonQteFullScreenPullItem.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0601132C RID: 70444 RVA: 0x0050E35C File Offset: 0x0050C55C
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

	// Token: 0x0601132D RID: 70445 RVA: 0x0050E422 File Offset: 0x0050C622
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

	// Token: 0x0601132E RID: 70446 RVA: 0x0050E454 File Offset: 0x0050C654
	[NullableContext(1)]
	protected override bool IsContextMatched(CommonQteContextBase context)
	{
		return context is CommonQteDragContext;
	}

	// Token: 0x0601132F RID: 70447 RVA: 0x0050E45F File Offset: 0x0050C65F
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

	// Token: 0x06011330 RID: 70448 RVA: 0x0050E490 File Offset: 0x0050C690
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
			else if (scommonQte_Drag.ViewType == ECommonQteViewType_Drag.莉莉左滑界面)
			{
				this.DragAxis = CommonQteFullScreenPullItem.EDragAxis.X;
				this.DragDirection = -1;
			}
			this.LerpSpeed = scommonQte_Drag.LerpSpeed / 1000f;
			this.CheckByRealTimeInput = scommonQte_Drag.CheckByRealTimeInput;
		}
	}

	// Token: 0x06011331 RID: 70449 RVA: 0x0050E578 File Offset: 0x0050C778
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

	// Token: 0x06011332 RID: 70450 RVA: 0x0050E5F8 File Offset: 0x0050C7F8
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

	// Token: 0x06011333 RID: 70451 RVA: 0x0050E650 File Offset: 0x0050C850
	protected override void RefreshUiOffset()
	{
		if (this.CommonQteContext != null)
		{
			SCommonQte_Drag scommonQte_Drag = this.CommonQteContext.GetUiConfig() as SCommonQte_Drag;
			if (scommonQte_Drag != null && scommonQte_Drag.ViewType != ECommonQteViewType_Drag.莉莉左滑界面)
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

	// Token: 0x06011334 RID: 70452 RVA: 0x0050E6D6 File Offset: 0x0050C8D6
	protected override bool IsUseBaseAction()
	{
		return false;
	}

	// Token: 0x06011335 RID: 70453 RVA: 0x0050E6DC File Offset: 0x0050C8DC
	protected override void OnBindAction()
	{
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiScroll2", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.BindAxisIgnoreLimit("UiScroll1", new TInputHandle<float>(this.OnInputLookup));
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x06011336 RID: 70454 RVA: 0x0050E73C File Offset: 0x0050C93C
	protected override void OnUnbindAction()
	{
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiScroll2", new TInputHandle<float>(this.OnInputTurn));
		InputDistributeController.Instance.UnBindAxisIgnoreLimit("UiScroll1", new TInputHandle<float>(this.OnInputLookup));
		EventSystem.Instance.Remove<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.OnInputControllerChange));
	}

	// Token: 0x06011337 RID: 70455 RVA: 0x0050E79C File Offset: 0x0050C99C
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

	// Token: 0x06011338 RID: 70456 RVA: 0x0050E7F0 File Offset: 0x0050C9F0
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

	// Token: 0x06011339 RID: 70457 RVA: 0x0050E848 File Offset: 0x0050CA48
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

	// Token: 0x0601133A RID: 70458 RVA: 0x0050E8A0 File Offset: 0x0050CAA0
	private void OnPointerDownCallBack(ULGUIPointerEventData eventData)
	{
		this.DerivedLength = this.CacheLength;
	}

	// Token: 0x0601133B RID: 70459 RVA: 0x0050E8AE File Offset: 0x0050CAAE
	private void OnPointerUpCallBack(ULGUIPointerEventData eventData)
	{
		this.DerivedLength = 0f;
	}

	// Token: 0x0601133C RID: 70460 RVA: 0x0050E8BB File Offset: 0x0050CABB
	private void OnPointerBeginDragCallBack(ULGUIPointerEventData eventData)
	{
		if (!base.IsValidInput() || !this.HasBindAction)
		{
			return;
		}
		this.StartDragPosition = new FVector?(eventData.GetLocalPointInPlane());
		this.SetIsDragging(true);
	}

	// Token: 0x0601133D RID: 70461 RVA: 0x0050E8E8 File Offset: 0x0050CAE8
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

	// Token: 0x0601133E RID: 70462 RVA: 0x0050E97B File Offset: 0x0050CB7B
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

	// Token: 0x0601133F RID: 70463 RVA: 0x0050E9B7 File Offset: 0x0050CBB7
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

	// Token: 0x06011340 RID: 70464 RVA: 0x0050E9F0 File Offset: 0x0050CBF0
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

	// Token: 0x06011341 RID: 70465 RVA: 0x0050EB54 File Offset: 0x0050CD54
	private float GetDragInput()
	{
		return (float)((this.DragAxis == CommonQteFullScreenPullItem.EDragAxis.X) ? this.InputVector.X : this.InputVector.Y);
	}

	// Token: 0x04009739 RID: 38713
	private const float GAMEPAD_ENHANCE_RATE = 1.43f;

	// Token: 0x0400973A RID: 38714
	private InputMultiKeyItem KeyItem;

	// Token: 0x0400973B RID: 38715
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400973C RID: 38716
	private float DragLength;

	// Token: 0x0400973D RID: 38717
	private float CacheLength;

	// Token: 0x0400973E RID: 38718
	private float DerivedLength;

	// Token: 0x0400973F RID: 38719
	private float LerpSpeed;

	// Token: 0x04009740 RID: 38720
	private int DragDirection;

	// Token: 0x04009741 RID: 38721
	private CommonQteFullScreenPullItem.EDragAxis DragAxis = CommonQteFullScreenPullItem.EDragAxis.Y;

	// Token: 0x04009742 RID: 38722
	private FVector? StartDragPosition;

	// Token: 0x04009743 RID: 38723
	[Nullable(1)]
	private readonly Vector InputVector = Vector.Create();

	// Token: 0x04009744 RID: 38724
	private bool HasInputTurn;

	// Token: 0x04009745 RID: 38725
	private bool HasInputLookup;

	// Token: 0x04009746 RID: 38726
	private bool IsDragging;

	// Token: 0x04009747 RID: 38727
	private bool CheckByRealTimeInput;

	// Token: 0x02007DE0 RID: 32224
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04028BFF RID: 166911
		Prefab,
		// Token: 0x04028C00 RID: 166912
		Drag,
		// Token: 0x04028C01 RID: 166913
		HotKey
	}

	// Token: 0x02007DE1 RID: 32225
	[NullableContext(0)]
	private enum EDragAxis
	{
		// Token: 0x04028C03 RID: 166915
		X,
		// Token: 0x04028C04 RID: 166916
		Y
	}
}
