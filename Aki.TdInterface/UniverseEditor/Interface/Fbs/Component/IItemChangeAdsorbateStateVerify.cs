using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A16 RID: 23062
	public static class IItemChangeAdsorbateStateVerify
	{
		// Token: 0x06025AAF RID: 154287 RVA: 0x00529E0A File Offset: 0x0052800A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
