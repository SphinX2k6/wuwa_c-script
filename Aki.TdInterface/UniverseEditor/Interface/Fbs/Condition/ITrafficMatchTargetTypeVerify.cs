using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D02 RID: 19714
	public static class ITrafficMatchTargetTypeVerify
	{
		// Token: 0x0601F4B3 RID: 128179 RVA: 0x0045D8DE File Offset: 0x0045BADE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
