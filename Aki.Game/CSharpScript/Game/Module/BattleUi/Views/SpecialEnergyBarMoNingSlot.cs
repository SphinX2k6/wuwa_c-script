using System;
using System.Linq;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005DF7 RID: 24055
	public class SpecialEnergyBarMoNingSlot : SpecialEnergyBarSlot
	{
		// Token: 0x0603D266 RID: 250470 RVA: 0x00EB9B10 File Offset: 0x00EB7D10
		public void SwitchPointColor(bool enhanced)
		{
			SpecialEnergyBarInfo config = this.Config;
			string text;
			if (config == null)
			{
				text = null;
			}
			else
			{
				string[] pointColorList = config.PointColorList;
				text = ((pointColorList != null) ? pointColorList.ElementAtOrDefault((enhanced > false) ? 1 : 0) : null);
			}
			FColor fcolor = FColor.FromHex(text ?? "ffffff");
			this.SlotItemList[0].SetPointColor(fcolor);
		}
	}
}
