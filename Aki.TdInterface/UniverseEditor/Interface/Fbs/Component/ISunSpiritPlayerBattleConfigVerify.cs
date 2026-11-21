using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200601C RID: 24604
	public static class ISunSpiritPlayerBattleConfigVerify
	{
		// Token: 0x060297AE RID: 169902 RVA: 0x005A939E File Offset: 0x005A759E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
