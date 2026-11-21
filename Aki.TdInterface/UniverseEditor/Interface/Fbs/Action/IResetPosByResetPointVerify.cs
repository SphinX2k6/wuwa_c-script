using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007629 RID: 30249
	public static class IResetPosByResetPointVerify
	{
		// Token: 0x06035142 RID: 217410 RVA: 0x0072106A File Offset: 0x0071F26A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
