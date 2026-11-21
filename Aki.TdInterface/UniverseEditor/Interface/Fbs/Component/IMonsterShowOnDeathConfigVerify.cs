using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B39 RID: 23353
	public static class IMonsterShowOnDeathConfigVerify
	{
		// Token: 0x06026683 RID: 157315 RVA: 0x00542926 File Offset: 0x00540B26
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
