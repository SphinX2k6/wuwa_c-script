using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078F8 RID: 30968
	public static class ISkillBtnEffectBaseVerify
	{
		// Token: 0x06036888 RID: 223368 RVA: 0x0074CE3E File Offset: 0x0074B03E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
