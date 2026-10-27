using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DCD RID: 28109
	public static class IPromptStyleBattleVerify
	{
		// Token: 0x06031A6E RID: 203374 RVA: 0x006B9E6E File Offset: 0x006B806E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
