using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200789B RID: 30875
	public static class ISheriffUnlockEndingVerify
	{
		// Token: 0x06036505 RID: 222469 RVA: 0x00745DC6 File Offset: 0x00743FC6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
