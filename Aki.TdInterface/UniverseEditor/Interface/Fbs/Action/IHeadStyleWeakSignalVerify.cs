using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068DB RID: 26843
	public static class IHeadStyleWeakSignalVerify
	{
		// Token: 0x0602ED15 RID: 191765 RVA: 0x006634F6 File Offset: 0x006616F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
