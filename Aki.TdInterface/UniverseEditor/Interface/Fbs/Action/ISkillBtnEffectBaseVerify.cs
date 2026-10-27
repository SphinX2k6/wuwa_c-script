using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200712C RID: 28972
	public static class ISkillBtnEffectBaseVerify
	{
		// Token: 0x060335E6 RID: 210406 RVA: 0x006EC832 File Offset: 0x006EAA32
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
