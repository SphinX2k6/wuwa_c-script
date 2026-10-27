using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004301 RID: 17153
	public static class TQuestStatisticsVerify
	{
		// Token: 0x0601971A RID: 104218 RVA: 0x003A5ADC File Offset: 0x003A3CDC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IQuestMechaTrackScoreVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IQuestMonsterHealthScoreVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IQuestMonsterPointVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IQuestMonsterRemainingHealthVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IQuestPlayerHitStatisticsVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IQuestStaticTimerVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IQuestStatisticsCollectVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IQuestStatisticsPlayerTriggerMotionVerify.Verify(verifier, tablePos);
				break;
			case 9:
				result = IQuestStatisticsUseSkillVerify.Verify(verifier, tablePos);
				break;
			case 10:
				result = IQuestStatisticsUseSkillNewVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
