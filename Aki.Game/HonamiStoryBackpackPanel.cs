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

// Token: 0x02001E8D RID: 7821
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryBackpackPanel : HonamiStoryBackpackPanelBase
{
	// Token: 0x0600EF31 RID: 61233 RVA: 0x0039267C File Offset: 0x0039087C
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

	// Token: 0x0600EF32 RID: 61234 RVA: 0x003927FC File Offset: 0x003909FC
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

	// Token: 0x0600EF33 RID: 61235 RVA: 0x0039288E File Offset: 0x00390A8E
	protected override void OnBeforeShow()
	{
		this.AddEventListener();
	}

	// Token: 0x0600EF34 RID: 61236 RVA: 0x00392898 File Offset: 0x00390A98
	private void AddEventListener()
	{
		this.ScrollView.OnScrollValueChange.Bind(new Action<FVector2D>(this.OnScrollValueChange));
		EventSystem.Instance.Add<HonamiStoryBagUpdateContext>(EEventName.OnHonamiStoryBackpackUpdate, new Action<HonamiStoryBagUpdateContext>(this.OnHonamiStoryBackpackUpdate));
		EventSystem.Instance.Add(EEventName.OnHonamiStorySortSuccess, new Action(this.OnSortSuccess));
	}

	// Token: 0x0600EF35 RID: 61237 RVA: 0x003928FC File Offset: 0x00390AFC
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

	// Token: 0x0600EF36 RID: 61238 RVA: 0x00392948 File Offset: 0x00390B48
	private UniTask InitBottomButton()
	{
		HonamiStoryBackpackPanel.<InitBottomButton>d__30 <InitBottomButton>d__;
		<InitBottomButton>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBottomButton>d__.<>4__this = this;
		<InitBottomButton>d__.<>1__state = -1;
		<InitBottomButton>d__.<>t__builder.Start<HonamiStoryBackpackPanel.<InitBottomButton>d__30>(ref <InitBottomButton>d__);
		return <InitBottomButton>d__.<>t__builder.Task;
	}

	// Token: 0x0600EF37 RID: 61239 RVA: 0x0039298C File Offset: 0x00390B8C
	private UniTask UpdateViewportItems()
	{
		HonamiStoryBackpackPanel.<UpdateViewportItems>d__31 <UpdateViewportItems>d__;
		<UpdateViewportItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateViewportItems>d__.<>4__this = this;
		<UpdateViewportItems>d__.<>1__state = -1;
		<UpdateViewportItems>d__.<>t__builder.Start<HonamiStoryBackpackPanel.<UpdateViewportItems>d__31>(ref <UpdateViewportItems>d__);
		return <UpdateViewportItems>d__.<>t__builder.Task;
	}

	// Token: 0x0600EF38 RID: 61240 RVA: 0x003929D0 File Offset: 0x00390BD0
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

	// Token: 0x0600EF39 RID: 61241 RVA: 0x00392A2C File Offset: 0x00390C2C
	private UniTask UpdateWhenOverflowChange(int changeNum)
	{
		HonamiStoryBackpackPanel.<UpdateWhenOverflowChange>d__33 <UpdateWhenOverflowChange>d__;
		<UpdateWhenOverflowChange>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<UpdateWhenOverflowChange>d__.<>4__this = this;
		<UpdateWhenOverflowChange>d__.<>1__state = -1;
		<UpdateWhenOverflowChange>d__.<>t__builder.Start<HonamiStoryBackpackPanel.<UpdateWhenOverflowChange>d__33>(ref <UpdateWhenOverflowChange>d__);
		return <UpdateWhenOverflowChange>d__.<>t__builder.Task;
	}

	// Token: 0x0600EF3A RID: 61242 RVA: 0x00392A70 File Offset: 0x00390C70
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

	// Token: 0x0600EF3B RID: 61243 RVA: 0x00392AFC File Offset: 0x00390CFC
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

	// Token: 0x0600EF3C RID: 61244 RVA: 0x00392BA0 File Offset: 0x00390DA0
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

	// Token: 0x0600EF3D RID: 61245 RVA: 0x00392BEC File Offset: 0x00390DEC
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

	// Token: 0x0600EF3E RID: 61246 RVA: 0x00392C38 File Offset: 0x00390E38
	private void SetItemOffset(UUIItem item, int position)
	{
		int num = position / this.BackpackData.GetWidthCount();
		int num2 = position % this.BackpackData.GetWidthCount();
		int num3 = num2 * this.BackpackData.GetCellWidth() + (num2 + 1) * this.BackpackData.GetCellHorizontalInterval();
		int num4 = -num * this.BackpackData.GetCellHeight() - (num + 1) * this.BackpackData.GetCellVerticalInterval();
		item.SetAnchorOffsetX((float)num3);
		item.SetAnchorOffsetY((float)num4);
	}

	// Token: 0x0600EF3F RID: 61247 RVA: 0x00392CB0 File Offset: 0x00390EB0
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

	// Token: 0x0600EF40 RID: 61248 RVA: 0x00392D04 File Offset: 0x00390F04
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

	// Token: 0x0600EF41 RID: 61249 RVA: 0x00392D50 File Offset: 0x00390F50
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

	// Token: 0x0600EF42 RID: 61250 RVA: 0x00392D9C File Offset: 0x00390F9C
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

	// Token: 0x0600EF43 RID: 61251 RVA: 0x00392DE8 File Offset: 0x00390FE8
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

	// Token: 0x0600EF44 RID: 61252 RVA: 0x00392E34 File Offset: 0x00391034
	private UniTask FillEmptyGridInViewport()
	{
		HonamiStoryBackpackPanel.<FillEmptyGridInViewport>d__44 <FillEmptyGridInViewport>d__;
		<FillEmptyGridInViewport>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<FillEmptyGridInViewport>d__.<>4__this = this;
		<FillEmptyGridInViewport>d__.<>1__state = -1;
		<FillEmptyGridInViewport>d__.<>t__builder.Start<HonamiStoryBackpackPanel.<FillEmptyGridInViewport>d__44>(ref <FillEmptyGridInViewport>d__);
		return <FillEmptyGridInViewport>d__.<>t__builder.Task;
	}

	// Token: 0x0600EF45 RID: 61253 RVA: 0x00392E78 File Offset: 0x00391078
	private bool CheckItemInViewport(HonamiStoryGridItemBase item)
	{
		HonamiStoryItemDataBase data = item.GetData();
		return data != null && this.CheckItemDataInViewport(data);
	}

	// Token: 0x0600EF46 RID: 61254 RVA: 0x00392E98 File Offset: 0x00391098
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

	// Token: 0x0600EF47 RID: 61255 RVA: 0x00392EF4 File Offset: 0x003910F4
	private bool CheckPositionInViewport(int position)
	{
		return position >= this.CurViewportStartPosition && position <= this.CurViewportEndPosition;
	}

	// Token: 0x0600EF48 RID: 61256 RVA: 0x00392F0B File Offset: 0x0039110B
	protected override void OnBeforeHide()
	{
		this.RemoveEventListener();
	}

	// Token: 0x0600EF49 RID: 61257 RVA: 0x00392F14 File Offset: 0x00391114
	private void RemoveEventListener()
	{
		this.ScrollView.OnScrollValueChange.Unbind();
		EventSystem.Instance.Remove<HonamiStoryBagUpdateContext>(EEventName.OnHonamiStoryBackpackUpdate, new Action<HonamiStoryBagUpdateContext>(this.OnHonamiStoryBackpackUpdate));
		EventSystem.Instance.Remove(EEventName.OnHonamiStorySortSuccess, new Action(this.OnSortSuccess));
	}

	// Token: 0x0600EF4A RID: 61258 RVA: 0x00392F6C File Offset: 0x0039116C
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

	// Token: 0x0600EF4B RID: 61259 RVA: 0x00392FBF File Offset: 0x003911BF
	private void OnScrollValueChange(FVector2D inVector)
	{
		HonamiStoryModel.Instance.GetInteractController().RefreshSelectedUiItem();
		this.UpdateViewportItems();
	}

	// Token: 0x0600EF4C RID: 61260 RVA: 0x00392FD7 File Offset: 0x003911D7
	public override int GetBackpackType()
	{
		return (int)this.BackpackData.BackpackType;
	}

	// Token: 0x0600EF4D RID: 61261 RVA: 0x00392FE4 File Offset: 0x003911E4
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

	// Token: 0x0600EF4E RID: 61262 RVA: 0x00393039 File Offset: 0x00391239
	public override void OnHoverEnd()
	{
		this.HoverPosition = -1;
		this.DragItemHoverInfo = null;
		this.RefreshScrollMoveState(null);
		this.RefreshHoverTip(null);
	}

	// Token: 0x0600EF4F RID: 61263 RVA: 0x00393057 File Offset: 0x00391257
	public override bool OnDragBegin([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		HonamiStoryItemDataBase data = item.GetData();
		this.CurMaskingItemIncId = ((data != null) ? data.GetIncId() : -1);
		this.RefreshMask(item.GetData());
		this.RefreshScrollMoveState(null);
		return base.OnDragBegin(eventData, item);
	}

	// Token: 0x0600EF50 RID: 61264 RVA: 0x0039308C File Offset: 0x0039128C
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

	// Token: 0x0600EF51 RID: 61265 RVA: 0x003930C5 File Offset: 0x003912C5
	public override void OnDragEnd([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.CurMaskingItemIncId = -1;
		this.RefreshMask(null);
		base.OnDragEnd(eventData, item);
		this.RefreshScrollMoveState(null);
	}

	// Token: 0x0600EF52 RID: 61266 RVA: 0x003930E4 File Offset: 0x003912E4
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

	// Token: 0x0600EF53 RID: 61267 RVA: 0x003931EC File Offset: 0x003913EC
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

	// Token: 0x0600EF54 RID: 61268 RVA: 0x00393288 File Offset: 0x00391488
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

	// Token: 0x0600EF55 RID: 61269 RVA: 0x0039349C File Offset: 0x0039169C
	private int GetExchangeItemPosition(IHonamiStoryDragItemHoverInfo hoverInfo, int itemPosition, int position, HonamiStoryItemDataBase oriItemData, HonamiStoryItemDataBase otherData)
	{
		if (oriItemData.GetIsCross() == oriItemData.GetIsDragCross())
		{
			return this.GetExchangeItemPositionNoCrossChange(hoverInfo, itemPosition, position, otherData);
		}
		return this.GetExchangeItemPositionCrossChange(hoverInfo, itemPosition, position, oriItemData, otherData);
	}

	// Token: 0x0600EF56 RID: 61270 RVA: 0x003934C8 File Offset: 0x003916C8
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

	// Token: 0x0600EF57 RID: 61271 RVA: 0x003935C0 File Offset: 0x003917C0
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

	// Token: 0x0600EF58 RID: 61272 RVA: 0x00393640 File Offset: 0x00391840
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

	// Token: 0x0600EF59 RID: 61273 RVA: 0x00393804 File Offset: 0x00391A04
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

	// Token: 0x0600EF5A RID: 61274 RVA: 0x003938AC File Offset: 0x00391AAC
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

	// Token: 0x0600EF5B RID: 61275 RVA: 0x00393950 File Offset: 0x00391B50
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

	// Token: 0x0600EF5C RID: 61276 RVA: 0x00393BA0 File Offset: 0x00391DA0
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

	// Token: 0x0600EF5D RID: 61277 RVA: 0x00393CC0 File Offset: 0x00391EC0
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

	// Token: 0x0600EF5E RID: 61278 RVA: 0x00393D0C File Offset: 0x00391F0C
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

	// Token: 0x0600EF5F RID: 61279 RVA: 0x00393E74 File Offset: 0x00392074
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

	// Token: 0x0600EF60 RID: 61280 RVA: 0x00393F58 File Offset: 0x00392158
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

	// Token: 0x0600EF61 RID: 61281 RVA: 0x00393FC8 File Offset: 0x003921C8
	private void OnSortSuccess()
	{
		this.ScrollView.StopMovement();
		FVector2D fvector2D = new FVector2D();
		this.ScrollView.ScrollToTop(ref fvector2D, this.ContentItem, true);
	}

	// Token: 0x0600EF62 RID: 61282 RVA: 0x00393FFC File Offset: 0x003921FC
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

	// Token: 0x0600EF63 RID: 61283 RVA: 0x003940A8 File Offset: 0x003922A8
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

	// Token: 0x0600EF64 RID: 61284 RVA: 0x00394118 File Offset: 0x00392318
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

	// Token: 0x0600EF65 RID: 61285 RVA: 0x003941A4 File Offset: 0x003923A4
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

	// Token: 0x0600EF66 RID: 61286 RVA: 0x003941F8 File Offset: 0x003923F8
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

	// Token: 0x0600EF67 RID: 61287 RVA: 0x00394284 File Offset: 0x00392484
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

	// Token: 0x0600EF68 RID: 61288 RVA: 0x00394354 File Offset: 0x00392554
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

	// Token: 0x0600EF69 RID: 61289 RVA: 0x00394418 File Offset: 0x00392618
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

	// Token: 0x0600EF6A RID: 61290 RVA: 0x00394474 File Offset: 0x00392674
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

	// Token: 0x0600EF6B RID: 61291 RVA: 0x003944E0 File Offset: 0x003926E0
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

	// Token: 0x0600EF6C RID: 61292 RVA: 0x0039452C File Offset: 0x0039272C
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

	// Token: 0x0600EF6D RID: 61293 RVA: 0x00394578 File Offset: 0x00392778
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

	// Token: 0x0600EF6E RID: 61294 RVA: 0x00394658 File Offset: 0x00392858
	public override bool CheckPositionValidGamepad(int position)
	{
		return this.CheckPositionInViewport(position);
	}

	// Token: 0x0600EF6F RID: 61295 RVA: 0x00394664 File Offset: 0x00392864
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

	// Token: 0x0600EF70 RID: 61296 RVA: 0x003946AC File Offset: 0x003928AC
	public override void OnScrollValueChangedGamepad(bool isUp)
	{
		FVector location = this.ContentItem.GetRelativeTransform().GetLocation();
		int num = (isUp ? (-this.ScrollSpeed) : this.ScrollSpeed) * 15;
		float inY = Math.Max(0f, location.Y + (float)num);
		this.ScrollView.SetScrollValue(new FVector2D(0f, inY));
	}

	// Token: 0x0600EF71 RID: 61297 RVA: 0x00394710 File Offset: 0x00392910
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

	// Token: 0x0600EF72 RID: 61298 RVA: 0x00394794 File Offset: 0x00392994
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

	// Token: 0x0600EF73 RID: 61299 RVA: 0x00394964 File Offset: 0x00392B64
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

	// Token: 0x0600EF74 RID: 61300 RVA: 0x00394AD8 File Offset: 0x00392CD8
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

	// Token: 0x0600EF75 RID: 61301 RVA: 0x00394B80 File Offset: 0x00392D80
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

	// Token: 0x0600EF76 RID: 61302 RVA: 0x00394C24 File Offset: 0x00392E24
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

	// Token: 0x04006ECE RID: 28366
	private const int CONTENT_SMALL_OFFSET = 112;

	// Token: 0x04006ECF RID: 28367
	private const int CONTENT_FOR_SAFE = 6;

	// Token: 0x04006ED0 RID: 28368
	private HonamiStoryBackpackData BackpackData;

	// Token: 0x04006ED1 RID: 28369
	private UUIScrollViewWithScrollbarComponent ScrollView;

	// Token: 0x04006ED2 RID: 28370
	private UUIItem ViewportItem;

	// Token: 0x04006ED3 RID: 28371
	private UUIItem ContentItem;

	// Token: 0x04006ED4 RID: 28372
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Dictionary<int, HonamiStoryGridItemBase> BackpackItemMap = new Dictionary<int, HonamiStoryGridItemBase>();

	// Token: 0x04006ED5 RID: 28373
	private readonly HashSet<HonamiStoryGridItemBase> BackpackItemPool = new HashSet<HonamiStoryGridItemBase>();

	// Token: 0x04006ED6 RID: 28374
	[Nullable(2)]
	private IHonamiStoryDragItemHoverInfo DragItemHoverInfo;

	// Token: 0x04006ED7 RID: 28375
	private int HoverPosition = -1;

	// Token: 0x04006ED8 RID: 28376
	private float ViewportHeight;

	// Token: 0x04006ED9 RID: 28377
	private int LastViewportStartPosition = -1;

	// Token: 0x04006EDA RID: 28378
	private int LastViewportEndPosition = -1;

	// Token: 0x04006EDB RID: 28379
	private int CurViewportStartPosition = -1;

	// Token: 0x04006EDC RID: 28380
	private int CurViewportEndPosition = -1;

	// Token: 0x04006EDD RID: 28381
	[Nullable(2)]
	private ButtonItem ButtonSell;

	// Token: 0x04006EDE RID: 28382
	[Nullable(2)]
	private ButtonItem ButtonRight;

	// Token: 0x04006EDF RID: 28383
	[Nullable(2)]
	private HonamiStoryBackpackValueCountItem CurrentValueItem;

	// Token: 0x04006EE0 RID: 28384
	[Nullable(2)]
	private HonamiStoryBackpackTitleItem TitlePanel;

	// Token: 0x04006EE1 RID: 28385
	private bool IsScrollUp;

	// Token: 0x04006EE2 RID: 28386
	private int ScrollSpeed = 10;

	// Token: 0x04006EE3 RID: 28387
	private int CurMaskingItemIncId = -1;

	// Token: 0x04006EE4 RID: 28388
	private readonly HashSet<int> GridCreateAsyncLock = new HashSet<int>();

	// Token: 0x04006EE5 RID: 28389
	[Nullable(2)]
	private UiPanelBase OverflowBottomItem;

	// Token: 0x02008430 RID: 33840
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B02E RID: 176174
		TitleItem,
		// Token: 0x0402B02F RID: 176175
		GridBG,
		// Token: 0x0402B030 RID: 176176
		ScrollView,
		// Token: 0x0402B031 RID: 176177
		ViewportItem,
		// Token: 0x0402B032 RID: 176178
		ContentItem,
		// Token: 0x0402B033 RID: 176179
		SpriteHoverMask,
		// Token: 0x0402B034 RID: 176180
		SpriteHoverGridState,
		// Token: 0x0402B035 RID: 176181
		SpriteSelect,
		// Token: 0x0402B036 RID: 176182
		BtnLeft,
		// Token: 0x0402B037 RID: 176183
		BtnRight,
		// Token: 0x0402B038 RID: 176184
		ValueItem,
		// Token: 0x0402B039 RID: 176185
		PanelButton,
		// Token: 0x0402B03A RID: 176186
		PanelGoTop,
		// Token: 0x0402B03B RID: 176187
		PanelGoDown,
		// Token: 0x0402B03C RID: 176188
		PanelSelf,
		// Token: 0x0402B03D RID: 176189
		PanelGrid
	}
}
