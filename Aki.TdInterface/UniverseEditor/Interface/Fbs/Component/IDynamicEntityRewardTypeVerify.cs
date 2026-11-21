using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005645 RID: 22085
	public static class IDynamicEntityRewardTypeVerify
	{
		// Token: 0x0602349A RID: 144538 RVA: 0x004DAF32 File Offset: 0x004D9132
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
