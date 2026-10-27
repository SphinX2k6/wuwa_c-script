using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A71 RID: 14961
	public static class IBvbNpcCurEnergyVerify
	{
		// Token: 0x06014486 RID: 83078 RVA: 0x002F63EE File Offset: 0x002F45EE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
