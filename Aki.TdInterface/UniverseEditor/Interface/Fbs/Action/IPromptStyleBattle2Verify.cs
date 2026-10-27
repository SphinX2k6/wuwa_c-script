using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DD0 RID: 28112
	public static class IPromptStyleBattle2Verify
	{
		// Token: 0x06031A80 RID: 203392 RVA: 0x006B9FE6 File Offset: 0x006B81E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
