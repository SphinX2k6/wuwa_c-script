using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200419E RID: 16798
	public static class ITakePhoto2TargetPlayMontageConditionVerify
	{
		// Token: 0x06018B92 RID: 101266 RVA: 0x0038F5B9 File Offset: 0x0038D7B9
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
