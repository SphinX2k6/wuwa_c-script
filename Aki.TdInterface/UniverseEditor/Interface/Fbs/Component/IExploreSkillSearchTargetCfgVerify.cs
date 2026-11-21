using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005771 RID: 22385
	public static class IExploreSkillSearchTargetCfgVerify
	{
		// Token: 0x0602418D RID: 147853 RVA: 0x004F6D2E File Offset: 0x004F4F2E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
