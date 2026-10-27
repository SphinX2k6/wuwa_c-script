using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200691A RID: 26906
	public static class IHonamiStoryActivateSafeEvacuationVerify
	{
		// Token: 0x0602EF86 RID: 192390 RVA: 0x00667B12 File Offset: 0x00665D12
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
