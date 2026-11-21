using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004513 RID: 17683
	public static class IRoleTowerConditionStepBase_UnionVerify
	{
		// Token: 0x0601997A RID: 104826 RVA: 0x003A59F8 File Offset: 0x003A3BF8
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
