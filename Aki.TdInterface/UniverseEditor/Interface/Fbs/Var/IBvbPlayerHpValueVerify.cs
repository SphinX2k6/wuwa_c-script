using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A80 RID: 14976
	public static class IBvbPlayerHpValueVerify
	{
		// Token: 0x060144E0 RID: 83168 RVA: 0x002F6B46 File Offset: 0x002F4D46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
