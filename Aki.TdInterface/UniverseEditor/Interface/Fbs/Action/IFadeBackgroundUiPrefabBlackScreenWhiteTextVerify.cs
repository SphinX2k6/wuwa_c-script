using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200678B RID: 26507
	public static class IFadeBackgroundUiPrefabBlackScreenWhiteTextVerify
	{
		// Token: 0x0602E1EA RID: 188906 RVA: 0x0064CBD4 File Offset: 0x0064ADD4
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
