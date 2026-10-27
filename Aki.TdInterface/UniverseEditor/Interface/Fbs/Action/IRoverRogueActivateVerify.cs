using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F08 RID: 28424
	public static class IRoverRogueActivateVerify
	{
		// Token: 0x06032389 RID: 205705 RVA: 0x006C90FA File Offset: 0x006C72FA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
