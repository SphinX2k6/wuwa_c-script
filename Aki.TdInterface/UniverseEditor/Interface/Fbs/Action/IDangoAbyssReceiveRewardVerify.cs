using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BA1 RID: 27553
	public static class IDangoAbyssReceiveRewardVerify
	{
		// Token: 0x0602F6B8 RID: 194232 RVA: 0x00678202 File Offset: 0x00676402
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
