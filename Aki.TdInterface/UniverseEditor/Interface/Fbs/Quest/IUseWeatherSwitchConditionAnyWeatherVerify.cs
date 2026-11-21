using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046C0 RID: 18112
	public static class IUseWeatherSwitchConditionAnyWeatherVerify
	{
		// Token: 0x0601A9E8 RID: 109032 RVA: 0x003C914E File Offset: 0x003C734E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
