using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200789E RID: 30878
	public static class ISheriffUnlockProgressVerify
	{
		// Token: 0x06036517 RID: 222487 RVA: 0x00745F3E File Offset: 0x0074413E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
