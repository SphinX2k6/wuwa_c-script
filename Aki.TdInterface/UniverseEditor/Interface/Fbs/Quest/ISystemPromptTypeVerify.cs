using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045B8 RID: 17848
	public static class ISystemPromptTypeVerify
	{
		// Token: 0x0601A0A0 RID: 106656 RVA: 0x003B5F9E File Offset: 0x003B419E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
