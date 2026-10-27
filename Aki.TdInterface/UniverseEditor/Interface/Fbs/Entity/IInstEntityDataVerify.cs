using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047E3 RID: 18403
	public static class IInstEntityDataVerify
	{
		// Token: 0x0601C743 RID: 116547 RVA: 0x00406894 File Offset: 0x00404A94
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
