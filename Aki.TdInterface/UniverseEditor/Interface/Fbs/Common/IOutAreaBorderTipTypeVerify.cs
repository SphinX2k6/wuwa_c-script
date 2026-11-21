using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006460 RID: 25696
	public static class IOutAreaBorderTipTypeVerify
	{
		// Token: 0x0602BAB9 RID: 178873 RVA: 0x005F19C2 File Offset: 0x005EFBC2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
