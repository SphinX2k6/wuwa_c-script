using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A88 RID: 27272
	public static class IClientTpToStreamingTargetSuccessEffectVerify
	{
		// Token: 0x0602ECCA RID: 191690 RVA: 0x00660E29 File Offset: 0x0065F029
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
