using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D48 RID: 23880
	public static class IBvbBurnBuffTimeUpDataVerify
	{
		// Token: 0x06028D9D RID: 167325 RVA: 0x0059D4BA File Offset: 0x0059B6BA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
