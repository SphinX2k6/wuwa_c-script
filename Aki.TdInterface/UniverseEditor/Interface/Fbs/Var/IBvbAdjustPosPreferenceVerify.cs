using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E01 RID: 15873
	public static class IBvbAdjustPosPreferenceVerify
	{
		// Token: 0x0601553E RID: 87358 RVA: 0x0031508E File Offset: 0x0031328E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
