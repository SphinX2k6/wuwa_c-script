using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046D5 RID: 18133
	public static class IVisionSystemQuestDoIdentifyVerify
	{
		// Token: 0x0601AA71 RID: 109169 RVA: 0x003C9F7A File Offset: 0x003C817A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
