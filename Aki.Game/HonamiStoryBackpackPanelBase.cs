using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E8E RID: 7822
[NullableContext(1)]
[Nullable(0)]
public abstract class HonamiStoryBackpackPanelBase : UiPanelBase
{
	// Token: 0x0600EF78 RID: 61304 RVA: 0x00394ED6 File Offset: 0x003930D6
	[NullableContext(2)]
	protected void OnEnterItem(HonamiStoryItemGridItem item)
	{
		if (this.OnEnterGridCb != null)
		{
			this.OnEnterGridCb(item, (EHonamiStoryBackpackType)this.GetBackpackType());
		}
	}

	// Token: 0x0600EF79 RID: 61305 RVA: 0x00394EF2 File Offset: 0x003930F2
	protected void OnExitItem()
	{
		Action onExitGridCb = this.OnExitGridCb;
		if (onExitGridCb == null)
		{
			return;
		}
		onExitGridCb();
	}

	// Token: 0x0600EF7A RID: 61306 RVA: 0x00394F04 File Offset: 0x00393104
	protected void OnDownItem()
	{
		Action onDownGridCb = this.OnDownGridCb;
		if (onDownGridCb == null)
		{
			return;
		}
		onDownGridCb();
	}

	// Token: 0x0600EF7B RID: 61307 RVA: 0x00394F16 File Offset: 0x00393116
	protected void OnClickItem([Nullable(2)] HonamiStoryItemGridItem item, Vector2D loc, Vector2D size)
	{
		if (this.OnClickedGridCb != null)
		{
			this.OnClickedGridCb(item, loc, size, (EHonamiStoryBackpackType)this.GetBackpackType());
		}
	}

	// Token: 0x0600EF7C RID: 61308 RVA: 0x00394F34 File Offset: 0x00393134
	protected void OnCheckAttrItem([Nullable(2)] HonamiStoryEquipGridItem item, HonamiStoryInteractOperateAgent operateAgent)
	{
		Action<HonamiStoryEquipGridItem, HonamiStoryInteractOperateAgent> onCheckAttrGridCb = this.OnCheckAttrGridCb;
		if (onCheckAttrGridCb == null)
		{
			return;
		}
		onCheckAttrGridCb(item, operateAgent);
	}

	// Token: 0x0600EF7D RID: 61309 RVA: 0x00394F48 File Offset: 0x00393148
	public void RegisterDragController(HonamiStoryInteractController controller)
	{
		this.InteractController = controller;
	}

	// Token: 0x0600EF7E RID: 61310
	public abstract int GetBackpackType();

	// Token: 0x0600EF7F RID: 61311 RVA: 0x00394F51 File Offset: 0x00393151
	public virtual bool OnDragBegin([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.InteractController.DragBegin(this, item);
		return true;
	}

	// Token: 0x0600EF80 RID: 61312 RVA: 0x00394F62 File Offset: 0x00393162
	public virtual bool OnDrag([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.InteractController.OnDrag(eventData);
		return true;
	}

	// Token: 0x0600EF81 RID: 61313 RVA: 0x00394F71 File Offset: 0x00393171
	public virtual void OnDragEnd([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.InteractController.DragEnd(eventData, item);
	}

	// Token: 0x0600EF82 RID: 61314 RVA: 0x00394F80 File Offset: 0x00393180
	public virtual void RefreshSingleItem(HonamiStoryItemDataBase itemData)
	{
	}

	// Token: 0x0600EF83 RID: 61315
	public abstract void OnHover(ULGUIPointerEventData eventData, HonamiStoryInteractOperateAgent operateAgent);

	// Token: 0x0600EF84 RID: 61316
	public abstract void OnHoverEnd();

	// Token: 0x0600EF85 RID: 61317
	public abstract bool CheckDragItemInViewport(ULGUIPointerEventData eventData);

	// Token: 0x0600EF86 RID: 61318
	[return: Nullable(2)]
	public abstract HonamiStoryBagUpdateContext GetUpdateInfoInSameBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase item);

	// Token: 0x0600EF87 RID: 61319
	[return: Nullable(2)]
	public abstract HonamiStoryBagUpdateContext GetUpdateInfoInSendBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateItem, HashSet<HonamiStoryItemDataBase> exchangeItemSet);

	// Token: 0x0600EF88 RID: 61320
	[return: Nullable(2)]
	public abstract HonamiStoryBagUpdateContext GetUpdateInfoInReceiveBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateItem, HashSet<HonamiStoryItemDataBase> exchangeItemSet);

