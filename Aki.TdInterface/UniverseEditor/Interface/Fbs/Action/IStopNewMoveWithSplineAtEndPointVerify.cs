using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079B8 RID: 31160
	public static class IStopNewMoveWithSplineAtEndPointVerify
	{
		// Token: 0x06036E73 RID: 224883 RVA: 0x00757B2A File Offset: 0x00755D2A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
