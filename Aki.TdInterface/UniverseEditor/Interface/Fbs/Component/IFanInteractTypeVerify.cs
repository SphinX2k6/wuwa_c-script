using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005239 RID: 21049
	public static class IFanInteractTypeVerify
	{
		// Token: 0x060223C8 RID: 140232 RVA: 0x004BFB7E File Offset: 0x004BDD7E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
