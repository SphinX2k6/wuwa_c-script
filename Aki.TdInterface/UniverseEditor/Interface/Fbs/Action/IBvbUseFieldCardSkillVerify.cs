using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D9 RID: 26841
	public static class IBvbUseFieldCardSkillVerify
	{
		// Token: 0x0602DED8 RID: 188120 RVA: 0x00646D46 File Offset: 0x00644F46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
