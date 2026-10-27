using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004006 RID: 16390
	public static class IQuestPlayerHitStatisticsTypeVerify
	{
		// Token: 0x06017A73 RID: 96883 RVA: 0x003697BE File Offset: 0x003679BE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
