using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065D2 RID: 26066
	public static class IDisableAllMotorRadioOperationVerify
	{
		// Token: 0x0602D349 RID: 185161 RVA: 0x00632492 File Offset: 0x00630692
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
