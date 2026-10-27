using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ED5 RID: 28373
	public static class IRoadNetworkNavigationTargetVerify
	{
		// Token: 0x0603224A RID: 205386 RVA: 0x006C722A File Offset: 0x006C542A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
