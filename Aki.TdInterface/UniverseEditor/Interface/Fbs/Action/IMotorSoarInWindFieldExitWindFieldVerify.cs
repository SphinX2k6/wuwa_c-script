using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B41 RID: 27457
	public static class IMotorSoarInWindFieldExitWindFieldVerify
	{
		// Token: 0x0603031C RID: 197404 RVA: 0x0068CBBA File Offset: 0x0068ADBA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
