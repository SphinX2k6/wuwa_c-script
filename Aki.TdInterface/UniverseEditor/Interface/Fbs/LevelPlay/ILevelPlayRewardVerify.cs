using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200497F RID: 18815
	public static class ILevelPlayRewardVerify
	{
		// Token: 0x0601C11B RID: 114971 RVA: 0x003F7C02 File Offset: 0x003F5E02
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
