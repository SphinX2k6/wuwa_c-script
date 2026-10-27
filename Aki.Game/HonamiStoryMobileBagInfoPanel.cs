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

// Token: 0x02001E96 RID: 7830
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryMobileBagInfoPanel : HonamiStoryBackpackPanelBase
{
	// Token: 0x0600F017 RID: 61463 RVA: 0x00397E54 File Offset: 0x00396054
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUISprite))
		};
	}

	// Token: 0x0600F018 RID: 61464 RVA: 0x00397EC4 File Offset: 0x003960C4
	protected override void OnStart()
	{
		this.ScrollSpeed = HonamiStoryConfig.Instance.GetScrollingSpeed();
		base.GetSprite(3).SetUIActive(false);
		base.GetSprite(1).SetUIActive(false);
		base.GetSprite(1).SetHierarchyIndex(99);
		base.GetSprite(2).SetUIActive(false);
		base.GetSprite(2).SetHierarchyIndex(100);
	}

	// Token: 0x0600F019 RID: 61465 RVA: 0x00397F24 File Offset: 0x00396124
	protected override void OnBeforeShow()
	{
		this.AddEventListener();
		this.CurrentValueItem.RefreshInGame();
	}

	// Token: 0x0600F01A RID: 61466 RVA: 0x00397F37 File Offset: 0x00396137
	private void AddEventListener()
	{
		EventSystem.Instance.Add<HonamiStoryBagUpdateContext>(EEventName.OnHonamiStoryBackpackUpdate, new Action<HonamiStoryBagUpdateContext>(this.OnHonamiStoryBackpackUpdate));
	}

	// Token: 0x0600F01B RID: 61467 RVA: 0x00397F58 File Offset: 0x00396158
	public UniTask Init()
	{
		HonamiStoryMobileBagInfoPanel.<Init>d__26 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<HonamiStoryMobileBagInfoPanel.<Init>d__26>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600F01C RID: 61468 RVA: 0x00397F9C File Offset: 0x0039619C
	public UniTask UpdateViewportItems()
	{
		HonamiStoryMobileBagInfoPanel.<UpdateViewportItems>d__27 <UpdateViewportItems>d__;
		<UpdateViewportItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateViewportItems>d__.<>4__this = this;
		<UpdateViewportItems>d__.<>1__state = -1;
		<UpdateViewportItems>d__.<>t__builder.Start<HonamiStoryMobileBagInfoPanel.<UpdateViewportItems>d__27>(ref <UpdateViewportItems>d__);
		return <UpdateViewportItems>d__.<>t__builder.Task;
	}

	// Token: 0x0600F01D RID: 61469 RVA: 0x00397FE0 File Offset: 0x003961E0
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

	// Token: 0x0600F01E RID: 61470 RVA: 0x0039803C File Offset: 0x0039623C
	private UniTask UpdateWhenOverflowChange(int changeNum)
	{
		HonamiStoryMobileBagInfoPanel.<UpdateWhenOverflowChange>d__29 <UpdateWhenOverflowChange>d__;
		<UpdateWhenOverflowChange>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateWhenOverflowChange>d__.<>4__this = this;
		<UpdateWhenOverflowChange>d__.<>1__state = -1;
		<UpdateWhenOverflowChange>d__.<>t__builder.Start<HonamiStoryMobileBagInfoPanel.<UpdateWhenOverflowChange>d__29>(ref <UpdateWhenOverflowChange>d__);
		return <UpdateWhenOverflowChange>d__.<>t__builder.Task;
	}

	// Token: 0x0600F01F RID: 61471 RVA: 0x00398080 File Offset: 0x00396280
	[NullableContext(2)]
	private void RefreshMask(HonamiStoryItemDataBase itemData)
	{
		if (itemData == null)
		{
			base.GetSprite(1).SetUIActive(false);
			return;
		}
		UUISprite sprite = base.GetSprite(1);
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

	// Token: 0x0600F020 RID: 61472 RVA: 0x0039810C File Offset: 0x0039630C
	[NullableContext(2)]
	private void RefreshHoverTip(IHonamiStoryDragItemHoverInfo hoverInfo)
	{
		if (hoverInfo == null)
		{
			base.GetSprite(2).SetUIActive(false);
			return;
		}
		UUISprite sprite = base.GetSprite(2);
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

	// Token: 0x0600F021 RID: 61473 RVA: 0x003981B0 File Offset: 0x003963B0
	private UniTask CreateHonamiStoryGridItem(int position)
	{
		HonamiStoryMobileBagInfoPanel.<CreateHonamiStoryGridItem>d__32 <CreateHonamiStoryGridItem>d__;
		<CreateHonamiStoryGridItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateHonamiStoryGridItem>d__.<>4__this = this;
		<CreateHonamiStoryGridItem>d__.position = position;
		<CreateHonamiStoryGridItem>d__.<>1__state = -1;
		<CreateHonamiStoryGridItem>d__.<>t__builder.Start<HonamiStoryMobileBagInfoPanel.<CreateHonamiStoryGridItem>d__32>(ref <CreateHonamiStoryGridItem>d__);
		return <CreateHonamiStoryGridItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600F022 RID: 61474 RVA: 0x003981FC File Offset: 0x003963FC
	private UniTask CreateEmptyGridItem(int position)
	{
		HonamiStoryMobileBagInfoPanel.<CreateEmptyGridItem>d__33 <CreateEmptyGridItem>d__;
		<CreateEmptyGridItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateEmptyGridItem>d__.<>4__this = this;
		<CreateEmptyGridItem>d__.position = position;
		<CreateEmptyGridItem>d__.<>1__state = -1;
		<CreateEmptyGridItem>d__.<>t__builder.Start<HonamiStoryMobileBagInfoPanel.<CreateEmptyGridItem>d__33>(ref <CreateEmptyGridItem>d__);
		return <CreateEmptyGridItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600F023 RID: 61475 RVA: 0x00398248 File Offset: 0x00396448
	private void SetItemOffset(UUIItem item, int position)
	{
		int num = position / this.BackpackData.GetWidthCount();
		int num2 = position % this.BackpackData.GetWidthCount();
		int num3 = num2 * this.BackpackData.GetCellWidth() + num2 * this.BackpackData.GetCellHorizontalInterval();
		int num4 = -num * this.BackpackData.GetCellHeight() - num * this.BackpackData.GetCellVerticalInterval();
		item.SetAnchorOffsetX((float)num3);
		item.SetAnchorOffsetY((float)num4);
	}

	// Token: 0x0600F024 RID: 61476 RVA: 0x003982BC File Offset: 0x003964BC
	private UniTask FillBackpackItemMap(HonamiStoryItemDataBase itemData, HonamiStoryGridItemBase item)
	{
		HonamiStoryMobileBagInfoPanel.<FillBackpackItemMap>d__35 <FillBackpackItemMap>d__;
		<FillBackpackItemMap>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FillBackpackItemMap>d__.<>4__this = this;
		<FillBackpackItemMap>d__.itemData = itemData;
		<FillBackpackItemMap>d__.item = item;
		<FillBackpackItemMap>d__.<>1__state = -1;
		<FillBackpackItemMap>d__.<>t__builder.Start<HonamiStoryMobileBagInfoPanel.<FillBackpackItemMap>d__35>(ref <FillBackpackItemMap>d__);
		return <FillBackpackItemMap>d__.<>t__builder.Task;
	}

	// Token: 0x0600F025 RID: 61477 RVA: 0x00398310 File Offset: 0x00396510
	private UniTask RecycleGridItem(int position)
	{
		HonamiStoryMobileBagInfoPanel.<RecycleGridItem>d__36 <RecycleGridItem>d__;
		<RecycleGridItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RecycleGridItem>d__.<>4__this = this;
		<RecycleGridItem>d__.position = position;
		<RecycleGridItem>d__.<>1__state = -1;
		<RecycleGridItem>d__.<>t__builder.Start<HonamiStoryMobileBagInfoPanel.<RecycleGridItem>d__36>(ref <RecycleGridItem>d__);
		return <RecycleGridItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600F026 RID: 61478 RVA: 0x0039835C File Offset: 0x0039655C
	private UniTask RecycleChangeGridItem(int position)
	{
		HonamiStoryMobileBagInfoPanel.<RecycleChangeGridItem>d__37 <RecycleChangeGridItem>d__;
		<RecycleChangeGridItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RecycleChangeGridItem>d__.<>4__this = this;
		<RecycleChangeGridItem>d__.position = position;
		<RecycleChangeGridItem>d__.<>1__state = -1;
		<RecycleChangeGridItem>d__.<>t__builder.Start<HonamiStoryMobileBagInfoPanel.<RecycleChangeGridItem>d__37>(ref <RecycleChangeGridItem>d__);
		return <RecycleChangeGridItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600F027 RID: 61479 RVA: 0x003983A8 File Offset: 0x003965A8
	private UniTask RecycleEmptyGridItem(int position)
	{
		HonamiStoryMobileBagInfoPanel.<RecycleEmptyGridItem>d__38 <RecycleEmptyGridItem>d__;
		<RecycleEmptyGridItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RecycleEmptyGridItem>d__.<>4__this = this;
		<RecycleEmptyGridItem>d__.position = position;
		<RecycleEmptyGridItem>d__.<>1__state = -1;
		<RecycleEmptyGridItem>d__.<>t__builder.Start<HonamiStoryMobileBagInfoPanel.<RecycleEmptyGridItem>d__38>(ref <RecycleEmptyGridItem>d__);
		return <RecycleEmptyGridItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600F028 RID: 61480 RVA: 0x003983F4 File Offset: 0x003965F4
	private UniTask RefreshBackpackContextUpdate(HonamiStoryBagUpdateContext updateContext)
	{
		HonamiStoryMobileBagInfoPanel.<RefreshBackpackContextUpdate>d__39 <RefreshBackpackContextUpdate>d__;
		<RefreshBackpackContextUpdate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshBackpackContextUpdate>d__.<>4__this = this;
		<RefreshBackpackContextUpdate>d__.updateContext = updateContext;
		<RefreshBackpackContextUpdate>d__.<>1__state = -1;
		<RefreshBackpackContextUpdate>d__.<>t__builder.Start<HonamiStoryMobileBagInfoPanel.<RefreshBackpackContextUpdate>d__39>(ref <RefreshBackpackContextUpdate>d__);
		return <RefreshBackpackContextUpdate>d__.<>t__builder.Task;
	}

	// Token: 0x0600F029 RID: 61481 RVA: 0x00398440 File Offset: 0x00396640
	private UniTask FillEmptyGridInViewport()
	{
		HonamiStoryMobileBagInfoPanel.<FillEmptyGridInViewport>d__40 <FillEmptyGridInViewport>d__;
		<FillEmptyGridInViewport>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FillEmptyGridInViewport>d__.<>4__this = this;
		<FillEmptyGridInViewport>d__.<>1__state = -1;
		<FillEmptyGridInViewport>d__.<>t__builder.Start<HonamiStoryMobileBagInfoPanel.<FillEmptyGridInViewport>d__40>(ref <FillEmptyGridInViewport>d__);
		return <FillEmptyGridInViewport>d__.<>t__builder.Task;
	}

	// Token: 0x0600F02A RID: 61482 RVA: 0x00398484 File Offset: 0x00396684
	private bool CheckItemInViewport(HonamiStoryGridItemBase item)
	{
		HonamiStoryItemDataBase data = item.GetData();
		return data != null && this.CheckItemDataInViewport(data);
	}

	// Token: 0x0600F02B RID: 61483 RVA: 0x003984A4 File Offset: 0x003966A4
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

	// Token: 0x0600F02C RID: 61484 RVA: 0x00398500 File Offset: 0x00396700
	private bool CheckPositionInViewport(int position)
	{
		return position >= this.CurViewportStartPosition && position <= this.CurViewportEndPosition;
	}

	// Token: 0x0600F02D RID: 61485 RVA: 0x00398517 File Offset: 0x00396717
	protected override void OnBeforeHide()
	{
		this.RemoveEventListener();
	}

	// Token: 0x0600F02E RID: 61486 RVA: 0x0039851F File Offset: 0x0039671F
	private void RemoveEventListener()
	{
		EventSystem.Instance.Remove<HonamiStoryBagUpdateContext>(EEventName.OnHonamiStoryBackpackUpdate, new Action<HonamiStoryBagUpdateContext>(this.OnHonamiStoryBackpackUpdate));
	}

	// Token: 0x0600F02F RID: 61487 RVA: 0x00398540 File Offset: 0x00396740
	[NullableContext(2)]
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<HonamiStoryGridItemBase> GetHonamiStoryGridItem(bool needItem = false, HonamiStoryItemDataBase itemData = null)
	{
		HonamiStoryMobileBagInfoPanel.<GetHonamiStoryGridItem>d__46 <GetHonamiStoryGridItem>d__;
		<GetHonamiStoryGridItem>d__.<>t__builder = AsyncUniTaskMethodBuilder<HonamiStoryGridItemBase>.Create();
		<GetHonamiStoryGridItem>d__.<>4__this = this;
		<GetHonamiStoryGridItem>d__.needItem = needItem;
		<GetHonamiStoryGridItem>d__.itemData = itemData;
		<GetHonamiStoryGridItem>d__.<>1__state = -1;
		<GetHonamiStoryGridItem>d__.<>t__builder.Start<HonamiStoryMobileBagInfoPanel.<GetHonamiStoryGridItem>d__46>(ref <GetHonamiStoryGridItem>d__);
		return <GetHonamiStoryGridItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600F030 RID: 61488 RVA: 0x00398593 File Offset: 0x00396793
	public override int GetBackpackType()
	{
		return (int)this.BackpackData.BackpackType;
	}

	// Token: 0x0600F031 RID: 61489 RVA: 0x003985A0 File Offset: 0x003967A0
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

	// Token: 0x0600F032 RID: 61490 RVA: 0x003985F5 File Offset: 0x003967F5
	public override void OnHoverEnd()
	{
		this.HoverPosition = -1;
		this.DragItemHoverInfo = null;
		this.RefreshScrollMoveState(null);
		this.RefreshHoverTip(null);
	}

	// Token: 0x0600F033 RID: 61491 RVA: 0x00398613 File Offset: 0x00396813
	public override bool OnDragBegin([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.RefreshMask(item.GetData());
		this.RefreshScrollMoveState(null);
		return base.OnDragBegin(eventData, item);
	}

	// Token: 0x0600F034 RID: 61492 RVA: 0x00398630 File Offset: 0x00396830
	public override bool OnDrag([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.RefreshMask(item.GetData());
		return base.OnDrag(eventData, item);
	}

	// Token: 0x0600F035 RID: 61493 RVA: 0x00398646 File Offset: 0x00396846
	public override void OnDragEnd([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.RefreshMask(null);
		this.RefreshScrollMoveState(null);
		base.OnDragEnd(eventData, item);
	}

	// Token: 0x0600F036 RID: 61494 RVA: 0x00398660 File Offset: 0x00396860
	public int GetDragItemPositionInContent(ULGUIPointerEventData eventData)
	{
		UUIItem item = base.GetItem(0);
		FVector offsetVector = HonamiStoryUtil.GetOffsetVector(eventData.GetWorldPointInPlane());
		FVector uiworldPosition = item.GetUIWorldPosition();
		float num = uiworldPosition.X - item.GetWidth() / 2f;
		float num2 = num + item.GetWidth();
		float num3 = uiworldPosition.Z - item.GetHeight() / 2f;
		float num4 = num3 + item.GetHeight();
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

	// Token: 0x0600F037 RID: 61495 RVA: 0x0039875C File Offset: 0x0039695C
	public override bool CheckDragItemInViewport(ULGUIPointerEventData eventData)
	{
		FVector offsetVector = HonamiStoryUtil.GetOffsetVector(eventData.GetWorldPointInPlane());
		UUIItem item = base.GetItem(0);
		FVector uiworldPosition = item.GetUIWorldPosition();
		float num = uiworldPosition.X - item.GetWidth() / 2f;
		float num2 = num + item.GetWidth();
		float num3 = uiworldPosition.Z - item.GetHeight() / 2f;
		float num4 = num3 + item.GetHeight();
		return offsetVector.X >= num && offsetVector.X <= num2 && offsetVector.Z >= num3 && offsetVector.Z <= num4;
	}

	// Token: 0x0600F038 RID: 61496 RVA: 0x003987E8 File Offset: 0x003969E8
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

	// Token: 0x0600F039 RID: 61497 RVA: 0x003989FC File Offset: 0x00396BFC
	private int GetExchangeItemPosition(IHonamiStoryDragItemHoverInfo hoverInfo, int itemPosition, int position, HonamiStoryItemDataBase oriItemData, HonamiStoryItemDataBase otherData)
	{
		if (oriItemData.GetIsCross() == oriItemData.GetIsDragCross())
		{
			return this.GetExchangeItemPositionNoCrossChange(hoverInfo, itemPosition, position, otherData);
		}
		return this.GetExchangeItemPositionCrossChange(hoverInfo, itemPosition, position, oriItemData, otherData);
	}

	// Token: 0x0600F03A RID: 61498 RVA: 0x00398A28 File Offset: 0x00396C28
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

	// Token: 0x0600F03B RID: 61499 RVA: 0x00398B20 File Offset: 0x00396D20
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

	// Token: 0x0600F03C RID: 61500 RVA: 0x00398BA0 File Offset: 0x00396DA0
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

	// Token: 0x0600F03D RID: 61501 RVA: 0x00398D64 File Offset: 0x00396F64
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

	// Token: 0x0600F03E RID: 61502 RVA: 0x00398E0C File Offset: 0x0039700C
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

	// Token: 0x0600F03F RID: 61503 RVA: 0x00398EB0 File Offset: 0x003970B0
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

	// Token: 0x0600F040 RID: 61504 RVA: 0x00399100 File Offset: 0x00397300
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

	// Token: 0x0600F041 RID: 61505 RVA: 0x0039921D File Offset: 0x0039741D
	public override void OnBackpackLogicStateChange(EHonamiStoryBackpackLogicState state)
	{
		if (state == EHonamiStoryBackpackLogicState.Normal)
		{
			this.RefreshAllDataItem();
			return;
		}
		if (state == EHonamiStoryBackpackLogicState.Sell)
		{
			this.RefreshAllDataItem();
			return;
		}
		if (state == EHonamiStoryBackpackLogicState.TipsWithPlugins || state == EHonamiStoryBackpackLogicState.Tips || state != EHonamiStoryBackpackLogicState.DraggingPlugins)
		{
		}
	}

	// Token: 0x0600F042 RID: 61506 RVA: 0x00399244 File Offset: 0x00397444
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

	// Token: 0x0600F043 RID: 61507 RVA: 0x003993AC File Offset: 0x003975AC
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

	// Token: 0x0600F044 RID: 61508 RVA: 0x00399490 File Offset: 0x00397690
	[NullableContext(2)]
	protected void RefreshScrollMoveState(ULGUIPointerEventData eventData)
	{
		if (eventData == null)
		{
			this.MoveUpItem.SetUIActive(false);
			this.MoveDownItem.SetUIActive(false);
			return;
		}
		float stretchTop = this.ContentItem.GetStretchTop();
		bool flag = HonamiStoryUtil.CheckEventDataInItemViewport(eventData, this.MoveUpItem, true) && stretchTop < 0f;
		float stretchBottom = this.ContentItem.GetStretchBottom();
		bool flag2 = HonamiStoryUtil.CheckEventDataInItemViewport(eventData, this.MoveDownItem, true) && stretchBottom < 0f;
		this.MoveUpItem.SetUIActive(flag);
		this.MoveDownItem.SetUIActive(flag2);
		if (flag || flag2)
		{
			float scrollSpeedMulti = this.GetScrollSpeedMulti(flag, eventData);
			this.IsScrollUp = flag;
			this.OnHoveringUpDownPanel(scrollSpeedMulti);
		}
	}

	// Token: 0x0600F045 RID: 61509 RVA: 0x00399540 File Offset: 0x00397740
	private void OnHoveringUpDownPanel(float multi)
	{
		FVector location = this.ContentItem.GetRelativeTransform().GetLocation();
		float num = (float)(this.IsScrollUp ? (-(float)this.ScrollSpeed) : this.ScrollSpeed) * multi;
		this.ScrollView.SetScrollValue(new FVector2D(0f, Math.Max(0f, location.Y + num)));
		float stretchTop = this.ContentItem.GetStretchTop();
		float stretchBottom = this.ContentItem.GetStretchBottom();
		if (this.IsScrollUp && stretchTop >= 0f)
		{
			this.MoveUpItem.SetUIActive(false);
			return;
		}
		if (!this.IsScrollUp && stretchBottom >= 0f)
		{
			this.MoveDownItem.SetUIActive(false);
		}
	}

	// Token: 0x0600F046 RID: 61510 RVA: 0x003995F8 File Offset: 0x003977F8
	private float GetScrollSpeedMulti(bool isUp, ULGUIPointerEventData eventData)
	{
		UUIItem uuiitem = isUp ? this.MoveUpItem : this.MoveDownItem;
		FVector offsetVector = HonamiStoryUtil.GetOffsetVector(eventData.GetWorldPointInPlane());
		FVector uiworldPosition = uuiitem.GetUIWorldPosition();
		if (isUp)
		{
			return (float)((offsetVector.Z > uiworldPosition.Z) ? 2 : 1);
		}
		return (float)((offsetVector.Z > uiworldPosition.Z) ? 1 : 2);
	}

	// Token: 0x0600F047 RID: 61511 RVA: 0x00399654 File Offset: 0x00397854
	private void OnHonamiStoryBackpackUpdate(HonamiStoryBagUpdateContext updateContext)
	{
		if (updateContext.BackPackConfigId != this.BackpackData.BackpackId)
		{
			return;
		}
		UiLayer.Instance.SetShowMaskLayer(EUiViewName.HonamiStoryPickUpMobileView, true);
		this.RefreshBackpackContextUpdate(updateContext).ContinueWith(delegate()
		{
			if (this.GetBackpackType() == 1)
			{
				this.CurrentValueItem.RefreshInGame();
			}
			UiLayer.Instance.SetShowMaskLayer(EUiViewName.HonamiStoryPickUpMobileView, false);
			foreach (HonamiStoryGridItemBase honamiStoryGridItemBase in this.GetUpdateContextEffectGridItems(updateContext))
			{
				honamiStoryGridItemBase.PlayPosChangeSweepAnimation();
			}
		});
	}

	// Token: 0x0600F048 RID: 61512 RVA: 0x003996C4 File Offset: 0x003978C4
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

	// Token: 0x0600F049 RID: 61513 RVA: 0x00399770 File Offset: 0x00397970
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

	// Token: 0x0600F04A RID: 61514 RVA: 0x003997E0 File Offset: 0x003979E0
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

	// Token: 0x04006F15 RID: 28437
	private const int EQUIP_OFFSET = 300;

	// Token: 0x04006F16 RID: 28438
	private HonamiStoryBackpackData BackpackData;

	// Token: 0x04006F17 RID: 28439
	public UUIScrollViewWithScrollbarComponent ScrollView;

	// Token: 0x04006F18 RID: 28440
	public UUIItem ViewportItem;

	// Token: 0x04006F19 RID: 28441
	public float ViewportHeight;

	// Token: 0x04006F1A RID: 28442
	public int EquipCount;

	// Token: 0x04006F1B RID: 28443
	public UUIItem ContentItem;

	// Token: 0x04006F1C RID: 28444
	public UUIItem MoveUpItem;

	// Token: 0x04006F1D RID: 28445
	public UUIItem MoveDownItem;

	// Token: 0x04006F1E RID: 28446
	public HonamiStoryBackpackValueCountItem CurrentValueItem;

	// Token: 0x04006F1F RID: 28447
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Dictionary<int, HonamiStoryGridItemBase> BackpackItemMap = new Dictionary<int, HonamiStoryGridItemBase>();

	// Token: 0x04006F20 RID: 28448
	private readonly HashSet<HonamiStoryGridItemBase> BackpackItemPool = new HashSet<HonamiStoryGridItemBase>();

	// Token: 0x04006F21 RID: 28449
	[Nullable(2)]
	private IHonamiStoryDragItemHoverInfo DragItemHoverInfo;

	// Token: 0x04006F22 RID: 28450
	private int HoverPosition = -1;

	// Token: 0x04006F23 RID: 28451
	private int LastViewportStartPosition = -1;

	// Token: 0x04006F24 RID: 28452
	private int LastViewportEndPosition = -1;

	// Token: 0x04006F25 RID: 28453
	private int CurViewportStartPosition = -1;

	// Token: 0x04006F26 RID: 28454
	private int CurViewportEndPosition = -1;

	// Token: 0x04006F27 RID: 28455
	private bool IsScrollUp;

	// Token: 0x04006F28 RID: 28456
	private int ScrollSpeed = 10;

	// Token: 0x04006F29 RID: 28457
	private readonly HashSet<int> GridCreateAsyncLock = new HashSet<int>();

	// Token: 0x02008449 RID: 33865
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402B0D5 RID: 176341
		Panel,
		// Token: 0x0402B0D6 RID: 176342
		SpriteMask,
		// Token: 0x0402B0D7 RID: 176343
		SpriteState,
		// Token: 0x0402B0D8 RID: 176344
		SpriteSelect
	}
}
