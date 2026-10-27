using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004246 RID: 16966
	public static class IUseSkillCheckBaseVerify
	{
		// Token: 0x0601917C RID: 102780 RVA: 0x0039BBDA File Offset: 0x00399DDA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
