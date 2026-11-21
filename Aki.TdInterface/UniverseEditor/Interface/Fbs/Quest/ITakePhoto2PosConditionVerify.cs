using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045D9 RID: 17881
	public static class ITakePhoto2PosConditionVerify
	{
		// Token: 0x0601A1E6 RID: 106982 RVA: 0x003B8BD2 File Offset: 0x003B6DD2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
