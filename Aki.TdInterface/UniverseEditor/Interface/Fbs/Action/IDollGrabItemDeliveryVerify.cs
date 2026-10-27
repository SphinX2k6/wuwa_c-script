using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006602 RID: 26114
	public static class IDollGrabItemDeliveryVerify
	{
		// Token: 0x0602D574 RID: 185716 RVA: 0x00636DC2 File Offset: 0x00634FC2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
