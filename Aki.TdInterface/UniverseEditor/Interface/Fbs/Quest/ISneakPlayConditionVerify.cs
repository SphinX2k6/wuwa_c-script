using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004135 RID: 16693
	public static class ISneakPlayConditionVerify
	{
		// Token: 0x060187BD RID: 100285 RVA: 0x00387A32 File Offset: 0x00385C32
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
