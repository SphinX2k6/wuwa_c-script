using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B06 RID: 23302
	public static class IMonsterCombatInteractionConfig_UnionVerify
	{
		// Token: 0x060264A1 RID: 156833 RVA: 0x0053ED78 File Offset: 0x0053CF78
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IMonsterCombatInteractionConfigVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IMonsterCombatInteractionWaterBoxStagnationVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IMonsterCombatInteractionFrequencyPaintVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
