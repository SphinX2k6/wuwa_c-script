using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200134F RID: 4943
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryBackpackPanel : HonamiStoryBackpackPanelBase
{
	// Token: 0x0600C350 RID: 50000 RVA: 0x0039E238 File Offset: 0x0039C438
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUISprite)),
			new ValueTuple<int, Type>(6, typeof(UUISprite)),
			new ValueTuple<int, Type>(7, typeof(UUISprite)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIItem)),
			new ValueTuple<int, Type>(15, typeof(UUIItem))
		};
	}

	// Token: 0x0600C351 RID: 50001 RVA: 0x0039E3B8 File Offset: 0x0039C5B8
	protected override void OnStart()
	{
		this.ScrollSpeed = HonamiStoryConfig.Instance.GetScrollingSpeed();
		this.ScrollView = base.GetScrollViewWithScrollbar(2);
		this.ViewportItem = base.GetItem(3);
		this.ViewportHeight = this.ViewportItem.GetHeight();
		this.ContentItem = base.GetItem(4);
		base.GetSprite(5).SetUIActive(false);
		base.GetSprite(5).SetHierarchyIndex(99);
		base.GetSprite(6).SetUIActive(false);
		base.GetSprite(6).SetHierarchyIndex(100);
		this.RefreshScrollMoveState(null);
	}

	// Token: 0x0600C352 RID: 50002 RVA: 0x0039E44A File Offset: 0x0039C64A
	protected override void OnBeforeShow()
	{
		this.AddEventListener();
	}

	// Token: 0x0600C353 RID: 50003 RVA: 0x0039E454 File Offset: 0x0039C654
	private void AddEventListener()
	{
		this.ScrollView.OnScrollValueChange.Bind(new Action<FVector2D>(this.OnScrollValueChange));
		EventSystem.Instance.Add<HonamiStoryBagUpdateContext>(EEventName.OnHonamiStoryBackpackUpdate, new Action<HonamiStoryBagUpdateContext>(this.OnHonamiStoryBackpackUpdate));
		EventSystem.Instance.Add(EEventName.OnHonamiStorySortSuccess, new Action(this.OnSortSuccess));
	}

	// Token: 0x0600C354 RID: 50004 RVA: 0x0039E4B8 File Offset: 0x0039C6B8
	public UniTask Init(HonamiStoryBackpackData backpackData)
	{
		HonamiStoryBackpackPanel.<Init>d__29 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.backpackData = backpackData;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<HonamiStoryBackpackPanel.<Init>d__29>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600C355 RID: 50005 RVA: 0x0039E504 File Offset: 0x0039C704
	private UniTask InitBottomButton()
	{
		HonamiStoryBackpackPanel.<InitBottomButton>d__30 <InitBottomButton>d__;
		<InitBottomButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBottomButton>d__.<>4__this = this;
		<InitBottomButton>d__.<>1__state = -1;
		<InitBottomButton>d__.<>t__builder.Start<HonamiStoryBackpackPanel.<InitBottomButton>d__30>(ref <InitBottomButton>d__);
		return <InitBottomButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600C356 RID: 50006 RVA: 0x0039E548 File Offset: 0x0039C748
	private UniTask UpdateViewportItems()
	{
		HonamiStoryBackpackPanel.<UpdateViewportItems>d__31 <UpdateViewportItems>d__;
		<UpdateViewportItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateViewportItems>d__.<>4__this = this;
		<UpdateViewportItems>d__.<>1__state = -1;
		<UpdateViewportItems>d__.<>t__builder.Start<HonamiStoryBackpackPanel.<UpdateViewportItems>d__31>(ref <UpdateViewportItems>d__);
		return <UpdateViewportItems>d__.<>t__builder.Task;
	}

	// Token: 0x0600C357 RID: 50007 RVA: 0x0039E58C File Offset: 0x0039C78C
	protected HashSet<int> GetAvailableGrid(int start, int end)
	{
		HashSet<int> hashSet = new HashSet<int>();
		HashSet<HonamiStoryItemDataBase> hashSet2 = new HashSet<HonamiStoryItemDataBase>();
		for (int i = start; i <= end; i++)
		{
			HonamiStoryItemDataBase itemDataByPosition = this.BackpackData.GetItemDataByPosition(i);
			if (itemDataByPosition == null)
			{
				hashSet.Add(i);
			}
			else if (!hashSet2.Contains(itemDataByPosition))
			{
				hashSet2.Add(itemDataByPosition);
				hashSet.Add(i);
			}
		}
		return hashSet;
	}

	// Token: 0x0600C358 RID: 50008 RVA: 0x0039E5E8 File Offset: 0x0039C7E8
	private UniTask UpdateWhenOverflowChange(int changeNum)
	{
		HonamiStoryBackpackPanel.<UpdateWhenOverflowChange>d__33 <UpdateWhenOverflowChange>d__;
		<UpdateWhenOverflowChange>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateWhenOverflowChange>d__.<>4__this = this;
		<UpdateWhenOverflowChange>d__.<>1__state = -1;
		<UpdateWhenOverflowChange>d__.<>t__builder.Start<HonamiStoryBackpackPanel.<UpdateWhenOverflowChange>d__33>(ref <UpdateWhenOverflowChange>d__);
		return <UpdateWhenOverflowChange>d__.<>t__builder.Task;
	}

	// Token: 0x0600C359 RID: 50009 RVA: 0x0039E62C File Offset: 0x0039C82C
	[NullableContext(2)]
	private void RefreshMask(HonamiStoryItemDataBase itemData)
	{
		if (itemData == null)
		{
			base.GetSprite(5).SetUIActive(false);
			return;
		}
		UUISprite sprite = base.GetSprite(5);
		if (sprite != null)
		{
			sprite.SetUIActive(true);
		}
		int num = this.BackpackData.GetCellWidth() + this.BackpackData.GetCellHorizontalInterval();
		int num2 = this.BackpackData.GetCellHeight() + this.BackpackData.GetCellVerticalInterval();
		sprite.SetWidth((float)(num * itemData.GetGridWidth()));
		sprite.SetHeight((float)(num2 * itemData.GetGridHeight()));
		this.SetItemOffset(sprite, itemData.GetPosition());
	}

	// Token: 0x0600C35A RID: 50010 RVA: 0x0039E6B8 File Offset: 0x0039C8B8
	[NullableContext(2)]
	private void RefreshHoverTip(IHonamiStoryDragItemHoverInfo hoverInfo)
	{
		if (hoverInfo == null)
		{
			base.GetSprite(6).SetUIActive(false);
			return;
		}
		UUISprite sprite = base.GetSprite(6);
		sprite.SetUIActive(true);
		int num = this.BackpackData.GetCellWidth() + this.BackpackData.GetCellHorizontalInterval();
		int num2 = this.BackpackData.GetCellHeight() + this.BackpackData.GetCellVerticalInterval();
		sprite.SetWidth((float)(num * hoverInfo.Width));
		sprite.SetHeight((float)(num2 * hoverInfo.Height));
		UUIItem uuiitem = sprite;
		bool isValid = hoverInfo.IsValid;
		FColor? fcolor = new FColor?(sprite.changeColor);
		uuiitem.SetChangeColor(isValid, fcolor);
		this.SetItemOffset(sprite, hoverInfo.StartPosition);
	}

	// Token: 0x0600C35B RID: 50011 RVA: 0x0039E75C File Offset: 0x0039C95C
	private UniTask CreateHonamiStoryGridItem(int position)
	{
		HonamiStoryBackpackPanel.<CreateHonamiStoryGridItem>d__36 <CreateHonamiStoryGridItem>d__;
		<CreateHonamiStoryGridItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateHonamiStoryGridItem>d__.<>4__this = this;
		<CreateHonamiStoryGridItem>d__.position = position;
		<CreateHonamiStoryGridItem>d__.<>1__state = -1;
		<CreateHonamiStoryGridItem>d__.<>t__builder.Start<HonamiStoryBackpackPanel.<CreateHonamiStoryGridItem>d__36>(ref <CreateHonamiStoryGridItem>d__);
		return <CreateHonamiStoryGridItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C35C RID: 50012 RVA: 0x0039E7A8 File Offset: 0x0039C9A8
	private UniTask CreateEmptyGridItem(int position)
	{
		HonamiStoryBackpackPanel.<CreateEmptyGridItem>d__37 <CreateEmptyGridItem>d__;
		<CreateEmptyGridItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateEmptyGridItem>d__.<>4__this = this;
		<CreateEmptyGridItem>d__.position = position;
		<CreateEmptyGridItem>d__.<>1__state = -1;
		<CreateEmptyGridItem>d__.<>t__builder.Start<HonamiStoryBackpackPanel.<CreateEmptyGridItem>d__37>(ref <CreateEmptyGridItem>d__);
		return <CreateEmptyGridItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C35D RID: 50013 RVA: 0x0039E7F4 File Offset: 0x0039C9F4
	private void SetItemOffset(UUIItem item, int position)
	{
		int num = position / this.BackpackData.GetWidthCount();
		int num2 = position % this.BackpackData.GetWidthCount();
		int num3 = num2 * this.BackpackData.GetCellWidth() + (num2 + 1) * this.BackpackData.GetCellHorizontalInterval();
		int num4 = -num * this.BackpackData.GetCellHeight() - (num + 1) * this.BackpackData.GetCellVerticalInterval();
		item.SetAnchorOffsetX((float)num3);
		item.SetAnchorOffsetY((float)num4);
	}

	// Token: 0x0600C35E RID: 50014 RVA: 0x0039E86C File Offset: 0x0039CA6C
	private UniTask FillBackpackItemMap(HonamiStoryItemDataBase itemData, HonamiStoryGridItemBase item)
	{
		HonamiStoryBackpackPanel.<FillBackpackItemMap>d__39 <FillBackpackItemMap>d__;
		<FillBackpackItemMap>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FillBackpackItemMap>d__.<>4__this = this;
		<FillBackpackItemMap>d__.itemData = itemData;
		<FillBackpackItemMap>d__.item = item;
		<FillBackpackItemMap>d__.<>1__state = -1;
		<FillBackpackItemMap>d__.<>t__builder.Start<HonamiStoryBackpackPanel.<FillBackpackItemMap>d__39>(ref <FillBackpackItemMap>d__);
		return <FillBackpackItemMap>d__.<>t__builder.Task;
	}

	// Token: 0x0600C35F RID: 50015 RVA: 0x0039E8C0 File Offset: 0x0039CAC0
	private UniTask RecycleGridItem(int position)
	{
		HonamiStoryBackpackPanel.<RecycleGridItem>d__40 <RecycleGridItem>d__;
		<RecycleGridItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RecycleGridItem>d__.<>4__this = this;
		<RecycleGridItem>d__.position = position;
		<RecycleGridItem>d__.<>1__state = -1;
		<RecycleGridItem>d__.<>t__builder.Start<HonamiStoryBackpackPanel.<RecycleGridItem>d__40>(ref <RecycleGridItem>d__);
		return <RecycleGridItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C360 RID: 50016 RVA: 0x0039E90C File Offset: 0x0039CB0C
	private UniTask RecycleChangeGridItem(int position)
	{
		HonamiStoryBackpackPanel.<RecycleChangeGridItem>d__41 <RecycleChangeGridItem>d__;
		<RecycleChangeGridItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RecycleChangeGridItem>d__.<>4__this = this;
		<RecycleChangeGridItem>d__.position = position;
		<RecycleChangeGridItem>d__.<>1__state = -1;
		<RecycleChangeGridItem>d__.<>t__builder.Start<HonamiStoryBackpackPanel.<RecycleChangeGridItem>d__41>(ref <RecycleChangeGridItem>d__);
		return <RecycleChangeGridItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C361 RID: 50017 RVA: 0x0039E958 File Offset: 0x0039CB58
	private UniTask RecycleEmptyGridItem(int position)
	{
		HonamiStoryBackpackPanel.<RecycleEmptyGridItem>d__42 <RecycleEmptyGridItem>d__;
		<RecycleEmptyGridItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RecycleEmptyGridItem>d__.<>4__this = this;
		<RecycleEmptyGridItem>d__.position = position;
		<RecycleEmptyGridItem>d__.<>1__state = -1;
		<RecycleEmptyGridItem>d__.<>t__builder.Start<HonamiStoryBackpackPanel.<RecycleEmptyGridItem>d__42>(ref <RecycleEmptyGridItem>d__);
		return <RecycleEmptyGridItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C362 RID: 50018 RVA: 0x0039E9A4 File Offset: 0x0039CBA4
	private UniTask RefreshBackpackContextUpdate(HonamiStoryBagUpdateContext updateContext)
	{
		HonamiStoryBackpackPanel.<RefreshBackpackContextUpdate>d__43 <RefreshBackpackContextUpdate>d__;
		<RefreshBackpackContextUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshBackpackContextUpdate>d__.<>4__this = this;
		<RefreshBackpackContextUpdate>d__.updateContext = updateContext;
		<RefreshBackpackContextUpdate>d__.<>1__state = -1;
		<RefreshBackpackContextUpdate>d__.<>t__builder.Start<HonamiStoryBackpackPanel.<RefreshBackpackContextUpdate>d__43>(ref <RefreshBackpackContextUpdate>d__);
		return <RefreshBackpackContextUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x0600C363 RID: 50019 RVA: 0x0039E9F0 File Offset: 0x0039CBF0
	private UniTask FillEmptyGridInViewport()
	{
		HonamiStoryBackpackPanel.<FillEmptyGridInViewport>d__44 <FillEmptyGridInViewport>d__;
		<FillEmptyGridInViewport>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FillEmptyGridInViewport>d__.<>4__this = this;
		<FillEmptyGridInViewport>d__.<>1__state = -1;
		<FillEmptyGridInViewport>d__.<>t__builder.Start<HonamiStoryBackpackPanel.<FillEmptyGridInViewport>d__44>(ref <FillEmptyGridInViewport>d__);
		return <FillEmptyGridInViewport>d__.<>t__builder.Task;
	}

	// Token: 0x0600C364 RID: 50020 RVA: 0x0039EA34 File Offset: 0x0039CC34
	private bool CheckItemInViewport(HonamiStoryGridItemBase item)
	{
		HonamiStoryItemDataBase data = item.GetData();
		return data != null && this.CheckItemDataInViewport(data);
	}

	// Token: 0x0600C365 RID: 50021 RVA: 0x0039EA54 File Offset: 0x0039CC54
	private bool CheckItemDataInViewport(HonamiStoryItemDataBase itemData)
	{
		List<int> gridFillPositionList = itemData.GetGridFillPositionList();
		bool result = false;
		foreach (int position in gridFillPositionList)
		{
			if (this.CheckPositionInViewport(position))
			{
				result = true;
				break;
			}
		}
		return result;
	}

	// Token: 0x0600C366 RID: 50022 RVA: 0x0039EAB0 File Offset: 0x0039CCB0
	private bool CheckPositionInViewport(int position)
	{
		return position >= this.CurViewportStartPosition && position <= this.CurViewportEndPosition;
	}

	// Token: 0x0600C367 RID: 50023 RVA: 0x0039EAC7 File Offset: 0x0039CCC7
	protected override void OnBeforeHide()
	{
		this.RemoveEventListener();
	}

	// Token: 0x0600C368 RID: 50024 RVA: 0x0039EAD0 File Offset: 0x0039CCD0
	private void RemoveEventListener()
	{
		this.ScrollView.OnScrollValueChange.Unbind();
		EventSystem.Instance.Remove<HonamiStoryBagUpdateContext>(EEventName.OnHonamiStoryBackpackUpdate, new Action<HonamiStoryBagUpdateContext>(this.OnHonamiStoryBackpackUpdate));
		EventSystem.Instance.Remove(EEventName.OnHonamiStorySortSuccess, new Action(this.OnSortSuccess));
	}

	// Token: 0x0600C369 RID: 50025 RVA: 0x0039EB28 File Offset: 0x0039CD28
	[NullableContext(2)]
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<HonamiStoryGridItemBase> GetHonamiStoryGridItem(bool needItem = false, HonamiStoryItemDataBase itemData = null)
	{
		HonamiStoryBackpackPanel.<GetHonamiStoryGridItem>d__50 <GetHonamiStoryGridItem>d__;
		<GetHonamiStoryGridItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<HonamiStoryGridItemBase>.Create();
		<GetHonamiStoryGridItem>d__.<>4__this = this;
		<GetHonamiStoryGridItem>d__.needItem = needItem;
		<GetHonamiStoryGridItem>d__.itemData = itemData;
		<GetHonamiStoryGridItem>d__.<>1__state = -1;
		<GetHonamiStoryGridItem>d__.<>t__builder.Start<HonamiStoryBackpackPanel.<GetHonamiStoryGridItem>d__50>(ref <GetHonamiStoryGridItem>d__);
		return <GetHonamiStoryGridItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C36A RID: 50026 RVA: 0x0039EB7B File Offset: 0x0039CD7B
	private void OnScrollValueChange(FVector2D inVector)
	{
		HonamiStoryModel.Instance.GetInteractController().RefreshSelectedUiItem();
		this.UpdateViewportItems();
	}

	// Token: 0x0600C36B RID: 50027 RVA: 0x0039EB93 File Offset: 0x0039CD93
	public override int GetBackpackType()
	{
		return (int)this.BackpackData.BackpackType;
	}

	// Token: 0x0600C36C RID: 50028 RVA: 0x0039EBA0 File Offset: 0x0039CDA0
	public override void OnHover(ULGUIPointerEventData eventData, HonamiStoryInteractOperateAgent operateAgent)
	{
		int dragItemPositionInContent = this.GetDragItemPositionInContent(eventData);
		this.RefreshScrollMoveState(eventData);
		if (dragItemPositionInContent == -1)
		{
			return;
		}
		if (this.HoverPosition == dragItemPositionInContent)
		{
			return;
		}
		if (operateAgent.OperateData == null)
		{
			return;
		}
		this.DragItemHoverInfo = this.GetDragItemHoverInfo(operateAgent, dragItemPositionInContent);
		this.HoverPosition = dragItemPositionInContent;
		this.RefreshHoverTip(this.DragItemHoverInfo);
	}

	// Token: 0x0600C36D RID: 50029 RVA: 0x0039EBF5 File Offset: 0x0039CDF5
	public override void OnHoverEnd()
	{
		this.HoverPosition = -1;
		this.DragItemHoverInfo = null;
		this.RefreshScrollMoveState(null);
		this.RefreshHoverTip(null);
	}

	// Token: 0x0600C36E RID: 50030 RVA: 0x0039EC13 File Offset: 0x0039CE13
	public override bool OnDragBegin([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		HonamiStoryItemDataBase data = item.GetData();
		this.CurMaskingItemIncId = ((data != null) ? data.GetIncId() : -1);
		this.RefreshMask(item.GetData());
		this.RefreshScrollMoveState(null);
		return base.OnDragBegin(eventData, item);
	}

	// Token: 0x0600C36F RID: 50031 RVA: 0x0039EC48 File Offset: 0x0039CE48
	public override bool OnDrag([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		int curMaskingItemIncId = this.CurMaskingItemIncId;
		HonamiStoryItemDataBase data = item.GetData();
		if (curMaskingItemIncId == ((data != null) ? data.GetIncId() : -1))
		{
			this.RefreshMask(item.GetData());
		}
		else
		{
			this.RefreshMask(null);
		}
		return base.OnDrag(eventData, item);
	}

	// Token: 0x0600C370 RID: 50032 RVA: 0x0039EC81 File Offset: 0x0039CE81
	public override void OnDragEnd([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.CurMaskingItemIncId = -1;
		this.RefreshMask(null);
		base.OnDragEnd(eventData, item);
		this.RefreshScrollMoveState(null);
	}

	// Token: 0x0600C371 RID: 50033 RVA: 0x0039ECA0 File Offset: 0x0039CEA0
	public int GetDragItemPositionInContent(ULGUIPointerEventData eventData)
	{
		FVector offsetVector = HonamiStoryUtil.GetOffsetVector(eventData.GetWorldPointInPlane());
		FVector uiworldPosition = this.ContentItem.GetUIWorldPosition();
		float num = uiworldPosition.X - this.ContentItem.GetWidth() / 2f;
		float num2 = num + this.ContentItem.GetWidth();
		float num3 = uiworldPosition.Z - this.ContentItem.GetHeight() / 2f;
		float num4 = num3 + this.ContentItem.GetHeight();
		if (offsetVector.X < num || offsetVector.X > num2 || offsetVector.Z < num3 || offsetVector.Z > num4)
		{
			return -1;
		}
		double num5 = (double)(offsetVector.X - num);
		float num6 = num4 - offsetVector.Z;
		int num7 = this.BackpackData.GetCellWidth() + this.BackpackData.GetCellHorizontalInterval();
		int num8 = this.BackpackData.GetCellHeight() + this.BackpackData.GetCellVerticalInterval();
		int num9 = (int)Math.Floor(num5 / (double)((float)num7));
		return (int)Math.Floor((double)(num6 / (float)num8)) * this.BackpackData.GetWidthCount() + num9;
	}

	// Token: 0x0600C372 RID: 50034 RVA: 0x0039EDA8 File Offset: 0x0039CFA8
	public override bool CheckDragItemInViewport(ULGUIPointerEventData eventData)
	{
		FVector offsetVector = HonamiStoryUtil.GetOffsetVector(eventData.GetWorldPointInPlane());
		FVector uiworldPosition = this.ViewportItem.GetUIWorldPosition();
		float num = uiworldPosition.X - this.ViewportItem.GetWidth() / 2f;
		float num2 = num + this.ViewportItem.GetWidth();
		float num3 = uiworldPosition.Z - this.ViewportItem.GetHeight() / 2f;
		float num4 = num3 + this.ViewportItem.GetHeight();
		return offsetVector.X >= num && offsetVector.X <= num2 && offsetVector.Z >= num3 && offsetVector.Z <= num4;
	}

	// Token: 0x0600C373 RID: 50035 RVA: 0x0039EE44 File Offset: 0x0039D044
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInSameBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase itemData)
	{
		if (this.DragItemHoverInfo == null || !this.DragItemHoverInfo.IsValid)
		{
			return null;
		}
		if (this.DragItemHoverInfo.StartPosition == itemData.GetPosition() && itemData.GetIsCross() == itemData.GetIsDragCross())
		{
			return null;
		}
		HashSet<int> hashSet = new HashSet<int>();
		HonamiStoryBagUpdateContext honamiStoryBagUpdateContext = HonamiStoryBagUpdateContext.Create();
		honamiStoryBagUpdateContext.BackPackConfigId = this.BackpackData.BackpackId;
		HonamiStoryBagUpdateInfo honamiStoryItemSwapInfo = HonamiStoryUtil.GetHonamiStoryItemSwapInfo(itemData, this.DragItemHoverInfo.StartPosition);
		honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemSwapInfo);
		hashSet.Add(itemData.GetIncId());
		List<int> fillPosList = this.DragItemHoverInfo.FillPosList;
		foreach (int position in fillPosList)
		{
			HonamiStoryItemDataBase itemDataByPosition = this.BackpackData.GetItemDataByPosition(position);
			if (itemDataByPosition != null && !hashSet.Contains(itemDataByPosition.GetIncId()))
			{
				int exchangeItemPosition = this.GetExchangeItemPosition(this.DragItemHoverInfo, itemData.GetPosition(), itemDataByPosition.GetPosition(), itemData, itemDataByPosition);
				List<int> gridFillPositionByPosition = itemDataByPosition.GetGridFillPositionByPosition(exchangeItemPosition, itemDataByPosition.GetIsDragCross());
				bool flag = true;
				foreach (int num in gridFillPositionByPosition)
				{
					if (num >= this.BackpackData.GetCapacity())
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_NoSpaceForQuickAll", Array.Empty<object>());
						return null;
					}
					if (fillPosList.Contains(num))
					{
						Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.WHJ, "SwapInfo Error", default(ReadOnlySpan<ValueTuple<string, object>>));
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					return null;
				}
				hashSet.Add(itemDataByPosition.GetIncId());
				HonamiStoryBagUpdateInfo honamiStoryItemSwapInfo2 = HonamiStoryUtil.GetHonamiStoryItemSwapInfo(itemDataByPosition, exchangeItemPosition);
				honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemSwapInfo2);
			}
		}
		return honamiStoryBagUpdateContext;
	}

	// Token: 0x0600C374 RID: 50036 RVA: 0x0039F058 File Offset: 0x0039D258
	private int GetExchangeItemPosition(IHonamiStoryDragItemHoverInfo hoverInfo, int itemPosition, int position, HonamiStoryItemDataBase oriItemData, HonamiStoryItemDataBase otherData)
	{
		if (oriItemData.GetIsCross() == oriItemData.GetIsDragCross())
		{
			return this.GetExchangeItemPositionNoCrossChange(hoverInfo, itemPosition, position, otherData);
		}
		return this.GetExchangeItemPositionCrossChange(hoverInfo, itemPosition, position, oriItemData, otherData);
	}

	// Token: 0x0600C375 RID: 50037 RVA: 0x0039F084 File Offset: 0x0039D284
	private int GetExchangeItemPositionNoCrossChange(IHonamiStoryDragItemHoverInfo hoverInfo, int itemPosition, int position, HonamiStoryItemDataBase otherData)
	{
		int startPosition = hoverInfo.StartPosition;
		int widthCount = this.BackpackData.GetWidthCount();
		int num = startPosition / widthCount;
		int num2 = startPosition % widthCount;
		int num3 = itemPosition / widthCount;
		int num4 = itemPosition % widthCount;
		int num5 = num2 - num4;
		int num6 = num - num3;
		if (Math.Abs(num5) >= hoverInfo.Width || Math.Abs(num6) >= hoverInfo.Height)
		{
			return itemPosition - startPosition + position;
		}
		if (num5 == 0 && num6 == 0)
		{
			return 0;
		}
		if (num5 == 0 || num6 == 0)
		{
			int num7 = (num5 == 0) ? 0 : ((num5 > 0) ? 1 : -1);
			object obj = (num6 == 0) ? 0 : ((num6 > 0) ? 1 : -1);
			int num8 = -num7;
			object obj2 = obj;
			int num9 = -obj2;
			int num10 = Math.Abs(num7) * hoverInfo.Width;
			int num11 = Math.Abs(obj2) * hoverInfo.Height;
			int num12 = num9 * num11;
			int num13 = num8 * num10;
			return num12 * widthCount + num13 + position;
		}
		return itemPosition + hoverInfo.EndPosition - position + 1 - otherData.GetGridWidth() - (otherData.GetGridHeight() - 1) * this.BackpackData.GetWidthCount();
	}

	// Token: 0x0600C376 RID: 50038 RVA: 0x0039F17C File Offset: 0x0039D37C
	private int GetExchangeItemPositionCrossChange(IHonamiStoryDragItemHoverInfo hoverInfo, int itemPosition, int position, HonamiStoryItemDataBase oriItemData, HonamiStoryItemDataBase otherData)
	{
		if (otherData.GetGridWidth() != otherData.GetGridHeight())
		{
			otherData.SetIsDragCross(!otherData.GetIsCross());
		}
		List<int> gridFillPositionByPosition = oriItemData.GetGridFillPositionByPosition(itemPosition, oriItemData.GetIsCross());
		List<int> gridFillPositionByPosition2 = oriItemData.GetGridFillPositionByPosition(hoverInfo.StartPosition, oriItemData.GetIsDragCross());
		int num = 0;
		while (num < gridFillPositionByPosition2.Count && gridFillPositionByPosition2[num] != position)
		{
			num++;
		}
		int transPosIndex = oriItemData.GetTransPosIndex(num);
		return gridFillPositionByPosition[transPosIndex];
	}

	// Token: 0x0600C377 RID: 50039 RVA: 0x0039F1FC File Offset: 0x0039D3FC
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInSendBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateData, HashSet<HonamiStoryItemDataBase> exchangeItemSet)
	{
		HashSet<int> hashSet = new HashSet<int>();
		foreach (int item in operateData.GetGridFillPositionList())
		{
			hashSet.Add(item);
		}
		foreach (int item2 in this.BackpackData.GetEmptyGridSet())
		{
			hashSet.Add(item2);
		}
		List<int> list = new List<int>();
		List<HonamiStoryItemDataBase> list2 = new List<HonamiStoryItemDataBase>(exchangeItemSet);
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in list2)
		{
			if (honamiStoryItemDataBase != null)
			{
				IHonamiStoryAvailablePosInfo honamiStoryAvailablePosInfo = HonamiStoryUtil.FindAvailablePosition(hashSet, honamiStoryItemDataBase, this.BackpackData.GetWidthCount(), false, null);
				if (honamiStoryAvailablePosInfo.Position == -1)
				{
					return null;
				}
				List<int> gridFillPositionByPosition = honamiStoryItemDataBase.GetGridFillPositionByPosition(honamiStoryAvailablePosInfo.Position, honamiStoryAvailablePosInfo.IsCross);
				honamiStoryItemDataBase.SetIsDragCross(honamiStoryAvailablePosInfo.IsCross);
				HonamiStoryUtil.RemoveEmptyGridPosition(hashSet, gridFillPositionByPosition.ToArray());
				list.Add(honamiStoryAvailablePosInfo.Position);
			}
		}
		HonamiStoryBagUpdateContext honamiStoryBagUpdateContext = HonamiStoryBagUpdateContext.Create();
		honamiStoryBagUpdateContext.BackPackConfigId = this.BackpackData.BackpackId;
		HonamiStoryBagUpdateInfo honamiStoryItemRemoveInfo = HonamiStoryUtil.GetHonamiStoryItemRemoveInfo(operateData);
		honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemRemoveInfo);
		for (int i = 0; i < list2.Count; i++)
		{
			HonamiStoryBagUpdateInfo honamiStoryItemAddInfo = HonamiStoryUtil.GetHonamiStoryItemAddInfo(list2[i], list[i]);
			honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemAddInfo);
		}
		return honamiStoryBagUpdateContext;
	}

	// Token: 0x0600C378 RID: 50040 RVA: 0x0039F3C0 File Offset: 0x0039D5C0
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInReceiveBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateData, HashSet<HonamiStoryItemDataBase> exchangeItemSet)
	{
		if (this.DragItemHoverInfo == null || !this.DragItemHoverInfo.IsValid)
		{
			return null;
		}
		HonamiStoryBagUpdateContext honamiStoryBagUpdateContext = HonamiStoryBagUpdateContext.Create();
		honamiStoryBagUpdateContext.BackPackConfigId = this.BackpackData.BackpackId;
		HonamiStoryBagUpdateInfo honamiStoryItemAddInfo = HonamiStoryUtil.GetHonamiStoryItemAddInfo(operateData, this.DragItemHoverInfo.StartPosition);
		honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemAddInfo);
		foreach (HonamiStoryItemDataBase itemData in exchangeItemSet)
		{
			HonamiStoryBagUpdateInfo honamiStoryItemRemoveInfo = HonamiStoryUtil.GetHonamiStoryItemRemoveInfo(itemData);
			honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemRemoveInfo);
		}
		return honamiStoryBagUpdateContext;
	}

	// Token: 0x0600C379 RID: 50041 RVA: 0x0039F468 File Offset: 0x0039D668
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override HashSet<HonamiStoryItemDataBase> GetExchangeItemSet(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateItem)
	{
		if (this.DragItemHoverInfo == null || !this.DragItemHoverInfo.IsValid)
		{
			return null;
		}
		HashSet<HonamiStoryItemDataBase> hashSet = new HashSet<HonamiStoryItemDataBase>();
		foreach (int key in this.DragItemHoverInfo.FillPosList)
		{
			HonamiStoryGridItemBase honamiStoryGridItemBase;
			if (this.BackpackItemMap.TryGetValue(key, out honamiStoryGridItemBase) && honamiStoryGridItemBase != null)
			{
				HonamiStoryItemDataBase data = honamiStoryGridItemBase.GetData();
				if (data != null && !hashSet.Contains(data))
				{
					hashSet.Add(data);
				}
			}
		}
		return hashSet;
	}

	// Token: 0x0600C37A RID: 50042 RVA: 0x0039F50C File Offset: 0x0039D70C
	private IHonamiStoryDragItemHoverInfo GetDragItemHoverInfo(HonamiStoryInteractOperateAgent operateAgent, int centerPosition)
	{
		HonamiStoryItemDataBase operateData = operateAgent.OperateData;
		int widthCount = this.BackpackData.GetWidthCount();
		bool needOverflow = this.BackpackData.BackpackType == EHonamiStoryBackpackType.Inventory;
		int heightCount = this.BackpackData.GetHeightCount(needOverflow);
		int num = centerPosition % widthCount;
		int num2 = centerPosition / widthCount;
		bool flag = operateData.GetBaseGridWidth(false) == operateData.GetBaseGridHeight(false);
		int num3 = operateData.GetBaseGridWidth(false) / 2;
		int num4 = operateData.GetBaseGridHeight(false) / 2;
		int num5 = num - num3;
		int startRow = num2 - num4;
		ValueTuple<List<int>, IHonamiStoryDragItemHoverInfo> valueTuple = this.CreateDragItemHoverInfo(operateData, num5, startRow, widthCount, heightCount, false);
		List<int> item = valueTuple.Item1;
		IHonamiStoryDragItemHoverInfo item2 = valueTuple.Item2;
		int num6 = item[0];
		bool flag2 = item.Count < operateData.GetGridFillPositionList().Count;
		bool flag3 = operateAgent.StartOperateBackpack == operateAgent.TargetOperateBackpack && operateData.GetPosition() == num6 && !operateData.GetIsCross();
		bool flag4 = this.CheckSwapValid(operateData, item, false, null, operateData, false);
		if (flag3 || (!flag2 && flag4 && !flag3))
		{
			item2.IsValid = !flag3;
			this.InteractController.RefreshDragItem(operateAgent, false);
			return item2;
		}
		int num7 = operateData.GetBaseGridWidth(true) / 2;
		int num8 = num5 - 1 + operateData.GetBaseGridWidth(false) - num;
		int startColumn = num - num7;
		int startRow2 = num2 - num8;
		ValueTuple<List<int>, IHonamiStoryDragItemHoverInfo> valueTuple2 = this.CreateDragItemHoverInfo(operateData, startColumn, startRow2, widthCount, heightCount, true);
		List<int> item3 = valueTuple2.Item1;
		IHonamiStoryDragItemHoverInfo item4 = valueTuple2.Item2;
		bool flag5 = this.CheckSwapValid(operateData, item3, false, null, operateData, true);
		bool flag6 = item3.Count < operateData.GetGridFillPositionList().Count;
		int num9 = item3[0];
		bool flag7 = operateAgent.StartOperateBackpack == operateAgent.TargetOperateBackpack && operateData.GetPosition() == num9 && operateData.GetIsCross();
		if (flag7 || (flag5 && !flag6 && !flag7 && !flag))
		{
			item4.IsValid = !flag7;
			this.InteractController.RefreshDragItem(operateAgent, true);
			return item4;
		}
		if (!flag2 && this.CheckSwapValid(operateData, item, true, item2, operateData, false))
		{
			item2.IsValid = true;
			this.InteractController.RefreshDragItem(operateAgent, false);
			return item2;
		}
		if (!flag6 && !flag && this.CheckSwapValid(operateData, item3, true, item4, operateData, true))
		{
			item4.IsValid = true;
			this.InteractController.RefreshDragItem(operateAgent, true);
			return item4;
		}
		this.InteractController.RefreshDragItem(operateAgent, false);
		return item2;
	}

	// Token: 0x0600C37B RID: 50043 RVA: 0x0039F75C File Offset: 0x0039D95C
	[return: Nullable(new byte[]
	{
		0,
		1,
		1
	})]
	private ValueTuple<List<int>, IHonamiStoryDragItemHoverInfo> CreateDragItemHoverInfo(HonamiStoryItemDataBase data, int startColumn, int startRow, int backpackWidth, int backpackHeight, bool isCross)
	{
		int num = 10000;
		int num2 = -1;
		int num3 = 10000;
		int num4 = -1;
		List<int> list = new List<int>();
		for (int i = 0; i < data.GetBaseGridWidth(isCross); i++)
		{
			for (int j = 0; j < data.GetBaseGridHeight(isCross); j++)
			{
				int num5 = i + startColumn;
				int num6 = j + startRow;
				if (num5 >= 0 && num5 < backpackWidth && num6 >= 0 && num6 < backpackHeight)
				{
					int item = num6 * backpackWidth + num5;
					list.Add(item);
					num = Math.Min(num, num6);
					num2 = Math.Max(num2, num6);
					num3 = Math.Min(num3, num5);
					num4 = Math.Max(num4, num5);
				}
			}
		}
		int startPosition = list[0];
		int endPosition = list[list.Count - 1];
		HonamiStoryDragItemHoverInfo item2 = new HonamiStoryDragItemHoverInfo
		{
			IsValid = false,
			StartPosition = startPosition,
			EndPosition = endPosition,
			Width = ((num4 >= num3) ? (num4 - num3 + 1) : 0),
			Height = ((num2 >= num) ? (num2 - num + 1) : 0),
			FillPosList = list
		};
		return new ValueTuple<List<int>, IHonamiStoryDragItemHoverInfo>(list, item2);
	}

	// Token: 0x0600C37C RID: 50044 RVA: 0x0039F87C File Offset: 0x0039DA7C
	public override void OnBackpackLogicStateChange(EHonamiStoryBackpackLogicState state)
	{
		if (state == EHonamiStoryBackpackLogicState.Normal)
		{
			this.RefreshBottomButton(state);
			this.RefreshAllDataItem();
			return;
		}
		if (state == EHonamiStoryBackpackLogicState.Sell)
		{
			this.RefreshBottomButton(state);
			this.RefreshAllDataItem();
			return;
		}
		if (state == EHonamiStoryBackpackLogicState.DraggingPlugins || state == EHonamiStoryBackpackLogicState.Dragging)
		{
			this.RefreshBottomButton(state);
			return;
		}
		if (state == EHonamiStoryBackpackLogicState.TipsWithPlugins || state != EHonamiStoryBackpackLogicState.Tips)
		{
		}
	}

	// Token: 0x0600C37D RID: 50045 RVA: 0x0039F8C8 File Offset: 0x0039DAC8
	private bool CheckSwapValid(HonamiStoryItemDataBase data, List<int> fillPosList, bool canSwap, [Nullable(2)] IHonamiStoryDragItemHoverInfo hoverInfo, HonamiStoryItemDataBase oriItemData, bool isDragCross)
	{
		HashSet<int> hashSet = new HashSet<int>();
		int capacity = this.BackpackData.GetCapacity();
		foreach (int num in fillPosList)
		{
			if (num >= capacity)
			{
				return false;
			}
			hashSet.Add(num);
		}
		HashSet<HonamiStoryItemDataBase> hashSet2 = new HashSet<HonamiStoryItemDataBase>();
		foreach (int key in hashSet)
		{
			HonamiStoryGridItemBase honamiStoryGridItemBase;
			if (this.BackpackItemMap.TryGetValue(key, out honamiStoryGridItemBase) && honamiStoryGridItemBase != null && honamiStoryGridItemBase.GetData() != data)
			{
				HonamiStoryItemDataBase data2 = honamiStoryGridItemBase.GetData();
				if (data2 != null && !hashSet2.Contains(data2))
				{
					if (!canSwap)
					{
						return false;
					}
					foreach (int item in data2.GetGridFillPositionList())
					{
						if (!hashSet.Contains(item))
						{
							return false;
						}
					}
					if (!this.CheckSwapWithItemValid(fillPosList, hoverInfo, oriItemData, data2, isDragCross))
					{
						return false;
					}
					hashSet2.Add(data2);
				}
			}
		}
		return true;
	}

	// Token: 0x0600C37E RID: 50046 RVA: 0x0039FA30 File Offset: 0x0039DC30
	private bool CheckSwapWithItemValid(List<int> fillPosList, [Nullable(2)] IHonamiStoryDragItemHoverInfo hoverInfo, HonamiStoryItemDataBase oriItemData, HonamiStoryItemDataBase gridItemData, bool isDragCross)
	{
		bool itemDataByInstanceId = this.BackpackData.GetItemDataByInstanceId(oriItemData.GetIncId(), false) != null;
		HonamiStoryItemDataBase itemDataByInstanceId2 = this.BackpackData.GetItemDataByInstanceId(gridItemData.GetIncId(), false);
		if (!itemDataByInstanceId || itemDataByInstanceId2 == null)
		{
			return true;
		}
		bool isDragCross2 = oriItemData.GetIsDragCross();
		oriItemData.SetIsDragCross(isDragCross);
		bool isDragCross3 = gridItemData.GetIsDragCross();
		int exchangeItemPosition = this.GetExchangeItemPosition(hoverInfo, oriItemData.GetPosition(), gridItemData.GetPosition(), oriItemData, gridItemData);
		foreach (int item in gridItemData.GetGridFillPositionByPosition(exchangeItemPosition, gridItemData.GetIsDragCross()))
		{
			if (fillPosList.Contains(item))
			{
				oriItemData.SetIsDragCross(isDragCross2);
				gridItemData.SetIsDragCross(isDragCross3);
				return false;
			}
		}
		oriItemData.SetIsDragCross(isDragCross2);
		gridItemData.SetIsDragCross(isDragCross3);
		return true;
	}

	// Token: 0x0600C37F RID: 50047 RVA: 0x0039FB14 File Offset: 0x0039DD14
	private void OnHonamiStoryBackpackUpdate(HonamiStoryBagUpdateContext updateContext)
	{
		if (updateContext.BackPackConfigId != this.BackpackData.BackpackId)
		{
			return;
		}
		UiLayer.Instance.SetShowMaskLayer(EUiViewName.HonamiStoryBackpackView, true);
		this.RefreshBackpackContextUpdate(updateContext).ContinueWith(delegate()
		{
			HonamiStoryBackpackTitleItem titlePanel = this.TitlePanel;
			if (titlePanel != null)
			{
				titlePanel.Refresh();
			}
			if (HonamiStoryUtil.CheckInHonamiStoryDungeon() && this.GetBackpackType() == 1)
			{
				HonamiStoryBackpackValueCountItem currentValueItem = this.CurrentValueItem;
				if (currentValueItem != null)
				{
					currentValueItem.RefreshInGame();
				}
			}
			UiLayer.Instance.SetShowMaskLayer(EUiViewName.HonamiStoryBackpackView, false);
			foreach (HonamiStoryGridItemBase honamiStoryGridItemBase in this.GetUpdateContextEffectGridItems(updateContext))
			{
				honamiStoryGridItemBase.PlayPosChangeSweepAnimation();
			}
		});
	}

	// Token: 0x0600C380 RID: 50048 RVA: 0x0039FB84 File Offset: 0x0039DD84
	private void OnSortSuccess()
	{
		this.ScrollView.StopMovement();
		FVector2D fvector2D = new FVector2D();
		this.ScrollView.ScrollToTop(ref fvector2D, this.ContentItem, true);
	}

	// Token: 0x0600C381 RID: 50049 RVA: 0x0039FBB8 File Offset: 0x0039DDB8
	public override List<HonamiStoryGridItemBase> GetUpdateContextEffectGridItems(HonamiStoryBagUpdateContext updateContext)
	{
		List<HonamiStoryGridItemBase> list = new List<HonamiStoryGridItemBase>();
		foreach (HonamiStoryBagUpdateInfo honamiStoryBagUpdateInfo in updateContext.HonamiStoryBagUpdateInfo)
		{
			bool needLog = honamiStoryBagUpdateInfo.Type != 2;
			if (this.BackpackData.GetItemDataByInstanceId(honamiStoryBagUpdateInfo.ItemIncrId, needLog) != null && (honamiStoryBagUpdateInfo.Type == 0 || honamiStoryBagUpdateInfo.Type == 1))
			{
				int position = honamiStoryBagUpdateInfo.HonamiStoryPosInfo.Position;
				HonamiStoryGridItemBase honamiStoryGridItemBase;
				if (this.BackpackItemMap.TryGetValue(position, out honamiStoryGridItemBase) && honamiStoryGridItemBase != null)
				{
					list.Add(honamiStoryGridItemBase);
				}
			}
		}
		return list;
	}

	// Token: 0x0600C382 RID: 50050 RVA: 0x0039FC64 File Offset: 0x0039DE64
	public override void RefreshSingleItem(HonamiStoryItemDataBase itemData)
	{
		int position = itemData.GetPosition();
		HonamiStoryGridItemBase honamiStoryGridItemBase;
		if (this.BackpackItemMap.TryGetValue(position, out honamiStoryGridItemBase) && honamiStoryGridItemBase != null)
		{
			if (honamiStoryGridItemBase.GetData() != itemData)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.HonamiStory;
				ELogAuthor author = ELogAuthor.WHJ;
				string message = "Get Error Grid With Data";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("pos", position);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			honamiStoryGridItemBase.Refresh(itemData, itemData.GetPosition());
		}
	}

	// Token: 0x0600C383 RID: 50051 RVA: 0x0039FCD4 File Offset: 0x0039DED4
	protected void RefreshBottomButton(EHonamiStoryBackpackLogicState state)
	{
		if (this.GetBackpackType() == 2)
		{
			return;
		}
		if (state == EHonamiStoryBackpackLogicState.Normal || state == EHonamiStoryBackpackLogicState.Sell)
		{
			bool flag = state == EHonamiStoryBackpackLogicState.Normal;
			string textId = flag ? "HonamiStory_BackpackSort" : "HonamiStory_ClickSell";
			ButtonItem buttonRight = this.ButtonRight;
			if (buttonRight != null)
			{
				buttonRight.SetLocalTextNew(textId, Array.Empty<object>());
			}
			ButtonItem buttonSell = this.ButtonSell;
			if (buttonSell != null)
			{
				buttonSell.SetUiActive(flag);
			}
			bool flag2 = HonamiStoryUtil.CheckInHonamiStoryDungeon();
			this.CurrentValueItem.SetVisible(!flag || flag2);
			this.SetButtonAlpha(true);
			return;
		}
		if (state == EHonamiStoryBackpackLogicState.DraggingPlugins || state == EHonamiStoryBackpackLogicState.Dragging)
		{
			this.SetButtonAlpha(false);
		}
	}

	// Token: 0x0600C384 RID: 50052 RVA: 0x0039FD60 File Offset: 0x0039DF60
	protected void SetButtonAlpha(bool isEnable)
	{
		ButtonItem buttonRight = this.ButtonRight;
		if (buttonRight != null)
		{
			buttonRight.SetEnableClick(isEnable);
		}
		ButtonItem buttonSell = this.ButtonSell;
		if (buttonSell != null)
		{
			buttonSell.SetEnableClick(isEnable);
		}
		float alpha = isEnable ? 1f : 0.4f;
		UUIItem item = base.GetItem(11);
		if (item == null)
		{
			return;
		}
		item.SetAlpha(alpha);
	}

	// Token: 0x0600C385 RID: 50053 RVA: 0x0039FDB4 File Offset: 0x0039DFB4
	protected void RefreshAllDataItem()
	{
		HashSet<HonamiStoryGridItemBase> hashSet = new HashSet<HonamiStoryGridItemBase>();
		foreach (KeyValuePair<int, HonamiStoryGridItemBase> keyValuePair in this.BackpackItemMap)
		{
			HonamiStoryGridItemBase value = keyValuePair.Value;
			if (!hashSet.Contains(value) && value != null)
			{
				hashSet.Add(value);
				HonamiStoryItemDataBase data = value.GetData();
				if (data != null)
				{
					value.Refresh(data, data.GetPosition());
				}
			}
		}
	}

	// Token: 0x0600C386 RID: 50054 RVA: 0x0039FE40 File Offset: 0x0039E040
	[NullableContext(2)]
	protected void RefreshScrollMoveState(ULGUIPointerEventData eventData)
	{
		if (eventData != null)
		{
			float stretchTop = this.ContentItem.GetStretchTop();
			bool flag = HonamiStoryUtil.CheckEventDataInItemViewport(eventData, base.GetItem(12), true) && stretchTop < 0f;
			float stretchBottom = this.ContentItem.GetStretchBottom();
			bool flag2 = HonamiStoryUtil.CheckEventDataInItemViewport(eventData, base.GetItem(13), true) && stretchBottom < 0f;
			UUIItem item = base.GetItem(12);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(13);
			if (item2 != null)
			{
				item2.SetUIActive(flag2);
			}
			if (flag || flag2)
			{
				float scrollSpeedMulti = this.GetScrollSpeedMulti(flag, eventData);
				this.IsScrollUp = flag;
				this.OnHoveringUpDownPanel(scrollSpeedMulti);
			}
			return;
		}
		UUIItem item3 = base.GetItem(12);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		UUIItem item4 = base.GetItem(13);
		if (item4 == null)
		{
			return;
		}
		item4.SetUIActive(false);
	}

	// Token: 0x0600C387 RID: 50055 RVA: 0x0039FF10 File Offset: 0x0039E110
	private void OnHoveringUpDownPanel(float multi)
	{
		FVector location = this.ContentItem.GetRelativeTransform().GetLocation();
		float num = (float)(this.IsScrollUp ? (-(float)this.ScrollSpeed) : this.ScrollSpeed) * multi;
		this.ScrollView.SetScrollValue(new FVector2D(0f, Math.Max(0f, location.Y + num)));
		float stretchTop = this.ContentItem.GetStretchTop();
		float stretchBottom = this.ContentItem.GetStretchBottom();
		if (!this.IsScrollUp || stretchTop < 0f)
		{
			if (!this.IsScrollUp && stretchBottom >= 0f)
			{
				UUIItem item = base.GetItem(13);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(false);
			}
			return;
		}
		UUIItem item2 = base.GetItem(12);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x0600C388 RID: 50056 RVA: 0x0039FFD4 File Offset: 0x0039E1D4
	private float GetScrollSpeedMulti(bool isUp, ULGUIPointerEventData eventData)
	{
		HonamiStoryBackpackPanel.EComponent name = isUp ? HonamiStoryBackpackPanel.EComponent.PanelGoTop : HonamiStoryBackpackPanel.EComponent.PanelGoDown;
		UUIItem item = base.GetItem((int)name);
		FVector offsetVector = HonamiStoryUtil.GetOffsetVector(eventData.GetWorldPointInPlane());
		FVector uiworldPosition = item.GetUIWorldPosition();
		if (isUp)
		{
			return (float)((offsetVector.Z > uiworldPosition.Z) ? 2 : 1);
		}
		return (float)((offsetVector.Z > uiworldPosition.Z) ? 1 : 2);
	}

	// Token: 0x0600C389 RID: 50057 RVA: 0x003A0030 File Offset: 0x0039E230
	protected void SetBottomItemEnable(bool value)
	{
		UiPanelBase overflowBottomItem = this.OverflowBottomItem;
		if (overflowBottomItem != null)
		{
			overflowBottomItem.SetUiActive(value);
		}
		if (value && this.OverflowBottomItem != null)
		{
			int position = this.BackpackData.GetCapacity() + this.BackpackData.GetOverflowCapacity();
			this.SetItemOffset(this.OverflowBottomItem.GetRootItem(), position);
			UiPanelBase overflowBottomItem2 = this.OverflowBottomItem;
			if (overflowBottomItem2 == null)
			{
				return;
			}
			overflowBottomItem2.GetRootItem().SetAsLastHierarchy();
		}
	}

	// Token: 0x0600C38A RID: 50058 RVA: 0x003A009C File Offset: 0x0039E29C
	private void OnClickQuickSell(int _)
	{
		HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		if (backpackLogicState == EHonamiStoryBackpackLogicState.Normal)
		{
			if (backpackLogic != null)
			{
				backpackLogic.SetLogicState(EHonamiStoryBackpackLogicState.Sell, null, null);
				return;
			}
		}
		else if ((backpackLogicState == EHonamiStoryBackpackLogicState.TipsWithPlugins || backpackLogicState == EHonamiStoryBackpackLogicState.Tips) && backpackLogic != null)
		{
			backpackLogic.CloseTips();
		}
	}

	// Token: 0x0600C38B RID: 50059 RVA: 0x003A00E8 File Offset: 0x0039E2E8
	private void OnClickRight(int _)
	{
		HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
		EHonamiStoryBackpackLogicState logicState = backpackLogic.GetLogicState();
		if (logicState == EHonamiStoryBackpackLogicState.Normal)
		{
			HonamiStoryModel.Instance.SortBackpack();
			return;
		}
		if (logicState == EHonamiStoryBackpackLogicState.Sell)
		{
			backpackLogic.DoSell();
			return;
		}
		if ((logicState == EHonamiStoryBackpackLogicState.TipsWithPlugins || logicState == EHonamiStoryBackpackLogicState.Tips) && backpackLogic != null)
		{
			backpackLogic.CloseTips();
		}
	}

	// Token: 0x0600C38C RID: 50060 RVA: 0x003A0134 File Offset: 0x0039E334
	public override List<HonamiStoryGridItemBase> GetCurrentGridListGamepad()
	{
		List<HonamiStoryGridItemBase> list = new List<HonamiStoryGridItemBase>();
		List<int> list2 = new List<int>();
		foreach (KeyValuePair<int, HonamiStoryGridItemBase> keyValuePair in this.BackpackItemMap)
		{
			list2.Add(keyValuePair.Key);
		}
		list2.Sort((int a, int b) => a - b);
		foreach (int key in list2)
		{
			HonamiStoryGridItemBase honamiStoryGridItemBase;
			if (this.BackpackItemMap.TryGetValue(key, out honamiStoryGridItemBase) && honamiStoryGridItemBase != null)
			{
				list.Add(honamiStoryGridItemBase);
			}
		}
		return list;
	}

	// Token: 0x0600C38D RID: 50061 RVA: 0x003A0214 File Offset: 0x0039E414
	public override bool CheckPositionValidGamepad(int position)
	{
		return this.CheckPositionInViewport(position);
	}

	// Token: 0x0600C38E RID: 50062 RVA: 0x003A0220 File Offset: 0x0039E420
	public override void OnScrollToTopOrBottomGamepad(bool toTop)
	{
		if (toTop)
		{
			FVector2D fvector2D = new FVector2D();
			this.ScrollView.ScrollToTop(ref fvector2D, this.ContentItem, false);
			return;
		}
		FVector2D fvector2D2 = new FVector2D();
		this.ScrollView.ScrollToBottom(ref fvector2D2, this.ContentItem, false);
	}

	// Token: 0x0600C38F RID: 50063 RVA: 0x003A0268 File Offset: 0x0039E468
	public override void OnScrollValueChangedGamepad(bool isUp)
	{
		FVector location = this.ContentItem.GetRelativeTransform().GetLocation();
		int num = (isUp ? (-this.ScrollSpeed) : this.ScrollSpeed) * 15;
		float inY = Math.Max(0f, location.Y + (float)num);
		this.ScrollView.SetScrollValue(new FVector2D(0f, inY));
	}

	// Token: 0x0600C390 RID: 50064 RVA: 0x003A02CC File Offset: 0x0039E4CC
	public override void OnHoverGamepad(HonamiStoryGridItemBase targetItem, int position, HonamiStoryInteractOperateAgent operateAgent)
	{
		if (position == -1)
		{
			return;
		}
		if (this.HoverPosition == position)
		{
			return;
		}
		if (operateAgent.OperateData == null)
		{
			return;
		}
		this.DragItemHoverInfo = this.GetDragItemHoverInfo(operateAgent, position);
		this.HoverPosition = position;
		this.RefreshHoverTip(this.DragItemHoverInfo);
		HonamiStoryBackpackView honamiStoryBackpackView = UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryBackpackView) as HonamiStoryBackpackView;
		if (honamiStoryBackpackView != null)
		{
			honamiStoryBackpackView.ShowTipsHotKeyOnly(targetItem);
		}
		HonamiStoryPickUpBackpackView honamiStoryPickUpBackpackView = UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryPickUpBackpackView) as HonamiStoryPickUpBackpackView;
		if (honamiStoryPickUpBackpackView != null)
		{
			honamiStoryPickUpBackpackView.ShowTipsHotKeyOnly(targetItem);
		}
	}

	// Token: 0x0600C391 RID: 50065 RVA: 0x003A0350 File Offset: 0x0039E550
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInSameBackpackGamepad(HonamiStoryGridItemBase gridItem, HonamiStoryItemDataBase itemData)
	{
		if (this.DragItemHoverInfo == null || !this.DragItemHoverInfo.IsValid)
		{
			return null;
		}
		if (this.DragItemHoverInfo.StartPosition == itemData.GetPosition() && itemData.GetIsCross() == itemData.GetIsDragCross())
		{
			return null;
		}
		HashSet<int> hashSet = new HashSet<int>();
		HonamiStoryBagUpdateContext honamiStoryBagUpdateContext = HonamiStoryBagUpdateContext.Create();
		honamiStoryBagUpdateContext.BackPackConfigId = this.BackpackData.BackpackId;
		HonamiStoryBagUpdateInfo honamiStoryItemSwapInfo = HonamiStoryUtil.GetHonamiStoryItemSwapInfo(itemData, this.DragItemHoverInfo.StartPosition);
		honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemSwapInfo);
		hashSet.Add(itemData.GetIncId());
		List<int> fillPosList = this.DragItemHoverInfo.FillPosList;
		foreach (int position in fillPosList)
		{
			HonamiStoryItemDataBase itemDataByPosition = this.BackpackData.GetItemDataByPosition(position);
			if (itemDataByPosition != null && !hashSet.Contains(itemDataByPosition.GetIncId()))
			{
				hashSet.Add(itemDataByPosition.GetIncId());
				int exchangeItemPosition = this.GetExchangeItemPosition(this.DragItemHoverInfo, itemData.GetPosition(), itemDataByPosition.GetPosition(), itemData, itemDataByPosition);
				List<int> gridFillPositionByPosition = itemDataByPosition.GetGridFillPositionByPosition(exchangeItemPosition, itemDataByPosition.GetIsDragCross());
				bool flag = true;
				foreach (int item in gridFillPositionByPosition)
				{
					if (fillPosList.Contains(item))
					{
						Log.Instance.Error(ELogModule.HonamiStory, ELogAuthor.WHJ, "SwapInfo Error", default(ReadOnlySpan<ValueTuple<string, object>>));
						flag = false;
						break;
					}
				}
				if (!flag)
				{
					return null;
				}
				HonamiStoryBagUpdateInfo honamiStoryItemSwapInfo2 = HonamiStoryUtil.GetHonamiStoryItemSwapInfo(itemDataByPosition, exchangeItemPosition);
				honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemSwapInfo2);
			}
		}
		return honamiStoryBagUpdateContext;
	}

	// Token: 0x0600C392 RID: 50066 RVA: 0x003A0520 File Offset: 0x0039E720
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInSendBackpackGamepad(HonamiStoryGridItemBase gridItem, HonamiStoryItemDataBase operateData, HashSet<HonamiStoryItemDataBase> exchangeItemSet)
	{
		HashSet<int> hashSet = new HashSet<int>(this.BackpackData.GetEmptyGridSet());
		foreach (int item in operateData.GetGridFillPositionList())
		{
			hashSet.Add(item);
		}
		List<int> list = new List<int>();
		List<HonamiStoryItemDataBase> list2 = new List<HonamiStoryItemDataBase>(exchangeItemSet);
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in list2)
		{
			if (honamiStoryItemDataBase != null)
			{
				IHonamiStoryAvailablePosInfo honamiStoryAvailablePosInfo = HonamiStoryUtil.FindFirstAvailablePosition(hashSet, honamiStoryItemDataBase, this.BackpackData.GetWidthCount(), null);
				if (honamiStoryAvailablePosInfo.Position == -1)
				{
					return null;
				}
				List<int> gridFillPositionByPosition = honamiStoryItemDataBase.GetGridFillPositionByPosition(honamiStoryAvailablePosInfo.Position, honamiStoryAvailablePosInfo.IsCross);
				HonamiStoryUtil.RemoveEmptyGridPosition(hashSet, gridFillPositionByPosition.ToArray());
				list.Add(honamiStoryAvailablePosInfo.Position);
			}
		}
		HonamiStoryBagUpdateContext honamiStoryBagUpdateContext = HonamiStoryBagUpdateContext.Create();
		honamiStoryBagUpdateContext.BackPackConfigId = this.BackpackData.BackpackId;
		HonamiStoryBagUpdateInfo honamiStoryItemRemoveInfo = HonamiStoryUtil.GetHonamiStoryItemRemoveInfo(operateData);
		honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemRemoveInfo);
		for (int i = 0; i < list2.Count; i++)
		{
			HonamiStoryBagUpdateInfo honamiStoryItemAddInfo = HonamiStoryUtil.GetHonamiStoryItemAddInfo(list2[i], list[i]);
			honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemAddInfo);
		}
		return honamiStoryBagUpdateContext;
	}

	// Token: 0x0600C393 RID: 50067 RVA: 0x003A0694 File Offset: 0x0039E894
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInReceiveBackpackGamepad(HonamiStoryGridItemBase gridItem, HonamiStoryItemDataBase operateData, HashSet<HonamiStoryItemDataBase> exchangeItemSet)
	{
		if (this.DragItemHoverInfo == null || !this.DragItemHoverInfo.IsValid)
		{
			return null;
		}
		HonamiStoryBagUpdateContext honamiStoryBagUpdateContext = HonamiStoryBagUpdateContext.Create();
		honamiStoryBagUpdateContext.BackPackConfigId = this.BackpackData.BackpackId;
		HonamiStoryBagUpdateInfo honamiStoryItemAddInfo = HonamiStoryUtil.GetHonamiStoryItemAddInfo(operateData, this.DragItemHoverInfo.StartPosition);
		honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemAddInfo);
		foreach (HonamiStoryItemDataBase itemData in exchangeItemSet)
		{
			HonamiStoryBagUpdateInfo honamiStoryItemRemoveInfo = HonamiStoryUtil.GetHonamiStoryItemRemoveInfo(itemData);
			honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemRemoveInfo);
		}
		return honamiStoryBagUpdateContext;
	}

	// Token: 0x0600C394 RID: 50068 RVA: 0x003A073C File Offset: 0x0039E93C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override HashSet<HonamiStoryItemDataBase> GetExchangeItemSetGamepad(HonamiStoryGridItemBase gridItem, HonamiStoryItemDataBase operateItem)
	{
		if (this.DragItemHoverInfo == null || !this.DragItemHoverInfo.IsValid)
		{
			return null;
		}
		HashSet<HonamiStoryItemDataBase> hashSet = new HashSet<HonamiStoryItemDataBase>();
		foreach (int key in this.DragItemHoverInfo.FillPosList)
		{
			HonamiStoryGridItemBase honamiStoryGridItemBase;
			if (this.BackpackItemMap.TryGetValue(key, out honamiStoryGridItemBase) && honamiStoryGridItemBase != null)
			{
				HonamiStoryItemDataBase data = honamiStoryGridItemBase.GetData();
				if (data != null && !hashSet.Contains(data))
				{
					hashSet.Add(data);
				}
			}
		}
		return hashSet;
	}

	// Token: 0x0600C395 RID: 50069 RVA: 0x003A07E0 File Offset: 0x0039E9E0
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length < 1)
		{
			return null;
		}
		string a = configParams[0];
		if (a == "BtnSell")
		{
			UUIItem guideUiItem = base.GetGuideUiItem("0");
			if (guideUiItem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				guideUiItem,
				guideUiItem
			};
		}
		else if (a == "ToggleSelect")
		{
			UUIItem guideUiItem2 = base.GetGuideUiItem("1");
			if (guideUiItem2 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				guideUiItem2,
				guideUiItem2
			};
		}
		else if (a == "BtnReset")
		{
			UUIItem guideUiItem3 = base.GetGuideUiItem("2");
			if (guideUiItem3 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				guideUiItem3,
				guideUiItem3
			};
		}
		else
		{
			if (!(a == "Item"))
			{
				if (a == "Plugin")
				{
					int num = int.Parse(configParams[1]);
					foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in this.BackpackData.GetItemDataList())
					{
						if (honamiStoryItemDataBase.GetItemId() == num)
						{
							int position = honamiStoryItemDataBase.GetPosition();
							HonamiStoryGridItemBase honamiStoryGridItemBase;
							UUIItem uuiitem;
							if (!this.BackpackItemMap.TryGetValue(position, out honamiStoryGridItemBase) || honamiStoryGridItemBase == null)
							{
								uuiitem = null;
							}
							else
							{
								HonamiStoryItemGridItem itemGridItem = honamiStoryGridItemBase.GetItemGridItem();
								uuiitem = ((itemGridItem != null) ? itemGridItem.GetRootItem() : null);
							}
							UUIItem uuiitem2 = uuiitem;
							UUIItem[] result;
							if (uuiitem2 == null)
							{
								result = null;
							}
							else
							{
								UUIItem[] array = new UUIItem[2];
								array[0] = uuiitem2;
								result = array;
								array[1] = uuiitem2;
							}
							return result;
						}
					}
				}
				return null;
			}
			int num2 = int.Parse(configParams[1]);
			HonamiStoryItemDataBase honamiStoryItemDataBase2 = this.BackpackData.GetItemDataList()[num2];
			if (honamiStoryItemDataBase2 == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Guide;
				ELogAuthor author = ELogAuthor.TZJ;
				string message = "引导获取背包物品失败";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("index", num2);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			int position2 = honamiStoryItemDataBase2.GetPosition();
			HonamiStoryGridItemBase honamiStoryGridItemBase2;
			UUIItem uuiitem3;
			if (!this.BackpackItemMap.TryGetValue(position2, out honamiStoryGridItemBase2) || honamiStoryGridItemBase2 == null)
			{
				uuiitem3 = null;
			}
			else
			{
				HonamiStoryItemGridItem itemGridItem2 = honamiStoryGridItemBase2.GetItemGridItem();
				uuiitem3 = ((itemGridItem2 != null) ? itemGridItem2.GetRootItem() : null);
			}
			UUIItem uuiitem4 = uuiitem3;
			if (honamiStoryItemDataBase2 == null)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Guide;
				ELogAuthor author2 = ELogAuthor.TZJ;
				string message2 = "引导获取背包物品GridItem失败";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("position", position2);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return null;
			}
			if (uuiitem4 == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem4,
				uuiitem4
			};
		}
	}

	// Token: 0x04006FAF RID: 28591
	private const int CONTENT_SMALL_OFFSET = 112;

	// Token: 0x04006FB0 RID: 28592
	private const int CONTENT_FOR_SAFE = 6;

	// Token: 0x04006FB1 RID: 28593
	private HonamiStoryBackpackData BackpackData;

	// Token: 0x04006FB2 RID: 28594
	private UUIScrollViewWithScrollbarComponent ScrollView;

	// Token: 0x04006FB3 RID: 28595
	private UUIItem ViewportItem;

	// Token: 0x04006FB4 RID: 28596
	private UUIItem ContentItem;

	// Token: 0x04006FB5 RID: 28597
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Dictionary<int, HonamiStoryGridItemBase> BackpackItemMap = new Dictionary<int, HonamiStoryGridItemBase>();

	// Token: 0x04006FB6 RID: 28598
	private readonly HashSet<HonamiStoryGridItemBase> BackpackItemPool = new HashSet<HonamiStoryGridItemBase>();

	// Token: 0x04006FB7 RID: 28599
	[Nullable(2)]
	private IHonamiStoryDragItemHoverInfo DragItemHoverInfo;

	// Token: 0x04006FB8 RID: 28600
	private int HoverPosition = -1;

	// Token: 0x04006FB9 RID: 28601
	private float ViewportHeight;

	// Token: 0x04006FBA RID: 28602
	private int LastViewportStartPosition = -1;

	// Token: 0x04006FBB RID: 28603
	private int LastViewportEndPosition = -1;

	// Token: 0x04006FBC RID: 28604
	private int CurViewportStartPosition = -1;

	// Token: 0x04006FBD RID: 28605
	private int CurViewportEndPosition = -1;

	// Token: 0x04006FBE RID: 28606
	[Nullable(2)]
	private ButtonItem ButtonSell;

	// Token: 0x04006FBF RID: 28607
	[Nullable(2)]
	private ButtonItem ButtonRight;

	// Token: 0x04006FC0 RID: 28608
	[Nullable(2)]
	private HonamiStoryBackpackValueCountItem CurrentValueItem;

	// Token: 0x04006FC1 RID: 28609
	[Nullable(2)]
	private HonamiStoryBackpackTitleItem TitlePanel;

	// Token: 0x04006FC2 RID: 28610
	private bool IsScrollUp;

	// Token: 0x04006FC3 RID: 28611
	private int ScrollSpeed = 10;

	// Token: 0x04006FC4 RID: 28612
	private int CurMaskingItemIncId = -1;

	// Token: 0x04006FC5 RID: 28613
	private readonly HashSet<int> GridCreateAsyncLock = new HashSet<int>();

	// Token: 0x04006FC6 RID: 28614
	[Nullable(2)]
	private UiPanelBase OverflowBottomItem;

	// Token: 0x020075B5 RID: 30133
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04026352 RID: 156498
		TitleItem,
		// Token: 0x04026353 RID: 156499
		GridBG,
		// Token: 0x04026354 RID: 156500
		ScrollView,
		// Token: 0x04026355 RID: 156501
		ViewportItem,
		// Token: 0x04026356 RID: 156502
		ContentItem,
		// Token: 0x04026357 RID: 156503
		SpriteHoverMask,
		// Token: 0x04026358 RID: 156504
		SpriteHoverGridState,
		// Token: 0x04026359 RID: 156505
		SpriteSelect,
		// Token: 0x0402635A RID: 156506
		BtnLeft,
		// Token: 0x0402635B RID: 156507
		BtnRight,
		// Token: 0x0402635C RID: 156508
		ValueItem,
		// Token: 0x0402635D RID: 156509
		PanelButton,
		// Token: 0x0402635E RID: 156510
		PanelGoTop,
		// Token: 0x0402635F RID: 156511
		PanelGoDown,
		// Token: 0x04026360 RID: 156512
		PanelSelf,
		// Token: 0x04026361 RID: 156513
		PanelGrid
	}
}
