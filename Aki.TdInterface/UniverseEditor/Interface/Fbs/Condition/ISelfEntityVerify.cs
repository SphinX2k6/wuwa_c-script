using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CC3 RID: 19651
	public static class ISelfEntityVerify
	{
		// Token: 0x0601F2E6 RID: 127718 RVA: 0x0045A80A File Offset: 0x00458A0A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
