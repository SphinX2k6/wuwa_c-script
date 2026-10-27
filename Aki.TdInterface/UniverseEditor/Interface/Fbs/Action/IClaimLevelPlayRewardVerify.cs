using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006381 RID: 25473
	public static class IClaimLevelPlayRewardVerify
	{
		// Token: 0x0602C0F2 RID: 180466 RVA: 0x0060D5F6 File Offset: 0x0060B7F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
