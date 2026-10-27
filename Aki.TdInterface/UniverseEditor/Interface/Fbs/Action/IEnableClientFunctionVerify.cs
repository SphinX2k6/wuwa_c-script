using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006656 RID: 26198
	public static class IEnableClientFunctionVerify
	{
		// Token: 0x0602D818 RID: 186392 RVA: 0x0063B45E File Offset: 0x0063965E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
