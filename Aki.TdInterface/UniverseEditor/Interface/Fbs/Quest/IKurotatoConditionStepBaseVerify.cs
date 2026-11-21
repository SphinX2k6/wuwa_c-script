using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004312 RID: 17170
	public static class IKurotatoConditionStepBaseVerify
	{
		// Token: 0x06018257 RID: 98903 RVA: 0x00371D32 File Offset: 0x0036FF32
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
