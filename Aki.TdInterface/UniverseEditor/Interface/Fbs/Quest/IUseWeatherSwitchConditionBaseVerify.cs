using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004267 RID: 16999
	public static class IUseWeatherSwitchConditionBaseVerify
	{
		// Token: 0x0601928E RID: 103054 RVA: 0x0039DBEE File Offset: 0x0039BDEE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
