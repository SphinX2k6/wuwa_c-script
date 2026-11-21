using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061D0 RID: 25040
	public static class IWuWaGoHintStepInteractVerify
	{
		// Token: 0x0602A92C RID: 174380 RVA: 0x005CE23A File Offset: 0x005CC43A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
