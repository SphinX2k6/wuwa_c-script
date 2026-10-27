using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D5D RID: 23901
	public static class IBvbRecycleBoardCardDataVerify
	{
		// Token: 0x06028E43 RID: 167491 RVA: 0x0059E4A2 File Offset: 0x0059C6A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
