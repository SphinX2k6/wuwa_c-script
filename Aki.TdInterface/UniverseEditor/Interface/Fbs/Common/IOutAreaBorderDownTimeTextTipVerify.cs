using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E17 RID: 24087
	public static class IOutAreaBorderDownTimeTextTipVerify
	{
		// Token: 0x060293DD RID: 168925 RVA: 0x005A83E6 File Offset: 0x005A65E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
