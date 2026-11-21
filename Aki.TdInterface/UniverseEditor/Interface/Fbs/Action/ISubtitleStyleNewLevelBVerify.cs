using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A03 RID: 31235
	public static class ISubtitleStyleNewLevelBVerify
	{
		// Token: 0x06037095 RID: 225429 RVA: 0x0075B30E File Offset: 0x0075950E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
