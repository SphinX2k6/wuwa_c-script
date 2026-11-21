using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007485 RID: 29829
	public static class IPlayerNewSplineStopTargetVerify
	{
		// Token: 0x06034389 RID: 213897 RVA: 0x00708AAA File Offset: 0x00706CAA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
