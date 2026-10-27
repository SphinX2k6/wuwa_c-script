using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007294 RID: 29332
	public static class ITalkBackgroundVerify
	{
		// Token: 0x060340A4 RID: 213156 RVA: 0x006FF1FE File Offset: 0x006FD3FE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
