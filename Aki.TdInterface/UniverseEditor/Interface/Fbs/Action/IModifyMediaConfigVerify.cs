using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AC6 RID: 27334
	public static class IModifyMediaConfigVerify
	{
		// Token: 0x0602FE71 RID: 196209 RVA: 0x0068409A File Offset: 0x0068229A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
