using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200475A RID: 18266
	public static class TQuestPlayerHitStatisticsVerify
	{
		// Token: 0x0601AE5E RID: 110174 RVA: 0x003D0D90 File Offset: 0x003CEF90
		public static bool Verify(Verifier verifier, byte typeId, uint tablePos)
		{
			bool result;
			if (typeId != 1)
			{
				result = (typeId != 2 || IQuestPlayerHitCountVerify.Verify(verifier, tablePos));
			}
			else
			{
				result = IQuestPlayerBeDamageVerify.Verify(verifier, tablePos);
			}
			return result;
		}
	}
}
