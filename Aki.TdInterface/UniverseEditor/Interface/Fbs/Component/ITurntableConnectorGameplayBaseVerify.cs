using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006105 RID: 24837
	public static class ITurntableConnectorGameplayBaseVerify
	{
		// Token: 0x0602A1A3 RID: 172451 RVA: 0x005BF2BE File Offset: 0x005BD4BE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
