using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C63 RID: 19555
	public static class IOnlinePlayerConditionTargetHostVerify
	{
		// Token: 0x0601F018 RID: 127000 RVA: 0x00455E6E File Offset: 0x0045406E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
