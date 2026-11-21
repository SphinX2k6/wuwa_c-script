using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A54 RID: 31316
	public static class ISystemFunctionVerify
	{
		// Token: 0x0603731A RID: 226074 RVA: 0x0075F692 File Offset: 0x0075D892
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
