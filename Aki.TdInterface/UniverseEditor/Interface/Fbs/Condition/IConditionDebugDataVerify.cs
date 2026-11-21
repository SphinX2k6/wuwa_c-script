using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020050CF RID: 20687
	public static class IConditionDebugDataVerify
	{
		// Token: 0x060207CE RID: 133070 RVA: 0x0047F982 File Offset: 0x0047DB82
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
