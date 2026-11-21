using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C73 RID: 27763
	public static class IDollGrabItemDeliveryVerify
	{
		// Token: 0x0602FD45 RID: 195909 RVA: 0x0068392A File Offset: 0x00681B2A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
