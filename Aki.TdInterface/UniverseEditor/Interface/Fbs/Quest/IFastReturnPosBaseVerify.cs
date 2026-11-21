using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004261 RID: 16993
	public static class IFastReturnPosBaseVerify
	{
		// Token: 0x06017AE9 RID: 97001 RVA: 0x00360E6A File Offset: 0x0035F06A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
