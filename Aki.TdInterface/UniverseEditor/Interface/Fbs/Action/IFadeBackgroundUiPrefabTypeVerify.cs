using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200678E RID: 26510
	public static class IFadeBackgroundUiPrefabTypeVerify
	{
		// Token: 0x0602E1FC RID: 188924 RVA: 0x0064CD7A File Offset: 0x0064AF7A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
