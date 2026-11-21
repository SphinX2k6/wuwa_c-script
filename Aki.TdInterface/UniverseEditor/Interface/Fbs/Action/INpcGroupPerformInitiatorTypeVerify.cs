using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007306 RID: 29446
	public static class INpcGroupPerformInitiatorTypeVerify
	{
		// Token: 0x060335A4 RID: 210340 RVA: 0x006ECE1E File Offset: 0x006EB01E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
