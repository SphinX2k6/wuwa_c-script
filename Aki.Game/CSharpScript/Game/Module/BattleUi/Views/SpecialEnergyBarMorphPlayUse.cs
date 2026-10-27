using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005E20 RID: 24096
	public class SpecialEnergyBarMorphPlayUse : SpecialEnergyBarMorph
	{
		// Token: 0x0603D494 RID: 251028 RVA: 0x00EC51B8 File Offset: 0x00EC33B8
		[NullableContext(1)]
		protected override Type GetSpecialEnergyBarClass()
		{
			return typeof(SpecialEnergyBarSlotPlayUse);
		}
	}
}
