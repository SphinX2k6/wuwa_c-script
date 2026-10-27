using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200430D RID: 17165
	public static class TRoleTowerConditionStepVerify
	{
		// Token: 0x06019754 RID: 104276 RVA: 0x003A607C File Offset: 0x003A427C
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IRoleTowerConditionStepBattleVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRoleTowerConditionStepLoadSubLevelVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRoleTowerConditionStepPrepareVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRoleTowerConditionStepSettleVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IRoleTowerConditionStepTeamUpgradeVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
