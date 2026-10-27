using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004174 RID: 16756
	public static class ISystemPromptTypeVerify
	{
		// Token: 0x060189D8 RID: 100824 RVA: 0x0038B9E2 File Offset: 0x00389BE2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
