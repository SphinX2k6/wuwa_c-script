using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D0B RID: 19723
	public static class IUltimateSkillReadyVerify
	{
		// Token: 0x0601F4E3 RID: 128227 RVA: 0x0045DCCA File Offset: 0x0045BECA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
