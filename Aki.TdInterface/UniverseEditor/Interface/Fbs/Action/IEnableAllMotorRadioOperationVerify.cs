using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200664A RID: 26186
	public static class IEnableAllMotorRadioOperationVerify
	{
		// Token: 0x0602D7C8 RID: 186312 RVA: 0x0063AD62 File Offset: 0x00638F62
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
