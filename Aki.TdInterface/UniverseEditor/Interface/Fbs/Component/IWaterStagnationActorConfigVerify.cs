using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B55 RID: 23381
	public static class IWaterStagnationActorConfigVerify
	{
		// Token: 0x06027FDE RID: 163806 RVA: 0x0057F9C2 File Offset: 0x0057DBC2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
