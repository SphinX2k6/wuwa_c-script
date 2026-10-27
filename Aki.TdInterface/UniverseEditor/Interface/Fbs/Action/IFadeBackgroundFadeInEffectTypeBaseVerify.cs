using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006767 RID: 26471
	public static class IFadeBackgroundFadeInEffectTypeBaseVerify
	{
		// Token: 0x0602E0D4 RID: 188628 RVA: 0x0064AD7E File Offset: 0x00648F7E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
