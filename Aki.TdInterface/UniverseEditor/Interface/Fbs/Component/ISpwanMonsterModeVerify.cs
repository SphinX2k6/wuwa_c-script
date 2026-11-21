using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FA1 RID: 24481
	public static class ISpwanMonsterModeVerify
	{
		// Token: 0x060292DB RID: 168667 RVA: 0x0059F41A File Offset: 0x0059D61A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
