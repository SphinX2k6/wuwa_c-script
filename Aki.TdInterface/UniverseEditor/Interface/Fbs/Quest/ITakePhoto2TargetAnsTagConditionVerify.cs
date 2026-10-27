using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004192 RID: 16786
	public static class ITakePhoto2TargetAnsTagConditionVerify
	{
		// Token: 0x06018B22 RID: 101154 RVA: 0x0038E751 File Offset: 0x0038C951
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
