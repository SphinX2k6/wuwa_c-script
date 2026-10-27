using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006369 RID: 25449
	public static class ICheckFlowLookAtTargetVerify
	{
		// Token: 0x0602C070 RID: 180336 RVA: 0x0060CAB2 File Offset: 0x0060ACB2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
