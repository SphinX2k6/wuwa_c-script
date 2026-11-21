using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E23 RID: 24099
	public static class IRefreshConditionBaseVerify
	{
		// Token: 0x060283FF RID: 164863 RVA: 0x00580FC2 File Offset: 0x0057F1C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
