using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005111 RID: 20753
	public static class IExploreSkillConditionVerify
	{
		// Token: 0x060209FC RID: 133628 RVA: 0x00485D82 File Offset: 0x00483F82
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
