using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B2D RID: 23341
	public static class IMonsterNpcInteractionHookVerify
	{
		// Token: 0x0602663B RID: 157243 RVA: 0x005422C2 File Offset: 0x005404C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
