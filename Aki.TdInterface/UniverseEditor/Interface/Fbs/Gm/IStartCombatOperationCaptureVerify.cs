using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046AA RID: 18090
	public static class IStartCombatOperationCaptureVerify
	{
		// Token: 0x0601B7C6 RID: 112582 RVA: 0x003E6FC3 File Offset: 0x003E51C3
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
