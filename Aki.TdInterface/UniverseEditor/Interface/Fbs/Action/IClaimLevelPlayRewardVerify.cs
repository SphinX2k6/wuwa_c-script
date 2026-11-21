using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069F2 RID: 27122
	public static class IClaimLevelPlayRewardVerify
	{
		// Token: 0x0602E85C RID: 190556 RVA: 0x0065874A File Offset: 0x0065694A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
