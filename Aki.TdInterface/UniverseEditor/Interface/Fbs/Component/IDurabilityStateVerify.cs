using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020050C8 RID: 20680
	public static class IDurabilityStateVerify
	{
		// Token: 0x0602143C RID: 136252 RVA: 0x0049EE8F File Offset: 0x0049D08F
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
