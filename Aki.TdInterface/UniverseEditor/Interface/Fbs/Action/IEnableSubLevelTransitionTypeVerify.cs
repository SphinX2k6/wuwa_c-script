using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D06 RID: 27910
	public static class IEnableSubLevelTransitionTypeVerify
	{
		// Token: 0x06030221 RID: 197153 RVA: 0x0068BED6 File Offset: 0x0068A0D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
