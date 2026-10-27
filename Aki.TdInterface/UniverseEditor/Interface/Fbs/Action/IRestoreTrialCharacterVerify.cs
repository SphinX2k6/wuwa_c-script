using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EC0 RID: 28352
	public static class IRestoreTrialCharacterVerify
	{
		// Token: 0x060321C2 RID: 205250 RVA: 0x006C65C2 File Offset: 0x006C47C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
