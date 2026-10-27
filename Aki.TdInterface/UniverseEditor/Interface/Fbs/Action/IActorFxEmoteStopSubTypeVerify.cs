using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020060BE RID: 24766
	public static class IActorFxEmoteStopSubTypeVerify
	{
		// Token: 0x0602A499 RID: 173209 RVA: 0x005D4292 File Offset: 0x005D2492
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
