using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200496F RID: 18799
	public static class IBaseAccessQuestConditionVerify
	{
		// Token: 0x0601D4C9 RID: 120009 RVA: 0x00422026 File Offset: 0x00420226
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
