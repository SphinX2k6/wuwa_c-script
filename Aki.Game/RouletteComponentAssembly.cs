using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001E99 RID: 7833
[NullableContext(1)]
[Nullable(0)]
public class RouletteComponentAssembly : RouletteComponentBase
{
	// Token: 0x0601357F RID: 79231 RVA: 0x005A585B File Offset: 0x005A3A5B
	public void RegisterViewProxy(RouletteAssemblyViewProxy viewProxy)
	{
		this.ViewProxy = viewProxy;
	}

	// Token: 0x06013580 RID: 79232 RVA: 0x005A5864 File Offset: 0x005A3A64
	protected override bool IsCurrentEquippedId(RouletteData gridData)
	{
		return false;
	}

	// Token: 0x06013581 RID: 79233 RVA: 0x005A5867 File Offset: 0x005A3A67
	protected override void GamepadReturnEmptyGrid()
	{
		this.IsEmptyChoose = false;
	}

	// Token: 0x06013582 RID: 79234 RVA: 0x005A5870 File Offset: 0x005A3A70
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

	// Token: 0x06013583 RID: 79235 RVA: 0x005A58A0 File Offset: 0x005A3AA0
	protected override void SetCurrentToggleState(bool bSelect)
	{
		RouletteGridBase currentGrid = base.GetCurrentGrid();
		if (currentGrid == null)
		{
			return;
		}
		currentGrid.SetGridToggleNavigation(bSelect);
	}

	// Token: 0x06013584 RID: 79236 RVA: 0x005A58B3 File Offset: 0x005A3AB3
	protected override void InitGridEvent(RouletteGridBase grid)
	{
		base.InitGridEvent(grid);
		grid.SetGridToggleChangeEvent();
	}

	// Token: 0x06013585 RID: 79237 RVA: 0x005A58C2 File Offset: 0x005A3AC2
	protected override RouletteData GridDataDecorator(RouletteData data)
	{
		data.State = this.JudgeGridStateByData(data.Id, data.GridType);
		data.ShowIndex = true;
		data.ShowRedDot = false;
		return data;
	}

	// Token: 0x06013586 RID: 79238 RVA: 0x005A58EB File Offset: 0x005A3AEB
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

	// Token: 0x06013587 RID: 79239 RVA: 0x005A58F8 File Offset: 0x005A3AF8
	protected override int GetGridId(int index, ERouletteGridType gridType)
	{
		return this.ViewProxy.GetRouletteGridId(index, gridType);
	}

	// Token: 0x06013588 RID: 79240 RVA: 0x005A5908 File Offset: 0x005A3B08
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

	// Token: 0x06013589 RID: 79241 RVA: 0x005A5970 File Offset: 0x005A3B70
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

	// Token: 0x0601358A RID: 79242 RVA: 0x005A59D4 File Offset: 0x005A3BD4
	public void SetCurrentGridByData(RouletteData data)
	{
		this.CurrentGridIndex = data.GridIndex;
		base.RefreshRouletteComponent();
	}

	// Token: 0x0601358B RID: 79243 RVA: 0x005A59E8 File Offset: 0x005A3BE8
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

	// Token: 0x0601358C RID: 79244 RVA: 0x005A5A0C File Offset: 0x005A3C0C
	public void DeactivateGridToggleChangeEvent()
	{
		foreach (RouletteGridBase rouletteGridBase in this.RouletteGridList)
		{
			rouletteGridBase.RemoveGridToggleChangeEvent();
		}
	}

	// Token: 0x0601358D RID: 79245 RVA: 0x005A5A5C File Offset: 0x005A3C5C
	[NullableContext(2)]
	public RouletteGridBase GetGridByIndex(int index)
	{
		if (index < 0 || index >= this.RouletteGridList.Count)
		{
			return null;
		}
		return this.RouletteGridList[index];
	}

	// Token: 0x0400A5BC RID: 42428
	protected RouletteAssemblyViewProxy ViewProxy;
}
