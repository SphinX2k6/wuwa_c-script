using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B0B RID: 31499
	public static class ITalkOptionParamTypeVerify
	{
		// Token: 0x06038B82 RID: 232322 RVA: 0x007AC28A File Offset: 0x007AA48A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
