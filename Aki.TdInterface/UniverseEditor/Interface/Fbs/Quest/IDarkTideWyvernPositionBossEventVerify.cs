using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004201 RID: 16897
	public static class IDarkTideWyvernPositionBossEventVerify
	{
		// Token: 0x06017739 RID: 96057 RVA: 0x0035985E File Offset: 0x00357A5E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
