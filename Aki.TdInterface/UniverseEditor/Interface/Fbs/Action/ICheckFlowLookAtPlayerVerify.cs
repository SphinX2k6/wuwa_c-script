using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069D7 RID: 27095
	public static class ICheckFlowLookAtPlayerVerify
	{
		// Token: 0x0602E7C8 RID: 190408 RVA: 0x00657A8E File Offset: 0x00655C8E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
