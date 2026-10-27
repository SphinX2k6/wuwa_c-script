using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E99 RID: 28313
	public static class IResetPlayerFocusTypeVerify
	{
		// Token: 0x060320AA RID: 204970 RVA: 0x006C495A File Offset: 0x006C2B5A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
