using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001369 RID: 4969
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryGridItemBase : UiPanelBase
{
	// Token: 0x0600C503 RID: 50435 RVA: 0x003A9400 File Offset: 0x003A7600
	public HonamiStoryGridItemBase(bool needItem, HonamiStoryBackpackPanelBase panel = null, HonamiStoryItemDataBase itemData = null)
	{
		this.NeedItem = needItem;
		if (panel != null)
		{
			this.Panel = panel;
		}
		if (itemData != null)
		{
			this.Data = itemData;
		}
	}

	// Token: 0x17001305 RID: 4869
	// (get) Token: 0x0600C504 RID: 50436 RVA: 0x003A94D1 File Offset: 0x003A76D1
	private bool NeedItem { get; }

	// Token: 0x0600C505 RID: 50437 RVA: 0x003A94DC File Offset: 0x003A76DC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickedGridButton));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600C506 RID: 50438 RVA: 0x003A95A4 File Offset: 0x003A77A4
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryGridItemBase.<OnBeforeStartAsync>d__38 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryGridItemBase.<OnBeforeStartAsync>d__38>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C507 RID: 50439 RVA: 0x003A95E8 File Offset: 0x003A77E8
	protected override void OnStart()
	{
		FVector2D viewportSize = UWidgetLayoutLibrary.GetViewportSize(GlobalData.World);
		float viewportScale = UWidgetLayoutLibrary.GetViewportScale(GlobalData.World);
		this.ScreenHeight = viewportSize.Y / viewportScale;
		this.DragDistanceThreshold = viewportScale * 40f;
		this.DragSpeedThreshold = (float)HonamiStoryConfig.Instance.GetDragThresholdSpeed();
		this.SpriteBg = base.GetSprite(1);
		UUIButtonComponent button = base.GetButton(2);
		if (button != null)
		{
			button.OnPointDownCallBack.Bind(new Action(this.OnBtnPointDown));
		}
		UUIButtonComponent button2 = base.GetButton(2);
		if (button2 != null)
		{
			button2.OnPointEnterCallBack.Bind(new Action(this.OnBtnPointEnter));
		}
		UUIButtonComponent button3 = base.GetButton(2);
		if (button3 == null)
		{
			return;
		}
		button3.OnPointExitCallBack.Bind(new Action(this.OnBtnPointExit));
	}

	// Token: 0x0600C508 RID: 50440 RVA: 0x003A96B0 File Offset: 0x003A78B0
	protected override void OnBeforeDestroy()
	{
		UUIButtonComponent button = base.GetButton(2);
		if (button != null)
		{
			button.OnPointDownCallBack.Unbind();
		}
		UUIButtonComponent button2 = base.GetButton(2);
		if (button2 != null)
		{
			button2.OnPointEnterCallBack.Unbind();
		}
		UUIButtonComponent button3 = base.GetButton(2);
		if (button3 == null)
		{
			return;
		}
		button3.OnPointExitCallBack.Unbind();
	}

	// Token: 0x17001306 RID: 4870
	// (get) Token: 0x0600C509 RID: 50441 RVA: 0x003A9701 File Offset: 0x003A7901
	private HonamiStoryItemDataBase ItemData
	{
		get
		{
			return this.Data;
		}
	}

	// Token: 0x0600C50A RID: 50442 RVA: 0x003A9709 File Offset: 0x003A7909
	[NullableContext(1)]
	public HonamiStoryBackpackPanelBase GetPanel()
	{
		return this.Panel;
	}

	// Token: 0x0600C50B RID: 50443 RVA: 0x003A9711 File Offset: 0x003A7911
	public int GetEmptyPosition()
	{
		return this.EmptyPosition;
	}

	// Token: 0x0600C50C RID: 50444 RVA: 0x003A9719 File Offset: 0x003A7919
	public HonamiStoryItemGridItem GetItemGridItem()
	{
		return this.ItemGridItem;
	}

	// Token: 0x0600C50D RID: 50445 RVA: 0x003A9721 File Offset: 0x003A7921
	[NullableContext(1)]
	public void RegisterPanel(HonamiStoryBackpackPanelBase panel)
	{
		this.Panel = panel;
	}

	// Token: 0x0600C50E RID: 50446 RVA: 0x003A972A File Offset: 0x003A792A
	[NullableContext(1)]
	protected virtual HonamiStoryItemGridItem CreateGridItem([Nullable(2)] HonamiStoryItemDataBase data)
	{
		return new HonamiStoryItemGridItem(data);
	}

	// Token: 0x0600C50F RID: 50447 RVA: 0x003A9734 File Offset: 0x003A7934
	protected UniTask InitItemGridItem(HonamiStoryItemDataBase data, int position)
	{
		HonamiStoryGridItemBase.<InitItemGridItem>d__48 <InitItemGridItem>d__;
		<InitItemGridItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitItemGridItem>d__.<>4__this = this;
		<InitItemGridItem>d__.data = data;
		<InitItemGridItem>d__.position = position;
		<InitItemGridItem>d__.<>1__state = -1;
		<InitItemGridItem>d__.<>t__builder.Start<HonamiStoryGridItemBase.<InitItemGridItem>d__48>(ref <InitItemGridItem>d__);
		return <InitItemGridItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C510 RID: 50448 RVA: 0x003A9788 File Offset: 0x003A7988
	protected UniTask InitSweepItem(HonamiStoryItemDataBase data)
	{
		HonamiStoryGridItemBase.<InitSweepItem>d__49 <InitSweepItem>d__;
		<InitSweepItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSweepItem>d__.<>4__this = this;
		<InitSweepItem>d__.<>1__state = -1;
		<InitSweepItem>d__.<>t__builder.Start<HonamiStoryGridItemBase.<InitSweepItem>d__49>(ref <InitSweepItem>d__);
		return <InitSweepItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C511 RID: 50449 RVA: 0x003A97CC File Offset: 0x003A79CC
	public virtual void Refresh(HonamiStoryItemDataBase data, int position)
	{
		this.Data = data;
		if (this.IsForDrag)
		{
			UUISprite sprite = base.GetSprite(1);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
		}
		if (data == null)
		{
			this.EmptyPosition = position;
			this.CheckOverflowEnable(position, false);
			this.SetSpriteByPath("/Game/Aki/UI/UIResources/UiActivity/Atlas/Activity28/HonamiStory/HonamiStoryBackpack/SP_GridEmpty.SP_GridEmpty", base.GetSprite(1), false, null, null);
			HonamiStoryItemGridItem itemGridItem = this.ItemGridItem;
			if (itemGridItem != null)
			{
				itemGridItem.SetUiActive(false);
			}
			this.ClearSequence();
			return;
		}
		if (this.ItemGridItem == null)
		{
			this.InitItemGridItem(data, position).ContinueWith(delegate()
			{
				this.PlayNewlyPickedUpSweepAnimation(data);
			});
			return;
		}
		this.ItemGridItem.SetUiActive(true);
		this.ItemGridItem.Refresh(data, position != -1);
		this.CheckOverflowEnable(position, true);
		this.SetSpriteByPath(data.GetQualityConfig().Value.GridBg, base.GetSprite(1), false, null, null);
		this.PlayNewlyPickedUpSweepAnimation(data);
	}

	// Token: 0x0600C512 RID: 50450 RVA: 0x003A98F6 File Offset: 0x003A7AF6
	public int GetIncId()
	{
		HonamiStoryItemDataBase itemData = this.ItemData;
		if (itemData == null)
		{
			return -1;
		}
		return itemData.GetIncId();
	}

	// Token: 0x0600C513 RID: 50451 RVA: 0x003A9909 File Offset: 0x003A7B09
	public HonamiStoryItemDataBase GetData()
	{
		return this.Data;
	}

	// Token: 0x0600C514 RID: 50452 RVA: 0x003A9911 File Offset: 0x003A7B11
	public void SetIsForDrag(bool value)
	{
		this.IsForDrag = value;
	}

	// Token: 0x0600C515 RID: 50453 RVA: 0x003A991C File Offset: 0x003A7B1C
	[NullableContext(1)]
	public UniTask PlaySequenceByName(string sequenceName)
	{
		HonamiStoryGridItemBase.<PlaySequenceByName>d__54 <PlaySequenceByName>d__;
		<PlaySequenceByName>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlaySequenceByName>d__.<>4__this = this;
		<PlaySequenceByName>d__.sequenceName = sequenceName;
		<PlaySequenceByName>d__.<>1__state = -1;
		<PlaySequenceByName>d__.<>t__builder.Start<HonamiStoryGridItemBase.<PlaySequenceByName>d__54>(ref <PlaySequenceByName>d__);
		return <PlaySequenceByName>d__.<>t__builder.Task;
	}

	// Token: 0x0600C516 RID: 50454 RVA: 0x003A9967 File Offset: 0x003A7B67
	public void PlayPosChangeSweepAnimation()
	{
		this.PlaySequenceByName("Sweep_In");
	}

	// Token: 0x0600C517 RID: 50455 RVA: 0x003A9975 File Offset: 0x003A7B75
	[NullableContext(1)]
	public void PlayNewlyPickedUpSweepAnimation(HonamiStoryItemDataBase data)
	{
		if (!data.GetNewInBackpack())
		{
			return;
		}
		this.PlaySequenceByName("Sweep_Tips");
		data.SetNewInBackpack(false);
	}

	// Token: 0x0600C518 RID: 50456 RVA: 0x003A9993 File Offset: 0x003A7B93
	protected void ClearSequence()
	{
		HonamiStoryItemSweepItem sweepItem = this.SweepItem;
		if (sweepItem == null)
		{
			return;
		}
		sweepItem.ClearSequence();
	}

	// Token: 0x0600C519 RID: 50457 RVA: 0x003A99A8 File Offset: 0x003A7BA8
	protected bool CheckOverflowEnable(int position, bool notEmpty)
	{
		if (this.Panel == null)
		{
			return false;
		}
		bool flag = this.Panel.GetBackpackType() == 0;
		if (position == -1 || !flag)
		{
			return false;
		}
		HonamiStoryBackpackData backpackData = HonamiStoryModel.Instance.GetBackPackData(1, false);
		if (notEmpty)
		{
			UiPanelBase overflowItem = this.OverflowItem;
			if (overflowItem != null)
			{
				overflowItem.SetUiActive(false);
			}
			int heightCount = backpackData.GetHeightCount(false);
			bool flag2 = this.ItemData.GetRow() + this.ItemData.GetGridHeight() > heightCount;
			HonamiStoryItemGridItem itemGridItem = this.ItemGridItem;
			if (itemGridItem != null)
			{
				itemGridItem.SetOverFlowEnable(flag2);
			}
			return flag2;
		}
		int capacity = backpackData.GetCapacity();
		if (position < capacity)
		{
			UiPanelBase overflowItem2 = this.OverflowItem;
			if (overflowItem2 != null)
			{
				overflowItem2.SetUiActive(false);
			}
			return false;
		}
		if (this.OverflowItem != null && !this.OverflowItem.InAsyncLoading())
		{
			this.OverflowItem.SetUiActive(true);
		}
		else
		{
			this.OverflowItem = new UiPanelBase();
			this.OverflowItem.CreateThenShowByResourceIdAsync("UiItem_HonamiStoryItemTagEmptyOverflow", this.RootItem, false).ContinueWith(delegate()
			{
				if (this.ItemGridItem != null && this.ItemGridItem.IsUiActiveInHierarchy())
				{
					UiPanelBase overflowItem3 = this.OverflowItem;
					if (overflowItem3 == null)
					{
						return;
					}
					overflowItem3.SetUiActive(false);
					return;
				}
				else
				{
					int capacity2 = backpackData.GetCapacity();
					UiPanelBase overflowItem4 = this.OverflowItem;
					if (overflowItem4 == null)
					{
						return;
					}
					overflowItem4.SetUiActive(this.EmptyPosition >= capacity2);
					return;
				}
			});
		}
		return true;
	}

	// Token: 0x0600C51A RID: 50458 RVA: 0x003A9AC5 File Offset: 0x003A7CC5
	private void OnClickedGridButton()
	{
		this.DoClickedGridButton();
	}

	// Token: 0x0600C51B RID: 50459 RVA: 0x003A9AD0 File Offset: 0x003A7CD0
	protected virtual void OnBtnPointDown()
	{
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		if (backpackLogicState == EHonamiStoryBackpackLogicState.TipsWithPlugins || backpackLogicState == EHonamiStoryBackpackLogicState.Tips)
		{
			HonamiStoryModel.Instance.GetBackpackLogic().CloseTips();
		}
	}

	// Token: 0x0600C51C RID: 50460 RVA: 0x003A9AFF File Offset: 0x003A7CFF
	private void OnBtnPointEnter()
	{
		HonamiStoryModel.Instance.GetInteractController().OnHoverItem(true, base.GetButton(2).RootUIComp);
	}

	// Token: 0x0600C51D RID: 50461 RVA: 0x003A9B22 File Offset: 0x003A7D22
	private void OnBtnPointExit()
	{
		HonamiStoryModel.Instance.GetInteractController().OnUnHover();
	}

	// Token: 0x0600C51E RID: 50462 RVA: 0x003A9B34 File Offset: 0x003A7D34
	protected virtual void DoClickedGridButton()
	{
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		if (backpackLogicState == EHonamiStoryBackpackLogicState.Normal)
		{
			return;
		}
		if (backpackLogicState == EHonamiStoryBackpackLogicState.TipsWithPlugins || backpackLogicState == EHonamiStoryBackpackLogicState.Tips)
		{
			HonamiStoryModel.Instance.GetBackpackLogic().CloseTips();
		}
		if (backpackLogicState == EHonamiStoryBackpackLogicState.Instead)
		{
			HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.Normal);
		}
	}

	// Token: 0x0600C51F RID: 50463 RVA: 0x003A9B76 File Offset: 0x003A7D76
	public void CancelItemToggleSelect()
	{
		HonamiStoryItemGridItem itemGridItem = this.ItemGridItem;
		if (itemGridItem == null)
		{
			return;
		}
		itemGridItem.CancelToggleSelect();
	}

	// Token: 0x0600C520 RID: 50464 RVA: 0x003A9B88 File Offset: 0x003A7D88
	private bool IsCanDragState(bool isBegin)
	{
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		if (isBegin)
		{
			return this.Data != null && (backpackLogicState == EHonamiStoryBackpackLogicState.Normal || backpackLogicState == EHonamiStoryBackpackLogicState.Tips || backpackLogicState == EHonamiStoryBackpackLogicState.TipsWithPlugins);
		}
		return this.CanDrag && (backpackLogicState == EHonamiStoryBackpackLogicState.Normal || backpackLogicState == EHonamiStoryBackpackLogicState.DraggingPlugins || backpackLogicState == EHonamiStoryBackpackLogicState.Dragging);
	}

	// Token: 0x0600C521 RID: 50465 RVA: 0x003A9BD4 File Offset: 0x003A7DD4
	private bool TrySellStateDragLogic(bool isBegin, ULGUIPointerEventData eventData)
	{
		if (HonamiStoryModel.Instance.GetBackpackLogicState() != EHonamiStoryBackpackLogicState.Sell)
		{
			return false;
		}
		HonamiStoryInteractController interactController = HonamiStoryModel.Instance.GetInteractController();
		if (!isBegin)
		{
			interactController.IsSellDragging = false;
			return true;
		}
		if (this.IsGamepadDragging)
		{
			interactController.IsSellDragging = true;
			this.ItemGridItem.DoSellLogic();
			return true;
		}
		Vector currentSellPosition = this.CurrentSellPosition;
		FVector pointerPosition = eventData.pointerPosition;
		FVectorDouble fvectorDouble = pointerPosition;
		currentSellPosition.DeepCopy(fvectorDouble);
		double angleByVector2D = MathUtils.Instance.GetAngleByVector2D(this.CurrentSellPosition.SubtractionEqual(this.LastSellPosition));
		if (Math.Abs(angleByVector2D) < 75.0 || Math.Abs(angleByVector2D) > 105.0)
		{
			interactController.IsSellDragging = true;
			this.ItemGridItem.DoSellLogic();
			return true;
		}
		return false;
	}

	// Token: 0x0600C522 RID: 50466 RVA: 0x003A9C94 File Offset: 0x003A7E94
	private void CloseTipsWhenBeginDrag()
	{
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		if (backpackLogicState != EHonamiStoryBackpackLogicState.Tips && backpackLogicState != EHonamiStoryBackpackLogicState.TipsWithPlugins)
		{
			return;
		}
		HonamiStoryModel.Instance.GetBackpackLogic().CloseTips();
	}

	// Token: 0x0600C523 RID: 50467 RVA: 0x003A9CC4 File Offset: 0x003A7EC4
	public void PlayMoveItemSeq()
	{
		if (!this.IsForDrag)
		{
			return;
		}
		this.ItemGridItem.PlayMoveItemSeq();
	}

	// Token: 0x0600C524 RID: 50468 RVA: 0x003A9CDA File Offset: 0x003A7EDA
	private void RemovePointerDownTimer()
	{
		if (this.LastPointerTimer != null && this.LastPointerTimer.Valid())
		{
			TimerSystem.GameplayTimeInstance.Remove(this.LastPointerTimer);
		}
		this.LastPointerTimer = null;
	}

	// Token: 0x0600C525 RID: 50469 RVA: 0x003A9D09 File Offset: 0x003A7F09
	public void MarkUseCancel()
	{
		this.IsUseCancel = true;
	}

	// Token: 0x0600C526 RID: 50470 RVA: 0x003A9D12 File Offset: 0x003A7F12
	public bool GetIsUseCancel()
	{
		return this.IsUseCancel;
	}

	// Token: 0x0600C527 RID: 50471 RVA: 0x003A9D1A File Offset: 0x003A7F1A
	public void TriggerOnEnterGridCb()
	{
		if (Info.Instance.IsInGamepad())
		{
			Action<HonamiStoryItemGridItem> onEnterGridCb = this.OnEnterGridCb;
			if (onEnterGridCb == null)
			{
				return;
			}
			onEnterGridCb(this.ItemGridItem);
		}
	}

	// Token: 0x0600C528 RID: 50472 RVA: 0x003A9D40 File Offset: 0x003A7F40
	protected void InitDraggable()
	{
		UUIExtendToggle draggableComponent = this.ItemGridItem.DraggableComponent;
		draggableComponent.OnPointEnterCallBack.Bind(new Action<EToggleState>(this.OnPointerEnter));
		draggableComponent.OnPointExitCallBack.Bind(new Action<EToggleState>(this.OnPointerExit));
		draggableComponent.OnPointDownCallBack.Bind(new Action<EToggleState>(this.OnPointerDown));
		draggableComponent.OnPointCancelCallBack.Bind(new Action<EToggleState>(this.OnPointerCancel));
		draggableComponent.OnPointUpCallBack.Bind(new Action<EToggleState>(this.OnPointerUp));
		draggableComponent.OnPointerBeginDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnDragBegin));
		draggableComponent.OnPointerDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnDrag));
		draggableComponent.OnPointerEndDragCallBack.Bind(new Func<ULGUIPointerEventData, bool>(this.OnDragEnd));
	}

	// Token: 0x0600C529 RID: 50473 RVA: 0x003A9E10 File Offset: 0x003A8010
	public void OnPointerEnter(EToggleState _)
	{
		if (HonamiStoryModel.Instance.GetInteractController().IsSellDragging)
		{
			this.ItemGridItem.DoSellLogic();
		}
		if (this.IsDragging || this.OnEnterGridCb == null)
		{
			return;
		}
		this.OnEnterGridCb(this.ItemGridItem);
		HonamiStoryModel.Instance.GetInteractController().OnHoverItem(false, this.ItemGridItem.GetPanelForHover());
	}

	// Token: 0x0600C52A RID: 50474 RVA: 0x003A9E76 File Offset: 0x003A8076
	public void OnPointerExit(EToggleState _)
	{
		if (this.IsDragging || this.OnExitGridCb == null)
		{
			return;
		}
		this.OnExitGridCb();
		HonamiStoryModel.Instance.GetInteractController().OnUnHover();
	}

	// Token: 0x0600C52B RID: 50475 RVA: 0x003A9EA4 File Offset: 0x003A80A4
	public void OnPointerDown(EToggleState _)
	{
		Action onDownGridCb = this.OnDownGridCb;
		if (onDownGridCb != null)
		{
			onDownGridCb();
		}
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		if (backpackLogicState != EHonamiStoryBackpackLogicState.Normal)
		{
			if (backpackLogicState == EHonamiStoryBackpackLogicState.Sell)
			{
				ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
				if (pointerEventData != null)
				{
					Vector lastSellPosition = this.LastSellPosition;
					FVector pointerPosition = pointerEventData.pointerPosition;
					FVectorDouble fvectorDouble = pointerPosition;
					lastSellPosition.DeepCopy(fvectorDouble);
				}
			}
			return;
		}
		this.ItemGridItem.SetCanOpenTips(true);
		ULGUIPointerEventData pointerEventData2 = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
		if (pointerEventData2 != null)
		{
			this.MoveDistanceX = 0.0;
			this.MoveDistanceY = 0.0;
			Vector lastPosition = this.LastPosition;
			FVector pointerPosition = pointerEventData2.pointerPosition;
			FVectorDouble fvectorDouble = pointerPosition;
			lastPosition.DeepCopy(fvectorDouble);
			this.CanDrag = true;
			this.LastPointerDownTime = Time.Instance.Now;
			this.LastPointerTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				AudioSystem.Instance.PostEvent("play_ui_honamistory_backpack_drag");
			}, 500f, null, null, true, 1f);
		}
		this.IsGamepadDragging = UiNavigationNewController.Instance.IsNavigationMousePositionDragging();
		if (this.IsGamepadDragging)
		{
			HonamiStoryGamepadLogicController gamepadLogic = HonamiStoryModel.Instance.GetGamepadLogic();
			if (gamepadLogic != null)
			{
				gamepadLogic.PickUp(this);
			}
			this.RefreshBackpackLogicStateByDrag();
			this.Panel.OnDragBegin(pointerEventData2, this);
			this.Panel.OnDrag(pointerEventData2, this);
		}
	}

	// Token: 0x0600C52C RID: 50476 RVA: 0x003AA001 File Offset: 0x003A8201
	public void OnPointerCancel(EToggleState _)
	{
		if (this.IsStartDrag)
		{
			return;
		}
		this.OnPointerUp(EToggleState.ETT_UnChecked);
	}

	// Token: 0x0600C52D RID: 50477 RVA: 0x003AA014 File Offset: 0x003A8214
	public void OnPointerUp(EToggleState _)
	{
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		this.RemovePointerDownTimer();
		this.ItemGridItem.SetCanOpenTips(backpackLogicState != EHonamiStoryBackpackLogicState.Dragging && backpackLogicState != EHonamiStoryBackpackLogicState.DraggingPlugins);
		if (this.IsGamepadDragging)
		{
			HonamiStoryGamepadLogicController gamepadLogic = HonamiStoryModel.Instance.GetGamepadLogic();
			if (gamepadLogic != null)
			{
				gamepadLogic.PutDown(this);
			}
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, false);
			this.Panel.OnDragEnd(pointerEventData, this);
			this.IsGamepadDragging = false;
			HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.Normal);
		}
	}

	// Token: 0x0600C52E RID: 50478 RVA: 0x003AA094 File Offset: 0x003A8294
	public bool OnDragBegin(ULGUIPointerEventData eventData)
	{
		this.IsStartDrag = true;
		if (this.TrySellStateDragLogic(true, eventData))
		{
			return false;
		}
		if (this.IsGamepadDragging)
		{
			return false;
		}
		if (!this.IsCanDragState(true))
		{
			return false;
		}
		Vector currentPosition = this.CurrentPosition;
		FVector pointerPosition = eventData.pointerPosition;
		FVectorDouble fvectorDouble = pointerPosition;
		currentPosition.DeepCopy(fvectorDouble);
		double num = Time.Instance.Now - this.LastPointerDownTime;
		if (num >= 500.0)
		{
			this.CloseTipsWhenBeginDrag();
			return false;
		}
		this.RemovePointerDownTimer();
		double angleByVector2D = MathUtils.Instance.GetAngleByVector2D(this.CurrentPosition.SubtractionEqual(this.LastPosition));
		if (Math.Abs(angleByVector2D) < 75.0 || Math.Abs(angleByVector2D) > 105.0)
		{
			this.CloseTipsWhenBeginDrag();
			return false;
		}
		Vector currentPosition2 = this.CurrentPosition;
		pointerPosition = eventData.pointerPosition;
		fvectorDouble = pointerPosition;
		currentPosition2.DeepCopy(fvectorDouble);
		double num2 = Vector.Distance(this.CurrentPosition, this.LastPosition) * 1000.0 / (double)((float)num);
		if ((double)this.ScreenHeight / num2 > (double)this.DragSpeedThreshold)
		{
			this.CloseTipsWhenBeginDrag();
			return false;
		}
		this.CanDrag = false;
		return true;
	}

	// Token: 0x0600C52F RID: 50479 RVA: 0x003AA1B7 File Offset: 0x003A83B7
	private void RefreshBackpackLogicStateByDrag()
	{
		if (this.GetData().GetItemType() == EHonamiStoryItemType.Plugin)
		{
			HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.DraggingPlugins);
			return;
		}
		HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.Dragging);
	}

	// Token: 0x0600C530 RID: 50480 RVA: 0x003AA1E0 File Offset: 0x003A83E0
	public bool OnDrag(ULGUIPointerEventData eventData)
	{
		if (!this.IsCanDragState(false))
		{
			return true;
		}
		Vector currentPosition = this.CurrentPosition;
		FVector pointerPosition = eventData.pointerPosition;
		FVectorDouble fvectorDouble = pointerPosition;
		currentPosition.DeepCopy(fvectorDouble);
		double num = this.CurrentPosition.X - this.LastPosition.X;
		this.MoveDistanceX += num;
		double num2 = this.CurrentPosition.Y - this.LastPosition.Y;
		this.MoveDistanceY += num2;
		this.LastPosition.DeepCopy(this.CurrentPosition);
		if (!this.IsDragging && Math.Abs(this.MoveDistanceX) + Math.Abs(this.MoveDistanceY) > (double)this.DragDistanceThreshold)
		{
			if (!this.IsGamepadDragging)
			{
				this.RefreshBackpackLogicStateByDrag();
				this.Panel.OnDragBegin(eventData, this);
			}
			this.IsDragging = true;
			return false;
		}
		if (this.IsDragging)
		{
			this.Panel.OnDrag(eventData, this);
			return false;
		}
		return true;
	}

	// Token: 0x0600C531 RID: 50481 RVA: 0x003AA2D8 File Offset: 0x003A84D8
	public bool OnDragEnd(ULGUIPointerEventData eventData)
	{
		this.TrySellStateDragLogic(false, null);
		this.IsStartDrag = false;
		if (!this.IsCanDragState(false))
		{
			return true;
		}
		this.Panel.OnDragEnd(eventData, this);
		AudioSystem.Instance.PostEvent("play_ui_honamistory_backpack_equip");
		HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.Normal);
		this.IsDragging = false;
		this.IsGamepadDragging = false;
		this.IsUseCancel = false;
		return false;
	}

	// Token: 0x0600C532 RID: 50482 RVA: 0x003AA340 File Offset: 0x003A8540
	protected void OnClickedItem()
	{
		if (this.IsDragging || this.OnClickedGridCb == null)
		{
			return;
		}
		FVector uiworldPosition = this.RootItem.GetUIWorldPosition();
		Vector2D arg = new Vector2D((double)uiworldPosition.X, (double)uiworldPosition.Z);
		Vector2D arg2 = new Vector2D((double)this.RootItem.Width, (double)this.RootItem.Height);
		this.OnClickedGridCb(this.ItemGridItem, arg, arg2);
	}

	// Token: 0x0600C533 RID: 50483 RVA: 0x003AA3AF File Offset: 0x003A85AF
	public UUIItem GetBtnItem()
	{
		UUIButtonComponent button = base.GetButton(2);
		if (button == null)
		{
			return null;
		}
		return button.GetRootComponent();
	}

	// Token: 0x04007042 RID: 28738
	public Action<HonamiStoryItemGridItem> OnEnterGridCb;

	// Token: 0x04007043 RID: 28739
	public Action OnExitGridCb;

	// Token: 0x04007044 RID: 28740
	public Action OnDownGridCb;

	// Token: 0x04007045 RID: 28741
	[Nullable(new byte[]
	{
		2,
		2,
		1,
		1
	})]
	public Action<HonamiStoryItemGridItem, Vector2D, Vector2D> OnClickedGridCb;

	// Token: 0x04007046 RID: 28742
	[Nullable(1)]
	protected HonamiStoryBackpackPanelBase Panel;

	// Token: 0x04007047 RID: 28743
	public HonamiStoryItemDataBase Data;

	// Token: 0x04007048 RID: 28744
	private UiPanelBase OverflowItem;

	// Token: 0x04007049 RID: 28745
	private bool CanDrag;

	// Token: 0x0400704A RID: 28746
	private double LastPointerDownTime;

	// Token: 0x0400704B RID: 28747
	private TimerHandle LastPointerTimer;

	// Token: 0x0400704C RID: 28748
	[Nullable(1)]
	private readonly Vector LastPosition = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400704D RID: 28749
	[Nullable(1)]
	private readonly Vector CurrentPosition = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400704E RID: 28750
	[Nullable(1)]
	private readonly Vector LastSellPosition = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400704F RID: 28751
	[Nullable(1)]
	private readonly Vector CurrentSellPosition = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04007050 RID: 28752
	private double MoveDistanceX;

	// Token: 0x04007051 RID: 28753
	private double MoveDistanceY;

	// Token: 0x04007052 RID: 28754
	private float DragDistanceThreshold = 40f;

	// Token: 0x04007053 RID: 28755
	private float ScreenHeight;

	// Token: 0x04007054 RID: 28756
	private bool IsStartDrag;

	// Token: 0x04007055 RID: 28757
	private bool IsDragging;

	// Token: 0x04007056 RID: 28758
	private bool IsGamepadDragging;

	// Token: 0x04007057 RID: 28759
	private bool IsUseCancel;

	// Token: 0x04007058 RID: 28760
	private bool IsForDrag;

	// Token: 0x04007059 RID: 28761
	private float DragSpeedThreshold;

	// Token: 0x0400705A RID: 28762
	private int EmptyPosition;

	// Token: 0x0400705B RID: 28763
	protected HonamiStoryItemGridItem ItemGridItem;

	// Token: 0x0400705C RID: 28764
	[Nullable(1)]
	protected UUISprite SpriteBg;

	// Token: 0x0400705D RID: 28765
	protected HonamiStoryItemSweepItem SweepItem;

	// Token: 0x0400705E RID: 28766
	private const int DRAG_MIN_ANGLE = 75;

	// Token: 0x0400705F RID: 28767
	private const int DRAG_MAX_ANGLE = 105;

	// Token: 0x04007060 RID: 28768
	private const int DARG_MOVE_DISTANCE = 40;

	// Token: 0x04007061 RID: 28769
	private const int POINTER_DOWN_DELAY = 500;

	// Token: 0x020075F4 RID: 30196
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040264C8 RID: 156872
		Self,
		// Token: 0x040264C9 RID: 156873
		SpriteBg,
		// Token: 0x040264CA RID: 156874
		Btn
	}
}
