using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DB2 RID: 28082
	public static class IProgramSpecialConfigBaseVerify
	{
		// Token: 0x060319A8 RID: 203176 RVA: 0x006B8AF6 File Offset: 0x006B6CF6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
