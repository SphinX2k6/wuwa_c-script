using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E18 RID: 28184
	public static class IRecoverDurabilityVerify
	{
		// Token: 0x06031CBF RID: 203967 RVA: 0x006BDD5E File Offset: 0x006BBF5E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
