using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007716 RID: 30486
	public static class ISeasonWeatherUnlockSpecialVerify
	{
		// Token: 0x060357D6 RID: 219094 RVA: 0x0072BE92 File Offset: 0x0072A092
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
