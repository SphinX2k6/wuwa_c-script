using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200772E RID: 30510
	public static class ISendBattleStateTypeVerify
	{
		// Token: 0x0603588A RID: 219274 RVA: 0x0072D0EA File Offset: 0x0072B2EA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
