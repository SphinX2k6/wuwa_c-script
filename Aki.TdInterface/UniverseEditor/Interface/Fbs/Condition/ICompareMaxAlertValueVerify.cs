using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BB5 RID: 19381
	public static class ICompareMaxAlertValueVerify
	{
		// Token: 0x0601E925 RID: 125221 RVA: 0x00446B0E File Offset: 0x00444D0E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
