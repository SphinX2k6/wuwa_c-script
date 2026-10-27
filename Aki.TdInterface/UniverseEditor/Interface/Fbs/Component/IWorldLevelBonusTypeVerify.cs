using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B94 RID: 23444
	public static class IWorldLevelBonusTypeVerify
	{
		// Token: 0x06028236 RID: 164406 RVA: 0x0058448A File Offset: 0x0058268A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
