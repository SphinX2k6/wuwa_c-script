using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004186 RID: 16774
	public static class ITakePhoto2PosConditionVerify
	{
		// Token: 0x06018AB0 RID: 101040 RVA: 0x0038DA3E File Offset: 0x0038BC3E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
