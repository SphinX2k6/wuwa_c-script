using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044B7 RID: 17591
	public static class IFindSunSpiritGridBeginFloorVerify
	{
		// Token: 0x0601A46D RID: 107629 RVA: 0x003C0B46 File Offset: 0x003BED46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
