using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061D2 RID: 25042
	public static class IAwakePosTypeVerify
	{
		// Token: 0x0602B297 RID: 176791 RVA: 0x005F312A File Offset: 0x005F132A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
