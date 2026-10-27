using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A0F RID: 23055
	public static class ISunSpiritPlayerBattleConfigVerify
	{
		// Token: 0x06027236 RID: 160310 RVA: 0x005623DA File Offset: 0x005605DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
