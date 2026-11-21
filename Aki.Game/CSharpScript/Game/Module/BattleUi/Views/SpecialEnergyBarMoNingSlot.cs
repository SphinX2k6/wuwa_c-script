using System;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DDC RID: 19932
	public class SpecialEnergyBarMoNingSlot : SpecialEnergyBarSlot
	{
		// Token: 0x060321F5 RID: 205301 RVA: 0x00E0B058 File Offset: 0x00E09258
		public void SwitchPointColor(bool enhanced)
		{
			int num = (enhanced > false) ? 1 : 0;
			FColor fcolor = FColor.FromHex((this.Config != null && num < this.Config.PointColorList.Length) ? this.Config.PointColorList[num] : "ffffff");
			this.SlotItemList[0].SetPointColor(fcolor);
		}
	}
}
