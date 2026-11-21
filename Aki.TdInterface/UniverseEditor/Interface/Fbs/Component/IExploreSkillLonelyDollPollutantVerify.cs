using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200575C RID: 22364
	public static class IExploreSkillLonelyDollPollutantVerify
	{
		// Token: 0x060240C5 RID: 147653 RVA: 0x004F54A6 File Offset: 0x004F36A6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
