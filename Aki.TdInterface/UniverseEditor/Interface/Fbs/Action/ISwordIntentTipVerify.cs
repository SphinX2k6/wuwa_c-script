using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A4E RID: 31310
	public static class ISwordIntentTipVerify
	{
		// Token: 0x060372EE RID: 226030 RVA: 0x0075F2B6 File Offset: 0x0075D4B6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
