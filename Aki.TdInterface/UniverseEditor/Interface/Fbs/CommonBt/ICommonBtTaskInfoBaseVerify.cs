using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006517 RID: 25879
	public static class ICommonBtTaskInfoBaseVerify
	{
		// Token: 0x0602C1DF RID: 180703 RVA: 0x006027D2 File Offset: 0x006009D2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
