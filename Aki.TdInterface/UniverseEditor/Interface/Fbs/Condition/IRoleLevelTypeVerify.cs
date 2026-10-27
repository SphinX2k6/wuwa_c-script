using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CB7 RID: 19639
	public static class IRoleLevelTypeVerify
	{
		// Token: 0x0601F29C RID: 127644 RVA: 0x0045A18E File Offset: 0x0045838E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
