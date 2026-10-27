using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A35 RID: 14901
	public static class IBvbCardFilterCheckIsCapableToEvolveVerify
	{
		// Token: 0x0601429D RID: 82589 RVA: 0x002F2C54 File Offset: 0x002F0E54
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
