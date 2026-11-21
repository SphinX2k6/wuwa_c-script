using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C91 RID: 27793
	public static class IDynamicSettlementConfigVerify
	{
		// Token: 0x0602FE39 RID: 196153 RVA: 0x00685276 File Offset: 0x00683476
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
