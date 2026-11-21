using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FE0 RID: 24544
	public static class IStreamingRtEffectRefVerify
	{
		// Token: 0x060295A3 RID: 169379 RVA: 0x005A5475 File Offset: 0x005A3675
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
