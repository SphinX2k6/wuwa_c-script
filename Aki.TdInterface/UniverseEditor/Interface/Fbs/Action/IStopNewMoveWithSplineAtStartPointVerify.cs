using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E6 RID: 29158
	public static class IStopNewMoveWithSplineAtStartPointVerify
	{
		// Token: 0x06033B83 RID: 211843 RVA: 0x006F6942 File Offset: 0x006F4B42
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
