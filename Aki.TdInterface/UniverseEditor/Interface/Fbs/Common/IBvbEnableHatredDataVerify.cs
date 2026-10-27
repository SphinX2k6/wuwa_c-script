using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D4B RID: 23883
	public static class IBvbEnableHatredDataVerify
	{
		// Token: 0x06028DAF RID: 167343 RVA: 0x0059D632 File Offset: 0x0059B832
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
