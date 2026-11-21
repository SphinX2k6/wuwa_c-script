using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A21 RID: 18977
	public static class ITrapDefenseMonsterGroupVerify
	{
		// Token: 0x0601C7B3 RID: 116659 RVA: 0x004055D6 File Offset: 0x004037D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
