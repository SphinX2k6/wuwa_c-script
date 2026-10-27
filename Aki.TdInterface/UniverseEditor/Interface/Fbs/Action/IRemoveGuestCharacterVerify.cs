using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E51 RID: 28241
	public static class IRemoveGuestCharacterVerify
	{
		// Token: 0x06031E79 RID: 204409 RVA: 0x006C0A3A File Offset: 0x006BEC3A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
