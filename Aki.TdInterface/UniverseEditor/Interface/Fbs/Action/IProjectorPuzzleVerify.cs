using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DBE RID: 28094
	public static class IProjectorPuzzleVerify
	{
		// Token: 0x06031A0C RID: 203276 RVA: 0x006B95AE File Offset: 0x006B77AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
