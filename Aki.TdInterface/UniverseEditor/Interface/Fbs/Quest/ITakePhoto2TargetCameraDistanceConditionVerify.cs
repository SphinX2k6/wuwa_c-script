using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004195 RID: 16789
	public static class ITakePhoto2TargetCameraDistanceConditionVerify
	{
		// Token: 0x06018B34 RID: 101172 RVA: 0x0038E8C2 File Offset: 0x0038CAC2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
