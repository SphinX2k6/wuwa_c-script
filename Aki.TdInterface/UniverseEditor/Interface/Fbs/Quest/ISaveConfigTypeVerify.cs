using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040FC RID: 16636
	public static class ISaveConfigTypeVerify
	{
		// Token: 0x06018412 RID: 99346 RVA: 0x0037DCF6 File Offset: 0x0037BEF6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
