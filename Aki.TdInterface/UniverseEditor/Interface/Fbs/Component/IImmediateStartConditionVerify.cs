using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053EE RID: 21486
	public static class IImmediateStartConditionVerify
	{
		// Token: 0x0602348E RID: 144526 RVA: 0x004E2ABA File Offset: 0x004E0CBA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
