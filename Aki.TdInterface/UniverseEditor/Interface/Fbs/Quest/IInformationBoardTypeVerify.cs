using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E9E RID: 16030
	public static class IInformationBoardTypeVerify
	{
		// Token: 0x06016A25 RID: 92709 RVA: 0x00344F62 File Offset: 0x00343162
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
