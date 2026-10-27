using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A42 RID: 23106
	public static class ITeleControlDestroyConditionVerify
	{
		// Token: 0x060274B3 RID: 160947 RVA: 0x005683F2 File Offset: 0x005665F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
