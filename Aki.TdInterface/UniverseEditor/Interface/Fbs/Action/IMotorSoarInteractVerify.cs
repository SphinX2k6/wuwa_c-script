using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007278 RID: 29304
	public static class IMotorSoarInteractVerify
	{
		// Token: 0x060330FF RID: 209151 RVA: 0x006E43F6 File Offset: 0x006E25F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
