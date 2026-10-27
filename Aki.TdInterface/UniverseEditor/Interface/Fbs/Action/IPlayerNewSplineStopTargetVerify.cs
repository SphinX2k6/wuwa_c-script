using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D0A RID: 27914
	public static class IPlayerNewSplineStopTargetVerify
	{
		// Token: 0x06031395 RID: 201621 RVA: 0x006AD57A File Offset: 0x006AB77A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
