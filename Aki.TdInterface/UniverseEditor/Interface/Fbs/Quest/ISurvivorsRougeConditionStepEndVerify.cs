using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004165 RID: 16741
	public static class ISurvivorsRougeConditionStepEndVerify
	{
		// Token: 0x06018969 RID: 100713 RVA: 0x0038AD42 File Offset: 0x00388F42
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
