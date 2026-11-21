using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.BattleUi.Views;

// Token: 0x02000BB3 RID: 2995
public class SpecialEnergyBarFeiXueSlot : SpecialEnergyBarSlot
{
	// Token: 0x06007C9E RID: 31902 RVA: 0x00269C7C File Offset: 0x00267E7C
	protected override void OnStart()
	{
		base.OnStart();
		this.RefreshFullState(this.GetKeyEnable(), true);
		foreach (SpecialEnergyBarSlotItem specialEnergyBarSlotItem in this.SlotItemList)
		{
			specialEnergyBarSlotItem.SetFullEffectPercent(1f);
		}
	}

	// Token: 0x06007C9F RID: 31903 RVA: 0x00269CE4 File Offset: 0x00267EE4
	protected override void RefreshBarPercent(bool isStart = false)
	{
		base.RefreshBarPercent(isStart);
		this.RefreshFullState(this.GetKeyEnable(), false);
	}

	// Token: 0x06007CA0 RID: 31904 RVA: 0x00269CFA File Offset: 0x00267EFA
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

	// Token: 0x04004DAC RID: 19884
	private bool IsFull;

	// Token: 0x04004DAD RID: 19885
	[Nullable(2)]
	public Action<bool> FullStateChangedCallback;
}
