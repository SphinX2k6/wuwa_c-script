using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007287 RID: 29319
	public static class IMotorSoarInWindFieldExitWindFieldVerify
	{
		// Token: 0x06033173 RID: 209267 RVA: 0x006E5176 File Offset: 0x006E3376
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
