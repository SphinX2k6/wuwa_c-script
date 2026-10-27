using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;

// Token: 0x020025FB RID: 9723
public class PowerCurrencyItem : CommonCurrencyItem, IWorldMapItemVisibleControlInterface
{
	// Token: 0x1700195A RID: 6490
	// (get) Token: 0x06013C92 RID: 81042 RVA: 0x004F6630 File Offset: 0x004F4830
	// (set) Token: 0x06013C93 RID: 81043 RVA: 0x004F6638 File Offset: 0x004F4838
	public EWorldMapShowMode ShowMode { get; set; }

	// Token: 0x06013C94 RID: 81044 RVA: 0x004F6641 File Offset: 0x004F4841
	protected override void OnStart()
	{
		base.OnStart();
		this.AddOverPowerEventListener();
	}

	// Token: 0x06013C95 RID: 81045 RVA: 0x004F664F File Offset: 0x004F484F
	protected override void OnBeforeDestroy()
	{
		base.OnBeforeDestroy();
		this.RemoveOverPowerEventListener();
	}

	// Token: 0x06013C96 RID: 81046 RVA: 0x004F665D File Offset: 0x004F485D
	public void AddOverPowerEventListener()
	{
		if (this.OverPowerEventListenerAdded)
		{
			return;
		}
		this.OverPowerEventListenerAdded = true;
		EventSystem.Instance.Add(EEventName.OnPowerChangedWithId, new Action<int>(this.OnPowerChangedWithId));
	}

	// Token: 0x06013C97 RID: 81047 RVA: 0x004F668B File Offset: 0x004F488B
	public void RemoveOverPowerEventListener()
	{
		if (!this.OverPowerEventListenerAdded)
		{
			return;
		}
		this.OverPowerEventListenerAdded = false;
		EventSystem.Instance.Remove(EEventName.OnPowerChangedWithId, new Action<int>(this.OnPowerChangedWithId));
	}

	// Token: 0x06013C98 RID: 81048 RVA: 0x004F66B9 File Offset: 0x004F48B9
	[NullableContext(2)]
	public override void RefreshTemp(int itemId, string countText = null)
	{
		this.ShowWithoutText(itemId);
	}

	// Token: 0x06013C99 RID: 81049 RVA: 0x004F66C2 File Offset: 0x004F48C2
	public override void ShowWithoutText(int itemId)
	{
		this.CurrentCurrentId = itemId;
		base.ShowWithoutText(itemId);
		this.OnPowerChangedWithId(itemId);
	}

	// Token: 0x06013C9A RID: 81050 RVA: 0x004F66D9 File Offset: 0x004F48D9
	public override void RefreshAddButtonActive()
	{
		base.SetButtonActive(this.CurrentCurrentId == 5 && !UiManager.Instance.IsViewOpen(EUiViewName.PowerView));
	}

	// Token: 0x06013C9B RID: 81051 RVA: 0x004F6700 File Offset: 0x004F4900
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

	// Token: 0x06013C9C RID: 81052 RVA: 0x004F6773 File Offset: 0x004F4973
	public void SetWorldMapSelfShow(EWorldMapShowMode showMode)
	{
		this.ShowMode = showMode;
	}

	// Token: 0x06013C9D RID: 81053 RVA: 0x004F677C File Offset: 0x004F497C
	public void RefreshWorldMapSelfShow(EWorldMapShowMode showMode)
	{
		base.SetUiActive(showMode == EWorldMapShowMode.Default);
	}

	// Token: 0x04009519 RID: 38169
	private int CurrentCurrentId;

	// Token: 0x0400951A RID: 38170
	private bool OverPowerEventListenerAdded;
}
