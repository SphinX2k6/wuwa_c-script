using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200450E RID: 17678
	public static class ILevelPlayRefreshVerify
	{
		// Token: 0x0601A906 RID: 108806 RVA: 0x003CB35E File Offset: 0x003C955E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
