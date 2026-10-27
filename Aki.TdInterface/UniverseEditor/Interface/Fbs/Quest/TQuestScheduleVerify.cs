using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042FE RID: 17150
	public static class TQuestScheduleVerify
	{
		// Token: 0x060196FE RID: 104190 RVA: 0x003A5798 File Offset: 0x003A3998
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IQuestScheduleBtTreeVarVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IQuestScheduleChildQuestCompletedVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IQuestScheduleChildQuestCompletedCountVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IQuestScheduleDistanceValueVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IQuestScheduleEntityHPVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IQuestScheduleMeetConditionVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IQuestScheduleMultiBtTreeVarVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IQuestScheduleNoneVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IQuestScheduleProgressValueVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IQuestScheduleRoleTowerChallengeTitleVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IQuestScheduleScoreVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IQuestScheduleTimeLeftVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IQuestScheduleTowerChallengeTitleVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
