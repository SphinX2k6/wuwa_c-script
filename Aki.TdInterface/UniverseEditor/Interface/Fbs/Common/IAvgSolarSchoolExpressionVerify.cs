using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005D1B RID: 23835
	public static class IAvgSolarSchoolExpressionVerify
	{
		// Token: 0x06028BAE RID: 166830 RVA: 0x0059804C File Offset: 0x0059624C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyString(tablePos, 12, false) && verifier.VerifyString(tablePos, 14, false) && verifier.VerifyString(tablePos, 16, false) && verifier.VerifyString(tablePos, 18, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
