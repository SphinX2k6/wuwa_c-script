using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005454 RID: 21588
	public static class IInteractEntityPartPrefabOptionPointVerify
	{
		// Token: 0x06023828 RID: 145448 RVA: 0x004E9BFA File Offset: 0x004E7DFA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
