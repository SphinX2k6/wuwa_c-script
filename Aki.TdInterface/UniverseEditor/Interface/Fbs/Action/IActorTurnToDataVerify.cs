using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060FD RID: 24829
	public static class IActorTurnToDataVerify
	{
		// Token: 0x0602A6C8 RID: 173768 RVA: 0x005D856A File Offset: 0x005D676A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
