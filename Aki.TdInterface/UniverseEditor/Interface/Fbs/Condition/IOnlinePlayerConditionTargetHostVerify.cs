using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200515C RID: 20828
	public static class IOnlinePlayerConditionTargetHostVerify
	{
		// Token: 0x06020C3A RID: 134202 RVA: 0x004899BE File Offset: 0x00487BBE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
