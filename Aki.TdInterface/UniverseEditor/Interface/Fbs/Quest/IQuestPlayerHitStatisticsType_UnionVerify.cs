using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004009 RID: 16393
	public static class IQuestPlayerHitStatisticsType_UnionVerify
	{
		// Token: 0x06017A81 RID: 96897 RVA: 0x003698E4 File Offset: 0x00367AE4
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
