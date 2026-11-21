using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B5E RID: 19294
	public static class IGameCurrBreakNodeInfo_RefVarsVerify
	{
		// Token: 0x0601D4BF RID: 119999 RVA: 0x0041D2B2 File Offset: 0x0041B4B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
