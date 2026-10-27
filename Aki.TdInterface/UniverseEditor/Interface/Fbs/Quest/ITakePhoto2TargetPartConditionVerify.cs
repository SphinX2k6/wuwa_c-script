using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200419B RID: 16795
	public static class ITakePhoto2TargetPartConditionVerify
	{
		// Token: 0x06018B7E RID: 101246 RVA: 0x0038F411 File Offset: 0x0038D611
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyVectorOfStrings(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
