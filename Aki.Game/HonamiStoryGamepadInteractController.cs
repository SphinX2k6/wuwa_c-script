using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory;

// Token: 0x02001355 RID: 4949
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryGamepadInteractController
{
	// Token: 0x0600C406 RID: 50182 RVA: 0x003A2827 File Offset: 0x003A0A27
	public void RegisterPanel(HonamiStoryBackpackPanelBase panel)
	{
		this.PanelBaseList.Add(panel);
	}

	// Token: 0x0600C407 RID: 50183 RVA: 0x003A2835 File Offset: 0x003A0A35
	public void ClearPanel()
	{
		this.PanelBaseList.Clear();
	}

	// Token: 0x17001304 RID: 4868
	// (get) Token: 0x0600C408 RID: 50184 RVA: 0x003A2842 File Offset: 0x003A0A42
	[Nullable(2)]
	private HonamiStoryGamepadLogicController Logic
	{
		[NullableContext(2)]
		get
		{
			return HonamiStoryModel.Instance.GetGamepadLogic();
		}
	}

	// Token: 0x0600C409 RID: 50185 RVA: 0x003A2850 File Offset: 0x003A0A50
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

	// Token: 0x0600C40A RID: 50186 RVA: 0x003A2887 File Offset: 0x003A0A87
	public bool HasFallingPile()
	{
		return this.PanelBaseList.Count > 2;
	}

	// Token: 0x0600C40B RID: 50187 RVA: 0x003A2898 File Offset: 0x003A0A98
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

	// Token: 0x0600C40C RID: 50188 RVA: 0x003A28C8 File Offset: 0x003A0AC8
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

	// Token: 0x0600C40D RID: 50189 RVA: 0x003A28EC File Offset: 0x003A0AEC
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

	// Token: 0x0600C40E RID: 50190 RVA: 0x003A290E File Offset: 0x003A0B0E
	private int GetColumn(int startPosition, int backpackWidth)
	{
		return startPosition / backpackWidth;
	}

	// Token: 0x0600C40F RID: 50191 RVA: 0x003A2913 File Offset: 0x003A0B13
	private int GetRow(int startPosition, int backpackWidth)
	{
		return startPosition % backpackWidth;
	}

	// Token: 0x0600C410 RID: 50192 RVA: 0x003A2918 File Offset: 0x003A0B18
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

	// Token: 0x0600C411 RID: 50193 RVA: 0x003A29CC File Offset: 0x003A0BCC
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

	// Token: 0x0600C412 RID: 50194 RVA: 0x003A2A08 File Offset: 0x003A0C08
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

	// Token: 0x0600C413 RID: 50195 RVA: 0x003A2A70 File Offset: 0x003A0C70
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

	// Token: 0x0600C414 RID: 50196 RVA: 0x003A2AF4 File Offset: 0x003A0CF4
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

	// Token: 0x0600C415 RID: 50197 RVA: 0x003A2B50 File Offset: 0x003A0D50
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

	// Token: 0x0600C416 RID: 50198 RVA: 0x003A2BE0 File Offset: 0x003A0DE0
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

	// Token: 0x0600C417 RID: 50199 RVA: 0x003A2C24 File Offset: 0x003A0E24
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

	// Token: 0x0600C418 RID: 50200 RVA: 0x003A2CCC File Offset: 0x003A0ECC
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

	// Token: 0x0600C419 RID: 50201 RVA: 0x003A2D70 File Offset: 0x003A0F70
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

	// Token: 0x0600C41A RID: 50202 RVA: 0x003A2E27 File Offset: 0x003A1027
	public void OnPutDown(HonamiStoryGridItemBase item)
	{
		this.ExecuteOperate(item);
		if (this.OperateAgent.TargetOperateBackpack != null)
		{
			this.OperateAgent.TargetOperateBackpack.OnHoverEnd();
		}
	}

	// Token: 0x0600C41B RID: 50203 RVA: 0x003A2E50 File Offset: 0x003A1050
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

	// Token: 0x0600C41C RID: 50204 RVA: 0x003A2F74 File Offset: 0x003A1174
	public void Reset()
	{
		this.CacheBackpackWidth = -1;
		this.CacheDragItemPosition = -1;
		foreach (HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase in this.PanelBaseList)
		{
			honamiStoryBackpackPanelBase.OnHoverEnd();
		}
	}

	// Token: 0x04006FE0 RID: 28640
	public List<HonamiStoryBackpackPanelBase> PanelBaseList = new List<HonamiStoryBackpackPanelBase>();

	// Token: 0x04006FE1 RID: 28641
	private readonly HonamiStoryInteractOperateAgent OperateAgent = new HonamiStoryInteractOperateAgent();

	// Token: 0x04006FE2 RID: 28642
	private int CacheBackpackWidth = -1;

	// Token: 0x04006FE3 RID: 28643
	private int CacheDragItemPosition = -1;
}
