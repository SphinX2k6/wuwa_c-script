using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200621A RID: 25114
	public static class IBossPilingRandomBuffVerify
	{
		// Token: 0x0602B49D RID: 177309 RVA: 0x005F646A File Offset: 0x005F466A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
