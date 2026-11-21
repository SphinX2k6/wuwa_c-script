using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A00 RID: 31232
	public static class ISubtitleStyleLevelAVerify
	{
		// Token: 0x06037083 RID: 225411 RVA: 0x0075B196 File Offset: 0x00759396
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
