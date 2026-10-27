using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DA2 RID: 23970
	public static class IElementalBoxConfigVerify
	{
		// Token: 0x0602906D RID: 168045 RVA: 0x005A245C File Offset: 0x005A065C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
