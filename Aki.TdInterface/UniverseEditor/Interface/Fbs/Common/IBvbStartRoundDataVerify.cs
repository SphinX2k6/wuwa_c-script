using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D6C RID: 23916
	public static class IBvbStartRoundDataVerify
	{
		// Token: 0x06028E99 RID: 167577 RVA: 0x0059EBCA File Offset: 0x0059CDCA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
