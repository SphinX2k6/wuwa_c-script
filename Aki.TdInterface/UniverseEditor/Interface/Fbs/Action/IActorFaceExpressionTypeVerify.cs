using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060A6 RID: 24742
	public static class IActorFaceExpressionTypeVerify
	{
		// Token: 0x0602A3C5 RID: 172997 RVA: 0x005D28AE File Offset: 0x005D0AAE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
