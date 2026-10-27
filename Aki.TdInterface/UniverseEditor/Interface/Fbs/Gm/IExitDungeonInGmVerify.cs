using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200464A RID: 17994
	public static class IExitDungeonInGmVerify
	{
		// Token: 0x0601B420 RID: 111648 RVA: 0x003E0F22 File Offset: 0x003DF122
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
