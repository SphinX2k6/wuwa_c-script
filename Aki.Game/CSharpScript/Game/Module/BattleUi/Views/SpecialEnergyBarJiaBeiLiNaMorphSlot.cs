using System;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DDB RID: 24027
	public class SpecialEnergyBarJiaBeiLiNaMorphSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D134 RID: 250164 RVA: 0x00EB1D90 File Offset: 0x00EAFF90
		protected override void RefreshBarPercent(bool isStart = false)
		{
			float curPercent = this.PercentMachine.GetCurPercent();
			this.SlotItemList[0].UpdatePercentWithFullEffect(curPercent, curPercent, isStart);
		}
	}
}
