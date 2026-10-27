using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006740 RID: 26432
	public static class IExploreConfigVerify
	{
		// Token: 0x0602DFA0 RID: 188320 RVA: 0x00648AF2 File Offset: 0x00646CF2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
