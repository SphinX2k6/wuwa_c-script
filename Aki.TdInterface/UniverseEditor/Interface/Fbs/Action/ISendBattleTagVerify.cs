using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007734 RID: 30516
	public static class ISendBattleTagVerify
	{
		// Token: 0x060358AC RID: 219308 RVA: 0x0072D3EE File Offset: 0x0072B5EE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
