using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F59 RID: 24409
	public static class ISpawnMonsterCompleteCondition_UnionVerify
	{
		// Token: 0x0602904D RID: 168013 RVA: 0x0059A4E4 File Offset: 0x005986E4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = ISpawnMonsterCompleteConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IAllKillConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IDurationConditionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IQuantityRefillConditionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
