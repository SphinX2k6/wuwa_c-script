using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F7C RID: 16252
	public static class IPhoneMessageProgressTypeBaseVerify
	{
		// Token: 0x0601732F RID: 95023 RVA: 0x00358E8A File Offset: 0x0035708A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
