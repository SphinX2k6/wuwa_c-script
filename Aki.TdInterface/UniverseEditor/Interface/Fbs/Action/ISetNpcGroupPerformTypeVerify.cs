using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007033 RID: 28723
	public static class ISetNpcGroupPerformTypeVerify
	{
		// Token: 0x06032D01 RID: 208129 RVA: 0x006DAB6E File Offset: 0x006D8D6E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
