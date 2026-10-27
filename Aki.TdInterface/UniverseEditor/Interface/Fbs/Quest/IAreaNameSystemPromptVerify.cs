using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D0F RID: 15631
	public static class IAreaNameSystemPromptVerify
	{
		// Token: 0x06015900 RID: 88320 RVA: 0x0031D5CE File Offset: 0x0031B7CE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
