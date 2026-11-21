using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004126 RID: 16678
	public static class IAreaNameSystemPromptVerify
	{
		// Token: 0x06016E38 RID: 93752 RVA: 0x00344846 File Offset: 0x00342A46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
