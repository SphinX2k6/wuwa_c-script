using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045B9 RID: 17849
	public static class ITrapDefenseMonsterGroupVerify
	{
		// Token: 0x0601AFDE RID: 110558 RVA: 0x003D933A File Offset: 0x003D753A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
