using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A48 RID: 23112
	public static class ITeleCtrlTriggerConfigVerify
	{
		// Token: 0x060274D5 RID: 160981 RVA: 0x005686F6 File Offset: 0x005668F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
