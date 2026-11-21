using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051C8 RID: 20936
	public static class ISkillUseTypeVerify
	{
		// Token: 0x06020F5E RID: 135006 RVA: 0x0048EB7E File Offset: 0x0048CD7E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
