using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;

// Token: 0x02001AE6 RID: 6886
public class PowerCurrencyItem : CommonCurrencyItem, IWorldMapItemVisibleControlInterface
{
	// Token: 0x17001992 RID: 6546
	// (get) Token: 0x06011174 RID: 70004 RVA: 0x005053C4 File Offset: 0x005035C4
	// (set) Token: 0x06011175 RID: 70005 RVA: 0x005053CC File Offset: 0x005035CC
	public EWorldMapShowMode ShowMode { get; set; }

	// Token: 0x06011176 RID: 70006 RVA: 0x005053D5 File Offset: 0x005035D5
	protected override void OnStart()
	{
		base.OnStart();
		this.AddOverPowerEventListener();
	}

	// Token: 0x06011177 RID: 70007 RVA: 0x005053E3 File Offset: 0x005035E3
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.RemoveOverPowerEventListener();
	}

	// Token: 0x06011178 RID: 70008 RVA: 0x005053F1 File Offset: 0x005035F1
	public void AddOverPowerEventListener()
	{
		if (this.OverPowerEventListenerAdded)
		{
			return;
		}
		this.OverPowerEventListenerAdded = true;
		EventSystem.Instance.Add(EEventName.OnPowerChangedWithId, new Action<int>(this.OnPowerChangedWithId));
	}

	// Token: 0x06011179 RID: 70009 RVA: 0x0050541F File Offset: 0x0050361F
	public void RemoveOverPowerEventListener()
	{
		if (!this.OverPowerEventListenerAdded)
		{
			return;
		}
		this.OverPowerEventListenerAdded = false;
		EventSystem.Instance.Remove(EEventName.OnPowerChangedWithId, new Action<int>(this.OnPowerChangedWithId));
	}

	// Token: 0x0601117A RID: 70010 RVA: 0x0050544D File Offset: 0x0050364D
	[NullableContext(2)]
	public override void RefreshTemp(int itemId, string countText = null)
	{
		this.ShowWithoutText(itemId);
	}

	// Token: 0x0601117B RID: 70011 RVA: 0x00505456 File Offset: 0x00503656
	public override void ShowWithoutText(int itemId)
	{
		this.CurrentCurrentId = itemId;
		base.ShowWithoutText(itemId);
		this.OnPowerChangedWithId(itemId);
	}

	// Token: 0x0601117C RID: 70012 RVA: 0x0050546D File Offset: 0x0050366D
	public override void RefreshAddButtonActive()
	{
		base.SetButtonActive(this.CurrentCurrentId == 5 && !UiManager.Instance.IsViewOpen(EUiViewName.PowerView));
	}

	// Token: 0x0601117D RID: 70013 RVA: 0x00505494 File Offset: 0x00503694
	private void OnPowerChangedWithId(int itemId)
	{
		if (this.CurrentCurrentId != itemId)
		{
			return;
		}
		PowerData powerDataById = PowerModel.Instance.GetPowerDataById(itemId);
		int currentPower = powerDataById.GetCurrentPower();
		int powerLimit = powerDataById.GetPowerLimit();
		string powerCurrencyShowTextId = powerDataById.GetPowerCurrencyShowTextId();
		base.SetCountTextNew(powerCurrencyShowTextId, new object[]
		{
			currentPower,
			powerLimit
		});
		bool bActive = powerDataById.IfNeedShowMax() && currentPower >= powerLimit;
		base.RefreshMaxItem(bActive);
	}

	// Token: 0x0601117E RID: 70014 RVA: 0x00505507 File Offset: 0x00503707
	public void SetWorldMapSelfShow(EWorldMapShowMode showMode)
	{
		this.ShowMode = showMode;
	}

	// Token: 0x0601117F RID: 70015 RVA: 0x00505510 File Offset: 0x00503710
	public void RefreshWorldMapSelfShow(EWorldMapShowMode showMode)
	{
		base.SetUiActive(showMode == EWorldMapShowMode.Default);
	}

	// Token: 0x04009670 RID: 38512
	private int CurrentCurrentId;

	// Token: 0x04009671 RID: 38513
	private bool OverPowerEventListenerAdded;
}
