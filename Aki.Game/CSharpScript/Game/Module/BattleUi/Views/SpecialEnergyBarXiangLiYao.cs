using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004DEE RID: 19950
	public class SpecialEnergyBarXiangLiYao : SpecialEnergyBarMorph
	{
		// Token: 0x060322FE RID: 205566 RVA: 0x00E10918 File Offset: 0x00E0EB18
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

		// Token: 0x060322FF RID: 205567 RVA: 0x00E10952 File Offset: 0x00E0EB52
		[NullableContext(1)]
		protected override Type GetSpecialEnergyBarClass()
		{
			return typeof(SpecialEnergyBarSlot);
		}
	}
}
