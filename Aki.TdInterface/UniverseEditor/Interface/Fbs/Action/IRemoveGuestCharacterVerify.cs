using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075D2 RID: 30162
	public static class IRemoveGuestCharacterVerify
	{
		// Token: 0x06034EA1 RID: 216737 RVA: 0x0071C53A File Offset: 0x0071A73A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
