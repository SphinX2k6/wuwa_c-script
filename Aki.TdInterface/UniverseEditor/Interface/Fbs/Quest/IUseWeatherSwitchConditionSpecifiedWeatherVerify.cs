using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200426D RID: 17005
	public static class IUseWeatherSwitchConditionSpecifiedWeatherVerify
	{
		// Token: 0x060192B2 RID: 103090 RVA: 0x0039DF28 File Offset: 0x0039C128
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
