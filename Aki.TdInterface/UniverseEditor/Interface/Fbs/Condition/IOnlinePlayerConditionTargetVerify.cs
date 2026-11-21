using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005159 RID: 20825
	public static class IOnlinePlayerConditionTargetVerify
	{
		// Token: 0x06020C28 RID: 134184 RVA: 0x00489846 File Offset: 0x00487A46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
