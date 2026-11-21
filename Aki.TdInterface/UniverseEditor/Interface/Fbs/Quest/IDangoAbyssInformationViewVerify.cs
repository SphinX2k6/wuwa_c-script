using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041E0 RID: 16864
	public static class IDangoAbyssInformationViewVerify
	{
		// Token: 0x06017665 RID: 95845 RVA: 0x0035835A File Offset: 0x0035655A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
