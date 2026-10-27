using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046F6 RID: 18166
	public static class IGameCurrBreakNodeInfo_RefVarsVerify
	{
		// Token: 0x0601BCEA RID: 113898 RVA: 0x003F1016 File Offset: 0x003EF216
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
