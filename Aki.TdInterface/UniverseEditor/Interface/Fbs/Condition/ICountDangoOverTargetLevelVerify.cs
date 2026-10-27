using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BF1 RID: 19441
	public static class ICountDangoOverTargetLevelVerify
	{
		// Token: 0x0601EC72 RID: 126066 RVA: 0x0044FC54 File Offset: 0x0044DE54
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
