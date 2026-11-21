using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200444A RID: 17482
	public static class IQuestPlayerHitStatisticsType_UnionVerify
	{
		// Token: 0x0601911A RID: 102682 RVA: 0x003936D8 File Offset: 0x003918D8
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			switch (typeId)
			{
			case 1:
				result = IQuestPlayerHitStatisticsTypeVerify.Verify(verifier, tablePos);
				break;
			case 2:
				result = IQuestPlayerHitCountVerify.Verify(verifier, tablePos);
				break;
			case 3:
				result = IQuestPlayerBeDamageVerify.Verify(verifier, tablePos);
				break;
			default:
				result = true;
				break;
			}
			return result;
		}
	}
}
