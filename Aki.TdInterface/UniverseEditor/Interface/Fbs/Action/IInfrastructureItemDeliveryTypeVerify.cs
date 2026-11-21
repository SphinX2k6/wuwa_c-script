using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007012 RID: 28690
	public static class IInfrastructureItemDeliveryTypeVerify
	{
		// Token: 0x06031B63 RID: 203619 RVA: 0x006BB3DA File Offset: 0x006B95DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
