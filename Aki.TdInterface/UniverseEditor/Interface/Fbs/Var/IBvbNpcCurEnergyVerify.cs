using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E4C RID: 15948
	public static class IBvbNpcCurEnergyVerify
	{
		// Token: 0x060157A2 RID: 87970 RVA: 0x003195DA File Offset: 0x003177DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
