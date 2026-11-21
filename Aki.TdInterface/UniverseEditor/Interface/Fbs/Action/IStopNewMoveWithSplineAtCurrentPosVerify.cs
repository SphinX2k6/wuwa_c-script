using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079B5 RID: 31157
	public static class IStopNewMoveWithSplineAtCurrentPosVerify
	{
		// Token: 0x06036E61 RID: 224865 RVA: 0x007579B2 File Offset: 0x00755BB2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
