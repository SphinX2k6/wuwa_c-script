using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200495B RID: 18779
	public static class ILevelPlayInfoMappingBaseVerify
	{
		// Token: 0x0601BFAB RID: 114603 RVA: 0x003F4DF6 File Offset: 0x003F2FF6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
