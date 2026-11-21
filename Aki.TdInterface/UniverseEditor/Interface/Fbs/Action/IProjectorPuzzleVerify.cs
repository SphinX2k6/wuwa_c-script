using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007539 RID: 30009
	public static class IProjectorPuzzleVerify
	{
		// Token: 0x06034A08 RID: 215560 RVA: 0x00714C96 File Offset: 0x00712E96
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