	// Token: 0x0600EF89 RID: 61321
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public abstract HashSet<HonamiStoryItemDataBase> GetExchangeItemSet(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateItem);

	// Token: 0x0600EF8A RID: 61322
	public abstract void OnBackpackLogicStateChange(EHonamiStoryBackpackLogicState state);

	// Token: 0x0600EF8B RID: 61323
	public abstract List<HonamiStoryGridItemBase> GetUpdateContextEffectGridItems(HonamiStoryBagUpdateContext updateContext);

	// Token: 0x0600EF8C RID: 61324 RVA: 0x00394F82 File Offset: 0x00393182
	public virtual List<HonamiStoryGridItemBase> GetCurrentGridListGamepad()
	{
		return new List<HonamiStoryGridItemBase>();
	}

	// Token: 0x0600EF8D RID: 61325 RVA: 0x00394F89 File Offset: 0x00393189
	public virtual bool CheckPositionValidGamepad(int position)
	{
		return false;
	}

	// Token: 0x0600EF8E RID: 61326 RVA: 0x00394F8C File Offset: 0x0039318C
	public virtual void OnScrollValueChangedGamepad(bool isUp)
	{
	}

	// Token: 0x0600EF8F RID: 61327 RVA: 0x00394F8E File Offset: 0x0039318E
	public virtual void OnScrollToTopOrBottomGamepad(bool toTop)
	{
	}

	// Token: 0x0600EF90 RID: 61328 RVA: 0x00394F90 File Offset: 0x00393190
	public virtual void OnHoverGamepad(HonamiStoryGridItemBase item, int position, HonamiStoryInteractOperateAgent operateAgent)
	{
	}

	// Token: 0x0600EF91 RID: 61329 RVA: 0x00394F92 File Offset: 0x00393192
	[return: Nullable(2)]
	public virtual HonamiStoryBagUpdateContext GetUpdateInfoInSameBackpackGamepad(HonamiStoryGridItemBase gridItem, HonamiStoryItemDataBase item)
	{
		return null;
	}

	// Token: 0x0600EF92 RID: 61330 RVA: 0x00394F95 File Offset: 0x00393195
	[return: Nullable(2)]
	public virtual HonamiStoryBagUpdateContext GetUpdateInfoInSendBackpackGamepad(HonamiStoryGridItemBase gridItem, HonamiStoryItemDataBase operateItem, HashSet<HonamiStoryItemDataBase> exchangeItemSet)
	{
		return null;
	}

	// Token: 0x0600EF93 RID: 61331 RVA: 0x00394F98 File Offset: 0x00393198
	[return: Nullable(2)]
	public virtual HonamiStoryBagUpdateContext GetUpdateInfoInReceiveBackpackGamepad(HonamiStoryGridItemBase gridItem, HonamiStoryItemDataBase operateItem, HashSet<HonamiStoryItemDataBase> exchangeItemSet)
	{
		return null;
	}

	// Token: 0x0600EF94 RID: 61332 RVA: 0x00394F9B File Offset: 0x0039319B
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public virtual HashSet<HonamiStoryItemDataBase> GetExchangeItemSetGamepad(HonamiStoryGridItemBase gridItem, HonamiStoryItemDataBase operateItem)
	{
		return null;
	}

	// Token: 0x04006EE6 RID: 28390
	[Nullable(2)]
	public Action<HonamiStoryItemGridItem, EHonamiStoryBackpackType> OnEnterGridCb;

	// Token: 0x04006EE7 RID: 28391
	[Nullable(2)]
	public Action OnExitGridCb;

	// Token: 0x04006EE8 RID: 28392
	[Nullable(2)]
	public Action OnDownGridCb;

	// Token: 0x04006EE9 RID: 28393
	[Nullable(new byte[]
	{
		2,
		2,
		1
	})]
	public Action<HonamiStoryEquipGridItem, HonamiStoryInteractOperateAgent> OnCheckAttrGridCb;

	// Token: 0x04006EEA RID: 28394
	[Nullable(new byte[]
	{
		2,
		2,
		1,
		1
	})]
	public Action<HonamiStoryItemGridItem, Vector2D, Vector2D, EHonamiStoryBackpackType> OnClickedGridCb;

	// Token: 0x04006EEB RID: 28395
	protected HonamiStoryInteractController InteractController;
}
