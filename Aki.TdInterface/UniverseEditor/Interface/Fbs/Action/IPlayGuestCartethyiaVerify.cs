using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D19 RID: 27929
	public static class IPlayGuestCartethyiaVerify
	{
		// Token: 0x06031403 RID: 201731 RVA: 0x006ADFF2 File Offset: 0x006AC1F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
