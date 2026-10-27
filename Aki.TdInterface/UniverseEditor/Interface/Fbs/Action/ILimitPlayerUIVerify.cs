using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A2E RID: 27182
	public static class ILimitPlayerUIVerify
	{
		// Token: 0x0602F917 RID: 194839 RVA: 0x00679A72 File Offset: 0x00677C72
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
