using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006620 RID: 26144
	public static class IDynamicSettlementConfigVerify
	{
		// Token: 0x0602D668 RID: 185960 RVA: 0x0063870E File Offset: 0x0063690E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
