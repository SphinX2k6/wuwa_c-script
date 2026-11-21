using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006454 RID: 25684
	public static class IOutAreaBorderDownTimeTextTipVerify
	{
		// Token: 0x0602BA67 RID: 178791 RVA: 0x005F1116 File Offset: 0x005EF316
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
