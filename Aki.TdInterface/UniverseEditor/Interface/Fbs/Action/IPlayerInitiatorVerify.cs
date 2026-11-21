using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007473 RID: 29811
	public static class IPlayerInitiatorVerify
	{
		// Token: 0x060342FE RID: 213758 RVA: 0x00707AEE File Offset: 0x00705CEE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
