using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005923 RID: 22819
	public static class IHitLogicChangeNextStateVerify
	{
		// Token: 0x06025197 RID: 151959 RVA: 0x0051760A File Offset: 0x0051580A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
