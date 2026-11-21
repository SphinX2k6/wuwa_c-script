using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061BC RID: 25020
	public static class IWuWaGoEntityBaseVerify
	{
		// Token: 0x0602A88E RID: 174222 RVA: 0x005CD0DE File Offset: 0x005CB2DE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
