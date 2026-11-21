using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B14 RID: 27412
	public static class ICommonTipPrepareCountdownVerify
	{
		// Token: 0x0602F221 RID: 193057 RVA: 0x0066D556 File Offset: 0x0066B756
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
