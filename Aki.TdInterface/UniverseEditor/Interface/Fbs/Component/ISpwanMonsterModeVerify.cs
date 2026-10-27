using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005994 RID: 22932
	public static class ISpwanMonsterModeVerify
	{
		// Token: 0x06026D71 RID: 159089 RVA: 0x005587AE File Offset: 0x005569AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
