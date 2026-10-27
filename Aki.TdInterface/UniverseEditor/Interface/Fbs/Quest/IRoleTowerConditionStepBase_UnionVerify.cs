using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040D2 RID: 16594
	public static class IRoleTowerConditionStepBase_UnionVerify
	{
		// Token: 0x060182D9 RID: 99033 RVA: 0x0037BAA8 File Offset: 0x00379CA8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRoleTowerConditionStepBaseVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRoleTowerConditionStepPrepareVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRoleTowerConditionStepBattleVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRoleTowerConditionStepSettleVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IRoleTowerConditionStepTeamUpgradeVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IRoleTowerConditionStepLoadSubLevelVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
