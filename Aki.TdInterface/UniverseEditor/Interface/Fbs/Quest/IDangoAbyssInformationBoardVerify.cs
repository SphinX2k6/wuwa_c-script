using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003DC6 RID: 15814
	public static class IDangoAbyssInformationBoardVerify
	{
		// Token: 0x0601611A RID: 90394 RVA: 0x00330E5A File Offset: 0x0032F05A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
