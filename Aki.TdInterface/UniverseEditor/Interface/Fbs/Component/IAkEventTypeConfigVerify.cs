using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E91 RID: 20113
	public static class IAkEventTypeConfigVerify
	{
		// Token: 0x0601FA6D RID: 129645 RVA: 0x004687A2 File Offset: 0x004669A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
