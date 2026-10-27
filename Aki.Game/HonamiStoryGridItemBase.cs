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

// Token: 0x02001EA7 RID: 7847
[NullableContext(2)]
[Nullable(0)]
public class HonamiStoryGridItemBase : UiPanelBase
{
	// Token: 0x0600F0E4 RID: 61668 RVA: 0x0039D844 File Offset: 0x0039BA44
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

	// Token: 0x170012DB RID: 4827
	// (get) Token: 0x0600F0E5 RID: 61669 RVA: 0x0039D915 File Offset: 0x0039BB15
	private bool NeedItem { get; }

	// Token: 0x0600F0E6 RID: 61670 RVA: 0x0039D920 File Offset: 0x0039BB20
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

	// Token: 0x0600F0E7 RID: 61671 RVA: 0x0039D9E8 File Offset: 0x0039BBE8
	protected override UniTask OnBeforeStartAsync()
	{
		HonamiStoryGridItemBase.<OnBeforeStartAsync>d__38 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<HonamiStoryGridItemBase.<OnBeforeStartAsync>d__38>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F0E8 RID: 61672 RVA: 0x0039DA2C File Offset: 0x0039BC2C
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

	// Token: 0x0600F0E9 RID: 61673 RVA: 0x0039DAF4 File Offset: 0x0039BCF4
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

	// Token: 0x170012DC RID: 4828
	// (get) Token: 0x0600F0EA RID: 61674 RVA: 0x0039DB45 File Offset: 0x0039BD45
	private HonamiStoryItemDataBase ItemData
	{
		get
		{
			return this.Data;
		}
	}

	// Token: 0x0600F0EB RID: 61675 RVA: 0x0039DB4D File Offset: 0x0039BD4D
	[NullableContext(1)]
	public HonamiStoryBackpackPanelBase GetPanel()
	{
		return this.Panel;
	}

	// Token: 0x0600F0EC RID: 61676 RVA: 0x0039DB55 File Offset: 0x0039BD55
	public int GetEmptyPosition()
	{
		return this.EmptyPosition;
	}

	// Token: 0x0600F0ED RID: 61677 RVA: 0x0039DB5D File Offset: 0x0039BD5D
	public HonamiStoryItemGridItem GetItemGridItem()
	{
		return this.ItemGridItem;
	}

	// Token: 0x0600F0EE RID: 61678 RVA: 0x0039DB65 File Offset: 0x0039BD65
	[NullableContext(1)]
	public void RegisterPanel(HonamiStoryBackpackPanelBase panel)
	{
		this.Panel = panel;
	}

	// Token: 0x0600F0EF RID: 61679 RVA: 0x0039DB6E File Offset: 0x0039BD6E
	[NullableContext(1)]
	protected virtual HonamiStoryItemGridItem CreateGridItem([Nullable(2)] HonamiStoryItemDataBase data)
	{
		return new HonamiStoryItemGridItem(data);
	}

	// Token: 0x0600F0F0 RID: 61680 RVA: 0x0039DB78 File Offset: 0x0039BD78
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

	// Token: 0x0600F0F1 RID: 61681 RVA: 0x0039DBCC File Offset: 0x0039BDCC
	protected UniTask InitSweepItem(HonamiStoryItemDataBase data)
	{
		HonamiStoryGridItemBase.<InitSweepItem>d__49 <InitSweepItem>d__;
		<InitSweepItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitSweepItem>d__.<>4__this = this;
		<InitSweepItem>d__.<>1__state = -1;
		<InitSweepItem>d__.<>t__builder.Start<HonamiStoryGridItemBase.<InitSweepItem>d__49>(ref <InitSweepItem>d__);
		return <InitSweepItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600F0F2 RID: 61682 RVA: 0x0039DC10 File Offset: 0x0039BE10
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

	// Token: 0x0600F0F3 RID: 61683 RVA: 0x0039DD3A File Offset: 0x0039BF3A
	public int GetIncId()
	{
		HonamiStoryItemDataBase itemData = this.ItemData;
		if (itemData == null)
		{
			return -1;
		}
		return itemData.GetIncId();
	}

	// Token: 0x0600F0F4 RID: 61684 RVA: 0x0039DD4D File Offset: 0x0039BF4D
	public HonamiStoryItemDataBase GetData()
	{
		return this.Data;
	}

	// Token: 0x0600F0F5 RID: 61685 RVA: 0x0039DD55 File Offset: 0x0039BF55
	public void SetIsForDrag(bool value)
	{
		this.IsForDrag = value;
	}

	// Token: 0x0600F0F6 RID: 61686 RVA: 0x0039DD60 File Offset: 0x0039BF60
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

	// Token: 0x0600F0F7 RID: 61687 RVA: 0x0039DDAB File Offset: 0x0039BFAB
	public void PlayPosChangeSweepAnimation()
	{
		this.PlaySequenceByName("Sweep_In");
	}

	// Token: 0x0600F0F8 RID: 61688 RVA: 0x0039DDB9 File Offset: 0x0039BFB9
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

	// Token: 0x0600F0F9 RID: 61689 RVA: 0x0039DDD7 File Offset: 0x0039BFD7
	protected void ClearSequence()
	{
		HonamiStoryItemSweepItem sweepItem = this.SweepItem;
		if (sweepItem == null)
		{
			return;
		}
		sweepItem.ClearSequence();
	}

	// Token: 0x0600F0FA RID: 61690 RVA: 0x0039DDEC File Offset: 0x0039BFEC
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

	// Token: 0x0600F0FB RID: 61691 RVA: 0x0039DF09 File Offset: 0x0039C109
	private void OnClickedGridButton()
	{
		this.DoClickedGridButton();
	}

	// Token: 0x0600F0FC RID: 61692 RVA: 0x0039DF14 File Offset: 0x0039C114
	protected virtual void OnBtnPointDown()
	{
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		if (backpackLogicState == EHonamiStoryBackpackLogicState.TipsWithPlugins || backpackLogicState == EHonamiStoryBackpackLogicState.Tips)
		{
			HonamiStoryModel.Instance.GetBackpackLogic().CloseTips();
		}
	}

	// Token: 0x0600F0FD RID: 61693 RVA: 0x0039DF43 File Offset: 0x0039C143
	private void OnBtnPointEnter()
	{
		HonamiStoryModel.Instance.GetInteractController().OnHoverItem(true, base.GetButton(2).RootUIComp);
	}

	// Token: 0x0600F0FE RID: 61694 RVA: 0x0039DF66 File Offset: 0x0039C166
	private void OnBtnPointExit()
	{
		HonamiStoryModel.Instance.GetInteractController().OnUnHover();
	}

	// Token: 0x0600F0FF RID: 61695 RVA: 0x0039DF78 File Offset: 0x0039C178
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

	// Token: 0x0600F100 RID: 61696 RVA: 0x0039DFBA File Offset: 0x0039C1BA
	public void CancelItemToggleSelect()
	{
		HonamiStoryItemGridItem itemGridItem = this.ItemGridItem;
		if (itemGridItem == null)
		{
			return;
		}
		itemGridItem.CancelToggleSelect();
	}

	// Token: 0x0600F101 RID: 61697 RVA: 0x0039DFCC File Offset: 0x0039C1CC
	private bool IsCanDragState(bool isBegin)
	{
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		if (isBegin)
		{
			return this.Data != null && (backpackLogicState == EHonamiStoryBackpackLogicState.Normal || backpackLogicState == EHonamiStoryBackpackLogicState.Tips || backpackLogicState == EHonamiStoryBackpackLogicState.TipsWithPlugins);
		}
		return this.CanDrag && (backpackLogicState == EHonamiStoryBackpackLogicState.Normal || backpackLogicState == EHonamiStoryBackpackLogicState.DraggingPlugins || backpackLogicState == EHonamiStoryBackpackLogicState.Dragging);
	}

	// Token: 0x0600F102 RID: 61698 RVA: 0x0039E018 File Offset: 0x0039C218
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

	// Token: 0x0600F103 RID: 61699 RVA: 0x0039E0D8 File Offset: 0x0039C2D8
	private void CloseTipsWhenBeginDrag()
	{
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		if (backpackLogicState != EHonamiStoryBackpackLogicState.Tips && backpackLogicState != EHonamiStoryBackpackLogicState.TipsWithPlugins)
		{
			return;
		}
		HonamiStoryModel.Instance.GetBackpackLogic().CloseTips();
	}

	// Token: 0x0600F104 RID: 61700 RVA: 0x0039E108 File Offset: 0x0039C308
	public void PlayMoveItemSeq()
	{
		if (!this.IsForDrag)
		{
			return;
		}
		this.ItemGridItem.PlayMoveItemSeq();
	}

	// Token: 0x0600F105 RID: 61701 RVA: 0x0039E11E File Offset: 0x0039C31E
	private void RemovePointerDownTimer()
	{
		if (this.LastPointerTimer != null && this.LastPointerTimer.Valid())
		{
			TimerSystem.GameplayTimeInstance.Remove(this.LastPointerTimer);
		}
		this.LastPointerTimer = null;
	}

	// Token: 0x0600F106 RID: 61702 RVA: 0x0039E14D File Offset: 0x0039C34D
	public void MarkUseCancel()
	{
		this.IsUseCancel = true;
	}

	// Token: 0x0600F107 RID: 61703 RVA: 0x0039E156 File Offset: 0x0039C356
	public bool GetIsUseCancel()
	{
		return this.IsUseCancel;
	}

	// Token: 0x0600F108 RID: 61704 RVA: 0x0039E15E File Offset: 0x0039C35E
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

	// Token: 0x0600F109 RID: 61705 RVA: 0x0039E184 File Offset: 0x0039C384
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

	// Token: 0x0600F10A RID: 61706 RVA: 0x0039E254 File Offset: 0x0039C454
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

	// Token: 0x0600F10B RID: 61707 RVA: 0x0039E2BA File Offset: 0x0039C4BA
	public void OnPointerExit(EToggleState _)
	{
		if (this.IsDragging || this.OnExitGridCb == null)
		{
			return;
		}
		this.OnExitGridCb();
		HonamiStoryModel.Instance.GetInteractController().OnUnHover();
	}

	// Token: 0x0600F10C RID: 61708 RVA: 0x0039E2E8 File Offset: 0x0039C4E8
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

	// Token: 0x0600F10D RID: 61709 RVA: 0x0039E445 File Offset: 0x0039C645
	public void OnPointerCancel(EToggleState _)
	{
		if (this.IsStartDrag)
		{
			return;
		}
		this.OnPointerUp(EToggleState.ETT_UnChecked);
	}

	// Token: 0x0600F10E RID: 61710 RVA: 0x0039E458 File Offset: 0x0039C658
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

	// Token: 0x0600F10F RID: 61711 RVA: 0x0039E4D8 File Offset: 0x0039C6D8
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

	// Token: 0x0600F110 RID: 61712 RVA: 0x0039E5FB File Offset: 0x0039C7FB
	private void RefreshBackpackLogicStateByDrag()
	{
		if (this.GetData().GetItemType() == EHonamiStoryItemType.Plugin)
		{
			HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.DraggingPlugins);
			return;
		}
		HonamiStoryModel.Instance.SetBackpackLogicState(EHonamiStoryBackpackLogicState.Dragging);
	}

	// Token: 0x0600F111 RID: 61713 RVA: 0x0039E624 File Offset: 0x0039C824
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

	// Token: 0x0600F112 RID: 61714 RVA: 0x0039E71C File Offset: 0x0039C91C
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

	// Token: 0x0600F113 RID: 61715 RVA: 0x0039E784 File Offset: 0x0039C984
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

	// Token: 0x0600F114 RID: 61716 RVA: 0x0039E7F3 File Offset: 0x0039C9F3
	public UUIItem GetBtnItem()
	{
		UUIButtonComponent button = base.GetButton(2);
		if (button == null)
		{
			return null;
		}
		return button.GetRootComponent();
	}

	// Token: 0x04006F61 RID: 28513
	public Action<HonamiStoryItemGridItem> OnEnterGridCb;

	// Token: 0x04006F62 RID: 28514
	public Action OnExitGridCb;

	// Token: 0x04006F63 RID: 28515
	public Action OnDownGridCb;

	// Token: 0x04006F64 RID: 28516
	[Nullable(new byte[]
	{
		2,
		2,
		1,
		1
	})]
	public Action<HonamiStoryItemGridItem, Vector2D, Vector2D> OnClickedGridCb;

	// Token: 0x04006F65 RID: 28517
	[Nullable(1)]
	protected HonamiStoryBackpackPanelBase Panel;

	// Token: 0x04006F66 RID: 28518
	public HonamiStoryItemDataBase Data;

	// Token: 0x04006F67 RID: 28519
	private UiPanelBase OverflowItem;

	// Token: 0x04006F68 RID: 28520
	private bool CanDrag;

	// Token: 0x04006F69 RID: 28521
	private double LastPointerDownTime;

	// Token: 0x04006F6A RID: 28522
	private TimerHandle LastPointerTimer;

	// Token: 0x04006F6B RID: 28523
	[Nullable(1)]
	private readonly Vector LastPosition = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04006F6C RID: 28524
	[Nullable(1)]
	private readonly Vector CurrentPosition = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04006F6D RID: 28525
	[Nullable(1)]
	private readonly Vector LastSellPosition = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04006F6E RID: 28526
	[Nullable(1)]
	private readonly Vector CurrentSellPosition = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x04006F6F RID: 28527
	private double MoveDistanceX;

	// Token: 0x04006F70 RID: 28528
	private double MoveDistanceY;

	// Token: 0x04006F71 RID: 28529
	private float DragDistanceThreshold = 40f;

	// Token: 0x04006F72 RID: 28530
	private float ScreenHeight;

	// Token: 0x04006F73 RID: 28531
	private bool IsStartDrag;

	// Token: 0x04006F74 RID: 28532
	private bool IsDragging;

	// Token: 0x04006F75 RID: 28533
	private bool IsGamepadDragging;

	// Token: 0x04006F76 RID: 28534
	private bool IsUseCancel;

	// Token: 0x04006F77 RID: 28535
	private bool IsForDrag;

	// Token: 0x04006F78 RID: 28536
	private float DragSpeedThreshold;

	// Token: 0x04006F79 RID: 28537
	private int EmptyPosition;

	// Token: 0x04006F7A RID: 28538
	protected HonamiStoryItemGridItem ItemGridItem;

	// Token: 0x04006F7B RID: 28539
	[Nullable(1)]
	protected UUISprite SpriteBg;

	// Token: 0x04006F7C RID: 28540
	protected HonamiStoryItemSweepItem SweepItem;

	// Token: 0x04006F7D RID: 28541
	private const int DRAG_MIN_ANGLE = 75;

	// Token: 0x04006F7E RID: 28542
	private const int DRAG_MAX_ANGLE = 105;

	// Token: 0x04006F7F RID: 28543
	private const int DARG_MOVE_DISTANCE = 40;

	// Token: 0x04006F80 RID: 28544
	private const int POINTER_DOWN_DELAY = 500;

	// Token: 0x0200846F RID: 33903
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B1A4 RID: 176548
		Self,
		// Token: 0x0402B1A5 RID: 176549
		SpriteBg,
		// Token: 0x0402B1A6 RID: 176550
		Btn
	}
}
