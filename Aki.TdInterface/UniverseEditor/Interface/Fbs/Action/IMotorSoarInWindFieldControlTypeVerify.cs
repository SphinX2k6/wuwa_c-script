using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B38 RID: 27448
	public static class IMotorSoarInWindFieldControlTypeVerify
	{
		// Token: 0x060302D0 RID: 197328 RVA: 0x0068C2AA File Offset: 0x0068A4AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
