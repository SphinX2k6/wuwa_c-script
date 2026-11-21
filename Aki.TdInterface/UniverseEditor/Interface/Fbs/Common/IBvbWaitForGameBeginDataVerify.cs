using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063A6 RID: 25510
	public static class IBvbWaitForGameBeginDataVerify
	{
		// Token: 0x0602B515 RID: 177429 RVA: 0x005E77B2 File Offset: 0x005E59B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
