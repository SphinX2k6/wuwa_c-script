using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200449B RID: 17563
	public static class IQuestStatisticsType_UnionVerify
	{
		// Token: 0x060194C2 RID: 103618 RVA: 0x0039C2EC File Offset: 0x0039A4EC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IQuestStatisticsTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IQuestStatisticsCollectVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IQuestStatisticsUseSkillVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IQuestStatisticsUseSkillNewVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IQuestStatisticsPlayerTriggerMotionVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IQuestStaticTimerVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IQuestMonsterPointVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IQuestMonsterRemainingHealthVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IQuestMonsterHealthScoreVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IQuestPlayerHitStatisticsVerify.Verify(verifier, tablePos);
				break;
			case 11:
				result = IQuestMechaTrackScoreVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
