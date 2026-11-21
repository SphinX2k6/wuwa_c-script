using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004489 RID: 17545
	public static class IQuestScheduleType_UnionVerify
	{
		// Token: 0x060193E4 RID: 103396 RVA: 0x00399DB4 File Offset: 0x00397FB4
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IQuestScheduleTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IQuestScheduleNoneVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IQuestScheduleEntityHPVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IQuestScheduleScoreVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IQuestScheduleChildQuestCompletedVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IQuestScheduleChildQuestCompletedCountVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IQuestScheduleTowerChallengeTitleVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IQuestScheduleRoleTowerChallengeTitleVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IQuestScheduleBtTreeVarVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IQuestScheduleMultiBtTreeVarVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IQuestScheduleTimeLeftVerify.Verify(verifier, tablePos);
				break;
			case 12:
				result = IQuestScheduleMeetConditionVerify.Verify(verifier, tablePos);
				break;
			case 13:
				result = IQuestScheduleProgressValueVerify.Verify(verifier, tablePos);
				break;
			case 14:
				result = IQuestScheduleDistanceValueVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
