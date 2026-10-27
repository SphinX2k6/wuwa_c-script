using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DF1 RID: 28145
	public static class IQiuyuanQinggongStraightVerify
	{
		// Token: 0x06031B5A RID: 203610 RVA: 0x006BB2A2 File Offset: 0x006B94A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
