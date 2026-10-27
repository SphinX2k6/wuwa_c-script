using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DC7 RID: 28103
	public static class IPromptStyleBaseVerify
	{
		// Token: 0x06031A4A RID: 203338 RVA: 0x006B9B2E File Offset: 0x006B7D2E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
