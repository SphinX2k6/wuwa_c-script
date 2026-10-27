using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006533 RID: 25907
	public static class IDangoAbyssReceiveRewardVerify
	{
		// Token: 0x0602CF1A RID: 184090 RVA: 0x0062BD56 File Offset: 0x00629F56
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
