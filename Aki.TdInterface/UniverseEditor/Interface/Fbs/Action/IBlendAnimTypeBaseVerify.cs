using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200620E RID: 25102
	public static class IBlendAnimTypeBaseVerify
	{
		// Token: 0x0602B454 RID: 177236 RVA: 0x005F5DFA File Offset: 0x005F3FFA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
