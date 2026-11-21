using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E32 RID: 20018
	public static class IBattleCondition_UnionVerify
	{
		// Token: 0x0601EF48 RID: 126792 RVA: 0x00452E14 File Offset: 0x00451014
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBattleConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBattleTagConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IPerfectDodgeConditionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = ICounterAttackConditionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
