using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A78 RID: 27256
	public static class IMaxAlertValueVerify
	{
		// Token: 0x0602FBD8 RID: 195544 RVA: 0x0067F00A File Offset: 0x0067D20A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
