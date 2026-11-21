using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005228 RID: 21032
	public static class TBattleConditionVerify
	{
		// Token: 0x06021212 RID: 135698 RVA: 0x0049330C File Offset: 0x0049150C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBattleTagConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = ICounterAttackConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPerfectDodgeConditionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
