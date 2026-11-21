using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200460C RID: 17932
	public static class ITargetBattleAttributeVerify
	{
		// Token: 0x0601A395 RID: 107413 RVA: 0x003BBF96 File Offset: 0x003BA196
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
