using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200405A RID: 16474
	public static class IQuestStatisticsType_UnionVerify
	{
		// Token: 0x06017E29 RID: 97833 RVA: 0x003724F8 File Offset: 0x003706F8
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
