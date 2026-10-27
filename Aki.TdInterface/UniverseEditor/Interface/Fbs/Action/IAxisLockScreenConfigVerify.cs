using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061DB RID: 25051
	public static class IAxisLockScreenConfigVerify
	{
		// Token: 0x0602B2DA RID: 176858 RVA: 0x005F394C File Offset: 0x005F1B4C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
