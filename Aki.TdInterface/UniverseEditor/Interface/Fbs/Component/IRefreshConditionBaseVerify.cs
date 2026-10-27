using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200581C RID: 22556
	public static class IRefreshConditionBaseVerify
	{
		// Token: 0x06025EDF RID: 155359 RVA: 0x0053AE36 File Offset: 0x00539036
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
