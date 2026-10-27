using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A74 RID: 14964
	public static class IBvbNpcHpVerify
	{
		// Token: 0x06014498 RID: 83096 RVA: 0x002F6566 File Offset: 0x002F4766
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
