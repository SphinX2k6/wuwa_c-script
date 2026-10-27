using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200702D RID: 28717
	public static class ISetMoveSpeedVerify
	{
		// Token: 0x06032CC8 RID: 208072 RVA: 0x006DA40E File Offset: 0x006D860E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
