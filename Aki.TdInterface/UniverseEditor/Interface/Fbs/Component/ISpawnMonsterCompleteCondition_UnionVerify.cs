using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200594C RID: 22860
	public static class ISpawnMonsterCompleteCondition_UnionVerify
	{
		// Token: 0x06026AE3 RID: 158435 RVA: 0x00553878 File Offset: 0x00551A78
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
