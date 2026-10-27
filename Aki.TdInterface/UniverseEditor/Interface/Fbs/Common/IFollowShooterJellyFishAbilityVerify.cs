using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DB4 RID: 23988
	public static class IFollowShooterJellyFishAbilityVerify
	{
		// Token: 0x060290F1 RID: 168177 RVA: 0x005A32CF File Offset: 0x005A14CF
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyVectorOfData(tablePos, 6, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
