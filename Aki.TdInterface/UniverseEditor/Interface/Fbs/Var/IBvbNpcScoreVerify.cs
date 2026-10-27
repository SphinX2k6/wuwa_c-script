using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A7A RID: 14970
	public static class IBvbNpcScoreVerify
	{
		// Token: 0x060144BC RID: 83132 RVA: 0x002F6856 File Offset: 0x002F4A56
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
