using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005248 RID: 21064
	public static class IFightMusicsSwitchTypeVerify
	{
		// Token: 0x06022442 RID: 140354 RVA: 0x004C09EA File Offset: 0x004BEBEA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
