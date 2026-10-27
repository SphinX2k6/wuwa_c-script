using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005427 RID: 21543
	public static class IInitStateMagneticStormVerify
	{
		// Token: 0x0602361C RID: 144924 RVA: 0x004E5422 File Offset: 0x004E3622
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
