using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DBF RID: 19903
	public class SpecialEnergyBarJiaBeiLiNaMorphSlot : SpecialEnergyBarSlot
	{
		// Token: 0x060320AB RID: 204971 RVA: 0x00E02C84 File Offset: 0x00E00E84
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			this.SlotItemList[0].UpdatePercentWithFullEffect(curPercent, curPercent, isStart);
		}
	}
}
