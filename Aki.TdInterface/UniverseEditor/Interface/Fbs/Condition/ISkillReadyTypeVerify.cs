using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CC6 RID: 19654
	public static class ISkillReadyTypeVerify
	{
		// Token: 0x0601F2F8 RID: 127736 RVA: 0x0045A982 File Offset: 0x00458B82
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
