using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004601 RID: 17921
	public static class TDartSkillConditionVerify
	{
		// Token: 0x0601B266 RID: 111206 RVA: 0x003DE4BC File Offset: 0x003DC6BC
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IBehindScoreGeConditionVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IBehindScoreLeConditionVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IFirstRoundsConditionVerify.Verify(verifier, tablePos);
				break;
			case 4:
				result = IRemainScoreCanWinConditionVerify.Verify(verifier, tablePos);
				break;
			case 5:
				result = IRemainScoreGeConditionVerify.Verify(verifier, tablePos);
				break;
			case 6:
				result = IRemainScoreLeConditionVerify.Verify(verifier, tablePos);
				break;
			case 7:
				result = IRoundIndexConditionVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
