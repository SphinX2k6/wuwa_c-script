using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045EB RID: 17899
	public static class ITakePhoto2TargetAnsTagConditionVerify
	{
		// Token: 0x0601A278 RID: 107128 RVA: 0x003B9BA5 File Offset: 0x003B7DA5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
