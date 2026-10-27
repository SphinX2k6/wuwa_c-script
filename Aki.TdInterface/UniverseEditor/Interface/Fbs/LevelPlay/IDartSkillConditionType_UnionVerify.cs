using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200448A RID: 17546
	public static class IDartSkillConditionType_UnionVerify
	{
		// Token: 0x0601A2B5 RID: 107189 RVA: 0x003BCF10 File Offset: 0x003BB110
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IDartSkillConditionTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IRemainScoreGeConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IRemainScoreLeConditionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IBehindScoreGeConditionVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IBehindScoreLeConditionVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IRemainScoreCanWinConditionVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IRoundIndexConditionVerify.Verify(verifier, tablePos);
				break;
			case 8:
				result = IFirstRoundsConditionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
