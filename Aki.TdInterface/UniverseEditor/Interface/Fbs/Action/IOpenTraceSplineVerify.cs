using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C47 RID: 27719
	public static class IOpenTraceSplineVerify
	{
		// Token: 0x06030D41 RID: 200001 RVA: 0x006A1F78 File Offset: 0x006A0178
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
