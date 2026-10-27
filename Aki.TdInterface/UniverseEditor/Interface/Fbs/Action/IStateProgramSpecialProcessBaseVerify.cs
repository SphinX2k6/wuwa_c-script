using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071C2 RID: 29122
	public static class IStateProgramSpecialProcessBaseVerify
	{
		// Token: 0x06033AA5 RID: 211621 RVA: 0x006F5292 File Offset: 0x006F3492
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
