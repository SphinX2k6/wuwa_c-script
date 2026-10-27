using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D8E RID: 28046
	public static class IPreloadCharacterTypeVerify
	{
		// Token: 0x060318B0 RID: 202928 RVA: 0x006B71CE File Offset: 0x006B53CE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
