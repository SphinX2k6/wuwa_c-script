using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BA4 RID: 27556
	public static class IDaolingAuthenticationVerify
	{
		// Token: 0x0602F6CA RID: 194250 RVA: 0x0067836A File Offset: 0x0067656A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
