using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BE2 RID: 19426
	public static class IConditionDebugDataVerify
	{
		// Token: 0x0601EBE8 RID: 125928 RVA: 0x0044C716 File Offset: 0x0044A916
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
