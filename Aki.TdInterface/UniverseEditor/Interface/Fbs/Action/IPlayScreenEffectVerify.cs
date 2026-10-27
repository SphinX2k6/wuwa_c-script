using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D3D RID: 27965
	public static class IPlayScreenEffectVerify
	{
		// Token: 0x060315D0 RID: 202192 RVA: 0x006B1D94 File Offset: 0x006AFF94
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 10, false) && verifier.VerifyField(tablePos, 12, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
