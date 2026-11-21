using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007593 RID: 30099
	public static class IRecoverDurabilityVerify
	{
		// Token: 0x06034CBB RID: 216251 RVA: 0x00719446 File Offset: 0x00717646
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
