using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069EF RID: 27119
	public static class IClaimDynamicTrafficRewardVerify
	{
		// Token: 0x0602E84F RID: 190543 RVA: 0x00658652 File Offset: 0x00656852
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
