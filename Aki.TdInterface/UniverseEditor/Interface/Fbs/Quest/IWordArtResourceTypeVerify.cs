using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004708 RID: 18184
	public static class IWordArtResourceTypeVerify
	{
		// Token: 0x0601AC12 RID: 109586 RVA: 0x003CCFDE File Offset: 0x003CB1DE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
