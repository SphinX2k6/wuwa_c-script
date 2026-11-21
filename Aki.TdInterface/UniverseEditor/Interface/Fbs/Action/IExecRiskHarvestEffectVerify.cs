using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D96 RID: 28054
	public static class IExecRiskHarvestEffectVerify
	{
		// Token: 0x060306AC RID: 198316 RVA: 0x006941D6 File Offset: 0x006923D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
