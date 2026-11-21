using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D00 RID: 27904
	public static class IEnableSkillOperationVerify
	{
		// Token: 0x060301F9 RID: 197113 RVA: 0x0068BA66 File Offset: 0x00689C66
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
