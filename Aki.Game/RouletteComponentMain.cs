using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;

// Token: 0x02001E9A RID: 7834
[NullableContext(1)]
[Nullable(0)]
public class RouletteComponentMain : RouletteComponentBase
{
	// Token: 0x0601358F RID: 79247 RVA: 0x005A5A86 File Offset: 0x005A3C86
	public void RegisterViewProxy(RouletteMainViewProxyBase viewProxy)
	{
		this.ViewProxy = viewProxy;
	}

	// Token: 0x06013590 RID: 79248 RVA: 0x005A5A90 File Offset: 0x005A3C90
	protected override void OnStart()
	{
		base.OnStart();
		if (Info.Instance.IsInGamepad())
		{
			int rouletteSelectConfig = RouletteModel.Instance.GetRouletteSelectConfig();
			this.CanEmitSelectOnFlag = (rouletteSelectConfig == 1);
		}
	}

	// Token: 0x06013591 RID: 79249 RVA: 0x005A5AC4 File Offset: 0x005A3CC4
	protected override void GamepadReturnEmptyGrid()
	{
		if (this.CurrentEquipGridIndex == this.CurrentGridIndex)
		{
			this.IsEmptyChoose = true;
			return;
		}
		RouletteGridBase rouletteGridBase = null;
		if (this.CurrentEquipGridIndex >= 0 && this.CurrentEquipGridIndex < this.RouletteGridList.Count)
		{
			rouletteGridBase = this.RouletteGridList[this.CurrentEquipGridIndex];
		}
		RouletteGridBase rouletteGridBase2 = this.RouletteGridList[this.CurrentGridIndex];
		RouletteData data = rouletteGridBase2.Data;
		if (data.State == EGridBehavior.Forbidden)
		{
			RouletteGridForbiddenSettings.TipsForbiddenState(data.GridType, data.Id);
			this.CurrentGridIndex = -1;
			this.IsEmptyChoose = true;
			return;
		}
		if (data.Id != 0 || data.GridType == ERouletteGridType.EquipItem)
		{
			if (rouletteGridBase != null)
			{
				rouletteGridBase.SetGridEquipped(false);
			}
			if (rouletteGridBase2 != null)
			{
				rouletteGridBase2.SetGridEquipped(true);
			}
			this.CurrentEquipGridIndex = this.CurrentGridIndex;
			this.OnEmitCurrentGridSelectOn();
			this.CloseRouletteMain();
		}
		this.IsEmptyChoose = true;
	}

	// Token: 0x06013592 RID: 79250 RVA: 0x005A5B9C File Offset: 0x005A3D9C
	public void TryEmitCurrentGridSelectOn()
	{
		if (!this.CanEmitSelectOnFlag)
		{
			return;
		}
		this.OnEmitCurrentGridSelectOn();
	}

	// Token: 0x06013593 RID: 79251 RVA: 0x005A5BAD File Offset: 0x005A3DAD
	protected void OnEmitCurrentGridSelectOn()
	{
		if (this.IsEmitGridSelectOn)
		{
			return;
		}
		this.IsEmitGridSelectOn = true;
		RouletteGridBase currentGrid = base.GetCurrentGrid();
		if (currentGrid == null)
		{
			return;
		}
		currentGrid.SelectOnGrid(true);
	}

	// Token: 0x06013594 RID: 79252 RVA: 0x005A5BD0 File Offset: 0x005A3DD0
	protected override bool IsCurrentEquippedId(RouletteData gridData)
	{
		ERouletteGridType gridType = gridData.GridType;
		if (gridType != ERouletteGridType.Explore)
		{
			if (gridType == ERouletteGridType.EquipItem)
			{
				return RouletteModel.Instance.IsEquipItemSelectOn;
			}
		}
		else
		{
			int currentExploreSkillId = RouletteModel.Instance.CurrentExploreSkillId;
			if (currentExploreSkillId != 0 && gridData.Id == currentExploreSkillId)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06013595 RID: 79253 RVA: 0x005A5C12 File Offset: 0x005A3E12
	protected override int GetGridId(int index, ERouletteGridType gridType)
	{
		return this.ViewProxy.GetRouletteGridId(index, gridType);
	}

	// Token: 0x06013596 RID: 79254 RVA: 0x005A5C21 File Offset: 0x005A3E21
	protected override void SetCurrentToggleState(bool bSelect)
	{
		RouletteGridBase currentGrid = base.GetCurrentGrid();
		if (currentGrid != null)
		{
			currentGrid.SetGridToggleState(bSelect, true);
		}
		if (bSelect)
		{
			AudioSystem.Instance.PostEvent("play_ui_float_spl_roulette");
		}
	}

	// Token: 0x06013597 RID: 79255 RVA: 0x005A5C4C File Offset: 0x005A3E4C
	protected override void RefreshCurrentShowName()
	{
		bool flag = Info.Instance.IsInTouch();
		RouletteGridBase currentGrid = base.GetCurrentGrid();
		string text;
		if (currentGrid == null)
		{
			text = null;
		}
		else
		{
			RouletteData data = currentGrid.Data;
			text = ((data != null) ? data.Name : null);
		}
		string text2 = text;
		if (!string.IsNullOrEmpty(text2))
		{
			base.SetNameVisible(true);
			base.RefreshName(text2);
			return;
		}
		base.SetNameVisible(flag);
		if (flag)
		{
			base.RefreshName("Text_ProbeToolFunctionNotice2_Text");
		}
	}

	// Token: 0x06013598 RID: 79256 RVA: 0x005A5CB0 File Offset: 0x005A3EB0
	protected override void RefreshTips()
	{
		bool flag = Info.Instance.IsInTouch();
		bool isEmptyChoose = this.IsEmptyChoose;
		RouletteGridBase currentGrid = base.GetCurrentGrid();
		bool flag2 = currentGrid == null || currentGrid.Data.State != EGridBehavior.Normal;
		string refreshTips = this.GetRefreshTips(isEmptyChoose || flag2);
		base.RefreshTipsByText(refreshTips, !flag);
		this.ViewProxy.RefreshTips();
	}

	// Token: 0x06013599 RID: 79257 RVA: 0x005A5D0D File Offset: 0x005A3F0D
	[NullableContext(2)]
	protected virtual string GetRefreshTips(bool isEmpty)
	{
		return null;
	}

	// Token: 0x0601359A RID: 79258 RVA: 0x005A5D10 File Offset: 0x005A3F10
	protected void CloseRouletteMain()
	{
		UiManager.Instance.CloseView(EUiViewName.PhantomExploreView, null);
	}

	// Token: 0x0400A5BD RID: 42429
	private bool CanEmitSelectOnFlag = true;

	// Token: 0x0400A5BE RID: 42430
	private bool IsEmitGridSelectOn;

	// Token: 0x0400A5BF RID: 42431
	protected RouletteMainViewProxyBase ViewProxy;
}
