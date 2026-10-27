using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071E3 RID: 29155
	public static class IStopNewMoveWithSplineAtEndPointVerify
	{
		// Token: 0x06033B71 RID: 211825 RVA: 0x006F67CA File Offset: 0x006F49CA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
