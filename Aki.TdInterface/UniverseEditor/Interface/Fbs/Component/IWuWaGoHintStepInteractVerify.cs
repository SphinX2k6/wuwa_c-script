using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BBA RID: 23482
	public static class IWuWaGoHintStepInteractVerify
	{
		// Token: 0x06028368 RID: 164712 RVA: 0x005867AA File Offset: 0x005849AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
