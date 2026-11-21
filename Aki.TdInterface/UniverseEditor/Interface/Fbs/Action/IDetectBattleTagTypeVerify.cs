using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C25 RID: 27685
	public static class IDetectBattleTagTypeVerify
	{
		// Token: 0x0602FA56 RID: 195158 RVA: 0x0067DC3A File Offset: 0x0067BE3A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
