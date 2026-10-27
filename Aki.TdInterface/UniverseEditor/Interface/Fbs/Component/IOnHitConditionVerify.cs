using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200569D RID: 22173
	public static class IOnHitConditionVerify
	{
		// Token: 0x06025019 RID: 151577 RVA: 0x0051C5A5 File Offset: 0x0051A7A5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
