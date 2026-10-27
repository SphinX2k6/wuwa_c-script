using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064B2 RID: 25778
	public static class ICommonTipTypeVerify
	{
		// Token: 0x0602CAEF RID: 183023 RVA: 0x0062201E File Offset: 0x0062021E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
