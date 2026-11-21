using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D8A RID: 28042
	public static class IExecClientBattleActionTypeVerify
	{
		// Token: 0x06030652 RID: 198226 RVA: 0x006938C2 File Offset: 0x00691AC2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
