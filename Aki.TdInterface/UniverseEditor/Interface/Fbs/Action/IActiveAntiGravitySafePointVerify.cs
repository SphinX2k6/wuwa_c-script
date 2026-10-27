using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006097 RID: 24727
	public static class IActiveAntiGravitySafePointVerify
	{
		// Token: 0x0602A33F RID: 172863 RVA: 0x005D19D2 File Offset: 0x005CFBD2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
