using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006268 RID: 25192
	public static class IBvbUseFieldCardSkillVerify
	{
		// Token: 0x0602B777 RID: 178039 RVA: 0x005FBF3E File Offset: 0x005FA13E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
