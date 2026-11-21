using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A28 RID: 23080
	public static class IJigsawCompleteConditionVerify
	{
		// Token: 0x06025B4F RID: 154447 RVA: 0x0052B1AA File Offset: 0x005293AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
