using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067E2 RID: 26594
	public static class IFixTeleControllerResetPosVerify
	{
		// Token: 0x0602E4BE RID: 189630 RVA: 0x006522EA File Offset: 0x006504EA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
