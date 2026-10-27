using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070CC RID: 28876
	public static class ISheriffUnlockClueVerify
	{
		// Token: 0x06033251 RID: 209489 RVA: 0x006E5642 File Offset: 0x006E3842
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
