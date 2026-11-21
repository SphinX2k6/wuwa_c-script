using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048CE RID: 18638
	public static class IDartboardZoneTypeVerify
	{
		// Token: 0x0601B954 RID: 112980 RVA: 0x003E695E File Offset: 0x003E4B5E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
