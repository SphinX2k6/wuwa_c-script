using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004264 RID: 16996
	public static class IUseWeatherSwitchConditionAnyWeatherVerify
	{
		// Token: 0x0601927C RID: 103036 RVA: 0x0039DA76 File Offset: 0x0039BC76
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
