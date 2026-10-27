using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006716 RID: 26390
	public static class IExecRiskHarvestEffectVerify
	{
		// Token: 0x0602DE66 RID: 188006 RVA: 0x00646A92 File Offset: 0x00644C92
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
