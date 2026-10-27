using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006366 RID: 25446
	public static class ICheckFlowLookAtPlayerVerify
	{
		// Token: 0x0602C05E RID: 180318 RVA: 0x0060C93A File Offset: 0x0060AB3A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
