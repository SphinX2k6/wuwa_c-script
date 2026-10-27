using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006372 RID: 25458
	public static class IClaimDungeonRewardVerify
	{
		// Token: 0x0602C0A3 RID: 180387 RVA: 0x0060CF26 File Offset: 0x0060B126
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
