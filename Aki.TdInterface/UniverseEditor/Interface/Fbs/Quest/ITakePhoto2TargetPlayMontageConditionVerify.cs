using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045F7 RID: 17911
	public static class ITakePhoto2TargetPlayMontageConditionVerify
	{
		// Token: 0x0601A2E8 RID: 107240 RVA: 0x003BAA0D File Offset: 0x003B8C0D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
