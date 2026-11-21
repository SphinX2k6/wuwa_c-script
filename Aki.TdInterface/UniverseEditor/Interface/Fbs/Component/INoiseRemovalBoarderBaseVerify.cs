using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B9C RID: 23452
	public static class INoiseRemovalBoarderBaseVerify
	{
		// Token: 0x06026A80 RID: 158336 RVA: 0x0054AD92 File Offset: 0x00548F92
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
