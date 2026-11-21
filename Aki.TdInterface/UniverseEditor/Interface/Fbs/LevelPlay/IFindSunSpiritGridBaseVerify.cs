using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004919 RID: 18713
	public static class IFindSunSpiritGridBaseVerify
	{
		// Token: 0x0601BC18 RID: 113688 RVA: 0x003EC9CA File Offset: 0x003EABCA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
