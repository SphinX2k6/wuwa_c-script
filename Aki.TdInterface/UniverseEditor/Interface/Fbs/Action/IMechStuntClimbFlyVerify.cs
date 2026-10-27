using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A8D RID: 27277
	public static class IMechStuntClimbFlyVerify
	{
		// Token: 0x0602FCDD RID: 195805 RVA: 0x0068144A File Offset: 0x0067F64A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
