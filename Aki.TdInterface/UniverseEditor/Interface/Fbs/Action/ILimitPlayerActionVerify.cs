using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A13 RID: 27155
	public static class ILimitPlayerActionVerify
	{
		// Token: 0x0602F84E RID: 194638 RVA: 0x0067858A File Offset: 0x0067678A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
