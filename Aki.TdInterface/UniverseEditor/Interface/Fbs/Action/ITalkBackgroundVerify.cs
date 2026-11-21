using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A69 RID: 31337
	public static class ITalkBackgroundVerify
	{
		// Token: 0x060373A8 RID: 226216 RVA: 0x0076059A File Offset: 0x0075E79A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
