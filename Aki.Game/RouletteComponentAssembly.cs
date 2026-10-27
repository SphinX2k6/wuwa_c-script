using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200291E RID: 10526
[NullableContext(1)]
[Nullable(0)]
public class RouletteComponentAssembly : RouletteComponentBase
{
	// Token: 0x06015B7B RID: 88955 RVA: 0x0057A8DF File Offset: 0x00578ADF
	public void RegisterViewProxy(RouletteAssemblyViewProxy viewProxy)
	{
		this.ViewProxy = viewProxy;
	}

	// Token: 0x06015B7C RID: 88956 RVA: 0x0057A8E8 File Offset: 0x00578AE8
	protected override bool IsCurrentEquippedId(RouletteData gridData)
	{
		return false;
	}

	// Token: 0x06015B7D RID: 88957 RVA: 0x0057A8EB File Offset: 0x00578AEB
	protected override void GamepadReturnEmptyGrid()
	{
		this.IsEmptyChoose = false;
	}

	// Token: 0x06015B7E RID: 88958 RVA: 0x0057A8F4 File Offset: 0x00578AF4
	protected override EGridBehavior JudgeGridStateByData(int id, ERouletteGridType gridType)
	{
		if (id == 0)
		{
			return EGridBehavior.CanAdd;
		}
		EGridBehavior? egridBehavior = RouletteGridForbiddenSettings.CheckGridSpecialState(ERouletteViewType.Assembly, gridType, id);
		if (egridBehavior != null)
		{
			return egridBehavior.Value;
		}
		return EGridBehavior.Normal;
	}

	// Token: 0x06015B7F RID: 88959 RVA: 0x0057A924 File Offset: 0x00578B24
	protected override void SetCurrentToggleState(bool bSelect)
	{
		RouletteGridBase currentGrid = base.GetCurrentGrid();
		if (currentGrid == null)
		{
			return;
		}
		currentGrid.SetGridToggleNavigation(bSelect);
	}

	// Token: 0x06015B80 RID: 88960 RVA: 0x0057A937 File Offset: 0x00578B37
	protected override void InitGridEvent(RouletteGridBase grid)
	{
		base.InitGridEvent(grid);
		grid.SetGridToggleChangeEvent();
	}

	// Token: 0x06015B81 RID: 88961 RVA: 0x0057A946 File Offset: 0x00578B46
	protected override RouletteData GridDataDecorator(RouletteData data)
	{
		data.State = this.JudgeGridStateByData(data.Id, data.GridType);
		data.ShowIndex = true;
		data.ShowRedDot = false;
		return data;
	}

	// Token: 0x06015B82 RID: 88962 RVA: 0x0057A96F File Offset: 0x00578B6F
	[return: Nullable(new byte[]
	{
		2,
		0,
		1
	})]
	protected override List<ValueTuple<List<int>, ERouletteComponentNode, ERouletteGridType>> GetRouletteInfoMap()
	{
		return this.ViewProxy.GetRouletteDataMap();
	}

	// Token: 0x06015B83 RID: 88963 RVA: 0x0057A97C File Offset: 0x00578B7C
	protected override int GetGridId(int index, ERouletteGridType gridType)
	{
		return this.ViewProxy.GetRouletteGridId(index, gridType);
	}

	// Token: 0x06015B84 RID: 88964 RVA: 0x0057A98C File Offset: 0x00578B8C
	[NullableContext(2)]
	public RouletteGridBase GetGridByValidId(int id)
	{
		if (id == 0)
		{
			return null;
		}
		foreach (RouletteGridBase rouletteGridBase in this.RouletteGridList)
		{
			if (rouletteGridBase.Data.Id == id)
			{
				return rouletteGridBase;
			}
		}
		return null;
	}

	// Token: 0x06015B85 RID: 88965 RVA: 0x0057A9F4 File Offset: 0x00578BF4
	[NullableContext(2)]
	public RouletteGridBase GetGridByType(ERouletteGridType gridType)
	{
		foreach (RouletteGridBase rouletteGridBase in this.RouletteGridList)
		{
			if (rouletteGridBase.Data.GridType == gridType)
			{
				return rouletteGridBase;
			}
		}
		return null;
	}

	// Token: 0x06015B86 RID: 88966 RVA: 0x0057AA58 File Offset: 0x00578C58
	public void SetCurrentGridByData(RouletteData data)
	{
		this.CurrentGridIndex = data.GridIndex;
		base.RefreshRouletteComponent();
	}

	// Token: 0x06015B87 RID: 88967 RVA: 0x0057AA6C File Offset: 0x00578C6C
	public void RefreshCurrentGridData(RouletteData data)
	{
		this.GridDataDecorator(data);
		RouletteGridBase currentGrid = base.GetCurrentGrid();
		if (currentGrid != null)
		{
			currentGrid.RefreshGrid(data);
		}
		base.RefreshRouletteComponent();
	}

	// Token: 0x06015B88 RID: 88968 RVA: 0x0057AA90 File Offset: 0x00578C90
	public void DeactivateGridToggleChangeEvent()
	{
		foreach (RouletteGridBase rouletteGridBase in this.RouletteGridList)
		{
			rouletteGridBase.RemoveGridToggleChangeEvent();
		}
	}

	// Token: 0x06015B89 RID: 88969 RVA: 0x0057AAE0 File Offset: 0x00578CE0
	[NullableContext(2)]
	public RouletteGridBase GetGridByIndex(int index)
	{
		if (index < 0 || index >= this.RouletteGridList.Count)
		{
			return null;
		}
		return this.RouletteGridList[index];
	}

	// Token: 0x0400A1D1 RID: 41425
	protected RouletteAssemblyViewProxy ViewProxy;
}
