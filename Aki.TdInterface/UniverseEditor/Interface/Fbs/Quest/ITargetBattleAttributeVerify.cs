using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041B3 RID: 16819
	public static class ITargetBattleAttributeVerify
	{
		// Token: 0x06018C3F RID: 101439 RVA: 0x00390B42 File Offset: 0x0038ED42
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
