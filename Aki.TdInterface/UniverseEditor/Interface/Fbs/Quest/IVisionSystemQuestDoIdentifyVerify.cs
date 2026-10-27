using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004279 RID: 17017
	public static class IVisionSystemQuestDoIdentifyVerify
	{
		// Token: 0x06019305 RID: 103173 RVA: 0x0039E8A2 File Offset: 0x0039CAA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
