using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200714A RID: 29002
	public static class ISlideRailEndTypeVerify
	{
		// Token: 0x060336A3 RID: 210595 RVA: 0x006EDA4A File Offset: 0x006EBC4A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
