using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007548 RID: 30024
	public static class IPromptStyleBattleVerify
	{
		// Token: 0x06034A6A RID: 215658 RVA: 0x00715556 File Offset: 0x00713756
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
