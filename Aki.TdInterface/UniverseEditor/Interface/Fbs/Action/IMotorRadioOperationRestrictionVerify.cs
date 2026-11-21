using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200726F RID: 29295
	public static class IMotorRadioOperationRestrictionVerify
	{
		// Token: 0x060330BF RID: 209087 RVA: 0x006E3C82 File Offset: 0x006E1E82
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
