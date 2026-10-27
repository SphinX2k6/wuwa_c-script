using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B8D RID: 27533
	public static class IMpcEffectParamBaseVerify
	{
		// Token: 0x060305B2 RID: 198066 RVA: 0x00691AE6 File Offset: 0x0068FCE6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
