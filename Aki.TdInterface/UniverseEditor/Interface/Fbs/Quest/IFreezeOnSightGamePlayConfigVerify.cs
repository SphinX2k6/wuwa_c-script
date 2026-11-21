using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042AF RID: 17071
	public static class IFreezeOnSightGamePlayConfigVerify
	{
		// Token: 0x06017E9B RID: 97947 RVA: 0x0036A2CE File Offset: 0x003684CE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
