using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006378 RID: 25464
	public static class IClaimDynamicEntityRewardTypeVerify
	{
		// Token: 0x0602C0C7 RID: 180423 RVA: 0x0060D28A File Offset: 0x0060B48A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
