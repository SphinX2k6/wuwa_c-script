using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200628A RID: 25226
	public static class TMonsterCombatInteractionConfigVerify
	{
		// Token: 0x0602AEA0 RID: 175776 RVA: 0x005DB3AC File Offset: 0x005D95AC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IMonsterCombatInteractionWaterBoxStagnationVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IMonsterCombatInteractionFrequencyPaintVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
