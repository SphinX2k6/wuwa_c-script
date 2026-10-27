using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005209 RID: 21001
	public static class IExploreSkillSearchTargetCfgVerify
	{
		// Token: 0x060221F7 RID: 139767 RVA: 0x004BC26A File Offset: 0x004BA46A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
