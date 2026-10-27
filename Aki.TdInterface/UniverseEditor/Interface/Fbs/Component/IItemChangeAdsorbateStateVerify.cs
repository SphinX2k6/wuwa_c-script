using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005490 RID: 21648
	public static class IItemChangeAdsorbateStateVerify
	{
		// Token: 0x060239F7 RID: 145911 RVA: 0x004ECD96 File Offset: 0x004EAF96
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
