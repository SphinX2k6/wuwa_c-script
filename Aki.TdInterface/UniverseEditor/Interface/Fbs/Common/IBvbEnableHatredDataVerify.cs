using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006382 RID: 25474
	public static class IBvbEnableHatredDataVerify
	{
		// Token: 0x0602B419 RID: 177177 RVA: 0x005E60A2 File Offset: 0x005E42A2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
