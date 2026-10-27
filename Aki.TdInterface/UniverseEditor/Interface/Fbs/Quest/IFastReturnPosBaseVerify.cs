using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E26 RID: 15910
	public static class IFastReturnPosBaseVerify
	{
		// Token: 0x060164BC RID: 91324 RVA: 0x00338272 File Offset: 0x00336472
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
