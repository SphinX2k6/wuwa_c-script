using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B71 RID: 27505
	public static class ICustomScreenLoadingCyberpunkVerify
	{
		// Token: 0x0602F558 RID: 193880 RVA: 0x00675B82 File Offset: 0x00673D82
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
