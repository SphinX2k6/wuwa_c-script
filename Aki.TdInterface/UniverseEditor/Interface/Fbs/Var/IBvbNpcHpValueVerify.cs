using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A77 RID: 14967
	public static class IBvbNpcHpValueVerify
	{
		// Token: 0x060144AA RID: 83114 RVA: 0x002F66DE File Offset: 0x002F48DE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
