using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005777 RID: 22391
	public static class IExploreSkillStatueInteractPointVerify
	{
		// Token: 0x060241BB RID: 147899 RVA: 0x004F7235 File Offset: 0x004F5435
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
