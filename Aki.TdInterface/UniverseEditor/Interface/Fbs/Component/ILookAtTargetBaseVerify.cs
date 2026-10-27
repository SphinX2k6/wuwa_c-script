using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005511 RID: 21777
	public static class ILookAtTargetBaseVerify
	{
		// Token: 0x06023F86 RID: 147334 RVA: 0x004F8C8A File Offset: 0x004F6E8A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
