using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FC5 RID: 28613
	public static class ISetBattleTagTypeVerify
	{
		// Token: 0x06032935 RID: 207157 RVA: 0x006D31DA File Offset: 0x006D13DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
