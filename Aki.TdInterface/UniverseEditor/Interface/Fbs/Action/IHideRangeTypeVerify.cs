using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068F6 RID: 26870
	public static class IHideRangeTypeVerify
	{
		// Token: 0x0602EE04 RID: 192004 RVA: 0x00664F96 File Offset: 0x00663196
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
