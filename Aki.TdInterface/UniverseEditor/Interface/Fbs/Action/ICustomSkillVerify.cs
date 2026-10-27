using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200651B RID: 25883
	public static class ICustomSkillVerify
	{
		// Token: 0x0602CE64 RID: 183908 RVA: 0x0062A824 File Offset: 0x00628A24
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
