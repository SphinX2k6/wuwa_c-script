using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FFD RID: 28669
	public static class IInfrActivityBuildStageOptionVerify
	{
		// Token: 0x06031AD9 RID: 203481 RVA: 0x006BA7A2 File Offset: 0x006B89A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
