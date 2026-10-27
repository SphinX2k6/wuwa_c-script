using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B29 RID: 27433
	public static class IMotorRadioOperationRestrictionVerify
	{
		// Token: 0x0603026E RID: 197230 RVA: 0x0068B7FE File Offset: 0x006899FE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
