using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FCD RID: 28621
	public static class IHonamiStoryActivateSafeEvacuationVerify
	{
		// Token: 0x06031956 RID: 203094 RVA: 0x006B7FFA File Offset: 0x006B61FA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
