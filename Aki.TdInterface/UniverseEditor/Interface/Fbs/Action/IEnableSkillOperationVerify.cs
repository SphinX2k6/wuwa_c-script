using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006686 RID: 26246
	public static class IEnableSkillOperationVerify
	{
		// Token: 0x0602D9DC RID: 186844 RVA: 0x0063E7B2 File Offset: 0x0063C9B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
