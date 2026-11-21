using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045DF RID: 17887
	public static class ITakePhoto2SuccessCameraBehaviorBaseVerify
	{
		// Token: 0x0601A20C RID: 107020 RVA: 0x003B8EF2 File Offset: 0x003B70F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
