using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D6F RID: 23919
	public static class IBvbWaitForGameBeginDataVerify
	{
		// Token: 0x06028EAB RID: 167595 RVA: 0x0059ED42 File Offset: 0x0059CF42
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
