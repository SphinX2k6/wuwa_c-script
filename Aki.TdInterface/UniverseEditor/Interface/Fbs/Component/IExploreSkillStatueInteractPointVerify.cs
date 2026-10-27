using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200520F RID: 21007
	public static class IExploreSkillStatueInteractPointVerify
	{
		// Token: 0x06022225 RID: 139813 RVA: 0x004BC771 File Offset: 0x004BA971
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
