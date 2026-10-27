using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020044B1 RID: 17585
	public static class IFindSunSpiritGridBaseVerify
	{
		// Token: 0x0601A447 RID: 107591 RVA: 0x003C07BE File Offset: 0x003BE9BE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
