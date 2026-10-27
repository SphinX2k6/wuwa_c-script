using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006536 RID: 25910
	public static class IDaolingAuthenticationVerify
	{
		// Token: 0x0602CF2C RID: 184108 RVA: 0x0062BEBE File Offset: 0x0062A0BE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
