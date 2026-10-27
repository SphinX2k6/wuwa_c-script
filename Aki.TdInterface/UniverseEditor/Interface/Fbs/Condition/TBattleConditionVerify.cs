using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D2C RID: 19756
	public static class TBattleConditionVerify
	{
		// Token: 0x0601F5CB RID: 128459 RVA: 0x0045F37C File Offset: 0x0045D57C
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
