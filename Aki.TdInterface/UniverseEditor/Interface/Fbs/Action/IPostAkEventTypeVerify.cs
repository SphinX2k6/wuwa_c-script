using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074FA RID: 29946
	public static class IPostAkEventTypeVerify
	{
		// Token: 0x06034843 RID: 215107 RVA: 0x00711CE2 File Offset: 0x0070FEE2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
