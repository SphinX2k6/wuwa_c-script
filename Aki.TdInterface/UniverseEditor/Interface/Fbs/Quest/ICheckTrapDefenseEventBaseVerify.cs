using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004192 RID: 16786
	public static class ICheckTrapDefenseEventBaseVerify
	{
		// Token: 0x060171E2 RID: 94690 RVA: 0x0034B5EA File Offset: 0x003497EA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
