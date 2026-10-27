using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040A8 RID: 16552
	public static class IRhythmSpaceshipConditionStepBaseVerify
	{
		// Token: 0x060181C6 RID: 98758 RVA: 0x00379FD6 File Offset: 0x003781D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
