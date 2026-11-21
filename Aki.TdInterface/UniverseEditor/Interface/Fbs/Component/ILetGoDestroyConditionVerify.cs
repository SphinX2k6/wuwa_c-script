using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A43 RID: 23107
	public static class ILetGoDestroyConditionVerify
	{
		// Token: 0x06025CAF RID: 154799 RVA: 0x0052E662 File Offset: 0x0052C862
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
