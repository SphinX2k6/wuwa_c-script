using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200497B RID: 18811
	public static class IBattleCondition_UnionVerify
	{
		// Token: 0x0601D523 RID: 120099 RVA: 0x00422960 File Offset: 0x00420B60
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
