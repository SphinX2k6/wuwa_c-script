using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200642D RID: 25645
	public static class IGiantTriggerTypeVerify
	{
		// Token: 0x0602B933 RID: 178483 RVA: 0x005EEE82 File Offset: 0x005ED082
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
