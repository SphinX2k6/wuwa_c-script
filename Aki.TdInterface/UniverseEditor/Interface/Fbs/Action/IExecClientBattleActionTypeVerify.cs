using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200670A RID: 26378
	public static class IExecClientBattleActionTypeVerify
	{
		// Token: 0x0602DE0E RID: 187918 RVA: 0x006461C2 File Offset: 0x006443C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
