using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054A2 RID: 21666
	public static class IJigsawCompleteConditionVerify
	{
		// Token: 0x06023A97 RID: 146071 RVA: 0x004EE136 File Offset: 0x004EC336
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
