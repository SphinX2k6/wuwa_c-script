using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B34 RID: 19252
	public static class ICheckSubLevelStateConfigVerify
	{
		// Token: 0x0601E4BD RID: 124093 RVA: 0x0043ED73 File Offset: 0x0043CF73
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
