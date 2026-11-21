using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200727E RID: 29310
	public static class IMotorSoarInWindFieldControlTypeVerify
	{
		// Token: 0x06033127 RID: 209191 RVA: 0x006E4866 File Offset: 0x006E2A66
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
