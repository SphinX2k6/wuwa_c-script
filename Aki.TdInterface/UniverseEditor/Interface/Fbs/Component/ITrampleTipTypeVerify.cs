using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AD1 RID: 23249
	public static class ITrampleTipTypeVerify
	{
		// Token: 0x06027A5F RID: 162399 RVA: 0x00574312 File Offset: 0x00572512
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
