using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005655 RID: 22101
	public static class INpcSpecialMarkIgnoreCameraHideNpcVerify
	{
		// Token: 0x06024BD6 RID: 150486 RVA: 0x00511BAE File Offset: 0x0050FDAE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
