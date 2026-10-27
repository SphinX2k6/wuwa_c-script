using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006408 RID: 25608
	public static class IClientTpToStreamingTargetSuccessEffectVerify
	{
		// Token: 0x0602C4F4 RID: 181492 RVA: 0x00614F9D File Offset: 0x0061319D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
