using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004E05 RID: 19973
	public class SpecialEnergyBarMorphPlayUse : SpecialEnergyBarMorph
	{
		// Token: 0x06032423 RID: 205859 RVA: 0x00E16718 File Offset: 0x00E14918
		[NullableContext(1)]
		protected override Type GetSpecialEnergyBarClass()
		{
			return typeof(SpecialEnergyBarSlotPlayUse);
		}
	}
}
