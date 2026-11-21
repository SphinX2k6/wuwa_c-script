using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046CC RID: 18124
	public static class IVisionSystemQuestBaseVerify
	{
		// Token: 0x0601AA30 RID: 109104 RVA: 0x003C9786 File Offset: 0x003C7986
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
