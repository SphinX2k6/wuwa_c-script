using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D1A RID: 19738
	public static class IVisionSkillReadyVerify
	{
		// Token: 0x0601F547 RID: 128327 RVA: 0x0045E612 File Offset: 0x0045C812
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
