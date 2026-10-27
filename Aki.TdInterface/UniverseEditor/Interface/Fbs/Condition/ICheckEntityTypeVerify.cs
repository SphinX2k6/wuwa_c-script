using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A1D RID: 18973
	public static class ICheckEntityTypeVerify
	{
		// Token: 0x0601DB06 RID: 121606 RVA: 0x0042D40A File Offset: 0x0042B60A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
