using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D08 RID: 19720
	public static class ITriggeredEntityVerify
	{
		// Token: 0x0601F4D1 RID: 128209 RVA: 0x0045DB52 File Offset: 0x0045BD52
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
