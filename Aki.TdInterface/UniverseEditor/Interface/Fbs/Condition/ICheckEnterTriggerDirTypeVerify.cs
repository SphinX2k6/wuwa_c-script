using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EAD RID: 20141
	public static class ICheckEnterTriggerDirTypeVerify
	{
		// Token: 0x0601F390 RID: 127888 RVA: 0x0045A39A File Offset: 0x0045859A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
