using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046C9 RID: 18121
	public static class IUseWeatherSwitchConditionSpecifiedWeatherVerify
	{
		// Token: 0x0601AA1E RID: 109086 RVA: 0x003C9600 File Offset: 0x003C7800
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
