using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E74 RID: 15988
	public static class IFreezeOnSightGamePlayConfigVerify
	{
		// Token: 0x06016864 RID: 92260 RVA: 0x0034154A File Offset: 0x0033F74A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
