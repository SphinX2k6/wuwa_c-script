using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046A2 RID: 18082
	public static class IUseSkillCheckBaseVerify
	{
		// Token: 0x0601A8E8 RID: 108776 RVA: 0x003C72B2 File Offset: 0x003C54B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
