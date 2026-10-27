using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004216 RID: 16918
	public static class ITrackRuleTypeBaseVerify
	{
		// Token: 0x0601900A RID: 102410 RVA: 0x003990EA File Offset: 0x003972EA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
