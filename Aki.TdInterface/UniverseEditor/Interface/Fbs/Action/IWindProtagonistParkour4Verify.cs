using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E20 RID: 32288
	public static class IWindProtagonistParkour4Verify
	{
		// Token: 0x0603A58E RID: 238990 RVA: 0x007DBF0A File Offset: 0x007DA10A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
