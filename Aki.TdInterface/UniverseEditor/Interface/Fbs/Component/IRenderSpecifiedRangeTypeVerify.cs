using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005851 RID: 22609
	public static class IRenderSpecifiedRangeTypeVerify
	{
		// Token: 0x060260DE RID: 155870 RVA: 0x0053F2E6 File Offset: 0x0053D4E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
