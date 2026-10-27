using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B46 RID: 19270
	public static class ICheckSystemStateTypeVerify
	{
		// Token: 0x0601E55C RID: 124252 RVA: 0x0044014A File Offset: 0x0043E34A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
