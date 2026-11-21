using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075B4 RID: 30132
	public static class IReignsTriggerGuideVerify
	{
		// Token: 0x06034DB1 RID: 216497 RVA: 0x0071ACE2 File Offset: 0x00718EE2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
