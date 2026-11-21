using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006055 RID: 24661
	public static class ITeleCtrlTriggerConfigVerify
	{
		// Token: 0x06029A4D RID: 170573 RVA: 0x005AF702 File Offset: 0x005AD902
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
