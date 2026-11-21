using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004928 RID: 18728
	public static class IFindSunSpiritGridEndFloorVerify
	{
		// Token: 0x0601BC90 RID: 113808 RVA: 0x003ED86A File Offset: 0x003EBA6A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
