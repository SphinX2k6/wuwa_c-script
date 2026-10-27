using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A26 RID: 14886
	public static class IBvbAdjustPosPreferenceVerify
	{
		// Token: 0x06014222 RID: 82466 RVA: 0x002F1EA2 File Offset: 0x002F00A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
