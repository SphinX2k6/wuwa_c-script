using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004592 RID: 17810
	public static class IRollBlockItemBaseVerify
	{
		// Token: 0x0601AE7A RID: 110202 RVA: 0x003D6B4E File Offset: 0x003D4D4E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
