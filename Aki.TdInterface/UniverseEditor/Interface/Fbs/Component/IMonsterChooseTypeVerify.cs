using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200556B RID: 21867
	public static class IMonsterChooseTypeVerify
	{
		// Token: 0x060242D0 RID: 148176 RVA: 0x004FF11A File Offset: 0x004FD31A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
