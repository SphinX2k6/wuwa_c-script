using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007402 RID: 29698
	public static class IPetalFlyConfigVerify
	{
		// Token: 0x06033F55 RID: 212821 RVA: 0x00701252 File Offset: 0x006FF452
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
