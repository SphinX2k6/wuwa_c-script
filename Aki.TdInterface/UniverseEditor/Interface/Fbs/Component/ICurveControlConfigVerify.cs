using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055AF RID: 21935
	public static class ICurveControlConfigVerify
	{
		// Token: 0x06022E54 RID: 142932 RVA: 0x004CE28A File Offset: 0x004CC48A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
