using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A28 RID: 27176
	public static class ILimitPlayerOptionVerify
	{
		// Token: 0x0602F8ED RID: 194797 RVA: 0x0067966A File Offset: 0x0067786A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
