using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F6B RID: 28523
	public static class ISendBattleStateTypeVerify
	{
		// Token: 0x0603264C RID: 206412 RVA: 0x006CD8AA File Offset: 0x006CBAAA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
