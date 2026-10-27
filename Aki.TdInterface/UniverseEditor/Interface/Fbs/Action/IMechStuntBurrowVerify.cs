using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A8A RID: 27274
	public static class IMechStuntBurrowVerify
	{
		// Token: 0x0602FCCB RID: 195787 RVA: 0x006812D2 File Offset: 0x0067F4D2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
