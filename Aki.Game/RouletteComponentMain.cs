using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;

// Token: 0x0200291F RID: 10527
[NullableContext(1)]
[Nullable(0)]
public class RouletteComponentMain : RouletteComponentBase
{
	// Token: 0x06015B8B RID: 88971 RVA: 0x0057AB0A File Offset: 0x00578D0A
	public void RegisterViewProxy(RouletteMainViewProxyBase viewProxy)
	{
		this.ViewProxy = viewProxy;
	}

	// Token: 0x06015B8C RID: 88972 RVA: 0x0057AB14 File Offset: 0x00578D14
	protected override void OnStart()
	{
		base.OnStart();
		if (Info.Instance.IsInGamepad())
		{
			int rouletteSelectConfig = RouletteModel.Instance.GetRouletteSelectConfig();
			this.CanEmitSelectOnFlag = (rouletteSelectConfig == 1);
		}
	}

	// Token: 0x06015B8D RID: 88973 RVA: 0x0057AB48 File Offset: 0x00578D48
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

	// Token: 0x06015B8E RID: 88974 RVA: 0x0057AC20 File Offset: 0x00578E20
	public void TryEmitCurrentGridSelectOn()
	{
		if (!this.CanEmitSelectOnFlag)
		{
			return;
		}
		this.OnEmitCurrentGridSelectOn();
	}

	// Token: 0x06015B8F RID: 88975 RVA: 0x0057AC31 File Offset: 0x00578E31
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

	// Token: 0x06015B90 RID: 88976 RVA: 0x0057AC54 File Offset: 0x00578E54
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

	// Token: 0x06015B91 RID: 88977 RVA: 0x0057AC96 File Offset: 0x00578E96
	protected override int GetGridId(int index, ERouletteGridType gridType)
	{
		return this.ViewProxy.GetRouletteGridId(index, gridType);
	}

	// Token: 0x06015B92 RID: 88978 RVA: 0x0057ACA5 File Offset: 0x00578EA5
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

	// Token: 0x06015B93 RID: 88979 RVA: 0x0057ACD0 File Offset: 0x00578ED0
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

	// Token: 0x06015B94 RID: 88980 RVA: 0x0057AD34 File Offset: 0x00578F34
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

	// Token: 0x06015B95 RID: 88981 RVA: 0x0057AD91 File Offset: 0x00578F91
	[NullableContext(2)]
	protected virtual string GetRefreshTips(bool isEmpty)
	{
		return null;
	}

	// Token: 0x06015B96 RID: 88982 RVA: 0x0057AD94 File Offset: 0x00578F94
	protected void CloseRouletteMain()
	{
		UiManager.Instance.CloseView(EUiViewName.PhantomExploreView, null);
	}

	// Token: 0x0400A1D2 RID: 41426
	private bool CanEmitSelectOnFlag = true;

	// Token: 0x0400A1D3 RID: 41427
	private bool IsEmitGridSelectOn;

	// Token: 0x0400A1D4 RID: 41428
	protected RouletteMainViewProxyBase ViewProxy;
}
