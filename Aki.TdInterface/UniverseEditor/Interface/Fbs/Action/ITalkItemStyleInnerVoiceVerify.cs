using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007AD8 RID: 31448
	public static class ITalkItemStyleInnerVoiceVerify
	{
		// Token: 0x06038303 RID: 230147 RVA: 0x0078FC92 File Offset: 0x0078DE92
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
