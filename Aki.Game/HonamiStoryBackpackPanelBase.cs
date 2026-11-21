using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001350 RID: 4944
[NullableContext(1)]
[Nullable(0)]
public abstract class HonamiStoryBackpackPanelBase : UiPanelBase
{
	// Token: 0x0600C397 RID: 50071 RVA: 0x003A0A92 File Offset: 0x0039EC92
	[NullableContext(2)]
	protected void OnEnterItem(HonamiStoryItemGridItem item)
	{
		if (this.OnEnterGridCb != null)
		{
			this.OnEnterGridCb(item, (EHonamiStoryBackpackType)this.GetBackpackType());
		}
	}

	// Token: 0x0600C398 RID: 50072 RVA: 0x003A0AAE File Offset: 0x0039ECAE
	protected void OnExitItem()
	{
		Action onExitGridCb = this.OnExitGridCb;
		if (onExitGridCb == null)
		{
			return;
		}
		onExitGridCb();
	}

	// Token: 0x0600C399 RID: 50073 RVA: 0x003A0AC0 File Offset: 0x0039ECC0
	protected void OnDownItem()
	{
		Action onDownGridCb = this.OnDownGridCb;
		if (onDownGridCb == null)
		{
			return;
		}
		onDownGridCb();
	}

	// Token: 0x0600C39A RID: 50074 RVA: 0x003A0AD2 File Offset: 0x0039ECD2
	protected void OnClickItem([Nullable(2)] HonamiStoryItemGridItem item, Vector2D loc, Vector2D size)
	{
		if (this.OnClickedGridCb != null)
		{
			this.OnClickedGridCb(item, loc, size, (EHonamiStoryBackpackType)this.GetBackpackType());
		}
	}

	// Token: 0x0600C39B RID: 50075 RVA: 0x003A0AF0 File Offset: 0x0039ECF0
	protected void OnCheckAttrItem([Nullable(2)] HonamiStoryEquipGridItem item, HonamiStoryInteractOperateAgent operateAgent)
	{
		Action<HonamiStoryEquipGridItem, HonamiStoryInteractOperateAgent> onCheckAttrGridCb = this.OnCheckAttrGridCb;
		if (onCheckAttrGridCb == null)
		{
			return;
		}
		onCheckAttrGridCb(item, operateAgent);
	}

	// Token: 0x0600C39C RID: 50076 RVA: 0x003A0B04 File Offset: 0x0039ED04
	public void RegisterDragController(HonamiStoryInteractController controller)
	{
		this.InteractController = controller;
	}

	// Token: 0x0600C39D RID: 50077
	public abstract int GetBackpackType();

	// Token: 0x0600C39E RID: 50078 RVA: 0x003A0B0D File Offset: 0x0039ED0D
	public virtual bool OnDragBegin([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.InteractController.DragBegin(this, item);
		return true;
	}

	// Token: 0x0600C39F RID: 50079 RVA: 0x003A0B1E File Offset: 0x0039ED1E
	public virtual bool OnDrag([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.InteractController.OnDrag(eventData);
		return true;
	}

	// Token: 0x0600C3A0 RID: 50080 RVA: 0x003A0B2D File Offset: 0x0039ED2D
	public virtual void OnDragEnd([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.InteractController.DragEnd(eventData, item);
	}

	// Token: 0x0600C3A1 RID: 50081 RVA: 0x003A0B3C File Offset: 0x0039ED3C
	public virtual void RefreshSingleItem(HonamiStoryItemDataBase itemData)
	{
	}

	// Token: 0x0600C3A2 RID: 50082
	public abstract void OnHover(ULGUIPointerEventData eventData, HonamiStoryInteractOperateAgent operateAgent);

	// Token: 0x0600C3A3 RID: 50083
	public abstract void OnHoverEnd();

	// Token: 0x0600C3A4 RID: 50084
	public abstract bool CheckDragItemInViewport(ULGUIPointerEventData eventData);

	// Token: 0x0600C3A5 RID: 50085
	[return: Nullable(2)]
	public abstract HonamiStoryBagUpdateContext GetUpdateInfoInSameBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase item);

	// Token: 0x0600C3A6 RID: 50086
	[return: Nullable(2)]
	public abstract HonamiStoryBagUpdateContext GetUpdateInfoInSendBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateItem, HashSet<HonamiStoryItemDataBase> exchangeItemSet);

	// Token: 0x0600C3A7 RID: 50087
	[return: Nullable(2)]
	public abstract HonamiStoryBagUpdateContext GetUpdateInfoInReceiveBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateItem, HashSet<HonamiStoryItemDataBase> exchangeItemSet);

