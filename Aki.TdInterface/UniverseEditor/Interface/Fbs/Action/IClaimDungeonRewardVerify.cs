using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069E3 RID: 27107
	public static class IClaimDungeonRewardVerify
	{
		// Token: 0x0602E80D RID: 190477 RVA: 0x0065807A File Offset: 0x0065627A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
