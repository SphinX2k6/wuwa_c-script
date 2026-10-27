using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D4E RID: 23886
	public static class IBvbEventDataVerify
	{
		// Token: 0x06028DC1 RID: 167361 RVA: 0x0059D7AA File Offset: 0x0059B9AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
