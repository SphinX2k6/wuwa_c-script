using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063F3 RID: 25587
	public static class IClientSetSeasonStateConfigVerify
	{
		// Token: 0x0602C446 RID: 181318 RVA: 0x0061367A File Offset: 0x0061187A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
