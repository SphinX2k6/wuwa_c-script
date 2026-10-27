using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006563 RID: 25955
	public static class IDelayRemoveTypeVerify
	{
		// Token: 0x0602D081 RID: 184449 RVA: 0x0062E036 File Offset: 0x0062C236
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
