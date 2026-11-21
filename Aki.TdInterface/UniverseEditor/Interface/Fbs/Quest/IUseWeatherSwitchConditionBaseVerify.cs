using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046C3 RID: 18115
	public static class IUseWeatherSwitchConditionBaseVerify
	{
		// Token: 0x0601A9FA RID: 109050 RVA: 0x003C92C6 File Offset: 0x003C74C6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
