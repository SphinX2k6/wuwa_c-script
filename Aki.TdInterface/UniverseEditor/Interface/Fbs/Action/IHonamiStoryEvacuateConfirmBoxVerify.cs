using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FD6 RID: 28630
	public static class IHonamiStoryEvacuateConfirmBoxVerify
	{
		// Token: 0x06031994 RID: 203156 RVA: 0x006B8562 File Offset: 0x006B6762
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
