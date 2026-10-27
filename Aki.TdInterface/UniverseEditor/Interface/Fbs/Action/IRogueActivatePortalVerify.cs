using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EDE RID: 28382
	public static class IRogueActivatePortalVerify
	{
		// Token: 0x06032279 RID: 205433 RVA: 0x006C761E File Offset: 0x006C581E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
