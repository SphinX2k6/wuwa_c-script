using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007108 RID: 28936
	public static class ILiveInteractDanmakuTriggerSkillIdVerify
	{
		// Token: 0x06032420 RID: 205856 RVA: 0x006CBE68 File Offset: 0x006CA068
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
