using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E36 RID: 28214
	public static class IReignsTriggerGuideVerify
	{
		// Token: 0x06031D9B RID: 204187 RVA: 0x006BF35A File Offset: 0x006BD55A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
