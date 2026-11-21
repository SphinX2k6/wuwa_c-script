using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200491F RID: 18719
	public static class IFindSunSpiritGridBeginFloorVerify
	{
		// Token: 0x0601BC3E RID: 113726 RVA: 0x003ECD52 File Offset: 0x003EAF52
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
