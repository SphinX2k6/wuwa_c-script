using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AE5 RID: 23269
	public static class IMidViewDistanceVerify
	{
		// Token: 0x0602636B RID: 156523 RVA: 0x0053C8E6 File Offset: 0x0053AAE6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
