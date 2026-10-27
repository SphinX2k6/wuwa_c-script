using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004144 RID: 16708
	public static class IStalkingGamePlayConfigVerify
	{
		// Token: 0x06018811 RID: 100369 RVA: 0x0038815E File Offset: 0x0038635E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
