using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;

// Token: 0x020016FB RID: 5883
public class SpecialEnergyBarFeiXueSlot : SpecialEnergyBarSlot
{
	// Token: 0x0600A8BE RID: 43198 RVA: 0x0025F860 File Offset: 0x0025DA60
	protected override void OnStart()
	{
		base.OnStart();
		this.RefreshFullState(this.GetKeyEnable(), true);
		foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
		{
			specialEnergyBarSlotItem.SetFullEffectPercent(1f);
		}
	}

	// Token: 0x0600A8BF RID: 43199 RVA: 0x0025F8C8 File Offset: 0x0025DAC8
	protected override void RefreshBarPercent(bool isStart = false)
	{
		base.RefreshBarPercent(isStart);
		this.RefreshFullState(this.GetKeyEnable(), false);
	}

	// Token: 0x0600A8C0 RID: 43200 RVA: 0x0025F8DE File Offset: 0x0025DADE
	private void RefreshFullState(bool isFull, bool isStart = false)
	{
		if (this.IsFull == isFull && !isStart)
		{
			return;
		}
		this.IsFull = isFull;
		if (this.FullStateChangedCallback != null)
		{
			this.FullStateChangedCallback(isFull);
		}
	}

	// Token: 0x04004D05 RID: 19717
	private bool IsFull;

	// Token: 0x04004D06 RID: 19718
	[Nullable(2)]
	public Action<bool> FullStateChangedCallback;
}
