using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B32 RID: 27442
	public static class IMotorSoarInteractVerify
	{
		// Token: 0x060302A8 RID: 197288 RVA: 0x0068BE3A File Offset: 0x0068A03A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
