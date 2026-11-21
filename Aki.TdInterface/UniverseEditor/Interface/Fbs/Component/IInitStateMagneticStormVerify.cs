using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059AD RID: 22957
	public static class IInitStateMagneticStormVerify
	{
		// Token: 0x060256D4 RID: 153300 RVA: 0x0052244E File Offset: 0x0052064E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
