using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005E23 RID: 24099
	public static class IOutAreaBorderTipTypeVerify
	{
		// Token: 0x0602942F RID: 169007 RVA: 0x005A8C92 File Offset: 0x005A6E92
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
