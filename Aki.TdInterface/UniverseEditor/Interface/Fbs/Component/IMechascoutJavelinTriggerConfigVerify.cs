using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200553B RID: 21819
	public static class IMechascoutJavelinTriggerConfigVerify
	{
		// Token: 0x060240CC RID: 147660 RVA: 0x004FAE4A File Offset: 0x004F904A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
