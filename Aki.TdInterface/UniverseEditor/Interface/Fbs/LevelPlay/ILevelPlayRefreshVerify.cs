using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004976 RID: 18806
	public static class ILevelPlayRefreshVerify
	{
		// Token: 0x0601C0DB RID: 114907 RVA: 0x003F75FA File Offset: 0x003F57FA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