	// Token: 0x0600C3A8 RID: 50088
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public abstract HashSet<HonamiStoryItemDataBase> GetExchangeItemSet(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateItem);

	// Token: 0x0600C3A9 RID: 50089
	public abstract void OnBackpackLogicStateChange(EHonamiStoryBackpackLogicState state);

	// Token: 0x0600C3AA RID: 50090
	public abstract List<HonamiStoryGridItemBase> GetUpdateContextEffectGridItems(HonamiStoryBagUpdateContext updateContext);

	// Token: 0x0600C3AB RID: 50091 RVA: 0x003A0B3E File Offset: 0x0039ED3E
	public virtual List<HonamiStoryGridItemBase> GetCurrentGridListGamepad()
	{
		return new List<HonamiStoryGridItemBase>();
	}

	// Token: 0x0600C3AC RID: 50092 RVA: 0x003A0B45 File Offset: 0x0039ED45
	public virtual bool CheckPositionValidGamepad(int position)
	{
		return false;
	}

	// Token: 0x0600C3AD RID: 50093 RVA: 0x003A0B48 File Offset: 0x0039ED48
	public virtual void OnScrollValueChangedGamepad(bool isUp)
	{
	}

	// Token: 0x0600C3AE RID: 50094 RVA: 0x003A0B4A File Offset: 0x0039ED4A
	public virtual void OnScrollToTopOrBottomGamepad(bool toTop)
	{
	}

	// Token: 0x0600C3AF RID: 50095 RVA: 0x003A0B4C File Offset: 0x0039ED4C
	public virtual void OnHoverGamepad(HonamiStoryGridItemBase item, int position, HonamiStoryInteractOperateAgent operateAgent)
	{
	}

	// Token: 0x0600C3B0 RID: 50096 RVA: 0x003A0B4E File Offset: 0x0039ED4E
	[return: Nullable(2)]
	public virtual HonamiStoryBagUpdateContext GetUpdateInfoInSameBackpackGamepad(HonamiStoryGridItemBase gridItem, HonamiStoryItemDataBase item)
	{
		return null;
	}

	// Token: 0x0600C3B1 RID: 50097 RVA: 0x003A0B51 File Offset: 0x0039ED51
	[return: Nullable(2)]
	public virtual HonamiStoryBagUpdateContext GetUpdateInfoInSendBackpackGamepad(HonamiStoryGridItemBase gridItem, HonamiStoryItemDataBase operateItem, HashSet<HonamiStoryItemDataBase> exchangeItemSet)
	{
		return null;
	}

	// Token: 0x0600C3B2 RID: 50098 RVA: 0x003A0B54 File Offset: 0x0039ED54
	[return: Nullable(2)]
	public virtual HonamiStoryBagUpdateContext GetUpdateInfoInReceiveBackpackGamepad(HonamiStoryGridItemBase gridItem, HonamiStoryItemDataBase operateItem, HashSet<HonamiStoryItemDataBase> exchangeItemSet)
	{
		return null;
	}

	// Token: 0x0600C3B3 RID: 50099 RVA: 0x003A0B57 File Offset: 0x0039ED57
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public virtual HashSet<HonamiStoryItemDataBase> GetExchangeItemSetGamepad(HonamiStoryGridItemBase gridItem, HonamiStoryItemDataBase operateItem)
	{
		return null;
	}

	// Token: 0x04006FC7 RID: 28615
	[Nullable(2)]
	public Action<HonamiStoryItemGridItem, EHonamiStoryBackpackType> OnEnterGridCb;

	// Token: 0x04006FC8 RID: 28616
	[Nullable(2)]
	public Action OnExitGridCb;

	// Token: 0x04006FC9 RID: 28617
	[Nullable(2)]
	public Action OnDownGridCb;

	// Token: 0x04006FCA RID: 28618
	[Nullable(new byte[]
	{
		2,
		2,
		1
	})]
	public Action<HonamiStoryEquipGridItem, HonamiStoryInteractOperateAgent> OnCheckAttrGridCb;

	// Token: 0x04006FCB RID: 28619
	[Nullable(new byte[]
	{
		2,
		2,
		1,
		1
	})]
	public Action<HonamiStoryItemGridItem, Vector2D, Vector2D, EHonamiStoryBackpackType> OnClickedGridCb;

	// Token: 0x04006FCC RID: 28620
	protected HonamiStoryInteractController InteractController;
}
