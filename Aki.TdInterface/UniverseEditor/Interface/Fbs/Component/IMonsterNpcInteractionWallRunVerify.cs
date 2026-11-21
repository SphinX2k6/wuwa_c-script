using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B33 RID: 23347
	public static class IMonsterNpcInteractionWallRunVerify
	{
		// Token: 0x0602665F RID: 157279 RVA: 0x005425B2 File Offset: 0x005407B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
