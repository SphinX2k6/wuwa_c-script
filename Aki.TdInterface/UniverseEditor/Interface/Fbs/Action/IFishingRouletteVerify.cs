using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067CA RID: 26570
	public static class IFishingRouletteVerify
	{
		// Token: 0x0602E402 RID: 189442 RVA: 0x00650E26 File Offset: 0x0064F026
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
