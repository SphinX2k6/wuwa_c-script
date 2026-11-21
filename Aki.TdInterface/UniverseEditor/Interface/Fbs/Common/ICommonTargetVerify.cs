using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063AC RID: 25516
	public static class ICommonTargetVerify
	{
		// Token: 0x0602B541 RID: 177473 RVA: 0x005E7CC6 File Offset: 0x005E5EC6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
