using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E09 RID: 24073
	public class SpecialEnergyBarXiangLiYao : SpecialEnergyBarMorph
	{
		// Token: 0x0603D36F RID: 250735 RVA: 0x00EBF3B8 File Offset: 0x00EBD5B8
		protected override void OnBeforeShow()
		{
			base.OnBeforeShow();
			UNiagaraSystem valueOrDefault = this.NiagaraList.GetValueOrDefault(0);
			if (valueOrDefault != null)
			{
				SpecialEnergyBarSlot specialEnergyBarSlot = this.BarItem as SpecialEnergyBarSlot;
				specialEnergyBarSlot.ReplaceFullEffect(valueOrDefault);
				specialEnergyBarSlot.UpdateFullEffectOffsetBySlotWidth();
			}
		}

		// Token: 0x0603D370 RID: 250736 RVA: 0x00EBF3F2 File Offset: 0x00EBD5F2
		[NullableContext(1)]
		protected override Type GetSpecialEnergyBarClass()
		{
			return typeof(SpecialEnergyBarSlot);
		}
	}
}
