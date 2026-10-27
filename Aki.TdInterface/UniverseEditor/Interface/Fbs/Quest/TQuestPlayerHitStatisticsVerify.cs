using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042FB RID: 17147
	public static class TQuestPlayerHitStatisticsVerify
	{
		// Token: 0x060196DC RID: 104156 RVA: 0x003A5460 File Offset: 0x003A3660
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
