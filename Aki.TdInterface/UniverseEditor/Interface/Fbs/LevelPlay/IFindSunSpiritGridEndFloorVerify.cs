using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044C0 RID: 17600
	public static class IFindSunSpiritGridEndFloorVerify
	{
		// Token: 0x0601A4BF RID: 107711 RVA: 0x003C165E File Offset: 0x003BF85E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
