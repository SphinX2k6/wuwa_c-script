using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046AD RID: 18093
	public static class IStartCombatOperationReplayVerify
	{
		// Token: 0x0601B7DE RID: 112606 RVA: 0x003E71F7 File Offset: 0x003E53F7
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
