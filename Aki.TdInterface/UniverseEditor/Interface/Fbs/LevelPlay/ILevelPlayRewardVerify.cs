using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004517 RID: 17687
	public static class ILevelPlayRewardVerify
	{
		// Token: 0x0601A946 RID: 108870 RVA: 0x003CB966 File Offset: 0x003C9B66
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
