using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004466 RID: 17510
	public static class IDartboardZoneTypeVerify
	{
		// Token: 0x0601A183 RID: 106883 RVA: 0x003BA752 File Offset: 0x003B8952
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
