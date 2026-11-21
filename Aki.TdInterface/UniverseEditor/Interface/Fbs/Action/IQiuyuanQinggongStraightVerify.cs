using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200756C RID: 30060
	public static class IQiuyuanQinggongStraightVerify
	{
		// Token: 0x06034B56 RID: 215894 RVA: 0x0071698A File Offset: 0x00714B8A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
