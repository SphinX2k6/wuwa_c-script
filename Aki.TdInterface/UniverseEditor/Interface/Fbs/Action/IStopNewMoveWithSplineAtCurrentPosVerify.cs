using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E0 RID: 29152
	public static class IStopNewMoveWithSplineAtCurrentPosVerify
	{
		// Token: 0x06033B5F RID: 211807 RVA: 0x006F6652 File Offset: 0x006F4852
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
