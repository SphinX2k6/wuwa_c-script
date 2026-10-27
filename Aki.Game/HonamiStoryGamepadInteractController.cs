using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001E93 RID: 7827
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryGamepadInteractController
{
	// Token: 0x0600EFE7 RID: 61415 RVA: 0x00396C6B File Offset: 0x00394E6B
	public void RegisterPanel(HonamiStoryBackpackPanelBase panel)
	{
		this.PanelBaseList.Add(panel);
	}

	// Token: 0x0600EFE8 RID: 61416 RVA: 0x00396C79 File Offset: 0x00394E79
	public void ClearPanel()
	{
		this.PanelBaseList.Clear();
	}

	// Token: 0x170012DA RID: 4826
	// (get) Token: 0x0600EFE9 RID: 61417 RVA: 0x00396C86 File Offset: 0x00394E86
	[Nullable(2)]
	private HonamiStoryGamepadLogicController Logic
	{
		[NullableContext(2)]
		get
		{
			return HonamiStoryModel.Instance.GetGamepadLogic();
		}
	}

	// Token: 0x0600EFEA RID: 61418 RVA: 0x00396C94 File Offset: 0x00394E94
	public bool CheckOverflowByLeftOrRight(int position, HonamiStoryGridItemBase item, int backpackWidth, int offset)
	{
		int num = position % backpackWidth;
		int num2 = 0;
		HonamiStoryItemDataBase data = item.GetData();
		if (data != null)
		{
			num2 = data.GetGridWidth();
		}
		bool flag = num + (num2 - 1) + offset > backpackWidth;
		return num + offset < 0 || flag;
	}

	// Token: 0x0600EFEB RID: 61419 RVA: 0x00396CCB File Offset: 0x00394ECB
	public bool HasFallingPile()
	{
		return this.PanelBaseList.Count > 2;
	}

	// Token: 0x0600EFEC RID: 61420 RVA: 0x00396CDC File Offset: 0x00394EDC
	[NullableContext(2)]
	private HonamiStoryBackpackData GetBackpackData(int backpackType)
	{
		EHonamiStoryBackpack backpackId;
		if (HonamiStoryDefine.Instance.HonamiBackpackTypeMap.TryGetValue((EHonamiStoryBackpackType)backpackType, out backpackId))
		{
			return HonamiStoryModel.Instance.GetBackPackData((int)backpackId, false);
		}
		return null;
	}

	// Token: 0x0600EFED RID: 61421 RVA: 0x00396D0C File Offset: 0x00394F0C
	public int GetBackpackCapacity(int backpackType)
	{
		int result = 0;
		HonamiStoryBackpackData backpackData = this.GetBackpackData(backpackType);
		if (backpackData != null)
		{
			result = backpackData.GetCapacity();
		}
		return result;
	}

	// Token: 0x0600EFEE RID: 61422 RVA: 0x00396D30 File Offset: 0x00394F30
	public int GetBackpackWidth(int backpackType)
	{
		int result = 0;
		HonamiStoryBackpackData backpackData = this.GetBackpackData(backpackType);
		if (backpackData != null)
		{
			result = backpackData.GetWidthCount();
		}
		return result;
	}

	// Token: 0x0600EFEF RID: 61423 RVA: 0x00396D52 File Offset: 0x00394F52
	private int GetColumn(int startPosition, int backpackWidth)
	{
		return startPosition / backpackWidth;
	}

	// Token: 0x0600EFF0 RID: 61424 RVA: 0x00396D57 File Offset: 0x00394F57
	private int GetRow(int startPosition, int backpackWidth)
	{
		return startPosition % backpackWidth;
	}

	// Token: 0x0600EFF1 RID: 61425 RVA: 0x00396D5C File Offset: 0x00394F5C
	private int GetGridCenterPositionByParam(int startPosition, int itemWidth, int itemHeight, int backpackWidth)
	{
		int row = this.GetRow(startPosition, backpackWidth);
		int column = this.GetColumn(startPosition, backpackWidth);
		int num;
		int num2;
		if (itemWidth == 1 && itemHeight == 1)
		{
			num = row;
			num2 = column;
		}
		else if (itemWidth % 2 == 1 && itemHeight % 2 == 1)
		{
			int num3 = itemHeight / 2;
			int num4 = itemWidth / 2;
			num = row + num3;
			num2 = column + num4;
		}
		else if (itemWidth % 2 == 0 && itemHeight % 2 == 0)
		{
			num = row + itemHeight - 1;
			num2 = column + itemWidth - 1;
		}
		else if (itemWidth % 2 == 1 && itemHeight % 2 == 0)
		{
			int num5 = itemWidth / 2;
			num = row + itemHeight - 1;
			num2 = column + num5;
		}
		else if (itemWidth % 2 == 0 && itemHeight % 2 == 1)
		{
			int num6 = itemHeight / 2;
			num = row + num6;
			num2 = column + itemWidth - 1;
		}
		else
		{
			num = row;
			num2 = column;
		}
		return num2 * backpackWidth + num;
	}

	// Token: 0x0600EFF2 RID: 61426 RVA: 0x00396E10 File Offset: 0x00395010
	private int GetGridCenterPosition(HonamiStoryGridItemBase item, int backpackWidth)
	{
		int startPosition = 0;
		int itemWidth = 0;
		int itemHeight = 0;
		HonamiStoryItemDataBase data = item.GetData();
		if (data != null)
		{
			startPosition = data.GetPosition();
			itemWidth = data.GetGridWidth();
			itemHeight = data.GetGridHeight();
		}
		return this.GetGridCenterPositionByParam(startPosition, itemWidth, itemHeight, backpackWidth);
	}

	// Token: 0x0600EFF3 RID: 61427 RVA: 0x00396E4C File Offset: 0x0039504C
	public List<HonamiStoryGridItemBase> GetGridItemListByBackpackType(int backpackType)
	{
		List<HonamiStoryGridItemBase> result = new List<HonamiStoryGridItemBase>();
		foreach (HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase in this.PanelBaseList)
		{
			if (honamiStoryBackpackPanelBase.GetBackpackType() == backpackType)
			{
				result = honamiStoryBackpackPanelBase.GetCurrentGridListGamepad();
				break;
			}
		}
		return result;
	}

	// Token: 0x0600EFF4 RID: 61428 RVA: 0x00396EB4 File Offset: 0x003950B4
	[NullableContext(2)]
	public HonamiStoryGridItemBase GetGridItemByPosition(int position, int backpackType)
	{
		foreach (HonamiStoryGridItemBase honamiStoryGridItemBase in this.GetGridItemListByBackpackType(backpackType))
		{
			HonamiStoryItemDataBase data = honamiStoryGridItemBase.GetData();
			if (data != null)
			{
				if (data.GetPosition() == position || data.GetGridFillPositionList().Contains(position))
				{
					return honamiStoryGridItemBase;
				}
			}
			else if (honamiStoryGridItemBase.GetEmptyPosition() == position)
			{
				return honamiStoryGridItemBase;
			}
		}
		return null;
	}

	// Token: 0x0600EFF5 RID: 61429 RVA: 0x00396F38 File Offset: 0x00395138
	[NullableContext(2)]
	public HonamiStoryBackpackPanelBase GetPanelByBackpackType(int backpackType)
	{
		HonamiStoryBackpackPanelBase result = null;
		foreach (HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase in this.PanelBaseList)
		{
			if (honamiStoryBackpackPanelBase.GetBackpackType() == backpackType)
			{
				result = honamiStoryBackpackPanelBase;
				break;
			}
		}
		return result;
	}

	// Token: 0x0600EFF6 RID: 61430 RVA: 0x00396F94 File Offset: 0x00395194
	[return: Nullable(2)]
	public HonamiStoryBackpackPanelBase GetPanelByGridItem(HonamiStoryGridItemBase gridItem)
	{
		HonamiStoryBackpackPanelBase result = null;
		foreach (HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase in this.PanelBaseList)
		{
			using (List<HonamiStoryGridItemBase>.Enumerator enumerator2 = honamiStoryBackpackPanelBase.GetCurrentGridListGamepad().GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current == gridItem)
					{
						result = honamiStoryBackpackPanelBase;
						break;
					}
				}
			}
		}
		return result;
	}

	// Token: 0x0600EFF7 RID: 61431 RVA: 0x00397024 File Offset: 0x00395224
	public int GetPanelIndexByGridItem(HonamiStoryGridItemBase gridItem)
	{
		int result = 0;
		HonamiStoryBackpackPanelBase panelByGridItem = this.GetPanelByGridItem(gridItem);
		if (panelByGridItem != null)
		{
			switch (panelByGridItem.GetBackpackType())
			{
			case 0:
			case 1:
				result = 2;
				break;
			case 2:
				result = 3;
				break;
			case 3:
				result = 1;
				break;
			}
		}
		return result;
	}

	// Token: 0x0600EFF8 RID: 61432 RVA: 0x00397068 File Offset: 0x00395268
	public int GetEquipIndexByGridItem(HonamiStoryGridItemBase gridItem)
	{
		HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase = null;
		foreach (HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase2 in this.PanelBaseList)
		{
			if (honamiStoryBackpackPanelBase2.GetBackpackType() == 3)
			{
				honamiStoryBackpackPanelBase = honamiStoryBackpackPanelBase2;
				break;
			}
		}
		int num = 0;
		if (honamiStoryBackpackPanelBase != null)
		{
			using (List<HonamiStoryGridItemBase>.Enumerator enumerator2 = honamiStoryBackpackPanelBase.GetCurrentGridListGamepad().GetEnumerator())
			{
				while (enumerator2.MoveNext())
				{
					if (enumerator2.Current == gridItem)
					{
						break;
					}
					num++;
				}
			}
		}
		return num;
	}

	// Token: 0x0600EFF9 RID: 61433 RVA: 0x00397110 File Offset: 0x00395310
	public void OnPickUp(HonamiStoryGridItemBase item)
	{
		HonamiStoryBackpackPanelBase panelByGridItem = this.GetPanelByGridItem(item);
		if (panelByGridItem != null)
		{
			int backpackType = panelByGridItem.GetBackpackType();
			if (backpackType == 0 || backpackType == 2 || backpackType == 1)
			{
				this.CacheBackpackWidth = this.GetBackpackWidth(panelByGridItem.GetBackpackType());
				this.CacheDragItemPosition = this.GetGridCenterPosition(item, this.CacheBackpackWidth);
			}
		}
		this.OperateAgent.Clear();
		this.OperateAgent.BaseWidth = 0f;
		this.OperateAgent.BaseHeight = 0f;
		this.OperateAgent.StartOperateBackpack = panelByGridItem;
		this.OperateAgent.OperateData = item.GetData();
		this.OnMove(item);
	}

	// Token: 0x0600EFFA RID: 61434 RVA: 0x003971B4 File Offset: 0x003953B4
	public void OnMove(HonamiStoryGridItemBase item)
	{
		HonamiStoryBackpackPanelBase panelByGridItem = this.GetPanelByGridItem(item);
		if (panelByGridItem == null)
		{
			HonamiStoryBackpackPanelBase targetOperateBackpack = this.OperateAgent.TargetOperateBackpack;
			if (targetOperateBackpack != null)
			{
				targetOperateBackpack.OnHoverEnd();
			}
			this.OperateAgent.TargetOperateBackpack = null;
			this.OperateAgent.TargetPosition = -1;
			return;
		}
		if (this.OperateAgent.TargetOperateBackpack == panelByGridItem)
		{
			this.OperateAgent.TargetOperateBackpack.OnHoverGamepad(item, this.CacheDragItemPosition, this.OperateAgent);
			return;
		}
		HonamiStoryBackpackPanelBase targetOperateBackpack2 = this.OperateAgent.TargetOperateBackpack;
		if (targetOperateBackpack2 != null)
		{
			targetOperateBackpack2.OnHoverEnd();
		}
		this.OperateAgent.TargetOperateBackpack = panelByGridItem;
		HonamiStoryBackpackPanelBase targetOperateBackpack3 = this.OperateAgent.TargetOperateBackpack;
		if (targetOperateBackpack3 == null)
		{
			return;
		}
		targetOperateBackpack3.OnHoverGamepad(item, this.CacheDragItemPosition, this.OperateAgent);
	}

	// Token: 0x0600EFFB RID: 61435 RVA: 0x0039726B File Offset: 0x0039546B
	public void OnPutDown(HonamiStoryGridItemBase item)
	{
		this.ExecuteOperate(item);
		if (this.OperateAgent.TargetOperateBackpack != null)
		{
			this.OperateAgent.TargetOperateBackpack.OnHoverEnd();
		}
	}

	// Token: 0x0600EFFC RID: 61436 RVA: 0x00397294 File Offset: 0x00395494
	private void ExecuteOperate(HonamiStoryGridItemBase item)
	{
		if (this.OperateAgent.TargetOperateBackpack == null || this.OperateAgent.StartOperateBackpack == null)
		{
			return;
		}
		List<HonamiStoryBagUpdateContext> list = new List<HonamiStoryBagUpdateContext>();
		if (this.OperateAgent.TargetOperateBackpack == this.OperateAgent.StartOperateBackpack)
		{
			HonamiStoryBagUpdateContext updateInfoInSameBackpackGamepad = this.OperateAgent.TargetOperateBackpack.GetUpdateInfoInSameBackpackGamepad(item, this.OperateAgent.OperateData);
			if (updateInfoInSameBackpackGamepad == null)
			{
				this.Logic.Reset();
				return;
			}
			list.Add(updateInfoInSameBackpackGamepad);
		}
		else
		{
			HashSet<HonamiStoryItemDataBase> exchangeItemSetGamepad = this.OperateAgent.TargetOperateBackpack.GetExchangeItemSetGamepad(item, this.OperateAgent.OperateData);
			if (exchangeItemSetGamepad == null)
			{
				this.Logic.Reset();
				return;
			}
			HonamiStoryBagUpdateContext updateInfoInReceiveBackpackGamepad = this.OperateAgent.TargetOperateBackpack.GetUpdateInfoInReceiveBackpackGamepad(item, this.OperateAgent.OperateData, exchangeItemSetGamepad);
			if (updateInfoInReceiveBackpackGamepad == null)
			{
				this.Logic.Reset();
				return;
			}
			list.Add(updateInfoInReceiveBackpackGamepad);
			HonamiStoryBagUpdateContext updateInfoInSendBackpackGamepad = this.OperateAgent.StartOperateBackpack.GetUpdateInfoInSendBackpackGamepad(item, this.OperateAgent.OperateData, exchangeItemSetGamepad);
			if (updateInfoInSendBackpackGamepad == null)
			{
				this.Logic.Reset();
				return;
			}
			list.Add(updateInfoInSendBackpackGamepad);
		}
		HonamiStoryController.Instance.SendHonamiStoryBagOperateRequest(list);
	}

	// Token: 0x0600EFFD RID: 61437 RVA: 0x003973B8 File Offset: 0x003955B8
	public void Reset()
	{
		this.CacheBackpackWidth = -1;
		this.CacheDragItemPosition = -1;
		foreach (HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase in this.PanelBaseList)
		{
			honamiStoryBackpackPanelBase.OnHoverEnd();
		}
	}

	// Token: 0x04006EFF RID: 28415
	public List<HonamiStoryBackpackPanelBase> PanelBaseList = new List<HonamiStoryBackpackPanelBase>();

	// Token: 0x04006F00 RID: 28416
	private readonly HonamiStoryInteractOperateAgent OperateAgent = new HonamiStoryInteractOperateAgent();

	// Token: 0x04006F01 RID: 28417
	private int CacheBackpackWidth = -1;

	// Token: 0x04006F02 RID: 28418
	private int CacheDragItemPosition = -1;
}
