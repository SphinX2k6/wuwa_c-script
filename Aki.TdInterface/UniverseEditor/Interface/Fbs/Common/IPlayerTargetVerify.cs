using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200647E RID: 25726
	public static class IPlayerTargetVerify
	{
		// Token: 0x0602BB6B RID: 179051 RVA: 0x005F29FE File Offset: 0x005F0BFE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
