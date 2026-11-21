using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B0F RID: 23311
	public static class IMonsterCommunicationGroupConfigVerify
	{
		// Token: 0x060264DB RID: 156891 RVA: 0x0053F28A File Offset: 0x0053D48A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
