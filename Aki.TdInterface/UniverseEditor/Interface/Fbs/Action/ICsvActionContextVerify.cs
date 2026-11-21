using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B59 RID: 27481
	public static class ICsvActionContextVerify
	{
		// Token: 0x0602F4AE RID: 193710 RVA: 0x00674BDD File Offset: 0x00672DDD
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
