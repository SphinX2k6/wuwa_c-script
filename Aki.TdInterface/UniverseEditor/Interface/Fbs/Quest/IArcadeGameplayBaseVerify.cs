using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D03 RID: 15619
	public static class IArcadeGameplayBaseVerify
	{
		// Token: 0x060158B4 RID: 88244 RVA: 0x0031CF0E File Offset: 0x0031B10E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
