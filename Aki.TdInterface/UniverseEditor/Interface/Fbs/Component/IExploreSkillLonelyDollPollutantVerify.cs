using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051F4 RID: 20980
	public static class IExploreSkillLonelyDollPollutantVerify
	{
		// Token: 0x0602212F RID: 139567 RVA: 0x004BA9E2 File Offset: 0x004B8BE2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
