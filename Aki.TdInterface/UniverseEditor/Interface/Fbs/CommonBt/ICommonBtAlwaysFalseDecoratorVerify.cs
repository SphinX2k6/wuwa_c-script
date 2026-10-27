using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005EA4 RID: 24228
	public static class ICommonBtAlwaysFalseDecoratorVerify
	{
		// Token: 0x06029817 RID: 170007 RVA: 0x005AFD8A File Offset: 0x005ADF8A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
