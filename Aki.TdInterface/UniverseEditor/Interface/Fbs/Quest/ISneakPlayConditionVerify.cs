using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004576 RID: 17782
	public static class ISneakPlayConditionVerify
	{
		// Token: 0x06019E60 RID: 106080 RVA: 0x003B1A3A File Offset: 0x003AFC3A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
